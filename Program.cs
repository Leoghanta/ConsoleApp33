namespace ConsoleApp33
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			var mytext = Console.ReadLine();
			var mynum = 0;
			try
			{
				mynum = int.Parse(mytext);
			} 
			catch (Exception e)
			{
                Console.WriteLine("Unknown Number Given");
				mynum = 0;
            }
			Console.WriteLine(mynum);

			if (!(mynum == 0))
			{
				Console.WriteLine("mynum was not 0");
			} else
			{
                Console.WriteLine("reached an else");
            }
			
			for (int i = 100; i < 1000; i+=50)
			{
                Console.WriteLine(i);
            }

			while (true)
			{
				Console.WriteLine("help! I'm in a loop!");
				break;

			}


			do
			{
                Console.WriteLine("I'm in a do while loop");
            } while (mynum < 5);

			myfunction();

			int x = addFive(5);

		}

		static void myfunction()
		{
			Console.WriteLine("I'm in a function");
		}
		

		static int addFive(int num)
		{

			car car = new car("Mr Car");
			//car.name = "Mr. Car";

			racecar broombroom = new racecar("Toot", 500);
			broombroom.setName("toottoot");


			return num + 5;


		}

	}
}