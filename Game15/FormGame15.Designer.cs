namespace Game15
{
    partial class FormGame15
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.level1 = new System.Windows.Forms.ToolStripMenuItem();
            this.level2 = new System.Windows.Forms.ToolStripMenuItem();
            this.level3 = new System.Windows.Forms.ToolStripMenuItem();
            this.savegame = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSavedGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.menu,
            this.toolStripMenuItem2,
            this.toolStripMenuItem7});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(43, 20);
            this.menu.Text = "Start";
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem2.Text = "?";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(27, 20);
            this.toolStripMenuItem7.Text = "+";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(65, 65);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonLeft
            // 
            this.buttonLeft.Enabled = false;
            this.buttonLeft.Location = new System.Drawing.Point(125, 1);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonLeft.Size = new System.Drawing.Size(20, 20);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.Text = "<";
            this.buttonLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Enabled = false;
            this.buttonRight.Location = new System.Drawing.Point(152, 1);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(20, 20);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.Text = ">";
            this.buttonRight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelToolStripMenuItem1,
            this.savegame,
            this.loadSavedGame});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // levelToolStripMenuItem1
            // 
            this.levelToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.level1,
            this.level2,
            this.level3});
            this.levelToolStripMenuItem1.Name = "levelToolStripMenuItem1";
            this.levelToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.levelToolStripMenuItem1.Text = "Level";
            // 
            // level1
            // 
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(152, 22);
            this.level1.Text = "Level 1";
            this.level1.Click += new System.EventHandler(this.level1_Click_1);
            // 
            // level2
            // 
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(152, 22);
            this.level2.Text = "Level 2";
            this.level2.Click += new System.EventHandler(this.level2_Click_1);
            // 
            // level3
            // 
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(152, 22);
            this.level3.Text = "Level 3";
            this.level3.Click += new System.EventHandler(this.level3_Click_1);
            // 
            // savegame
            // 
            this.savegame.Name = "savegame";
            this.savegame.Size = new System.Drawing.Size(166, 22);
            this.savegame.Text = "Save the game";
            this.savegame.Click += new System.EventHandler(this.savegame_Click);
            // 
            // loadSavedGame
            // 
            this.loadSavedGame.Name = "loadSavedGame";
            this.loadSavedGame.Size = new System.Drawing.Size(166, 22);
            this.loadSavedGame.Text = "Load saved game";
            this.loadSavedGame.Click += new System.EventHandler(this.loadSavedGame_Click);
            // 
            // FormGame15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(264, 287);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGame15";
            this.Text = "Game15";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        public System.Windows.Forms.Button buttonLeft;
        public System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem level1;
        private System.Windows.Forms.ToolStripMenuItem level2;
        private System.Windows.Forms.ToolStripMenuItem level3;
        private System.Windows.Forms.ToolStripMenuItem savegame;
        private System.Windows.Forms.ToolStripMenuItem loadSavedGame;
    }
}

