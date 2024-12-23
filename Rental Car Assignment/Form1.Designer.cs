namespace Rental_Car_Assignment
{
    partial class Form1
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
            this.rent_date_box = new System.Windows.Forms.ComboBox();
            this.return_date_box = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.place_rental = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.liscense_plate_box = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.extra_charge_cost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Col_Plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Total_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Car_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Extra_Driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Rent_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Return_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Rental Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rent Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Return Date:";
            // 
            // rent_date_box
            // 
            this.rent_date_box.FormattingEnabled = true;
            this.rent_date_box.Location = new System.Drawing.Point(316, 91);
            this.rent_date_box.Name = "rent_date_box";
            this.rent_date_box.Size = new System.Drawing.Size(121, 21);
            this.rent_date_box.TabIndex = 3;
            this.rent_date_box.Text = "YYYY-MM-DD";
            // 
            // return_date_box
            // 
            this.return_date_box.FormattingEnabled = true;
            this.return_date_box.Location = new System.Drawing.Point(316, 134);
            this.return_date_box.Name = "return_date_box";
            this.return_date_box.Size = new System.Drawing.Size(121, 21);
            this.return_date_box.TabIndex = 4;
            this.return_date_box.Text = "YYYY-MM-DD";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(77, 58);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(113, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Compact($25/day)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(77, 99);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "SUV($40/day)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(77, 140);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(120, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Sports Car($60/day)";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(532, 91);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "ExtraDriver Charge";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // place_rental
            // 
            this.place_rental.Location = new System.Drawing.Point(316, 195);
            this.place_rental.Name = "place_rental";
            this.place_rental.Size = new System.Drawing.Size(121, 23);
            this.place_rental.TabIndex = 9;
            this.place_rental.Text = "Place Rental";
            this.place_rental.UseVisualStyleBackColor = true;
            this.place_rental.Click += new System.EventHandler(this.place_rental_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Liscense Plate";
            // 
            // liscense_plate_box
            // 
            this.liscense_plate_box.Location = new System.Drawing.Point(316, 238);
            this.liscense_plate_box.Name = "liscense_plate_box";
            this.liscense_plate_box.Size = new System.Drawing.Size(121, 20);
            this.liscense_plate_box.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Fill";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Plate,
            this.Col_Total_Cost,
            this.Col_Car_Type,
            this.Col_Extra_Driver,
            this.Col_Rent_Date,
            this.Col_Return_Date});
            this.dataGridView1.Location = new System.Drawing.Point(93, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 162);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // extra_charge_cost
            // 
            this.extra_charge_cost.Location = new System.Drawing.Point(532, 115);
            this.extra_charge_cost.Name = "extra_charge_cost";
            this.extra_charge_cost.Size = new System.Drawing.Size(100, 20);
            this.extra_charge_cost.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(639, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Extra Driver Cost";
            // 
            // Col_Plate
            // 
            this.Col_Plate.DataPropertyName = "Plate#";
            this.Col_Plate.Frozen = true;
            this.Col_Plate.HeaderText = "Plate";
            this.Col_Plate.Name = "Col_Plate";
            // 
            // Col_Total_Cost
            // 
            this.Col_Total_Cost.DataPropertyName = "Total_Cost";
            this.Col_Total_Cost.HeaderText = "Total Cost";
            this.Col_Total_Cost.Name = "Col_Total_Cost";
            // 
            // Col_Car_Type
            // 
            this.Col_Car_Type.DataPropertyName = "Car_Type";
            this.Col_Car_Type.HeaderText = "Car Type";
            this.Col_Car_Type.Name = "Col_Car_Type";
            // 
            // Col_Extra_Driver
            // 
            this.Col_Extra_Driver.DataPropertyName = "Extra_Driver";
            this.Col_Extra_Driver.HeaderText = "Extra Driver";
            this.Col_Extra_Driver.Name = "Col_Extra_Driver";
            // 
            // Col_Rent_Date
            // 
            this.Col_Rent_Date.DataPropertyName = "Rent_Date";
            this.Col_Rent_Date.HeaderText = "Rent Date";
            this.Col_Rent_Date.Name = "Col_Rent_Date";
            this.Col_Rent_Date.ReadOnly = true;
            // 
            // Col_Return_Date
            // 
            this.Col_Return_Date.DataPropertyName = "Return_Date";
            this.Col_Return_Date.HeaderText = "Return Date";
            this.Col_Return_Date.Name = "Col_Return_Date";
            this.Col_Return_Date.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.extra_charge_cost);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.liscense_plate_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.place_rental);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.return_date_box);
            this.Controls.Add(this.rent_date_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox rent_date_box;
        private System.Windows.Forms.ComboBox return_date_box;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button place_rental;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox liscense_plate_box;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox extra_charge_cost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Total_Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Car_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Extra_Driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Rent_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Return_Date;
    }
}

