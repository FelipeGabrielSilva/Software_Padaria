
namespace WindowsForm_Padaria
{
    public class ExibindoLogError
    {
        public void Exibir(Exception ex)
        {
            string log = $"[{DateTime.Now}] Erro: {ex.Message}\nStackTrace: {ex.StackTrace}";
            if (ex.InnerException != null)
            {
                log += $"\nInner: {ex.InnerException.Message}";
            }

            File.AppendAllText("log.txt", log + "\n\n");
            MessageBox.Show(log, "Erro ao criar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}