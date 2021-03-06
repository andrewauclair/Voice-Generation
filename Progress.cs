﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;

namespace VoiceGeneration
{
	public partial class Progress : Form
	{
		public Progress()
		{
			InitializeComponent();
		}

		public void Generate(List<string> p_aryNames, List<string> p_aryLines, string p_strPath, int p_nRate, AudioBitsPerSample p_samples, AudioChannel p_channels)
		{
			SpeechAudioFormatInfo t_audioFormatInfo = new SpeechAudioFormatInfo(p_nRate, p_samples, p_channels);
			SpeechSynthesizer t_synth = new SpeechSynthesizer();
			
			progressBar1.Maximum = p_aryLines.Count;
			progressBar1.Step = 1;

			label1.Text = progressBar1.Step + "/" + p_aryNames.Count;

			for (int t_i = 0; t_i < p_aryNames.Count; ++t_i)
			{
				t_synth.SetOutputToWaveFile(p_strPath + "\\" + p_aryNames[t_i] + ".wav");
				t_synth.Speak(p_aryLines[t_i]);
		
				label1.Text = (t_i + 1) + "/" + p_aryLines.Count;
				progressBar1.PerformStep();
				progressBar1.Refresh();
			}

			t_synth.Dispose();

			Close();
		}
	}
}
