using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using UMLdiagrams.Arrows;
using UMLdiagrams.Helpers;

namespace UMLdiagrams
{
    public partial class ConnectionForm : Form
    {
        public int ConType { get; set; }
        private List<ArrowArgs> Clicks { get; set; }
        private List<Arrow_Template> Arrows { get; set; }
        public ConnectionForm(List<ArrowArgs> clicks, List<Arrow_Template> arrows)
        {
            InitializeComponent();

            this.Clicks = clicks;
            this.Arrows = arrows;

            this.label_from.Text = this.Clicks[0].ClickedOn.Name;
            this.label_to.Text = this.Clicks[1].ClickedOn.Name;


            this.comboBox_connections.Items.Add(ConnectionType.Association);
            this.comboBox_connections.Items.Add(ConnectionType.Inheritance);
            this.comboBox_connections.Items.Add(ConnectionType.Implementation);
            this.comboBox_connections.Items.Add(ConnectionType.Dependency);
            this.comboBox_connections.Items.Add(ConnectionType.Aggregation);
            this.comboBox_connections.Items.Add(ConnectionType.Composition);

            this.comboBox_connections.SelectedIndex = 0;

            this.comboBox_multiplicityFrom.Items.Add("0..0");
            this.comboBox_multiplicityFrom.Items.Add("0..1");
            this.comboBox_multiplicityFrom.Items.Add("1..1");
            this.comboBox_multiplicityFrom.Items.Add("0..*");
            this.comboBox_multiplicityFrom.Items.Add("1..*");

            this.comboBox_multiplicityTo.Items.Add("0..0");
            this.comboBox_multiplicityTo.Items.Add("0..1");
            this.comboBox_multiplicityTo.Items.Add("1..1");
            this.comboBox_multiplicityTo.Items.Add("0..*");
            this.comboBox_multiplicityTo.Items.Add("1..*");
            
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.ConType = this.comboBox_connections.SelectedIndex;
            ConnectionType conType = (ConnectionType)ConType;
            switch (conType)
            {
                case ConnectionType.Association:
                    Arrows.Add(new Association(new ArrowArgs(Clicks[0].WhereClicked, Clicks[0].ClickedOn), new ArrowArgs(Clicks[1].WhereClicked, Clicks[1].ClickedOn)));
                    break;
                case ConnectionType.Inheritance:
                    this.Clicks[1].ClickedOn.InheriteFrom = this.Clicks[0].ClickedOn; //who inherits, from who
                    Arrows.Add(new Inheritance(new ArrowArgs(Clicks[0].WhereClicked, Clicks[0].ClickedOn), new ArrowArgs(Clicks[1].WhereClicked, Clicks[1].ClickedOn)));
                    break;
                case ConnectionType.Implementation:
                    this.Clicks[1].ClickedOn.InheriteFrom = this.Clicks[0].ClickedOn; //who inherits, from who
                    Arrows.Add(new Implementation(new ArrowArgs(Clicks[0].WhereClicked, Clicks[0].ClickedOn), new ArrowArgs(Clicks[1].WhereClicked, Clicks[1].ClickedOn)));
                    break;
                case ConnectionType.Dependency:
                    Arrows.Add(new Dependency(new ArrowArgs(Clicks[0].WhereClicked, Clicks[0].ClickedOn), new ArrowArgs(Clicks[1].WhereClicked, Clicks[1].ClickedOn)));
                    break;
                case ConnectionType.Aggregation:
                    Arrows.Add(new Aggregation(new ArrowArgs(Clicks[0].WhereClicked, Clicks[0].ClickedOn), new ArrowArgs(Clicks[1].WhereClicked, Clicks[1].ClickedOn)));
                    break;
                case ConnectionType.Composition:
                    Arrows.Add(new Composition(new ArrowArgs(Clicks[0].WhereClicked, Clicks[0].ClickedOn), new ArrowArgs(Clicks[1].WhereClicked, Clicks[1].ClickedOn)));
                    break;
            }

            foreach (var item in this.Arrows)
            {
                if (item.MyRelations.From.Name == this.Clicks[0].ClickedOn.Name && item.MyRelations.To.Name == this.Clicks[1].ClickedOn.Name)
                {
                    item.Multiplicity[0] = this.comboBox_multiplicityFrom.Text;
                    item.Multiplicity[1] = this.comboBox_multiplicityTo.Text;
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
    public enum ConnectionType
    {
        Association,
        Inheritance,
        Implementation,
        Dependency,
        Aggregation,
        Composition
    }
}
