namespace RockPaperScissors
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ComputerOutput = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PlayerOutput = new System.Windows.Forms.PictureBox();
            this.roundText = new System.Windows.Forms.Label();
            this.PaperButton = new CustomControls.RJControls.RJButton();
            this.RockButton = new CustomControls.RJControls.RJButton();
            this.ScissorsButton = new CustomControls.RJControls.RJButton();
            this.computerScoreboard = new CustomControls.RJControls.RJButton();
            this.playerScoreboard = new CustomControls.RJControls.RJButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.roundText, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 550);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.Controls.Add(this.ComputerOutput, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.pictureBox4, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(503, 168);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(494, 269);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // ComputerOutput
            // 
            this.ComputerOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComputerOutput.Image = global::RockPaperScissors.Properties.Resources.scissors;
            this.ComputerOutput.Location = new System.Drawing.Point(72, 34);
            this.ComputerOutput.Name = "ComputerOutput";
            this.ComputerOutput.Size = new System.Drawing.Size(200, 200);
            this.ComputerOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ComputerOutput.TabIndex = 1;
            this.ComputerOutput.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = global::RockPaperScissors.Properties.Resources.artificial_intelligence;
            this.pictureBox4.Location = new System.Drawing.Point(379, 94);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.32667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33667F));
            this.tableLayoutPanel2.Controls.Add(this.PaperButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.RockButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ScissorsButton, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 443);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(494, 104);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 49);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Image = global::RockPaperScissors.Properties.Resources.close;
            this.CloseButton.Location = new System.Drawing.Point(955, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 44);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 4;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Fugaz One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(66, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rock Paper Scissors";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::RockPaperScissors.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(19, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 104);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.computerScoreboard, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.playerScoreboard, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(994, 104);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // label2
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Fugaz One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(988, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Score";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.PlayerOutput, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 168);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(494, 269);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::RockPaperScissors.Properties.Resources.athlete;
            this.pictureBox2.Location = new System.Drawing.Point(34, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // PlayerOutput
            // 
            this.PlayerOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerOutput.Image = global::RockPaperScissors.Properties.Resources.stone;
            this.PlayerOutput.Location = new System.Drawing.Point(221, 34);
            this.PlayerOutput.Name = "PlayerOutput";
            this.PlayerOutput.Size = new System.Drawing.Size(200, 200);
            this.PlayerOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerOutput.TabIndex = 1;
            this.PlayerOutput.TabStop = false;
            // 
            // roundText
            // 
            this.roundText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundText.Font = new System.Drawing.Font("Fugaz One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roundText.Location = new System.Drawing.Point(532, 483);
            this.roundText.Name = "roundText";
            this.roundText.Size = new System.Drawing.Size(436, 24);
            this.roundText.TabIndex = 5;
            this.roundText.Text = "Choose Rock, Paper or Scissors and Start the Game...";
            this.roundText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PaperButton
            // 
            this.PaperButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PaperButton.BackColor = System.Drawing.Color.Transparent;
            this.PaperButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.PaperButton.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.PaperButton.BorderRadius = 20;
            this.PaperButton.BorderSize = 2;
            this.PaperButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaperButton.FlatAppearance.BorderSize = 0;
            this.PaperButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PaperButton.ForeColor = System.Drawing.Color.Transparent;
            this.PaperButton.Image = global::RockPaperScissors.Properties.Resources.paper64;
            this.PaperButton.Location = new System.Drawing.Point(196, 20);
            this.PaperButton.Name = "PaperButton";
            this.PaperButton.Size = new System.Drawing.Size(100, 64);
            this.PaperButton.TabIndex = 4;
            this.PaperButton.TextColor = System.Drawing.Color.Transparent;
            this.PaperButton.UseVisualStyleBackColor = false;
            this.PaperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // RockButton
            // 
            this.RockButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RockButton.BackColor = System.Drawing.Color.Transparent;
            this.RockButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.RockButton.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.RockButton.BorderRadius = 20;
            this.RockButton.BorderSize = 2;
            this.RockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RockButton.FlatAppearance.BorderSize = 0;
            this.RockButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RockButton.ForeColor = System.Drawing.Color.Transparent;
            this.RockButton.Image = global::RockPaperScissors.Properties.Resources.stone64;
            this.RockButton.Location = new System.Drawing.Point(32, 20);
            this.RockButton.Name = "RockButton";
            this.RockButton.Padding = new System.Windows.Forms.Padding(2);
            this.RockButton.Size = new System.Drawing.Size(100, 64);
            this.RockButton.TabIndex = 3;
            this.RockButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RockButton.TextColor = System.Drawing.Color.Transparent;
            this.RockButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RockButton.UseVisualStyleBackColor = false;
            this.RockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // ScissorsButton
            // 
            this.ScissorsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScissorsButton.BackColor = System.Drawing.Color.Transparent;
            this.ScissorsButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.ScissorsButton.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ScissorsButton.BorderRadius = 20;
            this.ScissorsButton.BorderSize = 2;
            this.ScissorsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScissorsButton.FlatAppearance.BorderSize = 0;
            this.ScissorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ScissorsButton.ForeColor = System.Drawing.Color.Transparent;
            this.ScissorsButton.Image = global::RockPaperScissors.Properties.Resources.scissors64;
            this.ScissorsButton.Location = new System.Drawing.Point(361, 20);
            this.ScissorsButton.Name = "ScissorsButton";
            this.ScissorsButton.Size = new System.Drawing.Size(100, 64);
            this.ScissorsButton.TabIndex = 2;
            this.ScissorsButton.TextColor = System.Drawing.Color.Transparent;
            this.ScissorsButton.UseVisualStyleBackColor = false;
            this.ScissorsButton.Click += new System.EventHandler(this.ScissorsButton_Click);
            // 
            // computerScoreboard
            // 
            this.computerScoreboard.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.computerScoreboard.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.computerScoreboard.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.computerScoreboard.BorderRadius = 20;
            this.computerScoreboard.BorderSize = 0;
            this.computerScoreboard.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.computerScoreboard.FlatAppearance.BorderSize = 0;
            this.computerScoreboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.computerScoreboard.Font = new System.Drawing.Font("Fugaz One", 12F);
            this.computerScoreboard.ForeColor = System.Drawing.Color.White;
            this.computerScoreboard.Location = new System.Drawing.Point(507, 36);
            this.computerScoreboard.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.computerScoreboard.Name = "computerScoreboard";
            this.computerScoreboard.Size = new System.Drawing.Size(70, 40);
            this.computerScoreboard.TabIndex = 6;
            this.computerScoreboard.Text = "0";
            this.computerScoreboard.TextColor = System.Drawing.Color.White;
            this.computerScoreboard.UseVisualStyleBackColor = false;
            // 
            // playerScoreboard
            // 
            this.playerScoreboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerScoreboard.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.playerScoreboard.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.playerScoreboard.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.playerScoreboard.BorderRadius = 20;
            this.playerScoreboard.BorderSize = 0;
            this.playerScoreboard.FlatAppearance.BorderSize = 0;
            this.playerScoreboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playerScoreboard.Font = new System.Drawing.Font("Fugaz One", 12F);
            this.playerScoreboard.ForeColor = System.Drawing.Color.White;
            this.playerScoreboard.Location = new System.Drawing.Point(417, 36);
            this.playerScoreboard.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.playerScoreboard.Name = "playerScoreboard";
            this.playerScoreboard.Size = new System.Drawing.Size(70, 40);
            this.playerScoreboard.TabIndex = 5;
            this.playerScoreboard.Text = "0";
            this.playerScoreboard.TextColor = System.Drawing.Color.White;
            this.playerScoreboard.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComputerOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private CustomControls.RJControls.RJButton computerScoreboard;
        private CustomControls.RJControls.RJButton playerScoreboard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox ComputerOutput;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PlayerOutput;
        private CustomControls.RJControls.RJButton PaperButton;
        private CustomControls.RJControls.RJButton RockButton;
        private CustomControls.RJControls.RJButton ScissorsButton;
        private System.Windows.Forms.Label roundText;
    }
}

