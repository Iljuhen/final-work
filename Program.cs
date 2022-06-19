using System;
Console.Clear();

string[] firstArr = new string[]
{ "cat", "flag", "12345", "soft","yes", "csharp", "$)", "5" };

string[] secArr = new string[firstArr.Length];

Console.WriteLine("Задан массив:  ");
Console.WriteLine();
Console.WriteLine(PrintArray(firstArr));
Console.WriteLine();
SecArray(secArr);
Console.WriteLine("новый массив:  ");
Console.WriteLine();
Console.WriteLine(PrintArray(secArr));
Console.WriteLine();

void SecArray(string[] secArr)
{
    int sizeIndex = 0;
    for (int i = 0; i < firstArr.Length; i++)
    {

        if (firstArr[i].Length <= 3)
        {
            secArr[sizeIndex] = firstArr[i];
            sizeIndex++;
        }

    }
return;
}


string PrintArray(string[] array)
{
    string res = string.Empty;
    res = "|";
    for (int i = 0; i < array.Length; i++)
    {
        res += $"{array[i]} | ";
    }
    res += " ";
    return res ;
}

