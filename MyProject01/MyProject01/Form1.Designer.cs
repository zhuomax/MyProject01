namespace MyProject01
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.jieguo = new System.Windows.Forms.Panel();
            this.shuru = new System.Windows.Forms.Panel();
            this.fuhao = new System.Windows.Forms.Panel();
            this.jia = new System.Windows.Forms.Button();
            this.jian = new System.Windows.Forms.Button();
            this.cheng = new System.Windows.Forms.Button();
            this.chu = new System.Windows.Forms.Button();
            this.deng = new System.Windows.Forms.Button();
            this.diyigeshu = new System.Windows.Forms.TextBox();
            this.diergeshu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.jieguo.SuspendLayout();
            this.shuru.SuspendLayout();
            this.fuhao.SuspendLayout();
            this.SuspendLayout();
            // 
            // jieguo
            // 
            this.jieguo.Controls.Add(this.label1);
            this.jieguo.Location = new System.Drawing.Point(12, 12);
            this.jieguo.Name = "jieguo";
            this.jieguo.Size = new System.Drawing.Size(517, 183);
            this.jieguo.TabIndex = 0;
            this.jieguo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // shuru
            // 
            this.shuru.Controls.Add(this.diergeshu);
            this.shuru.Controls.Add(this.diyigeshu);
            this.shuru.Location = new System.Drawing.Point(12, 221);
            this.shuru.Name = "shuru";
            this.shuru.Size = new System.Drawing.Size(517, 200);
            this.shuru.TabIndex = 1;
            // 
            // fuhao
            // 
            this.fuhao.Controls.Add(this.deng);
            this.fuhao.Controls.Add(this.chu);
            this.fuhao.Controls.Add(this.cheng);
            this.fuhao.Controls.Add(this.jian);
            this.fuhao.Controls.Add(this.jia);
            this.fuhao.Location = new System.Drawing.Point(582, 12);
            this.fuhao.Name = "fuhao";
            this.fuhao.Size = new System.Drawing.Size(200, 409);
            this.fuhao.TabIndex = 2;
            // 
            // jia
            // 
            this.jia.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jia.Location = new System.Drawing.Point(58, 3);
            this.jia.Name = "jia";
            this.jia.Size = new System.Drawing.Size(92, 50);
            this.jia.TabIndex = 0;
            this.jia.Text = "+";
            this.jia.UseVisualStyleBackColor = true;
            this.jia.Click += new System.EventHandler(this.jia_Click);
            // 
            // jian
            // 
            this.jian.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jian.Location = new System.Drawing.Point(58, 70);
            this.jian.Name = "jian";
            this.jian.Size = new System.Drawing.Size(92, 50);
            this.jian.TabIndex = 1;
            this.jian.Text = "-";
            this.jian.UseVisualStyleBackColor = true;
            this.jian.Click += new System.EventHandler(this.jian_Click);
            // 
            // cheng
            // 
            this.cheng.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cheng.Location = new System.Drawing.Point(58, 142);
            this.cheng.Name = "cheng";
            this.cheng.Size = new System.Drawing.Size(92, 50);
            this.cheng.TabIndex = 2;
            this.cheng.Text = "*";
            this.cheng.UseVisualStyleBackColor = true;
            this.cheng.Click += new System.EventHandler(this.cheng_Click);
            // 
            // chu
            // 
            this.chu.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chu.Location = new System.Drawing.Point(58, 209);
            this.chu.Name = "chu";
            this.chu.Size = new System.Drawing.Size(92, 50);
            this.chu.TabIndex = 3;
            this.chu.Text = "/";
            this.chu.UseVisualStyleBackColor = true;
            this.chu.Click += new System.EventHandler(this.chu_Click);
            // 
            // deng
            // 
            this.deng.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deng.Location = new System.Drawing.Point(58, 320);
            this.deng.Name = "deng";
            this.deng.Size = new System.Drawing.Size(92, 50);
            this.deng.TabIndex = 4;
            this.deng.Text = "=";
            this.deng.UseVisualStyleBackColor = true;
            // 
            // diyigeshu
            // 
            this.diyigeshu.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.diyigeshu.Location = new System.Drawing.Point(62, 35);
            this.diyigeshu.Name = "diyigeshu";
            this.diyigeshu.Size = new System.Drawing.Size(355, 42);
            this.diyigeshu.TabIndex = 0;
            // 
            // diergeshu
            // 
            this.diergeshu.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.diergeshu.Location = new System.Drawing.Point(62, 111);
            this.diergeshu.Name = "diergeshu";
            this.diergeshu.Size = new System.Drawing.Size(355, 42);
            this.diergeshu.TabIndex = 1;
            this.diergeshu.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(66, 69);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(158, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "result";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fuhao);
            this.Controls.Add(this.shuru);
            this.Controls.Add(this.jieguo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.jieguo.ResumeLayout(false);
            this.jieguo.PerformLayout();
            this.shuru.ResumeLayout(false);
            this.shuru.PerformLayout();
            this.fuhao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel jieguo;
        private System.Windows.Forms.Panel shuru;
        private System.Windows.Forms.TextBox diergeshu;
        private System.Windows.Forms.TextBox diyigeshu;
        private System.Windows.Forms.Panel fuhao;
        private System.Windows.Forms.Button deng;
        private System.Windows.Forms.Button chu;
        private System.Windows.Forms.Button cheng;
        private System.Windows.Forms.Button jian;
        private System.Windows.Forms.Button jia;
        private System.Windows.Forms.Label label1;
    }
}

