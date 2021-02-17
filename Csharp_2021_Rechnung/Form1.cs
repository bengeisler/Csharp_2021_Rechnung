using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Csharp_2021_Rechnung
{
	public partial class frmRechnung : Form
	{
		// Globale Variable für die Summe anlegen
		private double Summe;
		public frmRechnung()
		{
			InitializeComponent();
		}

		private void btnSpeichern_Click(object sender, EventArgs e)
		{
			try
			{
				var sfd = new SaveFileDialog()
				{
					InitialDirectory = "C:\\temp",
					FileName = "Rechnung.txt",
					Filter = "Texte (*.txt; *.docx)|*.txt; *.docx",
					Title = "Datei zum Speichern auswählen"
				};

				// Abbruch, falls Benutzer abbricht
				if (sfd.ShowDialog() != DialogResult.OK) return;

				// Filestream zum Schreiben der Datei erstellen
				FileStream fs = new FileStream(sfd.FileName, FileMode.Create);

				StreamWriter sw = new StreamWriter(fs);

				sw.WriteLine("Rechnung:");
				sw.WriteLine("------------------");
				foreach (var item in lstBeträge.Items)
				{
					sw.WriteLine(item);
				}
				sw.WriteLine("------------------");
				sw.WriteLine(lblSumme.Text);

				sw.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnHinzufügen_Click(object sender, EventArgs e)
		{
			try
			{
				// Eingabe auf gültige Zahl überprüft und in double konvertiert
				// falls keine gültige Zahl : Fehlermeldung wird ausgegeben (über Exception), 
				// Abbruch der Funktion
				if (!double.TryParse(txtBetrag.Text, out double betrag))
					throw new ArgumentException("Bitte gültige Zahl eingeben!");

				// Betrag der Listbox in der richtigen Formatierung hinzufügen
				lstBeträge.Items.Add($"{betrag:##.00} EUR");

				// Gesamtsumme aktualisieren
				Summe += betrag;

				// Summe anzeigen
				lblSumme.Text = "Summe: " + $"{Summe:##.00} EUR";

				// Eingabetextfeld leeren & Fokus setzen
				txtBetrag.Text = "";
				txtBetrag.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void txtBetrag_KeyDown(object sender, KeyEventArgs e)
		{
			// Prüfen, ob "Enter" gedrückt wurde
			if (e.KeyCode == Keys.Enter)
			{
				// Ton unterdrücken
				e.SuppressKeyPress = true;

				// Ereignismethode für btnHinzufügen_Click aufrufen 
				btnHinzufügen_Click(sender, e);
			}
		}
	}
}
