using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI23T
{
    class ModelCalculadora
    {
        //1º Variáveis = GLOBALMENTE = Código inteiro enxerga elas
        private double num1;//Encapsular a variável
        private double num2;
        private double resultado;
        private double Met1;
        private double Met2;
        private double lado1;
        private double lado2;
        private double lado3;
        private double dNum;
        private double senha;
        private double comparar;

        //Método que instancia as variáveis = dá valores iniciais
        //2º Método construtor
        public ModelCalculadora()
        {
            this.num1      = 0;
            this.num2      = 0;
            this.resultado = 0;
        }//fim do construtor

        public ModelCalculadora(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }//fim do construtor com parâmetros

        //3º Método GET - Consulta
        public double getNum1()
        {
            return this.num1;
        }//fim do método get

        public double getNum2()
        {
            return this.num2;
        }//fim do get

        public double getResultado()
        {
            return this.resultado;
        }//fim do get

        //4º Métodos set - Modificadores
        public void setNum1(double num1)
        {
            this.num1 = num1;
        }//fim do set

        public void setNum2(double num2)
        {
            this.num2 = num2;
        }//fim do set

        public void setResultado(double resultado)
        {
            this.resultado = resultado;
        }//fim do set

        //Operações aritméticas
        public double somar()
        {
            this.setResultado(this.getNum1() + this.getNum2());//Alterando a resultado
            return this.getResultado();//Mostrando o resultado
        }//fim do método

        public double subtrair()
        {
            this.setResultado(this.getNum1() - this.getNum2());
            return this.getResultado();
        }//fim do subtrair

        public double multiplicar()
        {
            this.setResultado(this.getNum1() * this.getNum2());
            return this.getResultado();
        }//fim do multiplicar

        public double dividir()
        {
            if (this.getNum2() == 0)
            {
                return -1;//Flag = Porque ele vai indicar que não da para dividir por zero
            }
            else
            {
                this.setResultado(this.getNum1() / this.getNum2());
                return this.getResultado();
            }
        }//fim do dividir

        //POTENCIA

        public double potencia() {
            this.setResultado(Math.Pow(this.getNum1(), this.getNum2()));
            return this.getResultado();
        }//fim do potencia

        public double raizPrimeiroNumero()
        {
            this.setResultado(Math.Sqrt(this.getNum1()));
            return this.getResultado();
        }

        public double raizSegundoNumero()
        {
            this.setResultado(Math.Sqrt(this.getNum2()));
            return this.getResultado();
        }//fim do raiz Segundo numero

        public string tabuada(int num)
        {
            string msg = "";
            int i = 0;
            for (i = 0; i <= 10; i++)
            {
                msg += "\n" + num + " * " + i + " = " + (num * i);

            }//fim do for
            return msg; 
        }//fim do metodo

        public String bissexto(int ano)
        {
            if (ano == 0)
            {
                return $"{ano} É bissexto"; //Interpolação
            }
            else
            {
                return $"{ano} NÃO é bissexto"; 
            }
        }

        public string verificarNum(int vNum) 
        {
            if (vNum >= 100 &&  vNum <= 200)
            {
                return $"{vNum} está entre 100 e 200";
            }
            else
            {
                return $"{vNum} NÃO está entre 100 e 200";
            }
        }

        public string verificarIdade(int Num)
        {
            if (Num >= 16)
            {
                return "Tem idade para votar";
            }
            else
            {
                return "NÃO tem idade para votar";
            }
        }

        public string verificarIntervalo(int InNum, int Met1, int Met2)
        {
            if (InNum > Met1 && InNum <= Met2)
            {
                return $"O numero {InNum} está entre o intervalo";
            }
            else
            {
                return $"O numero {InNum} NÃO está no intervalo";
            }
        }

        public string verificarTriangulo(int lado1, int lado2, int lado3)
        {
            if (lado1 == lado2 && lado2 == lado3 && lado1 == lado3)
            {
                return $"O seu Triangulo é equilatero";
            }
            else if (lado1 == lado2 && lado2 != lado3)
            {
                return $"o triangulo é isosceles";
            }
            else
            {
                return $"o triangulo é escaleno";
            }
        }
       public string diaSemana(int dNum)
       {
            switch (dNum)
            {
                case 1:
                    return "Segunda-Feira!";
                case 2:
                    return "Terça-Feira!";
                case 3:
                    return "Quarta-Feira!";
                case 4:
                    return "Quinta-Feira!";
                case 5:
                    return "Sexta-Feira!";
                case 6:
                    return "Sabado!";
                case 7:
                    return "Domingo!";
                default:
                    return "Informe um valor entre 1 e 7!";
            }
        }

        public string senhaDigitada(int senha, int comp)
        {
            if (senha == comp)
            {
                return "senha aprovada";
            }
            else 
            {
                return "senha reprovada";
            }
        }

    }

   //fim da classe Mod
} //fim do projetoCalculadoraTI23T
