using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI23T
{
    class ControlCalculadora
    {
        //Variáveis Globais
        ModelCalculadora model;//Começando a conectar a control e a model

        //Construtor vazio da classe ModelCalculadora
        public ControlCalculadora()
        {
            this.model = new ModelCalculadora();//Efetivando a ligação com a Model
        }//fim do construtor vazio

        public ControlCalculadora(double num1, double num2)
        {
            this.model = new ModelCalculadora(num1, num2);
        }//fim do construtor com parâmetros

        //Método de Menu
        public string mostrarMenu()
        {
            return "--------- Menu --------\n\n" +
                   "Escolha uma das opções abaixo: \n" +
                   "0. Sair\n" +
                   "1. Somar\n" +
                   "2. Subtrair\n" +
                   "3. Multiplicar\n" +
                   "4. Dividir\n" +
                   "5. Potencia\n" +
                   "6. Raiz Primeiro Numero\n" +
                   "7. Raiz Primeiro Numero\n" +
                   "8. Tabuada\n" +
                   "9. Ano Bissexto\n" +
                   "10. Verificação de numero\n" +
                   "11. Verificação de Idade\n" +
                   "12. Verificação de Intervalo\n" +
                   "13. Verificação de lados\n" +
                   "14. Dia da Semana";
        }//fim do método

        public void realizarOperacao()
        {
            int opcao = 0;//declara do lado de fora do Do...While
            do{
                Console.WriteLine(this.mostrarMenu());//Chamar o menu
                opcao = Convert.ToInt32(Console.ReadLine());
                
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        this.coletar();// Pegar oque o usuario esteja coletando  
                        Console.WriteLine("A soma é: " + this.model.somar());
                        break;
                    case 2:
                        this.coletar();// Pegar oque o usuario esteja coletando  
                        Console.WriteLine("A subtração é: " + this.model.subtrair());
                        break;
                    case 3:
                        this.coletar();// Pegar oque o usuario esteja coletando  
                        Console.WriteLine("A multiplicação é: " + this.model.multiplicar());
                        break;
                    case 4:
                        this.coletar();// Pegar oque o usuario esteja coletando  
                        if (this.model.dividir() == -1)
                        {
                            Console.WriteLine("Impossível dividir por zero!");
                        }
                        else
                        {
                            Console.WriteLine("A divisão é: " + this.model.dividir());
                        }
                        break;
                    case 5:
                        this.coletar();// Pegar oque o usuario esteja coletando  
                        Console.WriteLine("A potencia é: " + this.model.potencia());
                        break;
                    case 6:
                        Console.WriteLine("Informe um Numero");
                        this.model.setNum1(Convert.ToInt32(Console.ReadLine()));

                        Console.WriteLine("A raiz do primeiro numero é: " + this.model.raizPrimeiroNumero());
                        break;
                    case 7:
                        Console.WriteLine("Informe um Numero");
                        this.model.setNum2(Convert.ToInt32(Console.ReadLine()));

                        Console.WriteLine("A raiz do segundo numero é: " + this.model.raizSegundoNumero());
                        break;
                    case 8:
                        Console.WriteLine("Informe um Numero");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //para chamar a tabuada
                        Console.WriteLine(this.model.tabuada(num));
                        break;
                    case 9:
                        Console.WriteLine("Informe um ANO");
                        int ano = Convert.ToInt32(Console.ReadLine());
                        //Chamar o metodo do Bissexto
                        Console.WriteLine(this.model.bissexto(ano));
                        break;
                    case 10:
                        Console.WriteLine("Informe um numero para verificação");
                        int vNum = Convert.ToInt32(Console.ReadLine());
                        //Chamar o metodo do Verificar Numero
                        Console.WriteLine(this.model.verificarNum(vNum));
                        break;
                    case 11:
                        Console.WriteLine("Informe uma idade para verificação");
                        int Num = Convert.ToInt32(Console.ReadLine());
                        //Chamar o metodo do Verificar Idade
                        Console.WriteLine(this.model.verificarIdade(Num));
                        break;
                    case 12:
                        Console.WriteLine("Informe o primeiro numero para intervalo");
                        int Met1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o Segundo numero para intervalo");
                        int Met2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o primeiro numero para intervalo");
                        int InNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe seu numero para intervalo");
                        Console.WriteLine(this.model.verificarIntervalo(InNum, Met1, Met2));
                        break;
                    case 13:
                        Console.WriteLine("Informe o primeiro lado");
                        int lado1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o Segundo lado");
                        int lado2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o terceiro lado");
                        int lado3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.model.verificarTriangulo(lado1, lado2, lado3));
                        break;
                    case 14:
                        Console.WriteLine("Informe o numero para o dia da semana");
                        int dNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.model.diaSemana(dNum));
                        break;
                    case 15:
                        Console.WriteLine("informe a senha");
                        int senha == int com = conver
                        break;
                    default:
                        Console.WriteLine("Informe um valor entre 0 e 9");
                        break;
                }//fim do escolha
            } while (opcao != 0);
        }//fim do método

        public void coletar()
        {
            Console.Write("\nInforme o primeiro número: ");
            this.model.setNum1 (Convert.ToDouble(Console.ReadLine()));//Peguei o primeiro número

            Console.Write("Informe o segundo número: ");
            this.model.setNum2 (Convert.ToDouble(Console.ReadLine()));//Peguei o segundo número
        }

    }//fim da classe
}//fim do projeto
