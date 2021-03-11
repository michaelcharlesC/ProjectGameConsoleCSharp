using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairedProject_ConsoleApp
{
    public class ProgramUI
    {

        private MoneyInWallet _repoWalled = new MoneyInWallet();

        User player = new User();



        static void Main(string[] args)
        {


            Console.WriteLine(" WELCOME TO WIN OR DIE\n" +
                "Who is our lucky contestant today?");
            string userName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Great! so how old are you?");
            string ageInput = Console.ReadLine();
            int age = int.Parse(ageInput);
            bool isRunning = true;
            while (isRunning)
            {


                if (age < 24)
                {
                    Console.Clear();
                    Console.WriteLine($" {age} Years old ? Quite young I must say {userName} . Well , I hope you can reach our prize today of $1.000.000 ! \n" +
                        $"======================================================================================\n" +
                        $"\n" +
                        $"\n" +
                        $"Each question will add 1 point to your wallet.\n" +
                        $"If you get at list 15 points into your wallet, you WON. \n" +
                        $"Else...You DIE.");
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Alright! so we have {userName} of age {age}. Lets see if you have what it takes to win $1.000.000 ! \n" +
                        $"======================================================================================" +
                        $"\n" +
                        $"\n" +
                        $"Each question will add 1 point to your wallet.\n" +
                        $"If you get at list 15 points into your wallet, you WON. \n" +
                        $"Else...You DIE.");
                    Console.ReadLine();
                    Console.Clear();

                }
                Console.Clear();

                Console.WriteLine("Do you consent to DIE if you will not reach the goal of 15 points?(y/n)");
                string consent = Console.ReadLine().ToLower();
                Console.Clear();
                switch (consent)
                {
                    case "y":
                        Console.WriteLine("GOOD! I like you already. Let's begin!");
                        Console.ReadKey();
                        Console.Clear();
                        isRunning = false;
                        break;
                    case "n":
                        Console.WriteLine("WHAT? Get out of here!");
                        Console.ReadLine();
                        Environment.Exit(0);

                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        Console.ReadLine();
                        break;

                }
            }
            ProgramUI topic = new ProgramUI();
            topic.TopicSelection();



        }



        public void TopicSelection()
        {

            ProgramUI topicSelectionPage = new ProgramUI();
            Console.WriteLine(" Please choose a topic from below:  \n" +
                "1) History \n" +
                "2) Movies \n" +
                "3) Video Games \n" +
                "4) Random \n" +
                "5) Exit game");


            string topicSelection = Console.ReadLine();
            int topicAsInt = int.Parse(topicSelection);
            switch (topicAsInt)
            {
                case 1:
                    topicSelectionPage.HistoryFirstRound();
                    break;
                case 2:
                    topicSelectionPage.MoviesFirstRound();
                    break;
                case 3:
                    topicSelectionPage.GamesFirstRound();
                    break;
                case 4:
                    topicSelectionPage.RandomRoundOne();
                    break;
                case 5:
                    _repoWalled.ExitGame();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number");
                    break;



            }

        }


        public void HistoryFirstRound()
        {

            User player = new User();
            Console.Clear();




            Console.WriteLine($"Okay, let's see if you know the first and easiest question \n" +
                $"" +
                $"" +
                $"");

            Console.WriteLine("What country was the United States fighting against in the 1950s-70s? \n" +
                "1) North Vietnam \n" +
                "2) Germany \n" +
                "3) Russia \n" +
                "4) North Korea");
            string correctAnswer = Console.ReadLine();
            int answerInt = int.Parse(correctAnswer);

            switch (answerInt)
            {
                case 1:
                    Console.WriteLine("Congradulations! Your answer was correct! you just won 1 point ");
                    _repoWalled.AddCashToWallet(1);
                    

                    break;
                case 2:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: North Vietnam ");
                    break;
                case 3:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: North Vietnam");
                    break;
                case 4:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: North Vietnam");
                    break;
                default:
                    Console.WriteLine("Please enter a valid number. Correct answer: North Vietnam");
                    break;


            }
            Console.ReadLine();
            int cashNowWallet = _repoWalled.CheckCashWallet();
            Console.WriteLine($"You currently have ${cashNowWallet} in your wallet. ");
            _repoWalled.didUserReachedGoal();
            Console.ReadLine();

            ProgramUI hystorySecond = new ProgramUI();
            hystorySecond.HistorySecondround();


        }

        public void HistorySecondround()
        {
            Console.Clear();



            Console.WriteLine($"Second Question!! Prepare yourself. \n" +
                $"" +
                $"" +
                $"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Who was the first President of the United States? \n" +
                "1) Kanye West \n" +
                "2) Abe Lincoln \n" +
                "3) George Washington \n" +
                "4) Oprah");
            string correctAnswer = Console.ReadLine();
            int answerInt = int.Parse(correctAnswer);

            switch (answerInt)
            {
                case 1:
                    Console.WriteLine("WROOONG! This is not correct ");

                    break;
                case 2:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: George Washington");
                    break;
                case 3:
                    Console.WriteLine("Congradulations! Your answer was correct! you just won 1 point ");
                    _repoWalled.AddCashToWallet(1);
                    break;
                case 4:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: George Washington");
                    break;
                default:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: George Washington");
                    break;


            }
            Console.ReadLine();
            int cashNowWallet = _repoWalled.CheckCashWallet();
            Console.WriteLine($"You currently have ${cashNowWallet} in your wallet. ");
            _repoWalled.didUserReachedGoal();
            Console.ReadLine();

            ProgramUI hystorySecond = new ProgramUI();
            hystorySecond.HistoryThirdRound();
        }

        public void HistoryThirdRound()
        {
            Console.Clear();

            User player = new User();

            Console.WriteLine($"Third Question!! Prepare yourself. \n" +
                $"" +
                $"" +
                $"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("World War 2 was ended in the ____ year. \n" +
                "1) 1945 B.C. \n" +
                "2) 1940 \n" +
                "3) 1945\n" +
                "4) 1947");
            string correctAnswer = Console.ReadLine();
            int answerInt = int.Parse(correctAnswer);

            switch (answerInt)
            {
                case 1:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: 1945 ");
                     
                    break;
                case 2:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: 1945");
                    break;
                case 3:
                    Console.WriteLine("Congradulations! Your answer was correct! you just won 1 point ");
                    _repoWalled.AddCashToWallet(1);
                    break;
                case 4:
                    Console.WriteLine("WROOONG! This is not correct.  Correct answer: 1945");
                    break;
                default:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: 1945");
                    break;


            }
            Console.ReadLine();
            int cashNowWallet = _repoWalled.CheckCashWallet();
            Console.WriteLine($"You currently have ${cashNowWallet} in your wallet. ");
            _repoWalled.didUserReachedGoal();
            Console.ReadLine(); ;

            ProgramUI hystorySecond = new ProgramUI();
            hystorySecond.HystoryForthRound();


        }

        public void HystoryForthRound()
        {
            Console.Clear();

            User player = new User();

            Console.WriteLine($"Forth Question!! Prepare yourself. \n" +
                $"" +
                $"" +
                $"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What method of execution was used on King Louis XVI after the French Revolution? \n" +
                "1) Lynched \n" +
                "2) Drowned \n" +
                "3) Stoned \n" +
                "4) Guillotine");
            string correctAnswer = Console.ReadLine();
            int answerInt = int.Parse(correctAnswer);

            switch (answerInt)
            {
                case 1:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer:Guillotine ");

                    break;
                case 2:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer:Guillotine");
                    break;
                case 3:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer:Guillotine ");
                    break;
                case 4:
                    Console.WriteLine("Congradulations! Your answer was correct! you just won 1 point ");
                    _repoWalled.AddCashToWallet(1);
                    break;
                default:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Guillotine");
                    break;



            }
            Console.ReadLine();
            int cashNowWallet = _repoWalled.CheckCashWallet();
            Console.WriteLine($"You currently have ${cashNowWallet} in your wallet. ");
            Console.ReadLine();

            ProgramUI hystorySecond = new ProgramUI();
            hystorySecond.HistoryFifthRound();
        }

        public void HistoryFifthRound()
        {

            Console.Clear();

            User player = new User();

            Console.WriteLine($"Fifth Question!! Prepare yourself. \n" +
                $"" +
                $"" +
                $"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("When was the Great Depression \n" +
                "1) 1929-1933 \n" +
                "2) 1915-1929 \n" +
                "3) 2019-2021 \n" +
                "4) 1914-1918");
            string correctAnswer = Console.ReadLine();
            int answerInt = int.Parse(correctAnswer);

            switch (answerInt)
            {
                case 1:
                    Console.WriteLine("Congradulations! Your answer was correct! you just won 1 point ");
                    _repoWalled.AddCashToWallet(1);
                    break;
                case 2:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer : 1929-1933");
                    break;
                case 3:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer : 1929-1933 ");
                    break;
                case 4:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer : 1929-1933");
                    
                    break;
                default:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: 1929-1933");
                    break;
                    


            }
            Console.ReadLine();
            int cashNowWallet = _repoWalled.CheckCashWallet();
            Console.WriteLine($"You currently have ${cashNowWallet} in your wallet. ");
            _repoWalled.didUserReachedGoal();
            Console.ReadLine();

            ProgramUI hystorySecond = new ProgramUI();
            hystorySecond.TopicSelection();
        }

        public void MoviesFirstRound()
        {
            Console.Clear();

            User player = new User();

            Console.WriteLine($"First Question!! Prepare yourself. \n" +
                $"" +
                $"" +
                $"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Luke Skywalker's father was _____ ________, in Star Wars movie \n" +
                "1) Marty Flaherty \n" +
                "2) Darth Vader \n" +
                "3) Vin Disel \n" +
                "4) Tom Brady");
            string correctAnswer = Console.ReadLine();
            int answerInt = int.Parse(correctAnswer);

            switch (answerInt)
            {
                case 1:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Darth Vader ");

                    break;
                case 2:
                    Console.WriteLine("Congradulations! Your answer was correct! you just won 1 point ");
                    _repoWalled.AddCashToWallet(1);
                    break;
                case 3:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Darth Vader ");
                    break;
                case 4:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Darth Vader");
                    
                    break;
                default:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Darth Vader");
                    break;



            }
            Console.ReadLine();
            int cashNowWallet = _repoWalled.CheckCashWallet();
            Console.WriteLine($"You currently have ${cashNowWallet} in your wallet. ");
            _repoWalled.didUserReachedGoal();
            Console.ReadLine();

            ProgramUI hystorySecond = new ProgramUI();
            hystorySecond.MoviesSecondRound();


        }

        public void MoviesSecondRound()
        {
            Console.Clear();

            User player = new User();

            Console.WriteLine($"Second Question!! Prepare yourself. \n" +
                $"" +
                $"" +
                $"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Which one of these is NOT a villain in Spiderman 3 \n" +
                "1) Venom \n" +
                "2) Sand Man \n" +
                "3) Electro \n" +
                "4) Green Goblin");
            string correctAnswer = Console.ReadLine();
            int answerInt = int.Parse(correctAnswer);

            switch (answerInt)
            {
                case 1:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Electro ");

                    break;
                case 2:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Electro");
                    break;
                case 3:
                    Console.WriteLine("Congradulations! Your answer was correct! you just won 1 point ");
                    _repoWalled.AddCashToWallet(1);
                    break;
                case 4:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Electro");
                    
                    break;
                default:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Electro");
                    break;


            }
            Console.ReadLine();
            int cashNowWallet = _repoWalled.CheckCashWallet();
            Console.WriteLine($"You currently have ${cashNowWallet} in your wallet. ");
            _repoWalled.didUserReachedGoal();
            Console.ReadLine();

            ProgramUI hystorySecond = new ProgramUI();
            hystorySecond.MoviesThirdRound();
        }

        public void MoviesThirdRound()
        {
            Console.Clear();

            User player = new User();

            Console.WriteLine($"Third Question!! Prepare yourself. \n" +
                $"" +
                $"" +
                $"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("In the Harry Potter series what was the headmaster's name? \n" +
                "1) Severus Snape \n" +
                "2) Tom Riddle \n" +
                "3) Gandalf \n" +
                "4) Albus Dumbledore");
            string correctAnswer = Console.ReadLine();
            int answerInt = int.Parse(correctAnswer);

            switch (answerInt)
            {
                case 1:
                    Console.WriteLine("WROOONG! This is not correct.Correct answer: Albus Dumbledore ");

                    break;
                case 2:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Albus Dumbledore");
                    break;
                case 3:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Albus Dumbledore ");
                    break;
                case 4:
                    Console.WriteLine("Congradulations! Your answer was correct! you just won 1 point");
                    _repoWalled.AddCashToWallet(1);
                    break;
                default:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer:  Albus Dumbledore");
                    break;


            }
            Console.ReadLine();
            int cashNowWallet = _repoWalled.CheckCashWallet();
            Console.WriteLine($"You currently have ${cashNowWallet} in your wallet. ");
            _repoWalled.didUserReachedGoal();
            Console.ReadLine();

            ProgramUI hystorySecond = new ProgramUI();
            hystorySecond.MoviesForthRound();
        }

        public void MoviesForthRound()
        {
            Console.Clear();

            User player = new User();

            Console.WriteLine($"Forth Question!! Prepare yourself. \n" +
                $"" +
                $"" +
                $"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("In Pirate's of the Carribean what was the name of the main pirate? \n" +
                "1) Will Turner \n" +
                "2) Blackbeard \n" +
                "3) Kevin Hart \n" +
                "4) Jack Sparrow");
            string correctAnswer = Console.ReadLine();
            int answerInt = int.Parse(correctAnswer);

            switch (answerInt)
            {
                case 1:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer:Jack Sparrow ");

                    break;
                case 2:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer:Jack Sparrow");
                    break;
                case 3:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer:Jack Sparrow ");
                    break;
                case 4:
                    Console.WriteLine("Congradulations! Your answer was correct! you just won 1 point");
                    _repoWalled.AddCashToWallet(1);
                    break;
                default:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Jack Sparrow");
                    break;


            }
            Console.ReadLine();
            int cashNowWallet = _repoWalled.CheckCashWallet();
            Console.WriteLine($"You currently have ${cashNowWallet} in your wallet. ");
            _repoWalled.didUserReachedGoal();
            Console.ReadLine();

            ProgramUI hystorySecond = new ProgramUI();
            hystorySecond.MoviesFifthRound();
        }

        public void MoviesFifthRound()
        {
            Console.Clear();

            User player = new User();

            Console.WriteLine($"Fifth Question!! Prepare yourself. \n" +
                $"" +
                $"" +
                $"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("In Happy Gilmore, what was the main sport in the movie? \n" +
                "1) Football \n" +
                "2) Golf \n" +
                "3) Tenis \n" +
                "4) Cricket");
            string correctAnswer = Console.ReadLine();
            int answerInt = int.Parse(correctAnswer);

            switch (answerInt)
            {
                case 1:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Cricket ");

                    break;
                case 2:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Cricket");
                    break;
                case 3:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Cricket ");
                    break;
                case 4:
                    Console.WriteLine("Congradulations! Your answer was correct! you just won 1 point");
                    _repoWalled.AddCashToWallet(1);
                    break;
                default:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Cricket");
                    break;


            }
            Console.ReadLine();
            int cashNowWallet = _repoWalled.CheckCashWallet();
            Console.WriteLine($"You currently have ${cashNowWallet} in your wallet. ");
            _repoWalled.didUserReachedGoal();
            Console.ReadLine();

            ProgramUI hystorySecond = new ProgramUI();
            hystorySecond.TopicSelection();
        }


        public void GamesFirstRound()
        {
            Console.Clear();

            User player = new User();

            Console.WriteLine($"First Question!! Prepare yourself. \n" +
                $"" +
                $"" +
                $"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What is the name of Mario's rival in the Super Mario franchise? \n" +
                "1) Bowser \n" +
                "2) Sub Zero \n" +
                "3) Ridley \n" +
                "4) Ganon");
            string correctAnswer = Console.ReadLine();
            int answerInt = int.Parse(correctAnswer);

            switch (answerInt)
            {
                case 1:
                    Console.WriteLine("Congradulations! Your answer was correct! you just won 1 point ");
                    _repoWalled.AddCashToWallet(1);
                    break;
                case 2:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Bowser");
                    break;
                case 3:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Bowser ");
                    break;
                case 4:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Bowser");
                    
                    break;
                default:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Bowser");
                    break;


            }
            Console.ReadLine();
            int cashNowWallet = _repoWalled.CheckCashWallet();
            Console.WriteLine($"You currently have ${cashNowWallet} in your wallet. ");
            _repoWalled.didUserReachedGoal();
            Console.ReadLine();

            ProgramUI hystorySecond = new ProgramUI();
            hystorySecond.GamesRoundTwo();
        }

        public void GamesRoundTwo()
        {
            Console.Clear();

            User player = new User();

            Console.WriteLine($"Second Question!! Prepare yourself. \n" +
                $"" +
                $"" +
                $"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What is the main protagonist's name in the Legend of Zelda franchise? \n" +
                "1) Ganondorf \n" +
                "2) Lunk \n" +
                "3) Link \n" +
                "4) Zelda");
            string correctAnswer = Console.ReadLine();
            int answerInt = int.Parse(correctAnswer);

            switch (answerInt)
            {
                case 1:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Link");

                    break;
                case 2:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Link");
                    break;
                case 3:
                    Console.WriteLine("Congradulations! Your answer was correct! you just won 1 point  ");
                    _repoWalled.AddCashToWallet(1);
                    break;
                case 4:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Link");
                    
                    break;
                default:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Link");
                    break;


            }
            Console.ReadLine();
            int cashNowWallet = _repoWalled.CheckCashWallet();
            Console.WriteLine($"You currently have ${cashNowWallet} in your wallet. ");
            _repoWalled.didUserReachedGoal();
            Console.ReadLine();

            ProgramUI hystorySecond = new ProgramUI();
            hystorySecond.GamesRoundThree();
        }

        public void GamesRoundThree()
        {
            Console.Clear();

            User player = new User();

            Console.WriteLine($"Third Question!! Prepare yourself. \n" +
                $"" +
                $"" +
                $"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What is the name of the Banshee Queen in WoW \n" +
                "1) Sylvanas \n" +
                "2) Serena \n" +
                "3) Brethelda \n" +
                "4) Sylvia");
            string correctAnswer = Console.ReadLine();
            int answerInt = int.Parse(correctAnswer);

            switch (answerInt)
            {
                case 1:
                    Console.WriteLine("Congradulations! Your answer was correct! you just won 1 point");
                    _repoWalled.AddCashToWallet(1);
                    break;
                case 2:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Sylvanas");
                    break;
                case 3:
                    Console.WriteLine(" WROOONG! This is not correct. Correct answer: Sylvanas ");
                    break;
                case 4:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Sylvanas");
                    
                    break;
                default:
                    Console.WriteLine(" WROOONG! This is not correct. Correct answer: Sylvanas ");
                    break;



            }
            Console.ReadLine();
            int cashNowWallet = _repoWalled.CheckCashWallet();
            Console.WriteLine($"You currently have ${cashNowWallet} in your wallet. ");
            _repoWalled.didUserReachedGoal();
            Console.ReadLine();

            ProgramUI hystorySecond = new ProgramUI();
            hystorySecond.GamesRoundFour();
        }

        public void GamesRoundFour()
        {
            Console.Clear();

            User player = new User();

            Console.WriteLine($"Forth Question!! Prepare yourself. \n" +
                $"" +
                $"" +
                $"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What does RPG stand for? \n" +
                "1) Roleplaying Game \n" +
                "2) Role Playing Gang \n" +
                "3) Right Person Game \n" +
                "4) Rocket Propelled Grenade Luncher ");
            string correctAnswer = Console.ReadLine();
            int answerInt = int.Parse(correctAnswer);

            switch (answerInt)
            {
                case 1:
                    Console.WriteLine("Congradulations! Your answer was correct! you just won 1 point");
                    _repoWalled.AddCashToWallet(1);
                    break;
                case 2:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer : Roleplaying Game ");
                    break;
                case 3:
                    Console.WriteLine(" WROOONG! This is not correct. Correct answer :Roleplaying Game");
                    break;
                case 4:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer :Roleplaying Game");
                    break;
                default:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer :Roleplaying Game");
                    break;




            }
            Console.ReadLine();
            int cashNowWallet = _repoWalled.CheckCashWallet();
            Console.WriteLine($"You currently have ${cashNowWallet} in your wallet. ");
            _repoWalled.didUserReachedGoal();
            Console.ReadLine();

            ProgramUI hystorySecond = new ProgramUI();
            hystorySecond.GamesRoundFive();
        }

        public void GamesRoundFive()
        {
            Console.Clear();

            User player = new User();

            Console.WriteLine($"Fifth Question!! Prepare yourself. \n" +
                $"" +
                $"" +
                $"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Which of these card games is only playable with one person? \n" +
                "1) Black Jack \n" +
                "2) Solitaire \n" +
                "3) Slap Jack \n" +
                "4) Poker ");
            string correctAnswer = Console.ReadLine();
            int answerInt = int.Parse(correctAnswer);

            switch (answerInt)
            {
                case 1:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Solitaire");

                    break;
                case 2:
                    Console.WriteLine(" Congradulations! Your answer was correct! you just won 1 point ");
                    _repoWalled.AddCashToWallet(1);
                    break;
                case 3:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Solitaire");
                    
                    break;
                case 4:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Solitaire");
                    break;
                default:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Solitaire");
                    break;



            }
            Console.ReadLine();
            int cashNowWallet = _repoWalled.CheckCashWallet();
            Console.WriteLine($"You currently have ${cashNowWallet} in your wallet. ");
            _repoWalled.didUserReachedGoal();
            Console.ReadLine();

            ProgramUI hystorySecond = new ProgramUI();
            hystorySecond.TopicSelection();
        }


        public void RandomRoundOne()
        {
            Console.Clear();

            User player = new User();

            Console.WriteLine($"First Question!! Prepare yourself. \n" +
                $"" +
                $"" +
                $"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Hunting unicorns is legal in which City? \n" +
                "1) Indiana \n" +
                "2) Michigan \n" +
                "3) Moscow \n" +
                "4) Amsterdam ");
            string correctAnswer = Console.ReadLine();
            int answerInt = int.Parse(correctAnswer);

            switch (answerInt)
            {
                case 1:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Michigan");

                    break;
                case 2:
                    Console.WriteLine("Congradulations! Your answer was correct! you just won 1 point");
                    _repoWalled.AddCashToWallet(1);
                    break;
                case 3:
                    Console.WriteLine(" WROOONG! This is not correct. Correct answer: Michigan ");
                    break;
                case 4:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Michigan");
                    
                    break;
                default:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Michigan");
                    break;



            }
            Console.ReadLine();
            int cashNowWallet = _repoWalled.CheckCashWallet();
            Console.WriteLine($"You currently have ${cashNowWallet} in your wallet. ");
            _repoWalled.didUserReachedGoal();
            Console.ReadLine();

            ProgramUI hystorySecond = new ProgramUI();
            hystorySecond.RandomRoundTwo();
        }


        public void RandomRoundTwo()
        {
            Console.Clear();

            User player = new User();

            Console.WriteLine("Second Question!! Prepare yourself. \n" +
                $"" +
                $"" +
                $"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What is the world's largest ocean?  \n" +
                "1) Pacific \n" +
                "2) Michigan Lake \n" +
                "3) Atlantic \n" +
                "4) The Black Sea ");
            string correctAnswer = Console.ReadLine();
            int answerInt = int.Parse(correctAnswer);

            switch (answerInt)
            {
                case 1:
                    Console.WriteLine("Congradulations! Your answer was correct! you just won 1 point");
                    _repoWalled.AddCashToWallet(1);
                    break;
                case 2:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Pacific");
                    break;
                case 3:
                    Console.WriteLine(" WROOONG! This is not correct. Correct answer: Pacific ");
                    break;
                case 4:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Pacific");
                    _repoWalled.AddCashToWallet(1);
                    break;
                default:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Pacific");
                    break;


            }
            Console.ReadLine();
            int cashNowWallet = _repoWalled.CheckCashWallet();
            Console.WriteLine($"You currently have ${cashNowWallet} in your wallet. ");
            _repoWalled.didUserReachedGoal();
            Console.ReadLine();

            ProgramUI hystorySecond = new ProgramUI();
            hystorySecond.RandomRoundThree();
        }

        public void RandomRoundThree()
        {
            Console.Clear();

            User player = new User();

            Console.WriteLine("Third Question!! Prepare yourself. \n" +
                $"" +
                $"" +
                $"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(" In the past, there have been __ versions of the American flag.  \n" +
                "1) 5 \n" +
                "2) 4 \n" +
                "3) 2 \n" +
                "4) 27 ");
            string correctAnswer = Console.ReadLine();
            int answerInt = int.Parse(correctAnswer);

            switch (answerInt)
            {
                case 1:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: 27");

                    break;
                case 2:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: 27");
                    break;
                case 3:
                    Console.WriteLine(" WROOONG! This is not correct . Correct answer: 27");
                    break;
                case 4:
                    Console.WriteLine("Congradulations! Your answer was correct! you just won 1 point");
                    _repoWalled.AddCashToWallet(1);
                    break;
                default:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: 27");
                    break;


            }
            Console.ReadLine();
            int cashNowWallet = _repoWalled.CheckCashWallet();
            Console.WriteLine($"You currently have ${cashNowWallet} in your wallet. ");
            _repoWalled.didUserReachedGoal();
            Console.ReadLine();

            ProgramUI hystorySecond = new ProgramUI();
            hystorySecond.TopicSelection();
        }


        public void RandomRoundFour()
        {
            Console.Clear();

            User player = new User();

            Console.WriteLine("Forth Question!! Prepare yourself. \n" +
                $"" +
                $"" +
                $"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(" There is more _____ than people in Kentucky.  \n" +
                "1) Guns \n" +
                "2) Fried Chicken \n" +
                "3) Bourbon \n" +
                "4) Cars ");
            string correctAnswer = Console.ReadLine();
            int answerInt = int.Parse(correctAnswer);

            switch (answerInt)
            {
                case 1:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Bourbon");

                    break;
                case 2:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Bourbon");
                    break;
                case 3:
                    Console.WriteLine(" Congradulations! Your answer was correct! you just won 1 point ");
                    _repoWalled.AddCashToWallet(1);
                    break;
                case 4:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Bourbon");
                    
                    break;
                default:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: Bourbon");
                    break;

            }
            Console.ReadLine();
            int cashNowWallet = _repoWalled.CheckCashWallet();
            Console.WriteLine($"You currently have ${cashNowWallet} in your wallet. ");
            _repoWalled.didUserReachedGoal();
            Console.ReadLine();

            ProgramUI hystorySecond = new ProgramUI();
            hystorySecond.TopicSelection();
        }

        public void RandomRoundFifth()
        {
            Console.Clear();

            User player = new User();

            Console.WriteLine("Fifth Question!! Prepare yourself. \n" +
                $"" +
                $"" +
                $"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(" The Statue of Liberty, was a gift from _____?  \n" +
                "1) Canada \n" +
                "2) China \n" +
                "3) Russia \n" +
                "4) France ");
            string correctAnswer = Console.ReadLine();
            int answerInt = int.Parse(correctAnswer);

            switch (answerInt)
            {
                case 1:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: France");

                    break;
                case 2:
                    Console.WriteLine("WROOONG! This is not correct. Correct answer: France");
                    break;
                case 3:
                    Console.WriteLine(" WROOONG! This is not correct. Correct answer:France ");
                    break;
                case 4:
                    Console.WriteLine("Congradulations! Your answer was correct! you just won 1 point");
                    _repoWalled.AddCashToWallet(1);
                    break;
                default:
                    Console.WriteLine(" WROOONG! This is not correct. Correct answer:France ");
                    break;


            }
            Console.ReadLine();
            int cashNowWallet = _repoWalled.CheckCashWallet();
            Console.WriteLine($"You currently have ${cashNowWallet} in your wallet. ");
            _repoWalled.didUserReachedGoal();
            Console.ReadLine();

            ProgramUI hystorySecond = new ProgramUI();
            hystorySecond.TopicSelection();

        }

        
    }
}
