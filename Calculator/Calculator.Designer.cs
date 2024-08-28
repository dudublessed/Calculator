using System.Windows.Forms;

namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            typedBox = new TextBox();
            clearButton = new Button();
            divisionButton = new Button();
            multiplyButton = new Button();
            subtractButton = new Button();
            addButton = new Button();
            resultButton = new Button();
            nineButton = new Button();
            eightButton = new Button();
            sevenButton = new Button();
            sixButton = new Button();
            fiveButton = new Button();
            fourButton = new Button();
            oneButton = new Button();
            twoButton = new Button();
            threeButton = new Button();
            zeroButton = new Button();
            previewBox = new TextBox();
            decimalButton = new Button();
            signalButton = new Button();
            SuspendLayout();
            // 
            // typedBox
            // 
            typedBox.BackColor = Color.Black;
            typedBox.BorderStyle = BorderStyle.None;
            typedBox.Enabled = false;
            typedBox.Font = new Font("Arial", 30F, FontStyle.Bold);
            typedBox.ForeColor = Color.Brown;
            typedBox.Location = new Point(12, 73);
            typedBox.Name = "typedBox";
            typedBox.PlaceholderText = "0";
            typedBox.ReadOnly = true;
            typedBox.RightToLeft = RightToLeft.No;
            typedBox.Size = new Size(357, 46);
            typedBox.TabIndex = 0;
            typedBox.TextAlign = HorizontalAlignment.Right;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.DimGray;
            clearButton.BackgroundImageLayout = ImageLayout.None;
            clearButton.FlatAppearance.BorderColor = Color.Black;
            clearButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            clearButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.ForeColor = Color.White;
            clearButton.ImageAlign = ContentAlignment.MiddleRight;
            clearButton.Location = new Point(284, 168);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(85, 46);
            clearButton.TabIndex = 1;
            clearButton.Text = "C";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // divisionButton
            // 
            divisionButton.BackColor = Color.DimGray;
            divisionButton.BackgroundImageLayout = ImageLayout.None;
            divisionButton.FlatAppearance.BorderColor = Color.Black;
            divisionButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            divisionButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            divisionButton.FlatStyle = FlatStyle.Flat;
            divisionButton.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            divisionButton.ForeColor = Color.White;
            divisionButton.ImageAlign = ContentAlignment.MiddleRight;
            divisionButton.Location = new Point(284, 220);
            divisionButton.Name = "divisionButton";
            divisionButton.Size = new Size(85, 46);
            divisionButton.TabIndex = 2;
            divisionButton.Text = "÷";
            divisionButton.UseVisualStyleBackColor = false;
            divisionButton.Click += divisionButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.BackColor = Color.DimGray;
            multiplyButton.BackgroundImageLayout = ImageLayout.None;
            multiplyButton.FlatAppearance.BorderColor = Color.Black;
            multiplyButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            multiplyButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            multiplyButton.FlatStyle = FlatStyle.Flat;
            multiplyButton.Font = new Font("Arial", 16F);
            multiplyButton.ForeColor = Color.White;
            multiplyButton.ImageAlign = ContentAlignment.MiddleRight;
            multiplyButton.Location = new Point(284, 272);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(85, 46);
            multiplyButton.TabIndex = 3;
            multiplyButton.Text = "×";
            multiplyButton.UseVisualStyleBackColor = false;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // subtractButton
            // 
            subtractButton.BackColor = Color.DimGray;
            subtractButton.BackgroundImageLayout = ImageLayout.None;
            subtractButton.FlatAppearance.BorderColor = Color.Black;
            subtractButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            subtractButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            subtractButton.FlatStyle = FlatStyle.Flat;
            subtractButton.Font = new Font("Arial", 16F);
            subtractButton.ForeColor = Color.White;
            subtractButton.ImageAlign = ContentAlignment.MiddleRight;
            subtractButton.Location = new Point(284, 324);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(85, 46);
            subtractButton.TabIndex = 4;
            subtractButton.Text = "-";
            subtractButton.UseVisualStyleBackColor = false;
            subtractButton.Click += subtractButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.DimGray;
            addButton.BackgroundImageLayout = ImageLayout.None;
            addButton.FlatAppearance.BorderColor = Color.Black;
            addButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            addButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Arial", 16F);
            addButton.ForeColor = Color.White;
            addButton.ImageAlign = ContentAlignment.MiddleRight;
            addButton.Location = new Point(284, 376);
            addButton.Name = "addButton";
            addButton.Size = new Size(85, 46);
            addButton.TabIndex = 5;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // resultButton
            // 
            resultButton.BackColor = Color.DimGray;
            resultButton.BackgroundImageLayout = ImageLayout.None;
            resultButton.FlatAppearance.BorderColor = Color.Black;
            resultButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            resultButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            resultButton.FlatStyle = FlatStyle.Flat;
            resultButton.Font = new Font("Arial", 16F);
            resultButton.ForeColor = Color.White;
            resultButton.ImageAlign = ContentAlignment.MiddleRight;
            resultButton.Location = new Point(284, 428);
            resultButton.Name = "resultButton";
            resultButton.Size = new Size(85, 46);
            resultButton.TabIndex = 6;
            resultButton.Text = "=";
            resultButton.UseVisualStyleBackColor = false;
            resultButton.Click += resultButton_Click;
            // 
            // nineButton
            // 
            nineButton.BackColor = Color.DimGray;
            nineButton.BackgroundImageLayout = ImageLayout.None;
            nineButton.FlatAppearance.BorderColor = Color.Black;
            nineButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            nineButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            nineButton.FlatStyle = FlatStyle.Flat;
            nineButton.Font = new Font("Arial", 16F);
            nineButton.ForeColor = Color.White;
            nineButton.ImageAlign = ContentAlignment.MiddleRight;
            nineButton.Location = new Point(193, 272);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(85, 46);
            nineButton.TabIndex = 7;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = false;
            nineButton.Click += nineButton_Click;
            // 
            // eightButton
            // 
            eightButton.BackColor = Color.DimGray;
            eightButton.BackgroundImageLayout = ImageLayout.None;
            eightButton.FlatAppearance.BorderColor = Color.Black;
            eightButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            eightButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            eightButton.FlatStyle = FlatStyle.Flat;
            eightButton.Font = new Font("Arial", 16F);
            eightButton.ForeColor = Color.White;
            eightButton.ImageAlign = ContentAlignment.MiddleRight;
            eightButton.Location = new Point(102, 272);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(85, 46);
            eightButton.TabIndex = 8;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = false;
            eightButton.Click += eightButton_Click;
            // 
            // sevenButton
            // 
            sevenButton.BackColor = Color.DimGray;
            sevenButton.BackgroundImageLayout = ImageLayout.None;
            sevenButton.FlatAppearance.BorderColor = Color.Black;
            sevenButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            sevenButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            sevenButton.FlatStyle = FlatStyle.Flat;
            sevenButton.Font = new Font("Arial", 16F);
            sevenButton.ForeColor = Color.White;
            sevenButton.ImageAlign = ContentAlignment.MiddleRight;
            sevenButton.Location = new Point(12, 272);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(85, 46);
            sevenButton.TabIndex = 9;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = false;
            sevenButton.Click += sevenButton_Click;
            // 
            // sixButton
            // 
            sixButton.BackColor = Color.DimGray;
            sixButton.BackgroundImageLayout = ImageLayout.None;
            sixButton.FlatAppearance.BorderColor = Color.Black;
            sixButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            sixButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            sixButton.FlatStyle = FlatStyle.Flat;
            sixButton.Font = new Font("Arial", 16F);
            sixButton.ForeColor = Color.White;
            sixButton.ImageAlign = ContentAlignment.MiddleRight;
            sixButton.Location = new Point(193, 324);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(85, 46);
            sixButton.TabIndex = 10;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = false;
            sixButton.Click += sixButton_Click;
            // 
            // fiveButton
            // 
            fiveButton.BackColor = Color.DimGray;
            fiveButton.BackgroundImageLayout = ImageLayout.None;
            fiveButton.FlatAppearance.BorderColor = Color.Black;
            fiveButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            fiveButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            fiveButton.FlatStyle = FlatStyle.Flat;
            fiveButton.Font = new Font("Arial", 16F);
            fiveButton.ForeColor = Color.White;
            fiveButton.ImageAlign = ContentAlignment.MiddleRight;
            fiveButton.Location = new Point(102, 324);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(85, 46);
            fiveButton.TabIndex = 11;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = false;
            fiveButton.Click += fiveButton_Click;
            // 
            // fourButton
            // 
            fourButton.BackColor = Color.DimGray;
            fourButton.BackgroundImageLayout = ImageLayout.None;
            fourButton.FlatAppearance.BorderColor = Color.Black;
            fourButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            fourButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            fourButton.FlatStyle = FlatStyle.Flat;
            fourButton.Font = new Font("Arial", 16F);
            fourButton.ForeColor = Color.White;
            fourButton.ImageAlign = ContentAlignment.MiddleRight;
            fourButton.Location = new Point(12, 324);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(85, 46);
            fourButton.TabIndex = 12;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = false;
            fourButton.Click += fourButton_Click;
            // 
            // oneButton
            // 
            oneButton.BackColor = Color.DimGray;
            oneButton.BackgroundImageLayout = ImageLayout.None;
            oneButton.FlatAppearance.BorderColor = Color.Black;
            oneButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            oneButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            oneButton.FlatStyle = FlatStyle.Flat;
            oneButton.Font = new Font("Arial", 16F);
            oneButton.ForeColor = Color.White;
            oneButton.ImageAlign = ContentAlignment.MiddleRight;
            oneButton.Location = new Point(12, 376);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(85, 46);
            oneButton.TabIndex = 13;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = false;
            oneButton.Click += oneButton_Click;
            // 
            // twoButton
            // 
            twoButton.BackColor = Color.DimGray;
            twoButton.BackgroundImageLayout = ImageLayout.None;
            twoButton.FlatAppearance.BorderColor = Color.Black;
            twoButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            twoButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            twoButton.FlatStyle = FlatStyle.Flat;
            twoButton.Font = new Font("Arial", 16F);
            twoButton.ForeColor = Color.White;
            twoButton.ImageAlign = ContentAlignment.MiddleRight;
            twoButton.Location = new Point(103, 376);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(85, 46);
            twoButton.TabIndex = 14;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = false;
            twoButton.Click += twoButton_Click;
            // 
            // threeButton
            // 
            threeButton.BackColor = Color.DimGray;
            threeButton.BackgroundImageLayout = ImageLayout.None;
            threeButton.FlatAppearance.BorderColor = Color.Black;
            threeButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            threeButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            threeButton.FlatStyle = FlatStyle.Flat;
            threeButton.Font = new Font("Arial", 16F);
            threeButton.ForeColor = Color.White;
            threeButton.ImageAlign = ContentAlignment.MiddleRight;
            threeButton.Location = new Point(193, 376);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(85, 46);
            threeButton.TabIndex = 15;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = false;
            threeButton.Click += threeButton_Click;
            // 
            // zeroButton
            // 
            zeroButton.BackColor = Color.DimGray;
            zeroButton.BackgroundImageLayout = ImageLayout.None;
            zeroButton.FlatAppearance.BorderColor = Color.Black;
            zeroButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            zeroButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            zeroButton.FlatStyle = FlatStyle.Flat;
            zeroButton.Font = new Font("Arial", 16F);
            zeroButton.ForeColor = Color.White;
            zeroButton.ImageAlign = ContentAlignment.MiddleRight;
            zeroButton.Location = new Point(103, 428);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(85, 46);
            zeroButton.TabIndex = 16;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = false;
            zeroButton.Click += zeroButton_Click;
            // 
            // previewBox
            // 
            previewBox.BackColor = Color.Black;
            previewBox.BorderStyle = BorderStyle.None;
            previewBox.Enabled = false;
            previewBox.Font = new Font("Arial", 12F, FontStyle.Bold);
            previewBox.ForeColor = Color.White;
            previewBox.Location = new Point(12, 48);
            previewBox.Name = "previewBox";
            previewBox.ReadOnly = true;
            previewBox.Size = new Size(357, 19);
            previewBox.TabIndex = 17;
            previewBox.TextAlign = HorizontalAlignment.Right;
            // 
            // decimalButton
            // 
            decimalButton.BackColor = Color.DimGray;
            decimalButton.BackgroundImageLayout = ImageLayout.None;
            decimalButton.FlatAppearance.BorderColor = Color.Black;
            decimalButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            decimalButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            decimalButton.FlatStyle = FlatStyle.Flat;
            decimalButton.Font = new Font("Arial", 16F);
            decimalButton.ForeColor = Color.White;
            decimalButton.ImageAlign = ContentAlignment.MiddleRight;
            decimalButton.Location = new Point(193, 428);
            decimalButton.Name = "decimalButton";
            decimalButton.Size = new Size(85, 46);
            decimalButton.TabIndex = 18;
            decimalButton.Text = ",";
            decimalButton.UseVisualStyleBackColor = false;
            decimalButton.Click += decimalButton_Click;
            // 
            // signalButton
            // 
            signalButton.BackColor = Color.DimGray;
            signalButton.BackgroundImageLayout = ImageLayout.None;
            signalButton.FlatAppearance.BorderColor = Color.Black;
            signalButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            signalButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            signalButton.FlatStyle = FlatStyle.Flat;
            signalButton.Font = new Font("Arial", 16F);
            signalButton.ForeColor = Color.White;
            signalButton.ImageAlign = ContentAlignment.MiddleRight;
            signalButton.Location = new Point(12, 428);
            signalButton.Name = "signalButton";
            signalButton.Size = new Size(85, 46);
            signalButton.TabIndex = 19;
            signalButton.Text = "±";
            signalButton.UseVisualStyleBackColor = false;
            signalButton.Click += signalButton_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(381, 486);
            Controls.Add(signalButton);
            Controls.Add(decimalButton);
            Controls.Add(previewBox);
            Controls.Add(zeroButton);
            Controls.Add(threeButton);
            Controls.Add(twoButton);
            Controls.Add(oneButton);
            Controls.Add(fourButton);
            Controls.Add(fiveButton);
            Controls.Add(sixButton);
            Controls.Add(sevenButton);
            Controls.Add(eightButton);
            Controls.Add(nineButton);
            Controls.Add(resultButton);
            Controls.Add(addButton);
            Controls.Add(subtractButton);
            Controls.Add(multiplyButton);
            Controls.Add(divisionButton);
            Controls.Add(clearButton);
            Controls.Add(typedBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox typedBox;
        private Button clearButton;
        private Button divisionButton;
        private Button multiplyButton;
        private Button subtractButton;
        private Button addButton;
        private Button resultButton;
        private Button nineButton;
        private Button eightButton;
        private Button sevenButton;
        private Button sixButton;
        private Button fiveButton;
        private Button fourButton;
        private Button oneButton;
        private Button twoButton;
        private Button threeButton;
        private Button zeroButton;
        private TextBox previewBox;
        private Button decimalButton;
        private Button signalButton;
    }
}
