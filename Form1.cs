using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7Net;
namespace PARTEN_PROJECT
{
    public partial class Form1 : Form
    {
		// test code
        private  PLC plc = null;
        private ExceptionCode errorState = ExceptionCode.ExceptionNo;
        public Form1()
        {
            InitializeComponent();
        }
        #region Event
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Create
        private void btnconnect_Click(object sender, EventArgs e)
        {
            try
            {
                plc = new PLC(CPU_Type.S71200, txtID.Text, 0, 1);
                if (!plc.IsAvailable) throw new Exception("Không tìm thấy PLC cần kết nối!");
                errorState = plc.Open();
                if (errorState != ExceptionCode.ExceptionNo) throw new Exception(errorState.ToString());
                btnconnect.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,ex.Message,"Information",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                //throw ex;
            }
            
        }

        private void bndisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc!= null)
                {
                    plc.Close();
                    btnconnect.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,ex.Message,"Information",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }

        private void btnOn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc != null)
                {
                   // plc.Write("M0.0", 1);
                    plc.Write("M0.4",1);
                }
                else
                {
                    throw new Exception("Chưa kết nối với PLC");
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Chưa kết nối với PLC","Information",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }

        private void btnOff1_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc != null)
                {
                    plc.Write("M0.4", 0);
                }
                else
                {
                    throw new Exception("Chưa kết nối với PLC");
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Chưa kết nối với PLC", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private void btnOn2_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc != null)
                {
                    plc.Write("M0.5", 1);
                }
                else
                {
                    throw new Exception("Chưa kết nối với PLC");
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Chưa kết nối với PLC", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private void btnOff2_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc != null)
                {
                    plc.Write("M0.5", 0);
                }
                else
                {
                    throw new Exception("Chưa kết nối với PLC");
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Chưa kết nối với PLC", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private void btnOn3_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc != null)
                {
                    plc.Write("O0.2", 1);
                }
                else
                {
                    throw new Exception("Chưa kết nối với PLC");
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Chưa kết nối với PLC", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private void btnOff3_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc != null)
                {
                    plc.Write("O0.2", 0);
                }
                else
                {
                    throw new Exception("Chưa kết nối với PLC");
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Chưa kết nối với PLC", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private void btnOn4_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc != null)
                {
                    plc.Write("O0.3", 1);
                }
                else
                {
                    throw new Exception("Chưa kết nối với PLC");
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Chưa kết nối với PLC", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private void btnOff4_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc != null)
                {
                    plc.Write("O0.3", 0);
                }
                else
                {
                    throw new Exception("Chưa kết nối với PLC");
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Chưa kết nối với PLC", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private void btnOn5_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc != null)
                {
                    plc.Write("O0.4", 1);
                }
                else
                {
                    throw new Exception("Chưa kết nối với PLC");
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Chưa kết nối với PLC", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private void btnOff5_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc != null)
                {
                    plc.Write("O0.4", 0);
                }
                else
                {
                    throw new Exception("Chưa kết nối với PLC");
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Chưa kết nối với PLC", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }
        #endregion
    }
}
