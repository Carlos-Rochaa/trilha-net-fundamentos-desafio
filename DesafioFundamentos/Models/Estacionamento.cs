using System.Globalization;
using System.Text.RegularExpressions;
namespace DesafioFundamentos.Models

{
    public class Estacionamento
    {
        public decimal PrecoInicial { get; private set; }
        public decimal PrecoPorHora { get; private set; }
        private List<string> Veiculos { get; set; } = new List<string>();

        public Estacionamento() { }

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine();
            Console.Write("Digite a placa do veículo para estacionar (Modelo Mercosul XXX0X00): ");
            string placa = Console.ReadLine().ToUpper();
            string padraoPlaca = "^[A-Za-z]{3}[0-9]{1}[A-Za-z]{1}[0-9]{2}$";

            if (Regex.IsMatch(placa, padraoPlaca))
            {

                if (!Veiculos.Contains(placa))
                {
                    Veiculos.Add(placa);
                    Console.WriteLine("Veículo adicionado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Esse veículo já existe na lista.");
                }
            }
            else
            {
                Console.WriteLine("O padrão de placa digitado não atende ao esperado. Tente novamente.");
            }

        }

        public void RemoverVeiculo()
        {

            Console.WriteLine("Veículos disponíveis para remoção ");
            ListarVeiculos();
            Console.WriteLine();
            Console.Write("Digite a placa do veículo para remover (Modelo Mercosul XXX0X00): ");
           
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*

            string placa = Console.ReadLine().ToUpper();
            string padraoPlaca = "^[A-Za-z]{3}[0-9]{1}[A-Za-z]{1}[0-9]{2}$";
            // Verifica se o veículo existe
            if (Regex.IsMatch(placa, padraoPlaca))
            {
                if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    Console.WriteLine();
                    Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");

                    

                    // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                    // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                    // *IMPLEMENTE AQUI*
                    try
                    {
                        int horas = int.Parse(Console.ReadLine());
                       while (horas <= 0)
                        {
                            Console.WriteLine("A quantidade de horas deve ser superior a 0!");
                            Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                            horas = int.Parse(Console.ReadLine()); 
                        }

                        decimal valorTotal = PrecoInicial + PrecoPorHora * horas;
                        


                        Veiculos.Remove(placa);

                        // TODO: Remover a placa digitada da lista de veículos
                        // *IMPLEMENTE AQUI*

                        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Entrada inválida para horas, digite um valor válido por favor.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Entrada inválida para horas, o número que você digitou excede o formato.");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Ocorreu um erro inesperado: " + e.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
            }
            else { Console.WriteLine("O padrão de placa digitado não atende ao esperado. Tente novamente.d "); }
            Console.WriteLine();
        }

        public void ListarVeiculos()
        {
            Console.WriteLine();
            // Verifica se há veículos no estacionamento
            if (Veiculos.Count != 0)
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string veiculo in Veiculos)
                {
                    Console.WriteLine(veiculo.ToUpper());
                }
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
