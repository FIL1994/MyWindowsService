using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MyWindowsService
{
    public partial class MyService : ServiceBase
    {
        public MyService()
        {
            this.ServiceName = "My Windows Service";
            this.EventLog.Log = "Application";

            //These flags set whether or not to handle that type of event
            this.CanHandlePowerEvent = true;
            this.CanHandleSessionChangeEvent = true;
            this.CanPauseAndContinue = true;
            this.CanShutdown = true;
            this.CanStop = true;

            InitializeComponent();
        }

        //start threads, get initial data, etc.
        protected override void OnStart(string[] args)
        {
            base.OnStart(args);
        }

        //for stoppiong threads, setting final data, etc.
        protected override void OnStop()
        {
            base.OnStop();
        }

        //pause working threads, etc.
        protected override void OnPause()
        {
            base.OnPause();
        }

        //un-pause working threads, etc.
        protected override void OnContinue()
        {
            base.OnContinue();
        }

        //code for handling a system shutdown. E.g. saving data
        protected override void OnShutdown()
        {
            base.OnShutdown();
        }

        //for receiving a custom command without the need for Remoting or Sockets
        protected override void OnCustomCommand(int command)
        {
            //  A custom command can be sent to a service by using this method:
            //#  int command = 128; //Some Arbitrary number between 128 & 256
            //#  ServiceController sc = new ServiceController("NameOfService");
            //#  sc.ExecuteCommand(command);
            base.OnCustomCommand(command);
        }

        //for detecting power status changes, such as Suspend or Low Battery (for laptops)
        protected override bool OnPowerEvent(PowerBroadcastStatus powerStatus)
        {
            return base.OnPowerEvent(powerStatus);
        }

        //handle a change event from a terminal server session. for determining when a user logs in remotely or logs off
        protected override void OnSessionChange(SessionChangeDescription changeDescription)
        {
            base.OnSessionChange(changeDescription);

        }
    }
}
