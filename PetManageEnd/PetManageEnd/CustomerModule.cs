﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetManageEnd
{
    public partial class CustomerModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DbConnect dbcon = new DbConnect();
        string title = "Pet Shop Management System";

        bool check = false;
        Customer cus;
        public CustomerModule(Customer form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            cus = form;
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CheckField();
                if (check)
                {
                    if (MessageBox.Show("Are you sure you want to register this customer?", "Customer Registation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("INSERT INTO tbCus(name, address, phone)VALUES(@name, @address, @phone)", cn);
                        cm.Parameters.AddWithValue("@name", txtName.Text);
                        cm.Parameters.AddWithValue("@address", txtAddress.Text);
                        cm.Parameters.AddWithValue("@phone", txtPhone.Text);

                        cn.Open();
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Customer has been successfully registed!", title);
                        Clear();
                        cus.LoadCustomer();
                    }
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                CheckField();
                if (check)
                {
                    if (MessageBox.Show("Are you sure you want to edit this customer?", "Record Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("UPDATE tbCus SET name = @name, address = @address, phone = @phone WHERE id = @id", cn);
                        cm.Parameters.AddWithValue("@id", lblCid.Text);
                        cm.Parameters.AddWithValue("@name", txtName.Text);
                        cm.Parameters.AddWithValue("@address", txtAddress.Text);
                        cm.Parameters.AddWithValue("@phone", txtPhone.Text);

                        cn.Open();
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Customer has been successfully updated!", title);
                        Clear();
                        cus.LoadCustomer();
                    }
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #region Method
        public void CheckField()
        {
            if (txtName.Text == "" | txtAddress.Text == "" | txtPhone.Text == "")
            {
                MessageBox.Show("Required date field", "Warning");
                return;
            }
            check = true;
        }

        public void Clear()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }
        #endregion Methos
    }
}
