using System;

namespace conta_bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBanco cliente1 = new ContaBanco();
            cliente1.mostrarConta();
            
            // Criando conta para Jubileu
            cliente1.abrirConta("Jubileu", "CC");
            cliente1.setNumConta(1234);
            cliente1.mostrarConta();
            
            // Fechando conta com saldo na conta
            cliente1.fecharConta();
            
            // Depositando 100
            cliente1.depositar(100);
            cliente1.mostrarConta();
            
            // Sacando 150
            cliente1.sacar(150);
            cliente1.mostrarConta();

            // Sacando 300
            cliente1.sacar(300);
            cliente1.mostrarConta();
            
            // Fechando conta com saldo zero
            cliente1.fecharConta();
            cliente1.mostrarConta();
            
            ContaBanco cliente2 = new ContaBanco();
            
            // Criando conta para Creuza
            cliente2.abrirConta("Creuza", "CP");
            cliente2.setNumConta(4321);
            cliente2.mostrarConta();

        }
    }
}
