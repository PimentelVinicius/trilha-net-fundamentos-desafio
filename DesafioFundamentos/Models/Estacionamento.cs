using System.Text.RegularExpressions;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        string regexMascara = @"^([A-Z]{3}-\d{4}|[A-Z]{3}\d[A-Z]\d{2})$";
        string mensagemPlacaInvalida = "Placa inválida. Por favor, siga o padrão brasileiro de placas de veículos.";
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
                        
            Console.Write("Digite a placa do veículo para estacionar: ");
            
            string veiculoPlaca = Console.ReadLine();
            if (Regex.IsMatch(veiculoPlaca, regexMascara))
            {
                veiculos.Add(veiculoPlaca);
            }
            else
            {
                Console.WriteLine(mensagemPlacaInvalida);
            }
           
            

        }

        public void RemoverVeiculo()
        {
            Console.Write("Digite a placa do veículo para remover: ");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
           
            string placa = Console.ReadLine();

            if (Regex.IsMatch(placa, regexMascara))
            {
                // Verifica se o veículo existe
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                    // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                    // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                  



                    int horas = Convert.ToInt32(Console.ReadLine());
                    decimal valorTotal = (horas * precoPorHora) + precoInicial;

                    // TODO: Remover a placa digitada da lista de veículos
                  
                    veiculos.Remove(placa);
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
            }
            else
            {
                Console.WriteLine(mensagemPlacaInvalida);
            }

            
           
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo.ToString());
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
