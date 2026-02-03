using Game.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GohkenThaiOverrider.Utils
{
    public static class FinalDestinationHelper
    {

        public static RouteWaypoint getFinalWaypoint(List<RouteWaypoint> waypoints)
        {
            try
            {
                return waypoints[waypoints.Count / 2];
            }
            catch (Exception e)
            {
                return waypoints[0];
            }

        }
    }
}
