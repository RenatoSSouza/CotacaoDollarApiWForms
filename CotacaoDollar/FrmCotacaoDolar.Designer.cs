
namespace CotacaoDollar
{
    partial class FrmCotacaoDolar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCotacaoDolar));
            this.lbDollarText = new System.Windows.Forms.Label();
            this.lblTextBuy = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTextSell = new System.Windows.Forms.Label();
            this.lblTextVariation = new System.Windows.Forms.Label();
            this.lblBuy = new System.Windows.Forms.Label();
            this.lblSell = new System.Windows.Forms.Label();
            this.lblVariation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblActualTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDollarText
            // 
            this.lbDollarText.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbDollarText.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDollarText.ForeColor = System.Drawing.Color.White;
            this.lbDollarText.Location = new System.Drawing.Point(-5, -1);
            this.lbDollarText.Name = "lbDollarText";
            this.lbDollarText.Size = new System.Drawing.Size(443, 77);
            this.lbDollarText.TabIndex = 0;
            this.lbDollarText.Text = "Dólar";
            this.lbDollarText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextBuy
            // 
            this.lblTextBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextBuy.Location = new System.Drawing.Point(10, 130);
            this.lblTextBuy.Name = "lblTextBuy";
            this.lblTextBuy.Size = new System.Drawing.Size(124, 23);
            this.lblTextBuy.TabIndex = 1;
            this.lblTextBuy.Text = "Compra: ";
            this.lblTextBuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(308, 352);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 47);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lblTextSell
            // 
            this.lblTextSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextSell.Location = new System.Drawing.Point(10, 200);
            this.lblTextSell.Name = "lblTextSell";
            this.lblTextSell.Size = new System.Drawing.Size(124, 23);
            this.lblTextSell.TabIndex = 3;
            this.lblTextSell.Text = "Venda: ";
            this.lblTextSell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTextVariation
            // 
            this.lblTextVariation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextVariation.Location = new System.Drawing.Point(10, 270);
            this.lblTextVariation.Name = "lblTextVariation";
            this.lblTextVariation.Size = new System.Drawing.Size(124, 23);
            this.lblTextVariation.TabIndex = 4;
            this.lblTextVariation.Text = "Variação: ";
            this.lblTextVariation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBuy
            // 
            this.lblBuy.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuy.ForeColor = System.Drawing.Color.White;
            this.lblBuy.Location = new System.Drawing.Point(122, 112);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(300, 65);
            this.lblBuy.TabIndex = 5;
            this.lblBuy.Text = "0,0";
            this.lblBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSell
            // 
            this.lblSell.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSell.ForeColor = System.Drawing.Color.White;
            this.lblSell.Location = new System.Drawing.Point(122, 182);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(300, 65);
            this.lblSell.TabIndex = 6;
            this.lblSell.Text = "0,0";
            this.lblSell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVariation
            // 
            this.lblVariation.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblVariation.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariation.ForeColor = System.Drawing.Color.White;
            this.lblVariation.Location = new System.Drawing.Point(122, 252);
            this.lblVariation.Name = "lblVariation";
            this.lblVariation.Size = new System.Drawing.Size(300, 65);
            this.lblVariation.TabIndex = 7;
            this.lblVariation.Text = "0,0";
            this.lblVariation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ultima consulta:";
            // 
            // lblActualTime
            // 
            this.lblActualTime.AutoSize = true;
            this.lblActualTime.Location = new System.Drawing.Point(62, 386);
            this.lblActualTime.Name = "lblActualTime";
            this.lblActualTime.Size = new System.Drawing.Size(55, 13);
            this.lblActualTime.TabIndex = 9;
            this.lblActualTime.Text = "????????";
            // 
            // FrmCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.lblActualTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVariation);
            this.Controls.Add(this.lblSell);
            this.Controls.Add(this.lblBuy);
            this.Controls.Add(this.lblTextVariation);
            this.Controls.Add(this.lblTextSell);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblTextBuy);
            this.Controls.Add(this.lbDollarText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCotacaoDolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotação Dolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDollarText;
        private System.Windows.Forms.Label lblTextBuy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTextSell;
        private System.Windows.Forms.Label lblTextVariation;
        private System.Windows.Forms.Label lblBuy;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.Label lblVariation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblActualTime;
    }
}

