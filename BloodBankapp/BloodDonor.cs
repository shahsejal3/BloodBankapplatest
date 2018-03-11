using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankapp
{
    public enum BloodGroupType
    {
        O,
        A,
        B,
        AB
    }
    public enum RHfactorType
    {
        positive,
        negative

    }
    public enum GenderType
    {
        Male,
        Female

    }


    /// <summary>
    /// this represent a blooddonor profile
    /// </summary>
    public class BloodDonor
    {

        private static int lastdonorID = 1000;

        #region Properties
        public int DonorId { get; private set; }

        public string DonorFirstName { get; set; }

        public string DonorLastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int DonorAge { get; set; }

        public GenderType TypeofGender { get; set; }

        public int DonorBloodRecord { get; set; }

        public DateTime RegisteredDate { get; private set; }

        public int BloodUnit { get; private set; }

        public BloodGroupType BloodGroup { get; set; }

        public RHfactorType RHFactor { get; set; }

        public string EmailAddress { get; set; }

        #endregion

        #region consturcter
        public BloodDonor()
        {
            DonorId = ++lastdonorID;
            RegisteredDate = DateTime.UtcNow;
        }
        #endregion

        #region Methods


        public int BloodDonation(int BloodUnit)

        {
            DonorBloodRecord += BloodUnit;
            return DonorBloodRecord;
        }
        #endregion



    }
}
