/*Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше или равна 3 символам.*/

Console.Write("Введите количество значений в массиве: ");
int number = int.Parse(Console.ReadLine());

string[] array = GetArray(number);
PrintArray(array);
Console.WriteLine();

string[] finalArray = LittleArray(array);
PrintArray(finalArray);


string[] GetArray(int length)
{
    string[] array = new string[length];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива номер {i + 1}: ");
        string userUnswer = Console.ReadLine();
        array[i] = userUnswer;
    }
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

string[] LittleArray(string[] array)
{
    string[] newArray = new string[array.Length];
    int count = 0;
    int minNumber = 3;  
    for (int i = 0; i < array.Length; i++)
    {
        if (minNumber >= array[i].Length)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}