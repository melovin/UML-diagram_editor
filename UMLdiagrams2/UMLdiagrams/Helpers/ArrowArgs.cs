using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLdiagrams.Myclasses;

namespace UMLdiagrams.Helpers
{
    [Serializable]
    public struct ArrowArgs
    {
        public Point WhereClicked { get; set; }
        public DiagramClass ClickedOn { get; set; }

        public ArrowArgs(Point whereClicked, DiagramClass clickedOn)
        {
            WhereClicked = whereClicked;
            ClickedOn = clickedOn;
        }
    }
}
