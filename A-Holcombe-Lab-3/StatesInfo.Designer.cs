namespace A_Holcombe_Lab_3
{
    partial class StatesInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatesInfo));
            this.statesDBDataSet = new A_Holcombe_Lab_3.StatesDBDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new A_Holcombe_Lab_3.StatesDBDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new A_Holcombe_Lab_3.StatesDBDataSetTableAdapters.TableAdapterManager();
            this.tbPop = new System.Windows.Forms.TextBox();
            this.tbFlower = new System.Windows.Forms.TextBox();
            this.tbBird = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.tbCapitol = new System.Windows.Forms.TextBox();
            this.tbIncome = new System.Windows.Forms.TextBox();
            this.tbPercentage = new System.Windows.Forms.TextBox();
            this.buttSelect = new System.Windows.Forms.Button();
            this.buttExit = new System.Windows.Forms.Button();
            this.ttpInfo = new System.Windows.Forms.ToolTip(this.components);
            this.cbState = new System.Windows.Forms.ComboBox();
            this.lstbCities = new System.Windows.Forms.ListBox();
            this.pbStates = new System.Windows.Forms.PictureBox();
            this.tbFlag = new System.Windows.Forms.TextBox();
            this.buttClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStates)).BeginInit();
            this.SuspendLayout();
            // 
            // statesDBDataSet
            // 
            this.statesDBDataSet.DataSetName = "StatesDBDataSet";
            this.statesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.statesDBDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = A_Holcombe_Lab_3.StatesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbPop
            // 
            this.tbPop.AcceptsTab = true;
            this.tbPop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPop.Location = new System.Drawing.Point(10, 444);
            this.tbPop.Multiline = true;
            this.tbPop.Name = "tbPop";
            this.tbPop.Size = new System.Drawing.Size(121, 51);
            this.tbPop.TabIndex = 5;
            this.ttpInfo.SetToolTip(this.tbPop, "Population of State");
            // 
            // tbFlower
            // 
            this.tbFlower.AcceptsTab = true;
            this.tbFlower.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFlower.Location = new System.Drawing.Point(142, 444);
            this.tbFlower.Multiline = true;
            this.tbFlower.Name = "tbFlower";
            this.tbFlower.Size = new System.Drawing.Size(121, 51);
            this.tbFlower.TabIndex = 6;
            this.ttpInfo.SetToolTip(this.tbFlower, "State\'s Flower");
            // 
            // tbBird
            // 
            this.tbBird.AcceptsTab = true;
            this.tbBird.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBird.Location = new System.Drawing.Point(278, 444);
            this.tbBird.Multiline = true;
            this.tbBird.Name = "tbBird";
            this.tbBird.Size = new System.Drawing.Size(121, 51);
            this.tbBird.TabIndex = 7;
            this.ttpInfo.SetToolTip(this.tbBird, "State\'s Bird");
            // 
            // tbColor
            // 
            this.tbColor.AcceptsTab = true;
            this.tbColor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbColor.Location = new System.Drawing.Point(419, 444);
            this.tbColor.Multiline = true;
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(121, 51);
            this.tbColor.TabIndex = 8;
            this.ttpInfo.SetToolTip(this.tbColor, "State\'s Color( If empty no state color! )");
            // 
            // tbCapitol
            // 
            this.tbCapitol.AcceptsTab = true;
            this.tbCapitol.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCapitol.Location = new System.Drawing.Point(558, 444);
            this.tbCapitol.Multiline = true;
            this.tbCapitol.Name = "tbCapitol";
            this.tbCapitol.Size = new System.Drawing.Size(121, 51);
            this.tbCapitol.TabIndex = 9;
            this.ttpInfo.SetToolTip(this.tbCapitol, "State\'s Capitol");
            // 
            // tbIncome
            // 
            this.tbIncome.AcceptsTab = true;
            this.tbIncome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIncome.Location = new System.Drawing.Point(706, 444);
            this.tbIncome.Multiline = true;
            this.tbIncome.Name = "tbIncome";
            this.tbIncome.Size = new System.Drawing.Size(121, 51);
            this.tbIncome.TabIndex = 10;
            this.ttpInfo.SetToolTip(this.tbIncome, "State\'s Median Income");
            // 
            // tbPercentage
            // 
            this.tbPercentage.AcceptsTab = true;
            this.tbPercentage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPercentage.Location = new System.Drawing.Point(849, 444);
            this.tbPercentage.Multiline = true;
            this.tbPercentage.Name = "tbPercentage";
            this.tbPercentage.Size = new System.Drawing.Size(121, 51);
            this.tbPercentage.TabIndex = 11;
            this.ttpInfo.SetToolTip(this.tbPercentage, "State\'s Computer Jobs Percentage");
            // 
            // buttSelect
            // 
            this.buttSelect.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttSelect.Location = new System.Drawing.Point(227, 12);
            this.buttSelect.Name = "buttSelect";
            this.buttSelect.Size = new System.Drawing.Size(128, 52);
            this.buttSelect.TabIndex = 1;
            this.buttSelect.Text = "&Select State";
            this.ttpInfo.SetToolTip(this.buttSelect, "Click to select State");
            this.buttSelect.UseVisualStyleBackColor = true;
            this.buttSelect.Click += new System.EventHandler(this.buttSelect_Click);
            // 
            // buttExit
            // 
            this.buttExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttExit.Location = new System.Drawing.Point(371, 12);
            this.buttExit.Name = "buttExit";
            this.buttExit.Size = new System.Drawing.Size(128, 52);
            this.buttExit.TabIndex = 2;
            this.buttExit.Text = "E&xit";
            this.ttpInfo.SetToolTip(this.buttExit, "Click to exit");
            this.buttExit.UseVisualStyleBackColor = true;
            this.buttExit.Click += new System.EventHandler(this.buttExit_Click);
            // 
            // cbState
            // 
            this.cbState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "State", true));
            this.cbState.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(10, 12);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(201, 25);
            this.cbState.TabIndex = 14;
            this.ttpInfo.SetToolTip(this.cbState, "Select a State from the drop down to learn more!!");
            // 
            // lstbCities
            // 
            this.lstbCities.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tableBindingSource, "Cities", true));
            this.lstbCities.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbCities.FormattingEnabled = true;
            this.lstbCities.ItemHeight = 19;
            this.lstbCities.Location = new System.Drawing.Point(558, 330);
            this.lstbCities.Name = "lstbCities";
            this.lstbCities.Size = new System.Drawing.Size(357, 42);
            this.lstbCities.TabIndex = 18;
            this.ttpInfo.SetToolTip(this.lstbCities, "Top Three Cities in state");
            // 
            // pbStates
            // 
            this.pbStates.Enabled = false;
            this.pbStates.Image = global::A_Holcombe_Lab_3.Properties.Resources.States_Pic_removebg_preview;
            this.pbStates.Location = new System.Drawing.Point(-35, 52);
            this.pbStates.Name = "pbStates";
            this.pbStates.Size = new System.Drawing.Size(575, 378);
            this.pbStates.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStates.TabIndex = 12;
            this.pbStates.TabStop = false;
            // 
            // tbFlag
            // 
            this.tbFlag.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFlag.Location = new System.Drawing.Point(523, 24);
            this.tbFlag.Multiline = true;
            this.tbFlag.Name = "tbFlag";
            this.tbFlag.Size = new System.Drawing.Size(432, 290);
            this.tbFlag.TabIndex = 19;
            this.ttpInfo.SetToolTip(this.tbFlag, "State\'s Flag Info");
            // 
            // buttClear
            // 
            this.buttClear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttClear.Location = new System.Drawing.Point(675, 378);
            this.buttClear.Name = "buttClear";
            this.buttClear.Size = new System.Drawing.Size(128, 52);
            this.buttClear.TabIndex = 20;
            this.buttClear.Text = "&Clear";
            this.ttpInfo.SetToolTip(this.buttClear, "Click to clear info");
            this.buttClear.UseVisualStyleBackColor = true;
            this.buttClear.Click += new System.EventHandler(this.buttClear_Click);
            // 
            // StatesInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(982, 507);
            this.Controls.Add(this.buttClear);
            this.Controls.Add(this.tbFlag);
            this.Controls.Add(this.lstbCities);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.buttExit);
            this.Controls.Add(this.buttSelect);
            this.Controls.Add(this.tbPercentage);
            this.Controls.Add(this.tbIncome);
            this.Controls.Add(this.tbCapitol);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.tbBird);
            this.Controls.Add(this.tbFlower);
            this.Controls.Add(this.tbPop);
            this.Controls.Add(this.pbStates);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatesInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatesInfo";
            this.Load += new System.EventHandler(this.StatesInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatesDBDataSet statesDBDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private StatesDBDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private StatesDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbPop;
        private System.Windows.Forms.TextBox tbFlower;
        private System.Windows.Forms.TextBox tbBird;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.TextBox tbCapitol;
        private System.Windows.Forms.TextBox tbIncome;
        private System.Windows.Forms.TextBox tbPercentage;
        private System.Windows.Forms.Button buttSelect;
        private System.Windows.Forms.Button buttExit;
        private System.Windows.Forms.ToolTip ttpInfo;
        private System.Windows.Forms.PictureBox pbStates;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.ListBox lstbCities;
        private System.Windows.Forms.TextBox tbFlag;
        private System.Windows.Forms.Button buttClear;
    }
}