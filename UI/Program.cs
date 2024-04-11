using Data;
using Microsoft.Extensions.DependencyInjection;
using Services;
using UI;
using UI.Product_Forms;
using UI.Supplier_Forms;

namespace ProductSupplierTool
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            // Recuperando objeto de configuração dos serviços
            var serviceProvider = ConfigureServices();

            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }

        // Método de configuração dos serviços aplicando a injeção de dependência
        static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddDbContext<MyDbContext>(); // Adição do contexto da base de dados

            services.AddTransient<ProductRepository>(); // Registro de repositório
            services.AddTransient<ProductServices>();   // Registro de serviço

            services.AddTransient<SupplierRepository>();
            services.AddTransient<SupplierServices>();

            services.AddTransient<Main>(); // Registro de formulário Main
            
            services.AddTransient<SupplierAddForm>(); // Registro de formulário de criação do Supplier
            services.AddTransient<SupplierEditForm>(); // Registro de formulário de edição do Supplier
            services.AddTransient<SupplierDeleteForm>(); // Registro de formulário de deleção do Supplier

            services.AddTransient<ProductAddForm>(); // Registro de formulário de criação do Product
            services.AddTransient<ProductEditForm>(); // Registro de formulário de edição do Product
            services.AddTransient<ProductDeleteForm>(); // Registro de formulário de deleção do Product


            return services.BuildServiceProvider(); // Retornarndo o objeto de configuração dos serviços
        }
    }
}