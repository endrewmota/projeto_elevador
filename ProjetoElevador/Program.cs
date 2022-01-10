using System;

namespace ProjetoElevador
{
    class MainClass
    {

        static void Main(string[] args)
        {

            bool continuar = true;

            Console.WriteLine("Informe a capacidade máxima do elevador.");
            string _capacidadeMaxima = Console.ReadLine();
            int capacidade = int.Parse(_capacidadeMaxima);

            Console.WriteLine("Informe o número de andares do prédio.");
            string _andaresDoPredio = Console.ReadLine();
            int _totalAndares = int.Parse(_andaresDoPredio);


            Console.Clear();
            Elevador e = new Elevador(capacidade, _totalAndares, 0, 0, 0);


            //MENU
            do
            {

                e.Iniciar();

                Console.WriteLine(@"Escolha uma opção:
1 - para entrar no elevador 
2 - para escolher andar
3 - para sair do elevador
4 - para sair do programa
                                ");

                string opcaoEscolhida = Console.ReadLine();
                Console.Clear();


                switch (opcaoEscolhida)
                {
                    case "1":
                        e.Entrar();
                        break;

                    case "2":
                        e.EscolherAndar();
                        break;

                    case "3":
                        e.Sair();
                        break;

                    case "4":
                        continuar = false;
                        Console.WriteLine("Finalizando programa");
                        break;

                }
            }

            while (continuar);
        }

    }
}