namespace PokeModel
{
        public class Pokemon
        {

        
            private int _pokeId;
            //this is a property
            //I want pokeID to only hold psotive numbers
            public int PokeID
            {
                get { return _pokeId; }
                set 
                {
                    if (value > 0)
                    {
                        _pokeId = value;
                    }
                    else
                    {
                        Console.WriteLine("Poke id can only  hold postive numbers (value > 0");
                    }
                }
            }
                               
            public string Name { get; set; }
            
            public string Type { get; set; }

            public List<Ability> Abilities { get; set;}           

            public Pokemon()
            {
                PokeID = 1;
                Name = "Ditto";
                Type = "Neutral";
                Abilities = new List<Ability>();
            }       
    }
}
