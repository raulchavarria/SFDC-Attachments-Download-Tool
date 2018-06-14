using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SFDC_Attachments_Download_Tool.AppCode
{
    class DBConnector
    {
        const string connectionString = @"Data Source=MXTJLTH7RQFH2\SQLEXPRESS;Initial Catalog=CCI_AttachmentMigration;Integrated Security=True";
        public List<ReportRecord> GetFundRequestAttachments()
        {
            
            var lstReportRecords = new List<ReportRecord>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM tblFundRequestAttachments";
                var command = new SqlCommand(query, connection);

                
                connection.Open();

                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var record = new ReportRecord()
                        {
                            Id = reader["Id"].ToString(),
                            Name = reader["Name"].ToString(),
                            FileName = reader["FileName"].ToString()

                        };

                        lstReportRecords.Add(record);
                        
                    }

                    connection.Close();
                }

            }

            return lstReportRecords;

        }

        public List<ReportRecord> GetFundClaimAttachments()
        {

            var lstReportRecords = new List<ReportRecord>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM tblFundClaimAttachments";
                var command = new SqlCommand(query, connection);


                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var record = new ReportRecord()
                        {
                            Id = reader["Id"].ToString(),
                            Name = reader["Name"].ToString(),
                            FileName = reader["FileName"].ToString()

                        };

                        lstReportRecords.Add(record);

                    }

                    connection.Close();
                }

            }

            return lstReportRecords;

        }
    }
}
