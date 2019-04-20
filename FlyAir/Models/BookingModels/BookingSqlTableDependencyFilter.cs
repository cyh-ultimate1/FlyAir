using FlyAir.Models.FlightModels;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TableDependency.SqlClient.Base.Abstracts;

namespace FlyAir.Models.BookingModels
{
    public class BookingSqlTableDependencyFilter : ITableDependencyFilter
    {
        private readonly int _locId1;
        private readonly int _locId2;
        public string queryStrOut { get; set; }

        public BookingSqlTableDependencyFilter(int locId1, int locId2)
        {
            _locId1 = locId1;
            _locId2 = locId2;
        }

        public string Translate()
        {
            string OriginLocIDName = nameof(Flight.OriginLocID);
            string DestLocIDName = nameof(Flight.DestLocID);


            var queryStr =  $@"({nameof(Booking.GoFlightId)} IN (SELECT ID FROM {Flight.tableName} WHERE({OriginLocIDName} = {_locId1} AND {DestLocIDName} = {_locId2}) OR({OriginLocIDName} = {_locId2} AND {DestLocIDName} = {_locId1}))) OR " +
                $"({nameof(Booking.ReturnFlightId)} IN (SELECT ID FROM {Flight.tableName} WHERE({OriginLocIDName} = {_locId1} AND {DestLocIDName} = {_locId2}) OR ({OriginLocIDName} = {_locId2} AND {DestLocIDName} = {_locId1})))";

            this.queryStrOut = queryStr;
            return queryStr;
        }
    }
}
