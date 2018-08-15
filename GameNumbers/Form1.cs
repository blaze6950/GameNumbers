using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace GameNumbers
{
    internal delegate void GenerateButtons();

    public partial class NumbersForm : Form
    {
        private List<List<Button>> _buttons;
        private int _currentNumber;
        private GenerateButtons _generateButtons;
        private List<int> _numbersList;

        public NumbersForm()
        {
            InitializeComponent();
            threeXThree_CheckedChanged(threeXThree, EventArgs.Empty);
        }

        private void CreateGameField()
        {
            _generateButtons.Invoke();
        }

        private void GenerateThreeXThree()
        {
            CreateButtons(3, 86);
            RandomNumbersForButtons();
        }

        private void GenerateFourXFour()
        {
            CreateButtons(4, 64);
            RandomNumbersForButtons();
        }

        private void GenerateFiveXFive()
        {
            CreateButtons(5, 51);
            RandomNumbersForButtons();
        }

        private void CreateButtons(int square, int size)
        {
            _buttons = new List<List<Button>>();
            for (var i = 0; i < square; i++)
            {
                var rowButtons = new List<Button>();
                for (var j = 0; j < square; j++)
                {
                    rowButtons.Add(new Button());
                    rowButtons[j].Parent = panel;
                    rowButtons[j].Bounds = new Rectangle(square + j * size, square + i * size, size, size);
                    rowButtons[j].Click += ButtonsClick;
                }
                _buttons.Add(rowButtons);
            }
        }

        private void RandomNumbersForButtons()
        {
            _currentNumber = (int) maximumUpDown.Value;
            _numbersList = new List<int>();
            var rng = new Random();
            foreach (var column in _buttons)
            foreach (var button in column)
            {
                int newNumber;
                bool isUniq;
                do
                {
                    newNumber = rng.Next(int.Parse(minimumUpDown.Value.ToString(CultureInfo.InvariantCulture)),
                        int.Parse(maximumUpDown.Value.ToString(CultureInfo.InvariantCulture)));
                    isUniq = true;
                    foreach (var number in _numbersList)
                        if (number == newNumber)
                            isUniq = false;
                } while (!isUniq);
                if (newNumber < _currentNumber) _currentNumber = newNumber;
                _numbersList.Add(newNumber);
                button.Text = newNumber.ToString();
            }
            _numbersList.Sort((x, y) => x.CompareTo(y));
        }

        private void threeXThree_CheckedChanged(object sender, EventArgs e)
        {
            if (threeXThree.Checked)
                _generateButtons = GenerateThreeXThree;
            maximumUpDown.Minimum = 9;
            maximumUpDown.Maximum = minimumUpDown.Maximum + maximumUpDown.Minimum;
            minimumUpDown_ValueChanged(minimumUpDown, EventArgs.Empty);
        }

        private void fourXFour_CheckedChanged(object sender, EventArgs e)
        {
            if (fourXFour.Checked)
                _generateButtons = GenerateFourXFour;
            maximumUpDown.Minimum = 16;
            maximumUpDown.Maximum = minimumUpDown.Maximum + maximumUpDown.Minimum;
            minimumUpDown_ValueChanged(minimumUpDown, EventArgs.Empty);
        }

        private void FiveXFive_CheckedChanged(object sender, EventArgs e)
        {
            if (FiveXFive.Checked)
                _generateButtons = GenerateFiveXFive;
            maximumUpDown.Minimum = 25;
            maximumUpDown.Maximum = minimumUpDown.Maximum + maximumUpDown.Minimum;
            minimumUpDown_ValueChanged(minimumUpDown, EventArgs.Empty);
        }

        private void minimumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (maximumUpDown.Value - minimumUpDown.Value < maximumUpDown.Minimum - minimumUpDown.Minimum)
                maximumUpDown.Value = minimumUpDown.Value + (maximumUpDown.Minimum - minimumUpDown.Minimum);
        }

        private void maximumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (maximumUpDown.Value - minimumUpDown.Value < maximumUpDown.Minimum - minimumUpDown.Minimum)
                minimumUpDown.Value = maximumUpDown.Value - (maximumUpDown.Minimum - minimumUpDown.Minimum);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < _buttons.Count; i++)
            for (var j = 0; j < _buttons[i].Count; j++)
                _buttons[i][j].Dispose();
            progressBar.Value = 0;
            Text = @"Числа";
        }

        private void timeTrackBar_Scroll(object sender, EventArgs e)
        {
            Text = timeTrackBar.Value.ToString();
            //toolTip.ToolTipTitle = String.Format("Время : {0}", timeTrackBar.Value);
            toolTip.Show(string.Format("Время : {0}", timeTrackBar.Value), timeTrackBar);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            CreateGameField();
            progressBar.Minimum = 0;
            progressBar.Maximum = timeTrackBar.Value;
            progressBar.Step = 1;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < progressBar.Maximum)
            {
                progressBar.PerformStep();
                Text = (timeTrackBar.Value - progressBar.Value).ToString();
            }
            else
            {
                stopButton_Click(stopButton, EventArgs.Empty);
                timer.Stop();
            }
        }

        private void ButtonsClick(object sender, EventArgs e)
        {
            if (int.Parse((sender as Button)?.Text ?? throw new InvalidOperationException()) == _numbersList[_currentNumber])
            {
                if (_currentNumber + 1 == _numbersList.Count)
                {
                    timer.Stop();
                    MessageBox.Show(
                        string.Format("Вы выиграли! Оставшееся время : {0}", timeTrackBar.Value - progressBar.Value),
                        @"Congratz!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    stopButton_Click(stopButton, EventArgs.Empty);
                }
                _currentNumber++;
            }
            else
            {
                MessageBox.Show(@"Не туда!", @"Упс", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}