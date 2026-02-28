namespace Food_Ordering_Application
{
    public partial class radlarge : Form
    {
        public radlarge()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string msg = "";

            // Category
            msg = "Category : " + cmbcategory.Text + "\n";

            // Items
            msg += "Items : " + lstitems.SelectedItem + "\n";

            // Size
            msg += "Size : ";
            if (radsamall.Checked)
            {
                msg += radsamall.Text + "\n";
            }
            else if (radmed.Checked)
            {
                msg += radmed.Text + "\n";
            }
            else if (chklarge.Checked)
            {
                msg += chklarge.Text + "\n";
            }

            // Extras
            msg += "Extras : ";
            if (chkchesse.Checked)
            {
                msg += chkchesse.Text + " ";
            }
            if (chkketchup.Checked)
            {
                msg += chkketchup.Text;
            }

            msg += "\n";

            // Quantity
            msg += "Quantity : " + numquant.Value + "\n";

            // Final Output
            lblmessage.Text = msg;
        }

        private void cmbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstitems.Items.Clear();

            if (cmbcategory.SelectedIndex == 0)
            {
                lstitems.Items.Add("Classic Burger");
                lstitems.Items.Add("Cheese Burger");
                lstitems.Items.Add("Veggie Burger");
            }
            else if (cmbcategory.SelectedIndex == 1)
            {
                lstitems.Items.Add("Vegetarian Pizza");
                lstitems.Items.Add("Donor Pizza");
                lstitems.Items.Add("Malai Boti Pizza");
                lstitems.Items.Add("Fajita Pizza");
                lstitems.Items.Add("Tikka Boti Pizza");
            }
            else if (cmbcategory.SelectedIndex == 2)
            {
                lstitems.Items.Add("Club Sandwich");
                lstitems.Items.Add("Chicken Sandwich");
                lstitems.Items.Add("Turkish Sandwich");
                lstitems.Items.Add("Veggie Sandwich");
            }
            else if (cmbcategory.SelectedIndex == 3)
            {
                lstitems.Items.Add("Coca Cola");
                lstitems.Items.Add("Mint Margarita");
                lstitems.Items.Add("Fanta");
                lstitems.Items.Add("Orange Juice");
                lstitems.Items.Add("Coffee");
            }
        }
    }
}
