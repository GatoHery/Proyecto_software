using System;
using System.Collections.Generic;
using System.Data;

namespace Banco{
    public static class WorkerQuery{
        public static List<Worker> getWorkers()
        {
            var dt = Connection.ExecuteQuery($"SELECT * FROM workers");
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

        public static string getWorker(string username){
            var dt = Connection.ExecuteQuery($"SELECT worker_password FROM workers WHERE worker_username = '{username}'");
            DataRow n = dt.Rows[0];
            string pass = n[0].ToString();

            return pass;
        }
    }
}