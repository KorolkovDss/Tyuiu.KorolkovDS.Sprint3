using Tyuiu.KorolkovDS.Sprint3.Task6.V28.Lib;

DataService ds  = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
int startValue = 13;
int stopValue = 19;
Console.WriteLine("Начало отрезка = " + startValue);
Console.WriteLine("Конец отрезка = " + stopValue);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Количестов делителей, которые меньше 7 = " + ds.GetSumTheDivisors(startValue, stopValue));
Console.ReadKey();