using imaint_barcode_v2.DataContracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace imaint_barcode_v2.DataContracts
{
    public class DatabaseService
    {
        public Part GetPartData(string partNumber)
        {
            var connectionString = string.Format("Data Source={0}; Initial Catalog={1}; trusted_connection=false; User Id={2}; Password={3};",
                         Properties.Settings.Default.DatabaseServer,
                         Properties.Settings.Default.SiteName,
                         Properties.Settings.Default.DatabaseUsername,
                         Properties.Settings.Default.DatabasePassword);
            var connection = new SqlConnection(connectionString);

            var command = new SqlCommand("usp_getPartData", connection)
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 3000
            };

            command.Parameters.AddWithValue("@partNumber", partNumber);

            var adapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();

            connection.Open();
            adapter.Fill(dataTable);
            connection.Close();

            var partItem = new Part();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    partItem.ID = row["PartID"] == DBNull.Value || row["PartID"] == null ? string.Empty : row["PartID"].ToString();
                    partItem.Description = row["PartDescription"] == DBNull.Value || row["PartDescription"] == null ? string.Empty : row["PartDescription"].ToString();
                    partItem.Whse = row["Whse"] == DBNull.Value || row["Whse"] == null ? string.Empty : row["Whse"].ToString();
                    partItem.WhsLocation = row["WhsLocation"] == DBNull.Value || row["WhsLocation"] == null ? string.Empty : row["WhsLocation"].ToString();
                }
            }

            return partItem;
        }

        public List<Site> GetSiteNames()
        {
            var connectionString = string.Format("Data Source={0}; Initial Catalog={1}; trusted_connection=false; User Id={2}; Password={3};",
                                     Properties.Settings.Default.DatabaseServer,
                                     Properties.Settings.Default.DatabaseName,
                                     Properties.Settings.Default.DatabaseUsername,
                                     Properties.Settings.Default.DatabasePassword);
            var connection = new SqlConnection(connectionString);

            var command = new SqlCommand("usp_getiMaintSites", connection)
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 3000
            };

            var adapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();

            connection.Open();
            adapter.Fill(dataTable);
            connection.Close();

            var sites = new List<Site>();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    sites.Add(new Site()
                    {
                        Name = row["site_name"] == DBNull.Value || row["site_name"] == null ? string.Empty : row["site_name"].ToString()
                    });
                }
            }

            return sites;
        }
    }
}
