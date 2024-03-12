// Задайте произвольный массив. Выведете его элементы, начиная с конца.
//  Использовать рекурсию, не использовать циклы.

void PrintAray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}

int[] CreatedArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

int minimum = 1;
int maximum = 10;
int size = 5;

int[] arrayMain = CreatedArrayRndInt(size, minimum, maximum);
PrintAray(arrayMain);

Console.WriteLine();


void ShowElementsFromEnd (int[] arrayMain)
{   
    if (arrayMain [i]=0) return;
    ShowElementsFromEnd(arrayMain.Lenght - 1);
    Console.WriteLine($"{arrayMain [i]}");
}
ShowElementsFromEnd(newarray)

Console.WriteLine("Введител натуральное число");
int number = Convert.ToInt32(Console.Readline());

void NaturalNumber(int num)
{
    if (num == 0) return;
    NaturalNumber(num - 1);
    Console.Write($"{num} ");
}
NaturalNumber(number);