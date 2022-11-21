namespace Models {
    public class WiskundeServiceImpl : IWiskundeServiceContract {
        public Vergelijking maakVergelijking(string vergelijking){
            return new Vergelijking(vergelijking);
        }

        public string afleiding(string wiskunde){
            Vergelijking vergelijking = new Vergelijking(wiskunde);
            return vergelijking.afleiding();
        }
    }
}