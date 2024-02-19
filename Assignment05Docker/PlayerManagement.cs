using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05Docker
{
    public  class PlayerManagement
    {
      static  List<Players> players = new List<Players>() { 
        new Players(){PId=1,Name="Lionel Messi",Team="Paris Saint-Germain",Role="Forward",jersey_number=30,Age=34},
        new Players(){PId=2,Name="Cristiano Ronaldo",Team="Manchester United",Role="Forward",jersey_number=7,Age=37},
        new Players(){PId=3,Name="Neymar Jr.",Team="Paris Saint-Germain",Role="Forward",jersey_number=10,Age=30},
        new Players(){PId=4,Name="Kevin De Bruyne",Team="Manchester City",Role="Midfielder",jersey_number=17,Age=30},
        new Players(){PId=5,Name="Robert Lewandowski",Team="Bayern Munich",Role="Forward",jersey_number=9,Age=33},
        new Players(){PId=6,Name="Virgil van Dijk",Team="Liverpool",Role="Defender",jersey_number=4,Age=31},
        };

        public static void GetAllPlayers()
        {
            Console.WriteLine($"{"P_ID",-5} {"Name",-20} {"Team",-20} {"Role",-15} {"Jersey No",-10} {"Age",-5}");
            foreach (Players player in players)
            {
               

                Console.WriteLine($"{player.PId,-5} {player.Name,-20} {player.Team,-20} {player.Role,-15} {player.jersey_number,-10} {player.Age,-5}");
            }
        }

        public static void GetPlayerById(int id) 
        {
            Console.WriteLine($"{"P_ID",-5} {"Name",-20} {"Team",-20} {"Role",-15} {"Jersey No",-10} {"Age",-5}");
            List<Players> p = players.FindAll(x=>x.PId == id);
            foreach(Players player in p)
            {
                
                Console.WriteLine($"{player.PId,-5} {player.Name,-20} {player.Team,-20} {player.Role,-15} {player.jersey_number,-10} {player.Age,-5}");

            }
        }
    }
   
}
