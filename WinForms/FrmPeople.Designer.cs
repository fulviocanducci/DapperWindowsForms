namespace WinForms
{
   partial class FrmPeople
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
         LblId = new Label();
         LblName = new Label();
         LblActive = new Label();
         TxtId = new TextBox();
         TxtName = new TextBox();
         ChkActive = new CheckBox();
         ButSave = new Button();
         ButEnd = new Button();
         SuspendLayout();
         // 
         // LblId
         // 
         LblId.AutoSize = true;
         LblId.Location = new Point(13, 9);
         LblId.Name = "LblId";
         LblId.Size = new Size(17, 15);
         LblId.TabIndex = 0;
         LblId.Text = "Id";
         // 
         // LblName
         // 
         LblName.AutoSize = true;
         LblName.Location = new Point(13, 55);
         LblName.Name = "LblName";
         LblName.Size = new Size(40, 15);
         LblName.TabIndex = 2;
         LblName.Text = "Nome";
         // 
         // LblActive
         // 
         LblActive.AutoSize = true;
         LblActive.Location = new Point(13, 98);
         LblActive.Name = "LblActive";
         LblActive.Size = new Size(35, 15);
         LblActive.TabIndex = 4;
         LblActive.Text = "Ativo";
         // 
         // TxtId
         // 
         TxtId.Location = new Point(14, 27);
         TxtId.Name = "TxtId";
         TxtId.ReadOnly = true;
         TxtId.Size = new Size(100, 23);
         TxtId.TabIndex = 1;
         TxtId.TextAlign = HorizontalAlignment.Center;
         // 
         // TxtName
         // 
         TxtName.Location = new Point(14, 70);
         TxtName.Name = "TxtName";
         TxtName.Size = new Size(482, 23);
         TxtName.TabIndex = 3;
         // 
         // ChkActive
         // 
         ChkActive.AutoSize = true;
         ChkActive.Location = new Point(13, 118);
         ChkActive.Name = "ChkActive";
         ChkActive.Size = new Size(95, 19);
         ChkActive.TabIndex = 5;
         ChkActive.Text = "Ativo/Inativo";
         ChkActive.UseVisualStyleBackColor = true;
         // 
         // ButSave
         // 
         ButSave.ImageAlign = ContentAlignment.MiddleLeft;
         ButSave.ImageIndex = 1;
         ButSave.Location = new Point(12, 143);
         ButSave.Name = "ButSave";
         ButSave.Size = new Size(73, 37);
         ButSave.TabIndex = 6;
         ButSave.Text = "&Salvar";
         ButSave.UseVisualStyleBackColor = true;
         ButSave.Click += ButSave_Click;
         // 
         // ButEnd
         // 
         ButEnd.ImageAlign = ContentAlignment.MiddleLeft;
         ButEnd.ImageIndex = 1;
         ButEnd.Location = new Point(423, 143);
         ButEnd.Name = "ButEnd";
         ButEnd.Size = new Size(73, 37);
         ButEnd.TabIndex = 7;
         ButEnd.Text = "&Sair";
         ButEnd.UseVisualStyleBackColor = true;
         ButEnd.Click += ButEnd_Click;
         // 
         // FrmPeople
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(508, 191);
         Controls.Add(ButEnd);
         Controls.Add(ButSave);
         Controls.Add(ChkActive);
         Controls.Add(TxtName);
         Controls.Add(TxtId);
         Controls.Add(LblActive);
         Controls.Add(LblName);
         Controls.Add(LblId);
         FormBorderStyle = FormBorderStyle.FixedSingle;
         KeyPreview = true;
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "FrmPeople";
         StartPosition = FormStartPosition.CenterScreen;
         Text = "Modificações: Pessoas";
         Load += FrmPeople_Load;
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private Label LblId;
      private Label LblName;
      private Label LblActive;
      private TextBox TxtId;
      private TextBox TxtName;
      private CheckBox ChkActive;
      private Button ButSave;
      private Button ButEnd;
   }
}