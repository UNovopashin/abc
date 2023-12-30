using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива строк через запятую:");
        string[] inputArray = Console.ReadLine().Split(',');

        // Формируем новый массив из строк, длина которых <= 3 символов
        string[] resultArray = FilterStrings(inputArray);

        // Выводим результат
        Console.WriteLine("Новый массив строк c длиной <= 3 символов:");
        foreach (var str in resultArray)
        {
            Console.WriteLine(str);
        }
    }

    // Метод для фильтрации строк в массиве
    static string[] FilterStrings(string[] inputArray)
    {
        int count = 0; // Счетчик строк, удовлетворяющих условию
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив нужного размера
        string[] resultArray = new string[count];
        int index = 0;

        // Заполняем новый массив строками, удовлетворяющими условию
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }

        return resultArray;
    }
}
