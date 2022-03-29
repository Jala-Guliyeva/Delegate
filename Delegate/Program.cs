using Delegate.Exceptions;
using Delegate.Models;
using System;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pharmacy pharmacy = new Pharmacy(4);
            Medicine medicine = new Medicine("spazmalqon",2,5);
            Medicine medicine1 = new Medicine("megaforte",8.7,3);
            Medicine medicine2 = new Medicine("noshpa", 1.5, 10);
            Medicine medicine3 = new Medicine("e vitamini", 3, 8);
            try
            {

                pharmacy.AddMedicine(medicine);
                pharmacy.AddMedicine(medicine1);
                pharmacy.AddMedicine(medicine2);
                pharmacy.AddMedicine(medicine3);

            }
            catch (MedicineAlreadyExistsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CapacityLimitException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }


            foreach (var item in pharmacy.GetAllMedicines())
            {
                item.ShowInfo();
            }
        }

    }
    
}
