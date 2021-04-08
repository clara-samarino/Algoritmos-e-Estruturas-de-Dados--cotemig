using System;

namespace atpratica2
{
    class Fila
    {
        private int [] vet;
        private int inicio, fim;
        
        public Fila(int tamanho){
            vet = new int[tamanho+1];
            inicio = fim = 0;
        }
        public void Enfileirar(int item){
            vet[fim] = item;
            fim = (fim+1)%vet.Length;
            //fim++;
            //if(fim == vet.Length){
                //fim = 0;
            //}
            
        }
        public int Desenfileirar(){
            int item = vet[inicio];
            inicio = (inicio+1)%vet.Length;
            return item;
        }
        public bool Vazia(){
            return (inicio==fim);
        }
        public bool Cheia(){
            return ((fim+1)%vet.Length==inicio);
        }
    }
}