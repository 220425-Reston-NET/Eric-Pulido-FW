//this is how you creta a class by using the class keyword
//Public is just there to make the class available for everyone.
public class Menu
{

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