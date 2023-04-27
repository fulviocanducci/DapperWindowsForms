namespace WinForms
{
   partial class FrmPrincipal
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
         DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
         DataGridViewPeople = new DataGridView();
         ColumnId = new DataGridViewTextBoxColumn();
         ColumnName = new DataGridViewTextBoxColumn();
         ColumnActive = new DataGridViewCheckBoxColumn();
         ButNew = new Button();
         ButEdit = new Button();
         BtuEnd = new Button();
         TxtFilter = new TextBox();
         ButFilter = new Button();
         ((System.ComponentModel.ISupportInitialize)DataGridViewPeople).BeginInit();
         SuspendLayout();
         // 
         // DataGridViewPeople
         // 
         DataGridViewPeople.AllowUserToAddRows = false;
         DataGridViewPeople.AllowUserToDeleteRows = false;
         DataGridViewPeople.AllowUserToResizeColumns = false;
         DataGridViewPeople.AllowUserToResizeRows = false;
         DataGridViewPeople.BackgroundColor = Color.FromArgb(255, 255, 200);
         DataGridViewPeople.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
         dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.BackColor = SystemColors.Control;
         dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
         dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
         dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
         DataGridViewPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         DataGridViewPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         DataGridViewPeople.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnName, ColumnActive });
         DataGridViewPeople.Location = new Point(12, 41);
         DataGridViewPeople.Name = "DataGridViewPeople";
         DataGridViewPeople.ReadOnly = true;
         DataGridViewPeople.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
         DataGridViewPeople.RowTemplate.Height = 25;
         DataGridViewPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
         DataGridViewPeople.ShowCellErrors = false;
         DataGridViewPeople.ShowCellToolTips = false;
         DataGridViewPeople.ShowEditingIcon = false;
         DataGridViewPeople.ShowRowErrors = false;
         DataGridViewPeople.Size = new Size(776, 376);
         DataGridViewPeople.TabIndex = 0;
         DataGridViewPeople.CellDoubleClick += DataGridViewPeople_CellDoubleClick;
         DataGridViewPeople.PreviewKeyDown += DataGridViewPeople_PreviewKeyDown;
         // 
         // ColumnId
         // 
         ColumnId.DataPropertyName = "Id";
         ColumnId.HeaderText = "Id";
         ColumnId.Name = "ColumnId";
         ColumnId.ReadOnly = true;
         // 
         // ColumnName
         // 
         ColumnName.DataPropertyName = "Name";
         ColumnName.HeaderText = "Nome";
         ColumnName.Name = "ColumnName";
         ColumnName.ReadOnly = true;
         ColumnName.Width = 500;
         // 
         // ColumnActive
         // 
         ColumnActive.DataPropertyName = "Active";
         ColumnActive.HeaderText = "Ativo";
         ColumnActive.Name = "ColumnActive";
         ColumnActive.ReadOnly = true;
         // 
         // ButNew
         // 
         ButNew.ImageAlign = ContentAlignment.MiddleLeft;
         ButNew.ImageIndex = 1;
         ButNew.Location = new Point(12, 431);
         ButNew.Name = "ButNew";
         ButNew.Size = new Size(73, 37);
         ButNew.TabIndex = 1;
         ButNew.Text = "&Novo";
         ButNew.UseVisualStyleBackColor = true;
         ButNew.Click += ButNew_Click;
         // 
         // ButEdit
         // 
         ButEdit.ImageAlign = ContentAlignment.MiddleLeft;
         ButEdit.ImageIndex = 3;
         ButEdit.Location = new Point(91, 431);
         ButEdit.Name = "ButEdit";
         ButEdit.Size = new Size(73, 37);
         ButEdit.TabIndex = 2;
         ButEdit.Text = "&Alterar";
         ButEdit.UseVisualStyleBackColor = true;
         ButEdit.Click += ButEdit_Click;
         // 
         // BtuEnd
         // 
         BtuEnd.Location = new Point(702, 431);
         BtuEnd.Name = "BtuEnd";
         BtuEnd.Size = new Size(86, 37);
         BtuEnd.TabIndex = 3;
         BtuEnd.Text = "Sai&r";
         BtuEnd.UseVisualStyleBackColor = true;
         BtuEnd.Click += BtuEnd_Click;
         // 
         // TxtFilter
         // 
         TxtFilter.Location = new Point(12, 12);
         TxtFilter.Name = "TxtFilter";
         TxtFilter.PlaceholderText = "Digite o nome";
         TxtFilter.Size = new Size(706, 23);
         TxtFilter.TabIndex = 4;
         TxtFilter.KeyUp += TxtFilter_KeyUp;
         // 
         // ButFilter
         // 
         ButFilter.Location = new Point(719, 12);
         ButFilter.Name = "ButFilter";
         ButFilter.Size = new Size(67, 23);
         ButFilter.TabIndex = 5;
         ButFilter.Text = "Pesquisar";
         ButFilter.UseVisualStyleBackColor = true;
         ButFilter.Click += ButFilter_Click;
         // 
         // FrmPrincipal
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         CancelButton = BtuEnd;
         ClientSize = new Size(800, 480);
         Controls.Add(ButFilter);
         Controls.Add(TxtFilter);
         Controls.Add(BtuEnd);
         Controls.Add(ButEdit);
         Controls.Add(ButNew);
         Controls.Add(DataGridViewPeople);
         FormBorderStyle = FormBorderStyle.FixedSingle;
         KeyPreview = true;
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "FrmPrincipal";
         StartPosition = FormStartPosition.CenterScreen;
         Text = "Pessoas";
         Load += FrmPrincipal_Load;
         ((System.ComponentModel.ISupportInitialize)DataGridViewPeople).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private DataGridView DataGridViewPeople;
      private DataGridViewTextBoxColumn ColumnId;
      private DataGridViewTextBoxColumn ColumnName;
      private DataGridViewCheckBoxColumn ColumnActive;
      private Button ButNew;
      private Button ButEdit;
      private Button BtuEnd;
      private TextBox TxtFilter;
      private Button ButFilter;
   }
}