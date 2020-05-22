using System;
using System.IO;
using System.Windows.Forms;

namespace Pr10_WF
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void info(DirectoryInfo directory, FileInfo K1_file1, FileInfo K1_file2, FileInfo K2_file1)
		{
			string str = "";
			str += $"Directory '{directory.Name}'\n".ToUpper();
			str += $"Full Name: {directory.FullName}\n" +
								$"Name: {directory.Name}\n" +
								$"Creation: {directory.CreationTime}\n" +
								$"Attributes: {directory.Attributes}\n" +
								$"Root: {directory.Root}\n";
			str += $"File 't1'\n".ToUpper();
			str += $"Full Name: {K1_file1.FullName}\n" +
								$"Name: {K1_file1.Name}\n" +
								$"Extention:{K1_file1.Extension}\n" +
								$"Creation: {K1_file1.CreationTime}\n" +
								$"Attributes: {K1_file1.Attributes}\n";
			str += "File 't2'\n".ToUpper();
			str += $"Full Name: {K1_file2.FullName}\n" +
								$"Name: {K1_file2.Name}\n" +
								$"Extention:{K1_file2.Extension}\n" +
								$"Creation: {K1_file2.CreationTime}\n" +
								$"Attributes: {K1_file2.Attributes}\n";
			str += "File 't3'\n".ToUpper();
			str += $"Full Name: {K2_file1.FullName}\n" +
								$"Name: {K2_file1.Name}\n" +
								$"Extention:{K2_file1.Extension}\n" +
								$"Creation: {K2_file1.CreationTime}\n" +
								$"Attributes: {K2_file1.Attributes}\n";
			process_box.Text = str;
		}
		private void execute_button_Click(object sender, EventArgs e)
		{
			DirectoryInfo directory = new DirectoryInfo(@"C:\temp");
			directory.Create();
			directory.CreateSubdirectory("K1");
			directory.CreateSubdirectory("K2");
			FileInfo K1_file1 = new FileInfo(@"C:\temp\K1\t1.txt");
			using (StreamWriter sw = K1_file1.CreateText())
			{
				sw.WriteLine("Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");
			}
			FileInfo K1_file2 = new FileInfo(@"C:\temp\K1\t2.txt");
			using (StreamWriter sw = K1_file2.CreateText())
			{
				sw.WriteLine("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
			}
			FileInfo K2_file1 = new FileInfo(@"C:\temp\K2\t3.txt");
			string str = "", str2 = "";
			using (StreamReader sr = K1_file1.OpenText())
			{
				var s = "";
				while ((s = sr.ReadLine()) != null)
				{
					str += s;
				}
			}
			using (StreamReader sr = K1_file2.OpenText())
			{
				var s = "";
				while ((s = sr.ReadLine()) != null)
				{
					str2 += s;
				}
			}
			using (StreamWriter sw = K2_file1.CreateText())
			{
				sw.WriteLine(str + "\n" + str2);
			}
			info(directory, K1_file1, K1_file2, K2_file1);
			try
			{
				File.Move(@"C:\temp\K1\t2.txt", @"C:\temp\K2\t2.txt");
				K1_file1.CopyTo(@"C:\temp\K2\t1.txt");
				Directory.Delete(@"C:\temp\K1", true);
				Directory.Move(@"C:\temp\K2", @"C:\temp\All");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			DirectoryInfo AllDirectory = new DirectoryInfo(@"C:\temp\All");
			info(AllDirectory, K1_file1, K1_file2, K2_file1);
			try
			{
				System.Diagnostics.Process.Start(@"C:\temp\All");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
