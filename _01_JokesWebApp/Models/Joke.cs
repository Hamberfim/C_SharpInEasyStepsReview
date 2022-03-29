using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_JokesWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }

        // constructor below will be populated automatically 
        public Joke()
        {
            
        }
    }



}
