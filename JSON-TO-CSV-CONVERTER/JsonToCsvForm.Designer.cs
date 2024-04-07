namespace ProjectJsonToCsvConverter
{
    partial class JsonToCsvForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JsonToCsvForm));
            txtBoxJson = new TextBox();
            txtBoxCsv = new TextBox();
            textBoxUserInput = new TextBox();
            labelEndpoints = new Label();
            endPoints = new Label();
            btnRequest = new Button();
            btnConvert = new Button();
            JSON = new Label();
            CSV = new Label();
            SuspendLayout();
            // 
            // txtBoxJson
            // 
            txtBoxJson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtBoxJson.Location = new Point(37, 89);
            txtBoxJson.Multiline = true;
            txtBoxJson.Name = "txtBoxJson";
            txtBoxJson.ScrollBars = ScrollBars.Vertical;
            txtBoxJson.Size = new Size(400, 455);
            txtBoxJson.TabIndex = 2;
            txtBoxJson.TextChanged += textBoxJson_TextChanged;
            // 
            // txtBoxCsv
            // 
            txtBoxCsv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxCsv.Location = new Point(681, 89);
            txtBoxCsv.Multiline = true;
            txtBoxCsv.Name = "txtBoxCsv";
            txtBoxCsv.ScrollBars = ScrollBars.Vertical;
            txtBoxCsv.Size = new Size(400, 455);
            txtBoxCsv.TabIndex = 5;
            txtBoxCsv.TextChanged += textBoxCsv_TextChanged;
            // 
            // textBoxUserInput
            // 
            textBoxUserInput.Location = new Point(523, 23);
            textBoxUserInput.Name = "textBoxUserInput";
            textBoxUserInput.Size = new Size(354, 27);
            textBoxUserInput.TabIndex = 1;
            textBoxUserInput.Text = "name/Bulgaria";
            // 
            // labelEndpoints
            // 
            labelEndpoints.AutoSize = true;
            labelEndpoints.BorderStyle = BorderStyle.FixedSingle;
            labelEndpoints.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelEndpoints.Location = new Point(280, 26);
            labelEndpoints.Name = "labelEndpoints";
            labelEndpoints.Size = new Size(237, 22);
            labelEndpoints.TabIndex = 4;
            labelEndpoints.Text = "https://restcountries.com/v3.1/";
            // 
            // endPoints
            // 
            endPoints.AutoSize = true;
            endPoints.BorderStyle = BorderStyle.FixedSingle;
            endPoints.Location = new Point(450, 362);
            endPoints.Name = "endPoints";
            endPoints.Size = new Size(217, 182);
            endPoints.TabIndex = 5;
            endPoints.Text = "Endpoints:\r\n- name/(name)\r\n  name/Bulgaria\r\n- region/(region)\r\n  (region/Europe)\r\n- subregion/(region)\r\n  (subregion/SouthEast Europe)\r\n- capital/(capital)\r\n  (capital/Sofia)\r\n";
            endPoints.Click += label1_Click;
            // 
            // btnRequest
            // 
            btnRequest.BackColor = SystemColors.ControlLightLight;
            btnRequest.Location = new Point(473, 89);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(172, 144);
            btnRequest.TabIndex = 3;
            btnRequest.Text = "Request API";
            btnRequest.UseVisualStyleBackColor = false;
            btnRequest.Click += btnRequest_Click;
            // 
            // btnConvert
            // 
            btnConvert.BackColor = SystemColors.ControlLightLight;
            btnConvert.Location = new Point(473, 256);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(172, 89);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Convert to CSV";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Visible = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // JSON
            // 
            JSON.AutoSize = true;
            JSON.Location = new Point(200, 66);
            JSON.Name = "JSON";
            JSON.Size = new Size(44, 20);
            JSON.TabIndex = 8;
            JSON.Text = "JSON";
            JSON.Click += label2_Click;
            // 
            // CSV
            // 
            CSV.AutoSize = true;
            CSV.Location = new Point(866, 66);
            CSV.Name = "CSV";
            CSV.Size = new Size(35, 20);
            CSV.TabIndex = 9;
            CSV.Text = "CSV";
            CSV.Click += label3_Click;
            // 
            // JsonToCsvForm
            // 
            AcceptButton = btnRequest;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 589);
            Controls.Add(CSV);
            Controls.Add(JSON);
            Controls.Add(btnConvert);
            Controls.Add(btnRequest);
            Controls.Add(endPoints);
            Controls.Add(labelEndpoints);
            Controls.Add(textBoxUserInput);
            Controls.Add(txtBoxCsv);
            Controls.Add(txtBoxJson);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "JsonToCsvForm";
            Text = "JsonToCsv";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBoxJson;
        private TextBox txtBoxCsv;
        private TextBox textBoxUserInput;
        private Label labelEndpoints;
        private Label endPoints;
        private Button btnRequest;
        private Button btnConvert;
        private Label JSON;
        private Label CSV;
    }
}
