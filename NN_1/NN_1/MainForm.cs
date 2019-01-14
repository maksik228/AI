using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NN_1
{
    public partial class MainForm : Form
    {
        PaintingGrid PG;

        Perceptron Pers;

        List<LearningPicture> LearningSample;

        //List<List<double>> Weights;
        //List<> TrainingSample;
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void Grid_pictureBox_Paint(object sender, PaintEventArgs e)
        {
            PG.DrawGrid(e.Graphics,new Point(0, 0), Grid_pictureBox.Size, new Pen(Color.Black, 2));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //PG = new PaintingGrid((int)X_numericUpDown.Value, (int)Y_numericUpDown.Value);
            PG = new PaintingGrid(5,5);
            Grid_pictureBox.Refresh();
        }

        private void Grid_pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            int Step_I = Grid_pictureBox.Size.Width / PG.RowCount;
            int Step_J = Grid_pictureBox.Size.Height / PG.ColumnCount;
            int Index_I = e.Y / Step_I;
            int Index_J = e.X / Step_J;
            if (PG.Matrix[Index_I][Index_J] == false)
            {
                PG.Matrix[Index_I][Index_J] = true;
            }
            else
            {
                PG.Matrix[Index_I][Index_J] = false;
            }


            Grid_pictureBox.Refresh();
            Recognize_textBox.Clear();
        }

        //private void X_numericUpDown_ValueChanged(object sender, EventArgs e)
        //{
        //    PG = new PaintingGrid((int)X_numericUpDown.Value, (int)Y_numericUpDown.Value);
        //    Grid_pictureBox.Refresh();
        //}

        //private void Y_numericUpDown_ValueChanged(object sender, EventArgs e)
        //{
        //    PG = new PaintingGrid((int)X_numericUpDown.Value, (int)Y_numericUpDown.Value);
        //    Grid_pictureBox.Refresh();
        //}

        private void ApplySettings_button_Click(object sender, EventArgs e)
        {
            if (ApplySettings_button.Text == "Применить")
            {
               // Pers = new Perceptron((int)X_numericUpDown.Value, (int)Y_numericUpDown.Value, (double)LearningSpeed_numericUpDown.Value, (double)Threshold_numericUpDown.Value);
                Pers = new Perceptron(5, 5, (double)LearningSpeed_numericUpDown.Value, (double)Threshold_numericUpDown.Value);
               // Setting_groupBox.Enabled = false;
                //Setting_groupBox.Enabled = true;
                //Teach_groupBox.Enabled = true;
                //Recognize_groupBox.Enabled = true;
                ApplySettings_button.Text = "Настроить";
            }
            else
            {
                //Setting_groupBox.Enabled = true;
                //Teach_groupBox.Enabled = false;
                //Recognize_groupBox.Enabled = false;
                ApplySettings_button.Text = "Применить";
            }
           
        }

        private void Teach_button_Click(object sender, EventArgs e)
        {
            bool IsLeant = Pers.Teach(PG.Matrix, this.IsTrue_checkBox.Checked);
            if (this.LearningSample == null)
                this.LearningSample = new List<LearningPicture>();

            List<List<bool>> NewMatrix = new List<List<bool>>();
            foreach (List<bool> row in PG.Matrix)
            {
                NewMatrix.Add(new List<bool>());
                foreach (bool pix in row)
                {
                    NewMatrix.Last().Add(pix);
                }
            }

            this.LearningSample.Add(new LearningPicture(NewMatrix, this.IsTrue_checkBox.Checked));
            while (IsLeant == false)
            {
                IsLeant = true;
                foreach (LearningPicture LP in this.LearningSample)
                {
                    //не обяз true
                    if (Pers.Teach(LP.Picture, LP.Answer) == false)
                    {
                        IsLeant = false;
                    }
                }
            }
            PG.Clear();
            Grid_pictureBox.Refresh();

            //Pers.Teach(PG.Matrix, true);

        }

        private void Select_Learning_Sample_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "*.txt|*.txt";
            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.LearningSample = new List<LearningPicture>();
                try
                {
                    StreamReader SR = new StreamReader(OFD.FileName);
                    int PicturesCount = Convert.ToInt32(SR.ReadLine());
                    int RowsCount = Convert.ToInt32(SR.ReadLine());
                    int ColumnCount = Convert.ToInt32(SR.ReadLine());

                    for (int p = 0; p < PicturesCount; p++)
                    {
                        int ss = Convert.ToInt32(SR.ReadLine());
                        bool ans = Convert.ToBoolean(ss);
                        List<List<bool>> Pic = new List<List<bool>>();
                        //LearningSample.Add(new List<List<bool>>());
                        for (int r = 0; r < RowsCount; r++)
                        {
                            Pic.Add(new List<bool> ());
                            //LearningSample[p].Add(new List<bool>());
                            for (int c = 0; c < ColumnCount; c++)
                            {
                                int next = Convert.ToInt32(SR.Read());
                                //string s = Convert.ToString(SR.Read());
                                switch((char)next)
                                {
                                    case '1':
                                        //LearningSample[p][r].Add(true);
                                        Pic[r].Add(true);
                                        break;
                                    case '0':
                                        //LearningSample[p][r].Add(false);
                                        Pic[r].Add(false);
                                        break;
                                    default:
                                        throw new Exception();
                                }
                            }
                            SR.ReadLine();
                        }
                        LearningPicture LP = new LearningPicture(Pic, ans);
                        this.LearningSample.Add(LP);
                        
                        SR.ReadLine();
                    }

                    //обучение
                    bool IsLeant = false;
                    while (IsLeant == false)
                    {
                        IsLeant = true;
                        foreach (LearningPicture LP in this.LearningSample)
                        {
                            //не обяз true
                            if (Pers.Teach(LP.Picture, LP.Answer) == false)
                            {
                                IsLeant = false;
                            }
                        }
                    }
                    SR.Close();

                }
                catch { }
            }
            
        }

        private void Save_Learning_Sample_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "*.txt|*.txt";
            if (SFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    StreamWriter SW = new StreamWriter(SFD.FileName);
                    SW.WriteLine(this.LearningSample.Count);
                    SW.WriteLine(this.PG.RowCount);
                    SW.WriteLine(this.PG.ColumnCount);

                    for (int p = 0; p < this.LearningSample.Count; p++)
                    {
                        SW.WriteLine(Convert.ToInt32(this.LearningSample[p].Answer));
                        for (int r = 0; r < this.PG.RowCount; r++)
                        {
                            for (int c = 0; c < this.PG.ColumnCount; c++)
                            {
                                SW.Write(Convert.ToInt32(this.LearningSample[p].Picture[r][c]));
                            }
                            SW.WriteLine(";");
                        }
                    SW.WriteLine();
                    }
                    SW.Close();
                }
                catch { }
            }
        }

        private void Recognize_button_Click(object sender, EventArgs e)
        {
            if (this.Pers.CheckPicture(PG.Matrix))
            {
                Recognize_textBox.Text = "Правда";
            }
            else
            {
                Recognize_textBox.Text = "Ложь";
            }
        }

        private void Grid_pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void IsTrue_checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    class PaintingGrid
    {
        public List<List<bool>> Matrix = new List<List<bool>>();
        public int ColumnCount;
        public int RowCount;
        //Point Location;
        //Size Size;
        //Graphics G;
        //Pen

        public void DrawGrid(Graphics g, Point location, Size size, Pen p)
        {
            int StepY = size.Height / this.RowCount;
            int StepX = size.Width / this.ColumnCount;
            for (int i = location.Y; i <= size.Height; i += StepY)
            {
                g.DrawLine(p, new Point(location.X, i), new Point(location.X + size.Width, i));
            }
            for (int j = location.X; j <= size.Width; j += StepX)
            {
                g.DrawLine(p, new Point(j, location.Y), new Point(j, location.Y + size.Height));
            }

            for (int i = 0; i < this.RowCount; i++)
                for (int j = 0; j < this.ColumnCount; j++)
                {
                    if (Matrix[i][j] == true)
                    {
                        g.FillRectangle(Brushes.Black, new Rectangle(j * StepX, i * StepY, StepX, StepY));
                    }
                }
        }
        public PaintingGrid(int cols, int rows)
        {
            this.Matrix = new List<List<bool>>();
            this.ColumnCount = cols;
            this.RowCount = rows;

            for (int i = 0; i < RowCount; i++)
            {
                Matrix.Add(new List<bool>());
                for (int j = 0; j < ColumnCount; j++)
                {
                    Matrix[i].Add(false);
                }
            }
        }

        public void Clear()
        {
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    Matrix[i][j] = false;
                }
            }
        }
    }

    class Perceptron
    {
        int ColumnCount;
        int RowCount;
        List<List<double>> Weights;
        double LearningSpeed;
        double Threshold;

        public Perceptron (int cols, int rows, double ls,double th)
        {
            this.ColumnCount = cols;
            this.RowCount = rows;
            this.LearningSpeed = ls;
            this.Threshold = th;

            this.Weights = new List<List<double>>();
            for (int i = 0; i < RowCount; i++)
            {
                Weights.Add(new List<double>());
                for (int j = 0; j < ColumnCount; j++)
                {
                    Weights[i].Add(1);
                }
            }
            //Weights[0][0] = 1;
            this.NormalizeWeights();
        }

        double PictureSum(List<List<bool>> Pic)
        {
            double Sum = 0;
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    if (Pic[i][j])
                        Sum += Weights[i][j];
                }
            }
            return Sum;
        }
        void NormalizeWeights()
        {
            //находим мин
            //double min = 1;
            //foreach (List<double> row in this.Weights)
            //    foreach (double w in row)
            //    {
            //        if (w < min)
            //        {
            //            min = w;
            //        }
            //    }
            //вычитаем мин и суммируем
            double Sum = 0;
            foreach (List<double> row in this.Weights)
                foreach (double w in row)
                {
                    Sum += w;
                }

            for (int i = 0; i < this.RowCount; i++)
                for (int j = 0; j < this.ColumnCount; j++)
                {
                    this.Weights[i][j] = (this.Weights[i][j]) / Sum;
                    //this.Weights[i][j] = this.Weights[i][j] / (this.RowCount * this.ColumnCount);
                }
        }

        public bool CheckPicture(List<List<bool>> Pic)
        {
            double Sum = this.PictureSum(Pic);
            if (Sum >= this.Threshold)
                return true;
            else
                return false;
        }
        public bool Teach(List<List<bool>> Pic, bool result) //true если уже обучен
        {
            if (this.CheckPicture(Pic) == result)
                return true;
            while (this.CheckPicture(Pic) != result) //если ответ неверный
            {
                double err;
                double inc;

                if (this.CheckPicture(Pic) == false) //если должно быть false, то вычитаем
                {
                    err = 1 - this.PictureSum(Pic);
                    inc = err * this.LearningSpeed;
                }
                else
                {
                    err = this.PictureSum(Pic);
                    inc = err * this.LearningSpeed;
                    inc = inc * (-1);
                }
                for (int i = 0; i < Pic.Count; i++)
                {
                    for (int j = 0; j < Pic[i].Count; j++)
                    {
                        if (Pic[i][j] == true)
                        {
                            this.Weights[i][j] += inc;
                            if (Weights[i][j] < 0)
                                Weights[i][j] = 0;
                        }
                    }
                }
                this.NormalizeWeights();
            }
            return
                false;
            
        }
    }

    class LearningPicture
    {
        public List<List<bool>> Picture;
        public bool Answer;
        public LearningPicture(List<List<bool>> picture, bool answer)
        {
            this.Answer = answer;
            this.Picture = picture;
        }
    }
}
