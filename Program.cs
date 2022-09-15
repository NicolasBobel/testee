using System;
using System.Collections.Generic;


namespace testee
{
    class Listar
    {
        List<ClienteLista> clienteLista;

        public Listar()
        {
            clienteLista = new List<ClienteLista>();

        }

        public void resgistrarCliente(ClienteLista cliente)
        {
            clienteLista.Add(cliente);
            
        }


    }
     class ClienteLista
        {
            public int Id;
            public string Nome;
            public int Cpf;
            public string DataNascimento;

            public ClienteLista(int Id, string Nome, int Cpf, string DataNascimento)
            
            {
                Id = Id;
                Nome = Nome;
                Cpf = Cpf;
                DataNascimento = DataNascimento;
            
            }
        }

    class Program
    {
        static void Main(string[] args)
        {
           int Id;
           string Nome;
           int Cpf;
           string DataNascimento;
           Listar listar = new Listar();

                Console.WriteLine("digite um Id");
                Id = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Digite o nome do cliente");
                Nome = Console.ReadLine();
                Console.WriteLine("digite o cpf do cliente");
                Cpf = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("digite a data de nascimento do cliente");
                DataNascimento = Console.ReadLine();
           
                ClienteLista clienteLista = new ClienteLista(Id, Nome, Cpf, DataNascimento);
        }
    }
}
