using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;
using UMLdiagrams.Helpers;
using UMLdiagrams.Myclasses;

namespace UMLdiagrams.Arrows
{
    [Serializable]
    public class Arrow_Template
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public Relations MyRelations { get; set; }

        protected int FromXOffset { get; set; }
        protected int FromYOffset { get; set; }

        protected int ToXOffset { get; set; }
        protected int ToYOffset { get; set; }
        protected int ClickedOnX { get; set; }
        [NonSerialized]
        public Pen Pen = new Pen(Color.Black, 1);
        public string stringPen { get; set; } = "public Pen Pen = new Pen(Color.Black, 1)";
        public int SelectMeDiameter { get; set; } = 15;
        public int SelectMeX { get; set; }
        public int SelectMeY { get; set; }
        public bool IsSelected { get; set; } = false;
        public string[] Multiplicity { get; set; } = new string [2];

        public Arrow_Template(ArrowArgs fromArgs, ArrowArgs toArgs)
        {
            MyRelations = new Relations();

            MyRelations.From = fromArgs.ClickedOn;
            MyRelations.To = toArgs.ClickedOn;

            FromXOffset = fromArgs.WhereClicked.X - fromArgs.ClickedOn.X;
            FromYOffset = fromArgs.WhereClicked.Y - fromArgs.ClickedOn.Y;

            ToXOffset = toArgs.WhereClicked.X - toArgs.ClickedOn.X;
            ToYOffset = toArgs.WhereClicked.Y - toArgs.ClickedOn.Y;

            ClickedOnX = toArgs.WhereClicked.X;
        }
        
        public virtual void Draw(Graphics g)
        {
            if (IsSelected)
                Pen.Color = Color.Red;
            Start = new Point(MyRelations.From.X + FromXOffset, MyRelations.From.Y + FromYOffset);
            End = new Point(MyRelations.To.X + ToXOffset, MyRelations.To.Y + ToYOffset);

            int width = Math.Abs(Start.X - End.X);

            if (Start.X < End.X)
            {
                g.DrawLine(Pen, Start, new Point(Start.X + width / 2, Start.Y));
                g.DrawLine(Pen, new Point(Start.X + width / 2, End.Y), End);
                g.DrawLine(Pen, new Point(Start.X + width / 2, Start.Y), new Point(Start.X + width / 2, End.Y));
                this.SelectMeX = this.MyRelations.From.X + this.MyRelations.From.Width;
                this.SelectMeY = this.Start.Y - this.SelectMeDiameter / 2;
                g.FillEllipse(Brushes.Black, this.MyRelations.From.X + this.MyRelations.From.Width, this.Start.Y - this.SelectMeDiameter / 2, this.SelectMeDiameter, this.SelectMeDiameter);
            }
            else
            {
                g.DrawLine(Pen, new Point(Start.X - width / 2, Start.Y), Start);
                g.DrawLine(Pen, End, new Point(Start.X - width / 2, End.Y));
                g.DrawLine(Pen, new Point(Start.X - width / 2, Start.Y), new Point(Start.X - width / 2, End.Y));
                this.SelectMeX = this.MyRelations.From.X;
                this.SelectMeY = this.Start.Y - this.SelectMeDiameter / 2;
                g.FillEllipse(Brushes.Black, this.MyRelations.From.X - this.SelectMeDiameter, this.Start.Y - this.SelectMeDiameter / 2, this.SelectMeDiameter, this.SelectMeDiameter);

            }
            this.DrawEnding(g);
        }
        public virtual void DrawEnding(Graphics g)
        {     
            if (this.MyRelations.To.X > this.MyRelations.From.X + this.MyRelations.From.Width)
            {
                g.DrawLine(Pens.Black, new(this.MyRelations.To.X, this.End.Y), new(this.MyRelations.To.X - 20, this.End.Y - 10));
                g.DrawLine(Pens.Black, new(this.MyRelations.To.X, this.End.Y), new(this.MyRelations.To.X - 20, this.End.Y + 10));
            }
            else if(this.MyRelations.To.X + this.MyRelations.To.Width < this.MyRelations.From.X)
            {
                g.DrawLine(Pens.Black, new(this.MyRelations.To.X + this.MyRelations.To.Width, this.End.Y), new(this.MyRelations.To.X + this.MyRelations.To.Width + 20, this.End.Y - 10));
                g.DrawLine(Pens.Black, new(this.MyRelations.To.X + this.MyRelations.To.Width, this.End.Y), new(this.MyRelations.To.X + this.MyRelations.To.Width + 20, this.End.Y + 10));
            }
            this.DrawMultiplicity(g);
        }
        public void DrawMultiplicity(Graphics g)
        {
            if (Start.X < End.X)
            {
                int multToWidth = g.MeasureString(this.Multiplicity[1], SystemFonts.DefaultFont).ToSize().Width;
                g.DrawString(this.Multiplicity[0], SystemFonts.DefaultFont, Brushes.Black, this.MyRelations.From.X + this.MyRelations.From.Width, Start.Y - 30);
                g.DrawString(this.Multiplicity[1], SystemFonts.DefaultFont, Brushes.Black, this.MyRelations.To.X - multToWidth, End.Y - 30);
            }
            else
            {
                int multFromWidth = g.MeasureString(Multiplicity[0], SystemFonts.DefaultFont).ToSize().Width;
                g.DrawString(Multiplicity[0], SystemFonts.DefaultFont, Brushes.Black, this.MyRelations.From.X - multFromWidth, Start.Y - 30);
                g.DrawString(this.Multiplicity[1], SystemFonts.DefaultFont, Brushes.Black, this.MyRelations.To.X + this.MyRelations.To.Width, End.Y - 30);
            }

        }
    }
}
