//Marcel Rodriguez
//10-18-22 4pm
//Mini Challenge 4 - Greater than or less than
//This program will ask for 2 numbers to be input and then
//say if the first is less than or greater than and then
//say if the second is less than or greater than
//Peer review -  

Console.Clear();

string end = "yes";
while(end == "yes")
{
    bool isContainer = false;
    bool isNumber;
    double validNum = 0;
    string numberOne = "";

    while(isContainer == false)
    {
        Console.WriteLine("Please enter a number: ");
        numberOne = Console.ReadLine();
        isNumber = double.TryParse(numberOne, out validNum);

        if (isNumber == true)
        {
            isContainer = true;
            Console.WriteLine($"\nThe number you entered was {numberOne}");
        }
        else
        {
            Console.WriteLine("\nPlease enter a number, not string: \n");
        }
    }

    bool isContainer2 = false;
    bool isNumber2;
    double validNum2 = 0;
    string numberTwo = "";

    while(isContainer2 == false)
    {
        Console.WriteLine("\nPlease enter another number: ");
        numberTwo = Console.ReadLine();
        isNumber2 = double.TryParse(numberTwo, out validNum2);

        if (isNumber2 == true)
        {
            isContainer2 = true;
            Console.WriteLine($"\nThe number you entered was {numberTwo}");
        }
        else
        {
            Console.WriteLine("\nPlease enter a number, not string: \n");
        }
    }

    if(validNum > validNum2)
    {
        Console.WriteLine($"\n{validNum} is greater than {validNum2}");
        Console.WriteLine($"\n{validNum2} is less than {validNum}");
    }
    else if (validNum < validNum2)
    {
        Console.WriteLine($"\n{validNum} is less than {validNum2}");
        Console.WriteLine($"\n{validNum2} is greater than {validNum}");
    }
    else
    {
        Console.WriteLine($"\n{validNum} is equal to {validNum2}");
    }

    Console.WriteLine("\nDo you want to play again? Yes/No");
    end = Console.ReadLine().ToLower();
}

