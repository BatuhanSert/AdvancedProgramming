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
    public partial class AcademicPersonelForm : Form
    {
        public static int sendAIC = 0; 
        public AcademicPersonelForm()
        {
            InitializeComponent();
        }

        private void btn_CalculateSalary_Click(object sender, EventArgs e)
        {
            try
            {
                sendAIC = Convert.ToInt32(txt_AIC.Text);
            }
            catch 
            {
                string text = "Please, enter a valid number in Text Boxes";
                MessageBox.Show(text);
                System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
                Application.Exit(); //to turn off current app

            }

            AcademicPersonel academic = new AcademicPersonel();
            lbl_PersonalType.Text = academic.PersonelGroup();
            MaritalStatus marital = (MaritalStatus)Enum.Parse(typeof(MaritalStatus), PersonelForm.sendMaritalStatus);//String to ENUM
            lbl_Salary.Text = academic.CalculateSalary( marital, PersonelForm.sendNumOfChildren,
                PersonelForm.sendStep, PersonelForm.sendDegree).ToString();

        }

        private void AcademicPersonelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
