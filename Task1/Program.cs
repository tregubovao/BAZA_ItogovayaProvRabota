﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами. 
/* Примеры: 
["hello", "2", "world", ":-)"] -> ["2", ":-)"] 
["1234", "1567", "-2", "computer science"] -> ["-2"] 
["Russia", "Denmark", "Кazan"] -> О  */

void PrintArray(string[] array)
{
    foreach(string element in array)
    Console.Write($"{element} ");
Console.WriteLine();    
}

int CountUniqueElements(string[] str)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
        if (str[i].Length <= 3)
            count++;
    return count;
}

string[] GetNewStr(string[] str)
{
    string[] newstr = new string[CountUniqueElements(str)];
    int index = 0;
    for (int i = 0; i < str.Length; i++)
        if (str[i].Length<=3)
        {
            newstr[index] = str[i];
            index++;
        }
    return newstr;
}
Console.Clear();
string[] str = { "Если", "б", "я", "был", "султан", ",", "я", "б", "имел", "трех", "жен", "." };
Console.WriteLine("Базовый массив строк: ");
PrintArray(str);
Console.WriteLine();
string[] newstr = GetNewStr(str);
Console.WriteLine("Новый массив строк (из элементов базового массива, каждый из которых длинной НЕ БОЛЕЕ трех символов): ");
PrintArray(newstr);
