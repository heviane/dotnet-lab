using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Agenda.Infraestructure.Data.Context;
using Agenda.Domain.Entities;

namespace Agenda.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        // ---- Injeção de dependência
        // AgendaContext é injetado no construtor, facilitando testes e desacoplando o controller.

        private readonly AgendaContext _context;

        public ContactController(AgendaContext context)
        {
            _context = context;
        }

        // ---- end points para o CRUD de Contatos

        // IActionResult retorna um resultado HTTP

        // POST: api/Contact
        [HttpPost]
        public IActionResult Create(ContactEntity contact)
        {
            _context.Add(contact);
            _context.SaveChanges();

            // Retorna 201 Created com a localização do novo recurso.
            // O 'nameof(GetById)' cria um link para o futuro endpoint que buscará o contato pelo ID.
            return CreatedAtAction(nameof(GetById), new { id = contact.Id }, contact);

            // Vai retornar no "Response headers > location" a url para acessar o contato criado pelo Id.
        }

        // GET: api/Contact/5
        // Adicionada restrição de rota ":int" para que este endpoint só seja acionado por valores inteiros.
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var contact = _context.Contacts.Find(id);
            return contact == null ? NotFound() : Ok(contact);
        }

        // GET: api/Contact/Maria
        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            // var contact = _context.Contacts.Where(c => c.Name == name).FirstOrDefault();
            var contact = _context.Contacts.Where(c => c.Name.Contains(name));
            return contact == null ? NotFound() : Ok(contact);
        }

        // GET: api/Contact
        [HttpGet]
        public IActionResult GetAll()
        {
            var contacts = _context.Contacts.ToList();
            return Ok(contacts);
        }

        // PUT: api/Contact/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, ContactEntity contact)
        {
            // Busca o contato existente no banco de dados pelo ID fornecido na URL.
            var contactInDb = _context.Contacts.Find(id);

            // Se o contato não for encontrado, retorna um erro 404 Not Found.
            if (contactInDb == null)
            {
                return NotFound();
            }

            // Atualiza as propriedades do contato encontrado com os dados recebidos no corpo da requisição.
            contactInDb.Name = contact.Name;
            contactInDb.Phone = contact.Phone;
            contactInDb.Email = contact.Email;
            contactInDb.IsActive = contact.IsActive;

            // Salva as alterações no banco de dados.
            _context.SaveChanges();

            // Retorna 204 No Content, indicando que a operação foi bem-sucedida, mas não há conteúdo para retornar.
            return NoContent();
        }

        // PATCH: api/Contact/5
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, ContactEntity contactUpdate)
        {
            // Busca o contato existente no banco de dados pelo ID.
            var contactInDb = _context.Contacts.Find(id);

            // Se o contato não for encontrado, retorna um erro 404 Not Found.
            if (contactInDb == null)
            {
                return NotFound();
            }

            // Aplica as atualizações parciais: apenas phone e email.
            // Os outros campos (name, isActive) são ignorados.
            contactInDb.Phone = contactUpdate.Phone;
            contactInDb.Email = contactUpdate.Email;

            // Salva as alterações no banco de dados.
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Busca o contato existente no banco de dados pelo ID.
            var contactInDb = _context.Contacts.Find(id);

            // Se o contato não for encontrado, retorna um erro 404 Not Found.
            if (contactInDb == null)
            {
                return NotFound();
            }

            // Remove o contato do contexto do EF.
            _context.Contacts.Remove(contactInDb);
            _context.SaveChanges();

            // Retorna 204 No Content, indicando que a operação foi bem-sucedida.
            return NoContent();
        }
    }
}
