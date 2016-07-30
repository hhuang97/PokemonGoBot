namespace PokemonGo.RocketAPI.Window
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
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnForceUnban = new System.Windows.Forms.Button();
            this.btnLuckyEgg = new System.Windows.Forms.Button();
            this.btnStartFarming = new System.Windows.Forms.Button();
            this.btnadvoptions = new System.Windows.Forms.Button();
            this.MainMap = new GMap.NET.WindowsForms.GMapControl();
            this.dGrid = new System.Windows.Forms.DataGridView();
            this.btnPokemon = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.Color.Black;
            this.logTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTextBox.ForeColor = System.Drawing.Color.White;
            this.logTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.logTextBox.Location = new System.Drawing.Point(225, 285);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(468, 207);
            this.logTextBox.TabIndex = 0;
            this.logTextBox.Text = "";
            this.logTextBox.TextChanged += new System.EventHandler(this.logTextBox_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 495);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(701, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Status";
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // showAllToolStripMenuItem1
            // 
            this.showAllToolStripMenuItem1.Name = "showAllToolStripMenuItem1";
            this.showAllToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnForceUnban);
            this.groupBox1.Controls.Add(this.btnLuckyEgg);
            this.groupBox1.Controls.Add(this.btnStartFarming);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 135);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Farming Control";
            // 
            // btnForceUnban
            // 
            this.btnForceUnban.Location = new System.Drawing.Point(6, 103);
            this.btnForceUnban.Name = "btnForceUnban";
            this.btnForceUnban.Size = new System.Drawing.Size(189, 23);
            this.btnForceUnban.TabIndex = 16;
            this.btnForceUnban.Text = "Force Unban";
            this.btnForceUnban.UseVisualStyleBackColor = true;
            this.btnForceUnban.Click += new System.EventHandler(this.btnForceUnban_Click);
            // 
            // btnLuckyEgg
            // 
            this.btnLuckyEgg.Location = new System.Drawing.Point(6, 77);
            this.btnLuckyEgg.Name = "btnLuckyEgg";
            this.btnLuckyEgg.Size = new System.Drawing.Size(189, 23);
            this.btnLuckyEgg.TabIndex = 7;
            this.btnLuckyEgg.Text = "Use Lucky egg";
            this.btnLuckyEgg.UseVisualStyleBackColor = true;
            this.btnLuckyEgg.Click += new System.EventHandler(this.btnLuckyEgg_Click);
            // 
            // btnStartFarming
            // 
            this.btnStartFarming.Location = new System.Drawing.Point(6, 22);
            this.btnStartFarming.Name = "btnStartFarming";
            this.btnStartFarming.Size = new System.Drawing.Size(189, 49);
            this.btnStartFarming.TabIndex = 0;
            this.btnStartFarming.Text = "Start Farming";
            this.btnStartFarming.UseVisualStyleBackColor = true;
            this.btnStartFarming.Click += new System.EventHandler(this.btnStartFarming_Click);
            // 
            // btnadvoptions
            // 
            this.btnadvoptions.Location = new System.Drawing.Point(12, 469);
            this.btnadvoptions.Name = "btnadvoptions";
            this.btnadvoptions.Size = new System.Drawing.Size(201, 23);
            this.btnadvoptions.TabIndex = 15;
            this.btnadvoptions.Text = "Advanced Options";
            this.btnadvoptions.UseVisualStyleBackColor = true;
            this.btnadvoptions.Click += new System.EventHandler(this.btnadvoptions_Click);
            // 
            // MainMap
            // 
            this.MainMap.Bearing = 0F;
            this.MainMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainMap.CanDragMap = true;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.MainMap.Enabled = false;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.LevelsKeepInMemmory = 5;
            this.MainMap.Location = new System.Drawing.Point(12, 153);
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 2;
            this.MainMap.MinZoom = 2;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = true;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Size = new System.Drawing.Size(201, 281);
            this.MainMap.TabIndex = 16;
            this.MainMap.Zoom = 0D;
            // 
            // dGrid
            // 
            this.dGrid.AllowUserToAddRows = false;
            this.dGrid.AllowUserToDeleteRows = false;
            this.dGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid.Location = new System.Drawing.Point(225, 12);
            this.dGrid.Name = "dGrid";
            this.dGrid.ReadOnly = true;
            this.dGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGrid.Size = new System.Drawing.Size(464, 267);
            this.dGrid.TabIndex = 0;
            // 
            // btnPokemon
            // 
            this.btnPokemon.Enabled = false;
            this.btnPokemon.Location = new System.Drawing.Point(12, 440);
            this.btnPokemon.Name = "btnPokemon";
            this.btnPokemon.Size = new System.Drawing.Size(201, 23);
            this.btnPokemon.TabIndex = 17;
            this.btnPokemon.Text = "Pokemon";
            this.btnPokemon.UseVisualStyleBackColor = true;
            this.btnPokemon.Click += new System.EventHandler(this.btnPokemon_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 517);
            this.Controls.Add(this.btnPokemon);
            this.Controls.Add(this.dGrid);
            this.Controls.Add(this.MainMap);
            this.Controls.Add(this.btnadvoptions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(717, 556);
            this.MinimumSize = new System.Drawing.Size(717, 556);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PoGoBoT - GUI";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox logTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuckyEgg;
        private System.Windows.Forms.Button btnStartFarming;
        private System.Windows.Forms.Button btnadvoptions;
        private System.Windows.Forms.Button btnForceUnban;
        private GMap.NET.WindowsForms.GMapControl MainMap;
        private System.Windows.Forms.DataGridView dGrid;
        private System.Windows.Forms.Button btnPokemon;
    }
}
