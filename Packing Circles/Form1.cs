using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Packing_Circles
{
    public partial class FormMain : Form
    {
        FormInputs formInputs;
        Packing packing;
        PackingCalculate packingCalculate;
        bool isDrawRectangle;
        bool isLastSheet;
        bool okClicked;

        float w;
        float h;
        int qty;
        float size;
        float space;
        public FormMain()
        {
            InitializeComponent();

            textBoxSize.Focus();

            formInputs = new FormInputs(panelInput.Location.X + panelInput.Width + 10, panelInput.Location.Y,
                                        Width, Height);            

            string[] comboUnits = { "mm", "cm", "m", "in", "ft" };
            comboBoxUnits.Items.AddRange(comboUnits);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            okClicked = true;
            updateForm();
        }

        private void updateForm()
        {
            if (okClicked)
            {
                formInputs.SetWidth(w);
                formInputs.SetHeight(h);
                formInputs.SetSize(size);
                formInputs.SetSpace(space);
                formInputs.AdjustScale();

                packingCalculate = new PackingCalculate(formInputs.GetSize(), formInputs.GetSpace(), qty);
                packing = new Packing(formInputs.GetSize(), formInputs.GetSpace(), qty);

                packing.SetScale(formInputs.GetScale());

                isDrawRectangle = true;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (isDrawRectangle)
            {
                int currentSheetCount;
                int recSheetCount;
                int triSheetCount;
                base.OnPaint(e);
                Graphics g = e.Graphics;
                SolidBrush mySolidBrush = new SolidBrush(Color.Gray);
                using (Pen selPen = new Pen(Color.Blue))
                {
                    //rectangular packing
                    currentSheetCount = packingCalculate.CalculateSheet(formInputs.GetX(), formInputs.GetY(),
                                      formInputs.GetWidth(), formInputs.GetHeight(), "rectangular");
                    if (isLastSheet)
                    {                       
                        packing.SetCurrentSheetCount(packingCalculate.GetCount() - packingCalculate.GetLastSheetCount());
                    }
                    else {
                        packing.SetCurrentSheetCount(packingCalculate.GetCount());
                    }

                    g.DrawRectangle(selPen, formInputs.GetX(), formInputs.GetY(), 
                                  formInputs.GetWidth(), formInputs.GetHeight());
                    g.FillRectangle(mySolidBrush, formInputs.GetX(), formInputs.GetY(),
                                  formInputs.GetWidth(), formInputs.GetHeight());
                    
                    packing.InitiateCornersListR();
                    packing.FillSheet(g, formInputs.GetX(), formInputs.GetY(),
                                  formInputs.GetWidth(), formInputs.GetHeight(), "rectangular");

                    recSheetCount = packing.GetCount();
                    textBoxRQtyPerSheet.Text = Convert.ToString(recSheetCount);                    
                    textBoxRSheets.Text = Convert.ToString(packing.GetSheetCount());
                    labelRLastRest.Text = Convert.ToString(packing.GetLastSheetCount()) + " pcs " + 
                        Convert.ToString(packing.LastSheetRestPercent()) + "%";
                    //triangular packing
                    currentSheetCount = packingCalculate.CalculateSheet(formInputs.GetX(), formInputs.GetY(),
                                  formInputs.GetWidth(), formInputs.GetHeight(), "triangular");
                    if (isLastSheet)
                    {                        
                        packing.SetCurrentSheetCount(packingCalculate.GetCount() - packingCalculate.GetLastSheetCount());
                    }
                    else {
                        packing.SetCurrentSheetCount(packingCalculate.GetCount());
                    }

                    g.DrawRectangle(selPen, formInputs.GetX(), formInputs.GetY()+ formInputs.GetHeight()+5,
                                  formInputs.GetWidth(), formInputs.GetHeight());
                    g.FillRectangle(mySolidBrush, formInputs.GetX(), formInputs.GetY() + formInputs.GetHeight() + 5,
                                 formInputs.GetWidth(), formInputs.GetHeight());

                    packing.InitiateCornersListT();
                    packing.FillSheet(g, formInputs.GetX(), formInputs.GetY() + formInputs.GetHeight() + 5,
                                  formInputs.GetWidth(), formInputs.GetHeight(), "triangular");

                    triSheetCount = packing.GetCount();
                    textBoxTQtyPerSheet.Text = Convert.ToString(triSheetCount);                    
                    textBoxTSheets.Text = Convert.ToString(packing.GetSheetCount());
                    labelTLastRest.Text = Convert.ToString(packing.GetLastSheetCount()) + " pcs " +
                        Convert.ToString(packing.LastSheetRestPercent()) + "%";

                    if (recSheetCount > triSheetCount)
                    {
                        panelOutputR.BackColor = Color.LightGreen;
                        panelOutputT.BackColor = DefaultBackColor;
                    } else
                    {
                        if (recSheetCount < triSheetCount) {
                            panelOutputT.BackColor = Color.LightGreen;
                            panelOutputR.BackColor = DefaultBackColor;
                        } else
                        {
                            panelOutputT.BackColor = Color.LightGreen;
                            panelOutputR.BackColor = Color.LightGreen;
                        }
                    }
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //radioButtonFullSheet.Checked = true;
            isLastSheet = false;
        }
        public int ValidateIntegerInput(string textBoxInput)
        {           
                if (int.TryParse(textBoxInput, out int numValue)){
                    if (numValue >= 0)
                    {
                        return numValue;
                    }else
                    {
                        return -1;
                    }
                }else
                {
                    return -1;
                }            
        }
        public float ValidateFloatInput(string textBoxInput)
        {
            textBoxInput = formInputs.GetDecimalNumber(textBoxInput);
            if (float.TryParse(textBoxInput, out float numValue))
            {
                if (numValue >= 0)
                {
                    return numValue;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }        

        private void textBoxWidth_Leave(object sender, EventArgs e)
        {
            int w = ValidateIntegerInput(textBoxWidth.Text);
            if (w >= 0)
            {
                this.w = w;
                //formInputs.SetWidth(w);
            }
            else
            {
                textBoxWidth.Text = "";
            }
        }

        private void textBoxHeight_Leave(object sender, EventArgs e)
        {
            int h = ValidateIntegerInput(textBoxHeight.Text);
            if (h >= 0)
            {
                this.h = h;
                //formInputs.SetHeight(h);
            }
            else
            {
                textBoxHeight.Text = "";
            }
        }
        private void textBoxQuantity_Leave(object sender, EventArgs e)
        {
            int q = ValidateIntegerInput(textBoxQuantity.Text);
            if (q >= 0)
            {
                this.qty = q;               
            }
            else
            {
                textBoxQuantity.Text = "";
            }
        }
        private void textBoxSize_Leave(object sender, EventArgs e)
        {
            float s = ValidateFloatInput(textBoxSize.Text);
            if (s >= 0)
            {
                textBoxSize.Text = Convert.ToString(s);
                this.size = s;
            }
            else
            {
                textBoxSize.Text = "";
            }
        }
        private void textBoxSpace_Leave(object sender, EventArgs e)
        {
            float s = ValidateFloatInput(textBoxSpace.Text);
            if (s >= 0)
            {
                textBoxSpace.Text = Convert.ToString(s);
                this.space = s;
            }
            else
            {
                textBoxSpace.Text = "";
            }
        }


        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelWUnits.Text = comboBoxUnits.Text;
            labelHUnits.Text = comboBoxUnits.Text;
            labelSpaceUnits.Text = comboBoxUnits.Text;
        }

        private void textBoxSize_Click(object sender, EventArgs e)
        {
            textBoxSize.SelectAll();
        }

        private void textBoxQuantity_Click(object sender, EventArgs e)
        {
            textBoxQuantity.SelectAll();
        }

        private void textBoxWidth_Click(object sender, EventArgs e)
        {
            textBoxWidth.SelectAll();
        }

        private void textBoxHeight_Click(object sender, EventArgs e)
        {
            textBoxHeight.SelectAll();
        }

        private void textBoxSpace_Click(object sender, EventArgs e)
        {
            textBoxSpace.SelectAll();
        }



        private void textBoxSize_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                textBoxQuantity.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxWidth.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxWidth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxHeight.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxHeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxSpace.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxSpace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonCalculate.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void textBoxSize_Enter(object sender, EventArgs e)
        {
            textBoxSize.SelectAll();
        }
        private void textBoxQuantity_Enter(object sender, EventArgs e)
        {
            textBoxQuantity.SelectAll();
        }

        private void textBoxWidth_Enter(object sender, EventArgs e)
        {
            textBoxWidth.SelectAll();
        }

        private void textBoxHeight_Enter(object sender, EventArgs e)
        {
            textBoxHeight.SelectAll();
        }

        private void textBoxSpace_Enter(object sender, EventArgs e)
        {
            textBoxSpace.SelectAll();
        }

        private void radioButtonFullSheet_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFullSheet.Checked)
            {               
                isLastSheet = false;
                updateForm();              
            }
        }

        private void radioButtonLastSheet_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLastSheet.Checked)
            {               
                isLastSheet = true;
                updateForm();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Created on C#, Microsoft Visual Studio Community 2019 \n Version 16.6.2 \n pavlovfontanka@gmail.com";
            string caption = "About";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (okClicked)
            {
                System.Collections.Generic.List<string[]> centersListR;
                System.Collections.Generic.List<string[]> centersListT;
                centersListR = packing.GetCircleCenters("rectangular");
                centersListT = packing.GetCircleCenters("triangular");
                Form2 form2 = new Form2(this.Location.X + Width + 10, this.Location.Y);
                
                form2.SetListR(centersListR);
                form2.SetListT(centersListT);
                form2.SetQtySheetR(textBoxRQtyPerSheet.Text);
                form2.SetQtySheetT(textBoxTQtyPerSheet.Text);
                form2.Show();
            }
        }
    }
}
