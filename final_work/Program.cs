string[] ArrayLess3Elements (string[] array)
{
    string[] NewArray = new string[10];
    
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

string[] MyArray = new string[size];

Console.WriteLine("Input elements of array: ");
for(int i = 0; i < size; i++)
{
    MyArray[i] = Console.ReadLine();
}

ShowStringArray(MyArray);
