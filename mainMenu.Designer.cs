﻿
namespace Network_Detective
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.openPingForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openSubnetForm = new System.Windows.Forms.Button();
            this.openPortScanForm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openPingForm
            // 
            this.openPingForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openPingForm.BackColor = System.Drawing.SystemColors.MenuBar;
            this.openPingForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openPingForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPingForm.Location = new System.Drawing.Point(33, 350);
            this.openPingForm.Name = "openPingForm";
            this.openPingForm.Size = new System.Drawing.Size(172, 51);
            this.openPingForm.TabIndex = 0;
            this.openPingForm.Text = "PING";
            this.openPingForm.UseVisualStyleBackColor = false;
            this.openPingForm.Click += new System.EventHandler(this.openPingForm_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(303, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Advanced Network Scan";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // openSubnetForm
            // 
            this.openSubnetForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openSubnetForm.BackColor = System.Drawing.SystemColors.MenuBar;
            this.openSubnetForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openSubnetForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSubnetForm.Location = new System.Drawing.Point(33, 245);
            this.openSubnetForm.Name = "openSubnetForm";
            this.openSubnetForm.Size = new System.Drawing.Size(172, 51);
            this.openSubnetForm.TabIndex = 2;
            this.openSubnetForm.Text = "Subnet Scan";
            this.openSubnetForm.UseVisualStyleBackColor = false;
            this.openSubnetForm.Click += new System.EventHandler(this.openSubnetForm_Click);
            // 
            // openPortScanForm
            // 
            this.openPortScanForm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.openPortScanForm.BackColor = System.Drawing.SystemColors.MenuBar;
            this.openPortScanForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPortScanForm.Location = new System.Drawing.Point(303, 246);
            this.openPortScanForm.Name = "openPortScanForm";
            this.openPortScanForm.Size = new System.Drawing.Size(172, 51);
            this.openPortScanForm.TabIndex = 3;
            this.openPortScanForm.Text = "Port Scan";
            this.openPortScanForm.UseVisualStyleBackColor = false;
            this.openPortScanForm.Click += new System.EventHandler(this.openPortScanForm_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(570, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 52);
            this.button2.TabIndex = 5;
            this.button2.Text = "Advanced Port Scan";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(570, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 52);
            this.button3.TabIndex = 6;
            this.button3.Text = "Trace Route";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Network_Detective.Properties.Resources.mainMenuTitle_NAME;
            this.pictureBox2.Location = new System.Drawing.Point(1, -51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 75);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox1.Image = global::Network_Detective.Properties.Resources.mainMenuTitle256;
            this.pictureBox1.Location = new System.Drawing.Point(244, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.openPortScanForm);
            this.Controls.Add(this.openSubnetForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openPingForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainMenu";
            this.Text = "Network Detective";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openPingForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button openSubnetForm;
        private System.Windows.Forms.Button openPortScanForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
