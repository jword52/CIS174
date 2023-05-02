using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectComicsWebApp.Models
{
    //holds the current comic that the user is looking at, in order to perform actions like adding or editing reviews
    public static class CurrentComic
    {
        public static Comic Current { get; set; }
    }
}
