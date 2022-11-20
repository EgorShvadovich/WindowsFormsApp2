using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
       ToolStripMenuItem x;
        ToolStripMenuItem t = new ToolStripMenuItem();
        int name = 2;
        public Form1()
        {
            InitializeComponent();
            x = toolStripMenuItem1;
        }
        private void toolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            x.DropDownOpening += toolStripMenuItem1_MouseEnter;
            x.DropDownItems.Add(t);
            t.Text = name.ToString();
            name++;
            x = t;
            t = new ToolStripMenuItem();
            x.DropDownOpening -= toolStripMenuItem1_MouseEnter;
        }
    }
}
