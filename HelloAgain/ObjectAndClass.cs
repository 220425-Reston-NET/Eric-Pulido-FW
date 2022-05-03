//this is how you creta a class by using the class keyword
//Public is just there to make the class available for everyone.
public class Menu
{
    //This is a field
    //its used to store information or used to define the current state of the object.
    //By default , fields should all be private
   
    //This is a method
    //A way to represent behavior/function and it will create multiple lines of code.
    public int TotalDistancedotPerFuel()
    {
        Console.WriteLine("Current Fuel:" +_fuel);
        Console.WriteLine("Gallon Per Mile:" +_gallonPerMile);

        Console.WriteLine(_fuel/_gallonPerMile + "This is how many miles");

        //return keyworn is what the method will give back
        return _fuel/_gallonPerMile;
    }

    //Methods can also have parameters
    //parameters are implemented by adding in datatypes of the paenthesis
    public void Sum(int num1, int num2)
    {
        Console.WriteLine(num1+num2);
    }

    //this is a constructor
    //It is a special method that will run when you create an object

    public Car()
    {
        _color = "Blue";
        _fuel = 100;
        _gallonPerMile = 5;
        _owner = "eric";
    }

    public Car(string p_owner)
    {
        _owner = p_owner;
    }
    //This is a property
    //  Gives us the flexibility to check that the data stored is correct, let only things access data, makes things read or write
    public string Owner
    {
        //get keyword is this is how the data is going to be shared
        get {return _owner + "is the new owner";}

        //set keyword is how you change the data that is being stored
        set {_owner=value +" Owner";}
    }
    public int Fuel
    {
        get {return _fuel;}
        set 
        {
            if (value <=100 && value >= 0)
            {
                _fuel = value;
            }
            else    
            {
                Console.WriteLine("Fuel can only hold from 0-100");
            }
        }
    }
}
    //This is a constructor
    //It is a method that will execute when you create an object a 
   // public Car(string p_color)
    //{
       // _color = p_color;
    //}
    //This is a property
    //public string Color 
    //{
        //How can i grab this information
    //    get {return _color + "is this the color of the car";}
  //How can i save this
    //    set {}
  //  }
//}