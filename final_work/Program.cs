string[] ArrayLess3 (string[] array)
{
    string[] NewArray = new string[array.Length];
    int k = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) 
        {
            NewArray[k] = array[i];
            k++;
        }
    }

    return NewArray;
}

void ShowStringArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] MainArray = new string[size];

Console.WriteLine("Input elements of array: ");
for(int i = 0; i < size; i++)
{
    MainArray[i] = Console.ReadLine();
}

Console.WriteLine();

Console.Write("Main array - ");
ShowStringArray(MainArray);

Console.WriteLine();

string[] NewArray = ArrayLess3(MainArray);

for(int i = 0; i < NewArray.Length; i++)
{
    if(NewArray[0] == null)
    {
        Console.Write("New array - Empty array!");
        break;
    }
    else 
    {
        Console.Write("New array - ");
        ShowStringArray(NewArray);
        break;
    }
}
