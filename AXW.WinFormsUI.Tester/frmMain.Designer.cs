
namespace AXW.WinFormsUI.Tester
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new AXW.WinFormsUI.Controls.Button();
            this.button6 = new AXW.WinFormsUI.Controls.Button();
            this.button3 = new AXW.WinFormsUI.Controls.Button();
            this.button1 = new AXW.WinFormsUI.Controls.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.AutoEllipsis = true;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(325, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(365, 137);
            this.button2.TabIndex = 1;
            this.button2.Text = "&button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(484, 261);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BorderRadius = 100;
            this.button4.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button4.FocusColor = System.Drawing.Color.LightSkyBlue;
            this.button4.FocusVisible = true;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button4.GeneralStatesColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.button4.Location = new System.Drawing.Point(484, 93);
            this.button4.MakeTransparentCorners = true;
            this.button4.Name = "button4";
            this.button4.OnHoverState.BackColor = System.Drawing.Color.Silver;
            this.button4.OnHoverState.BorderColor = System.Drawing.Color.DarkGray;
            this.button4.OnHoverState.FontColor = System.Drawing.Color.Black;
            this.button4.OnIdleState.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.OnIdleState.BorderColor = System.Drawing.Color.DarkGray;
            this.button4.OnIdleState.FontColor = System.Drawing.Color.Black;
            this.button4.OnPressedState.BackColor = System.Drawing.Color.DarkGray;
            this.button4.OnPressedState.BorderColor = System.Drawing.Color.DarkGray;
            this.button4.OnPressedState.FontColor = System.Drawing.Color.Black;
            this.button4.Size = new System.Drawing.Size(286, 100);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            // 
            // button6
            // 
            this.button6.BorderRadius = 50;
            this.button6.Enabled = false;
            this.button6.FocusColor = System.Drawing.Color.LightSkyBlue;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button6.GeneralStatesColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.button6.Location = new System.Drawing.Point(353, 331);
            this.button6.Name = "button6";
            this.button6.OnHoverState.BackColor = System.Drawing.Color.Silver;
            this.button6.OnHoverState.BorderColor = System.Drawing.Color.DarkGray;
            this.button6.OnHoverState.FontColor = System.Drawing.Color.Black;
            this.button6.OnIdleState.BackColor = System.Drawing.Color.Gainsboro;
            this.button6.OnIdleState.BorderColor = System.Drawing.Color.DarkGray;
            this.button6.OnIdleState.FontColor = System.Drawing.Color.Red;
            this.button6.OnPressedState.BackColor = System.Drawing.Color.DarkGray;
            this.button6.OnPressedState.BorderColor = System.Drawing.Color.DarkGray;
            this.button6.OnPressedState.FontColor = System.Drawing.Color.Black;
            this.button6.Size = new System.Drawing.Size(110, 30);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            // 
            // button3
            // 
            this.button3.BorderRadius = 50;
            this.button3.BorderVisible = false;
            this.button3.FocusColor = System.Drawing.Color.LightSkyBlue;
            this.button3.FocusVisible = true;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button3.GeneralStatesColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.button3.Location = new System.Drawing.Point(158, 202);
            this.button3.Name = "button3";
            this.button3.OnHoverState.BackColor = System.Drawing.Color.Green;
            this.button3.OnHoverState.BorderColor = System.Drawing.Color.Empty;
            this.button3.OnHoverState.FontColor = System.Drawing.Color.White;
            this.button3.OnIdleState.BackColor = System.Drawing.Color.Tomato;
            this.button3.OnIdleState.BorderColor = System.Drawing.Color.Empty;
            this.button3.OnIdleState.FontColor = System.Drawing.Color.White;
            this.button3.OnPressedState.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.OnPressedState.BorderColor = System.Drawing.Color.DarkGray;
            this.button3.OnPressedState.FontColor = System.Drawing.Color.White;
            this.button3.Size = new System.Drawing.Size(110, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            // 
            // button1
            // 
            this.button1.FocusColor = System.Drawing.Color.Salmon;
            this.button1.FocusVisible = true;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.GeneralStatesColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.button1.Location = new System.Drawing.Point(131, 146);
            this.button1.Name = "button1";
            this.button1.OnHoverState.BackColor = System.Drawing.Color.Silver;
            this.button1.OnHoverState.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.OnHoverState.FontColor = System.Drawing.Color.Black;
            this.button1.OnIdleState.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.OnIdleState.BorderColor = System.Drawing.Color.DimGray;
            this.button1.OnIdleState.FontColor = System.Drawing.Color.Black;
            this.button1.OnPressedState.BackColor = System.Drawing.Color.DarkGray;
            this.button1.OnPressedState.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.OnPressedState.FontColor = System.Drawing.Color.Black;
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AXW.WinFormsUI.Tester";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private Controls.Button button1;
        private Controls.Button button3;
        private System.Windows.Forms.Button button5;
        private Controls.Button button6;
        private Controls.Button button4;
    }
}

