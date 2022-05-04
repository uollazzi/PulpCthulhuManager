namespace PulpCthulhuManager.Models
{
    public class ArmaModel
    {
        public ArmaModel()
        {

        }

        public ArmaModel(string nome, string nomeAbilita)
        {
            Nome = nome;
            NomeAbilita = nomeAbilita;            
        }
        public string Nome { get; set; } = string.Empty;

        public string NomeAbilita { get; set; } = string.Empty;
    }

}
