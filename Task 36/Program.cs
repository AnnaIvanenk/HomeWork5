// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
int size = 8;
int[] numbers = new int[size];
Fill(numbers);

PrintArray(numbers);
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 != 0)
    sum += numbers[i];
}

Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равна {sum}.");
Console.WriteLine();

void Fill(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,10);
    }
}

void PrintArray(int[] numbers)
{
    Console.Write("создан массив: [ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine("]");
    Console.WriteLine();
   
}

Fill(numbers);

PrintArray(numbers);