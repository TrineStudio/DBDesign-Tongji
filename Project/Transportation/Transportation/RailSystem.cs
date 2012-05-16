﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Transportation
{
    public partial class RailSystem : Form
    {
        public RailSystem()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RailSystem_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// 设置鼠标单击的坐标，以及图片的坐标
        /// 
        int mouseX;
        int mouseY;
        int picX;
        int picY;

        ///


        /// 当鼠标单击时，给鼠标设定值。初始化。
        ///

        /// 
        /// 
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = Cursor.Position.X;
            mouseY = Cursor.Position.Y;
            picX = this.pictureBox1.Left;
            picY = this.pictureBox1.Top;

            //if (isMouseMoveEventAviable == false)
            //    //添加鼠标移动事件
            this.pictureBox1.MouseMove += this.pictureBox1_MouseMove;
        }

        ///

        /// 根据鼠标的移动的值，设置
        ///

        /// 
        /// 
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int y = Cursor.Position.Y - mouseY + picY;
            int x = Cursor.Position.X - mouseX + picX;
            if (e.Button == MouseButtons.Left)
            {
                this.pictureBox1.Top = y;
                this.pictureBox1.Left = x;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseX = 0;
            mouseY = 0;
            if (this.pictureBox1.Location.X < 0)
            {
                this.pictureBox1.Left = 0;

            }
            if (this.pictureBox1.Location.Y < 0)
            {
                this.pictureBox1.Top = 0;
            }
            if ((this.pictureBox1.Left + this.pictureBox1.Width) > this.ClientSize.Width)
            {
                this.pictureBox1.Left = this.ClientSize.Width - this.pictureBox1.Width;
            }
            if ((this.pictureBox1.Top + this.pictureBox1.Height) > this.ClientSize.Height)
            {
                this.pictureBox1.Top = this.ClientSize.Height - this.pictureBox1.Height;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Cursor = Cursors.SizeAll;
        }
    }
}