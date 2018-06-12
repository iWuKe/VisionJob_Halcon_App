using dotNetLab.Debug;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace 代码植入
{
    public partial class Form1 : Form
    {
        CodeEngine codeEngine;
        StringBuilder sbDecryptText = new StringBuilder();
      
        public Form1()
        {
            InitializeComponent();
            codeEngine = new CodeEngine();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(File.Exists("Config.txt"))
            {
                this.txb_dllPath.Text = File.ReadAllText("config.txt", Encoding.Default);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(String.IsNullOrEmpty(txb_dllPath.Text)|| String.IsNullOrEmpty(txb_Code.Text))
            {
                MessageBox.Show("安装文件路径或者代码文本框不能为空");
                return;
            }

            sbDecryptText.Clear();
            sbDecryptText.Append(codeEngine.Decrypt(txb_Code.Text));
            if (codeEngine.CompileDll(sbDecryptText.ToString(), Path.Combine(txb_dllPath.Text, codeEngine.SHIKII_DEBUG_DLL_NAME)) )
            {
                txb_ErrorInfo.Text = "已成功生成";
                MessageBox.Show("植入成功");
              
                
            }
            else
            {
                txb_ErrorInfo.Text = codeEngine.LastErrorInfo;
                MessageBox.Show("植入失败");
            }
               
        }

        private void btn_ViewPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
           if(fdb.ShowDialog()== DialogResult.OK)
            {
                File.WriteAllText("config.txt", fdb.SelectedPath, Encoding.Default);
                txb_dllPath.Text = fdb.SelectedPath;
            }
        }

        private void txb_Code_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData== (Keys.Alt|Keys.Right))
            {
                if(txb_Code.Text.Contains("}"))
                txb_Code.Text = codeEngine.Encrypt(txb_Code.Text);
            }
            if(e.KeyData == (Keys.Alt | Keys.Left))
            {
                if (!txb_Code.Text.Contains("}"))
                    txb_Code.Text = codeEngine.Decrypt(txb_Code.Text);
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
