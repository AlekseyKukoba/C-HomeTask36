// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int sum = 0;
for (int i = 0; i < size; i+=2)
sum = sum + numbers[i];
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}