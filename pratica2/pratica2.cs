using System;

namespace atpratica2
{
    
    class Programat2
    {
        static ConsoleKeyInfo chave;
        static void Menu(){
            Fila fPedidos = new Fila(100);
            Fila fPagamentos = new Fila(100);
            Fila fEntrega = new Fila(100);
            int numeroCliente=0, var, var2, var3;
            string numeroString;
            bool continua = true;
            do{
                Console.WriteLine("Digite o botão correspondente à função desejada");
                Console.WriteLine("");
                Console.WriteLine("D1 - Inserção de cliente na fila de pedidos");
                Console.WriteLine("D2 - Remoção de cliente da fila de pedidos");
                Console.WriteLine("D3 - Remoção de cliente da fila de pagamentos");
                Console.WriteLine("D4 - Remoção de cliente da fila de encomendas");
                Console.WriteLine("D5 - Sair");
                chave = Console.ReadKey();
                switch(chave.Key){
                    case ConsoleKey.D1:
                        if(!fPedidos.Cheia()){
                            numeroCliente +=1;
                            fPedidos.Enfileirar(numeroCliente);
                            if(numeroCliente<10){
                                numeroString = "00"+Convert.ToString(numeroCliente);
                            }
                            else {
                                numeroString = "0"+Convert.ToString(numeroCliente);
                            }
                            Console.WriteLine("");
                            Console.WriteLine("Cliente {0} entrou na fila de pedidos", numeroString);
                        
                        }
                        else{
                            Console.WriteLine("Capacidade máxima da fila de pedido atingida");
                        }
                        break;
                        

                    case ConsoleKey.D2:
                        if(fPagamentos.Cheia()){
                            Console.WriteLine("Capacidade máxima da fila de pagamento atingida");
                        }
                        else if(fPedidos.Vazia()){
                            Console.WriteLine("Erro, a fila de pedidos está vazia");
                        }
                        else{
                            var = fPedidos.Desenfileirar();
                            fPagamentos.Enfileirar(var);
                            if(var<10){
                                numeroString = "00"+Convert.ToString(var);
                            }
                            else {
                                numeroString = "0"+Convert.ToString(var);
                            }
                            Console.WriteLine("");
                            Console.WriteLine("Cliente {0} saiu da fila de pedidos", numeroString);
                            Console.WriteLine("Cliente {0} entrou na fila de pagamento", numeroString);
                            
                        }
                        break;
                        
                    case ConsoleKey.D3:
                        if(fEntrega.Cheia()){
                            Console.WriteLine("Capacidade máxima da fila de entrega atingida");
                        }
                        else if(fPagamentos.Vazia()){
                            Console.WriteLine("Erro, a fila de pagamentos está vazia");
                        }
                        else{
                            var2 = fPagamentos.Desenfileirar();
                            fEntrega.Enfileirar(var2);
                            if(var2<10){
                                numeroString = "00"+Convert.ToString(var2);
                            }
                            else {
                                numeroString = "0"+Convert.ToString(var2);
                            }
                            Console.WriteLine("");
                            Console.WriteLine("Cliente {0} saiu da fila de pagamento", numeroString);
                            Console.WriteLine("Cliente {0} entrou na fila de encomendas", numeroString);
                        }
                        break;
                    case ConsoleKey.D4:
                        if(fEntrega.Vazia()){
                            Console.WriteLine("Erro, a fila de encomenda está vazia");
                        }
                        else{
                            var3 = fEntrega.Desenfileirar();
                            if(var3<10){
                                numeroString = "00"+Convert.ToString(var3);
                            }
                            else {
                                numeroString = "0"+Convert.ToString(var3);
                            }
                            Console.WriteLine("");
                            Console.WriteLine("Cliente {0} saiu da fila de encomendas", numeroString);
                        }
                        break;
                    case ConsoleKey.D5:
                        continua = false;
                        break;    
                }
            }while(continua);
            
        }
        static void Main(string[] args)
        {
            Menu();   
        }
    }
}