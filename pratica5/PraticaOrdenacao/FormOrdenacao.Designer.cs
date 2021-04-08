namespace Pratica5
{
    partial class FormOrdenacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algoritmoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insercaoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selecaoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quicksortMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heapSortMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MergeSortMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShellSortMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolhaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.TipoOrdenacao = new System.Windows.Forms.ComboBox();
            this.tamanhoArray = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inserçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selecaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heapSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 56);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(500, 300);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoToolStripMenuItem,
            this.estatísticasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algoritmoToolStripMenuItem
            // 
            this.algoritmoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolhaToolStripMenuItem,
            this.insercaoMenuItem,
            this.selecaoMenuItem,
            this.quicksortMenuItem,
            this.heapSortMenuItem,
            this.MergeSortMenuItem,
            this.ShellSortMenuItem});
            this.algoritmoToolStripMenuItem.Name = "algoritmoToolStripMenuItem";
            this.algoritmoToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.algoritmoToolStripMenuItem.Text = "Algoritmo";
            // 
            // bolhaToolStripMenuItem
            // 
            this.bolhaToolStripMenuItem.Name = "bolhaToolStripMenuItem";
            this.bolhaToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.bolhaToolStripMenuItem.Text = "Bolha";
            this.bolhaToolStripMenuItem.Click += new System.EventHandler(this.bolhaToolStripMenuItem_Click);
            // 
            // insercaoMenuItem
            // 
            this.insercaoMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.insercaoMenuItem.Name = "insercaoMenuItem";
            this.insercaoMenuItem.Size = new System.Drawing.Size(129, 22);
            this.insercaoMenuItem.Text = "Inserção";
            this.insercaoMenuItem.Click += new System.EventHandler(this.insercaoMenuItem_Click);
            // 
            // selecaoMenuItem
            // 
            this.selecaoMenuItem.Name = "selecaoMenuItem";
            this.selecaoMenuItem.Size = new System.Drawing.Size(129, 22);
            this.selecaoMenuItem.Text = "Seleção";
            this.selecaoMenuItem.Click += new System.EventHandler(this.selecaoMenuItem_Click);
            // 
            // quicksortMenuItem
            // 
            this.quicksortMenuItem.Name = "quicksortMenuItem";
            this.quicksortMenuItem.Size = new System.Drawing.Size(129, 22);
            this.quicksortMenuItem.Text = "Quicksort";
            this.quicksortMenuItem.Click += new System.EventHandler(this.quicksortMenuItem_Click);
            // 
            // heapSortMenuItem
            // 
            this.heapSortMenuItem.Name = "heapSortMenuItem";
            this.heapSortMenuItem.Size = new System.Drawing.Size(129, 22);
            this.heapSortMenuItem.Text = "HeapSort";
            this.heapSortMenuItem.Click += new System.EventHandler(this.heapSortMenuItem_Click);
            // 
            // MergeSortMenuItem
            // 
            this.MergeSortMenuItem.Name = "MergeSortMenuItem";
            this.MergeSortMenuItem.Size = new System.Drawing.Size(129, 22);
            this.MergeSortMenuItem.Text = "MergeSort";
            this.MergeSortMenuItem.Click += new System.EventHandler(this.MergeSortMenuItem_Click);
            // 
            // ShellSortMenuItem
            // 
            this.ShellSortMenuItem.Name = "ShellSortMenuItem";
            this.ShellSortMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ShellSortMenuItem.Text = "ShellSort";
            this.ShellSortMenuItem.Click += new System.EventHandler(this.ShellSortMenuItem_Click);
            // 
            // estatísticasToolStripMenuItem
            // 
            this.estatísticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolhaToolStripMenuItem1,
            this.inserçãoToolStripMenuItem,
            this.selecaoToolStripMenuItem,
            this.quickSortToolStripMenuItem,
            this.heapSortToolStripMenuItem,
            this.mergeSortToolStripMenuItem,
            this.shellSortToolStripMenuItem});
            this.estatísticasToolStripMenuItem.Name = "estatísticasToolStripMenuItem";
            this.estatísticasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.estatísticasToolStripMenuItem.Text = "Estatísticas";
            // 
            // bolhaToolStripMenuItem1
            // 
            this.bolhaToolStripMenuItem1.Name = "bolhaToolStripMenuItem1";
            this.bolhaToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.bolhaToolStripMenuItem1.Text = "Bolha";
            this.bolhaToolStripMenuItem1.Click += new System.EventHandler(this.bolhaToolStripMenuItem1_Click_1);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // bgw
            // 
            this.bgw.WorkerSupportsCancellation = true;
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // TipoOrdenacao
            // 
            this.TipoOrdenacao.FormattingEnabled = true;
            this.TipoOrdenacao.Items.AddRange(new object[] {
            "Crecente",
            "Decrecente",
            "Aletorio"});
            this.TipoOrdenacao.Location = new System.Drawing.Point(296, 27);
            this.TipoOrdenacao.Name = "TipoOrdenacao";
            this.TipoOrdenacao.Size = new System.Drawing.Size(121, 21);
            this.TipoOrdenacao.TabIndex = 2;
            // 
            // tamanhoArray
            // 
            this.tamanhoArray.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tamanhoArray.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tamanhoArray.FormattingEnabled = true;
            this.tamanhoArray.Items.AddRange(new object[] {
            "1000",
            "10000",
            "50000",
            "100000",
            "500000"});
            this.tamanhoArray.Location = new System.Drawing.Point(70, 27);
            this.tamanhoArray.Name = "tamanhoArray";
            this.tamanhoArray.Size = new System.Drawing.Size(121, 21);
            this.tamanhoArray.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tamanho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo de Odenação";
            // 
            // inserçãoToolStripMenuItem
            // 
            this.inserçãoToolStripMenuItem.Name = "inserçãoToolStripMenuItem";
            this.inserçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inserçãoToolStripMenuItem.Text = "Inserção";
            this.inserçãoToolStripMenuItem.Click += new System.EventHandler(this.inserçãoToolStripMenuItem_Click);
            // 
            // selecaoToolStripMenuItem
            // 
            this.selecaoToolStripMenuItem.Name = "selecaoToolStripMenuItem";
            this.selecaoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selecaoToolStripMenuItem.Text = "Selecao";
            this.selecaoToolStripMenuItem.Click += new System.EventHandler(this.selecaoToolStripMenuItem_Click);
            // 
            // quickSortToolStripMenuItem
            // 
            this.quickSortToolStripMenuItem.Name = "quickSortToolStripMenuItem";
            this.quickSortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quickSortToolStripMenuItem.Text = "QuickSort";
            this.quickSortToolStripMenuItem.Click += new System.EventHandler(this.quickSortToolStripMenuItem_Click);
            // 
            // heapSortToolStripMenuItem
            // 
            this.heapSortToolStripMenuItem.Name = "heapSortToolStripMenuItem";
            this.heapSortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.heapSortToolStripMenuItem.Text = "HeapSort";
            this.heapSortToolStripMenuItem.Click += new System.EventHandler(this.heapSortToolStripMenuItem_Click);
            // 
            // mergeSortToolStripMenuItem
            // 
            this.mergeSortToolStripMenuItem.Name = "mergeSortToolStripMenuItem";
            this.mergeSortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mergeSortToolStripMenuItem.Text = "MergeSort";
            this.mergeSortToolStripMenuItem.Click += new System.EventHandler(this.mergeSortToolStripMenuItem_Click);
            // 
            // shellSortToolStripMenuItem
            // 
            this.shellSortToolStripMenuItem.Name = "shellSortToolStripMenuItem";
            this.shellSortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shellSortToolStripMenuItem.Text = "ShellSort";
            this.shellSortToolStripMenuItem.Click += new System.EventHandler(this.shellSortToolStripMenuItem_Click);
            // 
            // FormOrdenacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tamanhoArray);
            this.Controls.Add(this.TipoOrdenacao);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormOrdenacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prática 5 - Métodos de Ordenação 2020/2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algoritmoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bolhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatísticasToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.ToolStripMenuItem bolhaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insercaoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selecaoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quicksortMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heapSortMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MergeSortMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShellSortMenuItem;
        private System.Windows.Forms.ComboBox TipoOrdenacao;
        private System.Windows.Forms.ComboBox tamanhoArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem inserçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selecaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heapSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellSortToolStripMenuItem;
    }
}

