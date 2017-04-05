using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PizzaOrderForm
{
    public partial class formPizza : Form
    {
        double smallTotal = 0.0;
        double mediumTotal = 0.0;
        double largeTotal = 0.0;
        double xlargeTotal = 0.0;
        double Total = 0.0;
        double tax = .075;
        double sumTotal = 0.0;
        double taxTotal = 0.0;
        double grandTotal = 0.0;

        string size = string.Empty;
        int numPizzas = 1;
        string sauce = string.Empty;
        double toppings = 0.0;
        int popCount = 0;

        public formPizza()
        {
            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void populateComboBoxes()
        {
            if (popCount == 0)
            {
                //cboSmall.Items.Clear();
                for (int s = 0; s < 21; s++)
                    cboSmall.Items.Add(s);
                cboSmall.SelectedIndex = 0;

                //cboMedium.Items.Clear();
                for (int m = 0; m < 21; m++)
                    cboMedium.Items.Add(m);
                cboMedium.SelectedIndex = 0;

                //cboLarge.Items.Clear();
                for (int l = 0; l < 21; l++)
                    cboLarge.Items.Add(l);
                cboLarge.SelectedIndex = 0;

                //cboXLarge.Items.Clear();
                for (int x = 0; x < 21; x++)
                    cboXLarge.Items.Add(x);
                cboXLarge.SelectedIndex = 0;
            }
        }

        private TabPage _summaryTabPage;

        private void formPizza_Load(object sender, EventArgs e)
        {
            btnClear_Click(sender, e);
            buttonOrder.Enabled = false;
            buttonCalculate.Enabled = false;
            _summaryTabPage = tabControl1.TabPages[1];
            tabControl1.TabPages.Remove(_summaryTabPage);
        }

        private void clearSizes()
        {
            foreach (CheckBox c in grpSize.Controls.OfType<CheckBox>())
            {
                c.Checked = false;
            }
        }
        private void resetComboBoxes(Boolean status)
        {
            foreach (ComboBox cbo in grpSize.Controls.OfType<ComboBox>())
            {
                if (status == true)
                {
                    //cbo.SelectedIndex = 0;
                    cbo.Enabled = false;
                }
                else
                {
                    cbo.Enabled = true;
                }
            }
        }

        private void resetToppings(Boolean status)
        {
            foreach (CheckBox chkbox in grpToppings.Controls.OfType<CheckBox>())
            {
                if (status == true)
                {
                    chkbox.Checked = false;
                    chkbox.Enabled = false;
                }
                else
                {
                    chkbox.Enabled = true;
                }
            }
            toppings = 0.0;
        }

        private void resetSauces(Boolean status)
        {
            foreach (RadioButton rdo in grpSauce.Controls.OfType<RadioButton>())
            {
                if (status == true)
                {
                    rdo.Checked = false;
                    rdo.Enabled = false;
                }
                else
                {
                    rdo.Checked = true;
                    rdo.Enabled = true;
                }
            }
        }

        private void resetTextboxes()
        {
            foreach (TextBox txt in grpSize.Controls.OfType<TextBox>())
            {
                txt.Text = string.Empty;
                txt.Enabled = false;
            }
            
            txtSummary.Text = string.Empty;
        }

        private void resetSizes(string size)
        {
            foreach (CheckBox chk in grpSize.Controls.OfType<CheckBox>())
            {
                if (chk.Text != size)
                {
                    chk.Checked = false;
                    chk.Enabled = true;
                }
            }
        }
        
        
        private void btnClear_Click(object sender, EventArgs e)
        {

            MessageBox.Show(tabControl1.TabPages[1].Text);
            //tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            populateComboBoxes();

            popCount += 1;

            buttonCalculate.Enabled = false;
            buttonOrder.Enabled = false;
            buttonNext.Enabled = false;

            resetSizes("");
            resetComboBoxes(true);
            resetToppings(true);
            resetSauces(true);
            resetTextboxes();
            txtComments.Text = string.Empty;
            cboSmall.SelectedIndex = 0;
            cboMedium.SelectedIndex = 0;
            cboLarge.SelectedIndex = 0;
            cboXLarge.SelectedIndex = 0;
            tabControl1.SelectedIndex = 0;
        }
                    

        private void chkSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSmall.Checked == true)
            {
                size = "Small";
                resetSizes(size);
                cboSmall.Enabled = true;
                cboSmall.SelectedIndex = 1;
                resetToppings(false);
                resetSauces(false);
                buttonCalculate.Enabled = true;
            }
            else
            {
                resetTextboxes();
                resetComboBoxes(true);
                resetToppings(true);
                resetSauces(true);
                cboSmall.SelectedIndex = 0;
                txtComments.Text = string.Empty;
                buttonCalculate.Enabled = false;
                buttonNext.Enabled = false;
            }
           
            //if (cboSmall.Enabled == false)
            //{                
            //    resetSauces(false);
            //    resetToppings(false);
            //    resetTextboxes();
            
            //    foreach (CheckBox chkbox in grpToppings.Controls.OfType<CheckBox>())
            //    {
            //        if (chkbox.Text != "Small")
            //        {
            //            chkbox.Checked = false;
            //            chkbox.Enabled = true;
            //        }
            //        else
            //        {
            //            chkSmall.Checked = true;
            //        }
            //    }

            //    rdoTomato.Checked = true;

            //    size = "Small";

            //    cboSmall.Enabled = true;

            //    cboMedium.Enabled = false;
            //    cboLarge.Enabled = false;
            //    cboXLarge.Enabled = false;

            //    cboSmall.SelectedIndex = 1;
            //    cboMedium.SelectedIndex = 0;
            //    cboLarge.SelectedIndex = 0;
            //    cboXLarge.SelectedIndex = 0;

            //    txtMediumCost.Text = string.Empty;
            //    txtLargeCost.Text = string.Empty;
            //    txtXLargeCost.Text = string.Empty;

            //    chkMedium.Checked = false;
            //    chkLarge.Checked = false;
            //    chkXLarge.Checked = false;
            //    }

            //    else
            //    {   
            //        resetSauces(true);
            //        resetToppings(true);
            //        resetTextboxes();

            //        foreach (CheckBox chkbox in tabOrder.Controls.OfType<CheckBox>())
            //        {
            //            if (chkbox.Text != "Small")
            //            {
            //                chkbox.Checked = false;
            //                chkbox.Enabled = false;
            //            }
            //        }

            //        chkSmall.Enabled = true;
            //        chkMedium.Enabled = true;
            //        chkLarge.Enabled = true;
            //        chkXLarge.Enabled = true;

            //        cboSmall.Enabled = false;
            //        cboSmall.SelectedIndex = 0;
            //        txtSmallCost.Text = string.Empty;
            //        toppings = 0.0;
            //    }

        }

        private void chkMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMedium.Checked == true)
            {
                size = "Medium";
                resetSizes(size);
                cboMedium.Enabled = true;
                cboMedium.SelectedIndex = 1;
                resetToppings(false);
                resetSauces(false);
                buttonCalculate.Enabled = true;
            }
            else
            {
                resetTextboxes();
                resetComboBoxes(true);
                resetToppings(true);
                resetSauces(true);
                cboMedium.SelectedIndex = 0;
                txtComments.Text = string.Empty;
                buttonCalculate.Enabled = false;
                buttonNext.Enabled = false;
            }            
        }

        private void chkLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLarge.Checked == true)
            {
                size = "Large";
                resetSizes(size);
                cboLarge.Enabled = true;
                cboLarge.SelectedIndex = 1;
                resetToppings(false);
                resetSauces(false);
                buttonCalculate.Enabled = true;
            }
            else
            {
                resetTextboxes();
                resetComboBoxes(true);
                resetToppings(true);
                resetSauces(true);
                cboLarge.SelectedIndex = 0;
                txtComments.Text = string.Empty;
                buttonCalculate.Enabled = false;
                buttonNext.Enabled = false;
            }            
        }

        private void chkXLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (chkXLarge.Checked == true)
            {
                size = "XLarge";
                resetSizes(size);
                cboXLarge.Enabled = true;
                cboXLarge.SelectedIndex = 1;
                resetToppings(false);
                resetSauces(false);
                buttonCalculate.Enabled = true;
            }
            else
            {
                resetTextboxes();
                resetComboBoxes(true);
                resetToppings(true);
                resetSauces(true);
                cboXLarge.SelectedIndex = 0;
                txtComments.Text = string.Empty;
                buttonCalculate.Enabled = false;
                buttonNext.Enabled = false;
            }            
        }

        private void cboSmall_SelectedIndexChanged(object sender, EventArgs e)
        {
            smallTotal = 0.0;
            if (cboSmall.SelectedIndex > 0)
            {
                numPizzas = cboSmall.SelectedIndex;
                smallTotal = (numPizzas * double.Parse(cboSmall.Tag.ToString()));
            }
            //double total = 0.0;
            //toppings = 0.0;

            //if (cboSmall.SelectedIndex > 0)
            //{
            //    int count = cboSmall.SelectedIndex;
            //    total = (count * 10);                
            //    txtSmallCost.Text = string.Format("{0}", total);
            //    smallTotal = smallTotal + total;
            //    numPizzas = count;            
            //}
        }

        private void cboMedium_SelectedIndexChanged(object sender, EventArgs e)
        {
            mediumTotal = 0.0;
            if (cboMedium.SelectedIndex > 0)
            {
                numPizzas = cboMedium.SelectedIndex;
                mediumTotal = (numPizzas * double.Parse(cboMedium.Tag.ToString()));
            }
        }

        private void cboLarge_SelectedIndexChanged(object sender, EventArgs e)
        {
            largeTotal = 0.0;
            if (cboLarge.SelectedIndex > 0)
            {
                numPizzas = cboLarge.SelectedIndex;
                largeTotal = (numPizzas * double.Parse(cboLarge.Tag.ToString()));
            }
        }

        private void cboXLarge_SelectedIndexChanged(object sender, EventArgs e)
        {
            xlargeTotal = 0.0;
            if (cboXLarge.SelectedIndex > 0)
            {
                numPizzas = cboXLarge.SelectedIndex;
                xlargeTotal = (numPizzas * double.Parse(cboXLarge.Tag.ToString()));
            }
        }

        private void txtSmallCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(_summaryTabPage);
            var nl = Environment.NewLine;
            txtSummary.Text = "";

            txtSummary.Text = (" PIZZA ORDER SUMMARY ") + nl +
                               " =================== ";

            
            txtSummary.Text = txtSummary.Text + nl + nl +
                              " SIZE     : " + size + nl + nl +
                              " QUANTITY : " + numPizzas + nl + nl +
                              " SAUCE    : " + sauce + nl + nl +
                              " TOPPINGS : ";

            int topCount = 0;
            foreach (CheckBox chk in grpToppings.Controls.OfType<CheckBox>())
            {
                if (chk.Checked == true)
                {
                    txtSummary.Text = txtSummary.Text + chk.Text + nl + "            ";
                    topCount += 1;
                }
            }

            if (topCount == 0)
            {
                txtSummary.Text = txtSummary.Text + "Plain Cheese" + nl;
            }

            //MessageBox.Show(chkbox.Text);                                    

            if (txtComments.Text != "")
            {
                txtSummary.Text = nl + txtSummary.Text + nl +
                       " COMMENTS : " + txtComments.Text + nl;
            }

            if (txtGTotal.Text != "")
            {
                txtSummary.Text = nl + txtSummary.Text + nl +
                       " PRICE    : " + nl +
                       "     Sum  : " + txtSumTotal.Text + nl +
                       "7.5% Tax  : " + txtTax.Text + nl +
                       "   Total  : " + txtGTotal.Text + nl;
            }

            tabControl1.SelectedIndex = 1;

            buttonOrder.Enabled = false;
            buttonNext.Enabled = true;
        }

        private void lblToppings_Click(object sender, EventArgs e)
        {

        }

        private void btnClearSummary_Click(object sender, EventArgs e)
        {
            txtSummary.Text = string.Empty;
        }

        private void btnCloseSummary_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportSummary_Click(object sender, EventArgs e)
        {
            string summaryLog = @"C:\TEMP\PizzaOrderSummary.log";

            if (txtSummary.Text != "")
            {
                // Write log results out to a textfile
                System.IO.File.WriteAllText(summaryLog, txtSummary.Text);
                // Open the textfile with default text app
                Process.Start(summaryLog);
            }
            else
            {
                MessageBox.Show("Nothing to Export!!");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            //txtSummary.Text = "";
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void rdoTomato_CheckedChanged(object sender, EventArgs e)
        {
            sauce = rdoTomato.Text;
        }

        private void rdoAlfredo_CheckedChanged(object sender, EventArgs e)
        {
            sauce = rdoAlfredo.Text;
        }

        private void rdoBBQ_CheckedChanged(object sender, EventArgs e)
        {
            sauce = rdoBBQ.Text;
        }

        private void rdoPesto_CheckedChanged(object sender, EventArgs e)
        {
            sauce = rdoPesto.Text;
        }
        private void txtSummary_TextChanged(object sender, EventArgs e)
        {
            txtSummary.ScrollBars = ScrollBars.Vertical;
            txtSummary.WordWrap = false;
        }
        
        private void chkPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkSalami_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBacon_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkSausage_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkHam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkGroundBeef_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkChicken_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkChorizo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkMushroom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkGreenPepper_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBlackOlives_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkPineapple_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkJalapeno_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBasil_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkArtichoke_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabOrder_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            buttonNext.Enabled = false;
            resetTextboxes();

            if (cboSmall.SelectedIndex == 0 &&
                cboMedium.SelectedIndex == 0 &&
                cboLarge.SelectedIndex == 0 &&
                cboXLarge.SelectedIndex == 0)
            {
                MessageBox.Show("There are no orders to calculate.");
            }

            else if (chkSmall.Checked == false &&
                     chkMedium.Checked == false &&
                     chkLarge.Checked == false &&
                     chkXLarge.Checked == false)                               
            {
                MessageBox.Show("There are no orders to calculate.");
            }
            
            else
            {   // Get Toppings total
                toppings = 0.0;
                Total = 0.0;
                
                foreach (CheckBox chk in grpToppings.Controls.OfType<CheckBox>())
                {
                    if (chk.Checked == true)
                    {
                        toppings = toppings + double.Parse(chk.Tag.ToString());
                    }                   
                }

                // MessageBox.Show(string.Format("Toppings count : {0}", toppings));

                Total = smallTotal + mediumTotal + largeTotal + xlargeTotal + (toppings * numPizzas);

                //MessageBox.Show(string.Format("TOTAL : {0}", Total));


                if (smallTotal != 0 && cboSmall.SelectedIndex != 0)
                {
                    txtSmallCost.Text = Convert.ToString(Total);
                }
                if (mediumTotal != 0 && cboMedium.SelectedIndex != 0)
                {
                    txtMediumCost.Text = Convert.ToString(Total);
                }
                if (largeTotal != 0 && cboLarge.SelectedIndex != 0)
                {
                    txtLargeCost.Text = Convert.ToString(Total);
                }
                if (xlargeTotal != 0 && cboXLarge.SelectedIndex != 0)
                {
                    txtXLargeCost.Text = Convert.ToString(Total);
                }

                sumTotal = 0.0;
                taxTotal = 0.0;
                grandTotal = 0.0;

                foreach (TextBox txt in grpSize.Controls.OfType<TextBox>())
                {
                    if (txt.Text != "")
                    {
                        sumTotal = double.Parse(txt.Text);
                    }
                }

                txtSumTotal.Text = Convert.ToString(sumTotal.ToString("C2"));

                taxTotal = (sumTotal * tax);
                txtTax.Text = Convert.ToString(taxTotal.ToString("C2"));

                grandTotal = sumTotal + taxTotal;
                txtGTotal.Text = Convert.ToString(grandTotal.ToString("C2"));
                
                buttonOrder.Enabled = true;
            }
        }

        private void rdoSriracha_CheckedChanged(object sender, EventArgs e)
        {
            sauce = rdoSriracha.Text;
        }
    }
}
