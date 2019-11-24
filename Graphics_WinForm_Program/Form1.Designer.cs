namespace Graphics_WinForm_Program
{
    partial class frm_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PB_Draw = new System.Windows.Forms.PictureBox();
            this.btn_CreateLine = new System.Windows.Forms.Button();
            this.btn_DeleteLine = new System.Windows.Forms.Button();
            this.TB_Mouse_Coordinates = new System.Windows.Forms.TextBox();
            this.btn_Group = new System.Windows.Forms.Button();
            this.btn_Ungroup = new System.Windows.Forms.Button();
            this.dgv_Massive = new System.Windows.Forms.DataGridView();
            this.clm_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_OK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Exec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Draw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Massive)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Draw
            // 
            this.PB_Draw.Location = new System.Drawing.Point(1, 1);
            this.PB_Draw.Name = "PB_Draw";
            this.PB_Draw.Size = new System.Drawing.Size(650, 450);
            this.PB_Draw.TabIndex = 0;
            this.PB_Draw.TabStop = false;
            this.PB_Draw.Paint += new System.Windows.Forms.PaintEventHandler(this.PB_Draw_Paint);
            this.PB_Draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_Draw_MouseDown);
            this.PB_Draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_Draw_MouseMove);
            this.PB_Draw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PB_Draw_MouseUp);
            // 
            // btn_CreateLine
            // 
            this.btn_CreateLine.Location = new System.Drawing.Point(656, 12);
            this.btn_CreateLine.Name = "btn_CreateLine";
            this.btn_CreateLine.Size = new System.Drawing.Size(132, 22);
            this.btn_CreateLine.TabIndex = 1;
            this.btn_CreateLine.Text = "Create";
            this.btn_CreateLine.UseVisualStyleBackColor = true;
            this.btn_CreateLine.Click += new System.EventHandler(this.btn_CreateLine_Click);
            // 
            // btn_DeleteLine
            // 
            this.btn_DeleteLine.Location = new System.Drawing.Point(656, 41);
            this.btn_DeleteLine.Name = "btn_DeleteLine";
            this.btn_DeleteLine.Size = new System.Drawing.Size(132, 23);
            this.btn_DeleteLine.TabIndex = 2;
            this.btn_DeleteLine.Text = "Delete";
            this.btn_DeleteLine.UseVisualStyleBackColor = true;
            this.btn_DeleteLine.Click += new System.EventHandler(this.btn_DeleteLine_Click);
            // 
            // TB_Mouse_Coordinates
            // 
            this.TB_Mouse_Coordinates.Location = new System.Drawing.Point(657, 420);
            this.TB_Mouse_Coordinates.Name = "TB_Mouse_Coordinates";
            this.TB_Mouse_Coordinates.ReadOnly = true;
            this.TB_Mouse_Coordinates.Size = new System.Drawing.Size(131, 20);
            this.TB_Mouse_Coordinates.TabIndex = 3;
            // 
            // btn_Group
            // 
            this.btn_Group.Location = new System.Drawing.Point(657, 70);
            this.btn_Group.Name = "btn_Group";
            this.btn_Group.Size = new System.Drawing.Size(131, 23);
            this.btn_Group.TabIndex = 4;
            this.btn_Group.Text = "Group";
            this.btn_Group.UseVisualStyleBackColor = true;
            this.btn_Group.Click += new System.EventHandler(this.btn_Group_Click);
            // 
            // btn_Ungroup
            // 
            this.btn_Ungroup.Location = new System.Drawing.Point(657, 99);
            this.btn_Ungroup.Name = "btn_Ungroup";
            this.btn_Ungroup.Size = new System.Drawing.Size(131, 23);
            this.btn_Ungroup.TabIndex = 5;
            this.btn_Ungroup.Text = "Ungroup";
            this.btn_Ungroup.UseVisualStyleBackColor = true;
            this.btn_Ungroup.Click += new System.EventHandler(this.btn_Ungroup_Click);
            // 
            // dgv_Massive
            // 
            this.dgv_Massive.AllowUserToAddRows = false;
            this.dgv_Massive.AllowUserToDeleteRows = false;
            this.dgv_Massive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Massive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_X,
            this.clm_Y,
            this.clm_Z,
            this.clm_OK});
            this.dgv_Massive.Location = new System.Drawing.Point(658, 129);
            this.dgv_Massive.MultiSelect = false;
            this.dgv_Massive.Name = "dgv_Massive";
            this.dgv_Massive.Size = new System.Drawing.Size(390, 150);
            this.dgv_Massive.TabIndex = 6;
            // 
            // clm_X
            // 
            this.clm_X.HeaderText = "X";
            this.clm_X.Name = "clm_X";
            // 
            // clm_Y
            // 
            this.clm_Y.HeaderText = "Y";
            this.clm_Y.Name = "clm_Y";
            // 
            // clm_Z
            // 
            this.clm_Z.HeaderText = "Z";
            this.clm_Z.Name = "clm_Z";
            // 
            // clm_OK
            // 
            this.clm_OK.HeaderText = "OK";
            this.clm_OK.Name = "clm_OK";
            // 
            // btn_Exec
            // 
            this.btn_Exec.Location = new System.Drawing.Point(916, 294);
            this.btn_Exec.Name = "btn_Exec";
            this.btn_Exec.Size = new System.Drawing.Size(132, 22);
            this.btn_Exec.TabIndex = 7;
            this.btn_Exec.Text = "Execute";
            this.btn_Exec.UseVisualStyleBackColor = true;
            this.btn_Exec.Click += new System.EventHandler(this.btn_Exec_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 452);
            this.Controls.Add(this.btn_Exec);
            this.Controls.Add(this.dgv_Massive);
            this.Controls.Add(this.btn_Ungroup);
            this.Controls.Add(this.btn_Group);
            this.Controls.Add(this.TB_Mouse_Coordinates);
            this.Controls.Add(this.btn_DeleteLine);
            this.Controls.Add(this.btn_CreateLine);
            this.Controls.Add(this.PB_Draw);
            this.Name = "frm_Main";
            this.Text = "Graphics Project";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Draw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Massive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Draw;
        private System.Windows.Forms.Button btn_CreateLine;
        private System.Windows.Forms.Button btn_DeleteLine;
        private System.Windows.Forms.TextBox TB_Mouse_Coordinates;
        private System.Windows.Forms.Button btn_Group;
        private System.Windows.Forms.Button btn_Ungroup;
        private System.Windows.Forms.DataGridView dgv_Massive;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Z;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_OK;
        private System.Windows.Forms.Button btn_Exec;
    }
}

