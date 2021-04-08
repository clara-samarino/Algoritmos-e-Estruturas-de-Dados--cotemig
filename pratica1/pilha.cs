using System;

namespace trabalho_pratico
{
    class Pilha
    {
        private int [] vet;
        private int topo;
        public Pilha(int tamanho){
            vet = new int [tamanho];
            topo = 0;
        }
        public void Empilhar(int item){
            vet[topo] = item;
            topo++;
        }
        public int Desempilhar(){
            topo--;
            return vet[topo];
        }
        public bool Vazia(){
            return (topo ==0);
        }
        public bool Cheia(){
            return (topo==vet.Length);
        }
    }
}