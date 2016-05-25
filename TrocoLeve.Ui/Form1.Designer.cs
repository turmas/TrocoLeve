namespace TrocoLeve.Ui
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
			this.UxTxtProductAmount = new System.Windows.Forms.TextBox();
			this.UxTxtPaidAmount = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.UxLstChangeAmount = new System.Windows.Forms.ListBox();
			this.UxBtnBuy = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.comprarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// UxTxtProductAmount
			// 
			this.UxTxtProductAmount.Location = new System.Drawing.Point(216, 82);
			this.UxTxtProductAmount.Name = "UxTxtProductAmount";
			this.UxTxtProductAmount.Size = new System.Drawing.Size(395, 26);
			this.UxTxtProductAmount.TabIndex = 1;
			// 
			// UxTxtPaidAmount
			// 
			this.UxTxtPaidAmount.Location = new System.Drawing.Point(216, 50);
			this.UxTxtPaidAmount.Name = "UxTxtPaidAmount";
			this.UxTxtPaidAmount.Size = new System.Drawing.Size(395, 26);
			this.UxTxtPaidAmount.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Valor do produto";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Valor pago";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 169);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Troco";
			// 
			// UxLstChangeAmount
			// 
			this.UxLstChangeAmount.FormattingEnabled = true;
			this.UxLstChangeAmount.ItemHeight = 20;
			this.UxLstChangeAmount.Location = new System.Drawing.Point(216, 169);
			this.UxLstChangeAmount.Name = "UxLstChangeAmount";
			this.UxLstChangeAmount.Size = new System.Drawing.Size(395, 164);
			this.UxLstChangeAmount.TabIndex = 3;
			// 
			// UxBtnBuy
			// 
			this.UxBtnBuy.Location = new System.Drawing.Point(216, 114);
			this.UxBtnBuy.Name = "UxBtnBuy";
			this.UxBtnBuy.Size = new System.Drawing.Size(395, 49);
			this.UxBtnBuy.TabIndex = 2;
			this.UxBtnBuy.Text = "Comprar";
			this.UxBtnBuy.UseVisualStyleBackColor = true;
			this.UxBtnBuy.Click += new System.EventHandler(this.UxBtnBuy_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ajudaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(669, 33);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprarToolStripMenuItem,
            this.sairToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
			this.fileToolStripMenuItem.Text = "&Arquivo";
			// 
			// comprarToolStripMenuItem
			// 
			this.comprarToolStripMenuItem.Name = "comprarToolStripMenuItem";
			this.comprarToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
			this.comprarToolStripMenuItem.Text = "&Comprar";
			this.comprarToolStripMenuItem.Click += new System.EventHandler(this.comprarToolStripMenuItem_Click);
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
			this.sairToolStripMenuItem.Text = "&Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
			// 
			// ajudaToolStripMenuItem
			// 
			this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
			this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
			this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
			this.ajudaToolStripMenuItem.Text = "A&juda";
			// 
			// sobreToolStripMenuItem
			// 
			this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
			this.sobreToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
			this.sobreToolStripMenuItem.Text = "S&obre...";
			this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.UxBtnBuy;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(669, 362);
			this.Controls.Add(this.UxBtnBuy);
			this.Controls.Add(this.UxLstChangeAmount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.UxTxtPaidAmount);
			this.Controls.Add(this.UxTxtProductAmount);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Troco Leve";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox UxTxtProductAmount;
		private System.Windows.Forms.TextBox UxTxtPaidAmount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox UxLstChangeAmount;
		private System.Windows.Forms.Button UxBtnBuy;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem comprarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
	}
}

