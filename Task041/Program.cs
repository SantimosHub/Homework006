// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

int enterArray()
{
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0) count += 1;
    }
    return count;
}

Console.WriteLine($"Колличество положительных чисел = {enterArray()}");