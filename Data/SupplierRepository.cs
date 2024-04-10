using Domain;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace Data
{
    public class SupplierRepository
    {
        private readonly MyDbContext _context;

        public SupplierRepository(MyDbContext context)
        {
            _context = context;
        }


        // Método para validar duplicidade de CNPJ no sistema
        public bool ValidateSupplierCnpj(string cnpj)
        {
            var equalCnpj = _context.Suppliers.Any(s => s.Cnpj == cnpj); // Método para retornar true/false se houver cnpj já cadastrado

            return equalCnpj;
        }


        // Métodos CRUD
        public bool Create(Supplier supplier)
        {
            try
            {
                _context.Suppliers.Add(supplier); // Adicionando um novo objeto à lista de inserção
                
                _context.SaveChanges(); // Fazendo operação na base de dados

                return true;
            }
            catch(DbUpdateException ex)
            {
                return false;
            }
        }
            
        public List<Supplier> Read()
        {
            try
            {
                var supplierList = _context.Suppliers.ToList(); // Recuperando uma lista de fornecedores

                return supplierList; // Retornando essa lista para a view do usuário
            }
            catch (DbException ex)
            {
                return null;
            }
        } // Método para recuperar todos os registros ou preencher ComboBox na View

        public bool Update(Supplier supplier, int idSupplier)
        {
            var supplierToUpdate = _context.Suppliers.Find(idSupplier); // Método para obtenção do Fornecedor a ser atualizado

            if(supplierToUpdate != null)
            {
                supplierToUpdate.Name = supplier.Name;
                supplierToUpdate.Cnpj = supplier.Cnpj;
                supplierToUpdate.Email = supplier.Email;

                try
                {
                    _context.SaveChanges();
                    return true;

                }catch(DbUpdateException ex)
                {
                    // exceção de retorno
                    return false;
                }
            }

            return false;
        }

        public bool Delete(int idSupplier)
        {
            var supplierToDelete = _context.Suppliers.Find(idSupplier);

            if (supplierToDelete != null)
            {
                _context.Remove(supplierToDelete); // Removendo fornecedor selecionado

                try
                {
                    _context.SaveChanges();

                    return true;

                }catch(DbUpdateException ex)
                {
                    return false;
                }
            }
            return false;
        }
    }
}
