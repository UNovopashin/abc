Console.WriteLine("Введите элементы массива строк через запятую:");
string[] inputArray = Console.ReadLine().Split(',');

string[] resultArray = FilterStrings(inputArray);

Console.WriteLine("Новый массив строк c длиной <= 3 символов:");
foreach (var str in resultArray)
{
    Console.WriteLine(str);
}
   

