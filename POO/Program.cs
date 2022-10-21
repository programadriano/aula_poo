// See https://aka.ms/new-console-template for more information


using POO.Entities;

var conta = new Conta("Sirius Black");
//conta.Depositar(1000);
conta.Sacar(1000);


Console.WriteLine($"A conta titular: {conta.Titular} numero: {conta.RetornarNumeroConta()} foi criada corretamente com o saldo: {conta.Saldo}");


var contaB = new Conta("Harry Potter");


Console.WriteLine($"A conta titular: {contaB.Titular} numero: {contaB.RetornarNumeroConta()} foi criada corretamente com o saldo: {contaB.Saldo}");


conta.Transferir(contaB, 600);

Console.WriteLine($"Depois da transferencia Sirius: {conta.Saldo}");
Console.WriteLine($"Depois da transferencia Harry: {contaB.Saldo}");



Console.ReadLine();