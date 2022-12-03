 // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int size = 5;
double[] array = new double[size];
double min = array [0];
double max = array [0];

// Заполнение массива

void Fill(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(0, 200)) / 10;
        System.Console.WriteLine(numbers[i]);
   }
}

// Печать массива

// void PrintArray(double[] numbers)

// {
//     Console.Write("создан массив: [ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.WriteLine("]");
   
// }

Fill(array);
for (int i = 0; i < array.Length; i++)
{
   if (array [i] > max) max = array [i];
   if (array [i] <=min) min = array [i];
}
 
 Console.WriteLine($"Минимальное значение массива {min}");
 Console.WriteLine($"Максимальное значение массива {max}");

 double diff = max - min;

  Console.WriteLine($"Разница {diff}");

