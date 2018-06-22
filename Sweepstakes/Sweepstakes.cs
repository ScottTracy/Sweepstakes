using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public Dictionary<int,Contestant> contestants = new Dictionary<int,Contestant>();
        public int registrationNumber=1;
        string name;
        public Sweepstakes(String name)
        {
            this.name = name;
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestant.GetInfo();
            contestants.Add(registrationNumber, contestant);
            contestant.registration = registrationNumber;
            registrationNumber++;
        }
        public string PickWinner()
        {
            Random random = new Random();
            int winningNumber = random.Next(1, registrationNumber - 1);
            Contestant winner = contestants[winningNumber];
            return winner.firstName + " " + winner.lastName;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            contestant.MakeDictionary();
            foreach (KeyValuePair<string, string> identity in contestant.info)
            {
                Console.WriteLine(identity.Key + ": " + identity.Value);
            }
            Console.ReadLine();

        }
    }
}
