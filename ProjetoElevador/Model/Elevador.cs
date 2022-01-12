using System;

namespace ProjetoElevador
{
    class Elevador
    {
        public int andarAtual;
        public int totalAndares;
        public int capacidade;
        public int pessoasAtual;

        public Elevador(int _capacidade, int _totalAndares, int _andarAtual, int _pessoasAtual)
        {
            this.capacidade = _capacidade;
            this.totalAndares = _totalAndares;
            this.andarAtual = _andarAtual;
            this.pessoasAtual = _pessoasAtual;
        }

        public Elevador()
        {
        }

        public void Iniciar()
        { 

            if (andarAtual == 0)
            {
                Console.WriteLine("Elevador está no térreo.");
            }
           else
            {
                Console.WriteLine("Elevador está no  " + andarAtual + "˚ andar.");
            }


           if(pessoasAtual == 0)
            {
                Console.WriteLine("Elevador vazio.");
            }
           else if (pessoasAtual == 1)
            {
                Console.WriteLine("Tem " + pessoasAtual + " pessoa no elevador.");
            }
            else
            {
                Console.WriteLine("Tem " + pessoasAtual + " pessoas no elevador.");
            }

            Console.WriteLine("   ");
        }

        public void Entrar()
        {
            if (pessoasAtual < capacidade)
            {


                pessoasAtual = pessoasAtual + 1;
            }
            else
            {
                Console.WriteLine("ATENÇÃO!!");
                Console.WriteLine("Elevador já atingiu a capacidade máxima.");
                Console.WriteLine(" ");
            }
        }

        public void Sair()
        {
            if (pessoasAtual <= capacidade && pessoasAtual > 0)
            {


                pessoasAtual = pessoasAtual - 1;
            }
            else
            {
                Console.WriteLine("ATENÇÃO!!");
                Console.WriteLine("Elevador está vazio.");
                Console.WriteLine(" ");
            }

        }

        public void Subir()
        {
            if (andarAtual < totalAndares)
            {
                andarAtual = andarAtual + 1;
            }

            else
            {
                Console.WriteLine("ATENÇÃO!!");
                Console.WriteLine("Elevador já atingiu o último andar");
                Console.WriteLine(" ");
            }


        }


        public void Descer()
        {
            if (andarAtual <= totalAndares && andarAtual >0)
            {
                andarAtual = andarAtual - 1;
            }

            else
            {
                Console.WriteLine("ATENÇÃO!!");
                Console.WriteLine("Elevador já atingiu o térreo.");
                Console.WriteLine(" ");
            }


        }


    }
}