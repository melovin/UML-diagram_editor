using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UMLdiagrams.Myclasses
{
    [Serializable]
    public class Property
    {
        public string Access { get; set; }
        public string DataType { get; set; }
        public string Name { get; set; }
        public Property(string access, string dataType, string name)
        {
            this.Access = access;
            this.DataType = dataType;
            this.Name = name;
        }
        public void SwitchAcc(string access)
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
}
