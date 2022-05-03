namespace PokeDL
{
    //THis class is responsible for storing and reading our data
    public class Repository 
    {
        private string _filepath = "../PokeDL/Data/Pokemon.json";
        //purpose of this method is to add a pokemon to our data
        public void AddPokemon(Pokemon p_poke)
        {
            List<AddPokemon> ListOfPoke = new List<Pokemon>();
            ListOfPoke.ADD(p_poke);

            string jsonString = JsonSerializer.Serializer(ListOfPoke)           
        }
    }
}