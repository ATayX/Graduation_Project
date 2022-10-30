using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Graduation_Project.Model;
using Graduation_Project.Server;
using System.Threading;

namespace Graduation_Project
{
    public partial class Form1 : Form
    {
        Robot myRobot = new Robot();
        Transmitter myTransmitter = new Transmitter();

        public Form1()
        {
            InitializeComponent();
            // Setup transmission
            myTransmitter.portName = "COM3";
            myTransmitter.baudRate = 9600;
            // Setup Robot Server capabilities for Transmitter
            myTransmitter.robotsArray = new Robot[1];
            myTransmitter.robotsArray.Append(myRobot);

            // Starting transmission
            Thread thread = new Thread( 
                new ThreadStart(myTransmitter.Start));
            thread.IsBackground = true;
            thread.Start();
        }
        
        


    }
}
