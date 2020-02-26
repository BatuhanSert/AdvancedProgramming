using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIM313_HW2_16489165246
{
    public partial class AdministrativePersonelForm : Form
    {
        public static Boolean sendAdminDuty = false;
        public AdministrativePersonelForm()
        {
            InitializeComponent();
        }

        private void btn_CalculateSalary_Click(object sender, EventArgs e)
        {
            sendAdminDuty = checkBox_AdminDuty.Checked;
            AdministrativePersonel administrativePersonel = new AdministrativePersonel();
            lbl_PersonalType.Text = administrativePersonel.PersonelGroup();
            MaritalStatus marital = (MaritalStatus)Enum.Parse(typeof(MaritalStatus), PersonelForm.sendMaritalStatus);//String to ENUM
            lbl_Salary.Text = administrativePersonel.CalculateSalary(marital, PersonelForm.sendNumOfChildren,
                PersonelForm.sendStep, PersonelForm.sendDegree).ToString();

        }

        private void AdministrativePersonelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
