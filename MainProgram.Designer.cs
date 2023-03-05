﻿
namespace FinalProject
{
    partial class MainProgram
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
            this.clientConnect = new System.Windows.Forms.Button();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configIPMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.behaviourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.clientCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.destLabel = new System.Windows.Forms.Label();
            this.destIPBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.serverStop = new System.Windows.Forms.Button();
            this.clientDisconnect = new System.Windows.Forms.Button();
            this.serverStart = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientConnect
            // 
            this.clientConnect.Enabled = false;
            this.clientConnect.Location = new System.Drawing.Point(559, 400);
            this.clientConnect.Margin = new System.Windows.Forms.Padding(4);
            this.clientConnect.Name = "clientConnect";
            this.clientConnect.Size = new System.Drawing.Size(153, 28);
            this.clientConnect.TabIndex = 0;
            this.clientConnect.Text = "Connect";
            this.clientConnect.UseVisualStyleBackColor = true;
            this.clientConnect.Click += new System.EventHandler(this.RunClient);
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.chatBox.ForeColor = System.Drawing.Color.Green;
            this.chatBox.Location = new System.Drawing.Point(16, 48);
            this.chatBox.Margin = new System.Windows.Forms.Padding(4);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chatBox.Size = new System.Drawing.Size(852, 328);
            this.chatBox.TabIndex = 1;
            // 
            // inputBox
            // 
            this.inputBox.Enabled = false;
            this.inputBox.Location = new System.Drawing.Point(24, 475);
            this.inputBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(687, 22);
            this.inputBox.TabIndex = 2;
            this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_OnKeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configIPMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip";
            // 
            // configIPMenu
            // 
            this.configIPMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.behaviourToolStripMenuItem});
            this.configIPMenu.Name = "configIPMenu";
            this.configIPMenu.Size = new System.Drawing.Size(75, 26);
            this.configIPMenu.Text = "Options";
            // 
            // behaviourToolStripMenuItem
            // 
            this.behaviourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverCheck,
            this.clientCheck});
            this.behaviourToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.behaviourToolStripMenuItem.Name = "behaviourToolStripMenuItem";
            this.behaviourToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.behaviourToolStripMenuItem.Text = "Behaviour";
            // 
            // serverCheck
            // 
            this.serverCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.serverCheck.Name = "serverCheck";
            this.serverCheck.Size = new System.Drawing.Size(133, 26);
            this.serverCheck.Text = "Server";
            this.serverCheck.Click += new System.EventHandler(this.select_server);
            // 
            // clientCheck
            // 
            this.clientCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.clientCheck.Name = "clientCheck";
            this.clientCheck.Size = new System.Drawing.Size(133, 26);
            this.clientCheck.Text = "Client";
            this.clientCheck.Click += new System.EventHandler(this.select_client);
            // 
            // usernameBox
            // 
            this.usernameBox.Enabled = false;
            this.usernameBox.Location = new System.Drawing.Point(24, 423);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameBox.MaxLength = 10;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(152, 22);
            this.usernameBox.TabIndex = 4;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(20, 404);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(70, 16);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username";
            // 
            // destLabel
            // 
            this.destLabel.AutoSize = true;
            this.destLabel.Location = new System.Drawing.Point(181, 404);
            this.destLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.destLabel.Name = "destLabel";
            this.destLabel.Size = new System.Drawing.Size(89, 16);
            this.destLabel.TabIndex = 6;
            this.destLabel.Text = "Destination IP";
            // 
            // destIPBox
            // 
            this.destIPBox.Enabled = false;
            this.destIPBox.Location = new System.Drawing.Point(185, 423);
            this.destIPBox.Margin = new System.Windows.Forms.Padding(4);
            this.destIPBox.MaxLength = 15;
            this.destIPBox.Name = "destIPBox";
            this.destIPBox.Size = new System.Drawing.Size(152, 22);
            this.destIPBox.TabIndex = 7;
            this.destIPBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.destIPBox_OnKeyPress);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(20, 30);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(71, 16);
            this.outputLabel.TabIndex = 10;
            this.outputLabel.Text = "Output Box";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(20, 455);
            this.inputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(61, 16);
            this.inputLabel.TabIndex = 11;
            this.inputLabel.Text = "Input Box";
            // 
            // serverStop
            // 
            this.serverStop.Enabled = false;
            this.serverStop.Location = new System.Drawing.Point(720, 436);
            this.serverStop.Margin = new System.Windows.Forms.Padding(4);
            this.serverStop.Name = "serverStop";
            this.serverStop.Size = new System.Drawing.Size(153, 28);
            this.serverStop.TabIndex = 12;
            this.serverStop.Text = "Stop";
            this.serverStop.UseVisualStyleBackColor = true;
            this.serverStop.Click += new System.EventHandler(this.StopServer);
            // 
            // clientDisconnect
            // 
            this.clientDisconnect.Enabled = false;
            this.clientDisconnect.Location = new System.Drawing.Point(559, 436);
            this.clientDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.clientDisconnect.Name = "clientDisconnect";
            this.clientDisconnect.Size = new System.Drawing.Size(153, 28);
            this.clientDisconnect.TabIndex = 13;
            this.clientDisconnect.Text = "Disconnect";
            this.clientDisconnect.UseVisualStyleBackColor = true;
            this.clientDisconnect.Click += new System.EventHandler(this.StopClient);
            // 
            // serverStart
            // 
            this.serverStart.Enabled = false;
            this.serverStart.Location = new System.Drawing.Point(720, 400);
            this.serverStart.Margin = new System.Windows.Forms.Padding(4);
            this.serverStart.Name = "serverStart";
            this.serverStart.Size = new System.Drawing.Size(153, 28);
            this.serverStart.TabIndex = 14;
            this.serverStart.Text = "Start";
            this.serverStart.UseVisualStyleBackColor = true;
            this.serverStart.Click += new System.EventHandler(this.RunServer);
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(720, 471);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(153, 28);
            this.sendButton.TabIndex = 15;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.SendMessage);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(716, 380);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Server Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 380);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Client Control";
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(887, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.serverStart);
            this.Controls.Add(this.clientDisconnect);
            this.Controls.Add(this.serverStop);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.destIPBox);
            this.Controls.Add(this.destLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.clientConnect);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(905, 558);
            this.MinimumSize = new System.Drawing.Size(905, 558);
            this.Name = "MainProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHAT APP ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnCloseProgram);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clientConnect;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label destLabel;
        private System.Windows.Forms.TextBox destIPBox;
        private System.Windows.Forms.ToolStripMenuItem configIPMenu;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.ToolStripMenuItem behaviourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverCheck;
        private System.Windows.Forms.ToolStripMenuItem clientCheck;
        public System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.Button serverStop;
        private System.Windows.Forms.Button clientDisconnect;
        private System.Windows.Forms.Button serverStart;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

