﻿namespace WiAuth.Configure
{
    partial class Picker
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
            this.listenStateLabel = new System.Windows.Forms.Label();
            this.pairButton = new System.Windows.Forms.Button();
            this.wiauthIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.iconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uidListBox = new System.Windows.Forms.ListBox();
            this.iconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listenStateLabel
            // 
            this.listenStateLabel.Location = new System.Drawing.Point(12, 9);
            this.listenStateLabel.Name = "listenStateLabel";
            this.listenStateLabel.Size = new System.Drawing.Size(295, 43);
            this.listenStateLabel.TabIndex = 0;
            this.listenStateLabel.Text = "正在等待设备连接……";
            this.listenStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pairButton
            // 
            this.pairButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pairButton.Location = new System.Drawing.Point(13, 359);
            this.pairButton.Name = "pairButton";
            this.pairButton.Size = new System.Drawing.Size(294, 57);
            this.pairButton.TabIndex = 2;
            this.pairButton.Text = "配对";
            this.pairButton.UseVisualStyleBackColor = true;
            this.pairButton.Click += new System.EventHandler(this.pairButton_Click);
            // 
            // wiauthIcon
            // 
            this.wiauthIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.wiauthIcon.BalloonTipText = "配对程序正在运行中";
            this.wiauthIcon.BalloonTipTitle = "WiAuth";
            this.wiauthIcon.Text = "WiAuth配对程序";
            this.wiauthIcon.Visible = true;
            // 
            // iconMenu
            // 
            this.iconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.iconMenu.Name = "iconMenu";
            this.iconMenu.Size = new System.Drawing.Size(101, 26);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitMenuItem.Text = "退出";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // uidListBox
            // 
            this.uidListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uidListBox.FormattingEnabled = true;
            this.uidListBox.ItemHeight = 21;
            this.uidListBox.Location = new System.Drawing.Point(13, 55);
            this.uidListBox.Name = "uidListBox";
            this.uidListBox.Size = new System.Drawing.Size(294, 298);
            this.uidListBox.TabIndex = 4;
            // 
            // Picker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 428);
            this.Controls.Add(this.uidListBox);
            this.Controls.Add(this.pairButton);
            this.Controls.Add(this.listenStateLabel);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Picker";
            this.Text = "配对程序";
            this.iconMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label listenStateLabel;
        private System.Windows.Forms.Button pairButton;
        private System.Windows.Forms.NotifyIcon wiauthIcon;
        private System.Windows.Forms.ContextMenuStrip iconMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ListBox uidListBox;
    }
}