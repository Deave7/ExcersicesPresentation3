namespace ExcersicesPresentation3
{
    internal class Program
    {
        static void Exempel1() //Övning 1
        {
            int largeNumber = 1; //Initierar variablen largeNumber och sätter dess värde till 1
            int smallNumber = 2; //Initierar variablen smallNumber och sätter dess värde till 2

            if (largeNumber < smallNumber) //Om largeNumber är mindre än small number
            {
                //byt värde på smallNumber och largeNumber
                int temporaryNumber = smallNumber;
                smallNumber = largeNumber;
                largeNumber = temporaryNumber;



                Console.WriteLine($"Large number: {largeNumber} and small number: {smallNumber}"); //Skriver ut 
            }
        }

        static void Exempel2() //Övning 2
        {
            //Får våra tre värden från användaren
            Console.WriteLine("Please enter the first number: ");
            double numOne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            double numTwo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the third number: ");
            double numThree = Convert.ToDouble(Console.ReadLine());

            int negativeCount = 0; //Initierar variablen negativeCount och sätter den till 0

            if (numOne < 0) //Om första numret är mindre än 0
            {
                negativeCount++; //lägg till 1 på negativeCounts värde
            }
            if (numTwo < 0)
            {
                negativeCount++;
            }
            if (numThree < 0)
            {
                negativeCount++;
            }

            if (negativeCount % 2 == 0) //Om negativeCount delat på två = 0 skriv ut + annars är talet - 
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }

        static void Exempel3() //Övning 3
        {
            //Initierar variabler
            int numberOne = 30;
            int numberTwo = 30;
            int numberThree = 30;

            if (numberOne > numberTwo) //OM numberOne är större än numberTwo
            {
                if (numberOne > numberThree) //OM numberOne > numberThree
                {
                    Console.WriteLine(numberOne + " is the largest number");  //Skriver ut resultatet
                }
                else
                {
                    Console.WriteLine(numberThree + " is the largest number"); 
                }
            }

            else if (numberTwo > numberOne)
            {
                if (numberTwo > numberThree)
                {
                    Console.WriteLine(numberTwo + " is the largest number");
                }
                else
                {
                    Console.WriteLine(numberThree + " is the largest number");
                }
            }
            else
            {
               Console.WriteLine("Skriv inte in tre av samma tal");
            }
        }

        static void Exempel4() //Övning 4 
        {
            //Initiering av variabler 
            double smallestNumber = 1000;
            double middleNumber = 500;
            double largestNumber = 600;

            if (largestNumber > middleNumber && largestNumber > smallestNumber) //Om largestNumber är störst
            {
                if (middleNumber > smallestNumber) //Om middleNumber är större än smallestNumber
                {
                    Console.WriteLine("The smallest number is: " + smallestNumber);
                    Console.WriteLine("The middle number is: " + middleNumber);
                    Console.WriteLine("The largest number is: " + largestNumber);
                }
                else if (smallestNumber > middleNumber) //Om smallestNumber är större än middleNumber
                {
                    //Byt plats på smallestNumber och middleNumber
                    double temp = middleNumber;
                    middleNumber = smallestNumber;
                    smallestNumber = temp;

                    Console.WriteLine("The smallest number is: " + smallestNumber);
                    Console.WriteLine("The middle number is: " + middleNumber);
                    Console.WriteLine("The largest number is: " + largestNumber);
                }

            }
            else if (middleNumber > largestNumber && middleNumber > smallestNumber) //Om middleNubmer är störst
            {
                //Byt plats på middleNumber och largestNumber
                double temp = largestNumber;
                largestNumber = middleNumber;
                middleNumber = temp;

                if (middleNumber > smallestNumber) //Om middle number är större än smallestNumber
                {
                    Console.WriteLine("The smallest number is: " + smallestNumber);
                    Console.WriteLine("The middle number is: " + middleNumber);
                    Console.WriteLine("The largest number is: " + largestNumber);
                }
                else if (smallestNumber > middleNumber) //Om smallestNumber är större än middleNumber
                {
                    //Byt plats på middleNumber och smallestNumber
                    double tempOne = middleNumber;
                    middleNumber = smallestNumber;
                    smallestNumber = tempOne;

                    Console.WriteLine("The smallest number is: " + smallestNumber);
                    Console.WriteLine("The middle number is: " + middleNumber);
                    Console.WriteLine("The largest number is: " + largestNumber);
                }
            }
            else if (smallestNumber > largestNumber && smallestNumber > middleNumber) //Om smallestNumber är störst (egentligen inte nödvändigt, skulle funkat med else
            {
                //Byt plats på smallestNumber och largestNumber
                double temp = largestNumber;
                largestNumber = smallestNumber;
                smallestNumber = temp;

                if (middleNumber > smallestNumber) //Om middleNumber är större än smallestNumber
                {
                    Console.WriteLine("The smallest number is: " + smallestNumber);
                    Console.WriteLine("The middle number is: " + middleNumber);
                    Console.WriteLine("The largest number is: " + largestNumber);
                }
                else if (smallestNumber > middleNumber) //om smallestNumber är större än middleNumber
                {
                    //Byt plats på smallestNumber och middleNumber
                    double tempOne = middleNumber;
                    middleNumber = smallestNumber;
                    smallestNumber = tempOne;

                    Console.WriteLine("The smallest number is: " + smallestNumber);
                    Console.WriteLine("The middle number is: " + middleNumber);
                    Console.WriteLine("The largest number is: " + largestNumber);
                }
            }
        }

        static void Exempel5() //Övning 5
        {
            while (true) //Loopen alltid efter som (true) aldrig blir (false) 
            {
                Console.WriteLine("Please input a figure (0-9): ");
                int choice = Convert.ToInt32(Console.ReadLine()); //Initierar och sätter värdet till variablen choice, omvandlar användarens svar från en string till int

                switch (choice) //Switch sats som kollar på variablen choice
                {
                    case 0: //Om choice = 0 
                        Console.WriteLine("Noll"); //Skriv ut 
                        break; //Gå ur switch satsen 

                    case 1:
                        Console.WriteLine("Ett");
                        break;

                    case 2:
                        Console.WriteLine("Två");
                        break;

                    case 3:
                        Console.WriteLine("Tre");
                        break;

                    case 4:
                        Console.WriteLine("Fyra");
                        break;

                    case 5:
                        Console.WriteLine("Fem");
                        break;

                    case 6:
                        Console.WriteLine("Sex");
                        break;

                    case 7:
                        Console.WriteLine("Sju");
                        break;

                    case 8:
                        Console.WriteLine("Åtta");
                        break;

                    case 9:
                        Console.WriteLine("Nio");
                        break;

                    default: //Om användaren inte ger en siffra 
                        Console.WriteLine("Please input a figure (0-9) ");
                        break;
                }
            }
        }

        static void Exempel6() //Övning 6
        {
            Console.WriteLine("Please enter the coefficients a, b and c for the following equation: a*x2+b*x+c=0");

            Console.WriteLine("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine()); //intierar variablen a och sätter värdet till det användaren skriver

            Console.WriteLine("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine()); //intierar variablen b och sätter värdet till det användaren skriver

            Console.WriteLine("Enter c: ");
            int c = Convert.ToInt32(Console.ReadLine()); //intierar variablen c och sätter värdet till det användaren skriver

            double discriminant = b * b - 4 * a * c; //Någon matte??

            if (discriminant > 0) //Om discriminant är mindre än 0 så har ekvationen två reella rötter
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a); //+ rot
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a); //- rot
                Console.WriteLine($"Two distinct real roots: {root1}, {root2}"); //skriver ut 
            }
            else if (discriminant == 0) //Om discriminant är 0 har den en reell rot
            {
                double root = -b / (2 * a); //Nån matte?
                Console.WriteLine($"One real root: {root}"); //Skriver ut
            }
            else //Om inget ovan stämmer har ekvationen inga rötter 
            {
                Console.WriteLine("No real roots.");
            }
        }

        static void Exempel7() //Övning 7 
        {
            Console.WriteLine("Please input five numbers: "); 

            //Initierar variabler att spara användar input i 

            Console.WriteLine("Please input the first number: ");
            int numOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input the first number: ");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input the first number: ");
            int numThree = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input the first number: ");
            int numFour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input the first number: ");
            int numFive = Convert.ToInt32(Console.ReadLine());

            //If satser för om varje variabel är störst. Varje if sats kollar av om t.ex. numOne är större än de andra 4 variablerna

            if (numOne > numTwo && numOne > numThree && numOne > numFour && numOne > numFive) 
            {
                Console.WriteLine($"{numOne} is the largest number");
            }
            else if (numTwo > numOne && numTwo > numThree && numTwo > numFour && numTwo > numFive)
            {
                Console.WriteLine($"{numTwo} is the largest number");
            }
            else if (numThree > numOne && numThree > numTwo && numThree > numFour && numThree > numFive)
            {
                Console.WriteLine($"{numThree} is the largest number");
            }
            else if (numFour > numOne && numFour > numThree && numFour > numTwo && numFour > numFive)
            {
                Console.WriteLine($"{numFour} is the largest number");
            }
            else if (numFive > numOne && numFive > numThree && numFive > numFour && numFive > numTwo)
            {
                Console.WriteLine($"{numFive} is the largest number");
            }
        }

        static void Exempel8() //Övning 8
        {
            while (true) //Loopar för evigt. Tillagt för att man ska få chansen att välja igen och fortsätta testa utan att hela tiden starta om programmet 
            {
                //Skriver ut en meny 
                Console.WriteLine("Please pick one of the following to input: ");
                Console.WriteLine("[I]nt");
                Console.WriteLine("[D]ouble");
                Console.WriteLine("[S]tring");
                string choice = Console.ReadLine().ToUpper(); //Sätter string choice till värdet som användaren ger och gör om värdet till en stor bokstav

                switch (choice) //Switch sats som kollar på variablen choice)
                {
                    case "I": //Om I
                    case "D": //Om D
                        Console.WriteLine("Please enter your number: "); 
                        double input = Convert.ToDouble(Console.ReadLine()); //Initierar och sätter värdet till variablen input. Omvandlar användarens svar från en string till en double 
                        input++; //Lägger till +1 till inputs värde
                        Console.WriteLine(input + "\n"); //Skriver ut input och gör en ny rad
                        break; //går ur switch satsen 

                    case "S": //Om S
                        Console.WriteLine("Please enter your string: ");
                        string input2 = Console.ReadLine();
                        input2 += "*";
                        Console.WriteLine(input2 + "\n");
                        break;

                    default: //Om varken I, D eller S 
                        Console.WriteLine("Please enter one of the choices\n");
                        break;
                }
            }
        }

        static void Exempel9() //Övning 9
        {
            Console.WriteLine("Please input five numbers: ");

            //Initierar variabler att spara användar input i 
           
            int numOne = Convert.ToInt32(Console.ReadLine());           
            int numTwo = Convert.ToInt32(Console.ReadLine());           
            int numThree = Convert.ToInt32(Console.ReadLine());          
            int numFour = Convert.ToInt32(Console.ReadLine());
            int numFive = Convert.ToInt32(Console.ReadLine());

            bool subsetSumZeroExists = false;

            //Kollar om någon version av de fem talen leder till att summan blir 0. Lite löjligt utan loopar och andra saker. 
            if (numOne + numTwo + numThree + numFour + numFive == 0)
            {
                subsetSumZeroExists = true;
            }
            else if (numOne + numTwo + numThree + numFour == 0)
            {
                subsetSumZeroExists = true;
            }
            else if (numOne + numTwo + numThree + numFive == 0)
            {
                subsetSumZeroExists = true;
            }
            else if (numOne + numTwo + numFour + numFive == 0)
            {
                subsetSumZeroExists = true;
            }
            else if (numOne + numThree + numFour + numFive == 0)
            {
                subsetSumZeroExists = true;
            }
            else if (numTwo + numThree + numFour + numFive == 0)
            {
                subsetSumZeroExists = true;
            }
            else if (numOne + numTwo + numThree == 0)
            {
                subsetSumZeroExists = true;
            }
            else if (numOne + numTwo + numFour == 0)
            {
                subsetSumZeroExists = true;
            }
            else if (numOne + numTwo + numFive == 0)
            {
                subsetSumZeroExists = true;
            }
            else if (numOne + numThree + numFour == 0)
            {
                subsetSumZeroExists = true;
            }
            else if (numOne + numThree + numFive == 0)
            {
                subsetSumZeroExists = true;
            }
            else if (numOne + numFour + numFive == 0)
            {
                subsetSumZeroExists = true;
            }
            else if (numTwo + numThree + numFour == 0)
            {
                subsetSumZeroExists = true;
            }
            else if (numTwo + numThree + numFive == 0)
            {
                subsetSumZeroExists = true;
            }
            else if (numTwo + numFour + numFive == 0)
            {
                subsetSumZeroExists = true;
            }
            else if (numThree + numFour + numFive == 0)
            {
                subsetSumZeroExists = true;
            }

            if (subsetSumZeroExists)
            {
                Console.WriteLine("There exists a subset of numbers that equals 0.");
            }
            else
            {
                Console.WriteLine("There is no subset of numbers that equals 0.");
            }
        }

        static void Exempel10() //Övning 10
        {
            
            Console.WriteLine("Please enter your points! [1-9]: "); //Ber användaren om input
            int points = Convert.ToInt32(Console.ReadLine()); //Initierar variablen points och sätter värdet till användarinput. Konverterar användarens svar från en string till en int

            switch (points)
            {
                case 1: //Om 1 
                case 2: //Om 2
                case 3: //Om 3
                    int result = points * 10; //intiera variablen result och sätt dess värdet till points multiplicerat med 10 
                    Console.WriteLine("Your new total is: " + result); //Skriv ut 
                    break; //gå ur switch satsen 

                case 4: 
                case 5:
                case 6:
                    int resultTwo = points * 100;
                    Console.WriteLine("Your new total is: " + resultTwo);
                    break;
                case 7:
                case 8:
                case 9:
                    int resultThree = points * 1000;
                    Console.WriteLine("Your new total is: " + resultThree);
                    break;

                default: //Om man ej skriver en siffra mellan 1 och 9 
                    Console.WriteLine("Please enter a number between 1 and 9");
                    break;
            }
        }

        static void Exempel11() //Övning 11
        {
            Console.WriteLine("Please enter a number between 1-999: ");
            int number = int.Parse(Console.ReadLine()); //Initierar och sätter värdet till det som användaren skrivit 

            string result = ""; //initierar variablen result till en tom sträng 

            if (number == 0) //Om variablen number är likamed 0 
            {
                result = "Zero"; //Skriv ut 
            }
            else //Annars 
            {
                //intierar fält med värden för att skriva ut siffror med ord 
                string[] onesPlace = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" }; //börjar med en tom sträng för att de andra värdena ska hamna på rätt plats 
                string[] tensPlace = { "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
                string[] teenNumbers = { "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

                int hundreds = number / 100; //initierar variablen hundreds och sätter värdet hur många 100-tal vi har. (genom uträkningen) 
                int tens = (number / 10) % 10; //initierar variablen tens och sätter värdet hur många 10-tal vi har. (genom uträkningen) 
                int ones = number % 10; //initierar variablen ones och sätter värdet hur många 1-tal vi har. (genom uträkningen) 

                result += hundreds > 0 ? onesPlace[hundreds] + " Hundred" : ""; // OM hundreds är större än 0 körs det som är bakom "?" alltså lägger vi till värdet från fältet onesPlace[värdet på hundreds] + ordet Hundred och ett mellanslag
                result += tens > 1 ? " " + tensPlace[tens - 1] : (tens == 1 ? " " + teenNumbers[ones - 1] : ""); //OM tens är större än 1 körs det bakom "?" alltså lägger vi till ett mellanslag + värdet på fältet tensPlace[värdet på tens - 1]. OM tens är 1 så lägger vi istället till mellanslag + värdet på fältet teenNumbers[värdet på ones -1
                result += tens != 1 && ones > 0 ? " " + onesPlace[ones] : ""; //Om tens INTE är 1 och ones är större än 0 körs det bakom "?" alltså lägger vi till mellanslag + värdet från fältet onesPlace[värdet på ones] + mellanslag 
            }

            Console.WriteLine("Number in words: " + result);
        }

        static void Main(string[] args)
        {
            
        }
    }
}
    
