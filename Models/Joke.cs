using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebAppDotNet.Models
{
    public class Joke
    {
        // enter prop and hit tab twice
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }

        // enter ctor and hit tab to create function constructor
        public Joke()
        {

        }
    }
}
