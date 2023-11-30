using System.Globalization; 
namespace DesafioFundamentos.Models
    
{
    public class Estacionamento
    {
        private decimal PrecoInicial = 0;
        private decimal PrecoPorHora = 0;
        private List<string> Veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine().ToUpper();

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

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
           // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            
            string placa = Console.ReadLine().ToUpper(); 
            // Verifica se o veículo existe
            if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                
               

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = int.Parse(Console.ReadLine()); ;
                decimal valorTotal = PrecoInicial + PrecoPorHora * horas; ;


                Veiculos.Remove(placa); 

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (Veiculos.Count != 0)
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach(string veiculo in Veiculos)
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
