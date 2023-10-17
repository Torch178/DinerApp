namespace DinerApp
{
    public partial class OrderGUI : Form
    {
        private Order newOrder;
        public OrderGUI()
        {
            InitializeComponent();
        }

        //Instantiate an object of the Order Class when form first loads
        private void OrderGUI_Load(object sender, EventArgs e)
        {
            newOrder = new Order();
            for (int i = 0; i < newOrder.menuEntree.Length; i++)
            {
                lstBxEntreeSelection.Items.Add(newOrder.menuEntree[i]);

            }
        }

        private void lstBxEntreeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            newOrder.Entree = lstBxEntreeSelection.Text;
        }

        private void cmBxSpecialRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            newOrder.SpecialRequest = cmBxSpecialRequests.Text;
        }

        private void cmBxSpecialRequests_TextChanged(object sender, EventArgs e)
        {
            newOrder.SpecialRequest = cmBxSpecialRequests.Text;
        }

        private void chBxWater_CheckedChanged(object sender, EventArgs e)
        {
            if (chBxWater.Checked)
            {
                newOrder.WaterSelection = true;
            }
            else
            {
                newOrder.WaterSelection = false;
            }
        }

        private void Drink_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTea.Checked)
            {
                newOrder.DrinkSelection = rbTea.Text;
            }
            else if (rbCoffee.Checked)
            {
                newOrder.DrinkSelection = rbCoffee.Text;
            }
            else if (rbMilk.Checked)
            {
                newOrder.DrinkSelection = rbMilk.Text;
            }
            else if (rbJuice.Checked)
            {
                newOrder.DrinkSelection = rbJuice.Text;
            }
            else if (rbSoda.Checked)
            {
                newOrder.DrinkSelection = rbSoda.Text;
            }
            else if (rbLemonade.Checked)
            {
                newOrder.DrinkSelection = rbLemonade.Text;
            }
        }

        private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(newOrder.Entree + "\n" +
                newOrder.SpecialRequest + "\n" +
                newOrder.DrinkSelection + "\n" +
                newOrder.GetWaterSelection() + "\n\n\n" +
                //will show total because of ToString() Override
                newOrder + "\n" +
                "Placed Order");
        }

        private void displayOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(newOrder.Entree + "\n" +
               newOrder.SpecialRequest + "\n" +
               newOrder.DrinkSelection + "\n" +
               newOrder.GetWaterSelection() + "\n" +
               "Current Order");
        }

        private void entreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select a new Entree");
            newOrder.Entree = "";
            lstBxEntreeSelection.ClearSelected();
        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select a new Drink");
            newOrder.DrinkSelection = "";
            ClearDrinks();
        }

        private void ClearDrinks()
        {
            rbMilk.Checked = false;
            rbJuice.Checked = false;
            rbSoda.Checked = false;
            rbLemonade.Checked = false;
            rbTea.Checked = false;
            rbCoffee.Checked = false;
        }

        private void specialRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Special Request Cleared.");
            newOrder.SpecialRequest = "";
            //simulates clearing by resetting to blank index
            cmBxSpecialRequests.Text = "";
            cmBxSpecialRequests.SelectedIndex = -1;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Student Union - Diner by the Valley" +
                "\n\n\nVersion 1.0");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstBxEntreeSelection.ClearSelected();
            chBxWater.Checked = false;
            cmBxSpecialRequests.SelectedIndex = -1;
            ClearDrinks();
            newOrder.DrinkSelection = "";
            newOrder.Entree = "";
            newOrder.SpecialRequest = "";
            newOrder.WaterSelection = false;
        }
    }
}