int weekday = Convert.ToInt32(DateTime.Now.DayOfWeek);

if (weekday == 0)
{
    Console.WriteLine("It's Sunday!");
}
else if (weekday == 1)
{
    Console.WriteLine("It's Monday!");
}
else if (weekday == 2)
{
    Console.WriteLine("It's Tuesday!");
}
else if (weekday == 3)
{
    Console.WriteLine("It's Wednesday!");
}
else if (weekday == 4)
{
    Console.WriteLine("It's Thursday!");
}
else if (weekday == 5)
{
    Console.WriteLine("It's Friday!");
}
else if (weekday == 6)
{
    Console.WriteLine("It's Saturday!");
}