using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFDC_Attachments_Download_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnFundRequest_Click(object sender, EventArgs e)
        {
            var db = new AppCode.DBConnector();
            ProcessFile(db.GetFundRequestAttachments(), "FundRequest");
            btnFundRequest.Enabled = false;

            MessageBox.Show("I believe in miracles");
        }

        private void btnFundClaims_Click(object sender, EventArgs e)
        {
            var db = new AppCode.DBConnector();
            ProcessFile(db.GetFundClaimAttachments(), "FundClaim");

            btnFundClaims.Enabled = false;

            MessageBox.Show("I believe in miracles");

        }

        private void ProcessFile(List<ReportRecord> lstRecords, string recordType)
        {
            var lstDestinationRecords = new List<ReportRecord>();

            foreach(var record in lstRecords)
            {
                var path = recordType == "FundRequest" ? @"C:\Users\rachavarria\Documents\CCIAttachments\Fund Requests\Version 2\" + record.FileName : @"C:\Users\rachavarria\Documents\CCIAttachments\Fund Claim\Version 2\" + record.FileName;
                var destinationPath = recordType == "FundRequest" ? @"C:\Users\rachavarria\Documents\CCIAttachments\Fund Requests\Attachments\" : @"C:\Users\rachavarria\Documents\CCIAttachments\Fund Claims\";

                if (File.Exists(path))
                {
                    var destinationFile = destinationPath + record.Name + "_" + record.FileName;

                    destinationFile = CheckFileExistance(record, destinationPath, destinationFile);

                    File.Copy(path, destinationFile);

                    var item = new ReportRecord
                    {
                        Id = record.Id,
                        Name = record.Name,
                        FileName = record.Name + "_" + record.FileName

                    };
                    lstDestinationRecords.Add(item);
                }
                Console.Write(lstDestinationRecords.Count);
            }

            // WRITE TO EXCEL
            WriteOnFile(lstDestinationRecords, recordType);
        }

        private static string CheckFileExistance(ReportRecord record, string destinationPath, string destinationFile)
        {
            if (File.Exists(destinationFile))
            {
                destinationFile = destinationPath + record.Name + "_" + record.FileName.Split('.')[0] + "_2." + record.FileName.Split('.')[1];

                if (File.Exists(destinationFile))
                {
                    destinationFile = destinationPath + record.Name + "_" + record.FileName.Split('.')[0] + "_3." + record.FileName.Split('.')[1];

                    if (File.Exists(destinationFile))
                    {
                        destinationFile = destinationPath + record.Name + "_" + record.FileName.Split('.')[0] + "_4." + record.FileName.Split('.')[1];

                        if (File.Exists(destinationFile))
                        {
                            destinationFile = destinationPath + record.Name + "_" + record.FileName.Split('.')[0] + "_5." + record.FileName.Split('.')[1];

                            if (File.Exists(destinationFile))
                            {
                                destinationFile = destinationPath + record.Name + "_" + record.FileName.Split('.')[0] + "_6." + record.FileName.Split('.')[1];

                                if (File.Exists(destinationFile))
                                {
                                    destinationFile = destinationPath + record.Name + "_" + record.FileName.Split('.')[0] + "_7." + record.FileName.Split('.')[1];

                                    if (File.Exists(destinationFile))
                                    {
                                        destinationFile = destinationPath + record.Name + "_" + record.FileName.Split('.')[0] + "_8." + record.FileName.Split('.')[1];

                                        if (File.Exists(destinationFile))
                                        {
                                            destinationFile = destinationPath + record.Name + "_" + record.FileName.Split('.')[0] + "_9." + record.FileName.Split('.')[1];

                                            if (File.Exists(destinationFile))
                                            {
                                                destinationFile = destinationPath + record.Name + "_" + record.FileName.Split('.')[0] + "_10." + record.FileName.Split('.')[1];
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return destinationFile;
        }

        private void WriteOnFile(List<ReportRecord> lstRecords, string recordType)
        {
            lstRecords = lstRecords.OrderBy(x => x.Name).ToList();
            var reportPath = recordType == "FundRequest" ? @"C:\Users\rachavarria\Documents\CCIAttachments\Fund Request Report.csv" : @"C:\Users\rachavarria\Documents\CCIAttachments\Fund Claim Report.csv";
            
            if (File.Exists(reportPath))
                File.Delete(reportPath);

            File.WriteAllLines(reportPath, lstRecords.Select(x => string.Join("|",x.Id, x.Name, x.FileName)));
        }

    }
}
