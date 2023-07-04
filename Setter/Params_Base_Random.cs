using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Setter
{
    internal class Params_Base_Random
    {
        int is_direction_const;

        double direction_change_random_time ;
        double direction_cnange_random_percent ;

        double boost_activation_random_time;
        double boost_activation_random_percent;

        double pds_fire_random_time ;
        double pds_fire_random_percent ;

        double rocket_fire_random_time ;
        double rocket_fire_random_percent ;

        public void Write(string filename)

        {
            StreamWriter fileStream = new StreamWriter(filename);
            fileStream.WriteLine(is_direction_const.ToString());
            fileStream.WriteLine(direction_change_random_time.ToString());
            fileStream.WriteLine(direction_cnange_random_percent.ToString());
            fileStream.WriteLine(boost_activation_random_time.ToString());
            fileStream.WriteLine(boost_activation_random_percent.ToString());
            fileStream.WriteLine(pds_fire_random_time.ToString());
            fileStream.WriteLine(pds_fire_random_percent.ToString());
            fileStream.WriteLine(rocket_fire_random_time.ToString());
            fileStream.WriteLine(rocket_fire_random_percent.ToString());
            fileStream.Close();
        }
    }
}
