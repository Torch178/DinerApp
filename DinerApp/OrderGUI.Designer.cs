namespace DinerApp
{
    partial class OrderGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            placeOrderToolStripMenuItem = new ToolStripMenuItem();
            clearOrderToolStripMenuItem = new ToolStripMenuItem();
            displayOrderToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            entreeToolStripMenuItem = new ToolStripMenuItem();
            drinksToolStripMenuItem = new ToolStripMenuItem();
            specialRequestsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            chBxWater = new CheckBox();
            cmBxSpecialRequests = new ComboBox();
            lstBxEntreeSelection = new ListBox();
            lblEntreeSelection = new Label();
            lblSpecialRequests = new Label();
            rbMilk = new RadioButton();
            rbJuice = new RadioButton();
            rbSoda = new RadioButton();
            rbLemonade = new RadioButton();
            rbTea = new RadioButton();
            rbCoffee = new RadioButton();
            grBxDrinkSelection = new GroupBox();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 3, 0, 3);
            menuStrip.Size = new Size(914, 30);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { placeOrderToolStripMenuItem, clearOrderToolStripMenuItem, displayOrderToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // placeOrderToolStripMenuItem
            // 
            placeOrderToolStripMenuItem.Name = "placeOrderToolStripMenuItem";
            placeOrderToolStripMenuItem.Size = new Size(183, 26);
            placeOrderToolStripMenuItem.Text = "Place Order";
            placeOrderToolStripMenuItem.Click += placeOrderToolStripMenuItem_Click;
            // 
            // clearOrderToolStripMenuItem
            // 
            clearOrderToolStripMenuItem.Name = "clearOrderToolStripMenuItem";
            clearOrderToolStripMenuItem.Size = new Size(183, 26);
            clearOrderToolStripMenuItem.Text = "Clear Order";
            clearOrderToolStripMenuItem.Click += clearOrderToolStripMenuItem_Click;
            // 
            // displayOrderToolStripMenuItem
            // 
            displayOrderToolStripMenuItem.Name = "displayOrderToolStripMenuItem";
            displayOrderToolStripMenuItem.Size = new Size(183, 26);
            displayOrderToolStripMenuItem.Text = "Display Order";
            displayOrderToolStripMenuItem.Click += displayOrderToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(183, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { entreeToolStripMenuItem, drinksToolStripMenuItem, specialRequestsToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // entreeToolStripMenuItem
            // 
            entreeToolStripMenuItem.Name = "entreeToolStripMenuItem";
            entreeToolStripMenuItem.Size = new Size(203, 26);
            entreeToolStripMenuItem.Text = "Entree";
            entreeToolStripMenuItem.Click += entreeToolStripMenuItem_Click;
            // 
            // drinksToolStripMenuItem
            // 
            drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            drinksToolStripMenuItem.Size = new Size(203, 26);
            drinksToolStripMenuItem.Text = "Drinks";
            drinksToolStripMenuItem.Click += drinksToolStripMenuItem_Click;
            // 
            // specialRequestsToolStripMenuItem
            // 
            specialRequestsToolStripMenuItem.Name = "specialRequestsToolStripMenuItem";
            specialRequestsToolStripMenuItem.Size = new Size(203, 26);
            specialRequestsToolStripMenuItem.Text = "Special Requests";
            specialRequestsToolStripMenuItem.Click += specialRequestsToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // chBxWater
            // 
            chBxWater.AutoSize = true;
            chBxWater.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chBxWater.Location = new Point(89, 461);
            chBxWater.Margin = new Padding(3, 4, 3, 4);
            chBxWater.Name = "chBxWater";
            chBxWater.Size = new Size(80, 27);
            chBxWater.TabIndex = 1;
            chBxWater.Text = "Water";
            chBxWater.UseVisualStyleBackColor = true;
            chBxWater.CheckedChanged += chBxWater_CheckedChanged;
            // 
            // cmBxSpecialRequests
            // 
            cmBxSpecialRequests.BackColor = Color.LemonChiffon;
            cmBxSpecialRequests.FormattingEnabled = true;
            cmBxSpecialRequests.Items.AddRange(new object[] { "Whole Wheat", "Pumpernickle", "Seedless Rye", "Sourdough", "Pita" });
            cmBxSpecialRequests.Location = new Point(88, 376);
            cmBxSpecialRequests.Margin = new Padding(3, 4, 3, 4);
            cmBxSpecialRequests.Name = "cmBxSpecialRequests";
            cmBxSpecialRequests.Size = new Size(254, 28);
            cmBxSpecialRequests.TabIndex = 2;
            cmBxSpecialRequests.SelectedIndexChanged += cmBxSpecialRequests_SelectedIndexChanged;
            cmBxSpecialRequests.TextChanged += cmBxSpecialRequests_TextChanged;
            // 
            // lstBxEntreeSelection
            // 
            lstBxEntreeSelection.BackColor = Color.LemonChiffon;
            lstBxEntreeSelection.FormattingEnabled = true;
            lstBxEntreeSelection.ItemHeight = 20;
            lstBxEntreeSelection.Location = new Point(89, 139);
            lstBxEntreeSelection.Margin = new Padding(3, 4, 3, 4);
            lstBxEntreeSelection.Name = "lstBxEntreeSelection";
            lstBxEntreeSelection.Size = new Size(253, 124);
            lstBxEntreeSelection.TabIndex = 3;
            lstBxEntreeSelection.SelectedIndexChanged += lstBxEntreeSelection_SelectedIndexChanged;
            // 
            // lblEntreeSelection
            // 
            lblEntreeSelection.AutoSize = true;
            lblEntreeSelection.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEntreeSelection.Location = new Point(89, 89);
            lblEntreeSelection.Name = "lblEntreeSelection";
            lblEntreeSelection.Size = new Size(139, 23);
            lblEntreeSelection.TabIndex = 4;
            lblEntreeSelection.Text = "Entree Selection";
            // 
            // lblSpecialRequests
            // 
            lblSpecialRequests.AutoSize = true;
            lblSpecialRequests.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSpecialRequests.Location = new Point(88, 333);
            lblSpecialRequests.Name = "lblSpecialRequests";
            lblSpecialRequests.Size = new Size(143, 23);
            lblSpecialRequests.TabIndex = 5;
            lblSpecialRequests.Text = "Special Requests";
            // 
            // rbMilk
            // 
            rbMilk.AutoSize = true;
            rbMilk.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbMilk.Location = new Point(426, 179);
            rbMilk.Margin = new Padding(3, 4, 3, 4);
            rbMilk.Name = "rbMilk";
            rbMilk.Size = new Size(67, 27);
            rbMilk.TabIndex = 6;
            rbMilk.TabStop = true;
            rbMilk.Text = "Milk";
            rbMilk.UseVisualStyleBackColor = true;
            rbMilk.CheckedChanged += Drink_CheckedChanged;
            // 
            // rbJuice
            // 
            rbJuice.AutoSize = true;
            rbJuice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbJuice.Location = new Point(426, 240);
            rbJuice.Margin = new Padding(3, 4, 3, 4);
            rbJuice.Name = "rbJuice";
            rbJuice.Size = new Size(71, 27);
            rbJuice.TabIndex = 7;
            rbJuice.TabStop = true;
            rbJuice.Text = "Juice";
            rbJuice.UseVisualStyleBackColor = true;
            rbJuice.CheckedChanged += Drink_CheckedChanged;
            // 
            // rbSoda
            // 
            rbSoda.AutoSize = true;
            rbSoda.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbSoda.Location = new Point(426, 301);
            rbSoda.Margin = new Padding(3, 4, 3, 4);
            rbSoda.Name = "rbSoda";
            rbSoda.Size = new Size(71, 27);
            rbSoda.TabIndex = 8;
            rbSoda.TabStop = true;
            rbSoda.Text = "Soda";
            rbSoda.UseVisualStyleBackColor = true;
            rbSoda.CheckedChanged += Drink_CheckedChanged;
            // 
            // rbLemonade
            // 
            rbLemonade.AutoSize = true;
            rbLemonade.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbLemonade.Location = new Point(426, 363);
            rbLemonade.Margin = new Padding(3, 4, 3, 4);
            rbLemonade.Name = "rbLemonade";
            rbLemonade.Size = new Size(114, 27);
            rbLemonade.TabIndex = 9;
            rbLemonade.TabStop = true;
            rbLemonade.Text = "Lemonade";
            rbLemonade.UseVisualStyleBackColor = true;
            rbLemonade.CheckedChanged += Drink_CheckedChanged;
            // 
            // rbTea
            // 
            rbTea.AutoSize = true;
            rbTea.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbTea.Location = new Point(426, 424);
            rbTea.Margin = new Padding(3, 4, 3, 4);
            rbTea.Name = "rbTea";
            rbTea.Size = new Size(57, 27);
            rbTea.TabIndex = 10;
            rbTea.TabStop = true;
            rbTea.Text = "Tea";
            rbTea.UseVisualStyleBackColor = true;
            rbTea.CheckedChanged += Drink_CheckedChanged;
            // 
            // rbCoffee
            // 
            rbCoffee.AutoSize = true;
            rbCoffee.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbCoffee.Location = new Point(426, 485);
            rbCoffee.Margin = new Padding(3, 4, 3, 4);
            rbCoffee.Name = "rbCoffee";
            rbCoffee.Size = new Size(84, 27);
            rbCoffee.TabIndex = 11;
            rbCoffee.TabStop = true;
            rbCoffee.Text = "Coffee";
            rbCoffee.UseVisualStyleBackColor = true;
            rbCoffee.CheckedChanged += Drink_CheckedChanged;
            // 
            // grBxDrinkSelection
            // 
            grBxDrinkSelection.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            grBxDrinkSelection.Location = new Point(403, 89);
            grBxDrinkSelection.Margin = new Padding(3, 4, 3, 4);
            grBxDrinkSelection.Name = "grBxDrinkSelection";
            grBxDrinkSelection.Padding = new Padding(3, 4, 3, 4);
            grBxDrinkSelection.Size = new Size(202, 463);
            grBxDrinkSelection.TabIndex = 12;
            grBxDrinkSelection.TabStop = false;
            grBxDrinkSelection.Text = "Drink Selection";
            // 
            // OrderGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(914, 600);
            Controls.Add(rbCoffee);
            Controls.Add(rbTea);
            Controls.Add(rbLemonade);
            Controls.Add(rbSoda);
            Controls.Add(rbJuice);
            Controls.Add(rbMilk);
            Controls.Add(lblSpecialRequests);
            Controls.Add(lblEntreeSelection);
            Controls.Add(lstBxEntreeSelection);
            Controls.Add(cmBxSpecialRequests);
            Controls.Add(chBxWater);
            Controls.Add(menuStrip);
            Controls.Add(grBxDrinkSelection);
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrderGUI";
            Text = "Student Union - Diner by the Valley";
            Load += OrderGUI_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem placeOrderToolStripMenuItem;
        private ToolStripMenuItem clearOrderToolStripMenuItem;
        private ToolStripMenuItem displayOrderToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem entreeToolStripMenuItem;
        private ToolStripMenuItem drinksToolStripMenuItem;
        private ToolStripMenuItem specialRequestsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private CheckBox chBxWater;
        private ComboBox cmBxSpecialRequests;
        private ListBox lstBxEntreeSelection;
        private Label lblEntreeSelection;
        private Label lblSpecialRequests;
        private RadioButton rbMilk;
        private RadioButton rbJuice;
        private RadioButton rbSoda;
        private RadioButton rbLemonade;
        private RadioButton rbTea;
        private RadioButton rbCoffee;
        private GroupBox grBxDrinkSelection;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}