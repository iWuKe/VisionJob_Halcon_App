using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using dotNetLab.Common.ModernUI;
using dotNetLab.Common;
using System.Threading;

namespace shikii.VisionJob
{
    public partial class MainForm : dotNetLab.Common.ModernUI.PageBase
    {
        private Button button1;
        private dotNetLab.Widgets.MobileTextBox mobileTextBox1;
        public dotNetLab.Widgets.MobileListBox mobileListBox1;

        protected override void prepareCtrls()
        {
            base.prepareCtrls();
            InitializeComponent();
           
           

            

        }
       
        private void InitializeComponent()
        {
            dotNetLab.Widgets.UIBinding.UIElementBinderInfo uiElementBinderInfo1 = new dotNetLab.Widgets.UIBinding.UIElementBinderInfo();
            this.mobileListBox1 = new dotNetLab.Widgets.MobileListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mobileTextBox1 = new dotNetLab.Widgets.MobileTextBox();
            this.SuspendLayout();
            // 
            // mobileListBox1
            // 
            this.mobileListBox1.BackColor = System.Drawing.Color.Transparent;
            this.mobileListBox1.BorderColor = System.Drawing.Color.Gray;
            this.mobileListBox1.BorderThickness = 1;
            this.mobileListBox1.CornerAlignment = dotNetLab.Widgets.Alignments.All;
            this.mobileListBox1.DataBindingInfo = null;
            this.mobileListBox1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.mobileListBox1.ImagePos = new System.Drawing.Point(0, 0);
            this.mobileListBox1.ImageSize = new System.Drawing.Size(0, 0);
            this.mobileListBox1.Location = new System.Drawing.Point(351, 65);
            this.mobileListBox1.MainBindableProperty = "mobileListBox1";
            this.mobileListBox1.Name = "mobileListBox1";
            this.mobileListBox1.NormalColor = System.Drawing.Color.White;
            this.mobileListBox1.Radius = -1;
            this.mobileListBox1.Size = new System.Drawing.Size(228, 411);
            this.mobileListBox1.Source = null;
            this.mobileListBox1.TabIndex = 2;
            this.mobileListBox1.Text = "mobileListBox1";
            this.mobileListBox1.UIElementBinders = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mobileTextBox1
            // 
            this.mobileTextBox1.ActiveColor = System.Drawing.Color.Orange;
            this.mobileTextBox1.BackColor = System.Drawing.Color.Transparent;
            uiElementBinderInfo1.DBEngineIndex = 0;
            uiElementBinderInfo1.EnableCheckBox_One_Zero = false;
            uiElementBinderInfo1.FieldName = "Val";
            uiElementBinderInfo1.Filter = "Name=\'{}\'";
            uiElementBinderInfo1.Ptr = null;
            uiElementBinderInfo1.StoreInDB = true;
            uiElementBinderInfo1.StoreIntoDBRealTime = true;
            uiElementBinderInfo1.TableName = "User_Key";
            uiElementBinderInfo1.ThisControl = this.mobileTextBox1;
            this.mobileTextBox1.DataBindingInfo = uiElementBinderInfo1;
            this.mobileTextBox1.DoubleValue = double.NaN;
            this.mobileTextBox1.EnableMobileRound = false;
            this.mobileTextBox1.EnableNullValue = false;
            this.mobileTextBox1.FillColor = System.Drawing.Color.Empty;
            this.mobileTextBox1.FloatValue = float.NaN;
            this.mobileTextBox1.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.mobileTextBox1.ForeColor = System.Drawing.Color.Black;
            this.mobileTextBox1.GreyPattern = false;
            this.mobileTextBox1.IntValue = -2147483648;
            this.mobileTextBox1.LineThickness = 2F;
            this.mobileTextBox1.Location = new System.Drawing.Point(113, 76);
            this.mobileTextBox1.MainBindableProperty = "mobileTextBox1";
            this.mobileTextBox1.Name = "mobileTextBox1";
            this.mobileTextBox1.Radius = -1;
            this.mobileTextBox1.Size = new System.Drawing.Size(150, 31);
            this.mobileTextBox1.StaticColor = System.Drawing.Color.DodgerBlue;
            this.mobileTextBox1.TabIndex = 4;
            this.mobileTextBox1.Text = "mobileTextBox1";
            this.mobileTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.mobileTextBox1.TextBackColor = System.Drawing.SystemColors.Window;
            this.mobileTextBox1.TextBoxStyle = dotNetLab.Widgets.MobileTextBox.TextBoxStyles.Mobile;
            this.mobileTextBox1.UIElementBinders = null;
            this.mobileTextBox1.WhitePattern = false;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.ClipboardText = "User_Key";
            this.Controls.Add(this.mobileTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mobileListBox1);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Controls.SetChildIndex(this.mobileListBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.mobileTextBox1, 0);
            this.ResumeLayout(false);

        }

        //启动日志显示窗体
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.Alt | Keys.O))
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                //ConsolePipe.Info("hahahsdffffffffffffffffffffffffffffffffffffffffffff");
                //ConsolePipe.Error("jiji");
              

            }
            ).Start();
            LogInForm frm = new LogInForm();
            frm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
