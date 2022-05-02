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
            new AbilitaModel("Archeologia", 1),
            new AbilitaModel("Armi da Fuoco (Fucile/Shotgun)", 25, true),
            new AbilitaModel("Armi da Fuoco (Pistola)", 25, true),
            new AbilitaModel("Armi da Fuoco (Mitra)", 15, true),
            new AbilitaModel("Arti e Mestieri", 5),
            new AbilitaModel("Ascoltare", 20),
            new AbilitaModel("Biblioteconomia", 20),
            new AbilitaModel("Cammuffare", 5),
            new AbilitaModel("Cavalcare", 5),
            new AbilitaModel("Combattere (Rissa)", 1, true),
            new AbilitaModel("Contabilità", 5),
            new AbilitaModel("Demolizioni", 1),
            new AbilitaModel("Furtività", 20),
            new AbilitaModel("Guidare Auto", 20),
            new AbilitaModel("Immersione", 1),
            new AbilitaModel("Individuare", 25),
            new AbilitaModel("Lanciare", 20),
            new AbilitaModel("Legge", 5),
            new AbilitaModel("Leggere Labbra", 1),
            new AbilitaModel("Lingua (Altra)", 1),
            new AbilitaModel("Lingua (Madre)(IST)", 1),
            new AbilitaModel("Manovrare Macchinari Pesanti", 1),
            new AbilitaModel("Medicina", 1),
            new AbilitaModel("Miti di Cthulhu", 0),
            new AbilitaModel("Naturalistica", 10),
            new AbilitaModel("Navigare", 10),
            new AbilitaModel("Nuotare", 20),
            new AbilitaModel("Occultismo", 5),
            new AbilitaModel("Persuadere", 10),
            new AbilitaModel("Pilotare", 1),
            new AbilitaModel("Pronto Soccorso", 30),
            new AbilitaModel("Psicoanalisi", 1),
            new AbilitaModel("Psicologia", 10),
            new AbilitaModel("Raggirare", 5),
            new AbilitaModel("Rapidità di Mano", 10),
            new AbilitaModel("Riparazioni Elettriche", 10),
            new AbilitaModel("Riparazioni Meccaniche", 10),
            new AbilitaModel("Saltare", 20),
            new AbilitaModel("Scalare", 20),
            new AbilitaModel("Scassinare", 1),
            new AbilitaModel("Schivare", 0),
            new AbilitaModel("Scienza", 1),
            new AbilitaModel("Seguire Tracce", 10),
            new AbilitaModel("Sopravvivenza", 10),
            new AbilitaModel("Storia", 5),
            new AbilitaModel("Usare Computer", 0),
            new AbilitaModel("Valore Credito", 0),
            new AbilitaModel("Valutare", 5)
        };
        #endregion
    }
}
