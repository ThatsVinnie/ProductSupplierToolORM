using Domain;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System.Configuration;
using System.Data;

namespace Data
{
    public class SupplierRepository
    {
        private readonly MyDbContext _context;

        public SupplierRepository(MyDbContext context)
        {
            _context = context;
        }

        // Método para recuperar a connection string com o banco MYSQL
        private static string GetConnectionString()
        {
            string connectionString = ConfigurationManager.AppSettings["MySqlConnection"];
            return connectionString;
        }

        // Método para preencher ComboBox na View
        public static List<Supplier> FillComboBox()
        {
            using (var connect = new MySqlConnection(GetConnectionString()))
            {
                string query = "SELECT * FROM supplier";
                var command = new MySqlCommand(query, connect);

                var suppliersList = new List<Supplier>(); // Declaração de lista com suppliers

                try
                {
                    connect.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    // Leitura do valores no banco
                    while (reader.Read())
                    {
                        var supplier = new Supplier();
                        supplier.Id = Convert.ToInt32(reader["id"]);
                        supplier.Name = reader["_name"].ToString();

                        suppliersList.Add(supplier); // Adição dos objetos na lista de retorno
                    }
                    return suppliersList;
                }
                catch
                {
                    return suppliersList; // Em caso de exceção, retorna a lista vazia
                }
                finally
                {
                    connect.Close(); // Fechando a conexão com o banco de dados
                }
            }
        }

        // Método para validar duplicidade de CNPJ no sistema
        public static bool ValidateSupplierCnpj(string cnpj)
        {
            using(var connect = new MySqlConnection(GetConnectionString()))
            {
                string query = "SELECT COUNT(*) FROM supplier WHERE cnpj=@cnpj";
                
                var command = new MySqlCommand(query, connect);

                command.Parameters.AddWithValue("@cnpj", cnpj);

                try
                {
                    connect.Open();
                    
                    int equalCnpj = Convert.ToInt32(command.ExecuteScalar());

                    if(equalCnpj > 0)
                    {
                        return true;
                    }
                    return false;
                }
                catch
                {
                    return true;
                }
                finally
                {
                    connect.Close();
                }
            }
        }




        // Métodos CRUD
        public static bool Create(Supplier supplier)
        {

            using (var connect = new MySqlConnection(GetConnectionString()))
            {
                string query = "INSERT INTO supplier (_name, cnpj, email) VALUES (@name, @cnpj, @mail)";
                var command = new MySqlCommand(query, connect);

                command.Parameters.AddWithValue("@name", supplier.Name);
                command.Parameters.AddWithValue("@cnpj", supplier.Cnpj);
                command.Parameters.AddWithValue("@mail", supplier.Email);

                try
                {
                    connect.Open();
                    
                    command.ExecuteNonQuery(); // Executando a inserção no banco de dados

                    return true;
                }
                catch (MySqlException ex)
                {
                    return false; // Indicando falha na operação
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public static DataTable Read()
        {
            using (var connect = new MySqlConnection(GetConnectionString()))
            {
                string query = "SELECT * FROM supplier";
                var command = new MySqlCommand(query, connect);
                var adapter = new MySqlDataAdapter(command);
                var dataTable = new DataTable();

                try
                {
                    connect.Open();

                    adapter.Fill(dataTable); // Preenchendo o DataTable com os dados do banco de dados

                    return dataTable;

                }catch (MySqlException ex)
                {
                    return null; // Em caso de exceção, retorna null
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public static bool Update(Supplier supplier, int idSupplier)
        {
            using(var connect = new MySqlConnection(GetConnectionString()))
            {
                string query = "UPDATE supplier SET _name=@name, cnpj=@cnpj, email=@mail WHERE id=@idSupplier";
                var command = new MySqlCommand(query, connect);

                command.Parameters.AddWithValue("@name", supplier.Name);
                command.Parameters.AddWithValue("@cnpj", supplier.Cnpj);
                command.Parameters.AddWithValue("@mail", supplier.Email);
                command.Parameters.AddWithValue("@idSupplier", idSupplier);

                try
                {
                    connect.Open();

                    command.ExecuteNonQuery(); // Executando a atualização no banco de dados

                    return true;
                }
                catch
                {
                    return false;
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public static bool Delete(int idSupplier)
        {
            using (var connect = new MySqlConnection(GetConnectionString()))
            {
                try
                {
                    connect.Open();
                    
                    string productsQuery = "SELECT COUNT(*) FROM product WHERE id_supplier=@idSupplier"; // Consulta para verificar a existência de registros associados ao fornecedor
                    
                    var productsCommand = new MySqlCommand(productsQuery, connect);

                    productsCommand.Parameters.AddWithValue("@idSupplier", idSupplier);

                    int productsCount = Convert.ToInt32(productsCommand.ExecuteScalar());  // Recuperação da qtde dos possíveis registros associados

                    if(productsCount > 0)
                    {
                        return false; // Se houver produtos associados a este fornecedor, não pode ser excluído
                    }
                    else
                    {
                        string deleteQuery = "DELETE FROM supplier WHERE id=@idSupplier";

                        var deleteCommand = new MySqlCommand(deleteQuery, connect);

                        deleteCommand.Parameters.AddWithValue("@idSupplier", idSupplier);

                        deleteCommand.ExecuteNonQuery();

                        return true;
                    }
                }
                catch
                {
                    return false;
                }
                finally
                {
                    connect.Close();
                }
            }
        }
    }
}
