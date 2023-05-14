using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace UMLdiagrams.Myclasses
{
    [Serializable] 
    public class DiagramClass
    {
        public string Name { get; set; }
        public string TypeOfClass { get; set; }
        public string Access { get; set; }
        public BindingList<Property> Properties = new BindingList<Property>();
        public BindingList<Operation> Operations = new BindingList<Operation>();
        public int Width { get; set; } = 150;
        public int Height { get; set; } = 200;
        public int X { get; set; }
        public int Y { get; set; }
        public bool Selected { get; set; }
        public DiagramClass InheriteFrom { get; set; }

        public DiagramClass()
        {
            this.Selected = true;
        }
        public void Draw(Graphics g)
        {
            
            int textHeight = g.MeasureString(this.Name, SystemFonts.DefaultFont).ToSize().Height;
            
            int textWidthName = g.MeasureString(this.Access + " " +this.Name, SystemFonts.DefaultFont).ToSize().Width;
            int textWidthtP = 0;
            int textWidthtO = 0;
            foreach (var prop in this.Properties)
            {
                int tempW = 0;
                tempW += g.MeasureString(prop.Name, SystemFonts.DefaultFont).ToSize().Width;
                tempW += g.MeasureString(prop.Access, SystemFonts.DefaultFont).ToSize().Width;
                tempW += g.MeasureString(prop.DataType, SystemFonts.DefaultFont).ToSize().Width;
                tempW += g.MeasureString("+  :", SystemFonts.DefaultFont).ToSize().Width;
                if (tempW > textWidthtP)
                    textWidthtP = tempW;
            }
            foreach (var op in this.Operations)
            {
                int tempW = 0;
                tempW += g.MeasureString(op.Name, SystemFonts.DefaultFont).ToSize().Width;
                tempW += g.MeasureString(op.Access, SystemFonts.DefaultFont).ToSize().Width;
                tempW += g.MeasureString(op.DataType, SystemFonts.DefaultFont).ToSize().Width;
                tempW += g.MeasureString("+:  ()", SystemFonts.DefaultFont).ToSize().Width; // +: mezera mezera  ()
                foreach (var arg in op.MyArguments)
                {
                    tempW += g.MeasureString(arg.Name + arg.DataType + "  ,", SystemFonts.DefaultFont).ToSize().Width; //mezera carka;                  
                }
                tempW -= 2;
                if (tempW > textWidthtO)
                    textWidthtO = tempW;
            }

            this.Width = textWidthtP > textWidthtO ? textWidthtP : textWidthtO;
            this.Width = textWidthName > this.Width ? textWidthName : this.Width;


            this.Height = (3 + this.Properties.Count + this.Operations.Count) * textHeight; 
            if(this.Selected)
            {
                g.FillRectangle(Brushes.CornflowerBlue, this.X, this.Y, this.Width, this.Height);
                g.DrawRectangle(Pens.Red, this.X, this.Y, this.Width, this.Height);
            }
            else
                g.FillRectangle(Brushes.LightBlue, this.X, this.Y, this.Width, this.Height);

            //name
            if (this.TypeOfClass == "abstract class")
            {
                textWidthName = g.MeasureString(this.Name, new Font(SystemFonts.DefaultFont, FontStyle.Italic)).ToSize().Width;
                this.Width = textWidthName > this.Width ? textWidthName : this.Width;
                g.DrawString(this.Name, new Font(SystemFonts.DefaultFont, FontStyle.Italic), Brushes.Black, this.X + this.Width / 2 - textWidthName / 2, this.Y);
            }
            else if(this.TypeOfClass == "interface")
            {
                textWidthName = g.MeasureString("<" + this.Name + ">", SystemFonts.DefaultFont).ToSize().Width;
                this.Width = textWidthName > this.Width ? textWidthName : this.Width;
                g.DrawString("<" + this.Name + ">", SystemFonts.DefaultFont, Brushes.Black, this.X + this.Width / 2 - textWidthName / 2, this.Y);
            }              
            else
                g.DrawString(this.Access + " " + this.Name, SystemFonts.DefaultFont, Brushes.Black, this.X + this.Width / 2 - textWidthName / 2, this.Y);

                g.DrawLine(Pens.Black, this.X,this.Y + textHeight, this.X + this.Width -1, this.Y + textHeight);

            //props
            int i = 0;
            foreach (var prop in this.Properties)
            {
                g.DrawString(prop.Access + prop.Name + " : " + prop.DataType, SystemFonts.DefaultFont, Brushes.Black, this.X,this.Y+ textHeight*2 + i*textHeight);
                i++;
            }
            g.DrawLine(Pens.Black, this.X, this.Y + textHeight * 2 + this.Properties.Count * textHeight, this.X + this.Width - 1, this.Y + textHeight * 2 + this.Properties.Count * textHeight);

            //operations
            int j = 0;
            foreach (var op in this.Operations)
            {
                string input = "";
                foreach (var arg in op.MyArguments)
                {
                    input += arg.DataType + " " + arg.Name + ", " ;
                }
                if(input.Length != 0)
                    input = input.Substring(0, input.Length - 2);
               
                g.DrawString(op.Access + op.Name+$"({input})" + " : " + op.DataType, SystemFonts.DefaultFont, Brushes.Black, this.X,this.Y + textHeight * 3 + i * textHeight + j * textHeight);
                j++;
            }
        }

        Point prevCursor = new();
        public void Move(Point mouse)
        {
            int xDifference = mouse.X - prevCursor.X;
            int yDifference =  mouse.Y - prevCursor.Y;

            X += xDifference;
            Y += yDifference;

            prevCursor = mouse;
        }
    }
}
