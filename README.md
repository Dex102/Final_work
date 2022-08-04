# Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символа.
## Алгоритм решения:
1. Описывается метод нахождения элементов массива строк, длина которых меньше, либо рвна "3". 
Метод "пробегает" по каждому элементу массива строк, и находя нужный элемент,
записывает его в новый массив NewArray, затем возвращает данное значение.

**Основной метод:**

```
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
```

**Метод вывода массива на консоль:**
```
void ShowStringArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
```

**Основной блок программы**
```
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
```
