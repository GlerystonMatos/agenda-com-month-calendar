namespace Agenda
{
    partial class frmAgenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.CompromissosDoDia = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NovoCompromisso = new System.Windows.Forms.Button();
            this.relogio = new System.Windows.Forms.Timer(this.components);
            this.icone = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(18, 18);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 0;
            this.Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateChanged);
            // 
            // CompromissosDoDia
            // 
            this.CompromissosDoDia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.CompromissosDoDia.FullRowSelect = true;
            this.CompromissosDoDia.GridLines = true;
            this.CompromissosDoDia.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CompromissosDoDia.Location = new System.Drawing.Point(257, 18);
            this.CompromissosDoDia.Name = "CompromissosDoDia";
            this.CompromissosDoDia.Size = new System.Drawing.Size(400, 400);
            this.CompromissosDoDia.TabIndex = 1;
            this.CompromissosDoDia.UseCompatibleStateImageBehavior = false;
            this.CompromissosDoDia.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hora";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Descrição";
            this.columnHeader3.Width = 250;
            // 
            // NovoCompromisso
            // 
            this.NovoCompromisso.Location = new System.Drawing.Point(18, 192);
            this.NovoCompromisso.Name = "NovoCompromisso";
            this.NovoCompromisso.Size = new System.Drawing.Size(227, 23);
            this.NovoCompromisso.TabIndex = 2;
            this.NovoCompromisso.Text = "Novo compromisso";
            this.NovoCompromisso.UseVisualStyleBackColor = true;
            this.NovoCompromisso.Click += new System.EventHandler(this.NovoCompromisso_Click);
            // 
            // relogio
            // 
            this.relogio.Enabled = true;
            this.relogio.Tick += new System.EventHandler(this.relogio_Tick);
            // 
            // icone
            // 
            this.icone.Icon = ((System.Drawing.Icon)(resources.GetObject("icone.Icon")));
            this.icone.Text = "Agenda de Compromissos";
            this.icone.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.icone_MouseDoubleClick);
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 428);
            this.Controls.Add(this.NovoCompromisso);
            this.Controls.Add(this.CompromissosDoDia);
            this.Controls.Add(this.Calendario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de Compromissos";
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            this.Resize += new System.EventHandler(this.frmAgenda_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.ListView CompromissosDoDia;
        private System.Windows.Forms.Button NovoCompromisso;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Timer relogio;
        private System.Windows.Forms.NotifyIcon icone;
    }
}

