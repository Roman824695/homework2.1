Console.Write("Введите  число :->" );
int num = Convert.ToInt32(Console.ReadLine());
int a = 10;

int Sam(int number1, int number2)
{
   int result = number1 % number2;
    return result;
} 

int Pub(int number1, int number2)
{
     while(number1 > 999)
    {
    number1 = number1 / number2;
    }
return number1;
}

if(num > 99)
{
int number = Pub(num, a);
int sap = Sam(number, a);
Console.WriteLine("Третье число ->" + sap);
}
else
{
Console.WriteLine("Третьего числа нет");
}