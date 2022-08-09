String[] arr1 = new String [] {"hello", "2", "world", ":-)"};

String[] deleteString(String[] arr)
{
    int count = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    String[] result = new String [count];
    count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            result[count] = arr[i];
            count++;
        }
    }
    return result;
}

System.Console.WriteLine(String.Join(", ", deleteString(arr1)));

