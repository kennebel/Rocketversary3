using System.Collections.Generic;

namespace core
{
    public static class Global
    {
        #region Support Fields
        private static List<string> _EventTypes = null;
        #endregion

        #region Event Types
        public const string EventTypeGeneral = "General";
        public const string EventTypeLaunch = "Launch";
        public const string EventTypeLanding = "Landing";
        public const string EventTypeArrival = "Arrival";
        public const string EventTypeEndOfMission = "End of Mission";

        public static List<string> EventTypes
        {
            get
            {
                if (null == _EventTypes)
                {
                    _EventTypes = new List<string>()
                    {
                        EventTypeGeneral,
                        EventTypeLaunch,
                        EventTypeLanding,
                        EventTypeArrival,
                        EventTypeEndOfMission
                    };
                }
                return _EventTypes;
            }
        }
        #endregion
    }
}