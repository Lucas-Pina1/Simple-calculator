Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODO's");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

if (userChoice == "S") 
{
    PrintSelectedOption("Selected option: see all TODOs");
}
else if (userChoice == "A") 
{
    PrintSelectedOption("Selected option: add all TODOs");
} else if (userChoice == "R")
{
    PrintSelectedOption("Selected option: remove all TODOs");
}
else if (userChoice == "E") 
{
    PrintSelectedOption("Selected option: Exit");
}

//void PrintSelectedOption(string selectOption) 
//{  
//    Console.WriteLine("Selected option: " + selectOption); 
//}

//Console.ReadKey();