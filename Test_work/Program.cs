/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/



string[] array;
Console.WriteLine("Введите массив строк через запятую");
string arrays = Console.ReadLine();
array = arrays.Split(',');
var massive = new string[array.Length];
var size = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        massive[size] = value;
        size++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, massive, 0, size));

