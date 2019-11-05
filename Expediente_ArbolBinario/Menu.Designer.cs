namespace Expediente_ArbolBinario
{
    partial class Menu
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
            this.btnCaseFile = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCaseFile
            // 
            this.btnCaseFile.Location = new System.Drawing.Point(149, 58);
            this.btnCaseFile.Name = "btnCaseFile";
            this.btnCaseFile.Size = new System.Drawing.Size(518, 79);
            this.btnCaseFile.TabIndex = 0;
            this.btnCaseFile.Text = "CREAR EXPEDIENTESSS";
            this.btnCaseFile.UseVisualStyleBackColor = true;
            this.btnCaseFile.Click += new System.EventHandler(this.btnCaseFile_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(149, 186);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(518, 79);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "BUSQUEDA DE EXPEDIENTES";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnTree
            // 
            this.btnTree.Location = new System.Drawing.Point(149, 322);
            this.btnTree.Name = "btnTree";
            this.btnTree.Size = new System.Drawing.Size(518, 79);
            this.btnTree.TabIndex = 2;
            this.btnTree.Text = "ACTUALIZAR ARBOL";
            this.btnTree.UseVisualStyleBackColor = true;
            this.btnTree.Click += new System.EventHandler(this.btnTree_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTree);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCaseFile);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCaseFile;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnTree;
    }
}