/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

// РЕШЕНИЕ

string[] NewArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} слово");
        array[i] = Console.ReadLine()!;
    }
    return array;
}


string[] ArrayСhoice(string[] ArrayText)
{
    string[] NewArray = new string[ArrayText.Length];
    int index = 0;
    for (int i = 0; i < ArrayText.Length; i++)
    {
        int count = 0;
        foreach (char c in ArrayText[i])
        {
            count++;
        }
        if (count <= 3)
        {
            NewArray[index] = ArrayText[i];
            index++;
        }

    }
    return NewArray;
}

Console.WriteLine("Укажите колличество слов");
int size = int.Parse(Console.ReadLine()!);

string[] Myarray = NewArray(size);
string[] ArrayChoise = ArrayСhoice(Myarray);

Console.WriteLine($"[{string.Join(" ", ArrayChoise)}]");

