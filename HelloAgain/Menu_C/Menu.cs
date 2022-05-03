// See https://aka.ms/new-console-template for more informationConsole.WriteLine("Welcome to my store!");
Console.WriteLine("Welcome to my store!");
Menu MenuObj = new Menu();
bool repeat = true;
int total = 0
while (repeat)
    {
        Console.WriteLine("Enter 1 to enter list");
        Console.WriteLine("Enter 2 to exit menu");
        string answer = Console.ReadLine();
        if (answer == "1")
        {
            while (repeat)
            {
                Console.WriteLine("Choose items");
                Console.WriteLine("1. Milk");
                Console.WriteLine("2. Cheese");
                Console.WriteLine("3. Eggs");
                Console.WriteLine("4. Bread");
                
            }
        }
    }

public class NewBaseType
{
    private string _grain = "Bread";

    private string _dairy = "Milk";

    private string _meat = "Bacon";

    private string _dairy2 = "Cheese";
    //This is a property
    //  Gives us the flexibility to check that the data stored is correct, let only things access data, makes things read or write
    public string Owner
    {
        //get keyword is this is how the data is going to be shared
        get { return _owner + "is the new owner"; }

        //set keyword is how you change the data that is being stored
        set { _owner = value + " Owner"; }
    }
    public int Fuel
    {
        get { return _fuel; }
        set
        {
            if (value <= 100 && value >= 0)
            {
                _fuel = value;
            }
            else
            {
                Console.WriteLine("Fuel can only hold from 0-100");
            }
        }
    }

    //Methods can also have parameters
    //parameters are implemented by adding in datatypes of the paenthesis
    public void Sum(int num1, int num2)
    {
        Console.WriteLine(num1 + num2);
    }
    //This is a field
    //its used to store information or used to define the current state of the object.
    //By default , fields should all be private

    //This is a method
    //A way to represent behavior/function and it will create multiple lines of code.
    public int TotalDistancedotPerFuel()
    {
        Console.WriteLine("Current Fuel:" + _fuel);
        Console.WriteLine("Gallon Per Mile:" + _gallonPerMile);

        Console.WriteLine(_fuel / _gallonPerMile + "This is how many miles");

        //return keyworn is what the method will give back
        return _fuel / _gallonPerMile;
    }
}

public class Menu : NewBaseType
{
    public
}