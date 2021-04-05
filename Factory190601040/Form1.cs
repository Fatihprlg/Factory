using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
        /************************MÜCAHİT FATİH PARLAĞI************************
         ******************************190601040******************************
         **************************BIL201 VİZE ÖDEVİ**************************/
namespace Factory190601040
{
    public partial class Form1 : Form
    {
        Factory Factory = new Factory("Fatih Yazılım", "Seyrek");
        public Form1()
        {
            InitializeComponent();
        }


        #region EVENTS
        private void addPerson_Click(object sender, EventArgs e)
        {

            try
            {
                if (TextBoxControl())
                {
                    if (TCKControl())
                    {
                        Identity identity = new Identity(Convert.ToInt64(tcTxt.Text), nameTxt.Text, surnameTxt.Text);
                        Staff staff = new Staff(identity, Convert.ToInt32(idTxt.Text), departTxt.Text);

                        Factory.Recruit(staff);
                        MessageBox.Show(staff.identity.name + " kişisi başarıyla eklendi!");
                        ClearTexts();
                    }
                    else
                        MessageBox.Show("Geçerli bir TCKNo giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Boş alan bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        private void listPerson_Click(object sender, EventArgs e)
        {
            try
            {
                staffList.Items.Clear();
                foreach (Staff person in Factory.staffs)
                {
                    ListViewItem staffItem = new ListViewItem();
                    staffItem.Text = person.staffNo.ToString();
                    staffItem.SubItems.Add(person.identity.name);
                    staffItem.SubItems.Add(person.identity.surname);
                    staffItem.SubItems.Add(person.depart);
                    staffItem.SubItems.Add(person.identity.tckNo.ToString());
                    staffList.Items.Add(staffItem);
                }
                staffList.Update();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void subtractPerson_Click(object sender, EventArgs e)
        {
            try
            {
                Factory.Fire(staffList.SelectedItems[0].Index);
                listPerson_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void staffList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!subtractPerson.Enabled)
                subtractPerson.Enabled = true;
        }
        #endregion


        #region OTHER_FUNCTIONS
        bool TextBoxControl()
        {
            if (string.IsNullOrEmpty(idTxt.Text) || string.IsNullOrEmpty(tcTxt.Text) || string.IsNullOrEmpty(nameTxt.Text) || string.IsNullOrEmpty(surnameTxt.Text) || string.IsNullOrEmpty(departTxt.Text))
                return false;
            else
                return true;
        }
        void ClearTexts()
        {
            idTxt.Text = string.Empty;
            tcTxt.Text = string.Empty;
            nameTxt.Text = string.Empty;
            surnameTxt.Text = string.Empty;
            departTxt.Text = string.Empty;
        }

        bool TCKControl()
        {
            if (tcTxt.Text.Length == 11 && Convert.ToInt64(tcTxt.Text) > 10000000000) return true;
            else return false;
        }
        #endregion


    }
}
