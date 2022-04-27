
namespace combobox
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPalavra = new System.Windows.Forms.Label();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.lblDropDownList = new System.Windows.Forms.Label();
            this.cboDropDownList = new System.Windows.Forms.ComboBox();
            this.lblPosItem = new System.Windows.Forms.Label();
            this.txtPosItem = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTextoSel = new System.Windows.Forms.Label();
            this.txtTextoSel = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimparCombo = new System.Windows.Forms.Button();
            this.btnLimparPalavra = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalavra
            // 
            this.lblPalavra.AutoSize = true;
            this.lblPalavra.Location = new System.Drawing.Point(94, 58);
            this.lblPalavra.Name = "lblPalavra";
            this.lblPalavra.Size = new System.Drawing.Size(95, 13);
            this.lblPalavra.TabIndex = 0;
            this.lblPalavra.Text = "Digite uma palavra";
            // 
            // txtPalavra
            // 
            this.txtPalavra.Location = new System.Drawing.Point(97, 90);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(174, 20);
            this.txtPalavra.TabIndex = 1;
            // 
            // lblDropDownList
            // 
            this.lblDropDownList.AutoSize = true;
            this.lblDropDownList.Location = new System.Drawing.Point(94, 161);
            this.lblDropDownList.Name = "lblDropDownList";
            this.lblDropDownList.Size = new System.Drawing.Size(108, 13);
            this.lblDropDownList.TabIndex = 2;
            this.lblDropDownList.Text = "Estilo Drop Down List";
            // 
            // cboDropDownList
            // 
            this.cboDropDownList.FormattingEnabled = true;
            this.cboDropDownList.Location = new System.Drawing.Point(97, 195);
            this.cboDropDownList.Name = "cboDropDownList";
            this.cboDropDownList.Size = new System.Drawing.Size(174, 21);
            this.cboDropDownList.TabIndex = 3;
            // 
            // lblPosItem
            // 
            this.lblPosItem.AutoSize = true;
            this.lblPosItem.Location = new System.Drawing.Point(94, 262);
            this.lblPosItem.Name = "lblPosItem";
            this.lblPosItem.Size = new System.Drawing.Size(81, 13);
            this.lblPosItem.TabIndex = 4;
            this.lblPosItem.Text = "Posição na lista";
            // 
            // txtPosItem
            // 
            this.txtPosItem.Enabled = false;
            this.txtPosItem.Location = new System.Drawing.Point(97, 309);
            this.txtPosItem.Name = "txtPosItem";
            this.txtPosItem.Size = new System.Drawing.Size(174, 20);
            this.txtPosItem.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(458, 58);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total de Itens";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(461, 90);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(183, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // lblTextoSel
            // 
            this.lblTextoSel.AutoSize = true;
            this.lblTextoSel.Location = new System.Drawing.Point(458, 161);
            this.lblTextoSel.Name = "lblTextoSel";
            this.lblTextoSel.Size = new System.Drawing.Size(94, 13);
            this.lblTextoSel.TabIndex = 8;
            this.lblTextoSel.Text = "Texto selecionado";
            // 
            // txtTextoSel
            // 
            this.txtTextoSel.Enabled = false;
            this.txtTextoSel.Location = new System.Drawing.Point(461, 195);
            this.txtTextoSel.Name = "txtTextoSel";
            this.txtTextoSel.Size = new System.Drawing.Size(183, 20);
            this.txtTextoSel.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(461, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add no Combo";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(460, 235);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(142, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar Item Selecionado";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimparCombo
            // 
            this.btnLimparCombo.Location = new System.Drawing.Point(460, 383);
            this.btnLimparCombo.Name = "btnLimparCombo";
            this.btnLimparCombo.Size = new System.Drawing.Size(85, 23);
            this.btnLimparCombo.TabIndex = 12;
            this.btnLimparCombo.Text = "Limpar Combo";
            this.btnLimparCombo.UseVisualStyleBackColor = true;
            // 
            // btnLimparPalavra
            // 
            this.btnLimparPalavra.Location = new System.Drawing.Point(460, 284);
            this.btnLimparPalavra.Name = "btnLimparPalavra";
            this.btnLimparPalavra.Size = new System.Drawing.Size(125, 23);
            this.btnLimparPalavra.TabIndex = 13;
            this.btnLimparPalavra.Text = "Limpar Campo Palavra";
            this.btnLimparPalavra.UseVisualStyleBackColor = true;
            this.btnLimparPalavra.Click += new System.EventHandler(this.btnLimparPalavra_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(635, 235);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimparPalavra);
            this.Controls.Add(this.btnLimparCombo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTextoSel);
            this.Controls.Add(this.lblTextoSel);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtPosItem);
            this.Controls.Add(this.lblPosItem);
            this.Controls.Add(this.cboDropDownList);
            this.Controls.Add(this.lblDropDownList);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.lblPalavra);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavra;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Label lblDropDownList;
        private System.Windows.Forms.ComboBox cboDropDownList;
        private System.Windows.Forms.Label lblPosItem;
        private System.Windows.Forms.TextBox txtPosItem;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTextoSel;
        private System.Windows.Forms.TextBox txtTextoSel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimparCombo;
        private System.Windows.Forms.Button btnLimparPalavra;
        private System.Windows.Forms.Button btnSair;
    }
}

