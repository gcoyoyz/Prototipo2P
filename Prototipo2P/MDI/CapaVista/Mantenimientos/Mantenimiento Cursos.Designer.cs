
namespace CapaVista.Mantenimientos
{
    partial class Mantenimiento_Cursos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcurso = new System.Windows.Forms.TextBox();
            this.txtnomcurso = new System.Windows.Forms.TextBox();
            this.txtestatuscur = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.dgvcursos = new System.Windows.Forms.DataGridView();
            this.btnactualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcursos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimiento Cursos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(40, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Código Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(33, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre Curso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(33, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Estatus Curso";
            // 
            // txtcurso
            // 
            this.txtcurso.Location = new System.Drawing.Point(199, 94);
            this.txtcurso.Name = "txtcurso";
            this.txtcurso.Size = new System.Drawing.Size(136, 22);
            this.txtcurso.TabIndex = 13;
            // 
            // txtnomcurso
            // 
            this.txtnomcurso.Location = new System.Drawing.Point(199, 142);
            this.txtnomcurso.Name = "txtnomcurso";
            this.txtnomcurso.Size = new System.Drawing.Size(136, 22);
            this.txtnomcurso.TabIndex = 14;
            // 
            // txtestatuscur
            // 
            this.txtestatuscur.Location = new System.Drawing.Point(199, 194);
            this.txtestatuscur.Name = "txtestatuscur";
            this.txtestatuscur.Size = new System.Drawing.Size(49, 22);
            this.txtestatuscur.TabIndex = 15;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(407, 142);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(111, 42);
            this.btningresar.TabIndex = 16;
            this.btningresar.Text = "INGRESAR";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(524, 142);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(111, 42);
            this.btneliminar.TabIndex = 17;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // dgvcursos
            // 
            this.dgvcursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcursos.Location = new System.Drawing.Point(74, 244);
            this.dgvcursos.Name = "dgvcursos";
            this.dgvcursos.RowHeadersWidth = 51;
            this.dgvcursos.RowTemplate.Height = 24;
            this.dgvcursos.Size = new System.Drawing.Size(683, 224);
            this.dgvcursos.TabIndex = 18;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(646, 142);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(111, 42);
            this.btnactualizar.TabIndex = 19;
            this.btnactualizar.Text = "ACTUALIZAR";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // Mantenimiento_Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CapaVista.Properties.Resources.Blue_Abstract_Vector_2016_Design_HD_Wallpaper_1366x768;
            this.ClientSize = new System.Drawing.Size(889, 505);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.dgvcursos);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtestatuscur);
            this.Controls.Add(this.txtnomcurso);
            this.Controls.Add(this.txtcurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mantenimiento_Cursos";
            this.Text = "Mantenimiento_Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcurso;
        private System.Windows.Forms.TextBox txtnomcurso;
        private System.Windows.Forms.TextBox txtestatuscur;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.DataGridView dgvcursos;
        private System.Windows.Forms.Button btnactualizar;
    }
}