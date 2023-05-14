using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace UMLdiagrams.Myclasses
{
    [Serializable]
    public class Operation
    {
        public string Name { get; set; }
        public string DataType { get; set; }
        public string Access { get; set; }
        public BindingList<Arguments> MyArguments  = new BindingList<Arguments>();

        public Operation(string access, string dataType, string name)
        {
            this.Name = name;
            this.DataType = dataType;
            this.Access = access;
        }

        public Operation(string access, string dataType, string name, List<Arguments> args)
        {
            this.Name = name;
            this.DataType = dataType;
            this.Access = access;
            this.MyArguments = new BindingList<Arguments>(args);
        }
        public void SwitchOp(string access)
        {
            if(access.Length > 1)
            {
                switch (access)
                {
                    case "protected":
                        this.Access = "#";
                        break;
                    case "private":
                        this.Access = "-";
                        break;
                    default:
                        this.Access = "+";
                        break;
                }
            }
            else
            {
                switch (access)
                {
                    case "#":
                        this.Access = "protected";
                        break;
                    case "-":
                        this.Access = "private";
                        break;
                    default:
                        this.Access = "public";
                        break;
                }
            }
        }
    }
    [Serializable]
    public class Arguments
    {
        public string Name { get; set; }
        public string DataType { get; set; }
        public Arguments(string dataType, string name)
        {
            this.Name = name;
            this.DataType = dataType;
        }

    }
        
}
