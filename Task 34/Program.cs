int size = 10;
int[] numbers = new int[size];
Fill(numbers);

PrintArray(numbers);
int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    count++;
}

Console.WriteLine($"в котором {count} чисел чётные");

void Fill(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,999);
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
   
}