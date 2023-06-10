using System;
using System.Windows.Forms;

namespace VuelingStudentManagerCrud_Client
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.StudentNameText = new System.Windows.Forms.TextBox();
            this.StudentSurnameText = new System.Windows.Forms.TextBox();
            this.StudentBirthdayText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(12, 10);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(1041, 485);
            this.DataGrid.TabIndex = 3;
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(925, 500);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(128, 23);
            this.AddStudentButton.TabIndex = 4;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // StudentNameText
            // 
            this.StudentNameText.Location = new System.Drawing.Point(12, 502);
            this.StudentNameText.Name = "StudentNameText";
            this.StudentNameText.Size = new System.Drawing.Size(241, 22);
            this.StudentNameText.TabIndex = 5;
            this.StudentNameText.Text = "StudentName";
            this.StudentNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StudentSurnameText
            // 
            this.StudentSurnameText.Location = new System.Drawing.Point(276, 501);
            this.StudentSurnameText.Name = "StudentSurnameText";
            this.StudentSurnameText.Size = new System.Drawing.Size(241, 22);
            this.StudentSurnameText.TabIndex = 6;
            this.StudentSurnameText.Text = "StudentSurname";
            this.StudentSurnameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StudentBirthdayText
            // 
            this.StudentBirthdayText.Location = new System.Drawing.Point(539, 501);
            this.StudentBirthdayText.Name = "StudentBirthdayText";
            this.StudentBirthdayText.Size = new System.Drawing.Size(241, 22);
            this.StudentBirthdayText.TabIndex = 7;
            this.StudentBirthdayText.Text = "StudentBirthday";
            this.StudentBirthdayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1065, 536);
            this.Controls.Add(this.StudentBirthdayText);
            this.Controls.Add(this.StudentSurnameText);
            this.Controls.Add(this.StudentNameText);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.DataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Vueling Student Manager Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGrid;
        private Button AddStudentButton;
        private TextBox StudentNameText;
        private TextBox StudentSurnameText;
        private TextBox StudentBirthdayText;
    }
}

