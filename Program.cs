Console.WriteLine("You are alone in your house and you have 4 optionts of what to do");
Console.WriteLine(" \n 1.Take a nap \n 2. Go for a walk \n 3.Talk with your friend in a call  \n 4. Do nothing  ");
Console.WriteLine("What would be your option? ");
int choice = Convert.ToInt32(Console.ReadLine());
if (choice == 1)
{
    Console.WriteLine("You took a nap and you felt asleep");

}
else if ( choice == 2)
{
    Console.WriteLine("You went to a walk and made new friends");
}
else if (choice == 3)
{
    Console.WriteLine("You talked with your friend for 3 hours ");
}
else if (choice == 4)
{
    Console.WriteLine("You just lay in bed and did nothing");
}
else
{
    Console.WriteLine("Sorry, I don't know that one");
}
// Same excercise but using switch
switch (choice)
{
    case 1:
        Console.WriteLine("You took a nap and you felt asleep");
        break;
    case 2:
        Console.WriteLine("You went to a walk and made new friends");
        break;
    case 3:
        Console.WriteLine("You talked with you friend for 3 hours ");
        break;
    case 4:
        Console.WriteLine("You just lay in bed and did nothing");
        break;
    case 5:
        Console.WriteLine("Sorry, I don't know that one ");
        break;
    
}
//How to add multiple case statements for any given arm
switch (choice)
{
    case 1:
    case 2:
        Console.WriteLine("Thats a good choice");
        break;
    case 3:
    case 4:
        Console.WriteLine("I don't like those options but it's okay");
        break;
    
}
string response;
response = choice switch
{
    1 => "You took a nap and you felt asleep",
    2 => " You went to a walk and made new friends ",
    3 => "You talked with your friend for 3 hours",
    4 => "You just lay in bed",
    _=>  "Sorry, I don't know that one "
};
Console.WriteLine(response);



