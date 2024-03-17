// See https://aka.ms/new-console-template for more information


using tpmod5;

class Program
{
    public static void Main(string[] args)
    {
        HaloGenerik<String> data = new HaloGenerik<string>("Arvin");
        data.PrintData();

        DataGenerik<String> date = new DataGenerik<string>("1302223136");
        date.PrintData();
    }
}

