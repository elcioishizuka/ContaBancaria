using System;

namespace conta_bancaria
{
    public class ContaBanco
    {
        // Atributos
        // public string numConta{get; set;}
        // private string tipo{get; set;}
        // protected string dono{get; set;}
        // protected double saldo{get; set;}
        // protected string status{get; set;}

        public int numConta;
        protected string tipo;
        private string dono;
        private double saldo;
        private bool status;

        // Método construtor
        public ContaBanco()
        {
            saldo = 0;
            status = false;
        }
        
        // Getters
        public int getNumConta()
        {
            return this.numConta;
        }
        public string getTipo()
        {
            return this.tipo;            
        }
        public string getDono()
        {
            return this.dono;            
        }
        public double getSaldo()
        {
            return this.saldo;            
        }
        public bool getStatus()
        {
            return this.status;
        }
               
        // Setters
        public void setNumConta(int _numConta)
        {
            this.numConta = _numConta;
        }
        public void setTipo(string _tipo)
        {
            this.tipo = _tipo;
        }
        public void setDono(string _dono)
        {
            this.dono = _dono;
        }
        public void setSaldo(double _saldo)
        {
            this.saldo = _saldo;
        }
        public void setStatus(bool _status)
        {
            this.status = _status;
        }


        // Metodos
        public void abrirConta(string _dono, string _tipo)
        {

            if (this.status != true)
            {
                setDono(_dono);
                setStatus(true);
                setTipo(_tipo);
                if (_tipo == "CP")
                {
                    setSaldo(150);
                }
                else if (_tipo == "CC")
                {
                    setSaldo(50);
                }
                else
                {
                    throw new InvalidOperationException("Escolha um tipo de conta correta (CC ou CP) !!\n");
                }
                System.Console.WriteLine("Conta aberta com sucesso\n");
            }
            else
            {
                throw new InvalidOperationException("Conta já aberta\n");
            }
        }
        
        public void fecharConta()
        {
            if (getSaldo() > 0)
            {
                System.Console.WriteLine("Falha em fechar conta. Dinheiro em conta.\n");
            }
            else if (getSaldo() < 0)
            {
                System.Console.WriteLine(("Falha em fechar conta. Conta em débito\n"));
            }
            else
            {
                System.Console.WriteLine(("Sucesso em fechar conta\n"));
                setDono(null);
                setNumConta(0);
                setStatus(false);
                setTipo(null);
            }
        }
        public void depositar(double valor)
        {
            if (getStatus() == true)
            {
                System.Console.WriteLine($"Depósito de R$ {valor},00 efetuado com sucesso!\n");
                setSaldo(getSaldo() + valor);
            }
            else
            {
                System.Console.WriteLine("Impossível depositar!\n");
            }
        }
        public void sacar(double valor)
        {
            if (getStatus() == true)
            {
                if (getSaldo() >= valor)
                {
                    setSaldo(getSaldo()-valor);
                    System.Console.WriteLine($"Saque de R$ {valor},00 efetuado com sucesso\n");
                }
                else
                {
                    System.Console.WriteLine("Saldo insuficiente\n");  
                }            
            }
            else
            {
                System.Console.WriteLine("Conta não está aberta\n");
            }
        }
        public void pagarMensal()
        {
            double mensalidade = 0;
            if (getTipo() == "CC")
            {
                mensalidade = 12;
            }
            else if (getTipo() == "CP")
            {
                mensalidade = 20;
            }
                        
            if (getStatus() == true)
            {
                if (getSaldo() >= mensalidade)
                {
                    setSaldo(getSaldo()-mensalidade);
                    System.Console.WriteLine("Pagamento efetuado com sucesso\n");
                }
                else
                {
                    System.Console.WriteLine("Saldo insuficiente\n");  
                }            
            }
            else
            {
                System.Console.WriteLine("Conta nao esta aberta\n");
            }                   
        }
        public void mostrarConta()
        {
            System.Console.WriteLine("-------------------------------------------------");
            System.Console.WriteLine($"Nome: \t\t\t{getDono()}");
            System.Console.WriteLine($"Número da conta: \t{getNumConta()}");
            System.Console.WriteLine($"Tipo: \t\t\t{getTipo()}");
            System.Console.WriteLine($"Saldo: \t\t\tR$ {getSaldo()}");
            System.Console.WriteLine($"Status: \t\t{getStatus()}");
            System.Console.WriteLine("-------------------------------------------------\n");
        }
    }
}