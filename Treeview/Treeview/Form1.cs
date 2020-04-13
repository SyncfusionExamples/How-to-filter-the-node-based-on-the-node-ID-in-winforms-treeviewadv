using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treeview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int nodeId = 0; nodeId <= 10000; nodeId++)
            {
                //Custom node for ID propety
                CustomTreeNodeAdv customNode = new CustomTreeNodeAdv();
                customNode.ID = nodeId;
                customNode.Text = "Node" + nodeId.ToString();
                this.treeViewAdv1.Nodes.Add(customNode);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (CustomTreeNodeAdv item in this.treeViewAdv1.Nodes)
            {
                //Gets the TextBox value
                string textvalue = item.ID.ToString();
                if (this.textBox1.Text == textvalue)
                {
                    //Gets the node by its ID
                    MessageBox.Show(item.Text);
                }
            }
        }

        public class CustomTreeNodeAdv : TreeNodeAdv
        {
            public int ID { get; set; }

        }
    }
}
