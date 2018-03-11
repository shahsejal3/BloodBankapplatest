using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankapp
{
    static class Bloodbank
    {
        private static List<BloodDonor> blooddonors = new List<BloodDonor>();


        public static BloodDonor CreateBloodDonor(string Donorfirstname,
        string Donorlastname, GenderType Donorgender,
        int Donorage, BloodGroupType groupType,
        RHfactorType rHfactorType,
        string emailAddress)
        {
            var blooddonor = new BloodDonor
            {
                DonorFirstName = Donorfirstname,
                DonorLastName = Donorlastname,
                TypeofGender = Donorgender,
                DonorAge = Donorage,
                BloodGroup = groupType,
                RHFactor = rHfactorType,
                EmailAddress = emailAddress


            };
            if (Donorage >= 18)
                blooddonors.Add(blooddonor);
            return blooddonor;


        }


        public static IEnumerable<BloodDonor> GetBloodDonors()
        {
            return blooddonors;
        }

        public static BloodDonor GetBloodDonorByDonorId(int? donorId)

        {
            var blooddonor = blooddonors.Where(d => d.DonorId == donorId).FirstOrDefault();
            if (donorId == null)
                return null;
            return blooddonor;

        }

        public static void BloodDonation(int donorId)
        {

            int BloodUnit = 0;
            var blooddonor = GetBloodDonorByDonorId(donorId);
            blooddonor.BloodDonation(BloodUnit);

        }


        public static BloodDonor GetBloodDonorRecords(int donorId, int BloodUnit)
        {
            var blooddonor = BloodDonation(donorId, BloodUnit);
            return DonorBloodRecords();

        }

        private static object BloodDonation(int donorId, int bloodUnit)
        {
            throw new NotImplementedException();
        }

        private static BloodDonor DonorBloodRecords()
        {
            throw new NotImplementedException();
        }

    }
}

