int[] tab = new int[10];
string[] tabString = new string[]{"ala","ma","kota"};

for (int i = 0; i < tab.Length; i++)
{
    tab[i] = i*i;
}

ShowTable(tabString);

var tab2 = GenerTab(10);
ShowTable(tab2);
Console.WriteLine();
Console.WriteLine(GetMax(tab2));
Console.WriteLine(GetMin(tab2));
Console.WriteLine(GetMax(tab2)-GetMin(tab2));
Console.WriteLine(GetSum(tab2));
Console.WriteLine(GetAvg(tab2));

var tab3 = GenerDivBy(10,6);
ShowTable(tab3);




void ShowTable<T>(T[] tab)
{
    foreach (T element in tab)
    {
        Console.Write(element + " ");
    }
}

int[] GenerTab(int size)
{
    Random rand = new Random();
    int tabSize = size;
    int[] result = new int[tabSize];
    for (int i = 0; i < tabSize; i++)
    {
        result[i] = rand.Next(100);
    }
    return result;
}
int GetMax(int[] tab)
{
    int maxValue = 0;
    foreach (var element in tab)
    {
        if (maxValue <= element)
        {
            maxValue = element;
        }
    }   
    return maxValue;
}
int GetMin(int[] tab)
{
    int minValue = 100;
    foreach (var element in tab)
    {
        if (minValue >= element)
        {
            minValue = element;
        }
    }   
    return minValue;
}
int GetSum(int[] tab)
{
    int sum = 0;
    foreach (var element in tab)
    {
        sum+=element;
    }
    return sum;
}
float GetAvg(int[] tab)
{
    int sum = GetSum(tab);
    int size = tab.Length;
    float avg = sum/size;
    return avg;
}
int[] GenerDivBy(int size, int div)
{
    Random rnd = new Random();
    int tabSize = size;
    int[] result = new int[tabSize];
    int rand;
    for (int i = 0; i < tabSize; i++)
    {
        result[i] = rnd.Next(100)*div;
    }
    return result;
}