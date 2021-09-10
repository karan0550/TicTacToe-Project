/** 
 * Project name: KSharmaAssignment1
 * 
 * Purpose: To build a game TicTacToe
 * 
 * Revision History: 
 *                  Created by Karan Sharma.
 * **/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool player = true;
        int[,] array = new int[3, 3];
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void myImage1_Click(object sender, EventArgs e)
        {
            count++;
            //Giving Indexes and values to the indexes for the picture boxes. The value will be 1 for player A and -1 for player B.
            if (player == true)
            {
                array[0, 0] = 1;
            }
            else
            {
                array[0, 0] = -1;
            }
            ChangeImage(myImage1, label1);
            if (count > 4)
            {
                CheckLogic();
            }
        }

        private void myImage2_Click(object sender, EventArgs e)
        {
            count++;
            if (player == true)
            {
                //Giving Indexes and values to the indexes for the picture boxes. The value will be 1 for player A and -1 for player B.
                array[0, 1] = 1;
            }
            else
            {
                array[0, 1] = -1;
            }
            ChangeImage(myImage2, label1);
            if (count > 4)
            {
                CheckLogic();
            }
        }

        private void myImage3_Click(object sender, EventArgs e)
        {
            count++;
            //Giving Indexes and values to the indexes for the picture boxes. The value will be 1 for player A and -1 for player B.
            if (player == true)
            {
                array[0, 2] = 1;
            }
            else
            {
                array[0, 2] = -1;
            }
            ChangeImage(myImage3, label1);
            if (count > 4)
            {
                CheckLogic();
            }
        }

        private void myImage4_Click(object sender, EventArgs e)
        {
            count++;
            //Giving Indexes and values to the indexes for the picture boxes. The value will be 1 for player A and -1 for player B.
            if (player == true)
            {
                array[1, 0] = 1;
            }
            else
            {
                array[1, 0] = -1;
            }
            ChangeImage(myImage4, label1);
            if (count > 4)
            {
                CheckLogic();
            }
        }

        private void myImage5_Click(object sender, EventArgs e)
        {
            count++;
            //Giving Indexes and values to the indexes for the picture boxes. The value will be 1 for player A and -1 for player B.
            if (player == true)
            {
                array[1, 1] = 1;
            }
            else
            {
                array[1, 1] = -1;
            }
            ChangeImage(myImage5, label1);
            if (count > 4)
            {
                CheckLogic();
            }
        }

        private void myImage6_Click(object sender, EventArgs e)
        {
            count++;
            //Giving Indexes and values to the indexes for the picture boxes. The value will be 1 for player A and -1 for player B.
            if (player == true)
            {
                array[1, 2] = 1;
            }
            else
            {
                array[1, 2] = -1;
            }
            ChangeImage(myImage6, label1);
            if(count > 4)
            {
                CheckLogic();
            }
        }

        private void myImage7_Click(object sender, EventArgs e)
        {
            count++;
            //Giving Indexes and values to the indexes for the picture boxes. The value will be 1 for player A and -1 for player B.
            if (player == true)
            {
                array[2, 0] = 1;
            }
            else
            {
                array[2, 0] = -1;
            }
            ChangeImage(myImage7, label1);
            if (count > 4)
            {
                CheckLogic();
            }
        }

        private void myImage8_Click(object sender, EventArgs e)
        {
            count++;
            //Giving Indexes and values to the indexes for the picture boxes. The value will be 1 for player A and -1 for player B.
            if (player == true)
            {
                array[2, 1] = 1;
            }
            else
            {
                array[2, 1] = -1;
            }
            ChangeImage(myImage8, label1);
            if (count > 4)
            {
                CheckLogic();
            }
        }

        private void myImage9_Click(object sender, EventArgs e)
        {
            count++;
            //Giving Indexes and values to the indexes for the picture boxes. The value will be 1 for player A and -1 for player B. 
            if (player == true)
            {
                array[2, 2] = 1;
            }
            else
            {
                array[2, 2] = -1;
            }
            ChangeImage(myImage9, label1);
            if(count > 4)
            {
                CheckLogic();
            }
        }

        /// <summary>
        /// This method changes the picture in the picturebox when clicked, also on the top left the label changes displaying the player's turns.
        /// </summary>
        /// <param name="pictureBox">Parameer used to add and change pictures on picturebox depending on player's turns</param>
        /// <param name="label">To change the label showing each player's turn.</param>
        public void ChangeImage(PictureBox pictureBox, Label label)
        {
            if (player == true)
            {
                pictureBox.Image = Image.FromFile(@"C:\Conestoga\Level 3\Game Prog Data Structures- Prog2370\Assignments\KSharmaAssignment1\Resources\cross.jpg");
                player = false;
                label.Text = "Player A";
            }
            else
            {
                pictureBox.Image = Image.FromFile(@"C:\Conestoga\Level 3\Game Prog Data Structures- Prog2370\Assignments\KSharmaAssignment1\Resources\O.jpg");
                player = true;
                label.Text = "Player B";
            }
            pictureBox.Enabled = false;
        }

        /// <summary>
        /// This method checks the sum of the rows, columns and diagonals to decide the winner. If the sum is 3 then player A wins and if sum is -3 then player B wins. 
        /// </summary>
        public void CheckLogic()
        {
            int[] row = new int[3];
            int[] col = new int[3];
            int diagonal1 = 0;
            int diagonal2 = 0;
            //nested loops to find the sum of rows, columns and both the diagonals.
            //loop to check rows
            for(int i = 0; i < 3; i++)
            {
                row[i] = 0;
                col[i] = 0;
                //loop to check columns
                for(int j = 0; j < 3; j++)
                {
                    row[i] += array[i, j];
                    col[i] += array[j, i];
                    if(i == j)
                    {
                        diagonal1 += array[i, j]; 
                    }
                    if(i + j == 2)
                    {
                        diagonal2 += array[i, j];
                    }
                }
            }
            //Statements to check the values of the sum, if 3 then player A wins and if -3 then player B.
            if(diagonal1 == 3 || diagonal2 == 3)
            {
                DialogResult result = MessageBox.Show("X won! Play again?", "Game Over", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    Form1 obj = new Form1();
                    obj.Show();
                    this.Hide();
                }
                if(result == DialogResult.No)
                {
                    this.Close();
                }
                return;
            }
            else if(diagonal1 == -3 || diagonal2 == -3)
            {
                DialogResult result = MessageBox.Show("O won! Play again?", "Game Over", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Form1 obj = new Form1();
                    obj.Show();
                    this.Hide();
                }
                if (result == DialogResult.No)
                {
                    this.Close();
                }
                return;
            }
            else
            {
                for(int i = 0; i < 3; i++)
                {
                    if(row[i] == 3 || col[i] == 3)
                    {
                        DialogResult result = MessageBox.Show("X won! Play again?", "Game Over", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            Form1 obj = new Form1();
                            obj.Show();
                            this.Hide();
                        }
                        if (result == DialogResult.No)
                        {
                            this.Close();
                        }
                        return;
                    }
                    else if(col[i] == -3 || row[i] == -3)
                    {
                        DialogResult result = MessageBox.Show("O won! Play again?", "Game Over", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            Form1 obj = new Form1();
                            obj.Show();
                            this.Hide();
                        }
                        if (result == DialogResult.No)
                        {
                            this.Close();
                        }
                        return;
                    }
                }
            }
            //statement to check if the game is draw
            if(count == 9)
            {
                DialogResult result = MessageBox.Show("The game is Draw! Play again?", "Game Over", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Form1 obj = new Form1();
                    obj.Show();
                    this.Hide();
                }
                if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
