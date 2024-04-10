using Data;
using Domain;
using System.Data;

namespace Services
{
    public class SupplierServices
    {
        private readonly SupplierRepository _supplierRepository;

        public SupplierServices(SupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }
        
        // Serviços para recuperar o sucesso ou falha nos métodos CRUD
        public bool AddSupplier(string _name, string _cnpj, string _mail)
        {
            var supplier = new Supplier
            {
                Name = _name,
                Cnpj = _cnpj,
                Email = _mail
            };

            if (_supplierRepository.Create(supplier))
            {
                return true;
            }

            return false;
        }

        public List<Supplier> DisplaySuppliers()
        {
            return _supplierRepository.Read();
        }

        public bool UpdateSupplier(string _name, string _cnpj, string _mail, int _idSupplier)
        {
            var newSupplier = new Supplier
            {
                Name = _name,
                Cnpj = _cnpj,
                Email = _mail
            };

            if (_supplierRepository.Update(newSupplier, _idSupplier))
            {
                return true;
            }
            return false;
        }

        public bool DeleteSupplier(int _idSupplier)
        {
            if (_supplierRepository.Delete(_idSupplier))
            {
                return true;
            }
            return false;
        }

        public bool ValidateSupplierCnpj(string _cnpj)
        {
            if (_supplierRepository.ValidateSupplierCnpj(_cnpj))
            {
                return true;
            }
            return false;
        }
    }
}
