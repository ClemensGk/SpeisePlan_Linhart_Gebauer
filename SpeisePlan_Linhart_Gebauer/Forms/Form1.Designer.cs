﻿namespace SpeisePlan_Linhart_Gebauer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zutatenHnizufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zutatBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zutatEntfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neueZutatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.speiseHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speiseBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speiseEntfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSpeisen = new System.Windows.Forms.Label();
            this.lblZutaten = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.speiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wochenspeiseplanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(688, 160);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(611, 303);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Menge";
            this.columnHeader6.Width = 108;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Einheit";
            this.columnHeader7.Width = 93;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Bezeichnung";
            this.columnHeader8.Width = 147;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Allergene";
            this.columnHeader9.Width = 147;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zutatenHnizufügenToolStripMenuItem,
            this.zutatBearbeitenToolStripMenuItem,
            this.zutatEntfernenToolStripMenuItem,
            this.neueZutatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 92);
            // 
            // zutatenHnizufügenToolStripMenuItem
            // 
            this.zutatenHnizufügenToolStripMenuItem.Name = "zutatenHnizufügenToolStripMenuItem";
            this.zutatenHnizufügenToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.zutatenHnizufügenToolStripMenuItem.Text = "Zutat hinzufügen";
            this.zutatenHnizufügenToolStripMenuItem.Click += new System.EventHandler(this.zutatenHnizufügenToolStripMenuItem_Click);
            // 
            // zutatBearbeitenToolStripMenuItem
            // 
            this.zutatBearbeitenToolStripMenuItem.Name = "zutatBearbeitenToolStripMenuItem";
            this.zutatBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.zutatBearbeitenToolStripMenuItem.Text = "Zutat bearbeiten";
            // 
            // zutatEntfernenToolStripMenuItem
            // 
            this.zutatEntfernenToolStripMenuItem.Name = "zutatEntfernenToolStripMenuItem";
            this.zutatEntfernenToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.zutatEntfernenToolStripMenuItem.Text = "Zutat entfernen";
            // 
            // neueZutatToolStripMenuItem
            // 
            this.neueZutatToolStripMenuItem.Name = "neueZutatToolStripMenuItem";
            this.neueZutatToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.neueZutatToolStripMenuItem.Text = "neue Zutat";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.listView2.ContextMenuStrip = this.contextMenuStrip2;
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(12, 160);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(623, 303);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "Speiseart";
            this.columnHeader4.Width = 104;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "SpeiseID";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Speisename";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Preis";
            this.columnHeader3.Width = 157;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Bild";
            this.columnHeader5.Width = 149;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speiseHinzufügenToolStripMenuItem,
            this.speiseBearbeitenToolStripMenuItem,
            this.speiseEntfernenToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 92);
            // 
            // speiseHinzufügenToolStripMenuItem
            // 
            this.speiseHinzufügenToolStripMenuItem.Name = "speiseHinzufügenToolStripMenuItem";
            this.speiseHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speiseHinzufügenToolStripMenuItem.Text = "Speise hinzufügen";
            this.speiseHinzufügenToolStripMenuItem.Click += new System.EventHandler(this.speiseHinzufügenToolStripMenuItem_Click);
            // 
            // speiseBearbeitenToolStripMenuItem
            // 
            this.speiseBearbeitenToolStripMenuItem.Name = "speiseBearbeitenToolStripMenuItem";
            this.speiseBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speiseBearbeitenToolStripMenuItem.Text = "Speise bearbeiten";
            // 
            // speiseEntfernenToolStripMenuItem
            // 
            this.speiseEntfernenToolStripMenuItem.Name = "speiseEntfernenToolStripMenuItem";
            this.speiseEntfernenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speiseEntfernenToolStripMenuItem.Text = "Speise entfernen";
            // 
            // lblSpeisen
            // 
            this.lblSpeisen.AutoSize = true;
            this.lblSpeisen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeisen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSpeisen.Location = new System.Drawing.Point(249, 119);
            this.lblSpeisen.Name = "lblSpeisen";
            this.lblSpeisen.Size = new System.Drawing.Size(102, 29);
            this.lblSpeisen.TabIndex = 4;
            this.lblSpeisen.Text = "Speisen";
            // 
            // lblZutaten
            // 
            this.lblZutaten.AutoSize = true;
            this.lblZutaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZutaten.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblZutaten.Location = new System.Drawing.Point(872, 119);
            this.lblZutaten.Name = "lblZutaten";
            this.lblZutaten.Size = new System.Drawing.Size(216, 29);
            this.lblZutaten.TabIndex = 5;
            this.lblZutaten.Text = "Zutaten der Speise";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speiseToolStripMenuItem,
            this.wochenspeiseplanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1311, 33);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // speiseToolStripMenuItem
            // 
            this.speiseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.speiseToolStripMenuItem.Name = "speiseToolStripMenuItem";
            this.speiseToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.speiseToolStripMenuItem.Text = "Speiseplan";
            this.speiseToolStripMenuItem.Click += new System.EventHandler(this.speiseToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.beendenToolStripMenuItem.Text = "beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // wochenspeiseplanToolStripMenuItem
            // 
            this.wochenspeiseplanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erstellenToolStripMenuItem});
            this.wochenspeiseplanToolStripMenuItem.Name = "wochenspeiseplanToolStripMenuItem";
            this.wochenspeiseplanToolStripMenuItem.Size = new System.Drawing.Size(182, 29);
            this.wochenspeiseplanToolStripMenuItem.Text = "Wochenspeiseplan";
            // 
            // erstellenToolStripMenuItem
            // 
            this.erstellenToolStripMenuItem.Name = "erstellenToolStripMenuItem";
            this.erstellenToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.erstellenToolStripMenuItem.Text = "erstellen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(570, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Speiseplan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 577);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblZutaten);
            this.Controls.Add(this.lblSpeisen);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.HelpButton = true;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Speiseplan";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblSpeisen;
        private System.Windows.Forms.Label lblZutaten;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zutatenHnizufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zutatBearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zutatEntfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neueZutatToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem speiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem speiseHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speiseBearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speiseEntfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wochenspeiseplanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erstellenToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}
