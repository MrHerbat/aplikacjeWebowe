int[] tab = new int[10];
string[] tabString = new string[]{"ala","ma","kota"};

for (int i = 0; i < tab.Length; i++)
{
    tab[i] = i*i;
}

ShowTable(tabString);

void ShowTable<T>(T[] tab)
{
    foreach (T element in tab)
    {
        Console.Write(element + " ");
    }
}