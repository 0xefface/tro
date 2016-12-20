namespace decripter
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
            this.components = new System.ComponentModel.Container();
            this.rt_ip = new System.Windows.Forms.RichTextBox();
            this.rt_op = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_calculate = new System.Windows.Forms.Button();
            this.inputMenuStri = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.inputCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputCutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inutPasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputSelectAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.outputUndoLastToolStripMenuItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.outputCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputCutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputPasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputSelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputUndoLastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoLastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputMenuStri.SuspendLayout();
            this.outputUndoLastToolStripMenuItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // rt_ip
            // 
            this.rt_ip.ContextMenuStrip = this.inputMenuStri;
            this.rt_ip.Location = new System.Drawing.Point(12, 36);
            this.rt_ip.Name = "rt_ip";
            this.rt_ip.Size = new System.Drawing.Size(698, 195);
            this.rt_ip.TabIndex = 0;
            this.rt_ip.Text = "";
            // 
            // rt_op
            // 
            this.rt_op.ContextMenuStrip = this.outputUndoLastToolStripMenuItem;
            this.rt_op.Location = new System.Drawing.Point(12, 271);
            this.rt_op.Name = "rt_op";
            this.rt_op.Size = new System.Drawing.Size(698, 201);
            this.rt_op.TabIndex = 1;
            this.rt_op.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encrypted:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output";
            // 
            // bt_calculate
            // 
            this.bt_calculate.Location = new System.Drawing.Point(635, 240);
            this.bt_calculate.Name = "bt_calculate";
            this.bt_calculate.Size = new System.Drawing.Size(75, 23);
            this.bt_calculate.TabIndex = 3;
            this.bt_calculate.Text = "calculate";
            this.bt_calculate.UseVisualStyleBackColor = true;
            this.bt_calculate.Click += new System.EventHandler(this.bt_calculate_Click);
            // 
            // inputMenuStri
            // 
            this.inputMenuStri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputCopyToolStripMenuItem,
            this.inputCutToolStripMenuItem,
            this.inutPasteToolStripMenuItem,
            this.inputSelectAllToolStripMenuItem1,
            this.inputUndoLastToolStripMenuItem});
            this.inputMenuStri.Name = "inputMenuStrip";
            this.inputMenuStri.Size = new System.Drawing.Size(128, 114);
            // 
            // inputCopyToolStripMenuItem
            // 
            this.inputCopyToolStripMenuItem.Name = "inputCopyToolStripMenuItem";
            this.inputCopyToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.inputCopyToolStripMenuItem.Text = "Copy";
            this.inputCopyToolStripMenuItem.Click += new System.EventHandler(this.inputCopyToolStripMenuItem_Click);
            // 
            // inputCutToolStripMenuItem
            // 
            this.inputCutToolStripMenuItem.Name = "inputCutToolStripMenuItem";
            this.inputCutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.inputCutToolStripMenuItem.Text = "Cut";
            this.inputCutToolStripMenuItem.Click += new System.EventHandler(this.inputCutToolStripMenuItem_Click);
            // 
            // inutPasteToolStripMenuItem
            // 
            this.inutPasteToolStripMenuItem.Name = "inutPasteToolStripMenuItem";
            this.inutPasteToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.inutPasteToolStripMenuItem.Text = "Paste";
            this.inutPasteToolStripMenuItem.Click += new System.EventHandler(this.inutPasteToolStripMenuItem_Click);
            // 
            // inputSelectAllToolStripMenuItem1
            // 
            this.inputSelectAllToolStripMenuItem1.Name = "inputSelectAllToolStripMenuItem1";
            this.inputSelectAllToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.inputSelectAllToolStripMenuItem1.Text = "Select All";
            this.inputSelectAllToolStripMenuItem1.Click += new System.EventHandler(this.inputSelectAllToolStripMenuItem1_Click);
            // 
            // outputUndoLastToolStripMenuItem
            // 
            this.outputUndoLastToolStripMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputCopyToolStripMenuItem,
            this.outputCutToolStripMenuItem,
            this.outputPasteToolStripMenuItem,
            this.outputSelectAllToolStripMenuItem,
            this.undoLastToolStripMenuItem});
            this.outputUndoLastToolStripMenuItem.Name = "inputMenuStrip";
            this.outputUndoLastToolStripMenuItem.Size = new System.Drawing.Size(153, 136);
            // 
            // outputCopyToolStripMenuItem
            // 
            this.outputCopyToolStripMenuItem.Name = "outputCopyToolStripMenuItem";
            this.outputCopyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.outputCopyToolStripMenuItem.Text = "Copy";
            this.outputCopyToolStripMenuItem.Click += new System.EventHandler(this.outputCopyToolStripMenuItem_Click);
            // 
            // outputCutToolStripMenuItem
            // 
            this.outputCutToolStripMenuItem.Name = "outputCutToolStripMenuItem";
            this.outputCutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.outputCutToolStripMenuItem.Text = "Cut";
            this.outputCutToolStripMenuItem.Click += new System.EventHandler(this.outputCutToolStripMenuItem_Click);
            // 
            // outputPasteToolStripMenuItem
            // 
            this.outputPasteToolStripMenuItem.Name = "outputPasteToolStripMenuItem";
            this.outputPasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.outputPasteToolStripMenuItem.Text = "Paste";
            this.outputPasteToolStripMenuItem.Click += new System.EventHandler(this.outputPasteToolStripMenuItem_Click);
            // 
            // outputSelectAllToolStripMenuItem
            // 
            this.outputSelectAllToolStripMenuItem.Name = "outputSelectAllToolStripMenuItem";
            this.outputSelectAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.outputSelectAllToolStripMenuItem.Text = "Select All";
            this.outputSelectAllToolStripMenuItem.Click += new System.EventHandler(this.outputSelectAllToolStripMenuItem_Click);
            // 
            // inputUndoLastToolStripMenuItem
            // 
            this.inputUndoLastToolStripMenuItem.Name = "inputUndoLastToolStripMenuItem";
            this.inputUndoLastToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inputUndoLastToolStripMenuItem.Text = "Undo Last";
            this.inputUndoLastToolStripMenuItem.Click += new System.EventHandler(this.inputUndoLastToolStripMenuItem_Click);
            // 
            // undoLastToolStripMenuItem
            // 
            this.undoLastToolStripMenuItem.Name = "undoLastToolStripMenuItem";
            this.undoLastToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoLastToolStripMenuItem.Text = "Undo Last";
            this.undoLastToolStripMenuItem.Click += new System.EventHandler(this.undoLastToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 484);
            this.Controls.Add(this.bt_calculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rt_op);
            this.Controls.Add(this.rt_ip);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.inputMenuStri.ResumeLayout(false);
            this.outputUndoLastToolStripMenuItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt_ip;
        private System.Windows.Forms.RichTextBox rt_op;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_calculate;
        private System.Windows.Forms.ContextMenuStrip inputMenuStri;
        private System.Windows.Forms.ToolStripMenuItem inputCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputCutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inutPasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputSelectAllToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip outputUndoLastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputCutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputPasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputSelectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputUndoLastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoLastToolStripMenuItem;
    }
}

