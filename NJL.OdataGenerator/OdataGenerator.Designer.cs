// PROJECT : NJL.OdataGenerator
// This plugin was developed by Nizar JLASSI

namespace NJL.OdataGenerator
{
    partial class OdataGenerator
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdataGenerator));
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbCloseThisTab = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLoadEntities = new System.Windows.Forms.ToolStripButton();
            this.tsbLoadAttributes = new System.Windows.Forms.ToolStripButton();
            this.tsbGenerateOdata = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cbxEntities = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAttributes = new System.Windows.Forms.GroupBox();
            this.gvAttributes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.gbSelectingAttributes = new System.Windows.Forms.GroupBox();
            this.btnClearSelect = new System.Windows.Forms.Button();
            this.gvSelectingAttributes = new System.Windows.Forms.DataGridView();
            this.gbFilteringAttributes = new System.Windows.Forms.GroupBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.gvFilteringAttributes = new System.Windows.Forms.DataGridView();
            this.gbOrderingAttributes = new System.Windows.Forms.GroupBox();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.gvOrderingAttributes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxtOdataQueryUrl = new System.Windows.Forms.RichTextBox();
            this.txtSkip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxExpand = new System.Windows.Forms.GroupBox();
            this.btnClearSelectExtandAttributes = new System.Windows.Forms.Button();
            this.cbxlRelationships = new System.Windows.Forms.CheckedListBox();
            this.gvExpandAttributes = new System.Windows.Forms.DataGridView();
            this.gvExpand = new System.Windows.Forms.DataGridView();
            this.cbxUseExpand = new System.Windows.Forms.CheckBox();
            this.tsMain.SuspendLayout();
            this.gbAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAttributes)).BeginInit();
            this.gbSelectingAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelectingAttributes)).BeginInit();
            this.gbFilteringAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFilteringAttributes)).BeginInit();
            this.gbOrderingAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderingAttributes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbxExpand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvExpandAttributes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExpand)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.AutoSize = false;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCloseThisTab,
            this.toolStripSeparator2,
            this.tsbLoadEntities,
            this.tsbLoadAttributes,
            this.tsbGenerateOdata,
            this.toolStripSeparator3});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1600, 25);
            this.tsMain.TabIndex = 91;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbCloseThisTab
            // 
            this.tsbCloseThisTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCloseThisTab.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tsbCloseThisTab.Image = ((System.Drawing.Image)(resources.GetObject("tsbCloseThisTab.Image")));
            this.tsbCloseThisTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCloseThisTab.Name = "tsbCloseThisTab";
            this.tsbCloseThisTab.Size = new System.Drawing.Size(23, 22);
            this.tsbCloseThisTab.Text = "Close this tab";
            this.tsbCloseThisTab.Click += new System.EventHandler(this.tsbCloseThisTab_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbLoadEntities
            // 
            this.tsbLoadEntities.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tsbLoadEntities.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadEntities.Image")));
            this.tsbLoadEntities.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadEntities.Name = "tsbLoadEntities";
            this.tsbLoadEntities.Size = new System.Drawing.Size(93, 22);
            this.tsbLoadEntities.Text = "Load Entities";
            this.tsbLoadEntities.Click += new System.EventHandler(this.tsbLoadEntities_Click);
            // 
            // tsbLoadAttributes
            // 
            this.tsbLoadAttributes.Enabled = false;
            this.tsbLoadAttributes.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tsbLoadAttributes.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadAttributes.Image")));
            this.tsbLoadAttributes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadAttributes.Name = "tsbLoadAttributes";
            this.tsbLoadAttributes.Size = new System.Drawing.Size(182, 22);
            this.tsbLoadAttributes.Text = "Load Attributes And Relationships";
            this.tsbLoadAttributes.Click += new System.EventHandler(this.tsbLoadAttributes_Click);
            // 
            // tsbGenerateOdata
            // 
            this.tsbGenerateOdata.Enabled = false;
            this.tsbGenerateOdata.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tsbGenerateOdata.Image = ((System.Drawing.Image)(resources.GetObject("tsbGenerateOdata.Image")));
            this.tsbGenerateOdata.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGenerateOdata.Name = "tsbGenerateOdata";
            this.tsbGenerateOdata.Size = new System.Drawing.Size(109, 22);
            this.tsbGenerateOdata.Text = "Generate Odata";
            this.tsbGenerateOdata.Click += new System.EventHandler(this.tsbGenerateOdata_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // cbxEntities
            // 
            this.cbxEntities.Enabled = false;
            this.cbxEntities.FormattingEnabled = true;
            this.cbxEntities.Location = new System.Drawing.Point(59, 42);
            this.cbxEntities.Name = "cbxEntities";
            this.cbxEntities.Size = new System.Drawing.Size(459, 21);
            this.cbxEntities.TabIndex = 92;
            this.cbxEntities.SelectedIndexChanged += new System.EventHandler(this.cbxEntities_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Entity :";
            // 
            // gbAttributes
            // 
            this.gbAttributes.Controls.Add(this.gvAttributes);
            this.gbAttributes.Location = new System.Drawing.Point(17, 78);
            this.gbAttributes.Name = "gbAttributes";
            this.gbAttributes.Size = new System.Drawing.Size(574, 593);
            this.gbAttributes.TabIndex = 94;
            this.gbAttributes.TabStop = false;
            this.gbAttributes.Text = "Attributes";
            // 
            // gvAttributes
            // 
            this.gvAttributes.AllowUserToAddRows = false;
            this.gvAttributes.AllowUserToDeleteRows = false;
            this.gvAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAttributes.Location = new System.Drawing.Point(7, 20);
            this.gvAttributes.Name = "gvAttributes";
            this.gvAttributes.Size = new System.Drawing.Size(561, 559);
            this.gvAttributes.TabIndex = 0;
            this.gvAttributes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAttributes_CellValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Top :";
            // 
            // txtTop
            // 
            this.txtTop.Location = new System.Drawing.Point(637, 42);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(157, 20);
            this.txtTop.TabIndex = 96;
            this.txtTop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTop_KeyPress);
            // 
            // gbSelectingAttributes
            // 
            this.gbSelectingAttributes.Controls.Add(this.btnClearSelect);
            this.gbSelectingAttributes.Controls.Add(this.gvSelectingAttributes);
            this.gbSelectingAttributes.Location = new System.Drawing.Point(594, 78);
            this.gbSelectingAttributes.Name = "gbSelectingAttributes";
            this.gbSelectingAttributes.Size = new System.Drawing.Size(488, 205);
            this.gbSelectingAttributes.TabIndex = 97;
            this.gbSelectingAttributes.TabStop = false;
            this.gbSelectingAttributes.Text = "Select Attributes";
            // 
            // btnClearSelect
            // 
            this.btnClearSelect.Location = new System.Drawing.Point(389, 0);
            this.btnClearSelect.Name = "btnClearSelect";
            this.btnClearSelect.Size = new System.Drawing.Size(75, 20);
            this.btnClearSelect.TabIndex = 2;
            this.btnClearSelect.Text = "Clear";
            this.btnClearSelect.UseVisualStyleBackColor = true;
            this.btnClearSelect.Click += new System.EventHandler(this.btnClearSelect_Click);
            // 
            // gvSelectingAttributes
            // 
            this.gvSelectingAttributes.AllowUserToAddRows = false;
            this.gvSelectingAttributes.AllowUserToDeleteRows = false;
            this.gvSelectingAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvSelectingAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSelectingAttributes.Location = new System.Drawing.Point(7, 26);
            this.gvSelectingAttributes.Name = "gvSelectingAttributes";
            this.gvSelectingAttributes.ReadOnly = true;
            this.gvSelectingAttributes.Size = new System.Drawing.Size(475, 173);
            this.gvSelectingAttributes.TabIndex = 0;

            this.gbFilteringAttributes.Controls.Add(this.btnClearFilter);
            this.gbFilteringAttributes.Controls.Add(this.gvFilteringAttributes);
            this.gbFilteringAttributes.Location = new System.Drawing.Point(594, 289);
            this.gbFilteringAttributes.Name = "gbFilteringAttributes";
            this.gbFilteringAttributes.Size = new System.Drawing.Size(491, 218);
            this.gbFilteringAttributes.TabIndex = 98;
            this.gbFilteringAttributes.TabStop = false;
            this.gbFilteringAttributes.Text = "Filtering Attributes";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(389, 0);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(75, 20);
            this.btnClearFilter.TabIndex = 1;
            this.btnClearFilter.Text = "Clear";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // gvFilteringAttributes
            // 
            this.gvFilteringAttributes.AllowUserToAddRows = false;
            this.gvFilteringAttributes.AllowUserToDeleteRows = false;
            this.gvFilteringAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvFilteringAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFilteringAttributes.Location = new System.Drawing.Point(7, 26);
            this.gvFilteringAttributes.Name = "gvFilteringAttributes";
            this.gvFilteringAttributes.Size = new System.Drawing.Size(478, 186);
            this.gvFilteringAttributes.TabIndex = 0;
            this.gvFilteringAttributes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvFilteringAttributes_CellValueChanged);
            this.gvFilteringAttributes.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gvFilteringAttributes_DataError);
            // 
            // gbOrderingAttributes
            // 
            this.gbOrderingAttributes.Controls.Add(this.btnClearOrder);
            this.gbOrderingAttributes.Controls.Add(this.gvOrderingAttributes);
            this.gbOrderingAttributes.Location = new System.Drawing.Point(594, 513);
            this.gbOrderingAttributes.Name = "gbOrderingAttributes";
            this.gbOrderingAttributes.Size = new System.Drawing.Size(491, 158);
            this.gbOrderingAttributes.TabIndex = 99;
            this.gbOrderingAttributes.TabStop = false;
            this.gbOrderingAttributes.Text = "Order by Attributes";
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Location = new System.Drawing.Point(389, 0);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(75, 20);
            this.btnClearOrder.TabIndex = 2;
            this.btnClearOrder.Text = "Clear";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // gvOrderingAttributes
            // 
            this.gvOrderingAttributes.AllowUserToAddRows = false;
            this.gvOrderingAttributes.AllowUserToDeleteRows = false;
            this.gvOrderingAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvOrderingAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrderingAttributes.Location = new System.Drawing.Point(6, 26);
            this.gvOrderingAttributes.Name = "gvOrderingAttributes";
            this.gvOrderingAttributes.Size = new System.Drawing.Size(479, 117);
            this.gvOrderingAttributes.TabIndex = 0;

            this.groupBox1.Controls.Add(this.rtxtOdataQueryUrl);
            this.groupBox1.Location = new System.Drawing.Point(17, 677);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1580, 92);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odata Query URL";
            // 
            // rtxtOdataQueryUrl
            // 
            this.rtxtOdataQueryUrl.Location = new System.Drawing.Point(6, 19);
            this.rtxtOdataQueryUrl.Name = "rtxtOdataQueryUrl";
            this.rtxtOdataQueryUrl.Size = new System.Drawing.Size(1568, 65);
            this.rtxtOdataQueryUrl.TabIndex = 0;
            this.rtxtOdataQueryUrl.Text = "";
            // 
            // txtSkip
            // 
            this.txtSkip.Location = new System.Drawing.Point(843, 42);
            this.txtSkip.Name = "txtSkip";
            this.txtSkip.Size = new System.Drawing.Size(157, 20);
            this.txtSkip.TabIndex = 102;
            this.txtSkip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSkip_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(804, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 101;
            this.label3.Text = "Skip :";
            // 
            // gbxExpand
            // 
            this.gbxExpand.Controls.Add(this.btnClearSelectExtandAttributes);
            this.gbxExpand.Controls.Add(this.cbxlRelationships);
            this.gbxExpand.Controls.Add(this.gvExpandAttributes);
            this.gbxExpand.Controls.Add(this.gvExpand);
            this.gbxExpand.Enabled = false;
            this.gbxExpand.Location = new System.Drawing.Point(1085, 78);
            this.gbxExpand.Name = "gbxExpand";
            this.gbxExpand.Size = new System.Drawing.Size(512, 593);
            this.gbxExpand.TabIndex = 103;
            this.gbxExpand.TabStop = false;
            this.gbxExpand.Text = "Expand Relationship :";
            // 
            // btnClearSelectExtandAttributes
            // 
            this.btnClearSelectExtandAttributes.Location = new System.Drawing.Point(431, 429);
            this.btnClearSelectExtandAttributes.Name = "btnClearSelectExtandAttributes";
            this.btnClearSelectExtandAttributes.Size = new System.Drawing.Size(75, 20);
            this.btnClearSelectExtandAttributes.TabIndex = 101;
            this.btnClearSelectExtandAttributes.Text = "Clear";
            this.btnClearSelectExtandAttributes.UseVisualStyleBackColor = true;
            this.btnClearSelectExtandAttributes.Click += new System.EventHandler(this.btnClearSelectExtandAttributes_Click);
            // 
            // cbxlRelationships
            // 
            this.cbxlRelationships.FormattingEnabled = true;
            this.cbxlRelationships.Location = new System.Drawing.Point(9, 20);
            this.cbxlRelationships.Name = "cbxlRelationships";
            this.cbxlRelationships.Size = new System.Drawing.Size(497, 124);
            this.cbxlRelationships.TabIndex = 100;
            this.cbxlRelationships.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbxlRelationships_ItemCheck);
            // 
            // gvExpandAttributes
            // 
            this.gvExpandAttributes.AllowUserToAddRows = false;
            this.gvExpandAttributes.AllowUserToDeleteRows = false;
            this.gvExpandAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvExpandAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExpandAttributes.Location = new System.Drawing.Point(9, 454);
            this.gvExpandAttributes.Name = "gvExpandAttributes";
            this.gvExpandAttributes.ReadOnly = true;
            this.gvExpandAttributes.Size = new System.Drawing.Size(497, 124);
            this.gvExpandAttributes.TabIndex = 99;
            // 
            // gvExpand
            // 
            this.gvExpand.AllowUserToAddRows = false;
            this.gvExpand.AllowUserToDeleteRows = false;
            this.gvExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvExpand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExpand.Location = new System.Drawing.Point(9, 150);
            this.gvExpand.Name = "gvExpand";
            this.gvExpand.Size = new System.Drawing.Size(497, 273);
            this.gvExpand.TabIndex = 98;
            this.gvExpand.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExpand_CellValueChanged);
            // 
            // cbxUseExpand
            // 
            this.cbxUseExpand.AutoSize = true;
            this.cbxUseExpand.Location = new System.Drawing.Point(1094, 42);
            this.cbxUseExpand.Name = "cbxUseExpand";
            this.cbxUseExpand.Size = new System.Drawing.Size(93, 17);
            this.cbxUseExpand.TabIndex = 97;
            this.cbxUseExpand.Text = "Use Expand ?";
            this.cbxUseExpand.UseVisualStyleBackColor = true;
            this.cbxUseExpand.CheckedChanged += new System.EventHandler(this.cbxUseExpand_CheckedChanged);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxExpand);
            this.Controls.Add(this.txtSkip);
            this.Controls.Add(this.cbxUseExpand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbOrderingAttributes);
            this.Controls.Add(this.gbFilteringAttributes);
            this.Controls.Add(this.gbSelectingAttributes);
            this.Controls.Add(this.txtTop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbAttributes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEntities);
            this.Controls.Add(this.tsMain);
            this.Name = "OdataGenerator";
            this.Size = new System.Drawing.Size(1600, 778);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.gbAttributes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvAttributes)).EndInit();
            this.gbSelectingAttributes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSelectingAttributes)).EndInit();
            this.gbFilteringAttributes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvFilteringAttributes)).EndInit();
            this.gbOrderingAttributes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderingAttributes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gbxExpand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvExpandAttributes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExpand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbCloseThisTab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbLoadEntities;
        private System.Windows.Forms.ToolStripButton tsbLoadAttributes;
        private System.Windows.Forms.ToolStripButton tsbGenerateOdata;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ComboBox cbxEntities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAttributes;
        private System.Windows.Forms.DataGridView gvAttributes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.GroupBox gbSelectingAttributes;
        private System.Windows.Forms.DataGridView gvSelectingAttributes;
        private System.Windows.Forms.GroupBox gbFilteringAttributes;
        private System.Windows.Forms.GroupBox gbOrderingAttributes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxtOdataQueryUrl;
        private System.Windows.Forms.DataGridView gvFilteringAttributes;
        private System.Windows.Forms.DataGridView gvOrderingAttributes;
        private System.Windows.Forms.TextBox txtSkip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClearSelect;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.GroupBox gbxExpand;
        private System.Windows.Forms.DataGridView gvExpandAttributes;
        private System.Windows.Forms.DataGridView gvExpand;
        private System.Windows.Forms.CheckBox cbxUseExpand;
        private System.Windows.Forms.CheckedListBox cbxlRelationships;
        private System.Windows.Forms.Button btnClearSelectExtandAttributes;

    }
}
