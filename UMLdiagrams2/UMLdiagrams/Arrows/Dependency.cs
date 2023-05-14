using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLdiagrams.Helpers;

namespace UMLdiagrams.Arrows
{
    [Serializable]
    public class Dependency : Arrow_Template
    {
        public Dependency(ArrowArgs fromArgs, ArrowArgs toArgs) : base(fromArgs, toArgs)
        {
            this.Pen.DashStyle = DashStyle.Dash;
        }
    }
}
