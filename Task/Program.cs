Console.WriteLine("Введите массив строк через запятую");
string str = Console.ReadLine();
int count = 0;
int sizeStr = 3;

string[] array;
array = str.Split(',');

Console.WriteLine(string.Join(',', GetArrayWithSizeStr(array), 0, count));

string[] GetArrayWithSizeStr(string[] array)
{
    string[] result = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= sizeStr)
        {
            result[count] = array[i];
            count++;
        }
    }
    return result;
}
