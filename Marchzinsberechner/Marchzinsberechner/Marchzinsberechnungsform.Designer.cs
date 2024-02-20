namespace Marchzinsberechner
{
    partial class Marchzinsberechnungsform
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tagvon = new System.Windows.Forms.TrackBar();
            this.tagbis = new System.Windows.Forms.TrackBar();
            this.tagvon_txt = new System.Windows.Forms.Label();
            this.tagbis_txt = new System.Windows.Forms.Label();
            this.monatvon = new System.Windows.Forms.TrackBar();
            this.monatvon_txt = new System.Windows.Forms.Label();
            this.monatbis = new System.Windows.Forms.TrackBar();
            this.monatbis_txt = new System.Windows.Forms.Label();
            this.Berechne_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tagvon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagbis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monatvon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monatbis)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zeitraum auswählen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "von";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "bis";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tagvon
            // 
            this.tagvon.Location = new System.Drawing.Point(109, 242);
            this.tagvon.Maximum = 30;
            this.tagvon.Minimum = 1;
            this.tagvon.Name = "tagvon";
            this.tagvon.Size = new System.Drawing.Size(248, 69);
            this.tagvon.TabIndex = 5;
            this.tagvon.Value = 1;
            this.tagvon.Scroll += new System.EventHandler(this.vontag_scroll);
            // 
            // tagbis
            // 
            this.tagbis.Location = new System.Drawing.Point(493, 242);
            this.tagbis.Maximum = 30;
            this.tagbis.Minimum = 1;
            this.tagbis.Name = "tagbis";
            this.tagbis.Size = new System.Drawing.Size(240, 69);
            this.tagbis.TabIndex = 6;
            this.tagbis.Value = 1;
            this.tagbis.Scroll += new System.EventHandler(this.bistag_scroll);
            // 
            // tagvon_txt
            // 
            this.tagvon_txt.AutoSize = true;
            this.tagvon_txt.Location = new System.Drawing.Point(363, 251);
            this.tagvon_txt.Name = "tagvon_txt";
            this.tagvon_txt.Size = new System.Drawing.Size(53, 20);
            this.tagvon_txt.TabIndex = 7;
            this.tagvon_txt.Text = "Tag: 0";
            // 
            // tagbis_txt
            // 
            this.tagbis_txt.AutoSize = true;
            this.tagbis_txt.Location = new System.Drawing.Point(735, 251);
            this.tagbis_txt.Name = "tagbis_txt";
            this.tagbis_txt.Size = new System.Drawing.Size(53, 20);
            this.tagbis_txt.TabIndex = 8;
            this.tagbis_txt.Text = "Tag: 0";
            // 
            // monatvon
            // 
            this.monatvon.Location = new System.Drawing.Point(109, 294);
            this.monatvon.Maximum = 12;
            this.monatvon.Minimum = 1;
            this.monatvon.Name = "monatvon";
            this.monatvon.Size = new System.Drawing.Size(248, 69);
            this.monatvon.TabIndex = 9;
            this.monatvon.Value = 1;
            this.monatvon.Scroll += new System.EventHandler(this.vonmonat_scroll);
            // 
            // monatvon_txt
            // 
            this.monatvon_txt.AutoSize = true;
            this.monatvon_txt.Location = new System.Drawing.Point(363, 294);
            this.monatvon_txt.Name = "monatvon_txt";
            this.monatvon_txt.Size = new System.Drawing.Size(71, 20);
            this.monatvon_txt.TabIndex = 10;
            this.monatvon_txt.Text = "Monat: 0";
            // 
            // monatbis
            // 
            this.monatbis.Location = new System.Drawing.Point(493, 294);
            this.monatbis.Maximum = 12;
            this.monatbis.Minimum = 1;
            this.monatbis.Name = "monatbis";
            this.monatbis.Size = new System.Drawing.Size(240, 69);
            this.monatbis.TabIndex = 11;
            this.monatbis.Value = 1;
            this.monatbis.Scroll += new System.EventHandler(this.bismonat_scroll);
            // 
            // monatbis_txt
            // 
            this.monatbis_txt.AutoSize = true;
            this.monatbis_txt.Location = new System.Drawing.Point(735, 294);
            this.monatbis_txt.Name = "monatbis_txt";
            this.monatbis_txt.Size = new System.Drawing.Size(71, 20);
            this.monatbis_txt.TabIndex = 12;
            this.monatbis_txt.Text = "Monat: 0";
            // 
            // Berechne_btn
            // 
            this.Berechne_btn.Location = new System.Drawing.Point(344, 357);
            this.Berechne_btn.Name = "Berechne_btn";
            this.Berechne_btn.Size = new System.Drawing.Size(159, 43);
            this.Berechne_btn.TabIndex = 13;
            this.Berechne_btn.Text = "Berechnen";
            this.Berechne_btn.UseVisualStyleBackColor = true;
            this.Berechne_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(261, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(324, 37);
            this.label9.TabIndex = 14;
            this.label9.Text = "Marchzinsberechner";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "Jahreszins Anzeigen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Marchzinsberechnungsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Berechne_btn);
            this.Controls.Add(this.monatbis_txt);
            this.Controls.Add(this.monatbis);
            this.Controls.Add(this.monatvon_txt);
            this.Controls.Add(this.monatvon);
            this.Controls.Add(this.tagbis_txt);
            this.Controls.Add(this.tagvon_txt);
            this.Controls.Add(this.tagbis);
            this.Controls.Add(this.tagvon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Marchzinsberechnungsform";
            this.Text = "Marchzinsberechnungsform";
            ((System.ComponentModel.ISupportInitialize)(this.tagvon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagbis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monatvon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monatbis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tagvon;
        private System.Windows.Forms.TrackBar tagbis;
        private System.Windows.Forms.Label tagvon_txt;
        private System.Windows.Forms.Label tagbis_txt;
        private System.Windows.Forms.TrackBar monatvon;
        private System.Windows.Forms.Label monatvon_txt;
        private System.Windows.Forms.TrackBar monatbis;
        private System.Windows.Forms.Label monatbis_txt;
        private System.Windows.Forms.Button Berechne_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}