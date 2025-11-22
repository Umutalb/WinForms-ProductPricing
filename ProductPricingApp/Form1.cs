namespace ProductPricingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Product
        {
            public string Name;
            public int Quantity;
            public decimal UnitPrice;

            public decimal Total
            {
                get
                {
                    return Quantity * UnitPrice;
                }
            }

            public override string ToString()
            {
                return $"Product: {Name} | Quantity: {Quantity} | Unit Price: {UnitPrice} | Total: {Total}";
            }
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = txt_name.Text;
            product.Quantity = Convert.ToInt32(txt_quantity.Text);
            product.UnitPrice = Convert.ToDecimal(txt_unitPrice.Text);

            listBox1.Items.Add(product);
        }
    }
}
