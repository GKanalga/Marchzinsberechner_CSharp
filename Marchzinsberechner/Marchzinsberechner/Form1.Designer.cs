namespace Marchzinsberechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bestaetigungs_btn = new System.Windows.Forms.Button();
            this.kunde_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kunde_Guthaben = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.marchzins_txt = new System.Windows.Forms.TextBox();
            this.bonuszins_txt = new System.Windows.Forms.TextBox();
            this.geburtstags_m = new System.Windows.Forms.TrackBar();
            this.g_txt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gt_txt = new System.Windows.Forms.Label();
            this.geburtstags_t = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.geburtstags_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geburtstags_t)).BeginInit();
            this.SuspendLayout();
            // 
            // bestaetigungs_btn
            // 
            this.bestaetigungs_btn.Location = new System.Drawing.Point(339, 390);
            this.bestaetigungs_btn.Name = "bestaetigungs_btn";
            this.bestaetigungs_btn.Size = new System.Drawing.Size(167, 57);
            this.bestaetigungs_btn.TabIndex = 1;
            this.bestaetigungs_btn.Text = "Bestätigen";
            this.bestaetigungs_btn.UseVisualStyleBackColor = true;
            this.bestaetigungs_btn.Click += new System.EventHandler(this.bestaetigungs_btn_Click);
            // 
            // kunde_Name
            // 
            this.kunde_Name.Location = new System.Drawing.Point(252, 53);
            this.kunde_Name.Name = "kunde_Name";
            this.kunde_Name.Size = new System.Drawing.Size(157, 26);
            this.kunde_Name.TabIndex = 2;
            this.kunde_Name.TextChanged += new System.EventHandler(this.kunde_Name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name des Kundens:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Monat des Geburtstags:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // kunde_Guthaben
            // 
            this.kunde_Guthaben.Location = new System.Drawing.Point(252, 93);
            this.kunde_Guthaben.Name = "kunde_Guthaben";
            this.kunde_Guthaben.Size = new System.Drawing.Size(157, 26);
            this.kunde_Guthaben.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Guthaben des Kundens:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Marchzinssatz:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(433, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Prozentuale Erhöhung des Zinssatzes im Geburtstagmonat:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // marchzins_txt
            // 
            this.marchzins_txt.Location = new System.Drawing.Point(252, 131);
            this.marchzins_txt.Name = "marchzins_txt";
            this.marchzins_txt.Size = new System.Drawing.Size(157, 26);
            this.marchzins_txt.TabIndex = 12;
            // 
            // bonuszins_txt
            // 
            this.bonuszins_txt.Location = new System.Drawing.Point(451, 181);
            this.bonuszins_txt.Name = "bonuszins_txt";
            this.bonuszins_txt.Size = new System.Drawing.Size(157, 26);
            this.bonuszins_txt.TabIndex = 13;
            this.bonuszins_txt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // geburtstags_m
            // 
            this.geburtstags_m.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.geburtstags_m.Location = new System.Drawing.Point(252, 223);
            this.geburtstags_m.Maximum = 12;
            this.geburtstags_m.Minimum = 1;
            this.geburtstags_m.Name = "geburtstags_m";
            this.geburtstags_m.Size = new System.Drawing.Size(211, 69);
            this.geburtstags_m.TabIndex = 14;
            this.geburtstags_m.Value = 1;
            this.geburtstags_m.Scroll += new System.EventHandler(this.geburtstags_m_scroll);
            // 
            // g_txt
            // 
            this.g_txt.AutoSize = true;
            this.g_txt.Location = new System.Drawing.Point(203, 244);
            this.g_txt.Name = "g_txt";
            this.g_txt.Size = new System.Drawing.Size(18, 20);
            this.g_txt.TabIndex = 15;
            this.g_txt.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(316, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Dateneingabe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tag des Geburtstags:";
            // 
            // gt_txt
            // 
            this.gt_txt.AutoSize = true;
            this.gt_txt.Location = new System.Drawing.Point(206, 304);
            this.gt_txt.Name = "gt_txt";
            this.gt_txt.Size = new System.Drawing.Size(18, 20);
            this.gt_txt.TabIndex = 18;
            this.gt_txt.Text = "0";
            // 
            // geburtstags_t
            // 
            this.geburtstags_t.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.geburtstags_t.Location = new System.Drawing.Point(252, 294);
            this.geburtstags_t.Maximum = 30;
            this.geburtstags_t.Minimum = 1;
            this.geburtstags_t.Name = "geburtstags_t";
            this.geburtstags_t.Size = new System.Drawing.Size(211, 69);
            this.geburtstags_t.TabIndex = 19;
            this.geburtstags_t.Value = 1;
            this.geburtstags_t.Scroll += new System.EventHandler(this.geburtstags_t_scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.geburtstags_t);
            this.Controls.Add(this.gt_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.g_txt);
            this.Controls.Add(this.geburtstags_m);
            this.Controls.Add(this.bonuszins_txt);
            this.Controls.Add(this.marchzins_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kunde_Guthaben);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kunde_Name);
            this.Controls.Add(this.bestaetigungs_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.geburtstags_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geburtstags_t)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bestaetigungs_btn;
        private System.Windows.Forms.TextBox kunde_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kunde_Guthaben;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox marchzins_txt;
        private System.Windows.Forms.TextBox bonuszins_txt;
        private System.Windows.Forms.TrackBar geburtstags_m;
        private System.Windows.Forms.Label g_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label gt_txt;
        private System.Windows.Forms.TrackBar geburtstags_t;
    }
}

