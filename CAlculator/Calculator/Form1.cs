using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Diagnostics;
using Npgsql;

namespace Calculator
{
    public partial class CalcForm : Form
    {
        int dbms = 0;
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double results = 0.0;
        string exp = string.Empty;

        public CalcForm()
        {
            InitializeComponent();
            buttonStore.Enabled = false;            
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            buttonValue("0");
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            buttonValue("1");
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            buttonValue("2");
        }

        private void buttonThree_Click_1(object sender, EventArgs e)
        {
            buttonValue("3");
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            buttonValue("4");
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            buttonValue("5");
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            buttonValue("6");
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            buttonValue("7");
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            buttonValue("8");
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            buttonValue("9");
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            buttonValue(".");
            buttonDecimal.Enabled = false;
        }

        private void buttonValue(string num)
        {
            this.resultsBox.Text = "";
            input += num;
            this.resultsBox.Text += input;
        }

        public void clearComboBox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Insert(0, "DBMS");
            comboBox1.Items.Insert(1, "Oracle");
            comboBox1.Items.Insert(2, "Sql Server");
            comboBox1.Items.Insert(3, "Postgres");
            comboBox1.SelectedIndex = 0;
        }

        private void resetButtons()
        {
            buttonClear.BackColor = Color.Yellow;
            buttonZero.BackColor = Color.Yellow;
            buttonOne.BackColor = Color.Yellow;
            buttonTwo.BackColor = Color.Yellow;
            buttonThree.BackColor = Color.Yellow;
            buttonFour.BackColor = Color.Yellow;
            buttonFive.BackColor = Color.Yellow;
            buttonSix.BackColor = Color.Yellow;
            buttonSeven.BackColor = Color.Yellow;
            buttonEight.BackColor = Color.Yellow;
            buttonNine.BackColor = Color.Yellow;
            buttonDecimal.BackColor = Color.Yellow;

            buttonSubtract.BackColor = Color.FromArgb(255, 192, 192);
            buttonMultiply.BackColor = Color.FromArgb(255, 192, 192);
            buttonDivision.BackColor = Color.FromArgb(255, 192, 192);
            buttonAddition.BackColor = Color.FromArgb(255, 192, 192);
            buttonEquals.BackColor = Color.CornflowerBlue;
            buttonStore.Enabled = false;
        }         

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearComboBox();
            
            toggleButtons(true, Color.Yellow);

            resetButtons();

            this.resultsBox.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
            buttonClearLog_Click(sender, e);
            buttonDecimal.Enabled = true;
            operand1 = string.Empty;

        }

        private void toggleButtons(bool buttonStatus, System.Drawing.Color bgColor)
        {
            buttonEquals.Enabled = buttonStatus;
            buttonZero.Enabled = buttonStatus;
            buttonOne.Enabled = buttonStatus;
            buttonTwo.Enabled = buttonStatus;
            buttonThree.Enabled = buttonStatus;
            buttonFour.Enabled = buttonStatus;
            buttonFive.Enabled = buttonStatus;
            buttonSix.Enabled = buttonStatus;
            buttonSeven.Enabled = buttonStatus;
            buttonEight.Enabled = buttonStatus;
            buttonNine.Enabled = buttonStatus;
            buttonDecimal.Enabled = buttonStatus;
            buttonMultiply.Enabled = buttonStatus;
            buttonDivision.Enabled = buttonStatus;
            buttonAddition.Enabled = buttonStatus;
            buttonSubtract.Enabled = buttonStatus;

            if (bgColor == Color.Gray)
            {
                buttonEquals.BackColor = bgColor;
                buttonClear.BackColor = bgColor;
                buttonZero.BackColor = bgColor;
                buttonOne.BackColor = bgColor;
                buttonTwo.BackColor = bgColor;
                buttonThree.BackColor = bgColor;
                buttonFour.BackColor = bgColor;
                buttonFive.BackColor = bgColor;
                buttonSix.BackColor = bgColor;
                buttonSeven.BackColor = bgColor;
                buttonEight.BackColor = bgColor;
                buttonNine.BackColor = bgColor;
                buttonDecimal.BackColor = bgColor;
                buttonMultiply.BackColor = bgColor;
                buttonDivision.BackColor = bgColor;
                buttonAddition.BackColor = bgColor;
                buttonSubtract.BackColor = bgColor;
                buttonClear.BackColor = Color.Orange;
            }
            else
            {
                resetButtons();
            }
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            operationButton('/');
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operationButton('*');
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            operationButton('+');
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            operationButton('-');
        }

        private void operationButton (char op)
        {
            if (input != string.Empty)
            {
                if (op == '*')
                { buttonMultiply.BackColor = Color.Crimson; }

                if (op == '/')
                { buttonDivision.BackColor = Color.Crimson; }

                if (op == '+')
                { buttonAddition.BackColor = Color.Crimson; }

                if (op == '-')
                { buttonSubtract.BackColor = Color.Crimson; }
                
                if (operand1 == string.Empty)
                {
                    operand1 = input;
                }

                operation = op;
                input = string.Empty;
                buttonDecimal.Enabled = true;
                buttonAddition.Enabled = false;
                buttonSubtract.Enabled = false;
                buttonMultiply.Enabled = false;
                buttonDivision.Enabled = false;
            }
        }
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (input != string.Empty)
            {
                //buttonDecimal.Enabled = true;
                buttonStore.Enabled = true;
                operand2 = input;
                double num1, num2;
                double.TryParse(operand1, out num1);
                double.TryParse(operand2, out num2);

                //buttonClear_Click( sender, e);
                //System.Threading.Thread.Sleep(2000);
                toggleButtons(false, Color.Gray);

                if (operation == '+')
                {
                    results = num1 + num2;
                    resultsBox.Text = results.ToString();
                }
                else if (operation == '-')
                {
                    results = num1 - num2;
                    resultsBox.Text = results.ToString();
                }
                else if (operation == '*')
                {
                    results = num1 * num2;
                    resultsBox.Text = results.ToString();
                }
                else if (operation == '/')
                {
                    if (num2 != 0)
                    {
                        results = num1 / num2;
                        resultsBox.Text = results.ToString();
                    }
                    else
                    {
                        resultsBox.Text = "Division by ZERO is NOT ALLOWED!!";
                    }
                }

                exp = (num1.ToString() +
                       operation.ToString() +
                       num2.ToString() +
                       "=" +
                       resultsBox.Text);
            }
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {
            clearComboBox();
        }


        private string connSqlServer(string sql, string ReadWrite)
        {
            // create table sreetest.test.calculatorexpressions (id int, expression nvarchar(100))
            // create sequence test.calculatorexpression_seq start with 1 increment by 1
            SqlConnection ssConn = new SqlConnection("user id=test;" +
                "password=test;server=deeboo;trusted_connection=yes;" +
                "database=sreetest;connection timeout=30");
            ssConn.Open();

            SqlCommand sqlCmd = new SqlCommand(sql, ssConn);
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            string ssResults = "";

            while (sqlDr.Read())
            {
                if (ReadWrite == "R")
                {
                    ssResults = ssResults + 
                                Environment.NewLine + 
                                " id: " + sqlDr["id"].ToString() + 
                                "   exp: " + sqlDr["expression"].ToString();
                }
                else
                {
                    return ReadWrite;
                }

            }
         
            ssConn.Close();
            return ssResults;

        }

        private string connPostgres(string sql, string ReadWrite)
        {
            //https://www.codeproject.com/Articles/30989/Using-PostgreSQL-in-your-C-NET-application-An-intr
            NpgsqlConnection pgConn = new NpgsqlConnection("Server=ZAP12;" +
                           "User Id=csharp;Password=csharp;Database=pgtest");
            pgConn.Open();
            NpgsqlCommand pgCmd = new NpgsqlCommand(sql, pgConn);            
            NpgsqlDataReader pgDr = pgCmd.ExecuteReader();
            string pgResults = "";

            if (ReadWrite == "R")
            {
                while (pgDr.Read())
                {
                    pgResults = pgResults +
                                Environment.NewLine +
                                " id: " + pgDr["id"].ToString() +
                                "   exp: " + pgDr["expression"].ToString();
                }
            }
            else
            {
                return ReadWrite;
            }
            pgConn.Close();
            return pgResults;
        }
        
        
        private string connOracle(string sql, string ReadWrite)
        {            
                // CREATE TABLE CSHARP.CALCULATOREXPRESSIONS (ID NUMBER, EXPRESSION NVARCHAR2(100));
                // CREATE SEQUENCE  CSHARP.CALCULATORTAB_SEQ  MINVALUE 1 INCREMENT BY 1 START NOCACHE NOORDER NOCYCLE NOPARTITION;
                string oradb = "User Id=csharp;Password=csharp;" +
                               "Data Source=TIGERS/ESRI";
                OracleConnection oraConn = new OracleConnection(oradb);
                oraConn.Open();

                OracleCommand oraCmd = new OracleCommand(sql, oraConn);
                OracleDataReader oraDr = oraCmd.ExecuteReader();

                string oraResults = string.Empty;

                while (oraDr.Read())
                {

                    if (ReadWrite == "R")
                    {
                        oraResults = oraResults +
                                     Environment.NewLine +
                                     " id: " + oraDr["id"].ToString() +
                                     "   exp: " + oraDr["expression"].ToString();
                    }
                    else
                    {
                        return ReadWrite;
                    }

                }
                //oraConn.Dispose();
                oraConn.Close();
                return oraResults;            
        }

        private void buttonStore_Click(object sender, EventArgs e)
        {
            string sql = string.Empty;
            string results = string.Empty;

            if (dbms == 1)      // Oracle
            {
                //http://www.oracle.com/webfolder/technetwork/tutorials/obe/db/hol08/dotnet/getstarted-c/getstarted_c_otn.htm#t4
                //http://www.c-sharpcorner.com/UploadFile/nipuntomar/connection-strings-for-oracle/

                // Text Column being returned has to be NVARCHAR2 - VARCHAR2 will not suffice           
                MessageBox.Show(String.Format("Inserting expression into Oracle : " + Environment.NewLine + "   {0}",
                                              exp.ToString()), "Connected to Oracle");
                sql = String.Format("insert into csharp.calculatorexpressions values " +
                                           "(calculatortab_seq.nextval, '{0}')", exp);
                results = connOracle(sql, "W");
                buttonStore.Enabled = false;
            }
            else if (dbms == 2)     // SQL Server
            {
                MessageBox.Show(String.Format("Inserting expression into SQL Server : " + Environment.NewLine + "   {0}",
                                              exp.ToString()), "Connected to SQL Server");
                sql = String.Format("insert into sreetest.test.calculatorexpressions values" +
                                           "(NEXT VALUE FOR TEST.calculatorexpression_seq, '{0}')", exp);
                results = connSqlServer(sql, "W");
                buttonStore.Enabled = false;
            }
            else if (dbms == 3)     // Postgres
            {
                MessageBox.Show(String.Format("Inserting expression into Postgres : " + Environment.NewLine + "   {0}",
                                              exp.ToString()), "Connected to Postgres");
                sql = String.Format("insert into csharp.calculatorexpressions values " +
                                           "(nextval('csharp.calcexp_seq'), '{0}')", exp);
                results = connPostgres(sql, "W");
                buttonStore.Enabled = false;
            }
            else
            {
                MessageBox.Show("Select a DBMS to store the expression into.");
            }
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            string sql = string.Empty;
            string results = string.Empty;

            if (dbms == 1)  // Oracle
            {
                sql = "select id, expression from csharp.calculatorexpressions order by 1";
                results = connOracle(sql, "R");
                //MessageBox.Show("Last expression inserted into Oracle : " + Environment.NewLine + "  " + results, "Connected to Oracle");
                txtLog.Text = String.Format("{0}Calculator Expressions stored in Oracle ", Environment.NewLine);
                txtLog.Text = txtLog.Text + Environment.NewLine + results;
                tabControl1.SelectedIndex = 1;
            }
            else if (dbms == 2) // SQL Server
            {
                sql = "select id, expression from sreetest.test.calculatorexpressions order by 1";
                results = connSqlServer(sql, "R");
                //MessageBox.Show("Last expression inserted into SQL Server : " + Environment.NewLine + "  " + results, "Connected to SQL Server");
                txtLog.Text = String.Format("{0}Calculator Expressions stored in SQL Server ", Environment.NewLine);
                txtLog.Text = txtLog.Text + Environment.NewLine + results;
                tabControl1.SelectedIndex = 1;
            }
            else if (dbms == 3) // Postgres
            {
                sql = "select id, expression from csharp.calculatorexpressions order by 1";
                results = connPostgres(sql, "R");
                //MessageBox.Show("Last expression inserted into Postgres : " + Environment.NewLine + "  " + results, "Connected to SQL Server");
                txtLog.Text = String.Format("{0}Calculator Expressions stored in Postgres ", Environment.NewLine);
                txtLog.Text = txtLog.Text + Environment.NewLine + results;
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                //txtLog.Text = txtLog.Text + Environment.NewLine + Environment.NewLine + "Select a DBMS to retrieve the last expression from.";
                MessageBox.Show("Select a DBMS to retrieve the last expression from.");
            }            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (comboBox1.SelectedIndex == 1)
            {
                dbms = 1;   // Oracle
            }
            if (comboBox1.SelectedIndex == 2)
            {
                dbms = 2;   // SQL Server    
            }
            if (comboBox1.SelectedIndex == 3)
            {
                dbms = 3;   // Postgres
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            string calcLogFile = string.Empty;
                        
                if (dbms == 1)
                {
                    calcLogFile = @"C:\TEMP\CalculatorOracleExport.log";
                }
                if (dbms == 2)
                {
                    calcLogFile = @"C:\TEMP\CalculatorSqlServerExport.log";
                }
                if (dbms == 3)
                {
                    calcLogFile = @"C:\TEMP\CalculatorPostgresExport.log";
                }

            if (txtLog.Text != "")
            {
                // Write log results out to a textfile
                System.IO.File.WriteAllText(calcLogFile, txtLog.Text);
                // Open the textfile with default text app
                Process.Start(calcLogFile);
            }
            else
            {
                MessageBox.Show("Nothing to Export!!");                
            }
        }

        private void buttonExitLog_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Text = string.Empty;
            comboBox1.SelectedIndex = 0;
            dbms = 0;
        }
    }
}
