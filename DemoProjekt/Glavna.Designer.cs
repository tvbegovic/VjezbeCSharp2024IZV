using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace DemoBaza
{
  partial class Glavna
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
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSelectAll = new System.Windows.Forms.TabPage();
            this.lblRowCountAll = new System.Windows.Forms.Label();
            this.lblPronadenoAll = new System.Windows.Forms.Label();
            this.dgvAll = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeveloper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.tabSelectWithCriteria = new System.Windows.Forms.TabPage();
            this.txtNameContains = new System.Windows.Forms.TextBox();
            this.lblNameContains = new System.Windows.Forms.Label();
            this.lblRowCountFilter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSelectCriteria = new System.Windows.Forms.DataGridView();
            this.btnSelectCriteria = new System.Windows.Forms.Button();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblPriceFrom = new System.Windows.Forms.Label();
            this.txtPriceFrom = new System.Windows.Forms.TextBox();
            this.lblPriceTo = new System.Windows.Forms.Label();
            this.txtPriceTo = new System.Windows.Forms.TextBox();
            this.tabSelectOne = new System.Windows.Forms.TabPage();
            this.lblId1 = new System.Windows.Forms.Label();
            this.lblIdValue = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitleValue = new System.Windows.Forms.Label();
            this.lblGenre1 = new System.Windows.Forms.Label();
            this.lblGenreValue = new System.Windows.Forms.Label();
            this.lblPublisher1 = new System.Windows.Forms.Label();
            this.lblPublisherValue = new System.Windows.Forms.Label();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblDeveloperValue = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblReleaseDateValue = new System.Windows.Forms.Label();
            this.lblSelectOneResult = new System.Windows.Forms.Label();
            this.btnSelectOne = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtIdSelectOne = new System.Windows.Forms.TextBox();
            this.tabInsert = new System.Windows.Forms.TabPage();
            this.btnClearFormInsert = new System.Windows.Forms.Button();
            this.lblInsertResult = new System.Windows.Forms.Label();
            this.txtReleaseDateInsert = new System.Windows.Forms.TextBox();
            this.txtPriceInsert = new System.Windows.Forms.TextBox();
            this.txtDeveloperInsert = new System.Windows.Forms.TextBox();
            this.txtPublisherInsert = new System.Windows.Forms.TextBox();
            this.txtIdGenreInsert = new System.Windows.Forms.TextBox();
            this.txtTitleInsert = new System.Windows.Forms.TextBox();
            this.lblIdInsert = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tabUpdate = new System.Windows.Forms.TabPage();
            this.btnLoadUpdate = new System.Windows.Forms.Button();
            this.txtIdUpdate = new System.Windows.Forms.TextBox();
            this.btnClearUpdate = new System.Windows.Forms.Button();
            this.lblUpdateResult = new System.Windows.Forms.Label();
            this.txtReleaseDateUpdate = new System.Windows.Forms.TextBox();
            this.txtPriceUpdate = new System.Windows.Forms.TextBox();
            this.txtIdDeveloperUpdate = new System.Windows.Forms.TextBox();
            this.txtIdPublisherUpdate = new System.Windows.Forms.TextBox();
            this.txtIdGenreUpdate = new System.Windows.Forms.TextBox();
            this.txtTitleUpdate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.lblDeleteResult = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvDelete = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadDelete = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabSelectAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).BeginInit();
            this.tabSelectWithCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectCriteria)).BeginInit();
            this.tabSelectOne.SuspendLayout();
            this.tabInsert.SuspendLayout();
            this.tabUpdate.SuspendLayout();
            this.tabDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Location = new System.Drawing.Point(12, 15);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(114, 16);
            this.lblConnectionString.TabIndex = 0;
            this.lblConnectionString.Text = "Connection String:";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(121, 12);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(599, 22);
            this.txtConnectionString.TabIndex = 1;
            this.txtConnectionString.Text = "Data Source=palma.vernnet.hr,3233;Initial Catalog=gameshop_tvbegovic;Persist Secu" +
    "rity Info=True;User ID=appuser;Password=dbpassword";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabSelectAll);
            this.tabControl.Controls.Add(this.tabSelectWithCriteria);
            this.tabControl.Controls.Add(this.tabSelectOne);
            this.tabControl.Controls.Add(this.tabInsert);
            this.tabControl.Controls.Add(this.tabUpdate);
            this.tabControl.Controls.Add(this.tabDelete);
            this.tabControl.Location = new System.Drawing.Point(12, 50);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1087, 498);
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabSelectAll
            // 
            this.tabSelectAll.Controls.Add(this.lblRowCountAll);
            this.tabSelectAll.Controls.Add(this.lblPronadenoAll);
            this.tabSelectAll.Controls.Add(this.dgvAll);
            this.tabSelectAll.Controls.Add(this.btnSelectAll);
            this.tabSelectAll.Location = new System.Drawing.Point(4, 25);
            this.tabSelectAll.Name = "tabSelectAll";
            this.tabSelectAll.Size = new System.Drawing.Size(1079, 469);
            this.tabSelectAll.TabIndex = 0;
            this.tabSelectAll.Text = "Select All";
            this.tabSelectAll.UseVisualStyleBackColor = true;
            // 
            // lblRowCountAll
            // 
            this.lblRowCountAll.AutoSize = true;
            this.lblRowCountAll.Location = new System.Drawing.Point(252, 24);
            this.lblRowCountAll.Name = "lblRowCountAll";
            this.lblRowCountAll.Size = new System.Drawing.Size(0, 16);
            this.lblRowCountAll.TabIndex = 3;
            // 
            // lblPronadenoAll
            // 
            this.lblPronadenoAll.AutoSize = true;
            this.lblPronadenoAll.Location = new System.Drawing.Point(149, 24);
            this.lblPronadenoAll.Name = "lblPronadenoAll";
            this.lblPronadenoAll.Size = new System.Drawing.Size(120, 16);
            this.lblPronadenoAll.TabIndex = 2;
            this.lblPronadenoAll.Text = "Pronađeno zapisa:";
            // 
            // dgvAll
            // 
            this.dgvAll.AllowUserToAddRows = false;
            this.dgvAll.AllowUserToDeleteRows = false;
            this.dgvAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTitle,
            this.colGenre,
            this.colPublisher,
            this.colDeveloper,
            this.colPrice,
            this.colDate});
            this.dgvAll.Location = new System.Drawing.Point(16, 64);
            this.dgvAll.Name = "dgvAll";
            this.dgvAll.ReadOnly = true;
            this.dgvAll.RowHeadersWidth = 51;
            this.dgvAll.Size = new System.Drawing.Size(1053, 392);
            this.dgvAll.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 125;
            // 
            // colTitle
            // 
            this.colTitle.DataPropertyName = "Title";
            this.colTitle.HeaderText = "Title";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 125;
            // 
            // colGenre
            // 
            this.colGenre.DataPropertyName = "Genre";
            this.colGenre.HeaderText = "Genre";
            this.colGenre.MinimumWidth = 6;
            this.colGenre.Name = "colGenre";
            this.colGenre.ReadOnly = true;
            this.colGenre.Width = 125;
            // 
            // colPublisher
            // 
            this.colPublisher.DataPropertyName = "Publisher";
            this.colPublisher.HeaderText = "Publisher";
            this.colPublisher.MinimumWidth = 6;
            this.colPublisher.Name = "colPublisher";
            this.colPublisher.ReadOnly = true;
            this.colPublisher.Width = 125;
            // 
            // colDeveloper
            // 
            this.colDeveloper.DataPropertyName = "Developer";
            this.colDeveloper.HeaderText = "Developer";
            this.colDeveloper.MinimumWidth = 6;
            this.colDeveloper.Name = "colDeveloper";
            this.colDeveloper.ReadOnly = true;
            this.colDeveloper.Width = 125;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 125;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "ReleaseDate";
            this.colDate.HeaderText = "ReleaseDate";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 125;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(15, 13);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(128, 34);
            this.btnSelectAll.TabIndex = 0;
            this.btnSelectAll.Text = "Dohvati sve";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // tabSelectWithCriteria
            // 
            this.tabSelectWithCriteria.Controls.Add(this.txtNameContains);
            this.tabSelectWithCriteria.Controls.Add(this.lblNameContains);
            this.tabSelectWithCriteria.Controls.Add(this.lblRowCountFilter);
            this.tabSelectWithCriteria.Controls.Add(this.label1);
            this.tabSelectWithCriteria.Controls.Add(this.dgvSelectCriteria);
            this.tabSelectWithCriteria.Controls.Add(this.btnSelectCriteria);
            this.tabSelectWithCriteria.Controls.Add(this.lblGenre);
            this.tabSelectWithCriteria.Controls.Add(this.txtGenre);
            this.tabSelectWithCriteria.Controls.Add(this.lblPublisher);
            this.tabSelectWithCriteria.Controls.Add(this.txtPublisher);
            this.tabSelectWithCriteria.Controls.Add(this.lblPriceFrom);
            this.tabSelectWithCriteria.Controls.Add(this.txtPriceFrom);
            this.tabSelectWithCriteria.Controls.Add(this.lblPriceTo);
            this.tabSelectWithCriteria.Controls.Add(this.txtPriceTo);
            this.tabSelectWithCriteria.Location = new System.Drawing.Point(4, 25);
            this.tabSelectWithCriteria.Name = "tabSelectWithCriteria";
            this.tabSelectWithCriteria.Size = new System.Drawing.Size(1079, 469);
            this.tabSelectWithCriteria.TabIndex = 1;
            this.tabSelectWithCriteria.Text = "Select With Criteria";
            this.tabSelectWithCriteria.UseVisualStyleBackColor = true;
            // 
            // txtNameContains
            // 
            this.txtNameContains.Location = new System.Drawing.Point(704, 11);
            this.txtNameContains.Name = "txtNameContains";
            this.txtNameContains.Size = new System.Drawing.Size(75, 22);
            this.txtNameContains.TabIndex = 16;
            // 
            // lblNameContains
            // 
            this.lblNameContains.AutoSize = true;
            this.lblNameContains.Location = new System.Drawing.Point(631, 14);
            this.lblNameContains.Name = "lblNameContains";
            this.lblNameContains.Size = new System.Drawing.Size(83, 16);
            this.lblNameContains.TabIndex = 15;
            this.lblNameContains.Text = "Naziv sadrži:";
            // 
            // lblRowCountFilter
            // 
            this.lblRowCountFilter.AutoSize = true;
            this.lblRowCountFilter.Location = new System.Drawing.Point(245, 49);
            this.lblRowCountFilter.Name = "lblRowCountFilter";
            this.lblRowCountFilter.Size = new System.Drawing.Size(0, 16);
            this.lblRowCountFilter.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pronađeno zapisa:";
            // 
            // dgvSelectCriteria
            // 
            this.dgvSelectCriteria.AllowUserToAddRows = false;
            this.dgvSelectCriteria.AllowUserToDeleteRows = false;
            this.dgvSelectCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSelectCriteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectCriteria.Location = new System.Drawing.Point(13, 78);
            this.dgvSelectCriteria.Name = "dgvSelectCriteria";
            this.dgvSelectCriteria.ReadOnly = true;
            this.dgvSelectCriteria.RowHeadersWidth = 51;
            this.dgvSelectCriteria.Size = new System.Drawing.Size(1053, 378);
            this.dgvSelectCriteria.TabIndex = 4;
            // 
            // btnSelectCriteria
            // 
            this.btnSelectCriteria.Location = new System.Drawing.Point(16, 38);
            this.btnSelectCriteria.Name = "btnSelectCriteria";
            this.btnSelectCriteria.Size = new System.Drawing.Size(128, 34);
            this.btnSelectCriteria.TabIndex = 3;
            this.btnSelectCriteria.Text = "Dohvati";
            this.btnSelectCriteria.UseVisualStyleBackColor = true;
            this.btnSelectCriteria.Click += new System.EventHandler(this.btnSelectCriteria_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(12, 14);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(37, 16);
            this.lblGenre.TabIndex = 7;
            this.lblGenre.Text = "Žanr:";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(60, 11);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(80, 22);
            this.txtGenre.TabIndex = 8;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(160, 14);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(66, 16);
            this.lblPublisher.TabIndex = 9;
            this.lblPublisher.Text = "Publisher:";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(220, 11);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(80, 22);
            this.txtPublisher.TabIndex = 10;
            // 
            // lblPriceFrom
            // 
            this.lblPriceFrom.AutoSize = true;
            this.lblPriceFrom.Location = new System.Drawing.Point(320, 14);
            this.lblPriceFrom.Name = "lblPriceFrom";
            this.lblPriceFrom.Size = new System.Drawing.Size(67, 16);
            this.lblPriceFrom.TabIndex = 11;
            this.lblPriceFrom.Text = "Cijena od:";
            // 
            // txtPriceFrom
            // 
            this.txtPriceFrom.Location = new System.Drawing.Point(390, 11);
            this.txtPriceFrom.Name = "txtPriceFrom";
            this.txtPriceFrom.Size = new System.Drawing.Size(60, 22);
            this.txtPriceFrom.TabIndex = 12;
            // 
            // lblPriceTo
            // 
            this.lblPriceTo.AutoSize = true;
            this.lblPriceTo.Location = new System.Drawing.Point(470, 14);
            this.lblPriceTo.Name = "lblPriceTo";
            this.lblPriceTo.Size = new System.Drawing.Size(67, 16);
            this.lblPriceTo.TabIndex = 13;
            this.lblPriceTo.Text = "Cijena do:";
            // 
            // txtPriceTo
            // 
            this.txtPriceTo.Location = new System.Drawing.Point(540, 11);
            this.txtPriceTo.Name = "txtPriceTo";
            this.txtPriceTo.Size = new System.Drawing.Size(60, 22);
            this.txtPriceTo.TabIndex = 14;
            // 
            // tabSelectOne
            // 
            this.tabSelectOne.Controls.Add(this.lblId1);
            this.tabSelectOne.Controls.Add(this.lblIdValue);
            this.tabSelectOne.Controls.Add(this.lblTitle);
            this.tabSelectOne.Controls.Add(this.lblTitleValue);
            this.tabSelectOne.Controls.Add(this.lblGenre1);
            this.tabSelectOne.Controls.Add(this.lblGenreValue);
            this.tabSelectOne.Controls.Add(this.lblPublisher1);
            this.tabSelectOne.Controls.Add(this.lblPublisherValue);
            this.tabSelectOne.Controls.Add(this.lblDeveloper);
            this.tabSelectOne.Controls.Add(this.lblDeveloperValue);
            this.tabSelectOne.Controls.Add(this.lblPrice);
            this.tabSelectOne.Controls.Add(this.lblPriceValue);
            this.tabSelectOne.Controls.Add(this.lblReleaseDate);
            this.tabSelectOne.Controls.Add(this.lblReleaseDateValue);
            this.tabSelectOne.Controls.Add(this.lblSelectOneResult);
            this.tabSelectOne.Controls.Add(this.btnSelectOne);
            this.tabSelectOne.Controls.Add(this.lblId);
            this.tabSelectOne.Controls.Add(this.txtIdSelectOne);
            this.tabSelectOne.Location = new System.Drawing.Point(4, 25);
            this.tabSelectOne.Name = "tabSelectOne";
            this.tabSelectOne.Size = new System.Drawing.Size(1079, 469);
            this.tabSelectOne.TabIndex = 2;
            this.tabSelectOne.Text = "Select One";
            this.tabSelectOne.UseVisualStyleBackColor = true;
            // 
            // lblId1
            // 
            this.lblId1.Location = new System.Drawing.Point(20, 68);
            this.lblId1.Name = "lblId1";
            this.lblId1.Size = new System.Drawing.Size(50, 20);
            this.lblId1.TabIndex = 0;
            this.lblId1.Text = "Id:";
            // 
            // lblIdValue
            // 
            this.lblIdValue.Location = new System.Drawing.Point(130, 68);
            this.lblIdValue.Name = "lblIdValue";
            this.lblIdValue.Size = new System.Drawing.Size(150, 20);
            this.lblIdValue.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(20, 98);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(50, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // lblTitleValue
            // 
            this.lblTitleValue.Location = new System.Drawing.Point(130, 98);
            this.lblTitleValue.Name = "lblTitleValue";
            this.lblTitleValue.Size = new System.Drawing.Size(150, 20);
            this.lblTitleValue.TabIndex = 3;
            // 
            // lblGenre1
            // 
            this.lblGenre1.Location = new System.Drawing.Point(20, 128);
            this.lblGenre1.Name = "lblGenre1";
            this.lblGenre1.Size = new System.Drawing.Size(50, 20);
            this.lblGenre1.TabIndex = 4;
            this.lblGenre1.Text = "Genre:";
            // 
            // lblGenreValue
            // 
            this.lblGenreValue.Location = new System.Drawing.Point(130, 128);
            this.lblGenreValue.Name = "lblGenreValue";
            this.lblGenreValue.Size = new System.Drawing.Size(150, 20);
            this.lblGenreValue.TabIndex = 5;
            // 
            // lblPublisher1
            // 
            this.lblPublisher1.Location = new System.Drawing.Point(20, 158);
            this.lblPublisher1.Name = "lblPublisher1";
            this.lblPublisher1.Size = new System.Drawing.Size(70, 20);
            this.lblPublisher1.TabIndex = 6;
            this.lblPublisher1.Text = "Publisher:";
            // 
            // lblPublisherValue
            // 
            this.lblPublisherValue.Location = new System.Drawing.Point(130, 158);
            this.lblPublisherValue.Name = "lblPublisherValue";
            this.lblPublisherValue.Size = new System.Drawing.Size(150, 20);
            this.lblPublisherValue.TabIndex = 7;
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.Location = new System.Drawing.Point(20, 188);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(70, 20);
            this.lblDeveloper.TabIndex = 8;
            this.lblDeveloper.Text = "Developer:";
            // 
            // lblDeveloperValue
            // 
            this.lblDeveloperValue.Location = new System.Drawing.Point(130, 188);
            this.lblDeveloperValue.Name = "lblDeveloperValue";
            this.lblDeveloperValue.Size = new System.Drawing.Size(150, 20);
            this.lblDeveloperValue.TabIndex = 9;
            this.lblDeveloperValue.Click += new System.EventHandler(this.lblDeveloperValue_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(20, 218);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(50, 20);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price:";
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.Location = new System.Drawing.Point(130, 218);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(150, 20);
            this.lblPriceValue.TabIndex = 11;
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.Location = new System.Drawing.Point(20, 248);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(80, 20);
            this.lblReleaseDate.TabIndex = 12;
            this.lblReleaseDate.Text = "Release Date:";
            // 
            // lblReleaseDateValue
            // 
            this.lblReleaseDateValue.Location = new System.Drawing.Point(130, 248);
            this.lblReleaseDateValue.Name = "lblReleaseDateValue";
            this.lblReleaseDateValue.Size = new System.Drawing.Size(150, 20);
            this.lblReleaseDateValue.TabIndex = 13;
            // 
            // lblSelectOneResult
            // 
            this.lblSelectOneResult.AutoSize = true;
            this.lblSelectOneResult.ForeColor = System.Drawing.Color.Red;
            this.lblSelectOneResult.Location = new System.Drawing.Point(326, 25);
            this.lblSelectOneResult.Name = "lblSelectOneResult";
            this.lblSelectOneResult.Size = new System.Drawing.Size(0, 16);
            this.lblSelectOneResult.TabIndex = 13;
            // 
            // btnSelectOne
            // 
            this.btnSelectOne.Location = new System.Drawing.Point(177, 12);
            this.btnSelectOne.Name = "btnSelectOne";
            this.btnSelectOne.Size = new System.Drawing.Size(128, 34);
            this.btnSelectOne.TabIndex = 9;
            this.btnSelectOne.Text = "Dohvati";
            this.btnSelectOne.UseVisualStyleBackColor = true;
            this.btnSelectOne.Click += new System.EventHandler(this.btnSelectOne_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(20, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 16);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "Id:";
            // 
            // txtIdSelectOne
            // 
            this.txtIdSelectOne.Location = new System.Drawing.Point(81, 20);
            this.txtIdSelectOne.Name = "txtIdSelectOne";
            this.txtIdSelectOne.Size = new System.Drawing.Size(80, 22);
            this.txtIdSelectOne.TabIndex = 12;
            // 
            // tabInsert
            // 
            this.tabInsert.Controls.Add(this.btnClearFormInsert);
            this.tabInsert.Controls.Add(this.lblInsertResult);
            this.tabInsert.Controls.Add(this.txtReleaseDateInsert);
            this.tabInsert.Controls.Add(this.txtPriceInsert);
            this.tabInsert.Controls.Add(this.txtDeveloperInsert);
            this.tabInsert.Controls.Add(this.txtPublisherInsert);
            this.tabInsert.Controls.Add(this.txtIdGenreInsert);
            this.tabInsert.Controls.Add(this.txtTitleInsert);
            this.tabInsert.Controls.Add(this.lblIdInsert);
            this.tabInsert.Controls.Add(this.label2);
            this.tabInsert.Controls.Add(this.label3);
            this.tabInsert.Controls.Add(this.label4);
            this.tabInsert.Controls.Add(this.label5);
            this.tabInsert.Controls.Add(this.label6);
            this.tabInsert.Controls.Add(this.label7);
            this.tabInsert.Controls.Add(this.label8);
            this.tabInsert.Controls.Add(this.btnInsert);
            this.tabInsert.Location = new System.Drawing.Point(4, 25);
            this.tabInsert.Name = "tabInsert";
            this.tabInsert.Size = new System.Drawing.Size(1079, 469);
            this.tabInsert.TabIndex = 3;
            this.tabInsert.Text = "Insert";
            this.tabInsert.UseVisualStyleBackColor = true;
            // 
            // btnClearFormInsert
            // 
            this.btnClearFormInsert.Location = new System.Drawing.Point(167, 13);
            this.btnClearFormInsert.Name = "btnClearFormInsert";
            this.btnClearFormInsert.Size = new System.Drawing.Size(125, 34);
            this.btnClearFormInsert.TabIndex = 28;
            this.btnClearFormInsert.Text = "Očisti";
            this.btnClearFormInsert.UseVisualStyleBackColor = true;
            this.btnClearFormInsert.Click += new System.EventHandler(this.btnClearFormInsert_Click);
            // 
            // lblInsertResult
            // 
            this.lblInsertResult.BackColor = System.Drawing.Color.Transparent;
            this.lblInsertResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInsertResult.Location = new System.Drawing.Point(311, 18);
            this.lblInsertResult.Name = "lblInsertResult";
            this.lblInsertResult.Size = new System.Drawing.Size(666, 22);
            this.lblInsertResult.TabIndex = 27;
            this.lblInsertResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReleaseDateInsert
            // 
            this.txtReleaseDateInsert.Location = new System.Drawing.Point(145, 244);
            this.txtReleaseDateInsert.Name = "txtReleaseDateInsert";
            this.txtReleaseDateInsert.Size = new System.Drawing.Size(147, 22);
            this.txtReleaseDateInsert.TabIndex = 26;
            // 
            // txtPriceInsert
            // 
            this.txtPriceInsert.Location = new System.Drawing.Point(145, 214);
            this.txtPriceInsert.Name = "txtPriceInsert";
            this.txtPriceInsert.Size = new System.Drawing.Size(147, 22);
            this.txtPriceInsert.TabIndex = 25;
            // 
            // txtDeveloperInsert
            // 
            this.txtDeveloperInsert.Location = new System.Drawing.Point(145, 184);
            this.txtDeveloperInsert.Name = "txtDeveloperInsert";
            this.txtDeveloperInsert.Size = new System.Drawing.Size(147, 22);
            this.txtDeveloperInsert.TabIndex = 24;
            // 
            // txtPublisherInsert
            // 
            this.txtPublisherInsert.Location = new System.Drawing.Point(145, 154);
            this.txtPublisherInsert.Name = "txtPublisherInsert";
            this.txtPublisherInsert.Size = new System.Drawing.Size(147, 22);
            this.txtPublisherInsert.TabIndex = 23;
            // 
            // txtIdGenreInsert
            // 
            this.txtIdGenreInsert.Location = new System.Drawing.Point(145, 124);
            this.txtIdGenreInsert.Name = "txtIdGenreInsert";
            this.txtIdGenreInsert.Size = new System.Drawing.Size(147, 22);
            this.txtIdGenreInsert.TabIndex = 22;
            // 
            // txtTitleInsert
            // 
            this.txtTitleInsert.Location = new System.Drawing.Point(145, 94);
            this.txtTitleInsert.Name = "txtTitleInsert";
            this.txtTitleInsert.Size = new System.Drawing.Size(147, 22);
            this.txtTitleInsert.TabIndex = 21;
            // 
            // lblIdInsert
            // 
            this.lblIdInsert.Location = new System.Drawing.Point(142, 67);
            this.lblIdInsert.Name = "lblIdInsert";
            this.lblIdInsert.Size = new System.Drawing.Size(150, 20);
            this.lblIdInsert.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Id:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Title:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Genre:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(17, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Publisher:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(17, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Developer:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(17, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Price:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(17, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Release Date:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(20, 13);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(128, 34);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Pokreni";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tabUpdate
            // 
            this.tabUpdate.Controls.Add(this.btnLoadUpdate);
            this.tabUpdate.Controls.Add(this.txtIdUpdate);
            this.tabUpdate.Controls.Add(this.btnClearUpdate);
            this.tabUpdate.Controls.Add(this.lblUpdateResult);
            this.tabUpdate.Controls.Add(this.txtReleaseDateUpdate);
            this.tabUpdate.Controls.Add(this.txtPriceUpdate);
            this.tabUpdate.Controls.Add(this.txtIdDeveloperUpdate);
            this.tabUpdate.Controls.Add(this.txtIdPublisherUpdate);
            this.tabUpdate.Controls.Add(this.txtIdGenreUpdate);
            this.tabUpdate.Controls.Add(this.txtTitleUpdate);
            this.tabUpdate.Controls.Add(this.label10);
            this.tabUpdate.Controls.Add(this.label11);
            this.tabUpdate.Controls.Add(this.label12);
            this.tabUpdate.Controls.Add(this.label13);
            this.tabUpdate.Controls.Add(this.label14);
            this.tabUpdate.Controls.Add(this.label15);
            this.tabUpdate.Controls.Add(this.label16);
            this.tabUpdate.Controls.Add(this.label17);
            this.tabUpdate.Controls.Add(this.btnUpdate);
            this.tabUpdate.Location = new System.Drawing.Point(4, 25);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.Size = new System.Drawing.Size(1079, 469);
            this.tabUpdate.TabIndex = 4;
            this.tabUpdate.Text = "Update";
            this.tabUpdate.UseVisualStyleBackColor = true;
            // 
            // btnLoadUpdate
            // 
            this.btnLoadUpdate.Location = new System.Drawing.Point(458, 63);
            this.btnLoadUpdate.Name = "btnLoadUpdate";
            this.btnLoadUpdate.Size = new System.Drawing.Size(103, 23);
            this.btnLoadUpdate.TabIndex = 46;
            this.btnLoadUpdate.Text = "Učitaj";
            this.btnLoadUpdate.UseVisualStyleBackColor = true;
            this.btnLoadUpdate.Click += new System.EventHandler(this.btnLoadUpdate_Click);
            // 
            // txtIdUpdate
            // 
            this.txtIdUpdate.Location = new System.Drawing.Point(142, 65);
            this.txtIdUpdate.Name = "txtIdUpdate";
            this.txtIdUpdate.Size = new System.Drawing.Size(287, 22);
            this.txtIdUpdate.TabIndex = 37;
            // 
            // btnClearUpdate
            // 
            this.btnClearUpdate.Location = new System.Drawing.Point(164, 14);
            this.btnClearUpdate.Name = "btnClearUpdate";
            this.btnClearUpdate.Size = new System.Drawing.Size(125, 34);
            this.btnClearUpdate.TabIndex = 45;
            this.btnClearUpdate.Text = "Očisti";
            this.btnClearUpdate.UseVisualStyleBackColor = true;
            this.btnClearUpdate.Click += new System.EventHandler(this.btnClearUpdate_Click);
            // 
            // lblUpdateResult
            // 
            this.lblUpdateResult.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUpdateResult.Location = new System.Drawing.Point(308, 19);
            this.lblUpdateResult.Name = "lblUpdateResult";
            this.lblUpdateResult.Size = new System.Drawing.Size(666, 22);
            this.lblUpdateResult.TabIndex = 44;
            this.lblUpdateResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReleaseDateUpdate
            // 
            this.txtReleaseDateUpdate.Location = new System.Drawing.Point(142, 245);
            this.txtReleaseDateUpdate.Name = "txtReleaseDateUpdate";
            this.txtReleaseDateUpdate.Size = new System.Drawing.Size(287, 22);
            this.txtReleaseDateUpdate.TabIndex = 43;
            // 
            // txtPriceUpdate
            // 
            this.txtPriceUpdate.Location = new System.Drawing.Point(142, 215);
            this.txtPriceUpdate.Name = "txtPriceUpdate";
            this.txtPriceUpdate.Size = new System.Drawing.Size(287, 22);
            this.txtPriceUpdate.TabIndex = 42;
            // 
            // txtIdDeveloperUpdate
            // 
            this.txtIdDeveloperUpdate.Location = new System.Drawing.Point(142, 185);
            this.txtIdDeveloperUpdate.Name = "txtIdDeveloperUpdate";
            this.txtIdDeveloperUpdate.Size = new System.Drawing.Size(287, 22);
            this.txtIdDeveloperUpdate.TabIndex = 41;
            // 
            // txtIdPublisherUpdate
            // 
            this.txtIdPublisherUpdate.Location = new System.Drawing.Point(142, 155);
            this.txtIdPublisherUpdate.Name = "txtIdPublisherUpdate";
            this.txtIdPublisherUpdate.Size = new System.Drawing.Size(287, 22);
            this.txtIdPublisherUpdate.TabIndex = 40;
            // 
            // txtIdGenreUpdate
            // 
            this.txtIdGenreUpdate.Location = new System.Drawing.Point(142, 125);
            this.txtIdGenreUpdate.Name = "txtIdGenreUpdate";
            this.txtIdGenreUpdate.Size = new System.Drawing.Size(287, 22);
            this.txtIdGenreUpdate.TabIndex = 39;
            // 
            // txtTitleUpdate
            // 
            this.txtTitleUpdate.Location = new System.Drawing.Point(142, 95);
            this.txtTitleUpdate.Name = "txtTitleUpdate";
            this.txtTitleUpdate.Size = new System.Drawing.Size(287, 22);
            this.txtTitleUpdate.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(139, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(290, 20);
            this.label10.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(14, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Id:";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(14, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Title:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(14, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Genre:";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(14, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "Publisher:";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(14, 188);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "Developer:";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(14, 218);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 20);
            this.label16.TabIndex = 35;
            this.label16.Text = "Price:";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(14, 248);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 20);
            this.label17.TabIndex = 36;
            this.label17.Text = "Release Date:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(17, 14);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 34);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Pokreni";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.lblDeleteResult);
            this.tabDelete.Controls.Add(this.btnDelete);
            this.tabDelete.Controls.Add(this.dgvDelete);
            this.tabDelete.Controls.Add(this.btnLoadDelete);
            this.tabDelete.Location = new System.Drawing.Point(4, 25);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(1079, 469);
            this.tabDelete.TabIndex = 5;
            this.tabDelete.Text = "Delete";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // lblDeleteResult
            // 
            this.lblDeleteResult.BackColor = System.Drawing.Color.Transparent;
            this.lblDeleteResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeleteResult.Location = new System.Drawing.Point(280, 19);
            this.lblDeleteResult.Name = "lblDeleteResult";
            this.lblDeleteResult.Size = new System.Drawing.Size(666, 22);
            this.lblDeleteResult.TabIndex = 45;
            this.lblDeleteResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(146, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 34);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Obriši odabrani";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvDelete
            // 
            this.dgvDelete.AllowUserToAddRows = false;
            this.dgvDelete.AllowUserToDeleteRows = false;
            this.dgvDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvDelete.Location = new System.Drawing.Point(13, 64);
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.ReadOnly = true;
            this.dgvDelete.RowHeadersWidth = 51;
            this.dgvDelete.Size = new System.Drawing.Size(1053, 392);
            this.dgvDelete.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Genre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Publisher";
            this.dataGridViewTextBoxColumn4.HeaderText = "Publisher";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Developer";
            this.dataGridViewTextBoxColumn5.HeaderText = "Developer";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Price";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ReleaseDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "ReleaseDate";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // btnLoadDelete
            // 
            this.btnLoadDelete.Location = new System.Drawing.Point(12, 13);
            this.btnLoadDelete.Name = "btnLoadDelete";
            this.btnLoadDelete.Size = new System.Drawing.Size(128, 34);
            this.btnLoadDelete.TabIndex = 2;
            this.btnLoadDelete.Text = "Dohvati sve";
            this.btnLoadDelete.UseVisualStyleBackColor = true;
            this.btnLoadDelete.Click += new System.EventHandler(this.btnLoadDelete_Click);
            // 
            // Glavna
            // 
            this.ClientSize = new System.Drawing.Size(1111, 560);
            this.Controls.Add(this.lblConnectionString);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.tabControl);
            this.Name = "Glavna";
            this.Text = "Database Access Demo";
            this.tabControl.ResumeLayout(false);
            this.tabSelectAll.ResumeLayout(false);
            this.tabSelectAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).EndInit();
            this.tabSelectWithCriteria.ResumeLayout(false);
            this.tabSelectWithCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectCriteria)).EndInit();
            this.tabSelectOne.ResumeLayout(false);
            this.tabSelectOne.PerformLayout();
            this.tabInsert.ResumeLayout(false);
            this.tabInsert.PerformLayout();
            this.tabUpdate.ResumeLayout(false);
            this.tabUpdate.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private System.Windows.Forms.Label lblConnectionString;
    private System.Windows.Forms.TextBox txtConnectionString;
    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabSelectAll;
    private System.Windows.Forms.TabPage tabSelectWithCriteria;
    private System.Windows.Forms.TabPage tabSelectOne;
    private System.Windows.Forms.TabPage tabInsert;
    private System.Windows.Forms.TabPage tabUpdate;
    private System.Windows.Forms.TabPage tabDelete;

    #endregion

    private System.Windows.Forms.Button btnSelectAll;
    private System.Windows.Forms.DataGridView dgvAll;
    private System.Windows.Forms.Label lblRowCountAll;
    private System.Windows.Forms.Label lblPronadenoAll;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn developerDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn colId;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
    private System.Windows.Forms.DataGridViewTextBoxColumn colGenre;
    private System.Windows.Forms.DataGridViewTextBoxColumn colPublisher;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDeveloper;
    private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
    private System.Windows.Forms.Label lblRowCountFilter;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView dgvSelectCriteria;
    private System.Windows.Forms.Button btnSelectCriteria;
    private System.Windows.Forms.Label lblGenre;
    private System.Windows.Forms.TextBox txtGenre;
    private System.Windows.Forms.Label lblPublisher;
    private System.Windows.Forms.TextBox txtPublisher;
    private System.Windows.Forms.Label lblPriceFrom;
    private System.Windows.Forms.TextBox txtPriceFrom;
    private System.Windows.Forms.Label lblPriceTo;
    private System.Windows.Forms.TextBox txtPriceTo;
    private System.Windows.Forms.TextBox txtNameContains;
    private System.Windows.Forms.Label lblNameContains;
    private System.Windows.Forms.Label lblSelectOneResult;
    private System.Windows.Forms.Button btnSelectOne;
    private System.Windows.Forms.Label lblId;
    private System.Windows.Forms.TextBox txtIdSelectOne;
    private System.Windows.Forms.Label lblId1;
    private System.Windows.Forms.Label lblIdValue;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblTitleValue;
    private System.Windows.Forms.Label lblGenre1;
    private System.Windows.Forms.Label lblGenreValue;
    private System.Windows.Forms.Label lblPublisher1;
    private System.Windows.Forms.Label lblPublisherValue;
    private System.Windows.Forms.Label lblDeveloper;
    private System.Windows.Forms.Label lblDeveloperValue;
    private System.Windows.Forms.Label lblPrice;
    private System.Windows.Forms.Label lblPriceValue;
    private System.Windows.Forms.Label lblReleaseDate;
    private System.Windows.Forms.Label lblReleaseDateValue;
    private System.Windows.Forms.TextBox txtReleaseDateInsert;
    private System.Windows.Forms.TextBox txtPriceInsert;
    private System.Windows.Forms.TextBox txtDeveloperInsert;
    private System.Windows.Forms.TextBox txtPublisherInsert;
    private System.Windows.Forms.TextBox txtIdGenreInsert;
    private System.Windows.Forms.TextBox txtTitleInsert;
    private Label lblIdInsert;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private System.Windows.Forms.Button btnInsert;
    private Label lblInsertResult;
    private System.Windows.Forms.Button btnClearFormInsert;
    private System.Windows.Forms.Button btnClearUpdate;
    private Label lblUpdateResult;
    private System.Windows.Forms.TextBox txtReleaseDateUpdate;
    private System.Windows.Forms.TextBox txtPriceUpdate;
    private System.Windows.Forms.TextBox txtIdDeveloperUpdate;
    private System.Windows.Forms.TextBox txtIdPublisherUpdate;
    private System.Windows.Forms.TextBox txtIdGenreUpdate;
    private System.Windows.Forms.TextBox txtTitleUpdate;
    private Label label10;
    private Label label11;
    private Label label12;
    private Label label13;
    private Label label14;
    private Label label15;
    private Label label16;
    private Label label17;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnLoadUpdate;
    private System.Windows.Forms.TextBox txtIdUpdate;
    private System.Windows.Forms.Button btnDelete;
    private DataGridView dgvDelete;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private System.Windows.Forms.Button btnLoadDelete;
    private Label lblDeleteResult;
  }
}

