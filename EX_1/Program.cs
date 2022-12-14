Console.Write("\nВведите количество элиментов массива: ");
int quantity = Convert.ToInt32(Console.ReadLine());
Random random = new Random();


if (quantity > 0)
{
    int[] newArray = new int[quantity];
    int summ = 0;

    Console.WriteLine("\nВвывод массива: ");

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = random.Next(0, 1000);
        Console.WriteLine(newArray[i]);

        if (newArray[i] % 2 == 0)
            summ++;
    }

    Console.Write($"\nКоличество чётных чисел в массиве: {summ}");
}
else
{
    Console.Write("Вввел некорректное число. Фатальная ошибка.");
}