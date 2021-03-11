using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairedProject_ConsoleApp
{
    public class User
    {

        public decimal MoneyInWallet { get; set; }


        public User() { }
       
    }

    public class MoneyInWallet
    {
       static List<int> _cashInWallet = new List<int>();

        public void AddCashToWallet(int cash)
        {
            _cashInWallet.Add(cash);
        }

        public int CheckCashWallet()
        {
            int cashNowWallet = _cashInWallet.Count;
            return cashNowWallet;
        }

        public void didUserReachedGoal()
        {
           if(_cashInWallet.Count >= 15)
            {
                Console.WriteLine("Congratz! You have reached the goal of 15 points. Enjoy your prize of $1.000.000");
                Console.ReadKey();
                ExitGame();

            }
           

                
                
                
            
        }
        public void ExitGame()
        {
            Console.WriteLine("Bye Bye!");
            Environment.Exit(0);
        }
    }


     
}
