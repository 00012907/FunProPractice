
namespace FunPro3dataset
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label dobLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label gradeLevelLabel;
            System.Windows.Forms.Label countryIdLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dbDataSet = new FunPro3dataset.dbDataSet();
            this.tbTeacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbTeacherTableAdapter = new FunPro3dataset.dbDataSetTableAdapters.tbTeacherTableAdapter();
            this.tableAdapterManager = new FunPro3dataset.dbDataSetTableAdapters.TableAdapterManager();
            this.tbCountryTableAdapter = new FunPro3dataset.dbDataSetTableAdapters.tbCountryTableAdapter();
            this.tbTeacherBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbTeacherBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.list_box = new System.Windows.Forms.ListBox();
            this.crud_grpbx = new System.Windows.Forms.GroupBox();
            this.newGrade_numupdwn = new System.Windows.Forms.NumericUpDown();
            this.add_btn = new System.Windows.Forms.Button();
            this.newCountryid_combx = new System.Windows.Forms.ComboBox();
            this.tbCountryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newDob_dt = new System.Windows.Forms.DateTimePicker();
            this.newFirstName_tbx = new System.Windows.Forms.TextBox();
            this.newisActive_checbx = new System.Windows.Forms.CheckBox();
            this.newLastName_tbx = new System.Windows.Forms.TextBox();
            this.newPhone_tbx = new System.Windows.Forms.TextBox();
            this.first_btn = new System.Windows.Forms.Button();
            this.prev_btn = new System.Windows.Forms.Button();
            this.last_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.filter_tbx = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.delete_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.tbCountrytbTeacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            dobLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            gradeLevelLabel = new System.Windows.Forms.Label();
            countryIdLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeacherBindingNavigator)).BeginInit();
            this.tbTeacherBindingNavigator.SuspendLayout();
            this.crud_grpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newGrade_numupdwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountrytbTeacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(271, 67);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(76, 17);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "first Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(271, 95);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(75, 17);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "last Name:";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new System.Drawing.Point(271, 124);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new System.Drawing.Size(86, 17);
            dobLabel.TabIndex = 7;
            dobLabel.Text = "Date of birth";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(271, 151);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(52, 17);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "phone:";
            // 
            // gradeLevelLabel
            // 
            gradeLevelLabel.AutoSize = true;
            gradeLevelLabel.Location = new System.Drawing.Point(271, 179);
            gradeLevelLabel.Name = "gradeLevelLabel";
            gradeLevelLabel.Size = new System.Drawing.Size(87, 17);
            gradeLevelLabel.TabIndex = 11;
            gradeLevelLabel.Text = "grade Level:";
            // 
            // countryIdLabel
            // 
            countryIdLabel.AutoSize = true;
            countryIdLabel.Location = new System.Drawing.Point(271, 237);
            countryIdLabel.Name = "countryIdLabel";
            countryIdLabel.Size = new System.Drawing.Size(74, 17);
            countryIdLabel.TabIndex = 15;
            countryIdLabel.Text = "country Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(37, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 17);
            label1.TabIndex = 28;
            label1.Text = "first Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(37, 69);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 17);
            label2.TabIndex = 30;
            label2.Text = "last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(37, 98);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(86, 17);
            label3.TabIndex = 32;
            label3.Text = "Date of birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(37, 125);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(52, 17);
            label4.TabIndex = 34;
            label4.Text = "phone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(37, 153);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(87, 17);
            label5.TabIndex = 36;
            label5.Text = "grade Level:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(37, 211);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(74, 17);
            label6.TabIndex = 38;
            label6.Text = "country Id:";
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbTeacherBindingSource
            // 
            this.tbTeacherBindingSource.DataMember = "tbTeacher";
            this.tbTeacherBindingSource.DataSource = this.dbDataSet;
            this.tbTeacherBindingSource.CurrentChanged += new System.EventHandler(this.tbTeacherBindingSource_CurrentChanged);
            // 
            // tbTeacherTableAdapter
            // 
            this.tbTeacherTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbCountryTableAdapter = this.tbCountryTableAdapter;
            this.tableAdapterManager.tbTeacherTableAdapter = this.tbTeacherTableAdapter;
            this.tableAdapterManager.UpdateOrder = FunPro3dataset.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbCountryTableAdapter
            // 
            this.tbCountryTableAdapter.ClearBeforeFill = true;
            // 
            // tbTeacherBindingNavigator
            // 
            this.tbTeacherBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbTeacherBindingNavigator.BindingSource = this.tbTeacherBindingSource;
            this.tbTeacherBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbTeacherBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbTeacherBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbTeacherBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbTeacherBindingNavigatorSaveItem});
            this.tbTeacherBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbTeacherBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbTeacherBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbTeacherBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbTeacherBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbTeacherBindingNavigator.Name = "tbTeacherBindingNavigator";
            this.tbTeacherBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbTeacherBindingNavigator.Size = new System.Drawing.Size(1011, 27);
            this.tbTeacherBindingNavigator.TabIndex = 0;
            this.tbTeacherBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tbTeacherBindingNavigatorSaveItem
            // 
            this.tbTeacherBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbTeacherBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbTeacherBindingNavigatorSaveItem.Image")));
            this.tbTeacherBindingNavigatorSaveItem.Name = "tbTeacherBindingNavigatorSaveItem";
            this.tbTeacherBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tbTeacherBindingNavigatorSaveItem.Text = "Save Data";
            this.tbTeacherBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbTeacherBindingNavigatorSaveItem_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbTeacherBindingSource, "firstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(364, 64);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbTeacherBindingSource, "lastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(364, 92);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dobDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbTeacherBindingSource, "dob", true));
            this.dobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobDateTimePicker.Location = new System.Drawing.Point(364, 120);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dobDateTimePicker.TabIndex = 8;
            this.dobDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.dobDateTimePicker_Validating);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbTeacherBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(364, 148);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 22);
            this.phoneTextBox.TabIndex = 10;
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbTeacherBindingSource, "isActive", true));
            this.isActiveCheckBox.Location = new System.Drawing.Point(274, 204);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(290, 24);
            this.isActiveCheckBox.TabIndex = 14;
            this.isActiveCheckBox.Text = "isActive";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // list_box
            // 
            this.list_box.DataSource = this.tbTeacherBindingSource;
            this.list_box.DisplayMember = "lastName";
            this.list_box.FormattingEnabled = true;
            this.list_box.ItemHeight = 16;
            this.list_box.Location = new System.Drawing.Point(7, 42);
            this.list_box.Name = "list_box";
            this.list_box.Size = new System.Drawing.Size(199, 244);
            this.list_box.TabIndex = 17;
            // 
            // crud_grpbx
            // 
            this.crud_grpbx.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.crud_grpbx.Controls.Add(this.newGrade_numupdwn);
            this.crud_grpbx.Controls.Add(this.add_btn);
            this.crud_grpbx.Controls.Add(this.newCountryid_combx);
            this.crud_grpbx.Controls.Add(this.newDob_dt);
            this.crud_grpbx.Controls.Add(label1);
            this.crud_grpbx.Controls.Add(label6);
            this.crud_grpbx.Controls.Add(this.newFirstName_tbx);
            this.crud_grpbx.Controls.Add(this.newisActive_checbx);
            this.crud_grpbx.Controls.Add(label2);
            this.crud_grpbx.Controls.Add(label5);
            this.crud_grpbx.Controls.Add(this.newLastName_tbx);
            this.crud_grpbx.Controls.Add(this.newPhone_tbx);
            this.crud_grpbx.Controls.Add(label3);
            this.crud_grpbx.Controls.Add(label4);
            this.crud_grpbx.Location = new System.Drawing.Point(598, 30);
            this.crud_grpbx.Name = "crud_grpbx";
            this.crud_grpbx.Size = new System.Drawing.Size(374, 345);
            this.crud_grpbx.TabIndex = 18;
            this.crud_grpbx.TabStop = false;
            this.crud_grpbx.Text = "Add ";
            // 
            // newGrade_numupdwn
            // 
            this.newGrade_numupdwn.Location = new System.Drawing.Point(131, 153);
            this.newGrade_numupdwn.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.newGrade_numupdwn.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.newGrade_numupdwn.Name = "newGrade_numupdwn";
            this.newGrade_numupdwn.Size = new System.Drawing.Size(199, 22);
            this.newGrade_numupdwn.TabIndex = 40;
            this.newGrade_numupdwn.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(130, 271);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(122, 40);
            this.add_btn.TabIndex = 25;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // newCountryid_combx
            // 
            this.newCountryid_combx.DataSource = this.tbCountryBindingSource;
            this.newCountryid_combx.DisplayMember = "Name";
            this.newCountryid_combx.FormattingEnabled = true;
            this.newCountryid_combx.Location = new System.Drawing.Point(130, 202);
            this.newCountryid_combx.Name = "newCountryid_combx";
            this.newCountryid_combx.Size = new System.Drawing.Size(200, 24);
            this.newCountryid_combx.TabIndex = 39;
            // 
            // tbCountryBindingSource
            // 
            this.tbCountryBindingSource.DataMember = "tbCountry";
            this.tbCountryBindingSource.DataSource = this.dbDataSet;
            // 
            // newDob_dt
            // 
            this.newDob_dt.CustomFormat = "dd/MM/yyyy";
            this.newDob_dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.newDob_dt.Location = new System.Drawing.Point(130, 94);
            this.newDob_dt.Name = "newDob_dt";
            this.newDob_dt.Size = new System.Drawing.Size(200, 22);
            this.newDob_dt.TabIndex = 33;
            // 
            // newFirstName_tbx
            // 
            this.newFirstName_tbx.Location = new System.Drawing.Point(130, 38);
            this.newFirstName_tbx.Name = "newFirstName_tbx";
            this.newFirstName_tbx.Size = new System.Drawing.Size(200, 22);
            this.newFirstName_tbx.TabIndex = 29;
            this.newFirstName_tbx.Validating += new System.ComponentModel.CancelEventHandler(this.newFirstName_tbx_Validating);
            // 
            // newisActive_checbx
            // 
            this.newisActive_checbx.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newisActive_checbx.Location = new System.Drawing.Point(40, 178);
            this.newisActive_checbx.Name = "newisActive_checbx";
            this.newisActive_checbx.Size = new System.Drawing.Size(290, 24);
            this.newisActive_checbx.TabIndex = 37;
            this.newisActive_checbx.Text = "isActive";
            this.newisActive_checbx.UseVisualStyleBackColor = true;
            // 
            // newLastName_tbx
            // 
            this.newLastName_tbx.Location = new System.Drawing.Point(130, 66);
            this.newLastName_tbx.Name = "newLastName_tbx";
            this.newLastName_tbx.Size = new System.Drawing.Size(200, 22);
            this.newLastName_tbx.TabIndex = 31;
            this.newLastName_tbx.Validating += new System.ComponentModel.CancelEventHandler(this.newLastName_tbx_Validating);
            // 
            // newPhone_tbx
            // 
            this.newPhone_tbx.Location = new System.Drawing.Point(130, 122);
            this.newPhone_tbx.Name = "newPhone_tbx";
            this.newPhone_tbx.Size = new System.Drawing.Size(200, 22);
            this.newPhone_tbx.TabIndex = 35;
            this.newPhone_tbx.Validating += new System.ComponentModel.CancelEventHandler(this.newPhone_tbx_Validating);
            // 
            // first_btn
            // 
            this.first_btn.Location = new System.Drawing.Point(7, 350);
            this.first_btn.Name = "first_btn";
            this.first_btn.Size = new System.Drawing.Size(50, 40);
            this.first_btn.TabIndex = 19;
            this.first_btn.Text = "<<";
            this.first_btn.UseVisualStyleBackColor = true;
            this.first_btn.Click += new System.EventHandler(this.first_btn_Click);
            // 
            // prev_btn
            // 
            this.prev_btn.Location = new System.Drawing.Point(63, 350);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(50, 40);
            this.prev_btn.TabIndex = 20;
            this.prev_btn.Text = "<";
            this.prev_btn.UseVisualStyleBackColor = true;
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            // 
            // last_btn
            // 
            this.last_btn.Location = new System.Drawing.Point(175, 350);
            this.last_btn.Name = "last_btn";
            this.last_btn.Size = new System.Drawing.Size(50, 40);
            this.last_btn.TabIndex = 22;
            this.last_btn.Text = ">>";
            this.last_btn.UseVisualStyleBackColor = true;
            this.last_btn.Click += new System.EventHandler(this.last_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(119, 350);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(50, 40);
            this.next_btn.TabIndex = 23;
            this.next_btn.Text = ">";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // filter_tbx
            // 
            this.filter_tbx.Location = new System.Drawing.Point(13, 301);
            this.filter_tbx.Name = "filter_tbx";
            this.filter_tbx.Size = new System.Drawing.Size(193, 22);
            this.filter_tbx.TabIndex = 25;
            this.filter_tbx.TextChanged += new System.EventHandler(this.filter_tbx_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbTeacherBindingSource, "countryId", true));
            this.comboBox1.DataSource = this.tbCountryBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(364, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.ValueMember = "Id";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbTeacherBindingSource, "gradeLevel", true));
            this.numericUpDown1.Location = new System.Drawing.Point(365, 179);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(199, 22);
            this.numericUpDown1.TabIndex = 27;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(458, 292);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(122, 40);
            this.delete_btn.TabIndex = 26;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(274, 292);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(122, 40);
            this.save_btn.TabIndex = 27;
            this.save_btn.Text = "Save";
            this.save_btn.UseMnemonic = false;
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // tbCountrytbTeacherBindingSource
            // 
            this.tbCountrytbTeacherBindingSource.DataMember = "tbCountrytbTeacher";
            this.tbCountrytbTeacherBindingSource.DataSource = this.tbCountryBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 502);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.filter_tbx);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.last_btn);
            this.Controls.Add(this.prev_btn);
            this.Controls.Add(this.first_btn);
            this.Controls.Add(this.crud_grpbx);
            this.Controls.Add(this.list_box);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(dobLabel);
            this.Controls.Add(this.dobDateTimePicker);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(gradeLevelLabel);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(countryIdLabel);
            this.Controls.Add(this.tbTeacherBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeacherBindingNavigator)).EndInit();
            this.tbTeacherBindingNavigator.ResumeLayout(false);
            this.tbTeacherBindingNavigator.PerformLayout();
            this.crud_grpbx.ResumeLayout(false);
            this.crud_grpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newGrade_numupdwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountrytbTeacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource tbTeacherBindingSource;
        private dbDataSetTableAdapters.tbTeacherTableAdapter tbTeacherTableAdapter;
        private dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbTeacherBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbTeacherBindingNavigatorSaveItem;
        private dbDataSetTableAdapters.tbCountryTableAdapter tbCountryTableAdapter;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.ListBox list_box;
        private System.Windows.Forms.GroupBox crud_grpbx;
        private System.Windows.Forms.Button first_btn;
        private System.Windows.Forms.Button prev_btn;
        private System.Windows.Forms.Button last_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.TextBox filter_tbx;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tbCountryBindingSource;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.NumericUpDown newGrade_numupdwn;
        private System.Windows.Forms.ComboBox newCountryid_combx;
        private System.Windows.Forms.DateTimePicker newDob_dt;
        private System.Windows.Forms.TextBox newFirstName_tbx;
        private System.Windows.Forms.CheckBox newisActive_checbx;
        private System.Windows.Forms.TextBox newLastName_tbx;
        private System.Windows.Forms.TextBox newPhone_tbx;
        private System.Windows.Forms.BindingSource tbCountrytbTeacherBindingSource;
    }
}

