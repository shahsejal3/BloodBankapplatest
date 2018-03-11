using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankapp
{
    enum BloodGroupType
    {
        O,
        A,
        B,
        AB
    }
    enum RHfactorType
    {
        positive,
        negative

    }
    enum GenderType
    {
        Male,
        Female

    }

    
    /// <summary>
    /// this represent a blooddonor profile
    /// </summary>
    class BloodDonor
    {

        private static int lastdonorID =100;
        
        #region Properties

        public int DonorId { get; private set; }

        public string DonorName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int DonorAge { get; set; }

        public DateTime LastBloodDonate { get; set; }

        public GenderType TypeofGender { get; set; }

        public int DonorBloodRecord { get; private set; }

        public DateTime RegisteredDate { get;  private set; }

        public BloodGroupType BloodGroup { get; set; }

        public RHfactorType RHFactor { get; set; }

        public string EmailAddress { get; set; }

        #endregion

        #region consturcter
        public BloodDonor()
        {
            DonorId = ++lastdonorID;
            RegisteredDate =DateTime.UtcNow;
        }
        #endregion

        #region Methods


        public int BloodDonation(int Unit)

        {
            DonorBloodRecord += Unit;
            return DonorBloodRecord;
        }
        #endregion



    }
}
