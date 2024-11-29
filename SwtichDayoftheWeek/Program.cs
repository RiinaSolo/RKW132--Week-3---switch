int weekDay = 10;//Convert.ToInt32(DateTime.Now.DayOfWeek);

switch (weekDay) //väärtus, mida kontrollitakse
{
    case 0: //case 0: == if(weekday == 0 )
        Console.WriteLine("It's Sunday");
        break;
    case 1: //case 0: == if(weekday == 0 )
        Console.WriteLine("It's Monday");
        break;
    case 2: //case 0: == if(weekday == 0 )
        Console.WriteLine("It's Tuesday");
        break;
    case 3: //case 0: == if(weekday == 0 )
        Console.WriteLine("It's Wednesday");
        break;
    case 4: //case 0: == if(weekday == 0 )
        Console.WriteLine("It's Thursday");
        break;
    case 5: //case 0: == if(weekday == 0 )
        Console.WriteLine("It's Friday");
        break;
    case 6: //case 0: == if(weekday == 0 )
        Console.WriteLine("It's Saturday");
        break;
    default:
        Console.WriteLine("Opps, something went wrong, go on vacation");
        break;
}

Console.WriteLine("Have a nice day!");