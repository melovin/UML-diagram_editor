using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLdiagrams.Myclasses;

namespace UMLdiagrams.Arrows
{
    [Serializable]
    public class Relations
    {
        public DiagramClass From { get; set; }
        public DiagramClass To { get; set; }

    }
}
