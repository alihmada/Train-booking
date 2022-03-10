namespace Train_Boocking
{
    partial class addNewTrain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addNewTrain));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNewTrain = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMove = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArrive = new System.Windows.Forms.TextBox();
            this.txtDeiverID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(618, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 26;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNewTrain
            // 
            this.btnAddNewTrain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewTrain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewTrain.Location = new System.Drawing.Point(119, 339);
            this.btnAddNewTrain.Name = "btnAddNewTrain";
            this.btnAddNewTrain.Size = new System.Drawing.Size(440, 38);
            this.btnAddNewTrain.TabIndex = 25;
            this.btnAddNewTrain.Text = "OK";
            this.btnAddNewTrain.UseVisualStyleBackColor = true;
            this.btnAddNewTrain.Click += new System.EventHandler(this.btnAddNewTrain_Click);
            this.btnAddNewTrain.MouseEnter += new System.EventHandler(this.btnAddNewTrain_MouseEnter);
            this.btnAddNewTrain.MouseLeave += new System.EventHandler(this.btnAddNewTrain_MouseLeave);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(192, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(440, 39);
            this.txtName.TabIndex = 15;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 58);
            this.label1.TabIndex = 14;
            this.label1.Text = "Add New Train";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this._MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUp);
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(192, 133);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(440, 39);
            this.txtID.TabIndex = 16;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            // 
            // txtMove
            // 
            this.txtMove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMove.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMove.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMove.Location = new System.Drawing.Point(192, 178);
            this.txtMove.Name = "txtMove";
            this.txtMove.Size = new System.Drawing.Size(440, 39);
            this.txtMove.TabIndex = 17;
            this.txtMove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMove.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMove_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(73, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 28);
            this.label6.TabIndex = 24;
            this.label6.Text = "Train ID:";
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
            this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(this._MouseMove);
            this.label6.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUp);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(60, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Driver ID:";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this._MouseMove);
            this.label5.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUp);
            // 
            // txtArrive
            // 
            this.txtArrive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtArrive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArrive.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArrive.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtArrive.Location = new System.Drawing.Point(192, 223);
            this.txtArrive.Name = "txtArrive";
            this.txtArrive.Size = new System.Drawing.Size(440, 39);
            this.txtArrive.TabIndex = 18;
            this.txtArrive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArrive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArrive_KeyDown);
            // 
            // txtDeiverID
            // 
            this.txtDeiverID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDeiverID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeiverID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeiverID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDeiverID.Location = new System.Drawing.Point(192, 268);
            this.txtDeiverID.Name = "txtDeiverID";
            this.txtDeiverID.Size = new System.Drawing.Size(440, 39);
            this.txtDeiverID.TabIndex = 19;
            this.txtDeiverID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDeiverID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDeiverID_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(32, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Train Name:";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this._MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUp);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(8, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "Arriving Time:";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this._MouseMove);
            this.label4.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUp);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(20, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Moving Time:";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this._MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUp);
            // 
            // addNewTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(662, 389);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNewTrain);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtMove);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtArrive);
            this.Controls.Add(this.txtDeiverID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addNewTrain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "addNewTrain";
            this.Load += new System.EventHandler(this.addNewTrain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this._MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExit;
        private Button btnAddNewTrain;
        private TextBox txtName;
        private Label label1;
        private TextBox txtID;
        private TextBox txtMove;
        private Label label6;
        private Label label5;
        private TextBox txtArrive;
        private TextBox txtDeiverID;
        private Label label2;
        private Label label4;
        private Label label3;
    }
}