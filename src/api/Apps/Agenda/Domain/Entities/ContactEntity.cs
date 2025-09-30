using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Domain.Entities
{
    /// <summary>
    /// Representa a entidade Contato no domínio da aplicação.
    /// </summary>
    public class ContactEntity
    {
        /// <summary>
        /// Identificador único do contato. Chave primária.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do contato.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Número de telefone do contato.
        /// </summary>
        public string? Phone { get; set; }

        /// <summary>
        /// Endereço de e-mail do contato.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Indica se o contato está ativo.
        /// </summary>
        public bool IsActive { get; set; }
    }
}
