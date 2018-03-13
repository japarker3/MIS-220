namespace PokeDex
{
    partial class frmMain
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
            this.gbNewPokemon = new System.Windows.Forms.GroupBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHp = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblHp = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbSortBy = new System.Windows.Forms.GroupBox();
            this.btnSortHeight = new System.Windows.Forms.Button();
            this.btnSortWeight = new System.Windows.Forms.Button();
            this.btnSortType = new System.Windows.Forms.Button();
            this.btnSortHp = new System.Windows.Forms.Button();
            this.btnSortName = new System.Windows.Forms.Button();
            this.lblPokeDexSize = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.gbNewPokemon.SuspendLayout();
            this.gbSortBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNewPokemon
            // 
            this.gbNewPokemon.Controls.Add(this.cbType);
            this.gbNewPokemon.Controls.Add(this.txtName);
            this.gbNewPokemon.Controls.Add(this.btnAdd);
            this.gbNewPokemon.Controls.Add(this.txtHeight);
            this.gbNewPokemon.Controls.Add(this.txtWeight);
            this.gbNewPokemon.Controls.Add(this.txtHp);
            this.gbNewPokemon.Controls.Add(this.lblHeight);
            this.gbNewPokemon.Controls.Add(this.lblWeight);
            this.gbNewPokemon.Controls.Add(this.lblType);
            this.gbNewPokemon.Controls.Add(this.lblHp);
            this.gbNewPokemon.Controls.Add(this.lblName);
            this.gbNewPokemon.Location = new System.Drawing.Point(13, 13);
            this.gbNewPokemon.Name = "gbNewPokemon";
            this.gbNewPokemon.Size = new System.Drawing.Size(348, 213);
            this.gbNewPokemon.TabIndex = 0;
            this.gbNewPokemon.TabStop = false;
            this.gbNewPokemon.Text = "New Pokemon";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Bug",
            "Dark",
            "Dragon",
            "Electric",
            "Fairy",
            "Fighting",
            "Fire",
            "Flying",
            "Ghost",
            "Grass",
            "Ground",
            "Ice",
            "Normal",
            "Poison",
            "Psychic",
            "Rock",
            "Steel",
            "Water"});
            this.cbType.Location = new System.Drawing.Point(67, 87);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(275, 25);
            this.cbType.Sorted = true;
            this.cbType.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(275, 25);
            this.txtName.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(266, 179);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 28);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(67, 147);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(275, 25);
            this.txtHeight.TabIndex = 10;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(67, 117);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(275, 25);
            this.txtWeight.TabIndex = 9;
            // 
            // txtHp
            // 
            this.txtHp.Location = new System.Drawing.Point(67, 57);
            this.txtHp.Name = "txtHp";
            this.txtHp.Size = new System.Drawing.Size(275, 25);
            this.txtHp.TabIndex = 7;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(17, 150);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(46, 17);
            this.lblHeight.TabIndex = 5;
            this.lblHeight.Text = "Height";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(17, 120);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(48, 17);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Weight";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(17, 90);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(35, 17);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // lblHp
            // 
            this.lblHp.AutoSize = true;
            this.lblHp.Location = new System.Drawing.Point(17, 60);
            this.lblHp.Name = "lblHp";
            this.lblHp.Size = new System.Drawing.Size(24, 17);
            this.lblHp.TabIndex = 1;
            this.lblHp.Text = "HP";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // gbSortBy
            // 
            this.gbSortBy.Controls.Add(this.btnSortHeight);
            this.gbSortBy.Controls.Add(this.btnSortWeight);
            this.gbSortBy.Controls.Add(this.btnSortType);
            this.gbSortBy.Controls.Add(this.btnSortHp);
            this.gbSortBy.Controls.Add(this.btnSortName);
            this.gbSortBy.Location = new System.Drawing.Point(367, 13);
            this.gbSortBy.Name = "gbSortBy";
            this.gbSortBy.Size = new System.Drawing.Size(117, 213);
            this.gbSortBy.TabIndex = 1;
            this.gbSortBy.TabStop = false;
            this.gbSortBy.Text = "Sort By";
            // 
            // btnSortHeight
            // 
            this.btnSortHeight.Location = new System.Drawing.Point(21, 147);
            this.btnSortHeight.Name = "btnSortHeight";
            this.btnSortHeight.Size = new System.Drawing.Size(75, 25);
            this.btnSortHeight.TabIndex = 4;
            this.btnSortHeight.Text = "Height";
            this.btnSortHeight.UseVisualStyleBackColor = true;
            this.btnSortHeight.Click += new System.EventHandler(this.btnSortHeight_Click);
            // 
            // btnSortWeight
            // 
            this.btnSortWeight.Location = new System.Drawing.Point(21, 117);
            this.btnSortWeight.Name = "btnSortWeight";
            this.btnSortWeight.Size = new System.Drawing.Size(75, 25);
            this.btnSortWeight.TabIndex = 3;
            this.btnSortWeight.Text = "Weight";
            this.btnSortWeight.UseVisualStyleBackColor = true;
            this.btnSortWeight.Click += new System.EventHandler(this.btnSortWeight_Click);
            // 
            // btnSortType
            // 
            this.btnSortType.Location = new System.Drawing.Point(21, 87);
            this.btnSortType.Name = "btnSortType";
            this.btnSortType.Size = new System.Drawing.Size(75, 25);
            this.btnSortType.TabIndex = 2;
            this.btnSortType.Text = "Type";
            this.btnSortType.UseVisualStyleBackColor = true;
            this.btnSortType.Click += new System.EventHandler(this.btnSortType_Click);
            // 
            // btnSortHp
            // 
            this.btnSortHp.Location = new System.Drawing.Point(21, 57);
            this.btnSortHp.Name = "btnSortHp";
            this.btnSortHp.Size = new System.Drawing.Size(75, 25);
            this.btnSortHp.TabIndex = 1;
            this.btnSortHp.Text = "HP";
            this.btnSortHp.UseVisualStyleBackColor = true;
            this.btnSortHp.Click += new System.EventHandler(this.btnSortHp_Click);
            // 
            // btnSortName
            // 
            this.btnSortName.Location = new System.Drawing.Point(21, 27);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(75, 25);
            this.btnSortName.TabIndex = 0;
            this.btnSortName.Text = "Name";
            this.btnSortName.UseVisualStyleBackColor = true;
            this.btnSortName.Click += new System.EventHandler(this.btnSortName_Click);
            // 
            // lblPokeDexSize
            // 
            this.lblPokeDexSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPokeDexSize.AutoSize = true;
            this.lblPokeDexSize.Location = new System.Drawing.Point(617, 9);
            this.lblPokeDexSize.Name = "lblPokeDexSize";
            this.lblPokeDexSize.Size = new System.Drawing.Size(107, 17);
            this.lblPokeDexSize.TabIndex = 2;
            this.lblPokeDexSize.Text = "0 of 10 Pokemon";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(13, 233);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(50, 17);
            this.lblDisplay.TabIndex = 3;
            this.lblDisplay.Text = "Display";
            // 
            // txtDisplay
            // 
            this.txtDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisplay.Location = new System.Drawing.Point(16, 254);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDisplay.Size = new System.Drawing.Size(698, 285);
            this.txtDisplay.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(639, 545);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplay.Location = new System.Drawing.Point(558, 545);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 26);
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 591);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblPokeDexSize);
            this.Controls.Add(this.gbSortBy);
            this.Controls.Add(this.gbNewPokemon);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokeDex";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbNewPokemon.ResumeLayout(false);
            this.gbNewPokemon.PerformLayout();
            this.gbSortBy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewPokemon;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHp;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblHp;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbSortBy;
        private System.Windows.Forms.Button btnSortType;
        private System.Windows.Forms.Button btnSortHp;
        private System.Windows.Forms.Button btnSortName;
        private System.Windows.Forms.Button btnSortHeight;
        private System.Windows.Forms.Button btnSortWeight;
        private System.Windows.Forms.Label lblPokeDexSize;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ComboBox cbType;
    }
}

