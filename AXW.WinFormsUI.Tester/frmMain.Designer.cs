
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
            this.button1 = new AXW.WinFormsUI.Controls.Button();
            this.button3 = new AXW.WinFormsUI.Controls.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BorderVisible = false;
            this.button1.FocusColor = System.Drawing.Color.Salmon;
            this.button1.FocusVisible = true;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(131, 146);
            this.button1.Name = "button1";
            this.button1.OnHoverState.BackColor = System.Drawing.Color.Silver;
            this.button1.OnHoverState.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.OnHoverState.FontColor = System.Drawing.Color.Black;
            this.button1.OnIdleState.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.OnIdleState.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.OnIdleState.FontColor = System.Drawing.Color.Black;
            this.button1.OnPressedState.BackColor = System.Drawing.Color.DarkGray;
            this.button1.OnPressedState.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.OnPressedState.FontColor = System.Drawing.Color.Black;
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BorderVisible = false;
            this.button3.FocusColor = System.Drawing.Color.LightSkyBlue;
            this.button3.FocusVisible = true;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button3.Location = new System.Drawing.Point(189, 182);
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
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AXW.WinFormsUI.Tester";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private Controls.Button button1;
        private Controls.Button button3;
    }
}

