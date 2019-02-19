using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quicksort_SLIM
{
    public partial class frmQSS : Form
    {
        int[] arrNumbers = new int[9]; ///{ 1, 8, 3, 9, 4, 5, 7};
        Random generateNumbers = new Random();

        public frmQSS()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generate random numbers when form loads
        /// </summary>
        private void frmQSS_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                arrNumbers[i] = generateNumbers.Next(0, 11);
                lbxLeft.Items.Add(arrNumbers[i]);
            }
        }

        /// <summary>
        /// Resets array with random numbers
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            lbxLeft.Items.Clear();
            lbxRight.Items.Clear();

            for (int i = 0; i < arrNumbers.Length; i++)
            {
                arrNumbers[i] = generateNumbers.Next(0, 11);
                lbxLeft.Items.Add(arrNumbers[i]);
            }
        }


        private void btnSort_Click(object sender, EventArgs e)
        {
            int first = 0;
            int last = arrNumbers.Length;
            arrNumbers = Engine.sortArray(arrNumbers, first, last-1);

            for (int i = 0; i < arrNumbers.Length; i++)
            {
                lbxRight.Items.Add(arrNumbers[i]);
            }
        }
    }
}
