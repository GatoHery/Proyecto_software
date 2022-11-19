using System;
using System.Collections.Generic;
using System.Data;

namespace Banco{
    public static class WorkerQuery{
        public static List<Worker> getWorkers()
        {
            var dt = Connection.ExecuteQuery($"SELECT * FROM worker");
            List<Worker> allWorkers = new List<Worker>();

            foreach (DataRow n in dt.Rows)
            {
                Worker w = new Worker();
                
                w.id_worker = n[0].ToString();
                w.name = n[1].ToString();
                w.username = n[2].ToString();
                w.email = n[3].ToString();
                w.password = n[4].ToString();

                allWorkers.Add(w);
            }


            return allWorkers;
        }
    }
}