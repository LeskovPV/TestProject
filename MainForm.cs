using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;

namespace TestProject
{
    public partial class МainForm : Form
    {

        private CalcEngine calcEngine = new CalcEngine();
      

        private string resultText;

        public МainForm()
        {
            InitializeComponent();
            resultText = resultTextBox.Text;
            setResultTextBox();
            setInputDataGridView(true);
        }

        private void setResultTextBox()
        {
            string text = resultText;
            foreach (char key in calcEngine.getKeys())
            {
                text = Regex.Replace(text, "P" + key, String.Format("{0,2:F3}", calcEngine.getP()[key] * 100));
                text = Regex.Replace(text, "Q" + key, String.Format("{0,2:F3}", calcEngine.getQ()[key] * 100));
            }
            resultTextBox.Text = text;
        }

        // Установка размеров для inputDataGridView, в случае (dataLoading = true) заполняется значениями из calcEngine
        private void setInputDataGridView(bool dataLoading = false)
        {
            if (dataLoading)
            {
                xNumericUpDown.Value = calcEngine.getNx() - 1;
                yNumericUpDown.Value = calcEngine.getNy() - 1;
            }
            inputDataGridView.RowCount = (int)yNumericUpDown.Value + 1;
            inputDataGridView.ColumnCount = (int)xNumericUpDown.Value + 1;
            for (int column = 0; column < inputDataGridView.ColumnCount; column++)
            {
                inputDataGridView.Columns[column].HeaderText = column.ToString();
                inputDataGridView.Columns[column].Width = 50;
                inputDataGridView.Columns[column].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int row = 0; row < inputDataGridView.RowCount; row++)
                inputDataGridView.Rows[row].HeaderCell.Value = row.ToString();
            if (dataLoading)
            {
                for (int column = 0; column < inputDataGridView.ColumnCount; column++)
                    for (int row = 0; row < inputDataGridView.RowCount; row++)
                        inputDataGridView.Rows[row].Cells[column].Value = 
                            String.Format("{0,2:F3}", calcEngine.getPxy(column, row) * 100);
            }
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // Считывам данные inputDataGrid
            double[,] _Pxy = new double[inputDataGridView.ColumnCount, inputDataGridView.RowCount];
            for (int column = 0; column < inputDataGridView.ColumnCount; column++)
                for (int row = 0; row < inputDataGridView.RowCount; row++)
                {
                    string cellstext = (string) inputDataGridView.Rows[row].Cells[column].Value;
                    if (cellstext == null)
                        cellstext = "";
                    double value = 0;
                    cellstext = Regex.Replace(cellstext, @"\.", ",");
                    if (!Double.TryParse(cellstext, out value))
                    {
                        cellstext = Regex.Replace(cellstext, ",", ".");
                        Double.TryParse(cellstext, out value);
                    }
                    _Pxy[column, row] = value;
                }
            // Парсим последовательность забитых голов
            List<int> _G = new List<int>();
            _G.Add(0);
            for (int i = 0; i < goalsTextBox.Text.Length; i++)
            {
                if (Char.ToUpper(goalsTextBox.Text[i]) == 'Х') _G.Add(1);
                if (Char.ToUpper(goalsTextBox.Text[i]) == 'X') _G.Add(1);
                if (Char.ToUpper(goalsTextBox.Text[i]) == 'Г') _G.Add(-1);
            }
            goalsTextBox.Text = "";
            for (int i = 1; i < _G.Count; i++)
                goalsTextBox.Text += (_G[i] > 0) ? 'Х' : 'Г';

            double _T = (double) timeNumericUpDown.Value;
            int _kb = (int) beginNumericUpDown.Value;
            int _ke = (int) endNumericUpDown.Value;
            int _N = (int) checkNumericUpDown.Value;
            if (calcEngine.calculate(_Pxy, _G.ToArray(), _T, _kb, _ke, _N))
            {
                setInputDataGridView(true);
                setResultTextBox();
                checkGroupBox.Enabled = true;
            }
        }

        private void gridNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            setInputDataGridView();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (calcEngine.verification((int)checkNumericUpDown.Value))
                setResultTextBox();
        }

        private void taskButton_Click(object sender, EventArgs e)
        {
            runFile("Task.pdf");
        }

        private void solutionButton_Click(object sender, EventArgs e)
        {
            runFile("Solution.pdf");
        }

        private void runFile(string path)
        {
            if (File.Exists(path))
                Process.Start(path);
            else
                MessageBox.Show("Файл '" + path + "' не найден");
        }

        private void sourceLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/LeskovPV/TestProject");
        }
    }
}
