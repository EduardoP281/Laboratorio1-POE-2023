namespace Tarea_2_Laboratorio_1.OrganizadorEventos
{
    partial class PantallaInicial
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
            this.labelOne = new System.Windows.Forms.Label();
            this.eventosListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.AddEventosTextBox = new System.Windows.Forms.TextBox();
            this.addEventsButtom = new System.Windows.Forms.Button();
            this.adminGropuBox = new System.Windows.Forms.GroupBox();
            this.modificarLabel = new System.Windows.Forms.Label();
            this.eventModTxtBox = new System.Windows.Forms.TextBox();
            this.editEventsButtom = new System.Windows.Forms.Button();
            this.deleteEventsButtom = new System.Windows.Forms.Button();
            this.estadoLabel = new System.Windows.Forms.Label();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.addGroupBox.SuspendLayout();
            this.adminGropuBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOne
            // 
            this.labelOne.AutoSize = true;
            this.labelOne.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOne.Location = new System.Drawing.Point(12, 9);
            this.labelOne.Name = "labelOne";
            this.labelOne.Size = new System.Drawing.Size(164, 60);
            this.labelOne.TabIndex = 8;
            this.labelOne.Text = "Administrador \r\nde eventos";
            // 
            // eventosListBox
            // 
            this.eventosListBox.FormattingEnabled = true;
            this.eventosListBox.ItemHeight = 15;
            this.eventosListBox.Location = new System.Drawing.Point(12, 93);
            this.eventosListBox.Name = "eventosListBox";
            this.eventosListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.eventosListBox.Size = new System.Drawing.Size(237, 304);
            this.eventosListBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lista de eventos";
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.estadoComboBox);
            this.addGroupBox.Controls.Add(this.clienteTextBox);
            this.addGroupBox.Controls.Add(this.estadoLabel);
            this.addGroupBox.Controls.Add(this.clienteLabel);
            this.addGroupBox.Controls.Add(this.AddEventosTextBox);
            this.addGroupBox.Controls.Add(this.addEventsButtom);
            this.addGroupBox.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addGroupBox.Location = new System.Drawing.Point(255, 8);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(251, 226);
            this.addGroupBox.TabIndex = 11;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Agregar Eventos";
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.Location = new System.Drawing.Point(15, 87);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(213, 25);
            this.clienteTextBox.TabIndex = 4;
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Location = new System.Drawing.Point(6, 67);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(138, 17);
            this.clienteLabel.TabIndex = 3;
            this.clienteLabel.Text = "Nombre del cliente";
            // 
            // AddEventosTextBox
            // 
            this.AddEventosTextBox.Location = new System.Drawing.Point(15, 33);
            this.AddEventosTextBox.Multiline = true;
            this.AddEventosTextBox.Name = "AddEventosTextBox";
            this.AddEventosTextBox.Size = new System.Drawing.Size(213, 21);
            this.AddEventosTextBox.TabIndex = 2;
            // 
            // addEventsButtom
            // 
            this.addEventsButtom.Location = new System.Drawing.Point(36, 178);
            this.addEventsButtom.Name = "addEventsButtom";
            this.addEventsButtom.Size = new System.Drawing.Size(160, 41);
            this.addEventsButtom.TabIndex = 1;
            this.addEventsButtom.Text = "Agregar";
            this.addEventsButtom.UseVisualStyleBackColor = true;
            this.addEventsButtom.Click += new System.EventHandler(this.addEventsButtom_Click);
            // 
            // adminGropuBox
            // 
            this.adminGropuBox.Controls.Add(this.modificarLabel);
            this.adminGropuBox.Controls.Add(this.eventModTxtBox);
            this.adminGropuBox.Controls.Add(this.editEventsButtom);
            this.adminGropuBox.Controls.Add(this.deleteEventsButtom);
            this.adminGropuBox.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adminGropuBox.Location = new System.Drawing.Point(279, 240);
            this.adminGropuBox.Name = "adminGropuBox";
            this.adminGropuBox.Size = new System.Drawing.Size(188, 163);
            this.adminGropuBox.TabIndex = 12;
            this.adminGropuBox.TabStop = false;
            this.adminGropuBox.Text = "Administrar  Eventos";
            // 
            // modificarLabel
            // 
            this.modificarLabel.AutoSize = true;
            this.modificarLabel.Location = new System.Drawing.Point(6, 58);
            this.modificarLabel.Name = "modificarLabel";
            this.modificarLabel.Size = new System.Drawing.Size(135, 34);
            this.modificarLabel.TabIndex = 3;
            this.modificarLabel.Text = "Dato para cambiar\r\n al seleccionado";
            // 
            // eventModTxtBox
            // 
            this.eventModTxtBox.Location = new System.Drawing.Point(6, 95);
            this.eventModTxtBox.Name = "eventModTxtBox";
            this.eventModTxtBox.Size = new System.Drawing.Size(175, 25);
            this.eventModTxtBox.TabIndex = 2;
            // 
            // editEventsButtom
            // 
            this.editEventsButtom.Location = new System.Drawing.Point(48, 126);
            this.editEventsButtom.Name = "editEventsButtom";
            this.editEventsButtom.Size = new System.Drawing.Size(87, 31);
            this.editEventsButtom.TabIndex = 1;
            this.editEventsButtom.Text = "Editar";
            this.editEventsButtom.UseVisualStyleBackColor = true;
            this.editEventsButtom.Click += new System.EventHandler(this.editEventsButtom_Click);
            // 
            // deleteEventsButtom
            // 
            this.deleteEventsButtom.Location = new System.Drawing.Point(48, 24);
            this.deleteEventsButtom.Name = "deleteEventsButtom";
            this.deleteEventsButtom.Size = new System.Drawing.Size(87, 31);
            this.deleteEventsButtom.TabIndex = 0;
            this.deleteEventsButtom.Text = "Eliminar";
            this.deleteEventsButtom.UseVisualStyleBackColor = true;
            this.deleteEventsButtom.Click += new System.EventHandler(this.deleteEventsButtom_Click);
            // 
            // estadoLabel
            // 
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.estadoLabel.Location = new System.Drawing.Point(11, 119);
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(62, 21);
            this.estadoLabel.TabIndex = 13;
            this.estadoLabel.Text = "Estado";
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoComboBox.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(15, 143);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(213, 29);
            this.estadoComboBox.TabIndex = 14;
            // 
            // PantallaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 411);
            this.Controls.Add(this.adminGropuBox);
            this.Controls.Add(this.addGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventosListBox);
            this.Controls.Add(this.labelOne);
            this.Name = "PantallaInicial";
            this.Text = "PantallaInicial";
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.adminGropuBox.ResumeLayout(false);
            this.adminGropuBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelOne;
        private ListBox eventosListBox;
        private Label label1;
        private GroupBox addGroupBox;
        private Button addEventsButtom;
        private GroupBox adminGropuBox;
        private Button editEventsButtom;
        private Button deleteEventsButtom;
        private TextBox AddEventosTextBox;
        private Label estadoLabel;
        private ComboBox estadoComboBox;
        private TextBox clienteTextBox;
        private Label clienteLabel;
        private Label modificarLabel;
        private TextBox eventModTxtBox;
    }
}