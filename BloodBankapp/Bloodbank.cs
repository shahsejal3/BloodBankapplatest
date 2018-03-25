using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankapp
{
    static class Bloodbank
    {
        private static BloodBankModel db = new BloodBankModel();

        /// <summary>
        /// Creates BloodDonor profile
        /// </summary>
        /// <param name="Donorfirstname"></param>
        /// <param name="Donorlastname"></param>
        /// <param name="Donorgender"></param>
        /// <param name="Donorage"></param>
        /// <param name="groupType"></param>
        /// <param name="rHfactorType"></param>
        /// <param name="emailAddress"></param>
        /// <returns> New Blood Donor profile</returns>
        /// <exception cref="System.ArgumentNullException"/>
        ///<exception cref="System.NotImplementedException"/>

        public static BloodDonor CreateBloodDonor(string Donorfirstname,
        string Donorlastname, GenderType Donorgender,
        int Donorage, BloodGroupType groupType,
        RHfactorType rHfactorType,
        string emailAddress)
        {
            if (String.IsNullOrEmpty(Donorfirstname)
                || String.IsNullOrWhiteSpace(Donorfirstname))
             {
                throw new ArgumentNullException("Donorfirstname", "Donorfirstname cannot be Empty");

             }
            if (Donorage < 17)
            {
                throw new ArgumentOutOfRangeException("Donorage", "Sorry Minimum Donorage requirements in 17");
            }

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
           
                db.BloodDonors.Add(blooddonor);
                db.SaveChanges();
                return blooddonor;


        }


        public static IEnumerable<BloodDonor> GetBloodDonors()
        {
            return db.BloodDonors;
        }

        public static BloodDonor GetBloodDonorByDonorId(int? donorId)

        {
            var blooddonor = db.BloodDonors.Where(d => d.DonorId == donorId).FirstOrDefault();
            if (donorId == null)
                return null;
            return blooddonor;

        }

        public static void BloodDonation(int donorId)
        {

           
            var blooddonor = GetBloodDonorByDonorId(donorId);
            int BloodUnit = 0;
            blooddonor.BloodDonation(BloodUnit);
          

        }


        public static BloodDonor DisplayBloodDonorRecords(int donorId, int BloodUnit)
        {
            var blooddonor = GetBloodDonorByDonorId(donorId);
            blooddonor.BloodDonation(BloodUnit);
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

