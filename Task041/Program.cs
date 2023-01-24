// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

int[] enterArray()
{
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int count = 0;
foreach (var item in enterArray())
{
    Console.Write($"{item} ");
    if (item > 0) count += 1;

}
Console.WriteLine();
Console.WriteLine($"Колличество положительных чисел = {count}");