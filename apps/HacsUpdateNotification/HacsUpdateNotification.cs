using System;
using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;

public class HacsUpdateNotification : NetDaemonApp
{
    public override async Task InitializeAsync()
    {
        Entity("sensor.hacs")
        .WhenStateChange()
            .UseEntity("light.kitchen_light")
                .TurnOn()
        .Execute();
    }
}