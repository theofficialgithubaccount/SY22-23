using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neverminditsaformapp
{
    internal class car
    {
        public car(int mpg)
        {
            m_mpg = mpg;
        }
        public Boolean left { get; set; }   
        public Boolean right { get; set; }  
        public Boolean brake
        {
            get; set;
        }
        public Boolean Gas { get; set; }
        int m_speed;
        double m_pct = 1;
        int m_mpg;
        int m_fuel;
        public int speed 
        { 
            get
            {
                return m_speed;
            }
            set 
            {             
                m_pct = 1 - Math.Abs(55 - speed)/100;
                m_speed = value;
            }
        }
        public int mpg 
        { 
            get 
            { 
                return (int)m_pct * m_mpg; 
            }
            
        }
        public int fuel 
        { 
            get
            {
                return m_fuel;
            }
            set
            {

            }
        }
        public void drive()
        {
            if (Gas)
            {
                speed += 5;
                if (speed > 130)
                    speed = 130;

                fuel -= 1;
                if (fuel < 0)
                    fuel = 0;
            }
            if (brake)
            {
                speed -= 8;
                if (speed < 0)
                    speed = 0;
            }
        }
    }
}
