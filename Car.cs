using System.Drawing;

class Car(string make, string model, string color)
{
    // Read only so we can't change the make or model
    // after instantiation
    public string Make { get; } = make;
    public string Model { get; } = model;

    // You can set the color but only
    // if you do it from methods inside the class
    // since the setter is private
    public string Color { get; private set; } = color;

    public void WashMe()
    {
        Color = Color.Replace("smuts", "");
    }

}