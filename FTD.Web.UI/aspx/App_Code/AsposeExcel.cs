using System;
using System.Collections.Generic;
using System.Text;
using Aspose.Cells;
using System.Data;

namespace FTD.Web.UI.aspx.App_Code
{
    public class AsposeExcel
    {
        private string outFileName = "";
        private string fullFilename = "";
        private Workbook book = null;
        private Worksheet sheet = null;

        public AsposeExcel(string outfilename, string tempfilename)//导出构造数
        {
            outFileName = outfilename;
            book = new Workbook();
            // book.Open(tempfilename);这里我们暂时不用模板
            sheet = book.Worksheets[0];
        }
        public AsposeExcel(string fullfilename)//导入构造数
        {
            fullFilename = fullfilename;
            // book = new Workbook();
            //book.Open(tempfilename);
            //sheet = book.Worksheets[0];
        }

        private void AddTitle(string title, int columnCount)
        {
            sheet.Cells.Merge(0, 0, 1, columnCount);
            sheet.Cells.Merge(1, 0, 1, columnCount);

            Cell cell1 = sheet.Cells[0, 0];
            cell1.PutValue(title);
            Style s = new Style(); ;
            s.HorizontalAlignment = TextAlignmentType.Center;
            s.Font.Name = "黑体";
            s.Font.Size = 14;
            s.Font.IsBold = true;
            cell1.SetStyle(s);
            Cell cell2 = sheet.Cells[1, 0];
            cell1.PutValue("查询时间：" + DateTime.Now.ToLocalTime());
            cell2.SetStyle(s);
        }

        private void AddHeader(DataTable dt)
        {
            Cell cell = null;
            for (int col = 0; col < dt.Columns.Count; col++)
            {
                cell = sheet.Cells[0, col];
                cell.PutValue(dt.Columns[col].ColumnName);
                Style s = new Style();
                s.Font.IsBold = true;
                cell.SetStyle(s);
            }
        }

        private void AddBody(DataTable dt)
        {
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    sheet.Cells[r + 1, c].PutValue(dt.Rows[r][c].ToString());
                }
            }
        }
        //导出------------下一篇会用到这个方法
        public Boolean DatatableToExcel(DataTable dt)
        {
            Boolean yn = false;
            try
            {
                //sheet.Name = sheetName;

                //AddTitle(title, dt.Columns.Count);
                //AddHeader(dt);
                AddBody(dt);

                sheet.AutoFitColumns();
                //sheet.AutoFitRows();

                book.Save(outFileName);
                yn = true;
                return yn;
            }
            catch (Exception e)
            {
                return yn;
                // throw e;
            }
        }

        public DataTable ExcelToDatatalbe()//导入
        {
            Workbook book = new Workbook();
            book.Open(fullFilename);
            Worksheet sheet = book.Worksheets[0];
            Cells cells = sheet.Cells;
            //获取excel中的数据保存到一个datatable中
            DataTable dt_Import = cells.ExportDataTableAsString(0, 0, cells.MaxDataRow + 1, cells.MaxDataColumn + 1, false);
            // dt_Import.
            return dt_Import;
        }



    }
}