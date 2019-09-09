using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackoverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Post p = new Post("Android X not working", "blah blah");
            p.upVote();
            p.upVote();
            p.downVote();
            Console.WriteLine("votes :{0}", p.showVotes()); 
            
        }
    }
}
