using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace approximation
{
    public partial class approximation : Form
    {
        Int32[] input_x = new Int32[256];
        Int32[] input_y = new Int32[256];
        Int32 input_size = 0;
        float a = 0;
        float b = 0;

        public approximation()
        {
            InitializeComponent();
        }

        private void input_to_arrays(String x, String y)
        {
            int last_separator = -1;
            input_size = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == ',')
                {
                    input_x[input_size] = System.Convert.ToInt32(
                        x.Substring(last_separator + 1, i - last_separator - 1));
                    last_separator = i;
                    input_size = input_size + 1;
                }
                if (x.Length == i + 1)
                {
                    input_x[input_size] = System.Convert.ToInt32(
                        x.Substring(last_separator + 1, i - last_separator));
                    input_size = input_size + 1;
                }
            }
            last_separator = -1;
            int n = 0;
            for (int i = 0; i < y.Length; i++)
            {
                if (y[i] == ',')
                {
                    input_y[n] = System.Convert.ToInt32(
                        y.Substring(last_separator + 1, i - last_separator - 1));
                    last_separator = i;
                    n = n + 1;
                }
                if (y.Length == i + 1)
                {
                    input_y[n] = System.Convert.ToInt32(
                        y.Substring(last_separator + 1, i - last_separator));
                    n = n + 1;
                }
            }
        }

        private void calculate_a_b()
        {
            float sigma_x_y = 0;
            float sigma_x_2 = 0;
            float sigma_x = 0;
            float sigma_y = 0;
            for (int i = 0; i < input_size; i++)
            {
                sigma_x_y = sigma_x_y + (input_x[i] * input_y[i]);
                sigma_x_2 = sigma_x_2 + (input_x[i] * input_x[i]);
                sigma_x = sigma_x + input_x[i];
                sigma_y = sigma_y + input_y[i];
            }

            a = (input_size * sigma_x_y - sigma_x * sigma_y) / (input_size * sigma_x_2 - sigma_x * sigma_x);
            b = (sigma_y - a * sigma_x) / input_size;
        }

        private void plot_graphics()
        {
            chart_c.Series["input_s"].Points.Clear();
            chart_c.Series["input_points_s"].Points.Clear();
            chart_c.Series["output_s"].Points.Clear();
            for (int i = 0; i < input_size; i++)
            {
                chart_c.Series["input_s"].Points.AddXY(input_x[i], input_y[i]);
                chart_c.Series["input_points_s"].Points.AddXY(input_x[i], input_y[i]);
            }
            chart_c.Series["output_s"].Points.AddXY(input_x[0], a * input_x[0] + b);
            chart_c.Series["output_s"].Points.AddXY(input_x[input_size - 1], a * input_x[input_size - 1] + b);
        }

        private void calculate_b_Click(object sender, EventArgs e)
        {
            if (input_x_t.Text == "")
            {
                output_t.Text = "array 'x' is empty";
            }
            else if(input_y_t.Text == "")
            {
                output_t.Text = "array 'y' is empty";
            }
            else
            {
                if (welcome_l.Visible)
                {
                    welcome_l.Hide();
                }
                if (!chart_c.Visible)
                {
                    chart_c.Show();
                }
                input_to_arrays(input_x_t.Text, input_y_t.Text);
                calculate_a_b();
                plot_graphics();
                String output_s = "";
                output_s = output_s + "y = " + a.ToString();
				if (b > 0)
				{
					output_s = output_s + "x + " + b.ToString();
				}
				else if (b < 0)
				{
					output_s = output_s + "x - " + (0.0 - b).ToString();
				}
                output_t.Text = output_s;
            }
        }
    }
}
