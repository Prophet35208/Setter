using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Setter
{
    internal class Params
    {

        public double direction_change_random_time { get; set; }
        public double direction_cnange_random_percent { get; set; }

        public double pds_fire_random_time { get; set; }
        public double pds_fire_random_percent { get; set; }

        public double rocket_fire_random_time { get; set; }
        public double rocket_fire_random_percent { get; set; }

        public double angle_change_speed_ship { get; set; }
        public double passive_approach_engine_speed { get; set; }
        public double general_engine_speed { get; set; }
        public double distance_to_trigger_speed_boost { get; set; }
        public double ship_hp { get; set; }


        public double pds_alive_timer { get; set; }
        public double shots_per_pds_boorst { get; set; }
        public double pds_spread_angle { get; set; }
        public double pds_speed { get; set; }
        public double pds_dmg { get; set; }


        public double rocket_alive_timer { get; set; }
        public double angle_change_rocket { get; set; }
        public double rocket_speed { get; set; }
        public double rocket_dmg { get; set; }

        public Params()
        {
        }



        public int Write(StreamWriter fileStream)

        {
            try
            {
                fileStream.WriteLine(direction_change_random_time.ToString());
                fileStream.WriteLine(direction_cnange_random_percent.ToString());

                fileStream.WriteLine(pds_fire_random_time.ToString());
                fileStream.WriteLine(pds_fire_random_percent.ToString());

                fileStream.WriteLine(rocket_fire_random_time.ToString());
                fileStream.WriteLine(rocket_fire_random_percent.ToString());

                fileStream.WriteLine(angle_change_speed_ship.ToString());
                fileStream.WriteLine(passive_approach_engine_speed.ToString());
                fileStream.WriteLine(general_engine_speed.ToString());
                fileStream.WriteLine(distance_to_trigger_speed_boost.ToString());
                fileStream.WriteLine(ship_hp.ToString());


                fileStream.WriteLine(pds_alive_timer.ToString());
                fileStream.WriteLine(shots_per_pds_boorst.ToString());
                fileStream.WriteLine(pds_spread_angle.ToString());
                fileStream.WriteLine(pds_speed.ToString());
                fileStream.WriteLine(pds_dmg.ToString());


                fileStream.WriteLine(rocket_alive_timer.ToString());
                fileStream.WriteLine(angle_change_rocket.ToString());
                fileStream.WriteLine(rocket_speed.ToString());
                fileStream.WriteLine(rocket_dmg.ToString());
                return 0;
            }
            catch
            {
                return -1;
            }
        }
        public int Reed(StreamReader fileStream)
        {
            try
            {
                direction_change_random_time = double.Parse(fileStream.ReadLine(), CultureInfo.InvariantCulture);
                direction_cnange_random_percent = double.Parse(fileStream.ReadLine(), CultureInfo.InvariantCulture);

                pds_fire_random_time = double.Parse(fileStream.ReadLine(), CultureInfo.InvariantCulture);
                pds_fire_random_percent = double.Parse(fileStream.ReadLine(), CultureInfo.InvariantCulture);

                rocket_fire_random_time = double.Parse(fileStream.ReadLine(), CultureInfo.InvariantCulture);
                rocket_fire_random_percent = double.Parse(fileStream.ReadLine(), CultureInfo.InvariantCulture);

                angle_change_speed_ship = double.Parse(fileStream.ReadLine(), CultureInfo.InvariantCulture);
                passive_approach_engine_speed = double.Parse(fileStream.ReadLine(), CultureInfo.InvariantCulture);
                general_engine_speed = double.Parse(fileStream.ReadLine(), CultureInfo.InvariantCulture);
                distance_to_trigger_speed_boost = double.Parse(fileStream.ReadLine(), CultureInfo.InvariantCulture);
                ship_hp = double.Parse(fileStream.ReadLine(), CultureInfo.InvariantCulture);

                pds_alive_timer = double.Parse(fileStream.ReadLine(), CultureInfo.InvariantCulture);
                shots_per_pds_boorst = double.Parse(fileStream.ReadLine(), CultureInfo.InvariantCulture);
                pds_spread_angle = double.Parse(fileStream.ReadLine(), CultureInfo.InvariantCulture);
                pds_speed = double.Parse(fileStream.ReadLine(), CultureInfo.InvariantCulture);
                pds_dmg = double.Parse(fileStream.ReadLine(), CultureInfo.InvariantCulture);

                rocket_alive_timer = double.Parse(fileStream.ReadLine(), CultureInfo.InvariantCulture);
                angle_change_rocket = double.Parse(fileStream.ReadLine(), CultureInfo.InvariantCulture);
                rocket_speed = double.Parse(fileStream.ReadLine(), CultureInfo.InvariantCulture);
                rocket_dmg = double.Parse(fileStream.ReadLine(), CultureInfo.InvariantCulture);


                return 0;
            }
            catch
            {
                return -1;
            }

        }
    }
}
