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


    }//fim da classe Model
}//fim do projetoCalculadoraTI23T
