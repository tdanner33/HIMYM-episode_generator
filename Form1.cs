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

namespace HIMYM_EpisodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // exit button method to close the application
        private void exitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goBttn_Click(object sender, EventArgs e)
        {

            if (seasonRadioBttn.Checked == true)
            {
                string[] seasons = {"Season One", "Season Two", "Season Three", "Season Four", "Season Five",
                                                "Season Six", "Season Seven", "Season Eight", "Season Nine"};
                int seasonNumber = SeasonGenerator(); userSelectListBox.Visible = true; okayBttnOne.Visible = true;
                directionLblTwo.Visible = true;
                rightLbl.Visible = true;  rightLbl.Text = seasons[seasonNumber];
            }
            else if (episodeRadioBttn.Checked == true)
            {
                string[] seasons = {"Season One", "Season Two", "Season Three", "Season Four", "Season Five",
                                                "Season Six", "Season Seven", "Season Eight", "Season Nine"};
                foreach (string value in seasons)
                {
                    userSelectListBox.Items.Add(value);
                }
                userSelectListBox.Visible = true; okayBttnTwo.Visible = true;
                directionLblTwo.Visible = true;
            }
            else if (allRadioBttn.Checked == true)
            {
                string[] seasons = {"Season One", "Season Two", "Season Three", "Season Four", "Season Five",
                                                "Season Six", "Season Seven", "Season Eight", "Season Nine"};
                int sznNum = SeasonGenerator(); string episode = RandomizeEpisode(sznNum);
                // create instance of the resultForm class to display the results
                resultForm display = new resultForm(); display.seasonLbl.Text = seasons[sznNum];
                display.episodeLbl.Text = episode; display.ShowDialog();
            }
        }

        // seasonGenerator method to determine which season the user will get at random
        // as well as displaying a list of episodes the user can select from that season
        private int SeasonGenerator()
        {
            int index = 0;
            int number; Random rand = new Random(); number = rand.Next(9);
            // block of if statements to determine which season gets called
            // and writes the episode arrays to userSelectListBox
            if (number == 0)
            {
               string[] seasonOne = new string[22];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonOne.txt");
                while (index < seasonOne.Length && !inputFile.EndOfStream)
                {
                    seasonOne[index] = inputFile.ReadLine();
                    index++;
                }

                inputFile.Close();
                foreach (string value in seasonOne)
                {
                    userSelectListBox.Items.Add(value);
                }
            }
            else if (number == 1)
            {
                string[] seasonTwo = new string[22];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonTwo.txt");
                while (index < seasonTwo.Length && !inputFile.EndOfStream)
                {
                    seasonTwo[index] = inputFile.ReadLine();
                    index++;
                }

                inputFile.Close();
                foreach (string value in seasonTwo)
                {
                    userSelectListBox.Items.Add(value);
                }
            }
            else if (number == 2)
            {
                string[] seasonThree = new string[20];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonThree.txt");
                while (index < seasonThree.Length && !inputFile.EndOfStream)
                {
                    seasonThree[index] = inputFile.ReadLine();
                    index++;
                }

                inputFile.Close();
                foreach (string value in seasonThree)
                {
                    userSelectListBox.Items.Add(value);
                }
            }
            else if (number == 3)
            {
                string[] seasonFour = new string[24];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonFour.txt");
                while (index < seasonFour.Length && !inputFile.EndOfStream)
                {
                    seasonFour[index] = inputFile.ReadLine();
                    index++;
                }

                inputFile.Close();
                foreach (string value in seasonFour)
                {
                    userSelectListBox.Items.Add(value);
                }
            }
            else if (number == 4)
            {
                string[] seasonFive = new string[24];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonFive.txt");
                while (index < seasonFive.Length && !inputFile.EndOfStream)
                {
                    seasonFive[index] = inputFile.ReadLine();
                    index++;
                }

                inputFile.Close();
                foreach (string value in seasonFive)
                {
                    userSelectListBox.Items.Add(value);
                }
            }
            else if (number == 5)
            {
                string[] seasonSix = new string[24];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonSix.txt");
                while (index < seasonSix.Length && !inputFile.EndOfStream)
                {
                    seasonSix[index] = inputFile.ReadLine();
                    index++;
                }

                inputFile.Close();
                foreach (string value in seasonSix)
                {
                    userSelectListBox.Items.Add(value);
                }
            }
            else if (number == 6)
            {
                string[] seasonSeven = new string[24];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonSeven.txt");
                while (index < seasonSeven.Length && !inputFile.EndOfStream)
                {
                    seasonSeven[index] = inputFile.ReadLine();
                    index++;
                }

                inputFile.Close();
                foreach (string value in seasonSeven)
                {
                    userSelectListBox.Items.Add(value);
                }
            }
            else if (number == 7)
            {
                string[] seasonEight = new string[24];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonEight.txt");
                while (index < seasonEight.Length && !inputFile.EndOfStream)
                {
                    seasonEight[index] = inputFile.ReadLine();
                    index++;
                }

                inputFile.Close();
                foreach (string value in seasonEight)
                {
                    userSelectListBox.Items.Add(value);
                }
            }
            else if (number == 8)
            {
                string[] seasonNine = new string[24];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonNine.txt");
                while (index < seasonNine.Length && !inputFile.EndOfStream)
                {
                    seasonNine[index] = inputFile.ReadLine();
                    index++;
                }

                inputFile.Close();
                foreach (string value in seasonNine)
                {
                    userSelectListBox.Items.Add(value);
                }
            }
            return number;
        } // end of seasonGenerator method

        // EpisodeGenerator method makes descion based on what the user selects
        // randomizes an episode within the season the user selected and returns a string
        private string EpisodeGenerator()
        {
            // int numOne, numTwo, numThree will hold a different random number values 
            // to be called depending on length of season
            int index = 0; int numOne, numTwo, numThree; string epResult; 
            Random rand = new Random(); numOne = rand.Next(22);
            numTwo = rand.Next(20); numThree = rand.Next(24);
            string select = userSelectListBox.SelectedItem.ToString();

            // block of if statements that writes the contents of a file to an array
            // and then uses the random number generated at the top to get a value
            if (select == "Season One")
            {
                string[] seasonOne = new string[22];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonOne.txt");
                while (index < seasonOne.Length && !inputFile.EndOfStream)
                {
                    seasonOne[index] = inputFile.ReadLine();
                    index++;
                }
                inputFile.Close(); epResult = seasonOne[numOne];
                return epResult;
            }
            else if (select == "Season Two")
            {
                string[] seasonTwo = new string[22];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonTwo.txt");
                while (index < seasonTwo.Length && !inputFile.EndOfStream)
                {
                    seasonTwo[index] = inputFile.ReadLine();
                    index++;
                }
                inputFile.Close(); epResult = seasonTwo[numOne];
                return epResult;
            }
            else if (select == "Season Three")
            {
                string[] seasonThree = new string[20];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonThree.txt");
                while (index < seasonThree.Length && !inputFile.EndOfStream)
                {
                    seasonThree[index] = inputFile.ReadLine();
                    index++;
                }
                inputFile.Close(); epResult = seasonThree[numTwo];
                return epResult;
            }
            else if (select == "Season Four")
            {
                string[] seasonFour = new string[24];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonFour.txt");
                while (index < seasonFour.Length && !inputFile.EndOfStream)
                {
                    seasonFour[index] = inputFile.ReadLine();
                    index++;
                }
                inputFile.Close(); epResult = seasonFour[numThree];
                return epResult;
            }
            else if (select == "Season Five")
            {
                string[] seasonFive = new string[24];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonFive.txt");
                while (index < seasonFive.Length && !inputFile.EndOfStream)
                {
                    seasonFive[index] = inputFile.ReadLine();
                    index++;
                }
                inputFile.Close(); epResult = seasonFive[numThree];
                return epResult;
            }
            else if (select == "Season Six")
            {
                string[] seasonSix = new string[24];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonSix.txt");
                while (index < seasonSix.Length && !inputFile.EndOfStream)
                {
                    seasonSix[index] = inputFile.ReadLine();
                    index++;
                }
                inputFile.Close(); epResult = seasonSix[numThree];
                return epResult;
            }
            else if (select == "Season Seven")
            {
                string[] seasonSeven = new string[24];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonSeven.txt");
                while (index < seasonSeven.Length && !inputFile.EndOfStream)
                {
                    seasonSeven[index] = inputFile.ReadLine();
                    index++;
                }
                inputFile.Close(); epResult = seasonSeven[numThree];
                return epResult;
            }
            else if (select == "Season Eight")
            {
                string[] seasonEight = new string[24];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonEight.txt");
                while (index < seasonEight.Length && !inputFile.EndOfStream)
                {
                    seasonEight[index] = inputFile.ReadLine();
                    index++;
                }
                inputFile.Close(); epResult = seasonEight[numThree];
                return epResult;
            }
            else if (select == "Season Nine")
            {
                string[] seasonNine = new string[24];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonNine.txt");
                while (index < seasonNine.Length && !inputFile.EndOfStream)
                {
                    seasonNine[index] = inputFile.ReadLine();
                    index++;
                }
                inputFile.Close(); epResult = seasonNine[numThree];
                return epResult;
            }
            string error = "failure"; return error;
        } // end of episodeGenerator method

        // RandomizeEpisode method is similar to EpisodeGenerator method but
        // uses a parameter to determine which season will be used instead of a selection
        private string RandomizeEpisode(int number)
        {
            // int numOne, numTwo, numThree will hold a different random number values 
            // to be called depending on length of season
            int index = 0; int numOne, numTwo, numThree; string epResult;
            Random rand = new Random(); numOne = rand.Next(22);
            numTwo = rand.Next(20); numThree = rand.Next(24);

            // block of if statements that writes the contents of a file to an array
            // and then uses the passed variable to chose which season will be randomized
            if (number == 0)
            {
                string[] seasonOne = new string[22];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonOne.txt");
                while (index < seasonOne.Length && !inputFile.EndOfStream)
                {
                    seasonOne[index] = inputFile.ReadLine();
                    index++;
                }
                inputFile.Close(); epResult = seasonOne[numOne];
                return epResult;
            }
            else if (number == 1)
            {
                string[] seasonTwo = new string[22];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonTwo.txt");
                while (index < seasonTwo.Length && !inputFile.EndOfStream)
                {
                    seasonTwo[index] = inputFile.ReadLine();
                    index++;
                }
                inputFile.Close(); epResult = seasonTwo[numOne];
                return epResult;
            }
            else if (number == 2)
            {
                string[] seasonThree = new string[20];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonThree.txt");
                while (index < seasonThree.Length && !inputFile.EndOfStream)
                {
                    seasonThree[index] = inputFile.ReadLine();
                    index++;
                }
                inputFile.Close(); epResult = seasonThree[numTwo];
                return epResult;
            }
            else if (number == 3)
            {
                string[] seasonFour = new string[24];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonFour.txt");
                while (index < seasonFour.Length && !inputFile.EndOfStream)
                {
                    seasonFour[index] = inputFile.ReadLine();
                    index++;
                }
                inputFile.Close(); epResult = seasonFour[numThree];
                return epResult;
            }
            else if (number == 4)
            {
                string[] seasonFive = new string[24];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonFive.txt");
                while (index < seasonFive.Length && !inputFile.EndOfStream)
                {
                    seasonFive[index] = inputFile.ReadLine();
                    index++;
                }
                inputFile.Close(); epResult = seasonFive[numThree];
                return epResult;
            }
            else if (number == 5)
            {
                string[] seasonSix = new string[24];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonSix.txt");
                while (index < seasonSix.Length && !inputFile.EndOfStream)
                {
                    seasonSix[index] = inputFile.ReadLine();
                    index++;
                }
                inputFile.Close(); epResult = seasonSix[numThree];
                return epResult;
            }
            else if (number == 6)
            {
                string[] seasonSeven = new string[24];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonSeven.txt");
                while (index < seasonSeven.Length && !inputFile.EndOfStream)
                {
                    seasonSeven[index] = inputFile.ReadLine();
                    index++;
                }
                inputFile.Close(); epResult = seasonSeven[numThree];
                return epResult;
            }
            else if (number == 7)
            {
                string[] seasonEight = new string[24];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonEight.txt");
                while (index < seasonEight.Length && !inputFile.EndOfStream)
                {
                    seasonEight[index] = inputFile.ReadLine();
                    index++;
                }
                inputFile.Close(); epResult = seasonEight[numThree];
                return epResult;
            }
            else if (number == 8)
            {
                string[] seasonNine = new string[24];
                System.IO.StreamReader inputFile; inputFile = File.OpenText("seasonNine.txt");
                while (index < seasonNine.Length && !inputFile.EndOfStream)
                {
                    seasonNine[index] = inputFile.ReadLine();
                    index++;
                }
                inputFile.Close(); epResult = seasonNine[numThree];
                return epResult;
            }
            string error = "failure"; return error;
        } // end of RandomizeEpisode method

        // okayBttn click event to choose a selected episode
    private void okayBttn_Click(object sender, EventArgs e)
        {
            string selection; selection = userSelectListBox.SelectedItem.ToString();
            string seasonResult = rightLbl.Text;

             resultForm epSelect = new resultForm(); epSelect.episodeLbl.Text = selection;
             epSelect.seasonLbl.Text = seasonResult;
             epSelect.ShowDialog();
        }

        // okayBttnTwo click event to chose a selected season
        private void okayBttnTwo_Click(object sender, EventArgs e)
        {
            string epResult = EpisodeGenerator(); string selection = userSelectListBox.SelectedItem.ToString();

            resultForm sznResult = new resultForm(); sznResult.seasonLbl.Text = selection;
            sznResult.episodeLbl.Text = epResult;
            sznResult.ShowDialog();
        }

        // clearBttn_Click method is an event to clear all input done by the user
        private void clearBttn_Click(object sender, EventArgs e)
        {
            seasonRadioBttn.Checked = false; episodeRadioBttn.Checked = false; allRadioBttn.Checked = false;
            userSelectListBox.Items.Clear(); userSelectListBox.Visible = false; rightLbl.Text = "";
            rightLbl.Visible = false;  okayBttnOne.Visible = false; okayBttnTwo.Visible = false;
            directionLblOne.Visible = true; directionLblTwo.Visible = false;
        }
    }
}
