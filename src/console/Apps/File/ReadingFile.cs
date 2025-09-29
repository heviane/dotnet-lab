namespace File
{
    /// <summary>
    /// Encapsula a lógica de leitura de arquivos.
    /// </summary>
    public class ReadingFile
    {
        /// <summary>
        /// Lê todas as linhas de um arquivo de forma segura, sem lançar exceções para o chamador.
        /// </summary>
        /// <param name="path">O caminho completo para o arquivo.</param>
        /// <returns>Uma tupla contendo o sucesso da operação, as linhas do arquivo (se bem-sucedido) e a exceção (se falhar).</returns>
        public (bool Success, string[]? Lines, Exception? Error) ReadFile(string path)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(path);
                return (true, lines, null); // Retornando uma tupla.
            }
            catch (Exception ex) { return (false, null, ex); }
        }
    }
}
