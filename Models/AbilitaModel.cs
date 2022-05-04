namespace PulpCthulhuManager.Models
{
    public class AbilitaModel
    {
        public AbilitaModel()
        {

        }

        public AbilitaModel(string nome, int valoreDefault = 0, bool combattimento = false, string tag = "", bool custom = false)
        {
            Nome = nome;
            Base = valoreDefault;
            Combattimento = combattimento;
            Tag = tag;
            Custom = custom;
        }
        public string Nome { get; set; } = string.Empty;

        public int Base { get; set; }

        public int Arduo { get => Convert.ToInt32(Base / 2); }

        public int Estremo { get => Convert.ToInt32(Base / 5); }

        public bool Utilizzata { get; set; } = false;

        public bool Combattimento { get; set; } = false;

        public string Tag { get; set; } = string.Empty;

        public bool Custom { get; set; } = false;
    }

}
