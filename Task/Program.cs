string [] inputArray = {"Hello", "cat", "dog", "world", "1", "geekbrains", ":)"};
string [] FilterArray (string [] array)
{
    int count = 0;
    foreach (string str in array)
    {
        if (str.Length <=3)
        {
            count ++;
        }
    }
    string [] resultArray = new string [count];
    count = 0;
    foreach (string str in array)
    {
        if (str.Length <=3)
        {
            resultArray[count] = str;
            count++;
        }
    }
    return resultArray;
}
string [] result = FilterArray (inputArray);
Console.Write ($"Результат: {string.Join(", ", result)}");
