int[] numbers = { 1, 12, 23, 6, 9 };
int count=0;
for (int i = 0; i < numbers.Length; i++)
{
    if ((numbers[i] / 10) == 0)
    {
        count++;
    }
}
Console.WriteLine(count);