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
            this.SB_Fi = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SB_Tetta = new System.Windows.Forms.HScrollBar();
            this.tb_Fi = new System.Windows.Forms.TextBox();
            this.tb_Tetta = new System.Windows.Forms.TextBox();
            this.tb_Z = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SB_Z = new System.Windows.Forms.HScrollBar();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_Normal = new System.Windows.Forms.Button();
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
            this.TB_Mouse_Coordinates.Location = new System.Drawing.Point(2, 455);
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
            // SB_Fi
            // 
            this.SB_Fi.Location = new System.Drawing.Point(658, 299);
            this.SB_Fi.Maximum = 72;
            this.SB_Fi.Name = "SB_Fi";
            this.SB_Fi.Size = new System.Drawing.Size(118, 17);
            this.SB_Fi.TabIndex = 9;
            this.SB_Fi.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SB_Fi_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(763, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "2pi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Фи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Тетта";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(763, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "2pi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(657, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "0";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // SB_Tetta
            // 
            this.SB_Tetta.Location = new System.Drawing.Point(658, 348);
            this.SB_Tetta.Maximum = 72;
            this.SB_Tetta.Name = "SB_Tetta";
            this.SB_Tetta.Size = new System.Drawing.Size(118, 17);
            this.SB_Tetta.TabIndex = 13;
            this.SB_Tetta.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // tb_Fi
            // 
            this.tb_Fi.Location = new System.Drawing.Point(785, 299);
            this.tb_Fi.Name = "tb_Fi";
            this.tb_Fi.ReadOnly = true;
            this.tb_Fi.Size = new System.Drawing.Size(44, 20);
            this.tb_Fi.TabIndex = 17;
            // 
            // tb_Tetta
            // 
            this.tb_Tetta.Location = new System.Drawing.Point(785, 348);
            this.tb_Tetta.Name = "tb_Tetta";
            this.tb_Tetta.ReadOnly = true;
            this.tb_Tetta.Size = new System.Drawing.Size(44, 20);
            this.tb_Tetta.TabIndex = 18;
            // 
            // tb_Z
            // 
            this.tb_Z.Location = new System.Drawing.Point(785, 397);
            this.tb_Z.Name = "tb_Z";
            this.tb_Z.ReadOnly = true;
            this.tb_Z.Size = new System.Drawing.Size(44, 20);
            this.tb_Z.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(660, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Z схода";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(763, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "400";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(660, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "50";
            // 
            // SB_Z
            // 
            this.SB_Z.Location = new System.Drawing.Point(658, 397);
            this.SB_Z.Maximum = 400;
            this.SB_Z.Minimum = 50;
            this.SB_Z.Name = "SB_Z";
            this.SB_Z.Size = new System.Drawing.Size(118, 17);
            this.SB_Z.TabIndex = 19;
            this.SB_Z.Value = 50;
            this.SB_Z.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(754, 430);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(75, 23);
            this.btn_Show.TabIndex = 24;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_Normal
            // 
            this.btn_Normal.Location = new System.Drawing.Point(850, 346);
            this.btn_Normal.Name = "btn_Normal";
            this.btn_Normal.Size = new System.Drawing.Size(75, 23);
            this.btn_Normal.TabIndex = 25;
            this.btn_Normal.Text = "ToNormal";
            this.btn_Normal.UseVisualStyleBackColor = true;
            this.btn_Normal.Click += new System.EventHandler(this.btn_Normal_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 477);
            this.Controls.Add(this.btn_Normal);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.tb_Z);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SB_Z);
            this.Controls.Add(this.tb_Tetta);
            this.Controls.Add(this.tb_Fi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SB_Tetta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SB_Fi);
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
        private System.Windows.Forms.HScrollBar SB_Fi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.HScrollBar SB_Tetta;
        private System.Windows.Forms.TextBox tb_Fi;
        private System.Windows.Forms.TextBox tb_Tetta;
        private System.Windows.Forms.TextBox tb_Z;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.HScrollBar SB_Z;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Button btn_Normal;
    }
}

