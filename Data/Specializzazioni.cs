using PulpCthulhuManager.Models;

namespace PulpCthulhuManager
{
    public class Data
    {
        public static List<SpecializzazioneModel> Specializzazioni
        {
            get => new List<SpecializzazioneModel>()
            {
                new SpecializzazioneModel("Armi da Fuoco (Arco)", 15,true),
                new SpecializzazioneModel("Armi da Fuoco (Armi Pesanti)", 10,true),
                new SpecializzazioneModel("Armi da Fuoco (Lanciafiamme)", 10,true),
                new SpecializzazioneModel("Armi da Fuoco (Mitragliatrice)", 10,true),
                new SpecializzazioneModel("Arti e Mestieri (Barbiere)", 5,false),
                new SpecializzazioneModel("Arti e Mestieri (Belle Arti)", 5,false),
                new SpecializzazioneModel("Arti e Mestieri (Calligrafia)", 5,false),
                new SpecializzazioneModel("Arti e Mestieri (Canto)", 5,false),
                new SpecializzazioneModel("Arti e Mestieri (Carpenteria)", 5,false),
                new SpecializzazioneModel("Arti e Mestieri (Cermaica)", 5,false),
                new SpecializzazioneModel("Arti e Mestieri (Cucinare)", 5,false),
                new SpecializzazioneModel("Arti e Mestieri (Danza)", 5,false),
                new SpecializzazioneModel("Arti e Mestieri (Fabbro)", 5,false),
                new SpecializzazioneModel("Arti e Mestieri (Falsificare)", 5,false),
                new SpecializzazioneModel("Arti e Mestieri (Fotografia)", 5,false),
                new SpecializzazioneModel("Arti e Mestieri (Pittura e Decorazione)", 5,false),
                new SpecializzazioneModel("Arti e Mestieri (Recitare)", 5,false),
                new SpecializzazioneModel("Arti e Mestieri (Restauro)", 5,false),
                new SpecializzazioneModel("Arti e Mestieri (Scrittura)", 5,false),
                new SpecializzazioneModel("Arti e Mestieri (Scultura)", 5,false),
                new SpecializzazioneModel("Combattere (Ascia)", 15,true),
                new SpecializzazioneModel("Combattere (Frusta)", 5,true),
                new SpecializzazioneModel("Combattere (Garrota)", 15,true),
                new SpecializzazioneModel("Combattere (Lancia)", 20,true),
                new SpecializzazioneModel("Combattere (Mazzafrusto)", 10,true),
                new SpecializzazioneModel("Combattere (Motosega)", 10,true),
                new SpecializzazioneModel("Combattere (Spada)", 20,true),                
            };
        }
    }
}
