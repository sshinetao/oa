using System;
using System.Diagnostics;
using System.Collections;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aspose.Cells;
using System.Reflection;

namespace FTD.Unit
{
    /// <summary>
    /// ����EXCEL�������ݱ������    
    /// </summary>
    public class DataToExcel
    {
        public DataToExcel()
        {
        }

        #region ����EXCEL��һ����(��ҪExcel.dll֧��)

        private int titleColorindex = 15;
        /// <summary>
        /// ���ⱳ��ɫ
        /// </summary>
        public int TitleColorIndex
        {
            set { titleColorindex = value; }
            get { return titleColorindex; }
        }

        private DateTime beforeTime;			//Excel����֮ǰʱ��
        private DateTime afterTime;				//Excel����֮��ʱ��

        #region ����һ��Excelʾ��
        /// <summary>
        /// ����һ��Excelʾ��
        /// </summary>
        public void CreateExcel()
        {
            //Excel.Application excel = new Excel.Application();
            //excel.Application.Workbooks.Add(true);
            //excel.Cells[1, 1] = "��1�е�1��";
            //excel.Cells[1, 2] = "��1�е�2��";
            //excel.Cells[2, 1] = "��2�е�1��";
            //excel.Cells[2, 2] = "��2�е�2��";
            //excel.Cells[3, 1] = "��3�е�1��";
            //excel.Cells[3, 2] = "��3�е�2��";

            ////����
            //excel.ActiveWorkbook.SaveAs("./tt.xls", XlFileFormat.xlExcel9795, null, null, false, false, Excel.XlSaveAsAccessMode.xlNoChange, null, null, null, null, null);
            ////����ʾ
            //excel.Visible = true;
            //			excel.Quit();
            //			excel=null;            
            //			GC.Collect();//��������
        }
        #endregion

        #region ��DataTable�����ݵ�����ʾΪ����
        /// <summary>
        /// ��DataTable�����ݵ�����ʾΪ����
        /// </summary>
        /// <param name="dt">Ҫ����������</param>
        /// <param name="strTitle">��������ı���</param>
        /// <param name="FilePath">�����ļ���·��</param>
        /// <returns></returns>
      
        
        
        
        
        #endregion

        #region Kill Excel����

        /// <summary>
        /// ����Excel����
        /// </summary>
        public void KillExcelProcess()
        {
            Process[] myProcesses;
            DateTime startTime;
            myProcesses = Process.GetProcessesByName("Excel");

            //�ò���Excel����ID����ʱֻ���жϽ�������ʱ��
            foreach (Process myProcess in myProcesses)
            {
                startTime = myProcess.StartTime;
                if (startTime > beforeTime && startTime < afterTime)
                {
                    myProcess.Kill();
                }
            }
        }
        #endregion

        #endregion

        #region ��DataTable�����ݵ�����ʾΪ����(��ʹ��Excel����ʹ��COM.Excel)

        #region ʹ��ʾ��
        public static void GridViewToExcel(DataSet MyData, Hashtable nameList,string ReportTitle)
        {
            string FilePath = System.Web.HttpContext.Current.Server.MapPath("../") + "ReportFile\\";
            //����excel����
            DataToExcel dte = new DataToExcel();
            string filename = "";
            try
            {
                if (MyData.Tables[0].Rows.Count > 0)
                {
                    filename = dte.DataExcel(MyData.Tables[0], ReportTitle, FilePath, nameList);
                }
            }
            catch
            {}
            if (filename != "")
            {
                System.Web.HttpContext.Current.Response.Redirect("../ReportFile/" + filename, true);
            }
        }

        #endregion

        /// <summary>
        /// ��DataTable�����ݵ�����ʾΪ����(��ʹ��Excel����)
        /// </summary>
        /// <param name="dt">����DataTable</param>
        /// <param name="strTitle">����</param>
        /// <param name="FilePath">�����ļ���·��</param>
        /// <param name="nameList"></param>
        /// <returns></returns>
        public string DataExcel(System.Data.DataTable dt, string strTitle, string FilePath, Hashtable nameList)
        {
            COM.Excel.cExcelFile excel = new COM.Excel.cExcelFile();
            ClearFile(FilePath);
            string filename = DateTime.Now.ToString("yyyyMMddHHmmssff") + ".xls";
            excel.CreateFile(FilePath + filename);
            excel.PrintGridLines = false;

            COM.Excel.cExcelFile.MarginTypes mt1 = COM.Excel.cExcelFile.MarginTypes.xlsTopMargin;
            COM.Excel.cExcelFile.MarginTypes mt2 = COM.Excel.cExcelFile.MarginTypes.xlsLeftMargin;
            COM.Excel.cExcelFile.MarginTypes mt3 = COM.Excel.cExcelFile.MarginTypes.xlsRightMargin;
            COM.Excel.cExcelFile.MarginTypes mt4 = COM.Excel.cExcelFile.MarginTypes.xlsBottomMargin;

            double height = 1.5;
            excel.SetMargin(ref mt1, ref height);
            excel.SetMargin(ref mt2, ref height);
            excel.SetMargin(ref mt3, ref height);
            excel.SetMargin(ref mt4, ref height);

            COM.Excel.cExcelFile.FontFormatting ff = COM.Excel.cExcelFile.FontFormatting.xlsNoFormat;
            string font = "����";
            short fontsize = 9;
            excel.SetFont(ref font, ref fontsize, ref ff);

            byte b1 = 1,
                b2 = 12;
            short s3 = 12;
            excel.SetColumnWidth(ref b1, ref b2, ref s3);

            string header = "ҳü";
            string footer = "ҳ��";
            excel.SetHeader(ref header);
            excel.SetFooter(ref footer);


            COM.Excel.cExcelFile.ValueTypes vt = COM.Excel.cExcelFile.ValueTypes.xlsText;
            COM.Excel.cExcelFile.CellFont cf = COM.Excel.cExcelFile.CellFont.xlsFont0;
            COM.Excel.cExcelFile.CellAlignment ca = COM.Excel.cExcelFile.CellAlignment.xlsCentreAlign;
            COM.Excel.cExcelFile.CellHiddenLocked chl = COM.Excel.cExcelFile.CellHiddenLocked.xlsNormal;

            // �������
            int cellformat = 1;
            //			int rowindex = 1,colindex = 3;					
            //			object title = (object)strTitle;
            //			excel.WriteValue(ref vt, ref cf, ref ca, ref chl,ref rowindex,ref colindex,ref title,ref cellformat);

            int rowIndex = 1;//��ʼ��
            int colIndex = 0;



            //ȡ���б���				
            foreach (DataColumn colhead in dt.Columns)
            {
                colIndex++;
                string name = colhead.ColumnName.Trim();
                object namestr = (object)name;
                IDictionaryEnumerator Enum = nameList.GetEnumerator();
                while (Enum.MoveNext())
                {
                    if (Enum.Key.ToString().Trim() == name)
                    {
                        namestr = Enum.Value;
                    }
                }
                excel.WriteValue(ref vt, ref cf, ref ca, ref chl, ref rowIndex, ref colIndex, ref namestr, ref cellformat);
            }

            //ȡ�ñ���е�����			
            foreach (DataRow row in dt.Rows)
            {
                rowIndex++;
                colIndex = 0;
                foreach (DataColumn col in dt.Columns)
                {
                    colIndex++;
                    if (col.DataType == System.Type.GetType("System.DateTime"))
                    {
                        object str = (object)(Convert.ToDateTime(row[col.ColumnName].ToString())).ToString("yyyy-MM-dd"); ;
                        excel.WriteValue(ref vt, ref cf, ref ca, ref chl, ref rowIndex, ref colIndex, ref str, ref cellformat);
                    }
                    else
                    {
                        object str = (object)row[col.ColumnName].ToString();
                        excel.WriteValue(ref vt, ref cf, ref ca, ref chl, ref rowIndex, ref colIndex, ref str, ref cellformat);
                    }
                }
            }
            int ret = excel.CloseFile();

            //			if(ret!=0)
            //			{
            //				//MessageBox.Show(this,"Error!");
            //			}
            //			else
            //			{
            //				//MessageBox.Show(this,"����ļ�c:\\test.xls!");
            //			}
            return filename;

        }

        #endregion

        #region  �����ʱ��Excel�ļ�

        private void ClearFile(string FilePath)
        {
            String[] Files = System.IO.Directory.GetFiles(FilePath);
            if (Files.Length > 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    try
                    {
                        System.IO.File.Delete(Files[i]);
                    }
                    catch
                    {
                    }

                }
            }
        }
        #endregion

    }
}
