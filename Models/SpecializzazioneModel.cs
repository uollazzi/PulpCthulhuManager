namespace PulpCthulhuManager.Models
{
    public class SpecializzazioneModel
    {   
        public SpecializzazioneModel(string nome, int valoreDefault = 0, bool combattimento = false)
        {
            Nome = nome;
            Base = valoreDefault;
            Combattimento = combattimento;            
        }
        public string Nome { get; set; } = string.Empty;

        public int Base { get; set; }

        public bool Combattimento { get; set; } = false;
    }

}
