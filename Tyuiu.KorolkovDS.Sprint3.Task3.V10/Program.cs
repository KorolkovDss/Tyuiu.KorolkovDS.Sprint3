using Tyuiu.KorolkovDS.Sprint3.Task3.V10.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
string value = "gdfppf vfppt p";
char chr = 'p';
Console.WriteLine("Исходная строка: " + value);
Console.WriteLine("Символ который нужно удалить: " + chr);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Строка без символа: " + ds.DeleteCharInString(value, chr));
Console.ReadKey();

