System.Console.WriteLine("Введите строки массива, разделяя запятой:"," ");
string str = Console.ReadLine();
string[] array = str.Split(',');


System.Console.WriteLine();
System.Console.WriteLine("Результат выборки: ");

for (int i = 0; i < array.Length; i++)
{
   
    if (array[i].Length <= 3)
    {
        System.Console.Write("[" + string.Join(", ", array[i]) + "]");
    }
}