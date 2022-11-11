// See https://aka.ms/new-console-template for more information


using POO.Entities;
using POO.Extensions;

var contaPF = new ContaPF();
contaPF.Depositar(1000);


var listaGenerica = new List<string>();
listaGenerica.Add("ss");



Console.WriteLine($"contaPF saldo: {contaPF.VerificaSaldoFuturo()}");

contaPF.Sacar(1500);
Console.WriteLine($"contaPF saldo depois do saque: {contaPF.VerificaSaldoFuturo()}");


var contaPJ = new ContaPJ();
contaPJ.Depositar(1000);


Console.WriteLine($"contaPJ saldo: {contaPJ.VerificaSaldoFuturo()}");
contaPJ.Sacar(1500);

Console.WriteLine($"contaPJ saldo depois do saque: {contaPJ.VerificaSaldoFuturo()}");



Console.ReadLine();