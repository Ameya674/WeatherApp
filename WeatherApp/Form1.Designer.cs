namespace WeatherApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.city = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.windspeed = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.details = new System.Windows.Forms.Label();
            this.condition = new System.Windows.Forms.Label();
            this.maxtemp = new System.Windows.Forms.Label();
            this.mintemp = new System.Windows.Forms.Label();
            this.na = new System.Windows.Forms.Label();
            this.na2 = new System.Windows.Forms.Label();
            this.na4 = new System.Windows.Forms.Label();
            this.na3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.BackColor = System.Drawing.Color.Transparent;
            this.city.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.ForeColor = System.Drawing.Color.White;
            this.city.Location = new System.Drawing.Point(282, 113);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(77, 32);
            this.city.TabIndex = 0;
            this.city.Text = "City:";
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.White;
            this.input.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(373, 110);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(233, 39);
            this.input.TabIndex = 1;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(639, 105);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(140, 49);
            this.search.TabIndex = 2;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // windspeed
            // 
            this.windspeed.AutoSize = true;
            this.windspeed.BackColor = System.Drawing.Color.Transparent;
            this.windspeed.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windspeed.ForeColor = System.Drawing.Color.White;
            this.windspeed.Location = new System.Drawing.Point(591, 348);
            this.windspeed.Name = "windspeed";
            this.windspeed.Size = new System.Drawing.Size(188, 32);
            this.windspeed.TabIndex = 3;
            this.windspeed.Text = "Wind Speed:";
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.BackColor = System.Drawing.Color.Transparent;
            this.humidity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidity.ForeColor = System.Drawing.Color.White;
            this.humidity.Location = new System.Drawing.Point(591, 411);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(145, 32);
            this.humidity.TabIndex = 4;
            this.humidity.Text = "Humidity:";
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.BackColor = System.Drawing.Color.Transparent;
            this.details.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.ForeColor = System.Drawing.Color.White;
            this.details.Location = new System.Drawing.Point(808, 269);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(0, 32);
            this.details.TabIndex = 6;
            // 
            // condition
            // 
            this.condition.AutoSize = true;
            this.condition.BackColor = System.Drawing.Color.Transparent;
            this.condition.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condition.ForeColor = System.Drawing.Color.White;
            this.condition.Location = new System.Drawing.Point(808, 206);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(0, 32);
            this.condition.TabIndex = 5;
            // 
            // maxtemp
            // 
            this.maxtemp.AutoSize = true;
            this.maxtemp.BackColor = System.Drawing.Color.Transparent;
            this.maxtemp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxtemp.ForeColor = System.Drawing.Color.White;
            this.maxtemp.Location = new System.Drawing.Point(220, 411);
            this.maxtemp.Name = "maxtemp";
            this.maxtemp.Size = new System.Drawing.Size(163, 32);
            this.maxtemp.TabIndex = 8;
            this.maxtemp.Text = "Max Temp:";
            // 
            // mintemp
            // 
            this.mintemp.AutoSize = true;
            this.mintemp.BackColor = System.Drawing.Color.Transparent;
            this.mintemp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mintemp.ForeColor = System.Drawing.Color.White;
            this.mintemp.Location = new System.Drawing.Point(220, 348);
            this.mintemp.Name = "mintemp";
            this.mintemp.Size = new System.Drawing.Size(156, 32);
            this.mintemp.TabIndex = 7;
            this.mintemp.Text = "Min Temp:";
            // 
            // na
            // 
            this.na.AutoSize = true;
            this.na.BackColor = System.Drawing.Color.Transparent;
            this.na.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.na.ForeColor = System.Drawing.Color.White;
            this.na.Location = new System.Drawing.Point(403, 348);
            this.na.Name = "na";
            this.na.Size = new System.Drawing.Size(0, 32);
            this.na.TabIndex = 9;
            // 
            // na2
            // 
            this.na2.AutoSize = true;
            this.na2.BackColor = System.Drawing.Color.Transparent;
            this.na2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.na2.ForeColor = System.Drawing.Color.White;
            this.na2.Location = new System.Drawing.Point(403, 411);
            this.na2.Name = "na2";
            this.na2.Size = new System.Drawing.Size(0, 32);
            this.na2.TabIndex = 10;
            // 
            // na4
            // 
            this.na4.AutoSize = true;
            this.na4.BackColor = System.Drawing.Color.Transparent;
            this.na4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.na4.ForeColor = System.Drawing.Color.White;
            this.na4.Location = new System.Drawing.Point(808, 411);
            this.na4.Name = "na4";
            this.na4.Size = new System.Drawing.Size(0, 32);
            this.na4.TabIndex = 12;
            // 
            // na3
            // 
            this.na3.AutoSize = true;
            this.na3.BackColor = System.Drawing.Color.Transparent;
            this.na3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.na3.ForeColor = System.Drawing.Color.White;
            this.na3.Location = new System.Drawing.Point(808, 348);
            this.na3.Name = "na3";
            this.na3.Size = new System.Drawing.Size(0, 32);
            this.na3.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(227, 230);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(74, 32);
            this.time.TabIndex = 13;
            this.time.Text = "time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(591, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Weather:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(591, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Description:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 603);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.na4);
            this.Controls.Add(this.na3);
            this.Controls.Add(this.na2);
            this.Controls.Add(this.na);
            this.Controls.Add(this.maxtemp);
            this.Controls.Add(this.mintemp);
            this.Controls.Add(this.details);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.windspeed);
            this.Controls.Add(this.search);
            this.Controls.Add(this.input);
            this.Controls.Add(this.city);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label city;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label windspeed;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.Label details;
        private System.Windows.Forms.Label condition;
        private System.Windows.Forms.Label maxtemp;
        private System.Windows.Forms.Label mintemp;
        private System.Windows.Forms.Label na;
        private System.Windows.Forms.Label na2;
        private System.Windows.Forms.Label na4;
        private System.Windows.Forms.Label na3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

