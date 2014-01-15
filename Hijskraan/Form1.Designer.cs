namespace Hijskraan
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
            this.components = new System.ComponentModel.Container();
            this.ConnectRechts = new System.Windows.Forms.Button();
            this.connectLinksButton = new System.Windows.Forms.Button();
            this.ComLinksBox = new System.Windows.Forms.ComboBox();
            this.ComRechtsBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.achteruitButton = new System.Windows.Forms.Button();
            this.vooruitButton = new System.Windows.Forms.Button();
            this.openneerButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.statusLabelLinks = new System.Windows.Forms.Label();
            this.statusLabelRechts = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Timer(this.components);
            this.rescanButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnectRechts
            // 
            this.ConnectRechts.Location = new System.Drawing.Point(206, 37);
            this.ConnectRechts.Name = "ConnectRechts";
            this.ConnectRechts.Size = new System.Drawing.Size(152, 23);
            this.ConnectRechts.TabIndex = 0;
            this.ConnectRechts.Text = "Connect";
            this.ConnectRechts.UseVisualStyleBackColor = true;
            this.ConnectRechts.Click += new System.EventHandler(this.ConnectRechts_Click);
            // 
            // connectLinksButton
            // 
            this.connectLinksButton.Location = new System.Drawing.Point(206, 12);
            this.connectLinksButton.Name = "connectLinksButton";
            this.connectLinksButton.Size = new System.Drawing.Size(152, 23);
            this.connectLinksButton.TabIndex = 1;
            this.connectLinksButton.Text = "Connect";
            this.connectLinksButton.UseVisualStyleBackColor = true;
            this.connectLinksButton.Click += new System.EventHandler(this.ConnectLinks_Click);
            // 
            // ComLinksBox
            // 
            this.ComLinksBox.FormattingEnabled = true;
            this.ComLinksBox.Location = new System.Drawing.Point(79, 12);
            this.ComLinksBox.Name = "ComLinksBox";
            this.ComLinksBox.Size = new System.Drawing.Size(121, 21);
            this.ComLinksBox.TabIndex = 2;
            // 
            // ComRechtsBox
            // 
            this.ComRechtsBox.FormattingEnabled = true;
            this.ComRechtsBox.Location = new System.Drawing.Point(79, 39);
            this.ComRechtsBox.Name = "ComRechtsBox";
            this.ComRechtsBox.Size = new System.Drawing.Size(121, 21);
            this.ComRechtsBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Motor links";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Motor rechts";
            // 
            // achteruitButton
            // 
            this.achteruitButton.Location = new System.Drawing.Point(15, 85);
            this.achteruitButton.Name = "achteruitButton";
            this.achteruitButton.Size = new System.Drawing.Size(75, 23);
            this.achteruitButton.TabIndex = 6;
            this.achteruitButton.Text = "Achteruit";
            this.achteruitButton.UseVisualStyleBackColor = true;
            this.achteruitButton.Click += new System.EventHandler(this.achteruitButton_Click);
            // 
            // vooruitButton
            // 
            this.vooruitButton.Location = new System.Drawing.Point(15, 114);
            this.vooruitButton.Name = "vooruitButton";
            this.vooruitButton.Size = new System.Drawing.Size(75, 23);
            this.vooruitButton.TabIndex = 7;
            this.vooruitButton.Text = "Vooruit";
            this.vooruitButton.UseVisualStyleBackColor = true;
            this.vooruitButton.Click += new System.EventHandler(this.vooruitButton_Click);
            // 
            // openneerButton
            // 
            this.openneerButton.Location = new System.Drawing.Point(15, 143);
            this.openneerButton.Name = "openneerButton";
            this.openneerButton.Size = new System.Drawing.Size(75, 23);
            this.openneerButton.TabIndex = 8;
            this.openneerButton.Text = "Op en neer";
            this.openneerButton.UseVisualStyleBackColor = true;
            this.openneerButton.Click += new System.EventHandler(this.openneerButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Delay";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(15, 171);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 11;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // statusLabelLinks
            // 
            this.statusLabelLinks.AutoSize = true;
            this.statusLabelLinks.Location = new System.Drawing.Point(364, 20);
            this.statusLabelLinks.Name = "statusLabelLinks";
            this.statusLabelLinks.Size = new System.Drawing.Size(0, 13);
            this.statusLabelLinks.TabIndex = 12;
            // 
            // statusLabelRechts
            // 
            this.statusLabelRechts.AutoSize = true;
            this.statusLabelRechts.Location = new System.Drawing.Point(364, 42);
            this.statusLabelRechts.Name = "statusLabelRechts";
            this.statusLabelRechts.Size = new System.Drawing.Size(0, 13);
            this.statusLabelRechts.TabIndex = 13;
            // 
            // labelTimer
            // 
            this.labelTimer.Enabled = true;
            this.labelTimer.Tick += new System.EventHandler(this.labelTimer_Tick);
            // 
            // rescanButton
            // 
            this.rescanButton.Location = new System.Drawing.Point(206, 66);
            this.rescanButton.Name = "rescanButton";
            this.rescanButton.Size = new System.Drawing.Size(75, 23);
            this.rescanButton.TabIndex = 14;
            this.rescanButton.Text = "Rescan";
            this.rescanButton.UseVisualStyleBackColor = true;
            this.rescanButton.Click += new System.EventHandler(this.rescanButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(693, 200);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 23);
            this.restartButton.TabIndex = 15;
            this.restartButton.Text = "restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 235);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.rescanButton);
            this.Controls.Add(this.statusLabelRechts);
            this.Controls.Add(this.statusLabelLinks);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.openneerButton);
            this.Controls.Add(this.vooruitButton);
            this.Controls.Add(this.achteruitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComRechtsBox);
            this.Controls.Add(this.ComLinksBox);
            this.Controls.Add(this.connectLinksButton);
            this.Controls.Add(this.ConnectRechts);
            this.Name = "Form1";
            this.Text = "Hijskraan test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectRechts;
        private System.Windows.Forms.Button connectLinksButton;
        private System.Windows.Forms.ComboBox ComLinksBox;
        private System.Windows.Forms.ComboBox ComRechtsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button achteruitButton;
        private System.Windows.Forms.Button vooruitButton;
        private System.Windows.Forms.Button openneerButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label statusLabelLinks;
        private System.Windows.Forms.Label statusLabelRechts;
        private System.Windows.Forms.Timer labelTimer;
        private System.Windows.Forms.Button rescanButton;
        private System.Windows.Forms.Button restartButton;
    }
}

