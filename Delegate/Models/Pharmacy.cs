using Delegate.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate.Models
{
    internal class Pharmacy
    {
        public int MedicineLimit { get; set; }

        private List<Medicine> _medicines;

        public Pharmacy(int medicinelimit)
        {
            MedicineLimit = medicinelimit;
            _medicines = new List<Medicine>();
        }
        public void AddMedicine(Medicine medicine)
        {

            if (_medicines.Count > MedicineLimit)
            {
                throw new CapacityLimitException("Limit doldu!");
                return;
            }

            foreach (var item in _medicines)
            {
                if (item == medicine)
                {
                    throw new MedicineAlreadyExistsException("Movcuddur!");
                    return;
                }
            }

            _medicines.Add(medicine);

        }

        
        public List<Medicine> GetAllMedicines()
        {
            List<Medicine> medicineCopy = new List<Medicine>();
            medicineCopy.AddRange(_medicines);

            return medicineCopy;
            
        }
        public List<Medicine> FilterMedicinesByPrice(double minPrice, double maxPrice)
        {
            return _medicines.FindAll(m => m.Price >= minPrice && m.Price <= maxPrice);


        }

        public Medicine GetMedicineById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("id null olmamalidi!");

            Medicine medicine = _medicines.Find(m => m.Id == id);
            if (medicine == null)
            {
                throw new NotFoundException("Bele birsey Yoxdur!");

            }
            return medicine;
        }
        public void DeleteMedicineById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("id null olmamalidi!");

            Medicine medicine = _medicines.Find(m => m.Id == id);
            if (medicine == null)
                throw new NotFoundException("bele derman yoxdur!");
            else
            {
                medicine.IsDeleted = true;
            }
            _medicines.IsDeleted(medicine);
         
        }
        public void EditMedicineEmail(int? id, string name)
        {
            if (id == null || string.IsNullOrWhiteSpace(name))
            {
                throw new NullReferenceException("id ve name null olmamalidi!");
                return;
            }
            Medicine medicine = _medicines.Find(m => m.Name == name && m.IsDeleted == false);
            if (medicine == null)
                throw new NotFoundException("bele bir sey yoxdur!");
            medicine.Name = name;
        }
    }
}