using System;

namespace Course_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //list & array

            //prob 1

            var names = new list<string>();

            while (true)
            {
                console.write("type a name (or hit enter to quit): ");

                var input = console.readline();
                if (string.isnullorwhitespace(input))
                    break;
                names.add(input);
            }

            if (names.count > 2)
                console.writeline("{0}, {1} and {2} others like your post", names[0], names[1], names.count - 2);
            else if (names.count == 2)
                console.writeline("{0} and {1} like your post", names[0], names[1]);
            else if (names.count == 1)
                console.writeline("{0} likes your post.", names[0]);
            else
                console.writeline();

            // -------------------------------------------------------------------------------------------------------------------------------------------------------------------//

            //prob 2

            console.write("what's your name? ");
            var name = console.readline();

            var array = new char[name.length];
            for (var i = name.length; i > 0; i--)
                array[name.length - i] = name[i - 1];

            var reversed = new string(array);
            console.writeline("reversed name: " + reversed);

            // -------------------------------------------------------------------------------------------------------------------------------------------------------------------//

            // prob 3

            var numbers = new list<int>();

            while (numbers.count < 5)
            {
                console.write("enter a number: ");
                var number = convert.toint32(console.readline());
                if (numbers.contains(number))
                {
                    console.writeline("you've previously entered " + number);
                    continue;
                }

                numbers.add(number);
            }

            numbers.sort();

            foreach (var number in numbers)
                console.writeline(number);

            // -------------------------------------------------------------------------------------------------------------------------------------------------------------------//

            // prob 4

            var numbers = new list<int>();

            while (true)
            {
                console.write("enter a number (or 'quit' to exit): ");
                var input = console.readline();

                if (input.tolower() == "quit")
                    break;

                numbers.add(convert.toint32(input));
            }

            var uniques = new list<int>();
            foreach (var number in numbers)
            {
                if (!uniques.contains(number))
                    uniques.add(number);
            }

            console.writeline("unique numbers:");
            foreach (var number in uniques)
                console.writeline(number);

            // -------------------------------------------------------------------------------------------------------------------------------------------------------------------//

            // loops

            //prob 1

            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            console.writeline("there are {0} numbers ", count);

            // -------------------------------------------------------------------------------------------------------------------------------------------------------------------//

            //prob 2
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all numbers is: " + sum);
        }

        // -------------------------------------------------------------------------------------------------------------------------------------------------------------------//


        //prob 3

        Console.Write("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

        var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine("{0}! = {1}", number, factorial);

         // -------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //prob 4

         var number = new Random().Next(1, 10);

        Console.WriteLine("Secret is " + number);
            for (var i = 0; i< 4; i++)
            {
                Console.Write("Guess the secret number: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You won!");
                    return;
                }
}

Console.WriteLine("You lost!");

         // -------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //prob 5

         Console.Write("Enter commoa separated numbers: ");
            var input = Console.ReadLine();

var numbers = input.Split(',');

var max = Convert.ToInt32(numbers[0]);  

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max is " + max);
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------//


        //Conditional

    //prob1

         Console.Write("Enter a number between 1 to 10: ");
            var input = Console.ReadLine();
var number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");

         // -------------------------------------------------------------------------------------------------------------------------------------------------------------------//


    //prob2
         Console.Write("Enter a number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter another number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

var max = (number1 > number2) ? number1 : number2;
Console.WriteLine("Max is " + max);
         // -------------------------------------------------------------------------------------------------------------------------------------------------------------------//


    //prob3
         Console.Write("Image width: ");
            var width = Convert.ToInt32(Console.ReadLine());

Console.Write("Image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
Console.WriteLine("Image orientation is " + orientation);

    }

         // -------------------------------------------------------------------------------------------------------------------------------------------------------------------//


     //prob 4
        
             Console.Write("What is the speed limit? ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the speed of this car? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed<speedLimit)
                Console.WriteLine("Ok");
            else
            {
                const int kmPerDemeritPoint = 5;
var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }

         // -------------------------------------------------------------------------------------------------------------------------------------------------------------------//

    ////MY OWN PRACICE
    
    //vid 65

     var builder = new StringBuilder();
builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            builder.Replace('-', '+');
            //builder.Remove(0, 10);
            Console.WriteLine(builder);
            //var sentence = "This is going to be ver very vvery very very very very long text ";
            //const int maxLength = 20;
            //if (sentence.Length < maxLength)
            //    Console.WriteLine(sentence);
            //else
            //{
            //    var words = sentence.Split(' ');
            //    var totalCharacter = 0;
            //    foreach (var word in words)
            //    {
            //        totalCharacter += words.Length + 1;
            //        if ()
            //    }
            //}

    //Arrays

                     var firstName = "swarag";
var lastName = "gutte";
var fullName = firstName + " " + lastName;

var names = new string[3] { "A", "B", "C" };
Console.WriteLine(names[1]);
                            var formattedNames = string.Join(",", names);
Console.WriteLine(formattedNames);
                            var text = @"This is C# tutorial 


                ";
Console.WriteLine(text);
                            //Console.WriteLine(fullName);

    //App1

                        //var season = Season.autum;

                                /* switch(season)
                                 {
                                     case Season.autum:
                                         Console.WriteLine("autumn");
                                         break;

                                     case Season.summer:
                                         Console.WriteLine("summer");
                                         break;

                                     case Season.winter:
                                         Console.WriteLine("winter");
                                         break;

                                     case Season.spring:
                                         Console.WriteLine("spring");
                                         break;

                                 }*/

                                Console.Write("Enter a number between 1 to 10: ");
                                // var input = Console.ReadLine();
                                //var number = Convert.ToInt32(input);

                                var input1 = Console.ReadLine();
var number = Convert.ToInt32(input1);
                                if (number >= 1 && number <= 10)
                                    Console.WriteLine("Valid");
                                else
                                    Console.WriteLine("Invalid");

         //Date & Time
             var dateTime = new DateTime(2020, 3, 15);
var now = DateTime.Now;
var today = DateTime.Today;
Console.WriteLine(dateTime);
            Console.WriteLine(today);
            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);

         //Enum

     var method = Shipment.Express;
Console.WriteLine((int) method);

                    //Enum.Parse();
                    var a = 10;
var b = a;
b++;
                    Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

                    var array1 = new int[3] { 1, 2, 3 };
var array2 = array1;
array2[0] = 0;
            
                   // Console.WriteLine(vary);
                    array2[2] = 55;
                    var vary = string.Join(",", array1);
Console.WriteLine(vary);

        //Start

     var john = new Person();
john.FirstName = "john";
            john.LastName = "Smiths";
            john.Introduce();

            var ram = new Person();
ram.FirstName = "Ran";
            ram.LastName = "sham";
            ram.Introduce();

            Calculator calculate = new Calculator();
var result = calculate.Add(1, 2);
System.Console.WriteLine(result);

        //List

        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

//ADD
numbers.Add(5);

            //AddRange
            numbers.AddRange(new int[3] { 6, 7, 8 });

            //Remove
            numbers.Remove(6);

            //Remove AT (count starts from 0.)
            numbers.RemoveAt(3);

            Console.WriteLine(numbers.IndexOf(6));
            Console.WriteLine("number of objects in the list" +numbers.Count);
            foreach (var num in numbers)
                Console.WriteLine(num);

    //Loops

            /*for (var i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            //FOREACH demo
            // var name1 = "john smith";
            //for(var i = 0; i < name1.Length; i++)
            //{
            //    Console.WriteLine(name1[i]);
            //}
            //Console.WriteLine("\n\n");

            //foreach(var char1 in name1)
            //{
            //    Console.WriteLine(char1);
            //}

            var num = new int[5] { 1, 2, 3, 4, 5 };
            foreach(var num1 in num)
            {
                Console.WriteLine(num1);
            }


        //Ref Types

                         //Class
                    public class person
{
    public int Age;
}
class Program
{
    static void Main(string[] args)
    {
        var number = 1;
        Increament(number);
        Console.WriteLine(number);

        var person = new person() { Age = 20 };
        MakeOld(person);
        Console.WriteLine(person.Age);
    }

    //Methods
    public static void Increament(int number)
    {
        number += 10;

    }

    //Methods
    public static void MakeOld(person person)
    {
        person.Age += 10;
    }

    //String

    var fullname = "Swarag sanjay vandana sarthak GUTTE ";
    //Console.WriteLine("Trim : '{0}'",fullname.Trim());
    //Console.WriteLine("Trim : '{0}'",fullname.Trim().ToUpper());
    //Console.WriteLine("Trim : '{0}'",fullname.Trim().ToLower());

    //var index = fullname.IndexOf(' ');
    //var firstName = fullname.Substring(0, index);
    //var lastName = fullname.Substring(index + 1);
    //Console.WriteLine("First Name :- " +firstName);
    //Console.WriteLine("Last Name :- " +lastName);
    var names = fullname.Split(' ');
    Console.WriteLine("name - " +names[0]);
                    Console.WriteLine("name - " +names[1]);
                    Console.WriteLine("name - " +names[2]);
                    Console.WriteLine("name - " +names[3]);
                    Console.WriteLine("name - " +names[4]);
                    var replace = fullname.Replace("GUTTE", "gutte");
    Console.WriteLine("replace : " + replace);

                    var str2 = "25";
    var num = Convert.ToInt32(str2);

    Console.WriteLine(num);

            //While

            //var i = 0;
            //while (i < 10)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);

            //    }
            //    i++;
            //}

            //while (true)
            //{
            //    Console.Write("Type your name");
            //    var input = Console.ReadLine();

            //    if(String.IsNullOrWhiteSpace(input))
            //        break;
            //    Console.WriteLine("@ECHO = " + input);

            //}

            var random = new Random();
    const int wide = 9;
    var buffer = new char[wide];
           
            for (var i = 0; i<wide ; i++)
                buffer[i] = (char) ('a' + random.Next(0, 26));
            var password = new String(buffer);
    Console.WriteLine(password);


        }
    }
}
