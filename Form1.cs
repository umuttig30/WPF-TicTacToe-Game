using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfTicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] gameBoard = new string[9];
        int currentturn = 0;

        public String returnSymbol (int turn)
        {
            if (turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }

        public System.Drawing.Color PrintColor(String symbol)
        {
            if(symbol.Equals ("O"))
            {
                return System.Drawing.Color.Chartreuse;
            }
            else if(symbol.Equals ("X"))
            {
                return System.Drawing.Color.Turquoise;
            }
            return System.Drawing.Color.White;
        }

        public void CheckForWinner()
        {
            for(int i = 0; i < 8; i++)
            {
                String combination = "";
                int One = 0, Two = 0, Three = 0;
                switch (i)
                {
                    case 0:
                        
                        One = 0;
                        Two = 4;
                        Three = 8;

                       
                        break;
                    case 1:
               
                        One = 2;
                        Two = 4;
                        Three = 6;
                        break;
                    case 2:
                   
                        One = 0;
                        Two = 1;
                        Three = 2;
                        break;
                    case 3:
   
                        One = 3;
                        Two = 4;
                        Three = 5;
                        break;
                    case 4:
                        
                        One = 6;
                        Two = 7;
                        Three = 8;
                        break;
                    case 5:
                        
                        One = 0;
                        Two = 3;
                        Three = 6;
                        break;
                    case 6:
                        
                        One = 2;
                        Two = 4;
                        Three = 7;
                        break;
                    case 7:
                        
                        One = 3;
                        Two = 5;
                        Three = 8;
                        break;
                    
                }

                combination = gameBoard[One] + gameBoard[Two] + gameBoard[Three];


                if (combination.Equals("XXX") || combination == "OOO")
                {
                    changeColor(One);
                    changeColor(Two);
                    changeColor(Three);
                    MessageBox.Show(combination.Substring(0, 1) + " has won the game!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
                   if (combination.Equals("XXX"))
                {
                    changeColor(One);
                    changeColor(Two);
                    changeColor(Three);                   
                    MessageBox.Show("X has won the game!","We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(combination.Equals("OOO"))
                {
                    changeColor(One);
                    changeColor(Two);
                    changeColor(Three);
                    MessageBox.Show("O has won the game!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                checkDraw();
            }

        }

        public void reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.BackColor = System.Drawing.Color.White;
            button2.BackColor = System.Drawing.Color.White;
            button3.BackColor = System.Drawing.Color.White;
            button4.BackColor = System.Drawing.Color.White;
            button5.BackColor = System.Drawing.Color.White;
            button6.BackColor = System.Drawing.Color.White;
            button7.BackColor = System.Drawing.Color.White;
            button8.BackColor = System.Drawing.Color.White;
            button9.BackColor = System.Drawing.Color.White;
            gameBoard = new string[9];
            currentturn = 0;
        }


        public void changeColor(int luku)
        {
            switch(luku)
            {
                case 0:
                    button1.BackColor=System.Drawing.Color.Red; break;
                case 1:
                    button2.BackColor = System.Drawing.Color.Red; break;
                case 2:
                    button3.BackColor = System.Drawing.Color.Red; break;
                case 3:
                    button4.BackColor = System.Drawing.Color.Red; break;
                case 4:
                    button5.BackColor = System.Drawing.Color.Red; break;
                case 5:
                    button6.BackColor = System.Drawing.Color.Red; break;
                case 6:
                    button7.BackColor = System.Drawing.Color.Red; break;
                case 7:
                    button8.BackColor = System.Drawing.Color.Red; break;
                case 8:
                    button9.BackColor = System.Drawing.Color.Red; break;



            }
        }


        public void checkDraw()
        {
            int counter = 0;
            for(int i = 0; i < gameBoard.Length; i++)
            {
                if(gameBoard[i] != null)
                {
                    counter++;
                }

                if(counter == 9)
                {
                    
                    MessageBox.Show("Draw!", "No winner today :(", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[0] = returnSymbol(currentturn);
            Color ButtonColor = PrintColor(gameBoard[0]);
            button1.BackColor = ButtonColor;
            button1.Text = gameBoard[0];
            CheckForWinner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[1] = returnSymbol(currentturn);
            Color ButtonColor = PrintColor(gameBoard[1]);
            button2.BackColor = ButtonColor;
            button2.Text = gameBoard[1];
            CheckForWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[2] = returnSymbol(currentturn);
            Color ButtonColor = PrintColor(gameBoard[2]);
            button3.BackColor = ButtonColor;
            button3.Text = gameBoard[2];
            CheckForWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[3] = returnSymbol(currentturn);
            Color ButtonColor = PrintColor(gameBoard[3]);
            button4.BackColor = ButtonColor;
            button4.Text = gameBoard[3];
            CheckForWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[4] = returnSymbol(currentturn);
            Color ButtonColor = PrintColor(gameBoard[4]);
            button5.BackColor = ButtonColor;
            button5.Text = gameBoard[4];
            CheckForWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[5] = returnSymbol(currentturn);
            Color ButtonColor = PrintColor(gameBoard[5]);
            button6.BackColor = ButtonColor;
            button6.Text = gameBoard[5];
            CheckForWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[6] = returnSymbol(currentturn);
            Color ButtonColor = PrintColor(gameBoard[6]);
            button7.BackColor = ButtonColor;
            button7.Text = gameBoard[6];
            CheckForWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[7] = returnSymbol(currentturn);
            Color ButtonColor = PrintColor(gameBoard[7]);
            button8.BackColor = ButtonColor;
            button8.Text = gameBoard[7];
            CheckForWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[8] = returnSymbol(currentturn);
            Color ButtonColor = PrintColor(gameBoard[8]);
            button9.BackColor = ButtonColor;
            button9.Text = gameBoard[8];
            CheckForWinner();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
