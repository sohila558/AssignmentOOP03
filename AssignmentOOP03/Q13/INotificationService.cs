using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP03.Q13
{
    internal interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
}
