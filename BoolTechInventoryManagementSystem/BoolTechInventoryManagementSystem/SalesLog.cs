using BoolTechInventoryManagementSystem.SystemDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoolTechInventoryManagementSystem
{
    public partial class SalesLog : Form
    {
        public SalesLog()
        {
            InitializeComponent();
        }
        public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer("click.wav");
            simpleSound.Play();
        }
        private void salesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.systemDataSet);

        }

        private void SalesLog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'systemDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.systemDataSet.Sales);

        }

        private void addButtton_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            addSalesLog asf = new addSalesLog();
            asf.FormClosed += delegate
            {
                salesTableAdapter.Fill(this.systemDataSet.Sales);
            };
            asf.ShowDialog();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            deleteSalesLog dsl = new deleteSalesLog();
            dsl.FormClosed += delegate
            {
                salesTableAdapter.Fill(this.systemDataSet.Sales);
            };
            dsl.ShowDialog();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            modifySalesLog msf = new modifySalesLog();
            msf.FormClosed += delegate
            {
                salesTableAdapter.Fill(this.systemDataSet.Sales);
            };
            msf.ShowDialog();
        }

        private void lightButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            darkButton.ForeColor = Color.Black;
            lightButton.ForeColor = Color.Black;

        }

        private void darkButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
            darkButton.ForeColor = Color.White;
            lightButton.ForeColor = Color.White;
        }
    }
}
