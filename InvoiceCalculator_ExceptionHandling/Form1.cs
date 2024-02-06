namespace InvoiceCalculator_ExceptionHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal subTotal = Convert.ToDecimal(txtSubTotal.Text);

                decimal discount = 0.10m;

                decimal discountAmount = subTotal * discount;
                decimal total = subTotal - discountAmount;
                total *= 1000000000000000000000000000000000000000m;
                txtDiscountAmount.Text = discountAmount.ToString();
                txtTotal.Text = total.ToString();
            } catch
            {
                MessageBox.Show("Please enter a valid decimal number in the SubTotal text box.", "Format Exception");
                txtSubTotal.Text = "";
                txtDiscountAmount.Text = "";
                txtTotal.Text = "";
            }

            txtSubTotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}