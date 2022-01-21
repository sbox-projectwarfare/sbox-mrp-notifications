﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

namespace Notifications
{
	public class Error : NotificationsHud.NotificationBase
	{
		public Error()
        {
			Title = Add.Label("Something is creating error", "title");
        }
	}
}
