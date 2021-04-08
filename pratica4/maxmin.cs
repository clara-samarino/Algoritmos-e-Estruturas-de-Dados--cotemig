using System;

namespace atpratica4
{
    class MaxMin
    {
        // Operação relevante: TESTES (if)
        // T(n) = 2n - 2
        public void MaxMin1(int[] vet, out int ma, out int me)
        {
            int contador1 = 0;
            ma = me = vet[0];
            for (int i = 1; i < vet.Length; i++)
            {
                if (vet[i] < me)
                    me = vet[i];
                if (vet[i] > ma)
                    ma = vet[i];
                contador1 += 2;
            }
            Console.WriteLine("{0} Comparações", contador1);
        }

        // Melhor caso: T(n) = n - 1
        // Pior caso: T(n) = 2n - 2
        // Caso médio: T(n) = 3n/2 - 3/2
        public void MaxMin2(int[] vet, out int ma, out int me)
        {
            int contador2 = 0;
            ma = me = vet[0];
            for (int i = 1; i < vet.Length; i++)
            {
                contador2++;
                if (vet[i] < me)
                {
                    me = vet[i];
                }
                else
                {
                    contador2++;
                    if (vet[i] > ma)
                    {
                        ma = vet[i];
                    }
                }

            }
            Console.WriteLine("{0} Comparações", contador2);
        }

        // T(n) = 3n/2 - 2
        public void MaxMin3(int[] vet, out int ma, out int me)
        {
            int contador3 = 0;
            contador3++;
            if (vet[0] < vet[1])
            {
                me = vet[0];
                ma = vet[1];
            }
            else
            {
                me = vet[1];
                ma = vet[0];
            }
            for (int i = 2; i < vet.Length; i += 2)
            {
                
                contador3++;
                if (vet[i] < vet[i + 1])
                {
                    contador3++;
                    if (vet[i] < me)
                        me = vet[i];
                    contador3++;
                    if (vet[i + 1] > ma)
                        ma = vet[i + 1];
                }
                else
                {
                    contador3++;
                    if (vet[i + 1] < me)
                        me = vet[i + 1];
                    contador3++;
                    if (vet[i] > ma)
                        ma = vet[i];
                }
            }
            Console.WriteLine("{0} Comparações", contador3);
        }
    }
}