using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter a color: ");
            var color = Console.ReadLine();
            
            while (name == "Matt" || name == "Eric" || color == "Red" || color == "Blue")
            {
                Console.WriteLine("Fuck you, buddy!");
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
                Console.Write("Enter a color: ");
                color = Console.ReadLine();
            }

            Console.WriteLine("You're Awesome!\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("quu..__                                                                      ");
            Console.WriteLine(" $$$b  `---.__                                                               ");
            Console.WriteLine("  \"$$b        `--.                          ___.---uuudP                     ");
            Console.WriteLine("   `$$b           `.__.------.__     __.---'      $$$$\"              .       ");
            Console.WriteLine("     \"$b          -'            `-.-'            $$$\"              .'|       ");
            Console.WriteLine("       \".                                       d$\"             _.'  |       ");
            Console.WriteLine("         `.   /                              ...\"             .'     |       ");
            Console.WriteLine("           `./                           ..::-'            _.'       |       ");
            Console.WriteLine("            /                         .:::-'            .-'         .'       ");
            Console.WriteLine("           :                          ::''\\          _.'            |        ");
            Console.WriteLine("          .' .-.             .-.           `.      .'               |        ");
            Console.WriteLine("          : /'$$|           .@\"$\\           `.   .'              _.-'        ");
            Console.WriteLine("         .'|$u$$|          |$$,$$|           |  <            _.-'            ");
            Console.WriteLine("         | `:$$:'          :$$$$$:           `.  `.       .-'                ");
            Console.WriteLine("         :                  `\"--'             |    `-.     \\                 ");
            Console.Write("        :##.       ==             ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(".###.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("       `.      `.    `\\               ");
            Console.WriteLine("        |##:                      :###:        |        >     >              ");
            Console.WriteLine("        |#'     `..'`..'          `###'        x:      /     /               ");
            Console.WriteLine("         \\                                   xXX|     /    ./                ");
            Console.WriteLine("          \\                                xXXX'|    /   ./                  ");
            Console.WriteLine("          /`-.                                  `.  /   /                    ");
            Console.WriteLine("         :    `-  ...........,                   | /  .'                     ");
            Console.WriteLine("         |         ``:::::::'       .            |<    `.                    ");
            Console.WriteLine("         |             ```          |           x| \\ `.:``.                  ");
            Console.WriteLine("         |                         .'    /'   xXX|  `:`M`M':.                ");
            Console.WriteLine("         |    |                    ;    /:' xXXX'|  -'MMMMM:'                ");
            Console.WriteLine("         `.  .'                   :    /:'       |-'MMMM.-'                  ");
            Console.WriteLine("          |  |                   .'   /'        .'MMM.-'                     ");
            Console.WriteLine("          `'`'                   :  ,'          |MMM<                        ");
            Console.WriteLine("            |                     `'            |tbap\\                       ");
            Console.WriteLine("             \\                                  :MM.-'                       ");
            Console.WriteLine("              \\                 |              .''                           ");
            Console.WriteLine("               \\.               `.            /                              ");
            Console.WriteLine("                /     .:::::::.. :           /                               ");
            Console.WriteLine("               |     .:::::::::::`.         /                                ");
            Console.WriteLine("               |   .:::------------\\       /                                 ");
            Console.WriteLine("              /   .''               >::'  /                                  ");
            Console.WriteLine("              `',:                 :    .'                                   ");
                                    

            Console.ReadKey();
        }
    }
}
