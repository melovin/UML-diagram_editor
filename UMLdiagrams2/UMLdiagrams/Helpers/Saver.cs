using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Security;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using UMLdiagrams.Arrows;
using UMLdiagrams.Myclasses;

namespace UMLdiagrams.Helpers
{
    public class Saver
    {
        private int FormatTo { get; set; }
        private string Path { get; set; }
        private List<DiagramClass> Diagrams {get; set;}
        private List<Arrow_Template> Arrows { get; set; }
        public ContentHolder ContentHolder { get; set; }
        public Saver(int format, string path, ContentHolder contentHolder)
        {
            this.FormatTo = format;
            this.Path = path;
            this.Arrows = contentHolder.Arrows;
            this.Diagrams = contentHolder.Diagrams;
            this.ContentHolder = contentHolder;
        }
        public void SaveMe()
        {
            switch ((Format)this.FormatTo)
            {
                case Format.IMAGE:
                    this.SaveAsImage();
                    break;
                case Format.CODE:
                    this.SaveAsCode();
                    break;
                case Format.BINARY:
                    this.SaveAsBinary();
                    break;
            }
        }
        private void SaveAsImage()
        {
            Image image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(image);
            g.Clear(Color.White);
            foreach (var arrow in this.Arrows)
            {
                arrow.Draw(g);
            }
            foreach (var diagram in this.Diagrams)
            {
                diagram.Draw(g);
            }

            image.Save(this.Path, ImageFormat.Jpeg);
        }
        private void SaveAsCode()
        {
            Directory.CreateDirectory(this.Path);
            foreach (var item in this.Diagrams)
            {
                File.Create(this.Path + "\\" + item.Name + ".cs").Close();
                StreamWriter write = new StreamWriter(this.Path + "\\" + item.Name+".cs");

                write.WriteLine("using System;");
                write.WriteLine("using System.Collections.Generic;");
                write.WriteLine("using System.Linq;");
                write.WriteLine("using System.Text;");
                write.WriteLine("using System.Threading.Tasks;");
                write.WriteLine("");

                string[] dirName = this.Path.Split("\\");
                string accessOfItemClass;
                switch (item.Access)
                {
                    case "+":
                        accessOfItemClass = "public";
                        break;
                    case "-":
                        accessOfItemClass = "private";
                        break;
                    default:
                        accessOfItemClass = "protected";
                        break;
                }
                string inherit = "";
                if (item.InheriteFrom is not null)
                    inherit = " : " + item.InheriteFrom.Name;

                write.WriteLine("namespace " + dirName[dirName.Length - 1]);
                write.WriteLine("{");
                write.WriteLine("    " + accessOfItemClass + " " + item.TypeOfClass + " " + item.Name + inherit);
                write.WriteLine("    " + "{");
                if(item.InheriteFrom is not null && item.InheriteFrom.TypeOfClass == "interface")
                {
                    foreach (var inheriteProp in item.InheriteFrom.Properties)
                    {
                        inheriteProp.SwitchAcc(inheriteProp.Access);
                        write.WriteLine($"        {inheriteProp.Access} {inheriteProp.DataType} {inheriteProp.Name} {{ get => throw new NotImplementedException(); set => throw new NotImplementedException(); }}");
                        inheriteProp.SwitchAcc(inheriteProp.Access);
                    }
                }
                foreach (var prop in item.Properties)
                {
                    prop.SwitchAcc(prop.Access);
                    write.WriteLine($"        {prop.Access} {prop.DataType} {prop.Name} {{get; set;}}");
                    prop.SwitchAcc(prop.Access);
                }
                
                foreach (var operation in item.Operations)
                {
                    operation.SwitchOp(operation.Access);
                    write.Write($"        {operation.Access} {operation.DataType} {operation.Name}(");
                    int i = 0;
                    foreach (var props in operation.MyArguments)
                    {
                        if(i < operation.MyArguments.Count - 1)
                            write.Write($"{props.DataType} {props.Name}, ");
                        else
                            write.Write($"{props.DataType} {props.Name}");
                        i++;
                    }
                    write.Write(") ");
                    write.WriteLine("{}");
                    operation.SwitchOp(operation.Access);
                }
                write.WriteLine("    " + "}");
                write.WriteLine("}");
                write.Close();
            }
            
        }
        private void SaveAsBinary()
        {
            IFormatter formatter = new BinaryFormatter();
            using(FileStream stream = File.Create(this.Path))
            {
                formatter.Serialize(stream, this.ContentHolder);
            }
        }
    }
}
