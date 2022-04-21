using BLL;
using DTO;
using GUI.UserComponents;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormPOS : Form
    {
        public FormPOS()
        {
            InitializeComponent();
            LoadProductItems();
        }

        private void LoadProductItems()
        {
            var lstProductItem = SanPham_BLL.GetAllSanPham();
            foreach (var item in lstProductItem)
            {
                var itemComponent = new ItemProductControl(item, panelProducts);
                ItemProductControl_Click(itemComponent.Controls, item);
                panelProducts.Controls.Add(itemComponent);
            }
        }

        private void ItemProductControl_Click(Control.ControlCollection controlCollection, tb_SanPham product)
        {
            // If already have this product in the cart, increase the product quantity
            foreach (Control control in controlCollection)
            {
                control.Click += (o, e) =>
                  {
                      if (IsExistInCart(product))
                      {
                          IncreaseQuantity(product);
                      }
                      else
                      {
                          AddItemCart(product);
                      }
                  };

                if (control.HasChildren)
                {
                    ItemProductControl_Click(control.Controls, product);
                }
            }
        }

        private void AddItemCart(tb_SanPham product)
        {
            ItemCartControl itemCart = new ItemCartControl(product)
            {
                Parent = panelCart,
                Width = panelCart.Width - 25
            };
            panelCart.Controls.Add(itemCart);
        }

        private void IncreaseQuantity(tb_SanPham product)
        {
            foreach (ItemCartControl item in panelCart.Controls)
            {
                if (item.Product.MaSanPham.Equals(product.MaSanPham))
                {
                    item.BtnIncrease_Click(null, null);
                }
            }
        }

        private bool IsExistInCart(tb_SanPham productAdd)
        {
            foreach (ItemCartControl item in panelCart.Controls)
            {
                if (item.Product.MaSanPham.Equals(productAdd.MaSanPham))
                {
                    return true;
                }
            }
            return false;
        }

        private void FormPOS_Resize(object sender, EventArgs e)
        {
            foreach (Control item in panelCart.Controls)
            {
                item.Width = item.Parent.Width - 25;
            }
        }
    }
}