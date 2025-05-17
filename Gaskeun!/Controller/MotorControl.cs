using Gaskeun_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Controller
{
    public class MotorControl
    {
        MotorContext motorContext;
        public MotorControl()
        {
            motorContext = new MotorContext();
        }
        public bool AddMotor(Motor motor)
        {
            return motorContext.Insert(motor);
        }
        public List<Motor> GetAllMotors()
        {
            motorContext.Read();
            return motorContext.listMotor;
        }
        public bool UpdateMotor(Motor motor, string platLama)
        {
            return motorContext.Update(motor, platLama);
        }
        public bool DeleteMotor(Motor motor)
        {
            return motorContext.Delete(motor);
        }
    }
}
