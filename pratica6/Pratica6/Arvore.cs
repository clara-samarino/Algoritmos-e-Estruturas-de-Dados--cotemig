using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Pratica6 {
    class Arvore {
        public NoArvore raiz = null;
        public void inserir(string chave) {
            if (raiz == null) {
                raiz = new NoArvore(chave);
            }
            else {
                raiz.inserir(chave);
            }
        }

        public void emOrdem(NoArvore x) {
            if (x != null) {
                emOrdem(x.esq);
                Console.Write(x.diciplina + " ");
                emOrdem(x.dir);
            }
        }

        public void preOrdem(NoArvore x) {
            if (x != null) {
                Console.Write(x.diciplina + " ");
                preOrdem(x.esq);
                preOrdem(x.dir);
            }
        }

        public void posOrdem(NoArvore x) {
            if (x != null) {
                posOrdem(x.esq);
                posOrdem(x.dir);
                Console.Write(x.diciplina + " ");
            }
        }

        public NoArvore pesquisar(string c, NoArvore x) {
 
            if (x == null || x.diciplina == c)
                return x;
            else if (String.Compare(c,x.diciplina)<0) // c < x.chave
                return pesquisar(c, x.esq);
            else
                return pesquisar(c, x.dir);

        }
    }

    public class NoArvore {
        public string diciplina;
        public List<DadosPessoas> Alunos;
        public NoArvore esq, dir;

        public NoArvore(string c) {
            diciplina = c;
            esq = dir = null;
        }

        public void inserir(string c) {
            if (String.Compare(c, diciplina) < 0) {
                if (esq == null)
                    esq = new NoArvore(c);
                else
                    esq.inserir(c);
            }
            else if (String.Compare(c, diciplina) > 0) {
                if (dir == null)
                    dir = new NoArvore(c);
                else
                    dir.inserir(c);
            }
            else
                Console.WriteLine("Chave duplicada. Impossível inserir!");
        } // fim do metodo inserir
    }
}