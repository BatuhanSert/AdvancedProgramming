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
    public partial class PersonelForm : Form
    {
        public static string sendPersonelType = "";
        public static string sendMaritalStatus = "";
        public static int sendNumOfChildren = 0;
        public static int sendStep = 0;
        public static int sendDegree = 0;
        


        public PersonelForm()
        {
            InitializeComponent();
        }

        private void PersonelForm_Load(object sender, EventArgs e)
        {

            comboBox_PersonalType.Items.Add("Academic Person");
            comboBox_PersonalType.Items.Add("AdministrativePersonel Person");
            comboBox_PersonalType.SelectedItem = "Academic Person";
            comboBox_Marital.Items.Add(MaritalStatus.Single);
            comboBox_Marital.Items.Add(MaritalStatus.Married);
            comboBox_Marital.SelectedItem = MaritalStatus.Single;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            /*Entry Control*/
            try
            {
                sendPersonelType = comboBox_PersonalType.SelectedItem.ToString();
                sendMaritalStatus = comboBox_Marital.SelectedItem.ToString();
                sendNumOfChildren = Convert.ToInt32(txt_NumberChildren.Text);
                sendStep = Convert.ToInt32(txt_Step.Text);
                sendDegree = Convert.ToInt32(txt_Degree.Text);
            }
            catch
            {
                string text = "Please, enter a valid number in Text Boxes";
                MessageBox.Show(text);
                System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
                Application.Exit(); //to turn off current app
            }
            /*************************************************************************************************************/

            if (comboBox_PersonalType.SelectedItem == "Academic Person")
            {
                AcademicPersonelForm academic = new AcademicPersonelForm();
                academic.ShowDialog();

            }
            else
            {
                AdministrativePersonelForm administrative = new AdministrativePersonelForm();
                administrative.ShowDialog();
            }






        }
    }
}
