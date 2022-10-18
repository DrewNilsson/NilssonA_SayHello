// Andrew Nilsson
//09-07-2022
//Mini Challenge #1 - Say Hello
//This is a console project that will say hello
//Peer Review by: Caroline - great amazing ran good and was funny !


Console.Clear();
string play = "yes";
while (play == "yes")
{

    Console.WriteLine("What is your Name?");

    string myName = Console.ReadLine();

    Console.WriteLine("Say hello " + myName);

    string playInput = "";
    while (playInput != "yes" && playInput != "no")
    {
        Console.WriteLine("\n" + "If you would like to enter another name type yes, enter no if not.");
        playInput = Console.ReadLine();

        playInput = playInput.ToLower();

        if (playInput == "yes")
        {
            play = playInput;
        }
        else if (playInput == "no")
        {
            Console.WriteLine($"Have a good day {myName}");
            play = playInput;
        }
        else
        {
            Console.WriteLine("Invalid input");
        }

    }

}
