// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

int[] Bubblesort = { 45, 10, 15, 4};
int counter = 0;

for (int write = 0; write < Bubblesort.Length; write++)
{
    for (int sort = 0; sort < Bubblesort.Length - 1; sort++)
    {
        if (Bubblesort[sort] > Bubblesort[sort + 1])
        {
            counter = Bubblesort[sort + 1];
            Bubblesort[sort + 1] = Bubblesort[sort];
            Bubblesort[sort] = counter;
        }
    }
    
}
for (int i = 0; i < Bubblesort.Length; i++)
    Console.Write(Bubblesort[i] + " ");


