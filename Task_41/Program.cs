// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void CountNumbers(int[] array)
{
    int quantity = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) quantity++;
    }
    Console.WriteLine(quantity);
}

void FillArray(int[] array)
{
    for(int i = 0; i < 5; i++)
    {
    Console.WriteLine("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int [] array = new int[5];
FillArray(array);
Console.Write($"[{String.Join((", "), array)}] -> ");
CountNumbers(array);
