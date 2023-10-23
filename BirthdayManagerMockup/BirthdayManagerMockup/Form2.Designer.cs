namespace BirthdayManagerMockup;

partial class Form2
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
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        label1 = new Label();
        label2 = new Label();
        checkBox1 = new CheckBox();
        dateTimePicker1 = new DateTimePicker();
        label3 = new Label();
        label4 = new Label();
        numericUpDown1 = new NumericUpDown();
        label5 = new Label();
        button1 = new Button();
        pictureBox1 = new PictureBox();
        panel1 = new Panel();
        button2 = new Button();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Location = new Point(122, 57);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(227, 29);
        textBox1.TabIndex = 0;
        textBox1.Text = "Alice";
        // 
        // textBox2
        // 
        textBox2.Location = new Point(122, 198);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(227, 29);
        textBox2.TabIndex = 1;
        textBox2.Text = "She likes paintball";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(17, 60);
        label1.Name = "label1";
        label1.Size = new Size(55, 21);
        label1.TabIndex = 2;
        label1.Text = "Name:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(17, 115);
        label2.Name = "label2";
        label2.Size = new Size(45, 21);
        label2.TabIndex = 3;
        label2.Text = "Date:";
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Checked = true;
        checkBox1.CheckState = CheckState.Checked;
        checkBox1.Location = new Point(17, 253);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(181, 25);
        checkBox1.TabIndex = 4;
        checkBox1.Text = "Is close family / friend";
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Location = new Point(122, 109);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(227, 29);
        dateTimePicker1.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(17, 157);
        label3.Name = "label3";
        label3.Size = new Size(43, 21);
        label3.TabIndex = 6;
        label3.Text = "Year:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(17, 201);
        label4.Name = "label4";
        label4.Size = new Size(99, 21);
        label4.TabIndex = 7;
        label4.Text = "More details:";
        // 
        // numericUpDown1
        // 
        numericUpDown1.Location = new Point(122, 155);
        numericUpDown1.Margin = new Padding(2, 1, 2, 1);
        numericUpDown1.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(227, 29);
        numericUpDown1.TabIndex = 8;
        numericUpDown1.Value = new decimal(new int[] { 1999, 0, 0, 0 });
        // 
        // label5
        // 
        label5.BackColor = SystemColors.InactiveCaption;
        label5.BorderStyle = BorderStyle.FixedSingle;
        label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        label5.Location = new Point(-1, 148);
        label5.Name = "label5";
        label5.Size = new Size(417, 47);
        label5.TabIndex = 9;
        label5.Text = "Adding new birthdate";
        label5.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // button1
        // 
        button1.BackColor = SystemColors.ControlDark;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        button1.Location = new Point(34, 596);
        button1.Name = "button1";
        button1.Size = new Size(344, 48);
        button1.TabIndex = 10;
        button1.Text = "Save birthdate";
        button1.UseVisualStyleBackColor = false;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.bm_pic;
        pictureBox1.Location = new Point(-1, -1);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(416, 149);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 11;
        pictureBox1.TabStop = false;
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.GradientActiveCaption;
        panel1.Controls.Add(label1);
        panel1.Controls.Add(textBox1);
        panel1.Controls.Add(textBox2);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(numericUpDown1);
        panel1.Controls.Add(checkBox1);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(dateTimePicker1);
        panel1.Controls.Add(label3);
        panel1.Location = new Point(21, 220);
        panel1.Name = "panel1";
        panel1.Size = new Size(372, 360);
        panel1.TabIndex = 12;
        // 
        // button2
        // 
        button2.BackColor = Color.FromArgb(255, 128, 128);
        button2.FlatStyle = FlatStyle.Flat;
        button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        button2.Location = new Point(34, 658);
        button2.Name = "button2";
        button2.Size = new Size(344, 30);
        button2.TabIndex = 13;
        button2.Text = "Cancel";
        button2.UseVisualStyleBackColor = false;
        // 
        // Form2
        // 
        AutoScaleMode = AutoScaleMode.None;
        ClientSize = new Size(416, 729);
        Controls.Add(button2);
        Controls.Add(panel1);
        Controls.Add(pictureBox1);
        Controls.Add(button1);
        Controls.Add(label5);
        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Form2";
        Text = "Form2";
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TextBox textBox1;
    private TextBox textBox2;
    private Label label1;
    private Label label2;
    private CheckBox checkBox1;
    private DateTimePicker dateTimePicker1;
    private Label label3;
    private Label label4;
    private NumericUpDown numericUpDown1;
    private Label label5;
    private Button button1;
    private PictureBox pictureBox1;
    private Panel panel1;
    private Button button2;
}