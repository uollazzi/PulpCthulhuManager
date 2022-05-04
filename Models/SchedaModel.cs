namespace PulpCthulhuManager.Models
{
    public class SchedaModel
    {
        const string TAG_MITI_CTHULHU = "MITI_CTHULHU";
        const string TAG_SCHIVARE = "SCHIVARE";

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
            new AbilitaModel("Ascoltare", 20),
            new AbilitaModel("Biblioteconomia", 20),
            new AbilitaModel("Cammuffare", 5),
            new AbilitaModel("Cavalcare", 5),
            new AbilitaModel("Combattere (Rissa)", 25, true),
            new AbilitaModel("Contabilità", 5),
            new AbilitaModel("Demolizioni", 1),
            new AbilitaModel("Furtività", 20),
            new AbilitaModel("Guidare Auto", 20),
            new AbilitaModel("Immersione", 1),
            new AbilitaModel("Individuare", 25),
            new AbilitaModel("Lanciare", 20),
            new AbilitaModel("Legge", 5),
            new AbilitaModel("Leggere Labbra", 1),
            new AbilitaModel("Lingua (Madre)(IST)", 1),
            new AbilitaModel("Manovrare Macchinari Pesanti", 1),
            new AbilitaModel("Medicina", 1),
            new AbilitaModel("Miti di Cthulhu", 0, false, TAG_MITI_CTHULHU),
            new AbilitaModel("Naturalistica", 10),
            new AbilitaModel("Navigare", 10),
            new AbilitaModel("Nuotare", 20),
            new AbilitaModel("Occultismo", 5),
            new AbilitaModel("Persuadere", 10),
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
            new AbilitaModel("Schivare", 0, false, TAG_SCHIVARE),
            new AbilitaModel("Seguire Tracce", 10),
            new AbilitaModel("Storia", 5),
            new AbilitaModel("Usare Computer", 0),
            new AbilitaModel("Valore Credito", 0),
            new AbilitaModel("Valutare", 5)
        };
        #endregion

        #region Tattiche
        public string BonusDanno
        {
            get => CalcolaBonusDannoStruttura().BonusDanno;
        }

        public int Struttura { get => CalcolaBonusDannoStruttura().Struttura; }

        public int Movimento
        {
            get
            {
                if (DES.Base < TAG.Base && FOR.Base < TAG.Base)
                {
                    return 7;
                }
                else if (DES.Base > TAG.Base && FOR.Base > TAG.Base)
                {
                    return 9;
                }
                else { return 8; }
            }
        }

        public int PuntiFeritaMassimi { get => (int)Math.Round((double)(COS.Base + TAG.Base) / 5, MidpointRounding.ToEven); }

        private int puntiFeritaAttuali;
        public int PuntiFeritaAttuali
        {
            get { return puntiFeritaAttuali; }
            set
            {
                if (value > PuntiFeritaMassimi)
                    value = PuntiFeritaMassimi;

                if (value < 0)
                    value = 0;

                puntiFeritaAttuali = value;
            }
        }

        public int PuntiMagiaMassimi { get => (int)Math.Round((double)(POT.Base / 5), MidpointRounding.ToEven); }
        private int puntiMagiaAttuali;
        public int PuntiMagiaAttuali
        {
            get { return puntiMagiaAttuali; }
            set
            {
                if (value > PuntiMagiaMassimi)
                    value = PuntiMagiaMassimi;

                if (value < 0)
                    value = 0;

                puntiMagiaAttuali = value;
            }
        }

        public int Sanita { get; set; }
        public int SanitaIniziale { get; set; }
        public int SanitaMassima { get => 99 - Abilita.Single(a => a.Tag == TAG_MITI_CTHULHU).Base; }
        public bool TemporaneamentePazzo { get; set; } = false;
        public bool PermanentementePazzo { get; set; } = false;
        public bool Morente { get => PuntiFeritaAttuali <= 0; }
        public int Fortuna { get; set; }

        public List<ArmaModel> Armi = new List<ArmaModel>() {
            new ArmaModel("Disarmato", "Combattere (Rissa)")
        };

        private (string BonusDanno, int Struttura) CalcolaBonusDannoStruttura()
        {
            (string BonusDanno, int Struttura) retval = ("Nessuno", 0);
            var forTag = FOR.Base + TAG.Base;

            if (forTag <= 64)
            {
                retval.BonusDanno = "-2";
                retval.Struttura = -2;
            }
            else if (forTag <= 84)
            {
                retval.BonusDanno = "-1";
                retval.Struttura = -1;
            }
            else if (forTag <= 124)
            {
                retval.BonusDanno = "Nessuno";
                retval.Struttura = 0;
            }
            else if (forTag <= 164)
            {
                retval.BonusDanno = "+1D4";
                retval.Struttura = 1;
            }
            else if (forTag <= 204)
            {
                retval.BonusDanno = "+1D6";
                retval.Struttura = 2;
            }
            else
            {
                var multiplo = (int)Math.Ceiling(((double)forTag - 204) / 80);
                retval.BonusDanno = $"+{1 + multiplo}D6";
                retval.Struttura = 2 + multiplo;
            }

            return retval;
        }
        #endregion
    }
}
