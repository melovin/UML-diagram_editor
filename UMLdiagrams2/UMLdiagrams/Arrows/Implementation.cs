using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using UMLdiagrams.Helpers;

namespace UMLdiagrams.Arrows
{
    [Serializable]
    public class Implementation : Arrow_Template
    {
        public Implementation(ArrowArgs fromArgs, ArrowArgs toArgs) : base(fromArgs, toArgs)
        {
            this.Pen.DashStyle = DashStyle.Dash;
        }
        public override void DrawEnding(Graphics g)
        {
            if (this.MyRelations.To.X > this.MyRelations.From.X)
            {
                g.FillPolygon(Brushes.White, new Point[] { new(this.MyRelations.To.X - 20, this.End.Y - 10), new(this.MyRelations.To.X - 20, this.End.Y + 10), new(this.MyRelations.To.X, this.End.Y) });
                g.DrawPolygon(Pens.Black, new Point[] { new(this.MyRelations.To.X - 20, this.End.Y - 10), new(this.MyRelations.To.X - 20, this.End.Y + 10), new(this.MyRelations.To.X, this.End.Y) });
            }
            else
            {
                g.FillPolygon(Brushes.White, new Point[] { new(this.MyRelations.To.X + this.MyRelations.To.Width + 20, this.End.Y - 10), new(this.MyRelations.To.X + this.MyRelations.To.Width + 20, this.End.Y + 10), new(this.MyRelations.To.X + this.MyRelations.To.Width, this.End.Y) });
                g.DrawPolygon(Pens.Black, new Point[] { new(this.MyRelations.To.X + this.MyRelations.To.Width + 20, this.End.Y - 10), new(this.MyRelations.To.X + this.MyRelations.To.Width + 20, this.End.Y + 10), new(this.MyRelations.To.X + this.MyRelations.To.Width, this.End.Y) });
            }
            this.DrawMultiplicity(g);
        }
    }
}
