using System;

namespace atpratica3
{
    class Programat3
    {
        static void Menu(){
            ConsoleKeyInfo chave;
            bool continua = true;
            int num, axl;
            string nome;
            NoLista n;
            Listaat3 l = new Listaat3();
            do{
                Console.Clear();
                Console.WriteLine("Selecione a tecla desejada");
                Console.WriteLine(" ");
                Console.WriteLine("|TECLA|    FUNÇÃO    |");
                Console.WriteLine("| D1  |    Inserir   |");
                Console.WriteLine("| D2  |    Pesquisar |");
                Console.WriteLine("| D3  |    Imprimir  |");
                Console.WriteLine("| D4  |    Sair      |");
                chave = Console.ReadKey();
                switch(chave.Key){
                    case ConsoleKey.D1:
                        Console.WriteLine("Digite o número a ser inserido ou -1 para sair");
                        num = Convert.ToInt32(Console.ReadLine());
                        while(num!=-1){
                            if(l.Pesquisar(num)==null){
                                Console.WriteLine("Informe o nome:");
                                nome = Console.ReadLine();
                                l.Inserir(new NoLista(num,nome));
                                Console.WriteLine("Digite o número a ser inserido ou -1 para sair");
                                num = Convert.ToInt32(Console.ReadLine());
                            }
                            else{
                                Console.WriteLine("Chave já inserida. Digite -1 para sair");
                                num = Convert.ToInt32(Console.ReadLine());
                            }
                            
                        } 
                        
                    break;
                    case ConsoleKey.D2:
                        Console.WriteLine("Informe o número a ser pesquisado");
                        num = Convert.ToInt32(Console.ReadLine());
                        n = l.Pesquisar(num);
                        if(n!=null){
                            Console.WriteLine("nome:{0}", n.nome);
                            Console.WriteLine("Para remover o nó da lista digite 1");
                            axl = Convert.ToInt32(Console.ReadLine());
                            if(axl==1){
                                l.Remover(num);
                                Console.WriteLine("Nó removido com sucesso");
                            }
                        }
                        else{
                            Console.WriteLine("Chave não encontrada");
                            Console.ReadKey();
                        }
                    break;

                    case ConsoleKey.D3:
                        Console.WriteLine("Números da lista:");
                        l.Imprimir();
                        Console.ReadKey();
                    break;
                    case ConsoleKey.D4:
                        continua = false;
                    break;
                    default:
                        Console.WriteLine("ERRO. Informe outra chave/tecla");
                        Console.ReadKey();
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