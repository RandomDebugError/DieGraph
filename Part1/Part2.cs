using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part1
{
    public partial class Part2 : Form
    {
        /* Setting Global variables. */
        int numRoll2;
        int[] check = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        int[] count1 = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] count2 = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public Part2()
        {
            InitializeComponent();
        }



        /* Following method clears out default value from textbox in form when textbox is clicked. *
         * Thought process being that if user didn't want it changed, they wouldn't have clicked in box.  */
        private void clearRolls2(object sender, EventArgs e)
        {
            nRolls2.Clear();
        }



        /*Following method handles a standard roll that updates as it runs */
        private void standardRoll(int numRolls)
        {
            int numRoll = numRolls;

            /* For loop runs for every roll of the dice that user specified. */
            for (int i = 0; i < numRoll; i++)
            {
                int sum;
                int j = 0;

                /* Rolls two seperate dice, and sums them. Uses one random object to generate two numbers. */
                aDie d1 = new aDie();
                aDie d2 = new aDie();
                sum = d1+d2;

                /* While loop runs till it matches sum to its spot in check array.                 *
                 * J keeps array position so that  the count can be increased in the count1 array. *
                 * An offset of 1 has been added for proper histogram functionality.               */
                while (sum != check[j])
                {
                    j++;
                }

                int tmp = count2[j + 1];
                count2[j + 1] = tmp + 1;

                /* Binds chart values to values of throw count array. */
                chart2.Series[0].Points.DataBindY(count2);
                chart2.Refresh();
            }

            for (int i = 0; i < 6; i++)
            {
                count2[i] = 0;
            }
        }


        /*Following method handles a roll interval option that updates as it after a user defined amount of rolls. */
        private void rollUpdate(int numRolls, int rollInts)
        {
            int numRoll = numRolls,
            sum,
            k = 0;

            /* For loop runs for user specified amount of rolls. */
            for (int i = 0; i < numRoll; i++)
            {
                int j = 0;

                /* Rolls two seperate dice, and sums them. Uses one random object to generate two numbers. */
                aDie d1 = new aDie();
                aDie d2 = new aDie();
                sum = d1+d2;

                /* While loop runs till it matches number rolled to its spot in check array.       *
                 * J keeps array position so that  the count can be increased in the count1 array. *
                 * An offset of 1 has been added for proper histogram functionality.               */
                while (sum != check[j])
                {
                    j++;
                }

                int tmp = count2[j + 1];
                count2[j + 1] = tmp + 1;

                /* Binds chart values to values of throw count array.  One line sufficient due to y-axis only data that matters afterhistogram shift. *                                                                             *
             * https://docs.textcontrol.com/textcontrol/windows-forms/article.winforms.charts.htm                                                 *
             * https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datavisualization.charting.chart.databind?view=netframework-4.8   */
                chart2.Series[0].Points.DataBindY(count2);

                if (k < rollInts)
                {
                    k++;
                    continue;
                }
                else
                {
                    chart2.Refresh();
                    k = 0;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                count2[i] = 0;
            }
        }


        private void timeUpdate()
        {
            int sum;


            /* For loop runs for 1000 rolls. */
            for (int i = 0; i < 1000; i++)
            {
                int j = 0;

                /* Rolls two seperate dice, and sums them. Uses one random object to generate two numbers. */
                aDie d1 = new aDie();
                aDie d2 = new aDie();
                sum = d1 + d2;

                /* While loop runs till it matches number rolled to its spot in check array.       *
                 * J keeps array position so that  the count can be increased in the count1 array. *
                 * An offset of 1 has been added for proper histogram functionality.               */
                while (sum != check[j])
                {
                    j++;
                }

                int tmp = count2[j + 1];
                count2[j + 1] = tmp + 1;


                /* Binds chart values to values of throw count array.  One line sufficient due to y-axis only data that matters afterhistogram shift. *                                                                             *
             * https://docs.textcontrol.com/textcontrol/windows-forms/article.winforms.charts.htm                                                 *
             * https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datavisualization.charting.chart.databind?view=netframework-4.8   */
                //timer1.Enabled = false;

            }
            for (int k = 0; k < 6; k++)
            {
                count1[k] = count1[k] + (count2[k]);
            }
            chart2.Series[0].Points.DataBindY(count2);
        }



        /* Following method processes Throw button action. */
        private void button1_Click(object sender, EventArgs e)
        {
            int rollInt;

            /* implicitly converts textbox values to ints for use in comparision functions.   */
            numRoll2 = int.Parse(nRolls2.Text);
            rollInt = int.Parse(rollsInterval.Text);

            double timeDoub = double.Parse(timeInterval.Text);
            int time = Convert.ToInt32(timeDoub * 1000);


            /* Handles user check box execution choice. */

            if (stdCkBox.Checked == true)
            {
                standardRoll(numRoll2);
            }
            else if (rollCkBox.Checked == true)
            {
                rollUpdate(numRoll2, rollInt);
            }
            else if (timeCkBox.Checked == true)
            {
                timer1.Interval = time;
                timer1.Enabled = true;
                timer1.Tick += new EventHandler(timer1_Tick);
            }
        }


        /* Following method processes processes what happenes each time a timer tick event happens. */
        private void timer1_Tick(object sender, EventArgs e)
        {
            /* Removes the amount of rolls that will be used in the timeUpdate method. should be 1000, but 500 seems to be what works. */
            numRoll2 = numRoll2 - 500;

            if (numRoll2 <= 0)
            {
                numRoll2 = numRoll2 + 1000;
                timeUpdate();
                timer1.Stop();

                for (int i = 0; i < 6; i++)
                {
                    count2[i] = 0;
                }
            } else
            {
                timeUpdate();
            }
        }
    }
}
