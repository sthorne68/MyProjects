namespace PizzaOrderForm
{
    partial class formPizza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkArtichoke = new System.Windows.Forms.CheckBox();
            this.chkChorizo = new System.Windows.Forms.CheckBox();
            this.chkBasil = new System.Windows.Forms.CheckBox();
            this.chkJalapeno = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkBlackOlives = new System.Windows.Forms.CheckBox();
            this.chkGreenPepper = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkChicken = new System.Windows.Forms.CheckBox();
            this.chkGroundBeef = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkSalami = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtGTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.txtSumTotal = new System.Windows.Forms.TextBox();
            this.txtXLargeCost = new System.Windows.Forms.TextBox();
            this.txtLargeCost = new System.Windows.Forms.TextBox();
            this.txtMediumCost = new System.Windows.Forms.TextBox();
            this.txtSmallCost = new System.Windows.Forms.TextBox();
            this.cboXLarge = new System.Windows.Forms.ComboBox();
            this.cboLarge = new System.Windows.Forms.ComboBox();
            this.cboMedium = new System.Windows.Forms.ComboBox();
            this.cboSmall = new System.Windows.Forms.ComboBox();
            this.chkXLarge = new System.Windows.Forms.CheckBox();
            this.chkLarge = new System.Windows.Forms.CheckBox();
            this.chkMedium = new System.Windows.Forms.CheckBox();
            this.chkSmall = new System.Windows.Forms.CheckBox();
            this.grpSauce = new System.Windows.Forms.GroupBox();
            this.rdoPesto = new System.Windows.Forms.RadioButton();
            this.rdoBBQ = new System.Windows.Forms.RadioButton();
            this.rdoAlfredo = new System.Windows.Forms.RadioButton();
            this.rdoTomato = new System.Windows.Forms.RadioButton();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.buttonBack = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.rdoSriracha = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabOrder.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.grpSauce.SuspendLayout();
            this.tabSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "tabPizza";
            this.tabControl1.Controls.Add(this.tabOrder);
            this.tabControl1.Controls.Add(this.tabSummary);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(505, 391);
            this.tabControl1.TabIndex = 0;
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.buttonCalculate);
            this.tabOrder.Controls.Add(this.txtComments);
            this.tabOrder.Controls.Add(this.lblComments);
            this.tabOrder.Controls.Add(this.buttonNext);
            this.tabOrder.Controls.Add(this.lblCost);
            this.tabOrder.Controls.Add(this.lblAmount);
            this.tabOrder.Controls.Add(this.buttonOrder);
            this.tabOrder.Controls.Add(this.grpToppings);
            this.tabOrder.Controls.Add(this.grpSize);
            this.tabOrder.Controls.Add(this.grpSauce);
            this.tabOrder.Location = new System.Drawing.Point(4, 22);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrder.Size = new System.Drawing.Size(497, 365);
            this.tabOrder.TabIndex = 0;
            this.tabOrder.Text = "Order";
            this.tabOrder.UseVisualStyleBackColor = true;
            this.tabOrder.Click += new System.EventHandler(this.tabOrder_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(178, 328);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(101, 31);
            this.buttonCalculate.TabIndex = 50;
            this.buttonCalculate.Text = "CALCULATE";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(13, 283);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(466, 39);
            this.txtComments.TabIndex = 46;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(11, 262);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(64, 13);
            this.lblComments.TabIndex = 45;
            this.lblComments.Text = "Comments";
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(407, 328);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(81, 32);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "NEXT > ";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(142, 18);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(32, 13);
            this.lblCost.TabIndex = 44;
            this.lblCost.Text = "Cost";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(78, 18);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(49, 13);
            this.lblAmount.TabIndex = 43;
            this.lblAmount.Text = "Amount";
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(294, 328);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(102, 31);
            this.buttonOrder.TabIndex = 39;
            this.buttonOrder.Text = "PLACE ORDER";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chkArtichoke);
            this.grpToppings.Controls.Add(this.chkChorizo);
            this.grpToppings.Controls.Add(this.chkBasil);
            this.grpToppings.Controls.Add(this.chkJalapeno);
            this.grpToppings.Controls.Add(this.chkPineapple);
            this.grpToppings.Controls.Add(this.chkBlackOlives);
            this.grpToppings.Controls.Add(this.chkGreenPepper);
            this.grpToppings.Controls.Add(this.chkOnion);
            this.grpToppings.Controls.Add(this.chkMushroom);
            this.grpToppings.Controls.Add(this.chkChicken);
            this.grpToppings.Controls.Add(this.chkGroundBeef);
            this.grpToppings.Controls.Add(this.chkHam);
            this.grpToppings.Controls.Add(this.chkSausage);
            this.grpToppings.Controls.Add(this.chkBacon);
            this.grpToppings.Controls.Add(this.chkSalami);
            this.grpToppings.Controls.Add(this.chkPepperoni);
            this.grpToppings.Location = new System.Drawing.Point(201, 18);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(211, 239);
            this.grpToppings.TabIndex = 47;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // chkArtichoke
            // 
            this.chkArtichoke.AutoSize = true;
            this.chkArtichoke.Location = new System.Drawing.Point(105, 188);
            this.chkArtichoke.Name = "chkArtichoke";
            this.chkArtichoke.Size = new System.Drawing.Size(80, 17);
            this.chkArtichoke.TabIndex = 57;
            this.chkArtichoke.Tag = "0.50";
            this.chkArtichoke.Text = "Artichoke";
            this.chkArtichoke.UseVisualStyleBackColor = true;
            // 
            // chkChorizo
            // 
            this.chkChorizo.AutoSize = true;
            this.chkChorizo.Location = new System.Drawing.Point(6, 188);
            this.chkChorizo.Name = "chkChorizo";
            this.chkChorizo.Size = new System.Drawing.Size(68, 17);
            this.chkChorizo.TabIndex = 56;
            this.chkChorizo.Tag = "1.00";
            this.chkChorizo.Text = "Chorizo";
            this.chkChorizo.UseVisualStyleBackColor = true;
            // 
            // chkBasil
            // 
            this.chkBasil.AutoSize = true;
            this.chkBasil.Location = new System.Drawing.Point(105, 165);
            this.chkBasil.Name = "chkBasil";
            this.chkBasil.Size = new System.Drawing.Size(53, 17);
            this.chkBasil.TabIndex = 55;
            this.chkBasil.Tag = "0.50";
            this.chkBasil.Text = "Basil";
            this.chkBasil.UseVisualStyleBackColor = true;
            // 
            // chkJalapeno
            // 
            this.chkJalapeno.AutoSize = true;
            this.chkJalapeno.Location = new System.Drawing.Point(105, 142);
            this.chkJalapeno.Name = "chkJalapeno";
            this.chkJalapeno.Size = new System.Drawing.Size(77, 17);
            this.chkJalapeno.TabIndex = 54;
            this.chkJalapeno.Tag = "0.50";
            this.chkJalapeno.Text = "Jalapeno";
            this.chkJalapeno.UseVisualStyleBackColor = true;
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Location = new System.Drawing.Point(105, 119);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(82, 17);
            this.chkPineapple.TabIndex = 53;
            this.chkPineapple.Tag = "0.50";
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            // 
            // chkBlackOlives
            // 
            this.chkBlackOlives.AutoSize = true;
            this.chkBlackOlives.Location = new System.Drawing.Point(105, 96);
            this.chkBlackOlives.Name = "chkBlackOlives";
            this.chkBlackOlives.Size = new System.Drawing.Size(97, 17);
            this.chkBlackOlives.TabIndex = 52;
            this.chkBlackOlives.Tag = "0.50";
            this.chkBlackOlives.Text = "Black Olives";
            this.chkBlackOlives.UseVisualStyleBackColor = true;
            // 
            // chkGreenPepper
            // 
            this.chkGreenPepper.AutoSize = true;
            this.chkGreenPepper.Location = new System.Drawing.Point(105, 73);
            this.chkGreenPepper.Name = "chkGreenPepper";
            this.chkGreenPepper.Size = new System.Drawing.Size(104, 17);
            this.chkGreenPepper.TabIndex = 51;
            this.chkGreenPepper.Tag = "0.50";
            this.chkGreenPepper.Text = "Green Pepper";
            this.chkGreenPepper.UseVisualStyleBackColor = true;
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(105, 50);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(59, 17);
            this.chkOnion.TabIndex = 50;
            this.chkOnion.Tag = "0.50";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Location = new System.Drawing.Point(105, 27);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(83, 17);
            this.chkMushroom.TabIndex = 49;
            this.chkMushroom.Tag = "0.50";
            this.chkMushroom.Text = "Mushroom";
            this.chkMushroom.UseVisualStyleBackColor = true;
            // 
            // chkChicken
            // 
            this.chkChicken.AutoSize = true;
            this.chkChicken.Location = new System.Drawing.Point(6, 165);
            this.chkChicken.Name = "chkChicken";
            this.chkChicken.Size = new System.Drawing.Size(72, 17);
            this.chkChicken.TabIndex = 48;
            this.chkChicken.Tag = "1.00";
            this.chkChicken.Text = "Chicken";
            this.chkChicken.UseVisualStyleBackColor = true;
            // 
            // chkGroundBeef
            // 
            this.chkGroundBeef.AutoSize = true;
            this.chkGroundBeef.Location = new System.Drawing.Point(6, 142);
            this.chkGroundBeef.Name = "chkGroundBeef";
            this.chkGroundBeef.Size = new System.Drawing.Size(97, 17);
            this.chkGroundBeef.TabIndex = 47;
            this.chkGroundBeef.Tag = "1.00";
            this.chkGroundBeef.Text = "Ground Beef";
            this.chkGroundBeef.UseVisualStyleBackColor = true;
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Location = new System.Drawing.Point(6, 119);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(51, 17);
            this.chkHam.TabIndex = 46;
            this.chkHam.Tag = "1.00";
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Location = new System.Drawing.Point(6, 96);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(75, 17);
            this.chkSausage.TabIndex = 45;
            this.chkSausage.Tag = "1.00";
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(6, 73);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(62, 17);
            this.chkBacon.TabIndex = 44;
            this.chkBacon.Tag = "1.00";
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkSalami
            // 
            this.chkSalami.AutoSize = true;
            this.chkSalami.Location = new System.Drawing.Point(6, 50);
            this.chkSalami.Name = "chkSalami";
            this.chkSalami.Size = new System.Drawing.Size(63, 17);
            this.chkSalami.TabIndex = 43;
            this.chkSalami.Tag = "1.00";
            this.chkSalami.Text = "Salami";
            this.chkSalami.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(6, 27);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(83, 17);
            this.chkPepperoni.TabIndex = 42;
            this.chkPepperoni.Tag = "1.00";
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.lblTax);
            this.grpSize.Controls.Add(this.lblTotal);
            this.grpSize.Controls.Add(this.txtGTotal);
            this.grpSize.Controls.Add(this.txtTax);
            this.grpSize.Controls.Add(this.lblSum);
            this.grpSize.Controls.Add(this.txtSumTotal);
            this.grpSize.Controls.Add(this.txtXLargeCost);
            this.grpSize.Controls.Add(this.txtLargeCost);
            this.grpSize.Controls.Add(this.txtMediumCost);
            this.grpSize.Controls.Add(this.txtSmallCost);
            this.grpSize.Controls.Add(this.cboXLarge);
            this.grpSize.Controls.Add(this.cboLarge);
            this.grpSize.Controls.Add(this.cboMedium);
            this.grpSize.Controls.Add(this.cboSmall);
            this.grpSize.Controls.Add(this.chkXLarge);
            this.grpSize.Controls.Add(this.chkLarge);
            this.grpSize.Controls.Add(this.chkMedium);
            this.grpSize.Controls.Add(this.chkSmall);
            this.grpSize.Location = new System.Drawing.Point(9, 18);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(192, 238);
            this.grpSize.TabIndex = 48;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(52, 182);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(74, 13);
            this.lblTax.TabIndex = 38;
            this.lblTax.Text = "7.5% TAX   ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(71, 209);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 13);
            this.lblTotal.TabIndex = 37;
            this.lblTotal.Text = "TOTAL ";
            // 
            // txtGTotal
            // 
            this.txtGTotal.Location = new System.Drawing.Point(126, 208);
            this.txtGTotal.Name = "txtGTotal";
            this.txtGTotal.ReadOnly = true;
            this.txtGTotal.Size = new System.Drawing.Size(60, 20);
            this.txtGTotal.TabIndex = 36;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(126, 179);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(60, 20);
            this.txtTax.TabIndex = 35;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(76, 156);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(46, 13);
            this.lblSum.TabIndex = 34;
            this.lblSum.Text = " SUM  ";
            // 
            // txtSumTotal
            // 
            this.txtSumTotal.Location = new System.Drawing.Point(126, 153);
            this.txtSumTotal.Name = "txtSumTotal";
            this.txtSumTotal.ReadOnly = true;
            this.txtSumTotal.Size = new System.Drawing.Size(60, 20);
            this.txtSumTotal.TabIndex = 33;
            // 
            // txtXLargeCost
            // 
            this.txtXLargeCost.Location = new System.Drawing.Point(126, 121);
            this.txtXLargeCost.Name = "txtXLargeCost";
            this.txtXLargeCost.ReadOnly = true;
            this.txtXLargeCost.Size = new System.Drawing.Size(60, 20);
            this.txtXLargeCost.TabIndex = 31;
            // 
            // txtLargeCost
            // 
            this.txtLargeCost.Location = new System.Drawing.Point(126, 88);
            this.txtLargeCost.Name = "txtLargeCost";
            this.txtLargeCost.ReadOnly = true;
            this.txtLargeCost.Size = new System.Drawing.Size(60, 20);
            this.txtLargeCost.TabIndex = 30;
            // 
            // txtMediumCost
            // 
            this.txtMediumCost.Location = new System.Drawing.Point(126, 53);
            this.txtMediumCost.Name = "txtMediumCost";
            this.txtMediumCost.ReadOnly = true;
            this.txtMediumCost.Size = new System.Drawing.Size(60, 20);
            this.txtMediumCost.TabIndex = 29;
            // 
            // txtSmallCost
            // 
            this.txtSmallCost.Location = new System.Drawing.Point(126, 19);
            this.txtSmallCost.Name = "txtSmallCost";
            this.txtSmallCost.ReadOnly = true;
            this.txtSmallCost.Size = new System.Drawing.Size(60, 20);
            this.txtSmallCost.TabIndex = 28;
            // 
            // cboXLarge
            // 
            this.cboXLarge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboXLarge.Enabled = false;
            this.cboXLarge.FormattingEnabled = true;
            this.cboXLarge.Location = new System.Drawing.Point(72, 120);
            this.cboXLarge.Name = "cboXLarge";
            this.cboXLarge.Size = new System.Drawing.Size(45, 21);
            this.cboXLarge.TabIndex = 8;
            this.cboXLarge.Tag = "16";
            this.cboXLarge.SelectedIndexChanged += new System.EventHandler(this.cboXLarge_SelectedIndexChanged);
            // 
            // cboLarge
            // 
            this.cboLarge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLarge.Enabled = false;
            this.cboLarge.FormattingEnabled = true;
            this.cboLarge.Location = new System.Drawing.Point(72, 87);
            this.cboLarge.Name = "cboLarge";
            this.cboLarge.Size = new System.Drawing.Size(45, 21);
            this.cboLarge.TabIndex = 7;
            this.cboLarge.Tag = "14";
            this.cboLarge.SelectedIndexChanged += new System.EventHandler(this.cboLarge_SelectedIndexChanged);
            // 
            // cboMedium
            // 
            this.cboMedium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedium.Enabled = false;
            this.cboMedium.FormattingEnabled = true;
            this.cboMedium.Location = new System.Drawing.Point(72, 52);
            this.cboMedium.Name = "cboMedium";
            this.cboMedium.Size = new System.Drawing.Size(45, 21);
            this.cboMedium.TabIndex = 6;
            this.cboMedium.Tag = "12";
            this.cboMedium.SelectedIndexChanged += new System.EventHandler(this.cboMedium_SelectedIndexChanged);
            // 
            // cboSmall
            // 
            this.cboSmall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSmall.Enabled = false;
            this.cboSmall.FormattingEnabled = true;
            this.cboSmall.Location = new System.Drawing.Point(72, 18);
            this.cboSmall.Name = "cboSmall";
            this.cboSmall.Size = new System.Drawing.Size(45, 21);
            this.cboSmall.TabIndex = 5;
            this.cboSmall.Tag = "10";
            this.cboSmall.SelectedIndexChanged += new System.EventHandler(this.cboSmall_SelectedIndexChanged);
            // 
            // chkXLarge
            // 
            this.chkXLarge.AutoSize = true;
            this.chkXLarge.Location = new System.Drawing.Point(4, 120);
            this.chkXLarge.Name = "chkXLarge";
            this.chkXLarge.Size = new System.Drawing.Size(66, 17);
            this.chkXLarge.TabIndex = 4;
            this.chkXLarge.Text = "XLarge";
            this.chkXLarge.UseVisualStyleBackColor = true;
            this.chkXLarge.CheckedChanged += new System.EventHandler(this.chkXLarge_CheckedChanged);
            // 
            // chkLarge
            // 
            this.chkLarge.AutoSize = true;
            this.chkLarge.Location = new System.Drawing.Point(4, 87);
            this.chkLarge.Name = "chkLarge";
            this.chkLarge.Size = new System.Drawing.Size(58, 17);
            this.chkLarge.TabIndex = 3;
            this.chkLarge.Text = "Large";
            this.chkLarge.UseVisualStyleBackColor = true;
            this.chkLarge.CheckedChanged += new System.EventHandler(this.chkLarge_CheckedChanged);
            // 
            // chkMedium
            // 
            this.chkMedium.AutoSize = true;
            this.chkMedium.Location = new System.Drawing.Point(4, 52);
            this.chkMedium.Name = "chkMedium";
            this.chkMedium.Size = new System.Drawing.Size(69, 17);
            this.chkMedium.TabIndex = 2;
            this.chkMedium.Text = "Medium";
            this.chkMedium.UseVisualStyleBackColor = true;
            this.chkMedium.CheckedChanged += new System.EventHandler(this.chkMedium_CheckedChanged);
            // 
            // chkSmall
            // 
            this.chkSmall.AutoSize = true;
            this.chkSmall.Location = new System.Drawing.Point(4, 18);
            this.chkSmall.Name = "chkSmall";
            this.chkSmall.Size = new System.Drawing.Size(56, 17);
            this.chkSmall.TabIndex = 1;
            this.chkSmall.Text = "Small";
            this.chkSmall.UseVisualStyleBackColor = true;
            this.chkSmall.CheckedChanged += new System.EventHandler(this.chkSmall_CheckedChanged);
            // 
            // grpSauce
            // 
            this.grpSauce.Controls.Add(this.rdoSriracha);
            this.grpSauce.Controls.Add(this.rdoPesto);
            this.grpSauce.Controls.Add(this.rdoBBQ);
            this.grpSauce.Controls.Add(this.rdoAlfredo);
            this.grpSauce.Controls.Add(this.rdoTomato);
            this.grpSauce.Location = new System.Drawing.Point(412, 18);
            this.grpSauce.Name = "grpSauce";
            this.grpSauce.Size = new System.Drawing.Size(78, 141);
            this.grpSauce.TabIndex = 49;
            this.grpSauce.TabStop = false;
            this.grpSauce.Text = "Sauce";
            // 
            // rdoPesto
            // 
            this.rdoPesto.AutoSize = true;
            this.rdoPesto.Location = new System.Drawing.Point(4, 118);
            this.rdoPesto.Name = "rdoPesto";
            this.rdoPesto.Size = new System.Drawing.Size(57, 17);
            this.rdoPesto.TabIndex = 32;
            this.rdoPesto.TabStop = true;
            this.rdoPesto.Text = "Pesto";
            this.rdoPesto.UseVisualStyleBackColor = true;
            this.rdoPesto.CheckedChanged += new System.EventHandler(this.rdoPesto_CheckedChanged);
            // 
            // rdoBBQ
            // 
            this.rdoBBQ.AutoSize = true;
            this.rdoBBQ.Location = new System.Drawing.Point(4, 72);
            this.rdoBBQ.Name = "rdoBBQ";
            this.rdoBBQ.Size = new System.Drawing.Size(50, 17);
            this.rdoBBQ.TabIndex = 27;
            this.rdoBBQ.TabStop = true;
            this.rdoBBQ.Text = "BBQ";
            this.rdoBBQ.UseVisualStyleBackColor = true;
            this.rdoBBQ.CheckedChanged += new System.EventHandler(this.rdoBBQ_CheckedChanged);
            // 
            // rdoAlfredo
            // 
            this.rdoAlfredo.AutoSize = true;
            this.rdoAlfredo.Location = new System.Drawing.Point(4, 49);
            this.rdoAlfredo.Name = "rdoAlfredo";
            this.rdoAlfredo.Size = new System.Drawing.Size(65, 17);
            this.rdoAlfredo.TabIndex = 26;
            this.rdoAlfredo.TabStop = true;
            this.rdoAlfredo.Text = "Alfredo";
            this.rdoAlfredo.UseVisualStyleBackColor = true;
            this.rdoAlfredo.CheckedChanged += new System.EventHandler(this.rdoAlfredo_CheckedChanged);
            // 
            // rdoTomato
            // 
            this.rdoTomato.AutoSize = true;
            this.rdoTomato.Location = new System.Drawing.Point(4, 26);
            this.rdoTomato.Name = "rdoTomato";
            this.rdoTomato.Size = new System.Drawing.Size(67, 17);
            this.rdoTomato.TabIndex = 25;
            this.rdoTomato.TabStop = true;
            this.rdoTomato.Text = "Tomato";
            this.rdoTomato.UseVisualStyleBackColor = true;
            this.rdoTomato.CheckedChanged += new System.EventHandler(this.rdoTomato_CheckedChanged);
            // 
            // tabSummary
            // 
            this.tabSummary.Controls.Add(this.buttonBack);
            this.tabSummary.Controls.Add(this.btnExport);
            this.tabSummary.Controls.Add(this.txtSummary);
            this.tabSummary.Location = new System.Drawing.Point(4, 22);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSummary.Size = new System.Drawing.Size(497, 365);
            this.tabSummary.TabIndex = 1;
            this.tabSummary.Text = "Summary";
            this.tabSummary.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(306, 323);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(82, 30);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "< BACK";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(398, 323);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(82, 30);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "EXPORT";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExportSummary_Click);
            // 
            // txtSummary
            // 
            this.txtSummary.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSummary.Location = new System.Drawing.Point(13, 14);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ReadOnly = true;
            this.txtSummary.Size = new System.Drawing.Size(468, 294);
            this.txtSummary.TabIndex = 0;
            this.txtSummary.TextChanged += new System.EventHandler(this.txtSummary_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(296, 399);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 22);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(405, 399);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 22);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rdoSriracha
            // 
            this.rdoSriracha.AutoSize = true;
            this.rdoSriracha.Location = new System.Drawing.Point(4, 96);
            this.rdoSriracha.Name = "rdoSriracha";
            this.rdoSriracha.Size = new System.Drawing.Size(72, 17);
            this.rdoSriracha.TabIndex = 33;
            this.rdoSriracha.TabStop = true;
            this.rdoSriracha.Text = "Sriracha";
            this.rdoSriracha.UseVisualStyleBackColor = true;
            this.rdoSriracha.CheckedChanged += new System.EventHandler(this.rdoSriracha_CheckedChanged);
            // 
            // formPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 429);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnClear);
            this.Name = "formPizza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.formPizza_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabOrder.ResumeLayout(false);
            this.tabOrder.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpSauce.ResumeLayout(false);
            this.grpSauce.PerformLayout();
            this.tabSummary.ResumeLayout(false);
            this.tabSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.RadioButton rdoBBQ;
        private System.Windows.Forms.RadioButton rdoAlfredo;
        private System.Windows.Forms.RadioButton rdoTomato;
        private System.Windows.Forms.RadioButton rdoPesto;
        private System.Windows.Forms.ComboBox cboXLarge;
        private System.Windows.Forms.ComboBox cboLarge;
        private System.Windows.Forms.ComboBox cboMedium;
        private System.Windows.Forms.ComboBox cboSmall;
        private System.Windows.Forms.CheckBox chkXLarge;
        private System.Windows.Forms.CheckBox chkLarge;
        private System.Windows.Forms.CheckBox chkMedium;
        private System.Windows.Forms.CheckBox chkSmall;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtXLargeCost;
        private System.Windows.Forms.TextBox txtLargeCost;
        private System.Windows.Forms.TextBox txtMediumCost;
        private System.Windows.Forms.TextBox txtSmallCost;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TextBox txtSumTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtGTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox chkArtichoke;
        private System.Windows.Forms.CheckBox chkChorizo;
        private System.Windows.Forms.CheckBox chkBasil;
        private System.Windows.Forms.CheckBox chkJalapeno;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.CheckBox chkBlackOlives;
        private System.Windows.Forms.CheckBox chkGreenPepper;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.CheckBox chkChicken;
        private System.Windows.Forms.CheckBox chkGroundBeef;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkSalami;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.GroupBox grpSauce;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.RadioButton rdoSriracha;
    }
}

