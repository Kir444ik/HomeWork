int[] M = new int[8];
for (int i = 0 ; i < M.Length ; i++)
{
    Console.WriteLine($"Enter number {i}:\t ");
    M[i] = int.Parse(Console.ReadLine());
}
Console.Write("числа массива: ");
Console.WriteLine("Вывод массива");
for (int g = 0 ; g < M.Length ; g++ )
{
    Console.Write($" {M[g]} ;  ");
}