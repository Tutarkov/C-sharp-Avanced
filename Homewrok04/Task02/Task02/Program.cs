using ClassLibrary1;

class Program
{
    static void Main(string[] args)
    {
        DogStore dogStore = new DogStore();
        CatStore catStore = new CatStore();
        FishStore fishStore = new FishStore();

        dogStore.PrintPets();
        catStore.PrintPets();
        fishStore.PrintPets();

        dogStore.BuyPet("Rocky");
        catStore.BuyPet("Garfield");

        dogStore.PrintPets();
        catStore.PrintPets();
        fishStore.PrintPets();
    }
}