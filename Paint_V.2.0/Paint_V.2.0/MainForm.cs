using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_V._2._0
{
    public partial class MainForm : Form
    {
        Engine _engine = new Engine();
        IPaintGraphics _paintGraphics;
        public MainForm()
        {
            InitializeComponent();
            _paintGraphics = new PaintGraphics(MainPictureBox.Size);
            ThicknessTrackBar.Value = _engine._tool.Thickness;
            CurrentColorPictureBox.BackColor = Color.FromArgb(255<<24+_engine._tool.MyColorARGB);//alpha+Color

        }

        private void DotToolStripButton_Click(object sender, EventArgs e)
        {
            _engine._tool._currentmode = EIntaractionModes.CreateDot;
        }

        private void MainPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _engine.DrawingUp();
        }

        private void MainPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _engine.DrawingDown(e.X,e.Y);
            MainPictureBox.Image = _paintGraphics.MyDrawFigures(_engine._history);
        }

        private void MainPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            _engine.DrawingMove(e.X,e.Y);
            MainPictureBox.Image = _paintGraphics.MyDrawFigures(_engine._history);  
        }

        private void SelectToolStripButton_Click(object sender, EventArgs e)
        {
            _engine._tool._currentmode = EIntaractionModes.Select;
        }

        private void ChangeColorPictureBox_Click(object sender, EventArgs e)
        {
            if (ChangeColorDialog.ShowDialog()==DialogResult.OK) 
            {
                _engine._tool.MyColorARGB = ChangeColorDialog.Color.ToArgb();
                CurrentColorPictureBox.BackColor = ChangeColorDialog.Color;
            }
        }

        private void ThicknessTrackBar_Scroll(object sender, EventArgs e)
        {
            _engine._tool.Thickness = ThicknessTrackBar.Value;
        }

        private void MoveToolStripButton_Click(object sender, EventArgs e)
        {
            _engine._tool._currentmode = EIntaractionModes.Move;
        }
    }
}
