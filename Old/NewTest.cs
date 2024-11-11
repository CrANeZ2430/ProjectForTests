class NewTest
{
    Car car = new Car("BMW");

    private void Method()
    {
        car.Wheels = 4;
    }


    /*

    public Car(string model) { this.Model = model; }
    - constructor

    public int Wheels { get { return wheels; } set { wheels = value; } }
    - property

     */
}

class Car
{
    public string Model { get; set; }

    private int wheels;

    public Car(string model)
    {
        Model = model;
    }

    public int Wheels
    {
        private get { return wheels; }
        set { wheels = value; }
    }
}