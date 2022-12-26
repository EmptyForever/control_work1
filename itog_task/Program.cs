Console.Clear();

// метод для нахождения кол-ва строк, размер которых не больше 3
int HowManyStringMore3(string[] arr1)
{
    int k = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3) k++;
    }
    return k;
}

