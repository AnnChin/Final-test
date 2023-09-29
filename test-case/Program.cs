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
