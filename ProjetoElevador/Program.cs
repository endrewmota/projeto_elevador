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

            Elevador e = new Elevador(capacidade, _totalAndares, 0, 0);


            //MENU
            do
            {

                e.Iniciar();

                Console.WriteLine(@"Escolha uma opção:
1 - para entrar no elevador 
2 - para sair do elevador
3 - para o elevador subir
4 - para o elevador descer
5 - para sair do programa
                                ");

                string opcaoEscolhida = Console.ReadLine();
                Console.Clear();


                switch (opcaoEscolhida)
                {
                    case "1":
                        e.Entrar();
                        break;

                    case "2":
                        e.Sair();
                        break;

                    case "3":
                        e.Subir();
                        break;

                    case "4":
                        e.Descer();
                        break;

                    case "5":
                        continuar = false;
                        Console.WriteLine("Finalizando programa");
                        break;

                }
            }

            while (continuar);
        }

    }
}