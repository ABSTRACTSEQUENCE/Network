using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Network
{
	public partial class Form1 : Form
	{
		HttpClient client;
		HttpResponseMessage responce;
		enum ToSave{ all, unique}
		public Form1()
		{
			InitializeComponent();
			l_status.Text = "";
			client = new HttpClient();
			visibility(false);
		}
		void save(ToSave what)
		{
			using (SaveFileDialog sf = new SaveFileDialog())
			{
				sf.Filter = "Текстовые файлы (*.txt)|*.txt";
				//Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*
				sf.Title = "Сохранить";
				if (sf.ShowDialog() == DialogResult.OK)
				{
					if (!sf.CheckPathExists) MessageBox.Show("Невозможно сохранить файл с пустым именем");
					if(what == ToSave.all)
						System.IO.File.WriteAllText(sf.FileName, responce.Content.ReadAsStringAsync().Result);
					MessageBox.Show("Данные сохранены в файле");
				}	
			}

		}
		void visibility(bool on)
		{
			if (on) { uniqueTags.Enabled = true; countTags.Enabled = true; ReadAll.Enabled = true; save_all.Enabled = true; save_unique.Enabled = true; }
			else { uniqueTags.Enabled = false; countTags.Enabled = false; ReadAll.Enabled = false; save_all.Enabled = false; save_unique.Enabled = false; }
		}
		async void count()
		{
			tb_content.Text = "";
			int counter = 0;
			string str = responce.Content.ReadAsStringAsync().Result;
			Task<string> t = new Task<string>(() => { foreach (char i in str) { if (i == '<') counter++; } return counter.ToString(); });
			t.Start();
			tb_content.Text = "Общее количество тегов: " + await t;
		}
		void unique()
		{
			//Теги выводит, надо поработать над красивым выводом, чтоб выводил именно как теги (с < и >)
			tb_content.Text = "";
			new Task(() => 
			{
				BeginInvoke(new Action(() => { l_status.Text = "Processing..."; }));
				System.Collections.Generic.List<string> buffer = new System.Collections.Generic.List<string>();
				//string buffer = responce.Content.ReadAsStringAsync().Result;
				
				foreach (string str in responce.Content.ReadAsStringAsync().Result.Split(new char[] { '<', '>'}, StringSplitOptions.RemoveEmptyEntries)) 
				{
					BeginInvoke(new Action(()=> { l_status.Text = "Буферизация строки..."; }));
					if(!str.Contains("\n")) buffer.Add(str);
				}
				for (int i = 1; i < buffer.Count; i++)
				{
					//new Task(() => { while (i != buffer.Count) BeginInvoke(new Action(() => { l_status.Text = "Форматирование строки..." + i + '/' + buffer.Count; })); }).Start();
					if(buffer[i].Contains("=")) buffer[i] = buffer[i].Remove(buffer[i].IndexOf('='), buffer[i].Substring(buffer[i].IndexOf('=')).Length) + '>';
					//buffer[i] += '>'; buffer.Insert(i, "<");
				}
				for (int i = 0; i < buffer.Count; i++)
				{
					buffer.RemoveAll((string s) => { return s == buffer[i]; });
				}
				//buffer.RemoveAll((string s) => { return s.Contains("\n"); });

				//responce.Remove(responce.IndexOf('='),responce.Substring(responce.IndexOf('=')).Length) + '>'
				BeginInvoke(new Action(()=> { for (int i = 0; i < buffer.Count - 1; i++){ tb_content.Text += i + ") " + buffer[i] + Environment.NewLine;}}));
				BeginInvoke(new Action(() => { l_status.Text = "Done";}));
				//sleep 1000 text = ""
			}).Start();
		}

		private void bt_ok_Click(object sender, EventArgs e)
		{
			try {
				new Task(() =>
				{
					BeginInvoke(new Action(() => { l_status.Text = "Getting data"; }));
					responce = client.GetAsync(tb_uri.Text).Result;
					BeginInvoke(new Action(() => { l_status.Text = "Data aquired"; }));
					System.Threading.Thread.Sleep(1000);
					BeginInvoke(new Action(() => { l_status.Text = ""; visibility(true); }));
				}).Start();
				bt_ok.Enabled = false;
			}
			catch (System.UriFormatException) { MessageBox.Show("Неправильный URI", "Ошибка"); }
		}

		private void countTags_Click(object sender, EventArgs e){ count(); }

		private void uniqueTags_Click(object sender, EventArgs e){ unique(); }

		private void save_all_Click(object sender, EventArgs e){ save(ToSave.all); }

		private void ReadAll_Click(object sender, EventArgs e) { tb_content.Text = responce.Content.ReadAsStringAsync().Result; }
	}
}
