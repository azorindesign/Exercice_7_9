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
		
		while (userwrite != "end"){
			int newdigit = Convert.ToInt32(userwrite);
			
			/*Next review hoy many digits have the number introduced for the user
			using a division for go counting*/
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
			
		}
			Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", onedigit, twodigits, threedigits, morethreedigits); 
	}
}

