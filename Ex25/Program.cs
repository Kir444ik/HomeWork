Console.WriteLine("Enter number A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number B");
int d = Convert.ToInt32(Console.ReadLine());
int num = 1;
for (int i = 0 ; i < d ; ++i)
{
   num = num * a;
}
Console.WriteLine(num);