namespace PresentationLayer.Forms
{
    partial class StudentForm
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
            dgvStudents = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            txtNameStudent = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtLastNameStudent = new TextBox();
            label4 = new Label();
            cbxCareerStudent = new ComboBox();
            btnShowCareers = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(489, 111);
            dgvStudents.Margin = new Padding(3, 4, 3, 4);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(437, 399);
            dgvStudents.TabIndex = 17;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(340, 479);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(207, 479);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 31);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(60, 479);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 14;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtNameStudent
            // 
            txtNameStudent.Location = new Point(60, 160);
            txtNameStudent.Margin = new Padding(3, 4, 3, 4);
            txtNameStudent.Name = "txtNameStudent";
            txtNameStudent.Size = new Size(365, 27);
            txtNameStudent.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 232);
            label3.Name = "label3";
            label3.Size = new Size(246, 28);
            label3.TabIndex = 11;
            label3.Text = "Apellidos del estudiante:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 111);
            label2.Name = "label2";
            label2.Size = new Size(235, 28);
            label2.TabIndex = 10;
            label2.Text = "Nombre del Estudiante:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(347, 43);
            label1.Name = "label1";
            label1.Size = new Size(353, 32);
            label1.TabIndex = 9;
            label1.Text = "Administrador de Estudiantes";
            // 
            // txtLastNameStudent
            // 
            txtLastNameStudent.Location = new Point(61, 280);
            txtLastNameStudent.Margin = new Padding(3, 4, 3, 4);
            txtLastNameStudent.Name = "txtLastNameStudent";
            txtLastNameStudent.Size = new Size(365, 27);
            txtLastNameStudent.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 337);
            label4.Name = "label4";
            label4.Size = new Size(222, 28);
            label4.TabIndex = 19;
            label4.Text = "Carrera del Estudiante";
            // 
            // cbxCareerStudent
            // 
            cbxCareerStudent.FormattingEnabled = true;
            cbxCareerStudent.Location = new Point(61, 379);
            cbxCareerStudent.Name = "cbxCareerStudent";
            cbxCareerStudent.Size = new Size(364, 28);
            cbxCareerStudent.TabIndex = 20;
            // 
            // btnShowCareers
            // 
            btnShowCareers.Location = new Point(428, 551);
            btnShowCareers.Margin = new Padding(3, 4, 3, 4);
            btnShowCareers.Name = "btnShowCareers";
            btnShowCareers.Size = new Size(141, 31);
            btnShowCareers.TabIndex = 21;
            btnShowCareers.Text = "Ver Carreras";
            btnShowCareers.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 615);
            Controls.Add(btnShowCareers);
            Controls.Add(cbxCareerStudent);
            Controls.Add(label4);
            Controls.Add(txtLastNameStudent);
            Controls.Add(dgvStudents);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(txtNameStudent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentForm";
            Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudents;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
        private TextBox txtNameStudent;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtLastNameStudent;
        private Label label4;
        private ComboBox cbxCareerStudent;
        private Button btnShowCareers;
    }
}