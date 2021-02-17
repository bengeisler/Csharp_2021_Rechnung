
namespace Csharp_2021_Rechnung
{
	partial class frmRechnung
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtBetrag = new System.Windows.Forms.TextBox();
			this.btnHinzufügen = new System.Windows.Forms.Button();
			this.lstBeträge = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblSumme = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSpeichern = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Betrag:";
			// 
			// txtBetrag
			// 
			this.txtBetrag.Location = new System.Drawing.Point(80, 17);
			this.txtBetrag.Name = "txtBetrag";
			this.txtBetrag.Size = new System.Drawing.Size(100, 20);
			this.txtBetrag.TabIndex = 1;
			this.txtBetrag.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBetrag_KeyDown);
			// 
			// btnHinzufügen
			// 
			this.btnHinzufügen.Location = new System.Drawing.Point(92, 43);
			this.btnHinzufügen.Name = "btnHinzufügen";
			this.btnHinzufügen.Size = new System.Drawing.Size(75, 23);
			this.btnHinzufügen.TabIndex = 2;
			this.btnHinzufügen.Text = "Hinzufügen";
			this.btnHinzufügen.UseVisualStyleBackColor = true;
			this.btnHinzufügen.Click += new System.EventHandler(this.btnHinzufügen_Click);
			// 
			// lstBeträge
			// 
			this.lstBeträge.FormattingEnabled = true;
			this.lstBeträge.Location = new System.Drawing.Point(80, 124);
			this.lstBeträge.Name = "lstBeträge";
			this.lstBeträge.Size = new System.Drawing.Size(100, 95);
			this.lstBeträge.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Rechnung:";
			// 
			// lblSumme
			// 
			this.lblSumme.AutoSize = true;
			this.lblSumme.Location = new System.Drawing.Point(39, 233);
			this.lblSumme.Name = "lblSumme";
			this.lblSumme.Size = new System.Drawing.Size(35, 13);
			this.lblSumme.TabIndex = 5;
			this.lblSumme.Text = "label3";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(186, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "EUR";
			// 
			// btnSpeichern
			// 
			this.btnSpeichern.Location = new System.Drawing.Point(92, 267);
			this.btnSpeichern.Name = "btnSpeichern";
			this.btnSpeichern.Size = new System.Drawing.Size(75, 23);
			this.btnSpeichern.TabIndex = 8;
			this.btnSpeichern.Text = "Speichern";
			this.btnSpeichern.UseVisualStyleBackColor = true;
			this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
			// 
			// frmRechnung
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(236, 305);
			this.Controls.Add(this.btnSpeichern);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblSumme);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lstBeträge);
			this.Controls.Add(this.btnHinzufügen);
			this.Controls.Add(this.txtBetrag);
			this.Controls.Add(this.label1);
			this.Name = "frmRechnung";
			this.Text = "Rechnung";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBetrag;
		private System.Windows.Forms.Button btnHinzufügen;
		private System.Windows.Forms.ListBox lstBeträge;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblSumme;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnSpeichern;
	}
}

