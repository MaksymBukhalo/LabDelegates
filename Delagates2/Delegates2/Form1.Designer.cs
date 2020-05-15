namespace Delegates2
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
            this.btnTransparency = new System.Windows.Forms.Button();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.btnHelloWorld = new System.Windows.Forms.Button();
            this.btnSetOfActions = new System.Windows.Forms.Button();
            this.checkBoxTransparency = new System.Windows.Forms.CheckBox();
            this.checkBoxBackgroundColor = new System.Windows.Forms.CheckBox();
            this.checkBoxHelloWorld = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnTransparency
            // 
            this.btnTransparency.Location = new System.Drawing.Point(18, 12);
            this.btnTransparency.Name = "btnTransparency";
            this.btnTransparency.Size = new System.Drawing.Size(79, 26);
            this.btnTransparency.TabIndex = 0;
            this.btnTransparency.Text = "Прозорість";
            this.btnTransparency.UseVisualStyleBackColor = true;
            this.btnTransparency.Click += new System.EventHandler(this.btnTransparency_Click);
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Location = new System.Drawing.Point(103, 12);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(75, 25);
            this.btnBackgroundColor.TabIndex = 1;
            this.btnBackgroundColor.Text = "Колір тла";
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // btnHelloWorld
            // 
            this.btnHelloWorld.Location = new System.Drawing.Point(184, 12);
            this.btnHelloWorld.Name = "btnHelloWorld";
            this.btnHelloWorld.Size = new System.Drawing.Size(77, 25);
            this.btnHelloWorld.TabIndex = 2;
            this.btnHelloWorld.Text = "Hello World";
            this.btnHelloWorld.UseVisualStyleBackColor = true;
            this.btnHelloWorld.Click += new System.EventHandler(this.btnHelloWorld_Click);
            // 
            // btnSetOfActions
            // 
            this.btnSetOfActions.Location = new System.Drawing.Point(18, 48);
            this.btnSetOfActions.Name = "btnSetOfActions";
            this.btnSetOfActions.Size = new System.Drawing.Size(242, 23);
            this.btnSetOfActions.TabIndex = 3;
            this.btnSetOfActions.Text = "Супермегакнопка";
            this.btnSetOfActions.UseVisualStyleBackColor = true;
            this.btnSetOfActions.Click += new System.EventHandler(this.btnSetOfActions_Click);
            // 
            // checkBoxTransparency
            // 
            this.checkBoxTransparency.Location = new System.Drawing.Point(18, 83);
            this.checkBoxTransparency.Name = "checkBoxTransparency";
            this.checkBoxTransparency.Size = new System.Drawing.Size(241, 21);
            this.checkBoxTransparency.TabIndex = 4;
            this.checkBoxTransparency.Text = "Супермегакнопка поглинає Прозорість";
            this.checkBoxTransparency.UseVisualStyleBackColor = true;
            this.checkBoxTransparency.Click += new System.EventHandler(this.checkBoxTransparency_Click);
            // 
            // checkBoxBackgroundColor
            // 
            this.checkBoxBackgroundColor.Location = new System.Drawing.Point(18, 110);
            this.checkBoxBackgroundColor.Name = "checkBoxBackgroundColor";
            this.checkBoxBackgroundColor.Size = new System.Drawing.Size(241, 21);
            this.checkBoxBackgroundColor.TabIndex = 5;
            this.checkBoxBackgroundColor.Text = "Супермегакнопка поглинає Колір тла";
            this.checkBoxBackgroundColor.UseVisualStyleBackColor = true;
            this.checkBoxBackgroundColor.Click += new System.EventHandler(this.checkBoxBackgroundColor_Click);
            // 
            // checkBoxHelloWorld
            // 
            this.checkBoxHelloWorld.Location = new System.Drawing.Point(18, 137);
            this.checkBoxHelloWorld.Name = "checkBoxHelloWorld";
            this.checkBoxHelloWorld.Size = new System.Drawing.Size(241, 21);
            this.checkBoxHelloWorld.TabIndex = 6;
            this.checkBoxHelloWorld.Text = "Супермегакнопка поглинає Hello World";
            this.checkBoxHelloWorld.UseVisualStyleBackColor = true;
            this.checkBoxHelloWorld.Click += new System.EventHandler(this.checkBoxHelloWorld_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 287);
            this.Controls.Add(this.checkBoxHelloWorld);
            this.Controls.Add(this.checkBoxBackgroundColor);
            this.Controls.Add(this.checkBoxTransparency);
            this.Controls.Add(this.btnSetOfActions);
            this.Controls.Add(this.btnHelloWorld);
            this.Controls.Add(this.btnBackgroundColor);
            this.Controls.Add(this.btnTransparency);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.Button btnHelloWorld;
        private System.Windows.Forms.Button btnSetOfActions;
        private System.Windows.Forms.Button btnTransparency;
        private System.Windows.Forms.CheckBox checkBoxBackgroundColor;
        private System.Windows.Forms.CheckBox checkBoxHelloWorld;
        private System.Windows.Forms.CheckBox checkBoxTransparency;

        #endregion
    }
}