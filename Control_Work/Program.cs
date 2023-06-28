Console.WriteLine("Control work: ");
string[] GetArray ()
{
    Console.Write("Enter a size of array: ");
    int size = int.Parse(Console.ReadLine()!);
    string[] result = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter string {i}: ");
        result[i] = Console.ReadLine()!;
    }
    return result;
}
string[] GetStringsLess4Symbols(string[] inputArray)
{
    string[] result = new string[0];
    for (int i = 0;i < inputArray.Length;i++)
    {
        if (inputArray[i].Length < 4)
        {
            Array.Resize(ref result, result.Length + 1);
            result[result.Length - 1] = inputArray[i];
        }
    }
    return result;
}
void Show (string[] array)
{
    Console.WriteLine($"Array: \n {String.Join(" | ", array)}");
}
string[] array = GetArray();
Show(array);
string[] arrayLess4 =  GetStringsLess4Symbols(array);
Show(arrayLess4);
Console.WriteLine(arrayLess4.Length);