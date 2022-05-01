namespace PulpCthulhuManager.Models
{
    public class CaratteristicaModel
    {
        public CaratteristicaModel()
        {
        
        }

        public CaratteristicaModel(string nome, string abbreviazione)
        {
            Nome = nome;
            Abbreviazione = abbreviazione;
            Base = 0;
        }

        public string Nome { get; set; } = string.Empty;

        public string Abbreviazione { get; set; } = string.Empty;

        public int Base { get; set; }

        public int Arduo { get => Convert.ToInt32(Base / 2); }

        public int Estremo { get => Convert.ToInt32(Base / 5); }
    }

    //public class CaratteristicaFORModel : CaratteristicaModel
    //{
    //    public CaratteristicaFORModel(int valoreBase) : base(valoreBase)
    //    {
    //    }

    //    public override string Nome { get => "Forza"; }

    //    public override string Abbreviazione { get => "FOR"; }
    //}

    //public class CaratteristicaDESModel : CaratteristicaModel
    //{
    //    public CaratteristicaDESModel(int valoreBase) : base(valoreBase)
    //    {
    //    }

    //    public override string Nome { get => "DES"; }

    //    public override string Abbreviazione { get => "Destrezza"; }
    //}

    //public class CaratteristicaCOSModel : CaratteristicaModel
    //{
    //    public CaratteristicaCOSModel(int valoreBase) : base(valoreBase)
    //    {
    //    }

    //    public override string Nome { get => "COS"; }

    //    public override string Abbreviazione { get => "Costituzione"; }
    //}
}
