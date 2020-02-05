using System;

public class palindrome
{
	public static void Main(String [] ar)
    {
        int n, rev = 0,m;
        Console.WriteLine("Enter a number");
        n = Convert.ToInt32(Console.ReadLine());
        m = n; // storing the copy of number to be used later
        while(n>0)
        {
            rev = (rev*10) + (n%10); //n%10 extracts the last digit whereas rev stores the number in reverse eg if n=123 then n%10 =3
            n /= 10; //now n is the number with the last digit removed. eg if n was 123 at so now it is 12
        }
        if (rev == m) // a palindrome number is a number which when reversed remains the same eg 131.
            Console.WriteLine($"{m} is a Palindrome Number");
        else
            Console.WriteLine($"{m} is NOT a Palindrome Number");

    }
}
