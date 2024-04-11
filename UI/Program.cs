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

            // Recuperando objeto de configura��o dos servi�os
            var serviceProvider = ConfigureServices();

            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }

        // M�todo de configura��o dos servi�os aplicando a inje��o de depend�ncia
        static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddDbContext<MyDbContext>(); // Adi��o do contexto da base de dados

            services.AddTransient<ProductRepository>(); // Registro de reposit�rio
            services.AddTransient<ProductServices>();   // Registro de servi�o

            services.AddTransient<SupplierRepository>();
            services.AddTransient<SupplierServices>();

            services.AddTransient<Main>(); // Registro de formul�rio Main
            
            services.AddTransient<SupplierAddForm>(); // Registro de formul�rio de cria��o do Supplier
            services.AddTransient<SupplierEditForm>(); // Registro de formul�rio de edi��o do Supplier
            services.AddTransient<SupplierDeleteForm>(); // Registro de formul�rio de dele��o do Supplier

            services.AddTransient<ProductAddForm>(); // Registro de formul�rio de cria��o do Product
            services.AddTransient<ProductEditForm>(); // Registro de formul�rio de edi��o do Product
            services.AddTransient<ProductDeleteForm>(); // Registro de formul�rio de dele��o do Product


            return services.BuildServiceProvider(); // Retornarndo o objeto de configura��o dos servi�os
        }
    }
}