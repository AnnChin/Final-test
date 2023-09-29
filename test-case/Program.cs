// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 

// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

int UserInputNumbers(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1} эллемент массива: ");
        arr[i] = Console.ReadLine();
    }
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int lenArr = UserInputNumbers("Задайте количество слов: ");
string[] Arr = new string[lenArr];
FillArray(Arr);
Console.WriteLine($"Исходный массив: ");
PrintArray(Arr);
Console.WriteLine();

string[] Arr2 = new string[Arr.Length];
int j = 0;
for (int i = 0; i < Arr.Length; i++)
{
    if (Arr[i].Length <= 3)
    {
        Arr2[j] = Arr[i];
        j++;
    }
}

Console.WriteLine($"Новый массив: ");
PrintArray(Arr2);