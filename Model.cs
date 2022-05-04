public class Menu
{
    private string _name;
    public string Name
    {
        get{return _name;}
        set{ _name = value;}
    }
    private int _latte;
    private int _mocha;
    private int _espresso;
    //Another was to make a property what doesn't require a field attached to it
    public int Coffee { get; set; }
    private int _totalPrice; //Saving the total proce of what the user saved
    public int totalPrice
    {
        get{ return _totalPrice;}
        set{ _totalPrice = value;}
    }
    public Menu()
    {
        _name = "Eric";
        _latte = 3;
        _mocha = 4;
        _espresso = 3;
        Coffee = 5;
    }

    //This Method will greet the user
    public void GreetUser()
    {
        Console.Clear();
        Console.WriteLine("Hello,Welcome to my Store!");
        Console.Writeline("What is your name?");
        Console.ReadLine();
        Console.WriteLine("Are a new custoner?");
        Console.WriteLine("1. Yes");
        Console.WriteLine("2. No");
        Console.ReadLine();
        if (answer = "1")
        {
            Console.WriteLine("Welcome" + _name);
        }    
        else if (answer = "2")
        {
            Console.WriteLine("Welcome back! Heres our menu");
        }
        else
        {
            Console.Writeline("Please enter a correct option.");
        }
        Console.WriteLine("1. Buy an item");
        Console.WriteLine("2. Checkout");
    }

    //This method will buy something

    public void BuyItem()
    {
        Console.WriteLine("1 - Latte $" + _lattePrice);
        Console.WriteLine("2 - Mocha $" + _mochaPrice);
        Console.WriteLine("3 - Espresson $" + _EspressoPrice);
        Console.WriteLine("4 - Coffee $" + CoffeePrice);
        string answer =Console.ReadLine(); 
        if (answer == "1")
        {
            _totalPrice += _lattePrice;
        }
        else if (answer == "2")
        {
            _totalPrice += _mochaPrice;
        }
        else if (answer == "3")
        {
            _totalPrice += _espressomPrice;
        }
        else if (answer == "4")
        {
            _totalPrice += CoffeePrice;
        }
        Console.WriteLine("Your current total is: " + _totalPrice);
    }

}
