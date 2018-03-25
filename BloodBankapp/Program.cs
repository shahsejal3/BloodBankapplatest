using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Donate Blood and Save Lives!");
            Console.WriteLine("***************************");
            while (true)
            {
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Register New Donor");
                Console.WriteLine("2.BloodDonation");
                Console.WriteLine("3.Print DonorRecords");

                Console.Write("Please Select an Option:-");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you for Visting!");
                        return;
                    case "1":
                        Console.Write("FirstName:-");
                        var Donorfirstname = Console.ReadLine();
                        Console.Write("LastName:-");
                        var Donorlastname = Console.ReadLine();
                        var genderTypes = Enum.GetNames(typeof(GenderType));
                        for (int i = 0; i < genderTypes.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}.{genderTypes[i]}");
                        }
                        Console.Write("Please Select a Gender:-");
                        var genderType = Convert.ToInt32(Console.ReadLine());
                        
                        
                        Console.Write("Age:-");
                        var Donorage = Convert.ToInt32(Console.ReadLine());
                        var bloodGrouptypes = Enum.GetNames(typeof(BloodGroupType));
                        for (int i = 0; i < bloodGrouptypes.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}.{bloodGrouptypes[i]}");
                        }
                        Console.Write("Please Select a BloodGroup:-");
                        var bloodGrouptype = Convert.ToInt32(Console.ReadLine());
                        var rhFactortypes = Enum.GetNames(typeof(RHfactorType));
                        for (int i = 0; i < rhFactortypes.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}.{rhFactortypes[i]}");
                        }
                        Console.Write("please Select a RhFactor:-");
                        var rhFactortype = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Email Address:-");
                        var emailAddress = Console.ReadLine();
                        try
                        {
                           
                            var blooddonor = Bloodbank.CreateBloodDonor(Donorfirstname, Donorlastname, (GenderType)(genderType - 1), Donorage, (BloodGroupType)(bloodGrouptype - 1), (RHfactorType)(rhFactortype - 1), emailAddress);
                            Console.WriteLine($"DonorID:{blooddonor.DonorId},FirstName:{blooddonor.DonorFirstName},LastName:{blooddonor.DonorLastName}," +
                                $"Gender:{blooddonor.TypeofGender},Age:{blooddonor.DonorAge},BloodGroup:{blooddonor.BloodGroup}," +
                                $"RHFactor:{blooddonor.RHFactor},EmailAddress:{blooddonor.EmailAddress}");
                        }
                        catch(ArgumentNullException ax)
                        {
                            Console.WriteLine($"Opps!{ax.Message}");
                        }
                        catch(ArgumentOutOfRangeException ax)
                        {
                            Console.WriteLine($"Sorry!{ax.Message}");
                        }
                        finally
                        {
                            //cleanup
                        }
                        break;

                    case "2":
                        PrintDonorRecords();
                        Console.Write("Please Enter DonorID:-");
                        var donorId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Blood Donation in Unit:-");
                        var Bloodunit = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            var Bdonor = Bloodbank.DisplayBloodDonorRecords(donorId, Bloodunit);
                            Console.WriteLine($"DonorID:{Bdonor.DonorId},FirstName:{Bdonor.DonorFirstName},LastName:{Bdonor.DonorLastName}," +
                                $"Gender:{Bdonor.TypeofGender},Age:{Bdonor.DonorAge},BloodGroup:{Bdonor.BloodGroup}," +
                                $"RHFactor:{Bdonor.RHFactor},EmailAddress:{Bdonor.EmailAddress},Total BloodUnit:{Bdonor.BloodUnit}");
                        }
                        catch(NotImplementedException)
                        {
                            Console.WriteLine("");
                        }
                        finally
                        {
                            //Cleanup
                        }
                        

                        break;
                    case "3":
                        PrintDonorRecords();
                        break;
                    default:
                        break;

                }
            }
        }

        private static void PrintDonorRecords()
        {
            var blooddonors = Bloodbank.GetBloodDonors();
            foreach (var bloodDonor in blooddonors)
            {
                Console.WriteLine($"DonorID:{bloodDonor.DonorId},FirstName:{bloodDonor.DonorFirstName},LastName:{bloodDonor.DonorLastName}," +
                $"Gender:{bloodDonor.TypeofGender},Age:{bloodDonor.DonorAge},BloodGroup:{bloodDonor.BloodGroup}," +
                $"RHFactor:{bloodDonor.RHFactor},EmailAddress:{bloodDonor.EmailAddress}");
            }
        }
    }
}
