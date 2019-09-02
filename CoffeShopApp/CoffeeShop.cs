using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShopApp
{
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }
        int i = 0;

        List<string> customerName = new List<string>();
        List<string> contactNo = new List<string>();
        List<string> address = new List<string>();
        List<string> order = new List<string>();
        List<int> total = new List<int>();
        List<int> Quantity = new List<int>();
        int Black = 120, Cold = 100, Hot = 95, Regular = 80;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            customerName.Add(CustomertextBox.Text);
            contactNo.Add (contactTextBox.Text);
            address.Add( addressTextBox.Text);
            order.Add(orderComboBox.Text);
            Quantity.Add ( Convert.ToInt32(quantityTextBox.Text));
            total.Add(i);

            if (orderComboBox.Text=="Black")
            {
                total[i] = Convert.ToInt32(quantityTextBox.Text)* Black;
            }
            else if (orderComboBox.Text == "Cold")
            {
                total[i] = Convert.ToInt32(quantityTextBox.Text) * Cold;
            }
            else if (orderComboBox.Text == "Hot")
            {
                total[i] = Convert.ToInt32(quantityTextBox.Text) * Hot;
            }
            else if (orderComboBox.Text == "Regular")
            {
                total[i] = Convert.ToInt32(quantityTextBox.Text) * Regular;
            }
            i++;
            string message = "";
            for (int i=0; i <Quantity.Count; i++)
            {
                if (Quantity[i] != 0)
                {
                    if (Quantity[i] != 0)
                        message = message



                + "-------------------------------------------------------------------------------------------------------------------------------\n"
                + "\t\t\tCustomer Information"  +"  " + i + "\n"

                + "-------------------------------------------------------------------------------------------------------------------------------"
                + "\n\n\t\tCustomer name  :  " + customerName[i] + "\n\n\t\tContact NO  :  " + contactNo[i] + "\n\n\t\tCustomer Address  :  " + address
                [i] + "\n"
              + "\n\n\t\t\t  Order Details\n" +

          "\n\n\t\tOrder  :  " + order[i] + "\n\n\t\tQuantity  :  " + Quantity[i] + "\n\n\t\tTotal Price  :  " + total[i] + " BDT\n\n";
                }
              
            }
            richTextBox.Text = message;
        }
    }
}
