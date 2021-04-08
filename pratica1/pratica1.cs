using System;

namespace trabalho_pratico
{
    class Programat1
    {
        static void Main(string[] args)
        {
            string numero;
            int num1, num2, contador =0;
            Pilha p1 = new Pilha(100);
            while(!p1.Cheia()){
                numero = Console.ReadLine();
                if(numero!="+" && numero !="-" && numero!="*" && numero!="/"){
                   p1.Empilhar(Convert.ToInt32(numero));
                   contador++;
                }
                else if(numero=="+" || numero =="-" || numero=="*" || numero=="/"){
                    if(p1.Vazia()){
                        Console.WriteLine("Erro. Faltam valores");
                    }
                    else{
                        if(contador == 1){
                            Console.WriteLine("Erro. Faltam valores");
                        }
                        else if(numero=="+"){
                            num1 = p1.Desempilhar();
                            num2 = p1.Desempilhar();
                            Console.WriteLine(num1+num2);
                            p1.Empilhar(num1+num2);
                            contador--;
                        }
                        else if(numero=="-"){
                            num1 = p1.Desempilhar();
                            num2 = p1.Desempilhar();
                            Console.WriteLine(num2-num1);
                            p1.Empilhar(num2-num1);
                            contador--; 
                        }
                        else if(numero=="*"){
                            num1 = p1.Desempilhar();
                            num2 = p1.Desempilhar();
                            Console.WriteLine(num1*num2);
                            p1.Empilhar(num1*num2);
                            contador--; 
                        }
                        else if(numero=="/"){
                            num1 = p1.Desempilhar();
                            num2 = p1.Desempilhar();
                            Console.WriteLine(num2/num1);
                            p1.Empilhar(num2/num1);
                            contador--; 
                        }
                    }
                    
                }
                    
            }
            if(p1.Cheia()){
                Console.WriteLine("Erro. Pilha Cheia");
            }
             
        }
    }
}