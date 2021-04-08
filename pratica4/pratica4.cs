using System;
using System.Collections.Generic;
using System.Text;

namespace atpratica4
{
    class Pratica4
    {

        static void Main(string[] args)
        {
            Random num = new Random();
            int maior, menor;
            int[] vetcre = new int[1000];
            int[] vetdec = new int[1000];
            int[] vetaleat = new int[1000];
            for (int i = 0; i < vetaleat.Length; i++)
            {
                vetcre[i] = i;
                vetdec[i] = vetdec.Length - i - 1;
                vetaleat[i] = num.Next(-500,501);
            }
           
            MaxMin obj1 = new MaxMin();
            Console.WriteLine("Maxmin 1 = vetor crescente");
            obj1.MaxMin1(vetcre, out maior, out menor);
            Console.WriteLine("maior:{0} menor:{1}", maior, menor);
            Console.WriteLine("Maxmin 1 = vetor decrescente");
            obj1.MaxMin1(vetdec, out maior, out menor);
            Console.WriteLine("maior:{0} menor:{1}", maior, menor);
            Console.WriteLine("Maxmin 1 = vetor aleatorio");
            obj1.MaxMin1(vetaleat, out maior, out menor);
            Console.WriteLine("maior:{0} menor:{1}", maior, menor);
            Console.WriteLine("Maxmin 2 = vetor crescente");
            obj1.MaxMin2(vetcre, out maior, out menor);
            Console.WriteLine("maior:{0} menor:{1}", maior, menor);
            Console.WriteLine("Maxmin 2 = vetor decrescente");
            obj1.MaxMin2(vetdec, out maior, out menor);
            Console.WriteLine("maior:{0} menor:{1}", maior, menor);
            Console.WriteLine("Maxmin 2 = vetor aleatorio");
            obj1.MaxMin2(vetaleat, out maior, out menor);
            Console.WriteLine("maior:{0} menor:{1}", maior, menor);
            Console.WriteLine("Maxmin 3 = vetor crescente");
            obj1.MaxMin3(vetcre, out maior, out menor);
            Console.WriteLine("maior:{0} menor:{1}", maior, menor);
            Console.WriteLine("Maxmin 3 = vetor decrescente");
            obj1.MaxMin3(vetdec, out maior, out menor);
            Console.WriteLine("maior:{0} menor:{1}", maior, menor);
            Console.WriteLine("Maxmin 3 = vetor aleatorio");
            obj1.MaxMin3(vetaleat, out maior, out menor);
            Console.WriteLine("maior:{0} menor:{1}", maior, menor);
        }
    }
}