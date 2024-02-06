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
            decimal subTotal = Convert.ToDecimal(txtSubTotal.Text);

            decimal discount = 0.10m;

            decimal discountAmount = subTotal * discount;
            decimal total = subTotal - discountAmount;

            txtDiscountAmount.Text = discountAmount.ToString();
            txtTotal.Text = total.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}