// See https://aka.ms/new-console-template for more information
using Models;

List<Carro> listCarros = new List<Carro>();

Console.WriteLine("Informe o Valor do Estacionameto para Carro:");
decimal valorEstacionamentoCarro = decimal.Parse(Console.ReadLine());
Console.WriteLine("Informe o Valor da Hora para Carro:");
decimal porHoraEstacionamentoCarro = decimal.Parse(Console.ReadLine());

Console.WriteLine("Informe o Valor do Estacionameto para Moto:");
decimal valorEstacionamentoMoto = decimal.Parse(Console.ReadLine());
Console.WriteLine("Informe o Valor da Hora para Moto:");
decimal porHoraEstacionamentoMoto = decimal.Parse(Console.ReadLine());


Boolean op = true;

do{
  Console.WriteLine("Escolhar a Opção: \n1- Cadastrar Veiculo"
  +"\n2- Romover Veiculo. \n3-Listar Veiculos. \n4-Encerrar");
string opcao = Console.ReadLine();

  switch(opcao){
    case "1":
      Carro carro =new Carro();
      Console.WriteLine("Informe a Placa: ");
      carro.placa = Console.ReadLine().ToUpper();
      Console.WriteLine("Carro ou Moto");
      carro.tipo = Console.ReadLine().ToUpper();
     listCarros.Add(carro);
    break;
    case "2":
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
    break;
    case "3":
      Console.WriteLine("Lista de Veiculos");
      foreach(Carro c in listCarros){
        Console.WriteLine($"Palca {c.placa}, tipo de veiculo {c.tipo} " );
      }
    break;
    case "4":
      op = false;
      Console.WriteLine("Até logo!");
    break;
    default:
    Console.WriteLine("Opção Invalida");
    break;
  }

}while(op);