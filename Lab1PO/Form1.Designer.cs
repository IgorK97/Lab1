namespace Lab1PO
{
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
            PizzaDeliveryTable = new TabControl();
            Clients = new TabPage();
            dataGridViewClients = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            NameofClient = new DataGridViewTextBoxColumn();
            FamilyName = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            Login = new DataGridViewTextBoxColumn();
            _Password = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            button1 = new Button();
            Orders = new TabPage();
            dataGridViewOrders = new DataGridView();
            IdOrders = new DataGridViewTextBoxColumn();
            ClientId = new DataGridViewTextBoxColumn();
            IdCourier = new DataGridViewComboBoxColumn();
            final_price = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            address_del = new DataGridViewTextBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            ordertime = new DataGridViewTextBoxColumn();
            deliverytime = new DataGridViewTextBoxColumn();
            button2 = new Button();
            tabPage3 = new TabPage();
            dataGridViewReport1 = new DataGridView();
            groupBox1 = new GroupBox();
            button3 = new Button();
            comboBoxIngredients = new ComboBox();
            label1 = new Label();
            tabPage4 = new TabPage();
            groupBox2 = new GroupBox();
            button4 = new Button();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            dataGridViewReport2 = new DataGridView();
            PizzaDeliveryTable.SuspendLayout();
            Clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport1).BeginInit();
            groupBox1.SuspendLayout();
            tabPage4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport2).BeginInit();
            SuspendLayout();
            // 
            // PizzaDeliveryTable
            // 
            PizzaDeliveryTable.Controls.Add(Clients);
            PizzaDeliveryTable.Controls.Add(Orders);
            PizzaDeliveryTable.Controls.Add(tabPage3);
            PizzaDeliveryTable.Controls.Add(tabPage4);
            PizzaDeliveryTable.Location = new Point(12, 12);
            PizzaDeliveryTable.Name = "PizzaDeliveryTable";
            PizzaDeliveryTable.SelectedIndex = 0;
            PizzaDeliveryTable.Size = new Size(776, 426);
            PizzaDeliveryTable.TabIndex = 0;
            // 
            // Clients
            // 
            Clients.Controls.Add(dataGridViewClients);
            Clients.Controls.Add(button1);
            Clients.Location = new Point(4, 24);
            Clients.Name = "Clients";
            Clients.Padding = new Padding(3);
            Clients.Size = new Size(768, 398);
            Clients.TabIndex = 0;
            Clients.Text = "Clients";
            Clients.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Columns.AddRange(new DataGridViewColumn[] { Id, NameofClient, FamilyName, Surname, Login, _Password, Phone, Email, Address });
            dataGridViewClients.Location = new Point(8, 44);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.Size = new Size(754, 348);
            dataGridViewClients.TabIndex = 1;
            dataGridViewClients.CellFormatting += dataGridViewClients_CellFormatting;
            // 
            // Id
            // 
            Id.DataPropertyName = "id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // NameofClient
            // 
            NameofClient.DataPropertyName = "first_name";
            NameofClient.HeaderText = "Имя";
            NameofClient.Name = "NameofClient";
            // 
            // FamilyName
            // 
            FamilyName.DataPropertyName = "last_name";
            FamilyName.HeaderText = "Фамилия";
            FamilyName.Name = "FamilyName";
            // 
            // Surname
            // 
            Surname.DataPropertyName = "surname";
            Surname.HeaderText = "Отчество";
            Surname.Name = "Surname";
            // 
            // Login
            // 
            Login.DataPropertyName = "login";
            Login.HeaderText = "Логин";
            Login.Name = "Login";
            // 
            // _Password
            // 
            _Password.DataPropertyName = "_password";
            _Password.HeaderText = "Пароль";
            _Password.Name = "_Password";
            // 
            // Phone
            // 
            Phone.DataPropertyName = "phone";
            Phone.HeaderText = "Телефон";
            Phone.Name = "Phone";
            // 
            // Email
            // 
            Email.DataPropertyName = "email";
            Email.HeaderText = "Почта";
            Email.Name = "Email";
            // 
            // Address
            // 
            Address.DataPropertyName = "address";
            Address.HeaderText = "Адрес";
            Address.Name = "Address";
            // 
            // button1
            // 
            button1.Location = new Point(6, 6);
            button1.Name = "button1";
            button1.Size = new Size(92, 30);
            button1.TabIndex = 0;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonSaveClients_Click;
            // 
            // Orders
            // 
            Orders.Controls.Add(dataGridViewOrders);
            Orders.Controls.Add(button2);
            Orders.Location = new Point(4, 24);
            Orders.Name = "Orders";
            Orders.Padding = new Padding(3);
            Orders.Size = new Size(768, 398);
            Orders.TabIndex = 1;
            Orders.Text = "Orders";
            Orders.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.AllowUserToDeleteRows = false;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Columns.AddRange(new DataGridViewColumn[] { IdOrders, ClientId, IdCourier, final_price, Status, address_del, Weight, ordertime, deliverytime });
            dataGridViewOrders.Location = new Point(8, 44);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.ReadOnly = true;
            dataGridViewOrders.Size = new Size(754, 348);
            dataGridViewOrders.TabIndex = 1;
            dataGridViewOrders.CellFormatting += dataGridViewOrders_CellFormatting;
            // 
            // IdOrders
            // 
            IdOrders.DataPropertyName = "id";
            IdOrders.HeaderText = "Id";
            IdOrders.Name = "IdOrders";
            IdOrders.ReadOnly = true;
            // 
            // ClientId
            // 
            ClientId.DataPropertyName = "clientId";
            ClientId.HeaderText = "Id Клиента";
            ClientId.Name = "ClientId";
            ClientId.ReadOnly = true;
            // 
            // IdCourier
            // 
            IdCourier.DataPropertyName = "courierId";
            IdCourier.HeaderText = "Курьер";
            IdCourier.Name = "IdCourier";
            IdCourier.ReadOnly = true;
            // 
            // final_price
            // 
            final_price.DataPropertyName = "final_price";
            final_price.HeaderText = "Цена";
            final_price.Name = "final_price";
            final_price.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "status";
            Status.HeaderText = "Статус";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // address_del
            // 
            address_del.DataPropertyName = "address_del";
            address_del.HeaderText = "Адрес доставки";
            address_del.Name = "address_del";
            address_del.ReadOnly = true;
            // 
            // Weight
            // 
            Weight.DataPropertyName = "weight";
            Weight.HeaderText = "Вес";
            Weight.Name = "Weight";
            Weight.ReadOnly = true;
            // 
            // ordertime
            // 
            ordertime.DataPropertyName = "ordertime";
            ordertime.HeaderText = "Время доставки";
            ordertime.Name = "ordertime";
            ordertime.ReadOnly = true;
            // 
            // deliverytime
            // 
            deliverytime.DataPropertyName = "deliverytime";
            deliverytime.HeaderText = "Время доставки";
            deliverytime.Name = "deliverytime";
            deliverytime.ReadOnly = true;
            // 
            // button2
            // 
            button2.Location = new Point(6, 6);
            button2.Name = "button2";
            button2.Size = new Size(99, 35);
            button2.TabIndex = 0;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonSaveOrders_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridViewReport1);
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Отчет1";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReport1
            // 
            dataGridViewReport1.AllowUserToAddRows = false;
            dataGridViewReport1.AllowUserToDeleteRows = false;
            dataGridViewReport1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport1.Location = new Point(10, 85);
            dataGridViewReport1.Name = "dataGridViewReport1";
            dataGridViewReport1.ReadOnly = true;
            dataGridViewReport1.Size = new Size(752, 307);
            dataGridViewReport1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(comboBoxIngredients);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(7, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(740, 66);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button3
            // 
            button3.Location = new Point(406, 22);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Найти";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonGetReport1_Click;
            // 
            // comboBoxIngredients
            // 
            comboBoxIngredients.FormattingEnabled = true;
            comboBoxIngredients.Location = new Point(99, 21);
            comboBoxIngredients.Name = "comboBoxIngredients";
            comboBoxIngredients.Size = new Size(255, 23);
            comboBoxIngredients.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Ингредиент";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(groupBox2);
            tabPage4.Controls.Add(dataGridViewReport2);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(768, 398);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Отчет2";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(16, 11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(736, 63);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // button4
            // 
            button4.Location = new Point(445, 27);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "Найти";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonReport2_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(296, 26);
            numericUpDown2.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 2020, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 3;
            numericUpDown2.Value = new decimal(new int[] { 2020, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 31);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 2;
            label3.Text = "год";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(119, 26);
            numericUpDown1.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 28);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 0;
            label2.Text = "Заказы за месяц";
            // 
            // dataGridViewReport2
            // 
            dataGridViewReport2.AllowUserToAddRows = false;
            dataGridViewReport2.AllowUserToDeleteRows = false;
            dataGridViewReport2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport2.Location = new Point(16, 80);
            dataGridViewReport2.Name = "dataGridViewReport2";
            dataGridViewReport2.ReadOnly = true;
            dataGridViewReport2.Size = new Size(746, 312);
            dataGridViewReport2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PizzaDeliveryTable);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            PizzaDeliveryTable.ResumeLayout(false);
            Clients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            Orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl PizzaDeliveryTable;
        private TabPage Clients;
        private TabPage Orders;
        private DataGridView dataGridViewClients;
        private Button button1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dataGridViewOrders;
        private Button button2;
        private DataGridView dataGridViewReport1;
        private GroupBox groupBox1;
        private Button button3;
        private ComboBox comboBoxIngredients;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private DataGridView dataGridViewReport2;
        private Button button4;
        private NumericUpDown numericUpDown2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NameofClient;
        private DataGridViewTextBoxColumn FamilyName;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn _Password;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn IdOrders;
        private DataGridViewTextBoxColumn ClientId;
        private DataGridViewComboBoxColumn IdCourier;
        private DataGridViewTextBoxColumn final_price;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn address_del;
        private DataGridViewTextBoxColumn Weight;
        private DataGridViewTextBoxColumn ordertime;
        private DataGridViewTextBoxColumn deliverytime;
    }
}
