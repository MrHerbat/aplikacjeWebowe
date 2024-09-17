int[] tab = new int[10];

for (int i = 0; i < tab.length(); i++)
{
    tab[i] - i*i;
}

ShowTable(tab);

void ShowTable(int[] tab)
{
    foreach (int element in tab)
    {
        Console.Write(element + " ");
    }
}