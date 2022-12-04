using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunPro3dataset
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbTeacherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveData();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
            // TODO: This line of code loads data into the 'dbDataSet.tbCountry' table. You can move, or remove it, as needed.
            this.tbCountryTableAdapter.Fill(this.dbDataSet.tbCountry);
            // TODO: This line of code loads data into the 'dbDataSet.tbTeacher' table. You can move, or remove it, as needed.
            this.tbTeacherTableAdapter.Fill(this.dbDataSet.tbTeacher);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        //Save data in case of changes
        private void SaveData()
        {
            try
            {
                if (this.Validate())
                {
                    this.tbTeacherBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dbDataSet);
                    MessageBox.Show("Saved!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Navigation buttons
        private void first_btn_Click(object sender, EventArgs e)
        {
            tbTeacherBindingSource.MoveFirst();
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            tbTeacherBindingSource.MovePrevious();

        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            tbTeacherBindingSource.MoveNext();

        }

        private void last_btn_Click(object sender, EventArgs e)
        {
            tbTeacherBindingSource.MoveLast();

        }
        private void EnableDisableButtons()
        {
            if (tbTeacherBindingSource.Position == 0)
            {
                first_btn.Enabled = false;
                prev_btn.Enabled = false;
            }
            else
            {
                first_btn.Enabled = true;
                prev_btn.Enabled = true;
            }
            if (tbTeacherBindingSource.Position == tbTeacherBindingSource.Count - 1)
            {
                next_btn.Enabled = false;
                last_btn.Enabled = false;
            }
            else
            {
                next_btn.Enabled = true;
                last_btn.Enabled = true;
            }
        }

        private void tbTeacherBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            EnableDisableButtons();
        }

        private void filter_tbx_TextChanged(object sender, EventArgs e)
        {
            tbTeacherBindingSource.Filter = $"lastName LIKE ('%{filter_tbx.Text}%')";
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Validate())
            {
                this.tbTeacherBindingSource.EndEdit();
                if (dbDataSet.HasChanges())
                {

                    if (MessageBox.Show("Do you want to save the changes?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SaveData();
                    }
                }

            }
            else 
                e.Cancel = true;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void DeleteItem()
        {
            if (tbTeacherBindingSource.Count == 0)
            {
                MessageBox.Show("No more records");
            }
            else
            {
                var userResponse = MessageBox.Show("Are u sure to delete?", "Delete", MessageBoxButtons.YesNo);
                if (userResponse == DialogResult.Yes)
                {
                    tbTeacherBindingSource.RemoveCurrent();
                }
            }
        }


        //CRUD
        private void add_btn_Click(object sender, EventArgs e)
        {
            var selectedCountry = ((DataRowView) newCountryid_combx.SelectedItem).Row;

            dbDataSet.tbTeacher.AddtbTeacherRow(newFirstName_tbx.Text, newLastName_tbx.Text, newDob_dt.Value, newPhone_tbx.Text, (int)newGrade_numupdwn.Value, newisActive_checbx.Checked,(dbDataSet.tbCountryRow)selectedCountry);
            newFirstName_tbx.Text = "";
            newLastName_tbx.Text = "";
            newPhone_tbx.Text = "";
        }

        //validation
        private void dobDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if (newDob_dt.Value.AddYears(18) > DateTime.Now)
            {
                MessageBox.Show("Be at least 18 y.o.");
                e.Cancel = true;
            }
        }

        private void newLastName_tbx_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(newLastName_tbx.Text))
            {
                MessageBox.Show("Last Name can't be empty, please fill it");
                e.Cancel = true;
            }
        }

        private void newFirstName_tbx_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(newFirstName_tbx.Text))
            {
                MessageBox.Show("First name can't be empty, please fill it");
                e.Cancel = true;

            }
        }

       

        private void newPhone_tbx_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(newPhone_tbx.Text))
            {
                MessageBox.Show("Phone number can't be empty, please fill it");
                e.Cancel = true;
            }
        }

       
    }
}
