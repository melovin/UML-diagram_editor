using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLdiagrams.Helpers;

namespace UMLdiagrams.Arrows
{
    [Serializable]
    public class Aggregation : Arrow_Template
    {
        public Aggregation(ArrowArgs fromArgs, ArrowArgs toArgs) : base(fromArgs, toArgs)
        {
        }
        public override void DrawEnding(Graphics g)
        {
            if (this.MyRelations.To.X > this.MyRelations.From.X)
            {
                g.FillPolygon(Brushes.White, new Point[] { new(this.MyRelations.To.X, this.End.Y), new(this.MyRelations.To.X - 20, this.End.Y + 10), new(this.MyRelations.To.X - 40, this.End.Y), new(this.MyRelations.To.X - 20, this.End.Y - 10)});
                g.DrawPolygon(Pens.Black, new Point[] { new(this.MyRelations.To.X, this.End.Y), new(this.MyRelations.To.X - 20, this.End.Y + 10), new(this.MyRelations.To.X - 40, this.End.Y), new(this.MyRelations.To.X - 20, this.End.Y - 10) });
            }
            else
            {
                g.FillPolygon(Brushes.White, new Point[] { new(this.MyRelations.To.X + this.MyRelations.To.Width, this.End.Y), new(this.MyRelations.To.X + this.MyRelations.To.Width + 20, this.End.Y - 10), new(this.MyRelations.To.X + this.MyRelations.To.Width+ 40, this.End.Y), new(this.MyRelations.To.X + this.MyRelations.To.Width + 20, this.End.Y + 10)});
                g.DrawPolygon(Pens.Black, new Point[] { new(this.MyRelations.To.X + this.MyRelations.To.Width, this.End.Y), new(this.MyRelations.To.X + this.MyRelations.To.Width + 20, this.End.Y - 10), new(this.MyRelations.To.X + this.MyRelations.To.Width + 40, this.End.Y), new(this.MyRelations.To.X + this.MyRelations.To.Width + 20, this.End.Y + 10) });
            }
            this.DrawMultiplicity(g);
        }
    }
}
