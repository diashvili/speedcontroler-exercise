using BMW;

M5 m5 = new();

while (true)
{
	var key = Console.ReadKey(true).Key;
	switch (key)
	{
		case ConsoleKey.UpArrow:
			m5.Accelerate(20);
			break;
		case ConsoleKey.DownArrow:
			m5.Accelerate(-20);
			break;
		case ConsoleKey.Escape:
			return;
	}
}
