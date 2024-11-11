class Polymorphysm
{
    public void PolMethod()
    {
        ISample intImp1 = new InterfaceImplementation1();
        ISample intImp2 = new InterfaceImplementation2();

        ISample[] samples = { intImp1, intImp2 };

        int i = 1;

        foreach (ISample intImp in samples)
        {
            Console.WriteLine(intImp.PrintValue($"Hi! {i}"));

            i++;
        }
    }
}

class InterfaceImplementation1 : ISample
{
    public string PrintValue(string m)
    {
        return m;
    }
}

class InterfaceImplementation2 : ISample
{
    public string PrintValue(string m)
    {
        return m;
    }
}

interface ISample
{
    string PrintValue(string m);
}