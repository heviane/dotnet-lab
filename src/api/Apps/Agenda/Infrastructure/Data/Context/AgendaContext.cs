using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Agenda.Domain.Entities;

// Injeção de Dependência: O AgendaContext é injetado no construtor, facilitando testes e desacoplando o controller.

namespace Agenda.Infraestructure.Data.Context;

/// <summary>
/// Representa o contexto do banco de dados para a aplicação Agenda.
/// Esta classe é a ponte entre as entidades do domínio (como <see cref="Contact"/>) e o banco de dados.
/// </summary>
public class AgendaContext : DbContext
{
    /// <summary>
    /// Inicializa uma nova instância da classe <see cref="AgendaContext"/>.
    /// </summary>
    /// <param name="options">As opções a serem usadas pelo DbContext, geralmente injetadas via DI.</param>
    public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
    {
    }

    /// <summary>
    /// Obtém ou define o DbSet que representa a tabela de Contatos no banco de dados.
    /// Através desta propriedade, é possível realizar operações de CRUD (Create, Read, Update, Delete) na tabela de contatos.
    /// </summary>
    public DbSet<ContactEntity> Contacts { get; set; }
}
