

namespace Models
{
  public class Carro
    {
        public string placa { get; set; }
        public string tipo { get; set; }

        private List<Carro> listCarros = new List<Carro>();

    

    public void CadastrarVeiculo()
    {
      Carro carro =new Carro();
      Console.WriteLine("Informe a Placa: ");
      carro.placa = Console.ReadLine().ToUpper();
      Console.WriteLine("Carro ou Moto");
      carro.tipo = Console.ReadLine().ToUpper();
     listCarros.Add(carro);
    }
    public void RemoverVeiculo(decimal valorEstacionamentoCarro, decimal valorEstacionamentoMoto, decimal porHoraEstacionamentoCarro, decimal porHoraEstacionamentoMoto){
         Console.WriteLine("Informe a Placa");
      string placa = Console.ReadLine().ToUpper();
      Carro carroRemover = listCarros.Find(x => x.placa == placa);
      Console.WriteLine("Informe o tempo que o veiculo passou no estacionamento!");
      int tempo = int.Parse(Console.ReadLine());
      if(carroRemover.tipo.Equals("MOTO")){
        decimal valor = valorEstacionamentoMoto + tempo * porHoraEstacionamentoMoto;
        Console.WriteLine($"O valor a ser Pago {carroRemover.placa} é R$:{valor}");
      }else{
        decimal valor = valorEstacionamentoCarro + tempo * porHoraEstacionamentoCarro;
        Console.WriteLine($"O valor a ser Pago {carroRemover.placa} é R$:{valor}");
      }
      listCarros.Remove(carroRemover);
    }

    public void ListarVeiculos(){
      Console.WriteLine("Lista de Veiculos");
      foreach(Carro c in listCarros){
        Console.WriteLine($"Palca {c.placa}, tipo de veiculo {c.tipo} " );
      }
    }
    }    

}