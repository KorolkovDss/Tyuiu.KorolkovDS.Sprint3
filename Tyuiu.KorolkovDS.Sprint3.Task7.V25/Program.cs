using Tyuiu.KorolkovDS.Sprint3.Task7.V25.Lib;
DataService ds = new DataService();
int startValue = -5; int endValue = 5;
Console.WriteLine("Старт шага: " + startValue);
Console.WriteLine("Конец шага: " + endValue);
int len = ds.GetMassFunction(startValue, endValue).Length;
double[] res = new double[len];
res = ds.GetMassFunction(startValue, endValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine();
Console.WriteLine("+----------+-----------+");
Console.WriteLine("|    X     |   f(x)    |");
Console.WriteLine("+----------+-----------+");
for (int i = 0; i <= len - 1; i++)
{
    Console.WriteLine("|{0,5:d}     |  {1,6:f2}   |", startValue, res[i]);
    startValue++;
}
Console.WriteLine("+----------+-----------+");

Console.ReadKey();
