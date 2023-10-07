internal class Program
{
    private static void Main(string[] args)
    {Console.WriteLine("Enter Number");
    string a = Console.ReadLine();
    int kol_numbers = a.Length;
    int  Numeres = int.Parse(a);
    int sym = 0;
    for (int i = 0 ; i < kol_numbers ; ++i ){
    sym = sym + Numeres % 10;
    Numeres = Numeres / 10;
    }
    Console.WriteLine(sym);
    }
}