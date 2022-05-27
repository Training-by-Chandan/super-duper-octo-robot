using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Models;
using WindowsFormsApp.Repository;
using WindowsFormsApp.Services;
using WindowsFormsApp.Viewmodel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private CategoryServices categoryServices = new CategoryServices();
        private InventoryServices inventoryServices = new InventoryServices();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCategory();
        }

        private void LoadData()
        {
            grdInventory.DataSource = inventoryServices.GetAll();
            grdInventory.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var obj = new InventoryCreateEditViewModel()
            {
                Name = txtName.Text,
                CategoryId = Convert.ToInt32(cmbCategory.SelectedValue),
                DateOfPurchase = Convert.ToDateTime(dtPurchase.Text),
                Description = rtDesc.Text,
                Price = Convert.ToDouble(txtPrice.Text),
                Stock = Convert.ToDouble(txtStock.Text)
            };

            var res = inventoryServices.Create(obj);
            if (res.Item1)
            {
                //show the message
                LoadData();
                ResetTextField();
            }
            else
            {
                MessageBox.Show(res.Item2);
            }
        }

        private void ResetTextField()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            rtDesc.Clear();
            dtPurchase.ResetText();
            if (cmbCategory.Items.Count > 0)
            {
                cmbCategory.SelectedIndex = 0;
            }

            btnCreate.Visible = true;
            btnReset.Visible = true;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTextField();
        }

        private void LoadCategory()
        {
            var list = categoryServices.GetCategoryDropDowns();
            list.Insert(0, new CategoryDDViewModel() { Id = 0, Name = "Select Category" });
            cmbCategory.DataSource = new BindingSource(list, null);
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
        }

        private void grdInventory_SelectionChanged(object sender, EventArgs e)
        {
            var rows = grdInventory.SelectedRows;
            if (rows == null || rows.Count == 0)
            {
                ResetTextField();

                btnCreate.Visible = true;
                btnReset.Visible = true;
                btnEdit.Visible = false;
                btnDelete.Visible = false;

                return;
            }
            else
            {
                var selectedRow = rows[0];
                lblId.Text = selectedRow.Cells["Id"].Value.ToString();
                txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
                txtStock.Text = selectedRow.Cells["Stock"].Value.ToString();
                rtDesc.Text = selectedRow.Cells["Description"].Value == null ? "" : selectedRow.Cells["Description"].Value.ToString();
                cmbCategory.SelectedValue = selectedRow.Cells["CategoryId"].Value == null ? 0 : selectedRow.Cells["CategoryId"].Value;
                dtPurchase.Text = selectedRow.Cells["DateOfPurchase"].Value.ToString();

                btnCreate.Visible = !true;
                btnReset.Visible = !true;
                btnEdit.Visible = !false;
                btnDelete.Visible = !false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var res = inventoryServices.Delete(Convert.ToInt32(lblId.Text));
            if (res.Item1)
            {
                //show the message
                LoadData();
                ResetTextField();
            }
            else
            {
                MessageBox.Show(res.Item2);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var obj = new InventoryCreateEditViewModel()
            {
                Id = Convert.ToInt32(lblId.Text),
                Name = txtName.Text,
                CategoryId = Convert.ToInt32(cmbCategory.SelectedValue),
                DateOfPurchase = Convert.ToDateTime(dtPurchase.Text),
                Description = rtDesc.Text,
                Price = Convert.ToDouble(txtPrice.Text),
                Stock = Convert.ToDouble(txtStock.Text)
            };

            var res = inventoryServices.Edit(obj);
            if (res.Item1)
            {
                //show the message
                LoadData();
                ResetTextField();
            }
            else
            {
                MessageBox.Show(res.Item2);
            }
        }
    }
}