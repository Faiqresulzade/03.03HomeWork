int[] numbers = { 3, 7, 8, 11, 19, 21 };
int save_number = 0;
for (int i = 0; i < numbers.Length; i++)
{
	for (int j =(numbers.Length-1)-i; j >0; j--)
	{
		if(!(i== j||numbers.Length==i))
		{
            save_number = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = save_number;
            i++;
            j--;
        }
		break;
	}
}
for (int i = 0; i < numbers.Length; i++)
{
	Console.WriteLine(numbers[i]);
}
