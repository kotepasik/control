// Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void StringsLessThenThree(string[] array1, string[] array2)
{
    int index = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[index] = array1[i];
            index++;
        }
    }
}

string[] array3 = { "Baba", "hay", "1456", "you", "@#$=", "186541", "man", "+++++", ")", "comp", "IGRA" };
string[] array4 = new string[array3.Length];

StringsLessThenThree(array3, array4);
PrintArray(array4);