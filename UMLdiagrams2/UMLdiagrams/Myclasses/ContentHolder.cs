using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLdiagrams.Arrows;

namespace UMLdiagrams.Myclasses
{
    [Serializable]public class ContentHolder
    {
        public List<DiagramClass> Diagrams { get; set; } = new List<DiagramClass>();
        public List<Arrow_Template> Arrows { get; set; } = new List<Arrow_Template>();
    }
}
