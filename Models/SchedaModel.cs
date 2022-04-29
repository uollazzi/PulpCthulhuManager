namespace PulpCthulhuManager.Models
{    
    public class SchedaModel
    {
        public string Nome { get; set; } = string.Empty;

        public string Giocatore { get; set; } = string.Empty;

        public string Professione { get; set; } = string.Empty;

        public int Eta { get; set; }

        public string Sesso { get; set; } = string.Empty;

        public string Archetipo { get; set; } = string.Empty;

        public string Residenza { get; set; } = string.Empty;

        public string LuogoNascita { get; set; } = string.Empty;

        public CaratteristicaModel FOR { get; set; } = new CaratteristicaModel("Forza", "FOR");

        public CaratteristicaModel DES { get; set; } = new CaratteristicaModel("Destrezza", "DES");

        public CaratteristicaModel COS { get; set; } = new CaratteristicaModel("Costituzione", "COS");
    }
}
