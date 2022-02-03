// Задача: Написать программу, которая из имеющегося массива целых чисел формирует массив из чисел, больших 8.
//  Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void FillArray(int[] arrayOfFill)
{
    for (int i = 0; i < arrayOfFill.Length; i++)
    {
        arrayOfFill[i] = new Random().Next(1, 20);
    }
}

int[] PrintArray(int[] arrayOfPrint)
{
    if (arrayOfPrint.Length == 0)
    {
        Console.WriteLine("Пустой массив");
    }
    for (int i = 0; i < arrayOfPrint.Length; i++)
    {
        Console.Write($"[{i}]:{arrayOfPrint[i]} ");
    }
    return arrayOfPrint;
}

int MoreEightNumberCounter(int[] array1)
{
    int eightCounter = 0;
    foreach (int item in array1)
    {
        if (item > 8)
        {
            eightCounter++;
        }
    }
    return eightCounter;
}

int[] CreateNewArray(int[] array1)
{
    int[] finalArray = new int[MoreEightNumberCounter(array1)];
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] > 8)
        {
            finalArray[j] = array1[i];
            j++;
        }
    }
    return finalArray;
}

int[] array1 = new int[10];
FillArray(array1);
PrintArray(array1);
Console.WriteLine();
Console.WriteLine();
int[] finalArray = CreateNewArray(array1);
PrintArray(finalArray);

