namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }


        public void AdicionarVeiculo()
        {
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string addCarro = Console.ReadLine();
            veiculos.Add(addCarro);

        }

        public void RemoverVeiculo()
        {
           string placa = "";
           
            Console.WriteLine("Digite a placa do veículo para remover:");
            placa = Console.ReadLine();
           

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
               int horas ;
               
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = Convert.ToInt32( Console.ReadLine());
                
                decimal valorTotal = 0; 
                valorTotal = (precoInicial + precoPorHora) * horas ;

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                 veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            
            if (veiculos.Any())
            {
                Console.WriteLine($"Os veículos estacionados são:");
                
            
            int contador = 0;
            foreach(string item in veiculos){
            Console.WriteLine($"{contador} - {item}");
            contador++;
            }
            
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
