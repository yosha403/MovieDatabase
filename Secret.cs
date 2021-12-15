using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDatabase
{
    public class Secret
    {
        //we make this statc so that we don't need to create a secret object we can simply call 
        public static string Connection { get; set; } = $"server=localhost;uid=root;pwd=abc123;database=moviedb";
    }
}
