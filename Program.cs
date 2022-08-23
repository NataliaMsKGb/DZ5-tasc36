// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
       if(i<array.Length-1)Console.Write($"{array[i]}, ");
       else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}


int[] GetSummPosChetElem(int[] array)
{
int SumPos = 0;


for (int i = 0; i < array.Length; i+=2)
{

    SumPos += array[i];
    
}
return new int[] {SumPos};
}

int[] arr = CreateArrayRndInt(4, -99, 99);

PrintArray(arr);

int[] sumElem = GetSummPosChetElem(arr);
Console.WriteLine ($"Сумма чисел, стоящих на нечетных позициях: {sumElem [0]}");


