namespace PulpCthulhuManager.Models
{
    public class ArmaModel
    {
        public ArmaModel()
        {

        }

        public ArmaModel(string nome, string nomeAbilita, string danni = "", string attacchi = "", bool applicaBonusDanno = false)
        {
            Nome = nome;
            NomeAbilita = nomeAbilita;
            ApplicaBonusDanno = applicaBonusDanno;
            Danni = danni;
            Attacchi = attacchi;
        }
        public string Nome { get; set; } = string.Empty;
        public string NomeAbilita { get; set; } = string.Empty;
        public bool ApplicaBonusDanno { get; set; } = false;
        public string Danni { get; set; } = string.Empty;
        public string Gittata { get; set; } = string.Empty;
        public string Attacchi { get; set; } = string.Empty;
        public int Munizioni { get; set; }
        public int Malfunzionamento { get; set; }
    }

}
