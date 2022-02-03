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
    for (int i = 0; i < arrayOfPrint.Length; i++)
    {
        System.Console.Write($"[{i}]:{arrayOfPrint[i]} ");
    }
}

int[] NewArrayOfFill(int[] array1)
{
    int[] newArray1 = new int[array1.Length];
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] > 8)
        {

        }
    }
    return newArray1;
}

int[] array1 = new int[10];
FillArray(array1);
PrintArray(array1);

