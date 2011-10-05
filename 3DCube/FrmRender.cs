//===============================================
//| Downloaded from                             |
//| Visual C# Kicks - http://www.vcskicks.com/  |
//===============================================
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace _DCubeNoGimbalLock
{


    public partial class FrmRender : Form
    {
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern bool BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, System.Int32 dwRop);

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern IntPtr ReleaseDC(IntPtr hwnd, IntPtr hdc);


        public FrmRender()
        {
            InitializeComponent();
        }

        public class ZmienneGlobalne
        {
            public static int x, y, z, zoom=0;
        }

        Math3D.Cube mainCube;
        Point drawOrigin;


        private void FrmRender_Load(object sender, EventArgs e)
        {
            ZmienneGlobalne.x = Convert.ToInt32(textBox1.Text);
            ZmienneGlobalne.y = Convert.ToInt32(textBox2.Text);
            ZmienneGlobalne.z = Convert.ToInt32(textBox3.Text);
            label8.Text = Convert.ToString(ZmienneGlobalne.x * ZmienneGlobalne.y * ZmienneGlobalne.z) + " [ j^3 ]";
            label11.Text = Convert.ToString(ZmienneGlobalne.x * ZmienneGlobalne.y) + " [ j^2 ]";
            label12.Text = Convert.ToString((ZmienneGlobalne.x * ZmienneGlobalne.y * 2) + (ZmienneGlobalne.x * ZmienneGlobalne.z * 2) + (ZmienneGlobalne.y * ZmienneGlobalne.x * 2)) + " [ j^2 ]";
            mainCube = new Math3D.Cube(ZmienneGlobalne.x,ZmienneGlobalne.y,ZmienneGlobalne.z);
            drawOrigin = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
        }

        private void Render()
        {
            mainCube.RotateX = (float)tX.Value;
            mainCube.RotateY = (float)tY.Value;
            mainCube.RotateZ = (float)tZ.Value;

            pictureBox1.Image = mainCube.DrawCube(drawOrigin);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZmienneGlobalne.x = Convert.ToInt32(textBox1.Text);
            ZmienneGlobalne.y = Convert.ToInt32(textBox2.Text);
            ZmienneGlobalne.z = Convert.ToInt32(textBox3.Text);
            chWires.Checked = true;
            chFront.Checked = false;
            chBack.Checked = false;
            chLeft.Checked = false;
            chRight.Checked = false;
            chTop.Checked = false;
            chBottom.Checked = false;
            label8.Text = Convert.ToString(ZmienneGlobalne.x * ZmienneGlobalne.y * ZmienneGlobalne.z)+" [ j^3 ]";
            label11.Text = Convert.ToString(ZmienneGlobalne.x * ZmienneGlobalne.y)+" [ j^2 ]";
            label12.Text = Convert.ToString( (ZmienneGlobalne.x * ZmienneGlobalne.y *2) + (ZmienneGlobalne.x * ZmienneGlobalne.z * 2)+ (ZmienneGlobalne.y * ZmienneGlobalne.x * 2))+" [ j^2 ]";
            mainCube = new Math3D.Cube(ZmienneGlobalne.x, ZmienneGlobalne.y, ZmienneGlobalne.z); //Start over
            this.Refresh();
        }

        private void tX_Scroll(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void tY_Scroll(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void tZ_Scroll(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tX.Value = 0;
            tY.Value = 0;
            tZ.Value = 0;

            chWires.Checked = true;
            chFront.Checked = false;
            chBack.Checked = false;
            chLeft.Checked = false;
            chRight.Checked = false;
            chTop.Checked = false;
            chBottom.Checked = false;

            mainCube = new Math3D.Cube(ZmienneGlobalne.x, ZmienneGlobalne.y, ZmienneGlobalne.z); //Start over
            this.Refresh();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {



            ZmienneGlobalne.zoom = trackBar1.Value;
            label13.Text = Convert.ToString(trackBar1.Value);

            this.Refresh();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Render();
        }

        

        private void chWires_CheckedChanged(object sender, EventArgs e)
        {
            mainCube.DrawWires = chWires.Checked;
            this.Refresh();
        } 

        private void chFront_CheckedChanged(object sender, EventArgs e)
        {
            mainCube.FillFront = chFront.Checked;
            this.Refresh();
        }

        private void chBack_CheckedChanged(object sender, EventArgs e)
        {
            mainCube.FillBack = chBack.Checked;
            this.Refresh();
        }

        private void chLeft_CheckedChanged(object sender, EventArgs e)
        {
            mainCube.FillLeft = chLeft.Checked;
            this.Refresh();
        }

        private void chRight_CheckedChanged(object sender, EventArgs e)
        {
            mainCube.FillRight = chRight.Checked;
            this.Refresh();
        }

        private void chTop_CheckedChanged(object sender, EventArgs e)
        {
            mainCube.FillTop = chTop.Checked;
            this.Refresh();
        }

        private void chBottom_CheckedChanged(object sender, EventArgs e)
        {
            mainCube.FillBottom = chBottom.Checked;
            this.Refresh();
        }

             
             
    }
}