string[] ArrayLess3 (string[] array)
{
    string[] NewArray = new string[array.Length];
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) 
        {
            NewArray[i] = array[i];
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
Console.Write("New array - ");
ShowStringArray(NewArray);