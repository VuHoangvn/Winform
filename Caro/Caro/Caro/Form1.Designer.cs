namespace Caro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnChessBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLAN = new System.Windows.Forms.Button();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.pbCountDown = new System.Windows.Forms.ProgressBar();
            this.txbPlayerName = new System.Windows.Forms.TextBox();
            this.pbMark = new System.Windows.Forms.PictureBox();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnChessBoard
            // 
            this.pnChessBoard.Location = new System.Drawing.Point(2, 1);
            this.pnChessBoard.Name = "pnChessBoard";
            this.pnChessBoard.Size = new System.Drawing.Size(598, 449);
            this.pnChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pbAvatar);
            this.panel2.Location = new System.Drawing.Point(606, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 261);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pbMark);
            this.panel3.Controls.Add(this.btnLAN);
            this.panel3.Controls.Add(this.txbIP);
            this.panel3.Controls.Add(this.pbCountDown);
            this.panel3.Controls.Add(this.txbPlayerName);
            this.panel3.Location = new System.Drawing.Point(606, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 182);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "5 in a line to win";
            // 
            // btnLAN
            // 
            this.btnLAN.Location = new System.Drawing.Point(3, 83);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(121, 23);
            this.btnLAN.TabIndex = 3;
            this.btnLAN.Text = "LAN";
            this.btnLAN.UseVisualStyleBackColor = true;
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(3, 57);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(121, 20);
            this.txbIP.TabIndex = 2;
            // 
            // pbCountDown
            // 
            this.pbCountDown.Location = new System.Drawing.Point(3, 29);
            this.pbCountDown.Name = "pbCountDown";
            this.pbCountDown.Size = new System.Drawing.Size(121, 22);
            this.pbCountDown.TabIndex = 1;
            // 
            // txbPlayerName
            // 
            this.txbPlayerName.Location = new System.Drawing.Point(3, 3);
            this.txbPlayerName.Name = "txbPlayerName";
            this.txbPlayerName.ReadOnly = true;
            this.txbPlayerName.Size = new System.Drawing.Size(121, 20);
            this.txbPlayerName.TabIndex = 0;
            // 
            // pbMark
            // 
            this.pbMark.Location = new System.Drawing.Point(130, 3);
            this.pbMark.Name = "pbMark";
            this.pbMark.Size = new System.Drawing.Size(131, 103);
            this.pbMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMark.TabIndex = 4;
            this.pbMark.TabStop = false;
            // 
            // pbAvatar
            // 
            this.pbAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAvatar.Image = global::Caro.Properties.Resources.download;
            this.pbAvatar.Location = new System.Drawing.Point(0, 0);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(261, 261);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 0;
            this.pbAvatar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnChessBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Game Caro LAN";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnChessBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.PictureBox pbMark;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.ProgressBar pbCountDown;
        private System.Windows.Forms.TextBox txbPlayerName;
        private System.Windows.Forms.Label label1;
    }
}

