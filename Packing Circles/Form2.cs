using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Packing_Circles
{
    public partial class Form2 : Form
    {        
        public Form2(int locX, int locY)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(locX, locY);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }        
        public void SetListR(System.Collections.Generic.List<string[]> centersListR)
        {
            foreach (string[] center in centersListR)
            {
                listBoxR.Items.Add(string.Join(", ", center));
            }
        }
        public void SetListT(System.Collections.Generic.List<string[]> centersListT)
        {
            foreach (string[] center in centersListT)
            {
                listBoxT.Items.Add(string.Join(", ", center));
            }
        }

        public void SetQtySheetR(string qty)
        {
            textBoxRQtyPerSheet.Text =qty;   
        }
        public void SetQtySheetT(string qty)
        {
            textBoxTQtyPerSheet.Text = qty;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
