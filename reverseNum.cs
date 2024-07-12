using System;
class ReverseNumber
{
	public static void Main(String [] args)
	{
		int number;
		int reverseNum=0;
 		Console.WriteLine("Enter a number");
		number=Convert.ToInt32(Console.ReadLine());
		while(number!=0){
		reverseNum=reverseNum*10 + number%10;
		number/=10;
	        }
		
		Console.WriteLine("The reverse number is "+ reverseNum);
	}
}