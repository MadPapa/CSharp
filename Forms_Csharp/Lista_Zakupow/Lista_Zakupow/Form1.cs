using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Zakupow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void updateInput()
        {
            add_product.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (add_product.Text == "")
                MessageBox.Show("Pusta wartosc", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else 
            { 
                if(shopping_list.Items.Contains(add_product.Text))
                {
                    DialogResult result = MessageBox.Show("Produkt jest już na liście czy mimo to chcesz go dodać?", "Inforamtion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        shopping_list.Items.Add(add_product.Text);
                        updateInput();
                    }
                    else
                    {
                        updateInput();
                        return;
                    }
                }
                else
                {
                    shopping_list.Items.Add(add_product.Text);
                    updateInput();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int item = shopping_list.SelectedIndex;
            if (item == -1)
            {
                MessageBox.Show("Nie wybrano żadnego elementu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                shopping_list.Items.RemoveAt(item);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć wszystkie elementy z listy zakupów", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                shopping_list.Items.Clear();
            else
                return;
        }

    }
}
