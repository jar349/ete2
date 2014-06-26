using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ete2
{
    public partial class MainForm : Form
    {
        private bool isClosing = false;


        public MainForm()
        {
            InitializeComponent();
        }


        public void ShowAboutDialog() 
        {
            MessageBox.Show("This feature not yet implemented!");
        }

        public void Exit()
        {
            if (!isClosing) { this.Close(); }
        }

        public void ShowAddTimerDialog()
        {
        }

        public void ClearAllTimers()
        {
        }

        public void CheckForUpdates()
        {
            MessageBox.Show("This feature not implemented yet!");
        }


        private void file_exitMenu_Click(object sender, EventArgs e)
        {
            this.Exit();
        }

        private void timers_addTimerMenu_Click(object sender, EventArgs e)
        {
            this.ShowAddTimerDialog();
        }

        private void timers_clearAllTimersMenu_Click(object sender, EventArgs e)
        {
            this.ClearAllTimers();
        }

        private void help_checkForUpdatesMenu_Click(object sender, EventArgs e)
        {
            this.CheckForUpdates();
        }

        private void help_aboutMenu_Click(object sender, EventArgs e)
        {
            this.ShowAboutDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            isClosing = true;
            this.Exit();
        }
    }
}
