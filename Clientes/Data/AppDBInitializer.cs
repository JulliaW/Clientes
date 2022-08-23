using Clientes.Models;

namespace Clientes.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppCont>();
                context.Database.EnsureCreated();

                if(!context.Clientes.Any())
                {
                    context.Clientes.AddRange(new List<Cliente>()
                    {
                        new Cliente()
                        {
                            Nome = "Jullia",
                            Telefone = "(16)99999-9999",
                            Email = "jullia@weber.com.br",
                            Logradouro = "Rua da Subida",
                            Numero = "120",
                            Bairro = "Pq dos Perdidos",
                            Cidade = "Ribeirão Preto",
                            Estado = "SP",
                            Complemento = ""
                        },

                        new Cliente()
                        {
                            Nome = "Paulo",
                            Telefone = "(16)99999-9999",
                            Email = "paulo@oliveira.com.br",
                            Logradouro = "Rua da Subida",
                            Numero = "120",
                            Bairro = "Pq dos Perdidos",
                            Cidade = "Ribeirão Preto",
                            Estado = "SP",
                            Complemento = ""
                        },

                        new Cliente()
                        {
                            Nome = "Fernado",
                            Telefone = "(16)99999-9999",
                            Email = "fernado@amalinux.com.br",
                            Logradouro = "Rua do windows",
                            Numero = "876",
                            Bairro = "Jd dos MacOS",
                            Cidade = "Ribeirão Preto",
                            Estado = "SP",
                            Complemento = "Apt. 23"
                        },

                        new Cliente()
                        {
                            Nome = "Gustavo",
                            Telefone = "(16)99999-9999",
                            Email = "gus@tavo.com.br",
                            Logradouro = "Rua C#",
                            Numero = "",
                            Bairro = "Vila das Andorinhas",
                            Cidade = "São Sebastião do Paraíso",
                            Estado = "MG",
                            Complemento = "Casa sem número"
                        },

                        new Cliente()
                        {
                            Nome = "Leonardo",
                            Telefone = "(16)99999-9999",
                            Email = "leo@chinabelo.com.br",
                            Logradouro = "Rua do japones",
                            Numero = "789",
                            Bairro = "Pq dos Canudos",
                            Cidade = "Cravinhos",
                            Estado = "SP",
                            Complemento = ""
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
