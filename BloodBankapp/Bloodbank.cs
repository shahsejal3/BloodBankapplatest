using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankapp
{
   static class Bloodbank
    {
        public static BloodDonor CreateBloodDonor(string Donorname,
            int Donorage, BloodGroupType groupType,
            RHfactorType rHfactorType, int Blooddonation)
        {
            var BloodDonor = new BloodDonor
            {
                DonorName = Donorname,
                DonorAge = Donorage,
                BloodGroup = groupType,
                RHFactor = rHfactorType,
             

            };
            if (Donorage > 18)
                BloodDonor.BloodDonation(Blooddonation);
            return BloodDonor;

        }

    }

}
