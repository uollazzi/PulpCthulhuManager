namespace PulpCthulhuManager.Models
{
    public class SchedaModel
    {
        #region Anagrafica
        public string Nome { get; set; } = string.Empty;
        public string Giocatore { get; set; } = string.Empty;
        public string Professione { get; set; } = string.Empty;
        public int Eta { get; set; }
        public string Sesso { get; set; } = string.Empty;
        public string Archetipo { get; set; } = string.Empty;
        public string Residenza { get; set; } = string.Empty;
        public string LuogoNascita { get; set; } = string.Empty;
        #endregion

        #region Caratteristiche        
        public CaratteristicaModel FOR { get; set; } = new CaratteristicaModel("Forza", "FOR");
        public CaratteristicaModel DES { get; set; } = new CaratteristicaModel("Destrezza", "DES");
        public CaratteristicaModel INT { get; set; } = new CaratteristicaModel("Intelligenza", "INT");
        public CaratteristicaModel COS { get; set; } = new CaratteristicaModel("Costituzione", "COS");
        public CaratteristicaModel FAS { get; set; } = new CaratteristicaModel("Fascino", "FAS");
        public CaratteristicaModel POT { get; set; } = new CaratteristicaModel("Potenza", "POT");
        public CaratteristicaModel TAG { get; set; } = new CaratteristicaModel("Taglia", "TAG");
        public CaratteristicaModel IST { get; set; } = new CaratteristicaModel("Istruzione", "IST");
        #endregion

        #region Abilita
        public List<AbilitaModel> Abilita { get; set; } = new List<AbilitaModel>()
        {
            new AbilitaModel("Ammaliare", 15),
            new AbilitaModel("Archeologia", 1)
        };
        #endregion
    }
}
