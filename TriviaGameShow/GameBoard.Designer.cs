using TriviaGameShow.Controls;

namespace TriviaGameShow
{
    partial class frmGameBoard
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pnlColumns = new System.Windows.Forms.TableLayoutPanel();
            this.pnlNames = new System.Windows.Forms.TableLayoutPanel();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.lblPlayer3Score = new System.Windows.Forms.Label();
            this.lblPlayer3Name = new System.Windows.Forms.Label();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.lblQuestionR5C3 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR5C2 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR5C1 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR5C6 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR5C5 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR5C4 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR4C3 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR4C2 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR4C1 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR4C6 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR4C5 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR4C4 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR3C3 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR3C2 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR3C1 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR3C6 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR3C5 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR3C4 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR2C3 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR2C2 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR2C1 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR2C6 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR2C5 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR2C4 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR1C1 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR1C3 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR1C2 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR1C4 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR1C6 = new TriviaGameShow.Controls.GradientLabel();
            this.lblQuestionR1C5 = new TriviaGameShow.Controls.GradientLabel();
            this.lblTitleC5 = new TriviaGameShow.Controls.GradientLabel();
            this.lblTitleC3 = new TriviaGameShow.Controls.GradientLabel();
            this.lblTitleC4 = new TriviaGameShow.Controls.GradientLabel();
            this.lblTitleC6 = new TriviaGameShow.Controls.GradientLabel();
            this.lblTitleC2 = new TriviaGameShow.Controls.GradientLabel();
            this.lblTitleC1 = new TriviaGameShow.Controls.GradientLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.pnlColumns.SuspendLayout();
            this.pnlNames.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(4, 5);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.pnlColumns);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer.Panel2.Controls.Add(this.pnlNames);
            this.splitContainer.Size = new System.Drawing.Size(1274, 817);
            this.splitContainer.SplitterDistance = 725;
            this.splitContainer.SplitterWidth = 3;
            this.splitContainer.TabIndex = 1;
            // 
            // pnlColumns
            // 
            this.pnlColumns.ColumnCount = 6;
            this.pnlColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlColumns.Controls.Add(this.lblQuestionR5C3, 0, 5);
            this.pnlColumns.Controls.Add(this.lblQuestionR5C2, 0, 5);
            this.pnlColumns.Controls.Add(this.lblQuestionR5C1, 0, 5);
            this.pnlColumns.Controls.Add(this.lblQuestionR5C6, 0, 5);
            this.pnlColumns.Controls.Add(this.lblQuestionR5C5, 0, 5);
            this.pnlColumns.Controls.Add(this.lblQuestionR5C4, 0, 5);
            this.pnlColumns.Controls.Add(this.lblQuestionR4C3, 0, 4);
            this.pnlColumns.Controls.Add(this.lblQuestionR4C2, 0, 4);
            this.pnlColumns.Controls.Add(this.lblQuestionR4C1, 0, 4);
            this.pnlColumns.Controls.Add(this.lblQuestionR4C6, 0, 4);
            this.pnlColumns.Controls.Add(this.lblQuestionR4C5, 0, 4);
            this.pnlColumns.Controls.Add(this.lblQuestionR4C4, 0, 4);
            this.pnlColumns.Controls.Add(this.lblQuestionR3C3, 0, 3);
            this.pnlColumns.Controls.Add(this.lblQuestionR3C2, 0, 3);
            this.pnlColumns.Controls.Add(this.lblQuestionR3C1, 0, 3);
            this.pnlColumns.Controls.Add(this.lblQuestionR3C6, 0, 3);
            this.pnlColumns.Controls.Add(this.lblQuestionR3C5, 0, 3);
            this.pnlColumns.Controls.Add(this.lblQuestionR3C4, 0, 3);
            this.pnlColumns.Controls.Add(this.lblQuestionR2C3, 0, 2);
            this.pnlColumns.Controls.Add(this.lblQuestionR2C2, 0, 2);
            this.pnlColumns.Controls.Add(this.lblQuestionR2C1, 0, 2);
            this.pnlColumns.Controls.Add(this.lblQuestionR2C6, 0, 2);
            this.pnlColumns.Controls.Add(this.lblQuestionR2C5, 0, 2);
            this.pnlColumns.Controls.Add(this.lblQuestionR2C4, 0, 2);
            this.pnlColumns.Controls.Add(this.lblQuestionR1C1, 0, 1);
            this.pnlColumns.Controls.Add(this.lblQuestionR1C3, 0, 1);
            this.pnlColumns.Controls.Add(this.lblQuestionR1C2, 0, 1);
            this.pnlColumns.Controls.Add(this.lblQuestionR1C4, 0, 1);
            this.pnlColumns.Controls.Add(this.lblQuestionR1C6, 0, 1);
            this.pnlColumns.Controls.Add(this.lblQuestionR1C5, 0, 1);
            this.pnlColumns.Controls.Add(this.lblTitleC5, 4, 0);
            this.pnlColumns.Controls.Add(this.lblTitleC3, 2, 0);
            this.pnlColumns.Controls.Add(this.lblTitleC4, 3, 0);
            this.pnlColumns.Controls.Add(this.lblTitleC6, 5, 0);
            this.pnlColumns.Controls.Add(this.lblTitleC2, 1, 0);
            this.pnlColumns.Controls.Add(this.lblTitleC1, 0, 0);
            this.pnlColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColumns.Location = new System.Drawing.Point(0, 0);
            this.pnlColumns.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.pnlColumns.Name = "pnlColumns";
            this.pnlColumns.RowCount = 6;
            this.pnlColumns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlColumns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlColumns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlColumns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlColumns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlColumns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlColumns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.pnlColumns.Size = new System.Drawing.Size(1274, 725);
            this.pnlColumns.TabIndex = 1;
            // 
            // pnlNames
            // 
            this.pnlNames.BackColor = System.Drawing.Color.Black;
            this.pnlNames.ColumnCount = 3;
            this.pnlNames.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlNames.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlNames.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlNames.Controls.Add(this.lblPlayer1Score, 0, 1);
            this.pnlNames.Controls.Add(this.lblPlayer2Score, 0, 1);
            this.pnlNames.Controls.Add(this.lblPlayer3Score, 0, 1);
            this.pnlNames.Controls.Add(this.lblPlayer3Name, 2, 0);
            this.pnlNames.Controls.Add(this.lblPlayer2Name, 1, 0);
            this.pnlNames.Controls.Add(this.lblPlayer1Name, 0, 0);
            this.pnlNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNames.Location = new System.Drawing.Point(0, 0);
            this.pnlNames.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.pnlNames.Name = "pnlNames";
            this.pnlNames.RowCount = 2;
            this.pnlNames.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.pnlNames.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.67F));
            this.pnlNames.Size = new System.Drawing.Size(1274, 89);
            this.pnlNames.TabIndex = 2;
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.BackColor = System.Drawing.Color.Black;
            this.lblPlayer1Score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold);
            this.lblPlayer1Score.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1Score.Location = new System.Drawing.Point(2, 31);
            this.lblPlayer1Score.Margin = new System.Windows.Forms.Padding(2);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(420, 56);
            this.lblPlayer1Score.TabIndex = 7;
            this.lblPlayer1Score.Text = "$0";
            this.lblPlayer1Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.BackColor = System.Drawing.Color.Black;
            this.lblPlayer2Score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlayer2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold);
            this.lblPlayer2Score.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2Score.Location = new System.Drawing.Point(426, 31);
            this.lblPlayer2Score.Margin = new System.Windows.Forms.Padding(2);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(420, 56);
            this.lblPlayer2Score.TabIndex = 6;
            this.lblPlayer2Score.Text = "$0";
            this.lblPlayer2Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer3Score
            // 
            this.lblPlayer3Score.AutoSize = true;
            this.lblPlayer3Score.BackColor = System.Drawing.Color.Black;
            this.lblPlayer3Score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlayer3Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold);
            this.lblPlayer3Score.ForeColor = System.Drawing.Color.White;
            this.lblPlayer3Score.Location = new System.Drawing.Point(850, 31);
            this.lblPlayer3Score.Margin = new System.Windows.Forms.Padding(2);
            this.lblPlayer3Score.Name = "lblPlayer3Score";
            this.lblPlayer3Score.Size = new System.Drawing.Size(422, 56);
            this.lblPlayer3Score.TabIndex = 5;
            this.lblPlayer3Score.Text = "$0";
            this.lblPlayer3Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer3Name
            // 
            this.lblPlayer3Name.AutoSize = true;
            this.lblPlayer3Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPlayer3Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlayer3Name.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblPlayer3Name.ForeColor = System.Drawing.Color.White;
            this.lblPlayer3Name.Location = new System.Drawing.Point(850, 2);
            this.lblPlayer3Name.Margin = new System.Windows.Forms.Padding(2);
            this.lblPlayer3Name.Name = "lblPlayer3Name";
            this.lblPlayer3Name.Size = new System.Drawing.Size(422, 25);
            this.lblPlayer3Name.TabIndex = 4;
            this.lblPlayer3Name.Text = "NAME THREE";
            this.lblPlayer3Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPlayer2Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlayer2Name.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblPlayer2Name.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2Name.Location = new System.Drawing.Point(426, 2);
            this.lblPlayer2Name.Margin = new System.Windows.Forms.Padding(2);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(420, 25);
            this.lblPlayer2Name.TabIndex = 1;
            this.lblPlayer2Name.Text = "NAME TWO";
            this.lblPlayer2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPlayer1Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlayer1Name.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Name.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1Name.Location = new System.Drawing.Point(2, 2);
            this.lblPlayer1Name.Margin = new System.Windows.Forms.Padding(2);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(420, 25);
            this.lblPlayer1Name.TabIndex = 0;
            this.lblPlayer1Name.Text = "NAME ONE";
            this.lblPlayer1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR5C3
            // 
            this.lblQuestionR5C3.AutoSize = true;
            this.lblQuestionR5C3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR5C3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR5C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR5C3.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR5C3.Location = new System.Drawing.Point(426, 602);
            this.lblQuestionR5C3.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR5C3.Name = "lblQuestionR5C3";
            this.lblQuestionR5C3.Size = new System.Drawing.Size(208, 121);
            this.lblQuestionR5C3.TabIndex = 36;
            this.lblQuestionR5C3.Text = "$100";
            this.lblQuestionR5C3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR5C2
            // 
            this.lblQuestionR5C2.AutoSize = true;
            this.lblQuestionR5C2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR5C2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR5C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR5C2.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR5C2.Location = new System.Drawing.Point(214, 602);
            this.lblQuestionR5C2.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR5C2.Name = "lblQuestionR5C2";
            this.lblQuestionR5C2.Size = new System.Drawing.Size(208, 121);
            this.lblQuestionR5C2.TabIndex = 35;
            this.lblQuestionR5C2.Text = "$100";
            this.lblQuestionR5C2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR5C1
            // 
            this.lblQuestionR5C1.AutoSize = true;
            this.lblQuestionR5C1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR5C1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR5C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR5C1.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR5C1.Location = new System.Drawing.Point(2, 602);
            this.lblQuestionR5C1.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR5C1.Name = "lblQuestionR5C1";
            this.lblQuestionR5C1.Size = new System.Drawing.Size(208, 121);
            this.lblQuestionR5C1.TabIndex = 34;
            this.lblQuestionR5C1.Text = "$100";
            this.lblQuestionR5C1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR5C6
            // 
            this.lblQuestionR5C6.AutoSize = true;
            this.lblQuestionR5C6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR5C6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR5C6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR5C6.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR5C6.Location = new System.Drawing.Point(1062, 602);
            this.lblQuestionR5C6.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR5C6.Name = "lblQuestionR5C6";
            this.lblQuestionR5C6.Size = new System.Drawing.Size(210, 121);
            this.lblQuestionR5C6.TabIndex = 33;
            this.lblQuestionR5C6.Text = "$100";
            this.lblQuestionR5C6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR5C5
            // 
            this.lblQuestionR5C5.AutoSize = true;
            this.lblQuestionR5C5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR5C5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR5C5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR5C5.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR5C5.Location = new System.Drawing.Point(850, 602);
            this.lblQuestionR5C5.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR5C5.Name = "lblQuestionR5C5";
            this.lblQuestionR5C5.Size = new System.Drawing.Size(208, 121);
            this.lblQuestionR5C5.TabIndex = 32;
            this.lblQuestionR5C5.Text = "$100";
            this.lblQuestionR5C5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR5C4
            // 
            this.lblQuestionR5C4.AutoSize = true;
            this.lblQuestionR5C4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR5C4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR5C4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR5C4.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR5C4.Location = new System.Drawing.Point(638, 602);
            this.lblQuestionR5C4.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR5C4.Name = "lblQuestionR5C4";
            this.lblQuestionR5C4.Size = new System.Drawing.Size(208, 121);
            this.lblQuestionR5C4.TabIndex = 31;
            this.lblQuestionR5C4.Text = "$100";
            this.lblQuestionR5C4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR4C3
            // 
            this.lblQuestionR4C3.AutoSize = true;
            this.lblQuestionR4C3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR4C3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR4C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR4C3.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR4C3.Location = new System.Drawing.Point(426, 482);
            this.lblQuestionR4C3.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR4C3.Name = "lblQuestionR4C3";
            this.lblQuestionR4C3.Size = new System.Drawing.Size(208, 116);
            this.lblQuestionR4C3.TabIndex = 30;
            this.lblQuestionR4C3.Text = "$100";
            this.lblQuestionR4C3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR4C2
            // 
            this.lblQuestionR4C2.AutoSize = true;
            this.lblQuestionR4C2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR4C2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR4C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR4C2.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR4C2.Location = new System.Drawing.Point(214, 482);
            this.lblQuestionR4C2.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR4C2.Name = "lblQuestionR4C2";
            this.lblQuestionR4C2.Size = new System.Drawing.Size(208, 116);
            this.lblQuestionR4C2.TabIndex = 29;
            this.lblQuestionR4C2.Text = "$100";
            this.lblQuestionR4C2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR4C1
            // 
            this.lblQuestionR4C1.AutoSize = true;
            this.lblQuestionR4C1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR4C1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR4C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR4C1.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR4C1.Location = new System.Drawing.Point(2, 482);
            this.lblQuestionR4C1.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR4C1.Name = "lblQuestionR4C1";
            this.lblQuestionR4C1.Size = new System.Drawing.Size(208, 116);
            this.lblQuestionR4C1.TabIndex = 28;
            this.lblQuestionR4C1.Text = "$100";
            this.lblQuestionR4C1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR4C6
            // 
            this.lblQuestionR4C6.AutoSize = true;
            this.lblQuestionR4C6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR4C6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR4C6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR4C6.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR4C6.Location = new System.Drawing.Point(1062, 482);
            this.lblQuestionR4C6.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR4C6.Name = "lblQuestionR4C6";
            this.lblQuestionR4C6.Size = new System.Drawing.Size(210, 116);
            this.lblQuestionR4C6.TabIndex = 27;
            this.lblQuestionR4C6.Text = "$100";
            this.lblQuestionR4C6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR4C5
            // 
            this.lblQuestionR4C5.AutoSize = true;
            this.lblQuestionR4C5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR4C5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR4C5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR4C5.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR4C5.Location = new System.Drawing.Point(850, 482);
            this.lblQuestionR4C5.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR4C5.Name = "lblQuestionR4C5";
            this.lblQuestionR4C5.Size = new System.Drawing.Size(208, 116);
            this.lblQuestionR4C5.TabIndex = 26;
            this.lblQuestionR4C5.Text = "$100";
            this.lblQuestionR4C5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR4C4
            // 
            this.lblQuestionR4C4.AutoSize = true;
            this.lblQuestionR4C4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR4C4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR4C4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR4C4.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR4C4.Location = new System.Drawing.Point(638, 482);
            this.lblQuestionR4C4.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR4C4.Name = "lblQuestionR4C4";
            this.lblQuestionR4C4.Size = new System.Drawing.Size(208, 116);
            this.lblQuestionR4C4.TabIndex = 25;
            this.lblQuestionR4C4.Text = "$100";
            this.lblQuestionR4C4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR3C3
            // 
            this.lblQuestionR3C3.AutoSize = true;
            this.lblQuestionR3C3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR3C3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR3C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR3C3.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR3C3.Location = new System.Drawing.Point(426, 362);
            this.lblQuestionR3C3.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR3C3.Name = "lblQuestionR3C3";
            this.lblQuestionR3C3.Size = new System.Drawing.Size(208, 116);
            this.lblQuestionR3C3.TabIndex = 24;
            this.lblQuestionR3C3.Text = "$100";
            this.lblQuestionR3C3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR3C2
            // 
            this.lblQuestionR3C2.AutoSize = true;
            this.lblQuestionR3C2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR3C2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR3C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR3C2.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR3C2.Location = new System.Drawing.Point(214, 362);
            this.lblQuestionR3C2.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR3C2.Name = "lblQuestionR3C2";
            this.lblQuestionR3C2.Size = new System.Drawing.Size(208, 116);
            this.lblQuestionR3C2.TabIndex = 23;
            this.lblQuestionR3C2.Text = "$100";
            this.lblQuestionR3C2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR3C1
            // 
            this.lblQuestionR3C1.AutoSize = true;
            this.lblQuestionR3C1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR3C1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR3C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR3C1.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR3C1.Location = new System.Drawing.Point(2, 362);
            this.lblQuestionR3C1.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR3C1.Name = "lblQuestionR3C1";
            this.lblQuestionR3C1.Size = new System.Drawing.Size(208, 116);
            this.lblQuestionR3C1.TabIndex = 22;
            this.lblQuestionR3C1.Text = "$100";
            this.lblQuestionR3C1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR3C6
            // 
            this.lblQuestionR3C6.AutoSize = true;
            this.lblQuestionR3C6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR3C6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR3C6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR3C6.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR3C6.Location = new System.Drawing.Point(1062, 362);
            this.lblQuestionR3C6.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR3C6.Name = "lblQuestionR3C6";
            this.lblQuestionR3C6.Size = new System.Drawing.Size(210, 116);
            this.lblQuestionR3C6.TabIndex = 21;
            this.lblQuestionR3C6.Text = "$100";
            this.lblQuestionR3C6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR3C5
            // 
            this.lblQuestionR3C5.AutoSize = true;
            this.lblQuestionR3C5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR3C5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR3C5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR3C5.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR3C5.Location = new System.Drawing.Point(850, 362);
            this.lblQuestionR3C5.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR3C5.Name = "lblQuestionR3C5";
            this.lblQuestionR3C5.Size = new System.Drawing.Size(208, 116);
            this.lblQuestionR3C5.TabIndex = 20;
            this.lblQuestionR3C5.Text = "$100";
            this.lblQuestionR3C5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR3C4
            // 
            this.lblQuestionR3C4.AutoSize = true;
            this.lblQuestionR3C4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR3C4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR3C4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR3C4.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR3C4.Location = new System.Drawing.Point(638, 362);
            this.lblQuestionR3C4.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR3C4.Name = "lblQuestionR3C4";
            this.lblQuestionR3C4.Size = new System.Drawing.Size(208, 116);
            this.lblQuestionR3C4.TabIndex = 19;
            this.lblQuestionR3C4.Text = "$100";
            this.lblQuestionR3C4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR2C3
            // 
            this.lblQuestionR2C3.AutoSize = true;
            this.lblQuestionR2C3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR2C3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR2C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR2C3.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR2C3.Location = new System.Drawing.Point(426, 242);
            this.lblQuestionR2C3.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR2C3.Name = "lblQuestionR2C3";
            this.lblQuestionR2C3.Size = new System.Drawing.Size(208, 116);
            this.lblQuestionR2C3.TabIndex = 18;
            this.lblQuestionR2C3.Text = "$100";
            this.lblQuestionR2C3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR2C2
            // 
            this.lblQuestionR2C2.AutoSize = true;
            this.lblQuestionR2C2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR2C2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR2C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR2C2.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR2C2.Location = new System.Drawing.Point(214, 242);
            this.lblQuestionR2C2.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR2C2.Name = "lblQuestionR2C2";
            this.lblQuestionR2C2.Size = new System.Drawing.Size(208, 116);
            this.lblQuestionR2C2.TabIndex = 17;
            this.lblQuestionR2C2.Text = "$100";
            this.lblQuestionR2C2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR2C1
            // 
            this.lblQuestionR2C1.AutoSize = true;
            this.lblQuestionR2C1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR2C1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR2C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR2C1.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR2C1.Location = new System.Drawing.Point(2, 242);
            this.lblQuestionR2C1.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR2C1.Name = "lblQuestionR2C1";
            this.lblQuestionR2C1.Size = new System.Drawing.Size(208, 116);
            this.lblQuestionR2C1.TabIndex = 16;
            this.lblQuestionR2C1.Text = "$100";
            this.lblQuestionR2C1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR2C6
            // 
            this.lblQuestionR2C6.AutoSize = true;
            this.lblQuestionR2C6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR2C6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR2C6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR2C6.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR2C6.Location = new System.Drawing.Point(1062, 242);
            this.lblQuestionR2C6.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR2C6.Name = "lblQuestionR2C6";
            this.lblQuestionR2C6.Size = new System.Drawing.Size(210, 116);
            this.lblQuestionR2C6.TabIndex = 15;
            this.lblQuestionR2C6.Text = "$100";
            this.lblQuestionR2C6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR2C5
            // 
            this.lblQuestionR2C5.AutoSize = true;
            this.lblQuestionR2C5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR2C5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR2C5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR2C5.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR2C5.Location = new System.Drawing.Point(850, 242);
            this.lblQuestionR2C5.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR2C5.Name = "lblQuestionR2C5";
            this.lblQuestionR2C5.Size = new System.Drawing.Size(208, 116);
            this.lblQuestionR2C5.TabIndex = 14;
            this.lblQuestionR2C5.Text = "$100";
            this.lblQuestionR2C5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR2C4
            // 
            this.lblQuestionR2C4.AutoSize = true;
            this.lblQuestionR2C4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR2C4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR2C4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR2C4.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR2C4.Location = new System.Drawing.Point(638, 242);
            this.lblQuestionR2C4.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR2C4.Name = "lblQuestionR2C4";
            this.lblQuestionR2C4.Size = new System.Drawing.Size(208, 116);
            this.lblQuestionR2C4.TabIndex = 13;
            this.lblQuestionR2C4.Text = "$100";
            this.lblQuestionR2C4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR1C1
            // 
            this.lblQuestionR1C1.AutoSize = true;
            this.lblQuestionR1C1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR1C1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR1C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR1C1.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR1C1.Location = new System.Drawing.Point(426, 122);
            this.lblQuestionR1C1.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR1C1.Name = "lblQuestionR1C1";
            this.lblQuestionR1C1.Size = new System.Drawing.Size(208, 116);
            this.lblQuestionR1C1.TabIndex = 12;
            this.lblQuestionR1C1.Text = "$100";
            this.lblQuestionR1C1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR1C3
            // 
            this.lblQuestionR1C3.AutoSize = true;
            this.lblQuestionR1C3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR1C3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR1C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR1C3.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR1C3.Location = new System.Drawing.Point(214, 122);
            this.lblQuestionR1C3.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR1C3.Name = "lblQuestionR1C3";
            this.lblQuestionR1C3.Size = new System.Drawing.Size(208, 116);
            this.lblQuestionR1C3.TabIndex = 11;
            this.lblQuestionR1C3.Text = "$100";
            this.lblQuestionR1C3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR1C2
            // 
            this.lblQuestionR1C2.AutoSize = true;
            this.lblQuestionR1C2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR1C2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR1C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR1C2.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR1C2.Location = new System.Drawing.Point(2, 122);
            this.lblQuestionR1C2.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR1C2.Name = "lblQuestionR1C2";
            this.lblQuestionR1C2.Size = new System.Drawing.Size(208, 116);
            this.lblQuestionR1C2.TabIndex = 10;
            this.lblQuestionR1C2.Text = "$100";
            this.lblQuestionR1C2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR1C4
            // 
            this.lblQuestionR1C4.AutoSize = true;
            this.lblQuestionR1C4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR1C4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR1C4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR1C4.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR1C4.Location = new System.Drawing.Point(1062, 122);
            this.lblQuestionR1C4.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR1C4.Name = "lblQuestionR1C4";
            this.lblQuestionR1C4.Size = new System.Drawing.Size(210, 116);
            this.lblQuestionR1C4.TabIndex = 9;
            this.lblQuestionR1C4.Text = "$100";
            this.lblQuestionR1C4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR1C6
            // 
            this.lblQuestionR1C6.AutoSize = true;
            this.lblQuestionR1C6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR1C6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR1C6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR1C6.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR1C6.Location = new System.Drawing.Point(850, 122);
            this.lblQuestionR1C6.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR1C6.Name = "lblQuestionR1C6";
            this.lblQuestionR1C6.Size = new System.Drawing.Size(208, 116);
            this.lblQuestionR1C6.TabIndex = 8;
            this.lblQuestionR1C6.Text = "$100";
            this.lblQuestionR1C6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionR1C5
            // 
            this.lblQuestionR1C5.AutoSize = true;
            this.lblQuestionR1C5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestionR1C5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionR1C5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblQuestionR1C5.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionR1C5.Location = new System.Drawing.Point(638, 122);
            this.lblQuestionR1C5.Margin = new System.Windows.Forms.Padding(2);
            this.lblQuestionR1C5.Name = "lblQuestionR1C5";
            this.lblQuestionR1C5.Size = new System.Drawing.Size(208, 116);
            this.lblQuestionR1C5.TabIndex = 7;
            this.lblQuestionR1C5.Text = "$100";
            this.lblQuestionR1C5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleC5
            // 
            this.lblTitleC5.AutoSize = true;
            this.lblTitleC5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitleC5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleC5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblTitleC5.ForeColor = System.Drawing.Color.White;
            this.lblTitleC5.Location = new System.Drawing.Point(850, 2);
            this.lblTitleC5.Margin = new System.Windows.Forms.Padding(2);
            this.lblTitleC5.Name = "lblTitleC5";
            this.lblTitleC5.Size = new System.Drawing.Size(208, 116);
            this.lblTitleC5.TabIndex = 5;
            this.lblTitleC5.Text = "Potent Potables";
            this.lblTitleC5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleC3
            // 
            this.lblTitleC3.AutoSize = true;
            this.lblTitleC3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitleC3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblTitleC3.ForeColor = System.Drawing.Color.White;
            this.lblTitleC3.Location = new System.Drawing.Point(426, 2);
            this.lblTitleC3.Margin = new System.Windows.Forms.Padding(2);
            this.lblTitleC3.Name = "lblTitleC3";
            this.lblTitleC3.Size = new System.Drawing.Size(208, 116);
            this.lblTitleC3.TabIndex = 4;
            this.lblTitleC3.Text = "Potent Potables";
            this.lblTitleC3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleC4
            // 
            this.lblTitleC4.AutoSize = true;
            this.lblTitleC4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitleC4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblTitleC4.ForeColor = System.Drawing.Color.White;
            this.lblTitleC4.Location = new System.Drawing.Point(638, 2);
            this.lblTitleC4.Margin = new System.Windows.Forms.Padding(2);
            this.lblTitleC4.Name = "lblTitleC4";
            this.lblTitleC4.Size = new System.Drawing.Size(208, 116);
            this.lblTitleC4.TabIndex = 3;
            this.lblTitleC4.Text = "Potent Potables";
            this.lblTitleC4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleC6
            // 
            this.lblTitleC6.AutoSize = true;
            this.lblTitleC6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitleC6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleC6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblTitleC6.ForeColor = System.Drawing.Color.White;
            this.lblTitleC6.Location = new System.Drawing.Point(1062, 2);
            this.lblTitleC6.Margin = new System.Windows.Forms.Padding(2);
            this.lblTitleC6.Name = "lblTitleC6";
            this.lblTitleC6.Size = new System.Drawing.Size(210, 116);
            this.lblTitleC6.TabIndex = 2;
            this.lblTitleC6.Text = "Potent Potables";
            this.lblTitleC6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleC2
            // 
            this.lblTitleC2.AutoSize = true;
            this.lblTitleC2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitleC2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblTitleC2.ForeColor = System.Drawing.Color.White;
            this.lblTitleC2.Location = new System.Drawing.Point(214, 2);
            this.lblTitleC2.Margin = new System.Windows.Forms.Padding(2);
            this.lblTitleC2.Name = "lblTitleC2";
            this.lblTitleC2.Size = new System.Drawing.Size(208, 116);
            this.lblTitleC2.TabIndex = 1;
            this.lblTitleC2.Text = "Potent Potables";
            this.lblTitleC2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleC1
            // 
            this.lblTitleC1.AutoSize = true;
            this.lblTitleC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitleC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblTitleC1.ForeColor = System.Drawing.Color.White;
            this.lblTitleC1.Location = new System.Drawing.Point(2, 2);
            this.lblTitleC1.Margin = new System.Windows.Forms.Padding(2);
            this.lblTitleC1.Name = "lblTitleC1";
            this.lblTitleC1.Size = new System.Drawing.Size(208, 116);
            this.lblTitleC1.TabIndex = 0;
            this.lblTitleC1.Text = "Potent Potables";
            this.lblTitleC1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1282, 827);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGameBoard";
            this.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowIcon = false;
            this.Text = "x";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.pnlColumns.ResumeLayout(false);
            this.pnlColumns.PerformLayout();
            this.pnlNames.ResumeLayout(false);
            this.pnlNames.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.Label lblPlayer3Name;
        private System.Windows.Forms.Label lblPlayer3Score;
        private GradientLabel lblTitleC1;
        private GradientLabel lblTitleC2;
        private GradientLabel lblTitleC3;
        private GradientLabel lblTitleC4;
        private GradientLabel lblTitleC6;
        private GradientLabel lblQuestionR1C1;
        private GradientLabel lblQuestionR1C2;
        private GradientLabel lblQuestionR1C3;
        private GradientLabel lblQuestionR1C4;
        private GradientLabel lblQuestionR1C5;
        private GradientLabel lblQuestionR1C6;
        private GradientLabel lblQuestionR2C1;
        private GradientLabel lblQuestionR2C2;
        private GradientLabel lblQuestionR2C3;
        private GradientLabel lblQuestionR2C4;
        private GradientLabel lblQuestionR2C5;
        private GradientLabel lblQuestionR2C6;
        private GradientLabel lblQuestionR3C1;
        private GradientLabel lblQuestionR3C2;
        private GradientLabel lblQuestionR3C3;
        private GradientLabel lblQuestionR3C4;
        private GradientLabel lblQuestionR3C5;
        private GradientLabel lblQuestionR3C6;
        private GradientLabel lblQuestionR4C1;
        private GradientLabel lblQuestionR4C2;
        private GradientLabel lblQuestionR4C3;
        private GradientLabel lblQuestionR4C4;
        private GradientLabel lblQuestionR4C5;
        private GradientLabel lblQuestionR4C6;
        private GradientLabel lblQuestionR5C1;
        private GradientLabel lblQuestionR5C2;
        private GradientLabel lblQuestionR5C3;
        private GradientLabel lblQuestionR5C4;
        private GradientLabel lblQuestionR5C5;
        private GradientLabel lblQuestionR5C6;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel pnlColumns;
        private System.Windows.Forms.TableLayoutPanel pnlNames;
        private GradientLabel lblTitleC5;
    }
}