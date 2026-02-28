using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Food_Ordering_Application
{
    partial class RadLarge   // <-- Fixed class name
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disnamespace Food_Ordering_Application
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
                    msg += cposing)
        {
                        if (disposing && (components != null))
                        {
                            components.Dispose();
                        }
                        base.Dispose(disposing);
                    }

        #region Windows Form Designer generated code

        private void InitializeComponent()
            {
                lblheading = new Label();
                lblcategory = new Label();
                cmbcategory = new ComboBox();
                lblitems = new Label();
                lstitems = new ListBox();

                grpSize = new GroupBox();   // <-- FIXED (was: Size)
                chklarge = new RadioButton();
                radmed = new RadioButton();
                radsamall = new RadioButton();

                grpextras = new GroupBox();
                chkketchup = new CheckBox();
                chkchesse = new CheckBox();
                chkquantity = new Label();
                numquant = new NumericUpDown();
                btnsubmit = new Button();
                lblmessage = new Label();

                grpSize.SuspendLayout();     // <-- FIXED
                grpextras.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)numquant).BeginInit();
                SuspendLayout();

                // lblheading
                lblheading.BackColor = SystemColors.Highlight;
                lblheading.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                lblheading.Location = new Point(59, 51);
                lblheading.Name = "lblheading";
                lblheading.Size = new Size(1027, 69);
                lblheading.TabIndex = 0;
                lblheading.Text = "Food Ordering Form";
                lblheading.TextAlign = ContentAlignment.MiddleCenter;

                // lblcategory
                lblcategory.AutoSize = true;
                lblcategory.BackColor = SystemColors.ControlLightLight;
                lblcategory.Location = new Point(59, 150);
                lblcategory.Name = "lblcategory";
                lblcategory.Size = new Size(135, 25);
                lblcategory.TabIndex = 1;
                lblcategory.Text = "Select Category";

                // cmbcategory
                cmbcategory.FormattingEnabled = true;
                cmbcategory.Items.AddRange(new object[] { "Burger ", "Pizza ", "Sandwich ", "Drinks" });
                cmbcategory.Location = new Point(59, 187);
                cmbcategory.Name = "cmbcategory";
                cmbcategory.Size = new Size(182, 33);
                cmbcategory.TabIndex = 2;
                cmbcategory.SelectedIndexChanged += cmbcategory_SelectedIndexChanged;

                // lblitems
                lblitems.AutoSize = true;
                lblitems.BackColor = SystemColors.ControlLightLight;
                lblitems.Location = new Point(59, 237);
                lblitems.Name = "lblitems";
                lblitems.Size = new Size(120, 25);
                lblitems.TabIndex = 3;
                lblitems.Text = "Choose items";

                // lstitems
                lstitems.FormattingEnabled = true;
                lstitems.ItemHeight = 25;
                lstitems.Location = new Point(59, 284);
                lstitems.Name = "lstitems";
                lstitems.Size = new Size(265, 254);
                lstitems.TabIndex = 4;

                // grpSize  (FIXED)
                grpSize.Controls.Add(chklarge);
                grpSize.Controls.Add(radmed);
                grpSize.Controls.Add(radsamall);
                grpSize.Location = new Point(387, 150);
                grpSize.Name = "grpSize";
                grpSize.Size = new Size(342, 89);
                grpSize.TabIndex = 5;
                grpSize.TabStop = false;
                grpSize.Text = "Size";
                grpSize.Enter += Size_Enter;

                // chklarge
                chklarge.AutoSize = true;
                chklarge.Location = new Point(256, 41);
                chklarge.Name = "chklarge";
                chklarge.Size = new Size(80, 29);
                chklarge.TabIndex = 2;
                chklarge.TabStop = true;
                chklarge.Text = "Large";
                chklarge.UseVisualStyleBackColor = true;

                // radmed
                radmed.AutoSize = true;
                radmed.Location = new Point(137, 41);
                radmed.Name = "radmed";
                radmed.Size = new Size(103, 29);
                radmed.TabIndex = 1;
                radmed.TabStop = true;
                radmed.Text = "Medium";
                radmed.UseVisualStyleBackColor = true;

                // radsamall
                radsamall.AutoSize = true;
                radsamall.Location = new Point(36, 41);
                radsamall.Name = "radsamall";
                radsamall.Size = new Size(85, 29);
                radsamall.TabIndex = 0;
                radsamall.TabStop = true;
                radsamall.Text = "Small ";
                radsamall.UseVisualStyleBackColor = true;

                // grpextras
                grpextras.Controls.Add(chkketchup);
                grpextras.Controls.Add(chkchesse);
                grpextras.Location = new Point(387, 263);
                grpextras.Name = "grpextras";
                grpextras.Size = new Size(342, 78);
                grpextras.TabIndex = 6;
                grpextras.TabStop = false;
                grpextras.Text = "Extras";

                // chkketchup
                chkketchup.AutoSize = true;
                chkketchup.Location = new Point(207, 38);
                chkketchup.Name = "chkketchup";
                chkketchup.Size = new Size(102, 29);
                chkketchup.TabIndex = 1;
                chkketchup.Text = "Ketchup";

                // chkchesse
                chkchesse.AutoSize = true;
                chkchesse.Location = new Point(46, 38);
                chkchesse.Name = "chkchesse";
                chkchesse.Size = new Size(94, 29);
                chkchesse.TabIndex = 0;
                chkchesse.Text = "Cheese";

                // chkquantity
                chkquantity.AutoSize = true;
                chkquantity.BackColor = SystemColors.ControlLightLight;
                chkquantity.Location = new Point(387, 378);
                chkquantity.Name = "chkquantity";
                chkquantity.Size = new Size(80, 25);
                chkquantity.TabIndex = 7;
                chkquantity.Text = "Quantity";

                // numquant
                numquant.Location = new Point(496, 378);
                numquant.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
                numquant.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
                numquant.Name = "numquant";
                numquant.Size = new Size(180, 31);
                numquant.TabIndex = 8;
                numquant.Value = new decimal(new int[] { 1, 0, 0, 0 });

                // btnsubmit
                btnsubmit.BackColor = SystemColors.Highlight;
                btnsubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                btnsubmit.Location = new Point(346, 489);
                btnsubmit.Name = "btnsubmit";
                btnsubmit.Size = new Size(383, 49);
                btnsubmit.TabIndex = 9;
                btnsubmit.Text = "Submit";
                btnsubmit.Click += btnsubmit_Click;

                // lblmessage
                lblmessage.BackColor = Color.WhiteSmoke;
                lblmessage.BorderStyle = BorderStyle.FixedSingle;
                lblmessage.Location = new Point(766, 145);
                lblmessage.Name = "lblmessage";
                lblmessage.Size = new Size(320, 393);
                lblmessage.TabIndex = 10;

                // RadLarge  (FIXED)
                AutoScaleDimensions = new SizeF(10F, 25F);
                AutoScaleMode = AutoScaleMode.Font;
                ClientSize = new Size(1242, 652);
                Controls.Add(lblmessage);
                Controls.Add(btnsubmit);
                Controls.Add(numquant);
                Controls.Add(chkquantity);
                Controls.Add(grpextras);
                Controls.Add(grpSize);     // <-- FIXED
                Controls.Add(lstitems);
                Controls.Add(lblitems);
                Controls.Add(cmbcategory);
                Controls.Add(lblcategory);
                Controls.Add(lblheading);
                Name = "RadLarge";          // <-- FIXED
                Text = "Size";
                Load += RadLarge_Load;

                grpSize.ResumeLayout(false);
                grpSize.PerformLayout();
                grpextras.ResumeLayout(false);
                grpextras.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)numquant).EndInit();
                ResumeLayout(false);
                PerformLayout();
            }

            #endregion

            private Label lblheading;
            private Label lblcategory;
            private ComboBox cmbcategory;
            private Label lblitems;
            private ListBox lstitems;

            private GroupBox grpSize;  // <-- FIXED
            private RadioButton chklarge;
            private RadioButton radmed;
            private RadioButton radsamall;

            private GroupBox grpextras;
            private CheckBox chkketchup;
            private CheckBox chkchesse;
            private Label chkquantity;
            private NumericUpDown numquant;
            private Button btnsubmit;
            private Label lblmessage;
        }
    }
}