Console.Write("\nВведите количество элиментов массива: ");
int quantity = Convert.ToInt32(Console.ReadLine());



if (quantity > 0)
{
    Random random = new Random();
    int[] newArray = new int[quantity];
    long summ = 0;
    Console.WriteLine("\nВвывод массива: ");

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = random.Next();
        Console.WriteLine(newArray[i]);
    }
    for (int j = 1; j < newArray.Length; j = j + 2)
    {
        summ = summ + newArray[j];
    }
    Console.Write($"\nСумму элементов, стоящих на нечётных позициях. {summ}");
}
else
{
    Console.Write("Вввел некорректное число. Фатальная ошибка.");
}