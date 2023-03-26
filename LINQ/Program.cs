using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //            Exercise 2
            //-Fork and Clone the repository - Linq Repo to your local computer.
            //-Instructions for forking and cloning a project can be found HERE.
            //-Using Method Syntax, create a list of video games of your choice…
            string[] videoGames = { "Spy vs. Spy", "Contra", "Sonic",
                "Super Mario Bros.", "Tekken", "Metal Gear Solid",
                "Final Fantasy 11", "Zelda", "Call of Duty" };
            //Order the list of games by the length of the game’s names...


            //Be sure to use the lambda expression in this exercise!
            //Bonus - Try to use each of these methods on your list of video games
            //Use the list of Linq methods for help
            //Save and push your work up to your repository
            //- Instructions for pushing to Github for can be found HERE

            videoGames.OrderByDescending(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
            
        }
        
    }
}
