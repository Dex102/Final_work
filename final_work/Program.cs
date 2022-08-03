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
