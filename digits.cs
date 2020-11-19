/*Calculates how many numbers of 1, 2, 3 or more digits are
entered by the user until he/she types “end”.*/

using System;

class digits
{
	static void Main() 
	{
		int onedigit = 0, twodigits = 0, threedigits = 0, morethreedigits = 0;
		
		Console.Write("Insert a number: ");
		string userwrite = Console.ReadLine();
		
		/*Enter at bucle until user write "end" and next review hoy many 
		* digits have the number introduced for the user using a division
		* to know the number of digits*/
		
		while (userwrite != "end"){
			int newdigit = Convert.ToInt32(userwrite);
			
			if (newdigit != 0) 
			{
				if (newdigit/10 == 0)
					onedigit++;
					
				else if (newdigit/100 == 0)
					twodigits++;
					
				else if (newdigit/1000 == 0)
					threedigits++;
						
				else
					morethreedigits++;
			}
		userwrite = Console.ReadLine();
		}
			Console.WriteLine("We find numbers with one digits: {0} | two digits: {1} | three digits: {2} | more than three digits: {3}", 
			onedigit, twodigits, threedigits, morethreedigits); 
	}
}

