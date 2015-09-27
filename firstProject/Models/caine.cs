using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Linq;

namespace firstProject.Models
{    

    public class animal
    {
        private int _picioare { get; set; }
        
        public int Picioare { get ; set; }
        public string Culoare { get; set; }
    }

    public class caine : animal
    {
        public caine()
        {

            Caini = new List<caine>();
            foreach (var item in Caini)
            {
                
            }
            Picioare = 4;
        }
        public string Blana { get; set; }

        public void Latra()
        {

            Console.WriteLine("HAM");
        }
        public List<caine> Caini { get; set; }

    }
}