using System;
using System.Security.Cryptography.X509Certificates;

namespace BIM313_HW2_16489165246
{
    abstract class Personel
    {
        public const double BaseSalary = 2000;
        public const double SalaryFactor = 10;


     
        public abstract double CalculateSalary(Enum maritalStatus, int numOfChildren, int step, int degree);

        public virtual string PersonelGroup()
        {

            return PersonelForm.sendPersonelType;
        }
    }
}