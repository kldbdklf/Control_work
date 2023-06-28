string[] array = new string[5];
array[0] = "Sad";
Console.WriteLine(array.Length);
if (array[0].Length <= 3)
{
    Console.WriteLine(array[0]);
}
Array.Resize(ref array, array.Length+1);
Console.WriteLine(array.Length);