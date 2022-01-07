using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Part1
{
    public partial class btnRoll : Form
    {
        /* Setting Global variables. */
        int numRoll;
        int[] check = new int[] { 1, 2, 3, 4, 5, 6 };
        int[] count1 = new int[] { 0, 0, 0, 0, 0, 0 };
        int[] count2 = new int[] { 0, 0, 0, 0, 0, 0 };

        public btnRoll()
        {
            InitializeComponent();
        }
      
        
        /* Following method clears out default value from textbox in form when textbox is clicked. *
         * Thought process being that if user didn't want it changed, they wouldn't have clicked in box.  *
         * https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.textbox.clear?view=net-5.0 */
        private void clearRolls(object sender, EventArgs e)
        {
            nRolls.Clear();
        }

        
        /*Following method handles a standard roll that updates as it runs */
        private void standardRoll(int numRolls)
        {
            int numRoll = numRolls;

            /* For loop runs for user specified amount of rolls. */
            for (int i = 0; i < numRoll; i++)
            {
                int j = 0;

                /* creates new random seed die number to insure that the die isn't the same number continously. */
                aDie d = new aDie();

                /* While loop runs till it matches number rolled to its spot in check array.       *
                 * J keeps array position so that  the count can be increased in the count1 array. *
                 * An offset of 1 has been added for proper histogram functionality.               */
                while (d != check[j])
                {
                    j++;
                }

                int tmp = count1[j];
                count1[j] = tmp + 1;

                /* Binds chart values to values of throw count array.  One line sufficient due to y-axis only data that matters afterhistogram shift. *
                 * then refreshes chart after each throw.                                                                                          *
             * https://docs.textcontrol.com/textcontrol/windows-forms/article.winforms.charts.htm                                                 *
             * https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datavisualization.charting.chart.databind?view=netframework-4.8   */
                chart1.Series[0].Points.DataBindY(count1);
                chart1.Refresh();
            }

            for (int i = 0; i < 6; i++)
            {
                count1[i] = 0;
            }
        }


        /*Following method handles a roll interval option that updates as it after a user defined amount of rolls. */
        private void rollUpdate(int numRolls, int rollInts)
        {
            int  numRoll = numRolls,
            k = 0;

            /* For loop runs for user specified amount of rolls. */
            for (int i = 0; i < numRoll; i++)
            {
                int j = 0;

                /* Creates a new die with a random seed. */
                aDie d = new aDie();


                /* While loop runs till it matches number rolled to its spot in check array.       *
                 * J keeps array position so that  the count can be increased in the count1 array. *
                 * An offset of 1 has been added for proper histogram functionality.               */
                while (d != check[j])
                {
                    j++;
                }

                int tmp = count1[j];
                count1[j] = tmp + 1;

                /* Binds chart values to values of throw count array.  One line sufficient due to y-axis only data that matters afterhistogram shift. *                                                                             *
             * https://docs.textcontrol.com/textcontrol/windows-forms/article.winforms.charts.htm                                                 *
             * https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datavisualization.charting.chart.databind?view=netframework-4.8   */
                chart1.Series[0].Points.DataBindY(count1);

                if (k < rollInts)
                {
                    k++;
                    continue;
                } else
                {
                    chart1.Refresh();
                    k = 0;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                count1[i] = 0;
            }
        }

        private void timeUpdate( )
        {
            /* For loop runs for 1000 rolls. */
            for (int i = 0; i < 1000; i++)
            {
                int j = 0;

                /* Creates a new die with a random seed. */
                aDie d = new aDie();

                
                /* While loop runs till it matches number rolled to its spot in check array.       *
                 * J keeps array position so that  the count can be increased in the count1 array. *
                 * An offset of 1 has been added for proper histogram functionality.               */
                while (d != check[j])
                {
                    j++;
                }

                int tmp = count1[j];
                count1[j] = tmp + 1;

              /* Binds chart values to values of throw count array.  One line sufficient due to y-axis only data that matters afterhistogram shift. *                                                                             *
             * https://docs.textcontrol.com/textcontrol/windows-forms/article.winforms.charts.htm                                                 *
             * https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datavisualization.charting.chart.databind?view=netframework-4.8   */
                
                
            }
            for (int k = 0; k < 6; k++)
            {
                count2[k] = count2[k] + (count1[k] / 2);
            }
            chart1.Series[0].Points.DataBindY(count2);


        }

        /* Following method processes Throw button action. */
        private void button1_Click(object sender, EventArgs e)
        {
            int rollInt;

            numRoll = int.Parse(nRolls.Text);
            rollInt = int.Parse(rollsInterval.Text);

            double timeDoub = double.Parse(timeInterval.Text);
            int time = Convert.ToInt32(timeDoub * 1000);



            /* Handles user check box execution choice. */
            if (stdCkBox.Checked == true)
            {
                standardRoll(numRoll);
            } else if(RollCkBox.Checked == true)
              {
                rollUpdate(numRoll, rollInt);
              }else if(TimeCkBox.Checked == true)
               {
                timer1.Interval = time;
                timer1.Enabled = true;
                timer1.Tick += new EventHandler(timer1_Tick);
               }
            
        }


        /* Following method processes 2 Die Sum button by creating a new Part2 form object and showing it. With creating forms visually, *
         * needed help to know haw to properly initialize a new form from within an existing form.                                       *
         * https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.form?view=net-5.0                                            */
        private void button2_Click(object sender, EventArgs e)
        {
            Part2 form = new Part2();
            form.ShowDialog();
            this.Close();
        }


        /* Following method processes processes what happenes each time a timer tick event happens. */
        private void timer1_Tick(object sender, EventArgs e)
        {
            /* Removes the amount of rolls that will be used in the timeUpdate method. should be 1000, but 500 seems to be what works. */
            numRoll = numRoll - 500;

            if (numRoll <= 0)
            {
                numRoll = numRoll + 1000;
                timeUpdate();
                timer1.Stop();

                for (int i = 0; i < 6; i++)
                {
                    count2[i] = 0;
                }
            }else
            {
                timeUpdate();
            }
        }

       
    }
}
