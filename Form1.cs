using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;
using System.IO;

namespace VoiceGeneration
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			textPath_TextChanged(this, null);
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void generateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void dataGrid_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		private void dataGrid_DragDrop(object sender, DragEventArgs e)
		{
			string t_strData = (string)e.Data.GetData(DataFormats.Text);

			vAddData(t_strData);
		}

		private void button_listen_Click(object sender, EventArgs e)
		{
			if (dataGrid.SelectedRows.Count < 1) return;

			string t_strLine = dataGrid.SelectedRows[0].Cells[1].Value.ToString();

			SpeechSynthesizer t_synth = new SpeechSynthesizer();

			if (t_strLine.CompareTo("") != 0)
			{
				t_synth.SetOutputToDefaultAudioDevice();
				t_synth.Speak(t_strLine);
			}
		}

		private void dataGrid_SelectionChanged(object sender, EventArgs e)
		{
			btnPlay.Enabled = true;

			if (dataGrid.SelectedRows.Count < 1)
			{
				btnPlay.Enabled = false;
			}

			if (dataGrid.SelectedCells.Count < 2)
			{
				btnPlay.Enabled = false;
			}
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// enable all the components except the combo_character
			textRate.Enabled = true;
			textBPS.Enabled = true;
			textChannels.Enabled = true;

			btnPlay.Enabled = true;

			//combo_character.Items.Clear();
			//combo_character.Enabled = false;
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// TODO: make sure we at least have something loaded to save

			// if we've already saved this file before resave it, else prompt save
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// TODO: make sure we at least have something loaded to save

			// prompt save
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Progress t_progressForm = new Progress();
			t_progressForm.Show();

			List<string> m_aryLines = new List<string>();
			List<string> m_aryNames = new List<string>();

			DataGridViewRowCollection t_rows = dataGrid.Rows;

			foreach (DataGridViewRow t_row in t_rows)
			{
				if (t_row.Cells[0].Value == null || t_row.Cells[1].Value == null)
				{
					continue;
				}

				m_aryNames.Add(t_row.Cells[0].Value.ToString());
				m_aryLines.Add(t_row.Cells[1].Value.ToString());
			}

			int t_nRate = 41000;
			AudioBitsPerSample t_sample = AudioBitsPerSample.Sixteen;
			AudioChannel t_channel = AudioChannel.Stereo;

			if (textRate.Text.CompareTo("") == 0)
			{
				if (!Int32.TryParse(textRate.Text, out t_nRate))
				{
					return;
				}
			}

			if (textBPS.Text.CompareTo("") == 0)
			{
				int t_nSample = 0;

				if (Int32.TryParse(textBPS.Text, out t_nSample))
				{
					t_sample = (AudioBitsPerSample)t_nSample;
				}
				else
				{
					return;
				}
			}

			if (textChannels.Text.CompareTo("") == 0)
			{
				int t_nChannel = 0;

				if (Int32.TryParse(textChannels.Text, out t_nChannel))
				{
					t_channel = (AudioChannel)t_nChannel;
				}
			}

			t_progressForm.Generate(m_aryNames, m_aryLines, textPath.Text, t_nRate, t_sample, t_channel);
		}

		private void dataGrid_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
			{
				IDataObject t_dataClipboard = Clipboard.GetDataObject();
				string t_strData = (string)t_dataClipboard.GetData(DataFormats.Text);

				vAddData(t_strData);
			}
		}

		private void vAddData(string p_strData)
		{
			string[] t_aStrRows = p_strData.Split('\r');

			for (int t_i = 0; t_i < t_aStrRows.Length; ++t_i)
			{
				t_aStrRows[t_i] = t_aStrRows[t_i].Replace("\n", "");

				string[] t_aStrValues = t_aStrRows[t_i].Split('\t');

				if (t_aStrValues.Length >= 2)
				{
					dataGrid.Rows.Add(t_aStrValues[0], t_aStrValues[1]);
				}
			}
		}

		private void characterToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			DialogResult t_result = folderBrowser.ShowDialog();

			if (t_result == DialogResult.OK)
			{
				textPath.Text = folderBrowser.SelectedPath;
			}
		}

		private void textPath_TextChanged(object sender, EventArgs e)
		{
			bool t_fValid = true;

			// verify that the path exists
			if (!Directory.Exists(textPath.Text))
			{
				t_fValid = false;
			}

			btnGenerate.Enabled = t_fValid;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
