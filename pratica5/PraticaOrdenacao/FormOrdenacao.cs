using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Pratica5 {
    public partial class FormOrdenacao : Form {
        int[] vet = new int[500]; // vetor interno para a animação

        public FormOrdenacao() {
            InitializeComponent();
            panel.Paint += new PaintEventHandler(panel_Paint);
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel, new object[] { true });
        }

        private void panel_Paint(object sender, PaintEventArgs e) {
            for (int i = 0; i < vet.Length; i++) {
                e.Graphics.DrawLine(Pens.Olive, i, 299, i, 299 - vet[i]);
            }
        }

        private void bolhaToolStripMenuItem_Click(object sender, EventArgs e) {
            iniciaAnimacao(() => OrdenacaoGrafica.Bolha(vet, panel));          
        }
        private void insercaoMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.Insercao(vet, panel));
        }

        private void selecaoMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.selecao(vet, panel));
        }
        private void quicksortMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.quickSort(vet,0,vet.Length-1, panel));
        }
        private void heapSortMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.heapSort(vet, panel));
        }

        private void MergeSortMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.mergeSort(vet, 0, vet.Length - 1,panel));
        }

        private void ShellSortMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.shellSort(vet, panel));
        }

        // TODO: animação e estatísticas dos demais métodos de ordenação

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show(this, 
                "Métodos de Ordenação - 2020/2\n\n" +
                "Desenvolvido por:\n72000899 - Ana Clara Samarino\n" +
                "Prof. Virgílio Borges de Oliveira\n\n" +
                "Algoritmos e Estruturas de Dados\n" +
                "Faculdade COTEMIG\n" +
                "Somente para fins didáticos.", 
                "Sobre o trabalho...", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void iniciaAnimacao(Action a) {
            if (bgw.IsBusy != true) {
                Preenchimento.Aleatorio(vet, 299);
                bgw.RunWorkerAsync(a);
            }
            else {
                MessageBox.Show(this,
                   "Aguarde o fim da execução atual...",
                   "Métodos de Ordenação - 2020/2",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
            }
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e) {
            Action a = (Action)e.Argument;
            a();
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            MessageBox.Show(this,
               "Animação concluída!",
               "Métodos de Ordenação - 2020/2",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }

        private void bolhaToolStripMenuItem1_Click_1(object sender, EventArgs e) {

            OrdenacaoEstatistica estatiticas = new OrdenacaoEstatistica();
            IniciaEstatisticas(estatiticas,0); // Bolha

        }

        private void IniciaEstatisticas(OrdenacaoEstatistica estatistica,int NumeroMetodo)
        {

            int TA;
            String NomeMetodo = "Inicial";

            if(!Int32.TryParse(tamanhoArray.Text, out TA))
            {
                TA = 1000;
                tamanhoArray.Text = "1000";
            }
            
            int[] vetor = new int[TA];

            if (TipoOrdenacao.Text == "Aletorio") { Preenchimento.Aleatorio(vetor, 300); }
            else if (TipoOrdenacao.Text == "Decrecente") { Preenchimento.Decrescente(vetor, 300); }
            else { Preenchimento.Crescente(vetor, 300); TipoOrdenacao.Text = "Crecente"; }

            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            estatistica.cont_c = 0; //zera os contadores do metodo ordenaçãoestatistica
            estatistica.cont_t = 0;
            switch (NumeroMetodo)
            {
                case 0: //Bolha
                    estatistica.Bolha(vetor);
                    NomeMetodo = "Bolha"; 
                    break;
                case 1: //Inserção
                    estatistica.Insercao(vetor);
                    NomeMetodo = "Inserção";
                    break;
                case 2: //Selecão
                    estatistica.selecao(vetor);
                    NomeMetodo = "Selecao";
                    break;
                case 3: //QuickSort
                    estatistica.quickSort(vetor, 0, vetor.Length - 1);
                    NomeMetodo = "QuickSort";
                    break;
                case 4: //HeapSort
                    estatistica.heapSort(vetor);
                    NomeMetodo = "HeapSort";
                    break;
                case 5: //MergeSort
                    estatistica.mergeSort(vetor, 0, vetor.Length - 1);
                    NomeMetodo = "MergeSort";
                    break;
                case 6: //ShellSort
                    estatistica.shellSort(vetor);
                    NomeMetodo = "ShellSort";
                    break;
                default: //QuickSort
                    estatistica.quickSort(vetor, 0, vetor.Length - 1);
                    NomeMetodo = "QuickSort";
                    break;
            }
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vetor.Length +
                  "\nOrdenação inicial: " + TipoOrdenacao.Text +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + estatistica.cont_c +
                  "\nNº de trocas: " + estatistica.cont_t,
                  "Estatísticas do Método " + NomeMetodo,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);

        }

        private void inserçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenacaoEstatistica estatiticas = new OrdenacaoEstatistica();
            IniciaEstatisticas(estatiticas, 1); // Inserção
        }

        private void selecaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenacaoEstatistica estatiticas = new OrdenacaoEstatistica();
            IniciaEstatisticas(estatiticas, 2); // Seleção
        }

        private void quickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenacaoEstatistica estatiticas = new OrdenacaoEstatistica();
            IniciaEstatisticas(estatiticas, 3); // Quicksort
        }

        private void heapSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenacaoEstatistica estatiticas = new OrdenacaoEstatistica();
            IniciaEstatisticas(estatiticas, 4); // HeapSort
        }

        private void mergeSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenacaoEstatistica estatiticas = new OrdenacaoEstatistica();
            IniciaEstatisticas(estatiticas, 5); // MergeSort
        }

        private void shellSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenacaoEstatistica estatiticas = new OrdenacaoEstatistica();
            IniciaEstatisticas(estatiticas, 6); // ShellSort
        }
    }
}
