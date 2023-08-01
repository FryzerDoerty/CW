void Main()
{
    int len = LengthArray("Введите длину массива");
    string[] array = new string[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = MeaningArray();
    }

    System.Console.WriteLine("[" + string.Join(",", array) + "]");
    Arr(array);
}
int LengthArray(string text)
{
    System.Console.WriteLine(text);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
string MeaningArray()
{
    string a = Console.ReadLine()!;
    return a;
}
void Arr(string[] array)
{
    string[] arr = Array.Empty<string>();
    for (int i = 0; i < array.Length; i++)
    {
        //char a = char.Parse(array[i]);
        string a = array[i];
        if (a.Length <= 3)
        {
            arr = arr.Append(a).ToArray();
        }
    }
    System.Console.WriteLine("[" + string.Join(",", arr) + "]");
}
Main();
