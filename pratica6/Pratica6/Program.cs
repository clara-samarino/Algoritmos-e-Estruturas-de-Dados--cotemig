using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Pratica6 {
    class Program {
        [STAThread]
        static void Main(string[] args) {
            string linha;
            string nomeDaDiciplina;
            bool continua = true;
            
            Arvore arvoreAlunos = new Arvore();
            Console.WriteLine("ÁRVORE BINÁRIA DE PESQUISA");
            
            OpenFileDialog dialogo = new OpenFileDialog();
            
            do
            {
                
                Console.WriteLine("\n Digite a tecla de entrada");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("| Tecla |                       COMANDO                       ");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("|  1   |Informar arquivo");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("|  2   |Imprimir disciplinas em ordem crescente");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("|  3   |Imprimir disciplinas em pré - ordem");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("|  4   |Imprimir disciplinas em pós - ordem");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("|  5   |Listar Turma");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("|  6   |Sair");
                Console.WriteLine("--------------------------------------------------------------");

                ConsoleKeyInfo tecla;
                tecla = Console.ReadKey();
                switch (tecla.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        dialogo.Title = "Abrir arquivo...";
                        dialogo.Filter = "Arquivos texto|*.txt";
                        dialogo.InitialDirectory = @"c:\";
                        string[] vetorlinha; 

                        if (dialogo.ShowDialog() == DialogResult.OK)
                        {
                            System.IO.StreamReader arquivo = new System.IO.StreamReader(dialogo.FileName.ToString());
                            while ((linha = arquivo.ReadLine()) != null)
                            {
                                //Console.WriteLine(linha);
                                vetorlinha = linha.Split(';');

                                NoArvore temp, temp2;
                                
                                for (int i = 2; i< vetorlinha.Length; i++)
                                {
                                    
                                    temp = arvoreAlunos.pesquisar(vetorlinha[i].ToUpper(), arvoreAlunos.raiz);
                                    if (temp == null)
                                    {
                                        arvoreAlunos.inserir(vetorlinha[i].ToUpper());
                                        temp2 = arvoreAlunos.pesquisar(vetorlinha[i].ToUpper(), arvoreAlunos.raiz);
                                        temp2.Alunos = new List<DadosPessoas>();
                                        temp2.Alunos.Add(new DadosPessoas(vetorlinha[1], vetorlinha[0]));
                                    }
                                    else
                                    {
                                        temp.Alunos.Add(new DadosPessoas(vetorlinha[1], vetorlinha[0]));
                                    }
                                }
                            }
                            arquivo.Close();
                        }
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        if (arvoreAlunos.raiz == null)
                        {
                            Console.WriteLine("Informe um arquivo antes da impressão");
                            break;
                        }
                        arvoreAlunos.emOrdem(arvoreAlunos.raiz);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        if (arvoreAlunos.raiz == null)
                        {
                            Console.WriteLine("Informe um arquivo antes da impressão");
                            break;
                        }
                        arvoreAlunos.preOrdem(arvoreAlunos.raiz);
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        if (arvoreAlunos.raiz == null)
                        {
                            Console.WriteLine("Informe um arquivo antes da impressão");
                            break;
                        }
                        arvoreAlunos.posOrdem(arvoreAlunos.raiz);
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        if (arvoreAlunos.raiz == null)
                        {
                            Console.WriteLine("Não há turmas registradas");
                            break;
                        }
                        NoArvore aux;
                        Console.WriteLine("Informe o nome da diciplina");
                        nomeDaDiciplina = Console.ReadLine().ToUpper();
                        aux = arvoreAlunos.pesquisar(nomeDaDiciplina, arvoreAlunos.raiz);
                        if(aux == null)
                        {
                            Console.WriteLine("Essa diciplina não existe. Refaça a operação com uma diciplina válida");
                        }
                        else
                        {
                            aux.Alunos.Sort((pessoa1, pessoa2) => pessoa1.matricula.CompareTo(pessoa2.matricula));
                            foreach (DadosPessoas elemento in aux.Alunos)
                            {
                                Console.WriteLine(elemento.matricula + "-" + elemento.nomePessoa);
                                
                            }
                        }
                        break;
                    case ConsoleKey.D6:
                        continua = false;
                        break;
                    default:
                        Console.WriteLine("Informe uma tecla válida");
                        break;
                }
            } while (continua);

            
        }
    }
}