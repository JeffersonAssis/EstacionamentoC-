// See https://aka.ms/new-console-template for more information
using Models;

Carro carro = new Carro();

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
     carro.CadastrarVeiculo();
    break;
    case "2":
      carro.RemoverVeiculo(valorEstacionamentoCarro,valorEstacionamentoMoto,porHoraEstacionamentoCarro,porHoraEstacionamentoMoto);
    break;
    case "3":
      carro.ListarVeiculos();
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