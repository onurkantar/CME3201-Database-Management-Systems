using System;
using System.Collections.Generic;
using OTOTO.DataAccess;
using static OTOTO.DataAccess.LogEntityBase;

namespace OTOTO.Business
{
    class Log
    {

        public static List<LogEntity> GetAllLogs()
        {
            return DataAccess.LogDAO.GetAllLogs();
        }

    }
}
