namespace TicTacToe
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.NewGameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ModeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SinglePlayerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MultiPlayerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FullScreenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.StatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.BoardLayout = new System.Windows.Forms.TableLayoutPanel();
            this.slot9 = new System.Windows.Forms.PictureBox();
            this.slot8 = new System.Windows.Forms.PictureBox();
            this.slot7 = new System.Windows.Forms.PictureBox();
            this.slot6 = new System.Windows.Forms.PictureBox();
            this.slot5 = new System.Windows.Forms.PictureBox();
            this.slot4 = new System.Windows.Forms.PictureBox();
            this.slot3 = new System.Windows.Forms.PictureBox();
            this.slot2 = new System.Windows.Forms.PictureBox();
            this.slot1 = new System.Windows.Forms.PictureBox();
            this.bg = new System.ComponentModel.BackgroundWorker();
            this.MainMenu.SuspendLayout();
            this.statusbar.SuspendLayout();
            this.BoardLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slot9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameMenu,
            this.ModeMenu,
            this.FullScreenMenu,
            this.AboutMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainMenu.Size = new System.Drawing.Size(322, 24);
            this.MainMenu.TabIndex = 0;
            // 
            // NewGameMenu
            // 
            this.NewGameMenu.Name = "NewGameMenu";
            this.NewGameMenu.Size = new System.Drawing.Size(77, 20);
            this.NewGameMenu.Text = "&New Game";
            this.NewGameMenu.Click += new System.EventHandler(this.NewGameMenu_Click);
            // 
            // ModeMenu
            // 
            this.ModeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SinglePlayerMenu,
            this.MultiPlayerMenu});
            this.ModeMenu.Name = "ModeMenu";
            this.ModeMenu.Size = new System.Drawing.Size(50, 20);
            this.ModeMenu.Text = "&Mode";
            // 
            // SinglePlayerMenu
            // 
            this.SinglePlayerMenu.Checked = true;
            this.SinglePlayerMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SinglePlayerMenu.Enabled = false;
            this.SinglePlayerMenu.Name = "SinglePlayerMenu";
            this.SinglePlayerMenu.Size = new System.Drawing.Size(141, 22);
            this.SinglePlayerMenu.Text = "&Single Player";
            this.SinglePlayerMenu.Click += new System.EventHandler(this.SinglePlayerMenu_Click);
            // 
            // MultiPlayerMenu
            // 
            this.MultiPlayerMenu.Name = "MultiPlayerMenu";
            this.MultiPlayerMenu.Size = new System.Drawing.Size(141, 22);
            this.MultiPlayerMenu.Text = "&Multi Player";
            this.MultiPlayerMenu.Click += new System.EventHandler(this.MultiPlayerMenu_Click);
            // 
            // FullScreenMenu
            // 
            this.FullScreenMenu.Name = "FullScreenMenu";
            this.FullScreenMenu.Size = new System.Drawing.Size(76, 20);
            this.FullScreenMenu.Text = "Full Screen";
            this.FullScreenMenu.Click += new System.EventHandler(this.FullScreenMenu_Click);
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(52, 20);
            this.AboutMenu.Text = "About";
            this.AboutMenu.Click += new System.EventHandler(this.AboutMenu_Click);
            // 
            // statusbar
            // 
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusText});
            this.statusbar.Location = new System.Drawing.Point(0, 278);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(322, 22);
            this.statusbar.TabIndex = 1;
            // 
            // StatusText
            // 
            this.StatusText.BackColor = System.Drawing.SystemColors.Control;
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(64, 17);
            this.StatusText.Text = "Status Text";
            // 
            // BoardLayout
            // 
            this.BoardLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BoardLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.BoardLayout.ColumnCount = 3;
            this.BoardLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BoardLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BoardLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BoardLayout.Controls.Add(this.slot9, 2, 2);
            this.BoardLayout.Controls.Add(this.slot8, 1, 2);
            this.BoardLayout.Controls.Add(this.slot7, 0, 2);
            this.BoardLayout.Controls.Add(this.slot6, 2, 1);
            this.BoardLayout.Controls.Add(this.slot5, 1, 1);
            this.BoardLayout.Controls.Add(this.slot4, 0, 1);
            this.BoardLayout.Controls.Add(this.slot3, 2, 0);
            this.BoardLayout.Controls.Add(this.slot2, 1, 0);
            this.BoardLayout.Controls.Add(this.slot1, 0, 0);
            this.BoardLayout.Location = new System.Drawing.Point(12, 26);
            this.BoardLayout.Name = "BoardLayout";
            this.BoardLayout.RowCount = 3;
            this.BoardLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BoardLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BoardLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BoardLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BoardLayout.Size = new System.Drawing.Size(298, 248);
            this.BoardLayout.TabIndex = 2;
            // 
            // slot9
            // 
            this.slot9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.slot9.BackColor = System.Drawing.Color.White;
            this.slot9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slot9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slot9.Location = new System.Drawing.Point(201, 169);
            this.slot9.Name = "slot9";
            this.slot9.Size = new System.Drawing.Size(92, 74);
            this.slot9.TabIndex = 11;
            this.slot9.TabStop = false;
            this.slot9.BackgroundImageChanged += new System.EventHandler(this.Draw_BackgroundImageChanged);
            this.slot9.Click += new System.EventHandler(this.GameMove_Click);
            // 
            // slot8
            // 
            this.slot8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.slot8.BackColor = System.Drawing.Color.White;
            this.slot8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slot8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slot8.Location = new System.Drawing.Point(103, 169);
            this.slot8.Name = "slot8";
            this.slot8.Size = new System.Drawing.Size(90, 74);
            this.slot8.TabIndex = 10;
            this.slot8.TabStop = false;
            this.slot8.BackgroundImageChanged += new System.EventHandler(this.Draw_BackgroundImageChanged);
            this.slot8.Click += new System.EventHandler(this.GameMove_Click);
            // 
            // slot7
            // 
            this.slot7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.slot7.BackColor = System.Drawing.Color.White;
            this.slot7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slot7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slot7.Location = new System.Drawing.Point(5, 169);
            this.slot7.Name = "slot7";
            this.slot7.Size = new System.Drawing.Size(90, 74);
            this.slot7.TabIndex = 9;
            this.slot7.TabStop = false;
            this.slot7.BackgroundImageChanged += new System.EventHandler(this.Draw_BackgroundImageChanged);
            this.slot7.Click += new System.EventHandler(this.GameMove_Click);
            // 
            // slot6
            // 
            this.slot6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.slot6.BackColor = System.Drawing.Color.White;
            this.slot6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slot6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slot6.Location = new System.Drawing.Point(201, 87);
            this.slot6.Name = "slot6";
            this.slot6.Size = new System.Drawing.Size(92, 74);
            this.slot6.TabIndex = 8;
            this.slot6.TabStop = false;
            this.slot6.BackgroundImageChanged += new System.EventHandler(this.Draw_BackgroundImageChanged);
            this.slot6.Click += new System.EventHandler(this.GameMove_Click);
            // 
            // slot5
            // 
            this.slot5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.slot5.BackColor = System.Drawing.Color.White;
            this.slot5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slot5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slot5.Location = new System.Drawing.Point(103, 87);
            this.slot5.Name = "slot5";
            this.slot5.Size = new System.Drawing.Size(90, 74);
            this.slot5.TabIndex = 7;
            this.slot5.TabStop = false;
            this.slot5.BackgroundImageChanged += new System.EventHandler(this.Draw_BackgroundImageChanged);
            this.slot5.Click += new System.EventHandler(this.GameMove_Click);
            // 
            // slot4
            // 
            this.slot4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.slot4.BackColor = System.Drawing.Color.White;
            this.slot4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slot4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slot4.Location = new System.Drawing.Point(5, 87);
            this.slot4.Name = "slot4";
            this.slot4.Size = new System.Drawing.Size(90, 74);
            this.slot4.TabIndex = 6;
            this.slot4.TabStop = false;
            this.slot4.BackgroundImageChanged += new System.EventHandler(this.Draw_BackgroundImageChanged);
            this.slot4.Click += new System.EventHandler(this.GameMove_Click);
            // 
            // slot3
            // 
            this.slot3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.slot3.BackColor = System.Drawing.Color.White;
            this.slot3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slot3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slot3.Location = new System.Drawing.Point(201, 5);
            this.slot3.Name = "slot3";
            this.slot3.Size = new System.Drawing.Size(92, 74);
            this.slot3.TabIndex = 5;
            this.slot3.TabStop = false;
            this.slot3.BackgroundImageChanged += new System.EventHandler(this.Draw_BackgroundImageChanged);
            this.slot3.Click += new System.EventHandler(this.GameMove_Click);
            // 
            // slot2
            // 
            this.slot2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.slot2.BackColor = System.Drawing.Color.White;
            this.slot2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slot2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slot2.Location = new System.Drawing.Point(103, 5);
            this.slot2.Name = "slot2";
            this.slot2.Size = new System.Drawing.Size(90, 74);
            this.slot2.TabIndex = 4;
            this.slot2.TabStop = false;
            this.slot2.BackgroundImageChanged += new System.EventHandler(this.Draw_BackgroundImageChanged);
            this.slot2.Click += new System.EventHandler(this.GameMove_Click);
            // 
            // slot1
            // 
            this.slot1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.slot1.BackColor = System.Drawing.Color.White;
            this.slot1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slot1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slot1.Location = new System.Drawing.Point(5, 5);
            this.slot1.Name = "slot1";
            this.slot1.Size = new System.Drawing.Size(90, 74);
            this.slot1.TabIndex = 3;
            this.slot1.TabStop = false;
            this.slot1.BackgroundImageChanged += new System.EventHandler(this.Draw_BackgroundImageChanged);
            this.slot1.Click += new System.EventHandler(this.GameMove_Click);
            // 
            // bg
            // 
            this.bg.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_DoWork);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(322, 300);
            this.Controls.Add(this.BoardLayout);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.BoardLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slot9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.ToolStripStatusLabel StatusText;
        private System.Windows.Forms.TableLayoutPanel BoardLayout;
        private System.Windows.Forms.ToolStripMenuItem NewGameMenu;
        private System.Windows.Forms.ToolStripMenuItem ModeMenu;
        private System.Windows.Forms.ToolStripMenuItem SinglePlayerMenu;
        private System.Windows.Forms.ToolStripMenuItem MultiPlayerMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
        private System.Windows.Forms.PictureBox slot1;
        private System.Windows.Forms.PictureBox slot9;
        private System.Windows.Forms.PictureBox slot8;
        private System.Windows.Forms.PictureBox slot7;
        private System.Windows.Forms.PictureBox slot6;
        private System.Windows.Forms.PictureBox slot5;
        private System.Windows.Forms.PictureBox slot4;
        private System.Windows.Forms.PictureBox slot3;
        private System.Windows.Forms.PictureBox slot2;
        private System.Windows.Forms.ToolStripMenuItem FullScreenMenu;
        private System.ComponentModel.BackgroundWorker bg;
    }
}