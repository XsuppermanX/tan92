using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
//using System.Net;
using DocumentProcessing;
using DocumentProcessing.Common;
using System.Collections.Generic;
using System.IO;
using DocumentProcessing.Image2Ftp;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;


namespace DocumentProcessing
{
	/// <summary>
	/// Summary description for LoginForm.
	/// </summary>
	public class LoginForm : System.Windows.Forms.Form 
	{
        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox m_TxtPassword;
		private System.Windows.Forms.Label m_LblPassword;
		private System.Windows.Forms.TextBox m_TxtUserName;
		private System.Windows.Forms.Label m_LblUserName;
		private System.Windows.Forms.Button m_CmdLogin;
		private System.Windows.Forms.Button m_CmdCancel;
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Label label2;
		
        public LoginForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		
		}

		// Input value
		public string  UserID
		{
            get { return m_TxtUserName.Text; }
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_TxtPassword = new System.Windows.Forms.TextBox();
            this.m_LblPassword = new System.Windows.Forms.Label();
            this.m_TxtUserName = new System.Windows.Forms.TextBox();
            this.m_LblUserName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.m_CmdLogin = new System.Windows.Forms.Button();
            this.m_CmdCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_TxtPassword);
            this.groupBox1.Controls.Add(this.m_LblPassword);
            this.groupBox1.Controls.Add(this.m_TxtUserName);
            this.groupBox1.Controls.Add(this.m_LblUserName);
            this.groupBox1.Location = new System.Drawing.Point(251, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // m_TxtPassword
            // 
            this.m_TxtPassword.Location = new System.Drawing.Point(76, 84);
            this.m_TxtPassword.Name = "m_TxtPassword";
            this.m_TxtPassword.PasswordChar = '*';
            this.m_TxtPassword.Size = new System.Drawing.Size(176, 20);
            this.m_TxtPassword.TabIndex = 2;
            this.m_TxtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_TxtPassword_KeyDown);
            // 
            // m_LblPassword
            // 
            this.m_LblPassword.AutoSize = true;
            this.m_LblPassword.ForeColor = System.Drawing.SystemColors.Desktop;
            this.m_LblPassword.Location = new System.Drawing.Point(14, 88);
            this.m_LblPassword.Name = "m_LblPassword";
            this.m_LblPassword.Size = new System.Drawing.Size(53, 13);
            this.m_LblPassword.TabIndex = 9;
            this.m_LblPassword.Text = "Password";
            // 
            // m_TxtUserName
            // 
            this.m_TxtUserName.Location = new System.Drawing.Point(76, 55);
            this.m_TxtUserName.MaxLength = 50;
            this.m_TxtUserName.Name = "m_TxtUserName";
            this.m_TxtUserName.Size = new System.Drawing.Size(176, 20);
            this.m_TxtUserName.TabIndex = 1;
            // 
            // m_LblUserName
            // 
            this.m_LblUserName.AutoSize = true;
            this.m_LblUserName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.m_LblUserName.Location = new System.Drawing.Point(14, 59);
            this.m_LblUserName.Name = "m_LblUserName";
            this.m_LblUserName.Size = new System.Drawing.Size(58, 13);
            this.m_LblUserName.TabIndex = 6;
            this.m_LblUserName.Text = "User name";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(212, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(357, 50);
            this.label7.TabIndex = 17;
            this.label7.Text = "Scan Paperless Desktop";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_CmdLogin
            // 
            this.m_CmdLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.m_CmdLogin.Location = new System.Drawing.Point(302, 328);
            this.m_CmdLogin.Name = "m_CmdLogin";
            this.m_CmdLogin.Size = new System.Drawing.Size(75, 23);
            this.m_CmdLogin.TabIndex = 3;
            this.m_CmdLogin.Text = "Login";
            this.m_CmdLogin.UseVisualStyleBackColor = false;
            this.m_CmdLogin.Click += new System.EventHandler(this.m_CmdLogin_Click);
            // 
            // m_CmdCancel
            // 
            this.m_CmdCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.m_CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_CmdCancel.Location = new System.Drawing.Point(390, 328);
            this.m_CmdCancel.Name = "m_CmdCancel";
            this.m_CmdCancel.Size = new System.Drawing.Size(75, 23);
            this.m_CmdCancel.TabIndex = 4;
            this.m_CmdCancel.Text = "Cancel";
            this.m_CmdCancel.UseVisualStyleBackColor = false;
            this.m_CmdCancel.Click += new System.EventHandler(this.m_CmdCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "ace life";
            // 
            // LoginForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1178, 578);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.m_CmdCancel);
            this.Controls.Add(this.m_CmdLogin);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scan PPD - Login - ACE Life";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		// Load handlers
		private void LoginForm_Load(object sender, System.EventArgs e)
		{
			this.Activate();

			m_TxtUserName.Text = System.Environment.MachineName.Substring("vnaho0".Length).ToLower();
			
			m_TxtPassword.Focus();
           
		}

		// Command handlers
		private void m_CmdLogin_Click(object sender, System.EventArgs e)
		{
			Identity idUserID = new Identity();
			int intLoginRes;
            //if (Global.connGlobal.State == ConnectionState.Closed)
            //    Global.connGlobal.Open();
            // intLoginRes = GFunction.DoLogin(m_TxtUserName.Text.Trim(), m_TxtPassword.Text, Global.ws);
            intLoginRes = 1;

            switch (intLoginRes)
			{
				case 1:  // Login successfully
					DialogResult = DialogResult.OK;
					Close();
					break;
				case 0: // Login failed
					MessageBox.Show("Incorrect User Name / Password. Login failed, Please try again !", "PP Desktop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					this.DialogResult = DialogResult.None;
					break;
				case -1: // Blocked
                    MessageBox.Show("User was blocked. Please contact Administrator.", "PP Desktop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					this.DialogResult = DialogResult.None;
					break;
				default:
					break;
			}
		}
		/*private string GetFromIP()
		{
			string strFromIP = "";

			IPHostEntry iphostentry = Dns.GetHostByName(Dns.GetHostName());
			foreach (IPAddress ipaddress in iphostentry.AddressList)
				strFromIP += ipaddress.ToString() + ", ";
			strFromIP = strFromIP.Substring(0, strFromIP.Length-2);

			return strFromIP;
		}
        */
		private void m_CmdCancel_Click(object sender, System.EventArgs e)
		{
           
                    this.Close();
                 
		}

        private void m_TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Identity idUserID = new Identity();
                int intLoginRes;
                // if (Global.connGlobal.State == ConnectionState.Closed)
                //   Global.connGlobal.Open();
                intLoginRes = GFunction.DoLogin(m_TxtUserName.Text.Trim(), m_TxtPassword.Text, Global.ws);

                switch (intLoginRes)
                {
                    case 1:  // Login successfully
                        DialogResult = DialogResult.OK;
                        Close();
                        break;
                    case 0: // Login failed
                        MessageBox.Show("Incorrect User Name / Password. Login failed, Please try again !", "PP Desktop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        this.DialogResult = DialogResult.None;
                        break;
                    case -1: // Blocked
                        MessageBox.Show("User was blocked. Please contact Administrator.", "PP Desktop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        this.DialogResult = DialogResult.None;
                        break;
                    default:
                        break;
                }
                
            }

        }
        /*
        public void Upload()
        {
            try
            {
                
                string requestURL = "http://localhost:8180/dds/services/UserWebService?wsdl";
                string fileName = "C:\\Working\\welcome_letter.pdf";
                
                WebClient wc = new WebClient();
                byte[] bytes = File.ReadAllBytes(fileName); // You need to do this download if your file is on any other server otherwise you can convert that file directly to bytes  
                Dictionary<string, object> postParameters = new Dictionary<string, object>();
                // Add your parameters here  
                postParameters.Add("fileToUpload", new FormUpload.FileParameter(bytes, Path.GetFileName(fileName), "image/png")); //application/pdf - image/png
                string userAgent = "Someone";
                HttpWebResponse webResponse = FormUpload.MultipartFormPost(requestURL, userAgent, postParameters, "aaa", "aaa");
                // Process response  
                StreamReader responseReader = new StreamReader(webResponse.GetResponseStream());
                String returnResponseText = responseReader.ReadToEnd();
                webResponse.Close();
                 
            }
            catch (Exception)
            {

            }
        }


         public void UploadFilesAsync(string paths)
            {
                if(0==0)
                {
                    HttpClient client = new HttpClient();
                    // we need to send a request with multipart/form-data
                    var multiForm = new MultipartFormDataContent();
                    string fileMimeType = "";

                    // add file and directly upload it
                    //for (int i = 0; i < files.Count(); i++)
                    //{
                        FileStream fs = File.OpenRead(paths);
                        var streamContent = new StreamContent(fs);
                        if (Path.GetExtension(paths) == ".pdf")
                            fileMimeType = "application/pdf";
                        else
                            fileMimeType = "application/xml";

                        //string dd = MimeType(path);
                        var imageContent = new ByteArrayContent(streamContent.ReadAsByteArrayAsync().Result);
                        imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse(fileMimeType);
                        //imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                        multiForm.Add(imageContent, "files", Path.GetFileName(paths));
                        fs.Close();
                    

                    // send request to API
                    var url = "http://localhost:8180/dds/services/UserWebService?wsdl";
                    var response = client.PostAsync(url, multiForm);



                    if (response.IsCompleted == true)
                    {
                        MessageBox.Show("Success");
                    }
                    else
                    {
                        MessageBox.Show(response.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("There are no files in the folder to process");
                }
            } */
	}
}