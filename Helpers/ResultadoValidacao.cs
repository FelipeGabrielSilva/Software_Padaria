namespace WindowsForm_Padaria
{
    public class ResultadoValidacao
    {
        public bool Valido => !Erros.Any();
        public List<string> Erros { get; } = new List<string>();
    }
}