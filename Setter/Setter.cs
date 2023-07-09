
using System;
using System.Globalization;
using System.IO;
using System.IO.Pipes;

namespace Setter
{
    public partial class Setter : Form
    {
        Params param_first_ship;
        Params param_second_ship;
        StreamWriter fileStream_writer;
        StreamReader fileStream_reader;
        public Setter()
        {
            InitializeComponent();
            param_first_ship = new Params();
            param_second_ship = new Params();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                fileStream_writer = new StreamWriter("Param.txt");

                param_first_ship.direction_change_random_time = double.Parse(this.direction_change__random_time_1.Text, CultureInfo.InvariantCulture);
                param_first_ship.direction_cnange_random_percent = Convert.ToDouble(this.numericUpDown_direction_change_random_percent1.Value) / 100;

                param_first_ship.pds_fire_random_time = double.Parse(this.textBox_pds_fire_random_time_1.Text, CultureInfo.InvariantCulture);
                param_first_ship.pds_fire_random_percent = Convert.ToDouble(this.numericUpDown_pds_fire_random_percent_1.Value) / 100;

                param_first_ship.rocket_fire_random_time = double.Parse(this.textBox_rocket_fire_random_time_1.Text, CultureInfo.InvariantCulture);
                param_first_ship.rocket_fire_random_percent = Convert.ToDouble(this.numericUpDown_rocket_fire_random_percent_1.Value) / 100;

                param_first_ship.angle_change_speed_ship = double.Parse(this.textBox_angle_change_speed_ship_1.Text, CultureInfo.InvariantCulture);
                param_first_ship.passive_approach_engine_speed = double.Parse(this.textBox_passive_approach_engine_speed_1.Text, CultureInfo.InvariantCulture);
                param_first_ship.general_engine_speed = double.Parse(this.textBox_general_engine_speed_1.Text, CultureInfo.InvariantCulture);
                param_first_ship.distance_to_trigger_speed_boost = double.Parse(this.textBox_distance_to_trigger_speed_boost_1.Text, CultureInfo.InvariantCulture);
                param_first_ship.ship_hp = double.Parse(this.textBox_ship_hp_1.Text, CultureInfo.InvariantCulture);


                param_first_ship.pds_alive_timer = double.Parse(this.textBox_pds_alive_timer_1.Text, CultureInfo.InvariantCulture);
                param_first_ship.shots_per_pds_boorst = double.Parse(this.textBox_shots_per_pds_burst_1.Text, CultureInfo.InvariantCulture);
                param_first_ship.pds_spread_angle = double.Parse(this.textBox_pds_spread_angle_1.Text, CultureInfo.InvariantCulture);
                param_first_ship.pds_speed = double.Parse(this.textBox_pds_speed_1.Text, CultureInfo.InvariantCulture);
                param_first_ship.pds_dmg = double.Parse(this.textBox_pds_dmg_1.Text, CultureInfo.InvariantCulture);

                param_first_ship.rocket_alive_timer = double.Parse(this.textBox_rocket_alive_timer_1.Text, CultureInfo.InvariantCulture);
                param_first_ship.angle_change_rocket = double.Parse(this.textBox_angle_change_rocket_1.Text, CultureInfo.InvariantCulture);
                param_first_ship.rocket_speed = double.Parse(this.textBox_rocket_speed_1.Text, CultureInfo.InvariantCulture);
                param_first_ship.rocket_dmg = double.Parse(this.textBox_rocket_dmg_1.Text, CultureInfo.InvariantCulture);

                param_first_ship.Write(fileStream_writer);


                param_second_ship.direction_change_random_time = double.Parse(this.direction_change__random_time_2.Text, CultureInfo.InvariantCulture);
                param_second_ship.direction_cnange_random_percent = Convert.ToDouble(this.numericUpDown_direction_change_random_percent2.Value) / 100;

                param_second_ship.pds_fire_random_time = double.Parse(this.textBox_pds_fire_random_time_2.Text, CultureInfo.InvariantCulture);
                param_second_ship.pds_fire_random_percent = Convert.ToDouble(this.numericUpDown_pds_fire_random_percent_2.Value) / 100;

                param_second_ship.rocket_fire_random_time = double.Parse(this.textBox_rocket_fire_random_time_2.Text, CultureInfo.InvariantCulture);
                param_second_ship.rocket_fire_random_percent = Convert.ToDouble(this.numericUpDown_rocket_fire_random_percent_2.Value) / 100;

                param_second_ship.angle_change_speed_ship = double.Parse(this.textBox_angle_change_speed_ship_2.Text, CultureInfo.InvariantCulture);
                param_second_ship.passive_approach_engine_speed = double.Parse(this.textBox_passive_approach_engine_speed_2.Text, CultureInfo.InvariantCulture);
                param_second_ship.general_engine_speed = double.Parse(this.textBox_general_engine_speed_2.Text, CultureInfo.InvariantCulture);
                param_second_ship.distance_to_trigger_speed_boost = double.Parse(this.textBox_distance_to_trigger_speed_boost_2.Text, CultureInfo.InvariantCulture);
                param_second_ship.ship_hp = double.Parse(this.textBox_ship_hp_2.Text, CultureInfo.InvariantCulture);

                param_second_ship.pds_alive_timer = double.Parse(this.textBox_pds_alive_timer_2.Text, CultureInfo.InvariantCulture);
                param_second_ship.shots_per_pds_boorst = double.Parse(this.textBox_shots_per_pds_burst_2.Text, CultureInfo.InvariantCulture);
                param_second_ship.pds_spread_angle = double.Parse(this.textBox_pds_spread_angle_2.Text, CultureInfo.InvariantCulture);
                param_second_ship.pds_speed = double.Parse(this.textBox_pds_speed_2.Text, CultureInfo.InvariantCulture);
                param_second_ship.pds_dmg = double.Parse(this.textBox_pds_dmg_2.Text, CultureInfo.InvariantCulture);

                param_second_ship.rocket_alive_timer = double.Parse(this.textBox_rocket_alive_timer_2.Text, CultureInfo.InvariantCulture);
                param_second_ship.angle_change_rocket = double.Parse(this.textBox_angle_change_rocket_2.Text, CultureInfo.InvariantCulture);
                param_second_ship.rocket_speed = double.Parse(this.textBox_rocket_speed_2.Text, CultureInfo.InvariantCulture);
                param_second_ship.rocket_dmg = double.Parse(this.textBox_rocket_dmg_2.Text, CultureInfo.InvariantCulture);

                param_second_ship.Write(fileStream_writer);
                fileStream_writer.Close();
            }
            catch
            {
                if (fileStream_writer != null) {
                    fileStream_writer.Close();
                }
                MessageBox.Show("Ошибка при заполнении или не удалось сохранить. Скорее всего файл настроек недоступен");

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                fileStream_reader = new StreamReader("Param.txt");
                string line;
                line = fileStream_reader.ReadLine();
                direction_change__random_time_1.Text = line;
                numericUpDown_direction_change_random_percent1.Value = decimal.Parse(fileStream_reader.ReadLine()) * 100;

                textBox_pds_fire_random_time_1.Text= fileStream_reader.ReadLine();
                numericUpDown_pds_fire_random_percent_1.Value =decimal.Parse(fileStream_reader.ReadLine())*100;

                textBox_rocket_fire_random_time_1.Text = fileStream_reader.ReadLine();
                numericUpDown_rocket_fire_random_percent_1.Value = decimal.Parse(fileStream_reader.ReadLine()) * 100;

                textBox_angle_change_speed_ship_1.Text = fileStream_reader.ReadLine();
                textBox_passive_approach_engine_speed_1.Text = fileStream_reader.ReadLine();
                textBox_general_engine_speed_1.Text = fileStream_reader.ReadLine();
                textBox_distance_to_trigger_speed_boost_1.Text = fileStream_reader.ReadLine();
                textBox_ship_hp_1.Text = fileStream_reader.ReadLine();

                textBox_pds_alive_timer_1.Text = fileStream_reader.ReadLine();
                textBox_shots_per_pds_burst_1.Text = fileStream_reader.ReadLine();
                textBox_pds_spread_angle_1.Text = fileStream_reader.ReadLine();
                textBox_pds_speed_1.Text = fileStream_reader.ReadLine();
                textBox_pds_dmg_1.Text = fileStream_reader.ReadLine();

                textBox_rocket_alive_timer_1.Text = fileStream_reader.ReadLine();
                textBox_angle_change_rocket_1.Text = fileStream_reader.ReadLine();
                textBox_rocket_speed_1.Text = fileStream_reader.ReadLine();
                textBox_rocket_dmg_1.Text = fileStream_reader.ReadLine();






                direction_change__random_time_2.Text = fileStream_reader.ReadLine();
                numericUpDown_direction_change_random_percent2.Value = decimal.Parse(fileStream_reader.ReadLine()) * 100;

                textBox_pds_fire_random_time_2.Text = fileStream_reader.ReadLine();
                numericUpDown_pds_fire_random_percent_2.Value = decimal.Parse(fileStream_reader.ReadLine()) * 100;

                textBox_rocket_fire_random_time_2.Text = fileStream_reader.ReadLine();
                numericUpDown_rocket_fire_random_percent_2.Value = decimal.Parse(fileStream_reader.ReadLine()) * 100;

                textBox_angle_change_speed_ship_2.Text = fileStream_reader.ReadLine();
                textBox_passive_approach_engine_speed_2.Text = fileStream_reader.ReadLine();
                textBox_general_engine_speed_2.Text = fileStream_reader.ReadLine();
                textBox_distance_to_trigger_speed_boost_2.Text = fileStream_reader.ReadLine();
                textBox_ship_hp_2.Text = fileStream_reader.ReadLine();

                textBox_pds_alive_timer_2.Text = fileStream_reader.ReadLine();
                textBox_shots_per_pds_burst_2.Text = fileStream_reader.ReadLine();
                textBox_pds_spread_angle_2.Text = fileStream_reader.ReadLine();
                textBox_pds_speed_2.Text = fileStream_reader.ReadLine();
                textBox_pds_dmg_2.Text = fileStream_reader.ReadLine();

                textBox_rocket_alive_timer_2.Text = fileStream_reader.ReadLine();
                textBox_angle_change_rocket_2.Text = fileStream_reader.ReadLine();
                textBox_rocket_speed_2.Text = fileStream_reader.ReadLine();
                textBox_rocket_dmg_2.Text = fileStream_reader.ReadLine();

                fileStream_reader.Close();




            }
            catch
            {
                if (fileStream_reader != null)
                {
                    fileStream_reader.Close();
                }
                MessageBox.Show("Ошибка при чтении файла настроек. Они будут сброшены");
            }
        }

        private void KeepOnlyDigits_Key_Press(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_direction_change_random_percent2.Value < 0)
            {
                numericUpDown_direction_change_random_percent2.Value = 0;
            }
            if (numericUpDown_direction_change_random_percent2.Value > 100)
            {
                numericUpDown_direction_change_random_percent2.Value=100;
            }
        }
    }
}