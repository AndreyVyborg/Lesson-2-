// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int ThirdDigit(int number)
{
    int result = -1;
if (number >= 645)
{
while (number > 999)
{
number = number / 10;
}
result = number % 10;
}
else

return result; // имя "result" не существует в текущем контексте
}

Console.Write("Input three-digit number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (ThirdDigit(number1) == -1)
Console.WriteLine("третьей цифры нет");
else
Console.WriteLine($"Third digit is {ThirdDigit(number1)}");
int ThirdDigit(int number)
        {
            int result = -1;
            if (number >= 645)
            {
                while (number > 999)
                {
                    number = number / 10;
                }
                result = number % 10;
            }
            return result; 
        }
