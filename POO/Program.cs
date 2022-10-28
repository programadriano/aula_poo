// See https://aka.ms/new-console-template for more information


using POO.Entities;



var contaPF = new ContaPF("Sirius Black");
contaPF.Depositar(1000);

var contaPJ = new ContaPJ("Harry Potter");
contaPJ.Depositar(1000);

//var cliente1 = new Cliente("Sirius Black", 50);
//cliente1.Conta.TipoDeConta = POO.Entities.Enums.TipoDeConta.ContaPJ;
//cliente1.Conta.Depositar(1000);

//Console.WriteLine($"A conta titular: {cliente1.Nome} tipo de conta {cliente1.Conta.TipoDeConta} numero: {cliente1.Conta.RetornarNumeroConta()} foi criada corretamente com o saldo: {cliente1.Conta.VerificaSaldoFuturo()}");

//var contaB = new Cliente("Harry Potter", 30);
//contaB.Conta.TipoDeConta = POO.Entities.Enums.TipoDeConta.ContaPF;

//Console.WriteLine($"A conta titular: {contaB.Nome} tipo de conta {contaB.Conta.TipoDeConta} numero: {contaB.Conta.RetornarNumeroConta()} foi criada corretamente com o saldo: {contaB.Conta.VerificaSaldoFuturo()}");


//cliente1.Conta.Transferir(contaB.Conta, 600);

//Console.WriteLine($"Depois da transferencia Sirius: {cliente1.Conta.VerificaSaldoFuturo()}");
//Console.WriteLine($"Depois da transferencia Harry: {contaB.Conta.VerificaSaldoFuturo()}");



Console.ReadLine();