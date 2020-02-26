using System;

namespace BIM313_HW2_16489165246
{
    class AcademicPersonel : Personel
    {
        
        
        public override double CalculateSalary(Enum maritalStatus, int numOfChildren, int step, int degree)
        { 
            double salaryfactorAcademic = SalaryFactor;
            if (MaritalStatus.Married.Equals(maritalStatus))
            {
                salaryfactorAcademic = salaryfactorAcademic + 1 ;
            }

            if (numOfChildren == 1)
            {
                salaryfactorAcademic = salaryfactorAcademic + 1;
            }
            else if (numOfChildren > 1 )
            {
                salaryfactorAcademic = salaryfactorAcademic + (numOfChildren * 0.75);
            }

            if (AcademicPersonelForm.sendAIC > 0)
            {
                salaryfactorAcademic = salaryfactorAcademic + (0.65 * AcademicPersonelForm.sendAIC);
            }

            double academicSalary = ((BaseSalary * salaryfactorAcademic)+ (step * 10) + (degree * 15));


            return academicSalary;

        }

    }
}