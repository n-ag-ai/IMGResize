namespace IMGResizer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.DD_textBox = new System.Windows.Forms.TextBox();
            this.start_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.width_radioButton = new System.Windows.Forms.RadioButton();
            this.heigh_radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resize_textBox = new System.Windows.Forms.TextBox();
            this.path_textBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.all_radioButton = new System.Windows.Forms.RadioButton();
            this.top_radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DD_textBox
            // 
            this.DD_textBox.Enabled = false;
            this.DD_textBox.ForeColor = System.Drawing.Color.DarkGray;
            this.DD_textBox.Location = new System.Drawing.Point(12, 12);
            this.DD_textBox.Multiline = true;
            this.DD_textBox.Name = "DD_textBox";
            this.DD_textBox.Size = new System.Drawing.Size(246, 194);
            this.DD_textBox.TabIndex = 0;
            this.DD_textBox.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nここにイメージファイルまたはフォルダをドラッグ";
            this.DD_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.start_button.Location = new System.Drawing.Point(264, 272);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(211, 56);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "START";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.width_radioButton);
            this.groupBox1.Controls.Add(this.heigh_radioButton);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 47);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "リサイズ基準辺";
            // 
            // width_radioButton
            // 
            this.width_radioButton.AutoSize = true;
            this.width_radioButton.Checked = true;
            this.width_radioButton.Location = new System.Drawing.Point(6, 18);
            this.width_radioButton.Name = "width_radioButton";
            this.width_radioButton.Size = new System.Drawing.Size(35, 16);
            this.width_radioButton.TabIndex = 1;
            this.width_radioButton.TabStop = true;
            this.width_radioButton.Text = "横";
            this.width_radioButton.UseVisualStyleBackColor = true;
            // 
            // heigh_radioButton
            // 
            this.heigh_radioButton.AutoSize = true;
            this.heigh_radioButton.Location = new System.Drawing.Point(52, 18);
            this.heigh_radioButton.Name = "heigh_radioButton";
            this.heigh_radioButton.Size = new System.Drawing.Size(35, 16);
            this.heigh_radioButton.TabIndex = 0;
            this.heigh_radioButton.Text = "縦";
            this.heigh_radioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.resize_textBox);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(111, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 47);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "変換後サイズ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "px";
            // 
            // resize_textBox
            // 
            this.resize_textBox.Location = new System.Drawing.Point(6, 17);
            this.resize_textBox.Name = "resize_textBox";
            this.resize_textBox.Size = new System.Drawing.Size(112, 19);
            this.resize_textBox.TabIndex = 0;
            // 
            // path_textBox
            // 
            this.path_textBox.Location = new System.Drawing.Point(264, 12);
            this.path_textBox.Multiline = true;
            this.path_textBox.Name = "path_textBox";
            this.path_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.path_textBox.Size = new System.Drawing.Size(211, 247);
            this.path_textBox.TabIndex = 4;
            this.path_textBox.WordWrap = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.all_radioButton);
            this.groupBox3.Controls.Add(this.top_radioButton);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(12, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 63);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "リサイズ範囲";
            // 
            // all_radioButton
            // 
            this.all_radioButton.AutoSize = true;
            this.all_radioButton.Location = new System.Drawing.Point(6, 40);
            this.all_radioButton.Name = "all_radioButton";
            this.all_radioButton.Size = new System.Drawing.Size(155, 16);
            this.all_radioButton.TabIndex = 1;
            this.all_radioButton.Text = "フォルダ配下すべてのファイル";
            this.all_radioButton.UseVisualStyleBackColor = true;
            // 
            // top_radioButton
            // 
            this.top_radioButton.AutoSize = true;
            this.top_radioButton.Checked = true;
            this.top_radioButton.Location = new System.Drawing.Point(6, 18);
            this.top_radioButton.Name = "top_radioButton";
            this.top_radioButton.Size = new System.Drawing.Size(103, 16);
            this.top_radioButton.TabIndex = 0;
            this.top_radioButton.TabStop = true;
            this.top_radioButton.Text = "フォルダ直下のみ";
            this.top_radioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(487, 340);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.path_textBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.DD_textBox);
            this.Name = "Form1";
            this.Text = "Resize";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.onDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.onEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DD_textBox;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton width_radioButton;
        private System.Windows.Forms.RadioButton heigh_radioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resize_textBox;
        private System.Windows.Forms.TextBox path_textBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton all_radioButton;
        private System.Windows.Forms.RadioButton top_radioButton;
    }
}

