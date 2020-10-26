using System;
using System.Collections.Generic;
using MongoDB.Entities;
using core.Data.Interfaces;

namespace src.infrastructure.Data.Models
{
    public class SpaceEvent : Entity, ISpaceEvent
    {
        #region Fields
        protected DateTime _When = DateTime.MinValue;
        protected int _NormalizedDayOfYear = 0;
        #endregion

        #region Properties
        public string Header { get; set; }
        public string Description { get; set; }
        public DateTime When
        {
            get { return _When; }
            set
            {
                _When = value;
                CalculateNormalDayOfYear();
            }
        }
        public List<string> ReferenceLinks { get; set; }
        public string CountryOfOrigin { get; set; }
        public string Mission { get; set; }
        public int NormalizedDayOfYear
        {
            get
            {
                if (_NormalizedDayOfYear < 1 || _NormalizedDayOfYear > 366) { CalculateNormalDayOfYear(); }

                return _NormalizedDayOfYear;
            }
            set { _NormalizedDayOfYear = value; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Grabs the day of the year based on a leap year to more easily figure out what
        /// events happened near each other on a calendar year instead of in continuous history.
        /// </summary>
        protected void CalculateNormalDayOfYear()
        {
            _NormalizedDayOfYear = new DateTime(2020, When.Month, When.Day).DayOfYear;
        }
        #endregion
    }
}