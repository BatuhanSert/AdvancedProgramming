using System;

namespace BIM313_HW2_16489165246
{
    class AdministrativePersonel:Personel
    {
        public override double CalculateSalary(Enum maritalStatus, int numOfChildren, int step, int degree)
        {
            double salaryFactorAdmin = SalaryFactor;
            if (MaritalStatus.Married.Equals(maritalStatus))
            {
                salaryFactorAdmin = salaryFactorAdmin + 1;
            }

            if (numOfChildren == 1)
            {
                salaryFactorAdmin = salaryFactorAdmin + 1;
            }
            else if (numOfChildren > 1)
            {
                salaryFactorAdmin = salaryFactorAdmin + (numOfChildren * 0.75);
            }

            if (AdministrativePersonelForm.sendAdminDuty)
            {
                salaryFactorAdmin = salaryFactorAdmin + 1.5 ;
            }

            double adminSalary = ((BaseSalary * salaryFactorAdmin) + (step * 5) + (degree * 10));


            return adminSalary;

        }
    }
}