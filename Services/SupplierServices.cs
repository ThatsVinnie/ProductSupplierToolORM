using Domain;
using System.Data;

namespace Services
{
    public class SupplierServices
    {
        // Serviços para recuperar o sucesso ou falha nos métodos CRUD
        public static bool AddSupplier(string _name, string _cnpj, string _mail)
        {
            var supplier = new Supplier
            {
                Name = _name,
                Cnpj = _cnpj,
                Email = _mail
            };

            if (Data.SupplierRepository.Create(supplier))
            {
                return true;
            }

            return false;
        }

        public static DataTable DisplaySuppliers()
        {
            return Data.SupplierRepository.Read();
        }

        public static bool UpdateSupplier(string _name, string _cnpj, string _mail, int _idSupplier)
        {
            var newSupplier = new Supplier
            {
                Name = _name,
                Cnpj = _cnpj,
                Email = _mail
            };

            if (Data.SupplierRepository.Update(newSupplier, _idSupplier))
            {
                return true;
            }
            return false;
        }

        public static bool DeleteSupplier(int _idSupplier)
        {
            if (Data.SupplierRepository.Delete(_idSupplier))
            {
                return true;
            }
            return false;
        }

        public static List<Supplier> FillComboBoxSupplier()
        {
            return Data.SupplierRepository.FillComboBox();
        }

        public static bool ValidateSupplierCnpj(string _cnpj)
        {
            if (Data.SupplierRepository.ValidateSupplierCnpj(_cnpj))
            {
                return true;
            }
            return false;
        }
    }
}
