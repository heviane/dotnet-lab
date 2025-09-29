using System;

namespace Models.Exceptions
{
    /// <summary>
    /// Classe de exceção customizada
    /// Exceção lançada quando uma tentativa de saque é maior que o saldo disponível.
    /// </summary>
    public class SaldoInsuficienteException : Exception
    {
        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="SaldoInsuficienteException"/>.
        /// </summary>
        public SaldoInsuficienteException() { }

        public SaldoInsuficienteException(string message) : base(message) { }

        public SaldoInsuficienteException(string message, Exception innerException) : base(message, innerException) { }
    }
}
