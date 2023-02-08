
int sum = 0;

for (int i = 1; i <= 10; i++)
{
    sum = sum + i;
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current total: {sum}");
};

Console.WriteLine($"Final sum: {sum}");