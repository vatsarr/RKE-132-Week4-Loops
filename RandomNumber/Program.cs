Random rnd = new Random();


//int myRandomNum = rnd.Next(0, 11);
//Console.WriteLine($"The random number is: {myRandomNum}");
int myRandomNum;
int randomSum = 0;

for (int i = 0; i < 3; i++)
{
    myRandomNum = rnd.Next(0, 11);
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"The random sum is: {myRandomNum}");
};

Console.WriteLine($"The randomNums sum is: {randomSum}");