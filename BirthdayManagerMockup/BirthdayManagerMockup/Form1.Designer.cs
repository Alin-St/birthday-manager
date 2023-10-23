namespace BirthdayManagerMockup;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        ListViewItem listViewItem1 = new ListViewItem(new string[] { "Alice", "120", "21" }, -1);
        ListViewItem listViewItem2 = new ListViewItem(new string[] { "Bob", "131", "22" }, -1);
        listView1 = new ListView();
        columnHeader1 = new ColumnHeader();
        columnHeader2 = new ColumnHeader();
        columnHeader3 = new ColumnHeader();
        checkBox1 = new CheckBox();
        label1 = new Label();
        pictureBox1 = new PictureBox();
        button1 = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // listView1
        // 
        listView1.BackColor = SystemColors.Window;
        listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
        listView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        listView1.GridLines = true;
        listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
        listView1.Location = new Point(38, 259);
        listView1.Name = "listView1";
        listView1.Size = new Size(340, 372);
        listView1.TabIndex = 0;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = View.Details;
        // 
        // columnHeader1
        // 
        columnHeader1.Text = "Name";
        columnHeader1.Width = 90;
        // 
        // columnHeader2
        // 
        columnHeader2.Text = "Remaining Days";
        columnHeader2.Width = 120;
        // 
        // columnHeader3
        // 
        columnHeader3.Text = "Future Age";
        columnHeader3.Width = 120;
        // 
        // checkBox1
        // 
        checkBox1.BackColor = SystemColors.ControlDark;
        checkBox1.FlatAppearance.BorderColor = Color.Black;
        checkBox1.FlatStyle = FlatStyle.Flat;
        checkBox1.Location = new Point(38, 184);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(340, 24);
        checkBox1.TabIndex = 1;
        checkBox1.Text = "Show only close family and friends";
        checkBox1.UseVisualStyleBackColor = false;
        // 
        // label1
        // 
        label1.BackColor = Color.FromArgb(255, 128, 128);
        label1.FlatStyle = FlatStyle.Flat;
        label1.Location = new Point(38, 236);
        label1.Name = "label1";
        label1.Size = new Size(340, 23);
        label1.TabIndex = 2;
        label1.Text = "You're offline. Entities might not be up-to-date";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.bm_pic;
        pictureBox1.Location = new Point(0, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(416, 149);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 3;
        pictureBox1.TabStop = false;
        // 
        // button1
        // 
        button1.BackColor = SystemColors.ControlDark;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        button1.Location = new Point(38, 659);
        button1.Name = "button1";
        button1.Size = new Size(340, 37);
        button1.TabIndex = 4;
        button1.Text = "Add new birthday";
        button1.UseVisualStyleBackColor = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(416, 729);
        Controls.Add(button1);
        Controls.Add(label1);
        Controls.Add(checkBox1);
        Controls.Add(listView1);
        Controls.Add(pictureBox1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private ListView listView1;
    private CheckBox checkBox1;
    private Label label1;
    private PictureBox pictureBox1;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private Button button1;
}
