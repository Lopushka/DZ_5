
Console.Write("\nВведите количество элиментов массива:\t ");

int elementsCont = Convert.ToInt32(Console.ReadLine());


if (elementsCont > 0)
{
    double[] myArray = new double[elementsCont];
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"\nВведите элиментов массива под индексом {i}:\t");
        myArray[i] = Convert.ToDouble(Console.ReadLine());
    }

    Console.WriteLine("\nВвывод массива: ");

    for (int i = 0; i < myArray.Length; i++)

    {
        Console.WriteLine(myArray[i]);
    }

    Console.WriteLine($"\nРазница между максимальным и минимальным элементов массива.: {myArray.Max() - myArray.Min()}");

}

else
{
    Console.Write("Вввел некорректное число. Фатальная ошибка.");
}