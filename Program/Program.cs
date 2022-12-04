/*

Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении НЕ РЕКОМЕНУЕТСЯ
пользоваться коллекциями, лучше обойтись исключительно массивами.

Пример:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]

*/

void ShowArray (string message, string [] array)
{
    Console.Write(message);
    if (array.Length == 0 || array[0] == "")
    {
        Console.WriteLine("[]");
    }
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0) Console.Write($"[\"{array[i]}\",");
            else if (i == array.Length - 1) Console.Write($"\"{array[i]}\"]");
            else Console.Write($"\"{array[i]}\",");
        }
    }
    Console.WriteLine();
}

string [] GetArray (string message, char delimiter)
{
    Console.Write(message);
    string[] userArray = Console.ReadLine().Split(delimiter);
    return userArray;
}

string [] FilterElementsInArray (string [] array, int size)
{
    int sizeArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= size) sizeArray++;
    }
    string[] userArray = new string [sizeArray];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= size)
        {
            userArray[count] = array[i];
            count++;
        }
    }
    return userArray;
}

string [] userArray = GetArray("Пожалуйста введите элементы масива через запятую -> ", ',');
ShowArray("Введенный массив -> ", userArray);
string [] filterArray = FilterElementsInArray(userArray, 3);
ShowArray("Отфильтрованный массив -> ", filterArray);
