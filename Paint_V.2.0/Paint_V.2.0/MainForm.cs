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
        IPaintGraphics _paintGraphics; //оставить один
        public MainForm()
        {
            InitializeComponent();
            // new paint logic
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

        private void SelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _engine._tool._currentmode = EIntaractionModes.Select;
        }

        private void ChangeColorPictureBox_Click(object sender, EventArgs e)
        {
            if (ChangeColorDialog.ShowDialog()==DialogResult.OK) 
            {
                _engine._tool.MyColorARGB = ChangeColorDialog.Color.ToArgb();
                CurrentColorPictureBox.BackColor = ChangeColorDialog.Color;
                _engine._history.SetSelectedFigureColor(ChangeColorDialog.Color.ToArgb());
                MainPictureBox.Image = _paintGraphics.MyDrawFigures(_engine._history);
            }
        }

        private void ThicknessTrackBar_Scroll(object sender, EventArgs e)
        {
            _engine._tool.Thickness = ThicknessTrackBar.Value;
            _engine._history.SetSelectedFigureThikness(ThicknessTrackBar.Value);
            MainPictureBox.Image = _paintGraphics.MyDrawFigures(_engine._history);
        }

        private void MoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _engine._tool._currentmode = EIntaractionModes.Move;
        }

        private void EllipseToolStripButton_Click(object sender, EventArgs e)
        {
            _engine._tool._currentmode = EIntaractionModes.CreateEllipse;
        }

        private void CurveToolStripButton_Click(object sender, EventArgs e)
        {
            _engine._tool._currentmode = EIntaractionModes.CreateCurve;
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _engine._history.ClearFigureList();
            MainPictureBox.Image = _paintGraphics.MyDrawFigures(_engine._history);
        }

        private void UndoToolStripButton_Click(object sender, EventArgs e)
        {
            _engine._history.Undo();
            MainPictureBox.Image = _paintGraphics.MyDrawFigures(_engine._history);
        }

        private void RedoToolStripButton_Click(object sender, EventArgs e)
        {
            _engine._history.Redo();
            MainPictureBox.Image = _paintGraphics.MyDrawFigures(_engine._history);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png";
            //saveFileDialog1.ShowDialog();
            //if (saveFileDialog1.FileName != "")
            //{
            //    _currentBitmap.Save(saveFileDialog1.FileName);
            //}
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog()==DialogResult.OK) 
            {
                MainPictureBox.Image.Save(saveFileDialog.FileName);
            }
        }
    }
}
