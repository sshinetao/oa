using System;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace FTD.DBUnit
{
    /// <summary>
    /// ���ݷ��ʳ��������
    /// </summary>
    public abstract class DbHelperSQL
    { 
        public DbHelperSQL()
        {

        }
        //�Լ��������ݿ������ַ���
        protected static string DecryptDBStr(string Text, string sKey)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            int len;
            len = Text.Length / 2;
            byte[] inputByteArray = new byte[len];
            int x, i;
            for (x = 0; x < len; x++)
            {
                i = Convert.ToInt32(Text.Substring(x * 2, 2), 16);
                inputByteArray[x] = (byte)i;
            }
            des.Key = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
            des.IV = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Encoding.Default.GetString(ms.ToArray());
        } 
        //���������ַ�����
        //protected static string ConnectionString = DecryptDBStr(ConfigurationManager.AppSettings["SQLConnectionString"], "zhangweilong");
        protected static string ConnectionString = ConfigurationManager.AppSettings["SQLConnectionString"];
        protected static SqlConnection Connection;
        //�������ݿ�Ĵ򿪺͹رշ���
        protected static void Open()
        {
            if (Connection == null)
            {
                Connection = new SqlConnection(ConnectionString);
            }
            if (Connection.State.Equals(ConnectionState.Closed))
            {
                Connection.Open();
            }
        }
        protected static void Close()
        {
            if (Connection != null)
            {
                Connection.Close();
            }
        }
        //�󶨵�GridView
        public static void BindGridView(string SqlString, GridView MyGvData)
        {
            MyGvData.DataSource = GetDataSet(SqlString);
            MyGvData.DataBind();
        }
        //�󶨵�DropDownList���趨Text��value��ʾ
        public static void BindDropDownList2(string SqlString, DropDownList MyDDL, string TextStr, string ValueStr)
        {
            DataSet MyDT =GetDataSet(SqlString);
            for(int i=0;i<MyDT.Tables[0].Rows.Count;i++)
            {
                ListItem MyItem = new ListItem();
                MyItem.Text = MyDT.Tables[0].Rows[i][TextStr].ToString();
                MyItem.Value = MyDT.Tables[0].Rows[i][ValueStr].ToString();
                MyDDL.Items.Add(MyItem);
            }            
        }
        //�󶨵�DropDownList���趨Text��value��ʾ
        public static void BindDropDownList(string SqlString, DropDownList MyDDL, string TextStr, string ValueStr)
        {            
            MyDDL.Items.Clear();
            DataSet MyDT = GetDataSet(SqlString);
            for (int i = 0; i < MyDT.Tables[0].Rows.Count; i++)
            {
                ListItem MyItem = new ListItem();
                MyItem.Text = MyDT.Tables[0].Rows[i][TextStr].ToString();
                MyItem.Value = MyDT.Tables[0].Rows[i][ValueStr].ToString();
                MyDDL.Items.Add(MyItem);
            } 
        }
        //�󶨵�DropDownList���趨Text��value��ʾ
        public static void BindItemList(string SqlString, ListBox MyDDL, string TextStr, string ValueStr)
        {            
            MyDDL.Items.Clear();
            DataSet MyDT = GetDataSet(SqlString);
            for (int i = 0; i < MyDT.Tables[0].Rows.Count; i++)
            {
                ListItem MyItem = new ListItem();
                MyItem.Text = MyDT.Tables[0].Rows[i][TextStr].ToString();
                MyItem.Value = MyDT.Tables[0].Rows[i][ValueStr].ToString();
                MyDDL.Items.Add(MyItem);
            } 
        }
        //�󶨵�DropDownList���趨Text��value��ʾ
        public static void BindDropDownListAddEmpty(string SqlString, DropDownList MyDDL, string TextStr, string ValueStr)
        {            
            MyDDL.Items.Clear();
            ListItem MyItem1 = new ListItem();
            MyItem1.Text = "";
            MyItem1.Value = "0";
            MyDDL.Items.Add(MyItem1);
            DataSet MyDT = GetDataSet(SqlString);
            for (int i = 0; i < MyDT.Tables[0].Rows.Count; i++)
            {
                ListItem MyItem = new ListItem();
                MyItem.Text = MyDT.Tables[0].Rows[i][TextStr].ToString();
                MyItem.Value = MyDT.Tables[0].Rows[i][ValueStr].ToString();
                MyDDL.Items.Add(MyItem);
            } 
        }
        //����һ���� | �ָ����ַ���
        public static string GetStringList(string SqlString)
        {
            string ReturnStr = string.Empty;
            DataSet MyDT = GetDataSet(SqlString);
            for (int i = 0; i < MyDT.Tables[0].Rows.Count; i++)
            {
                if (ReturnStr.Length > 0)
                {
                    ReturnStr = ReturnStr + "|" + MyDT.Tables[0].Rows[i][0].ToString();
                }
                else
                {
                    ReturnStr = MyDT.Tables[0].Rows[i][0].ToString();
                }
            }            
            return ReturnStr;
        }
        //���ص�ǰ������ֵ
        public static int GetMaxID(string FieldName, string TableName)
        {
            int MyReturn = 0;
            DataSet MyDT = GetDataSet("select max(" + FieldName + ") from " + TableName);
            if (MyDT.Tables[0].Rows.Count>0)
            {
                MyReturn = int.Parse(MyDT.Tables[0].Rows[0][0].ToString());
            }            
            return MyReturn;
        }
        //�ж���Sql��ѯ�������Ƿ����,true��ʾ���ڣ�False��ʾ������
        public static bool Exists(string strSql)
        {
            object obj = DbHelperSQL.GetSingle(strSql);
            int cmdresult;
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool Exists(string strSql, params SqlParameter[] cmdParms)
        {
            object obj = DbHelperSQL.GetSingle(strSql, cmdParms);
            int cmdresult;
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //����SqlDataReader���ݼ�,ʹ�����ǵùر�SqlDataReader
        //public static SqlDataReader GetDataReader(string SqlString)
        //{
        //    try
        //    {
        //        Open();
        //        SqlCommand cmd = new SqlCommand(SqlString, Connection);
        //        return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        //    }
        //    catch (System.Data.SqlClient.SqlException ex)
        //    {                
        //        //throw new Exception(ex.Message);
        //        return null; 
        //    }
        //}
        // ���з�������ȡ���ݣ�����һ��DataSet��    
        public static DataSet GetDataSet(string SqlString)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(SqlString, connection))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        try
                        {
                            da.Fill(ds, "ds");
                            cmd.Parameters.Clear();
                        }
                        catch (System.Data.SqlClient.SqlException ex)
                        {
                            throw new Exception(ex.Message);
                        }
                        connection.Close();
                        return ds;
                    }
                }                
            }
        }
        // ���з�������ȡ���ݣ�����һ��DataTable��    
        public static DataTable GetDataTable(string SqlString)
        {
            DataSet dataset = GetDataSet(SqlString);
            return dataset.Tables[0];
        }
        // ���з�������ȡ���ݣ������������С�    
        public static string GetSHSL(string SqlString)
        {
            DataSet dataset = GetDataSet(SqlString);
            if (dataset.Tables[0].Rows.Count > 0)
            {
                return Convert.ToString(dataset.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return "";
            }
        }
        // ���з�������ȡ���ݣ������������е�INTֵ��    
        public static string GetSHSLInt(string SqlString)
        {
            DataSet dataset = GetDataSet(SqlString);
            if (dataset.Tables[0].Rows.Count > 0)
            {
                return Convert.ToString(dataset.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return "0";
            }
        }
        // ���з�������ȡ���ݣ�����һ��DataRow��
        public static DataRow GetDataRow(string SqlString)
        {
            DataSet dataset = GetDataSet(SqlString);
            if (dataset.Tables[0].Rows.Count > 0)
            {
                return dataset.Tables[0].Rows[0];
            }
            else
            {
                return null;
            }
        }        
        // ���з�����ִ��Sql��䡣��Update��Insert��DeleteΪӰ�쵽���������������Ϊ-1
        public static int ExecuteSQL(String SqlString, Hashtable MyHashTb)
        {
            int count = -1;
            SqlConnection connectiontemp = new SqlConnection(ConnectionString);
            connectiontemp.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(SqlString, connectiontemp);
                foreach (DictionaryEntry item in MyHashTb)
                {
                    string[] CanShu = item.Key.ToString().Split('|');
                    if (CanShu[1].ToString().Trim() == "string")
                    {
                        cmd.Parameters.Add(CanShu[0], SqlDbType.VarChar);
                    }
                    else if (CanShu[1].ToString().Trim() == "int")
                    {
                        cmd.Parameters.Add(CanShu[0], SqlDbType.Int);
                    }
                    else if (CanShu[1].ToString().Trim() == "text")
                    {
                        cmd.Parameters.Add(CanShu[0], SqlDbType.Text);
                    }
                    else if (CanShu[1].ToString().Trim() == "datetime")
                    {
                        cmd.Parameters.Add(CanShu[0], SqlDbType.DateTime);
                    }
                    else
                    {
                        cmd.Parameters.Add(CanShu[0], SqlDbType.VarChar);
                    }
                    cmd.Parameters[CanShu[0]].Value = item.Value.ToString();
                }
                count = cmd.ExecuteNonQuery();
            }
            catch
            {
                count = -1;
            }
            finally
            {
                connectiontemp.Close();
            }
            return count;
        }
        // ���з�����ִ��Sql��䡣��Update��Insert��DeleteΪӰ�쵽���������������Ϊ-1
        public static int ExecuteSQL(String SqlString)
        {
            int count = -1;
            SqlConnection connectionTemp = new SqlConnection(ConnectionString);
            connectionTemp.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(SqlString, connectionTemp);
                count = cmd.ExecuteNonQuery();
            }
            catch
            {
                count = -1;
            }
            finally
            {
                connectionTemp.Close();
            }
            return count;
        }
        // ���з�����ִ��һ��Sql��䡣�����Ƿ�ɹ�,����������������쳣ʱ�ع�����
        public static bool ExecuteSQL(string[] SqlStrings)
        {
            bool success = true;
            SqlConnection connectionTemp = new SqlConnection(ConnectionString);
            connectionTemp.Open();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction trans = Connection.BeginTransaction();
            cmd.Connection = connectionTemp;
            cmd.Transaction = trans;
            try
            {
                foreach (string str in SqlStrings)
                {
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                }
                trans.Commit();
            }
            catch
            {
                success = false;
                trans.Rollback();
            }
            finally
            {
                connectionTemp.Close();
            }
            return success;
        }        
        // ִ��һ�������ѯ�����䣬���ز�ѯ�����object����        
        public static object GetSingle(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        object obj = cmd.ExecuteScalar();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            connection.Close();
                            return null;
                        }
                        else
                        {
                            connection.Close();
                            return obj;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        return null;
                        //throw e;
                    }
                }
            }
        }
        public static object GetSingle(string SQLString, int Times)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        cmd.CommandTimeout = Times;
                        object obj = cmd.ExecuteScalar();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            connection.Close();
                            return null;
                        }
                        else
                        {
                            connection.Close();
                            return obj;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        //throw e;
                        return null;
                    }
                }
            }
        }
        public static object GetSingle(string SQLString, params SqlParameter[] cmdParms)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        object obj = cmd.ExecuteScalar();
                        cmd.Parameters.Clear();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            connection.Close();
                            return null;
                        }
                        else
                        {
                            connection.Close();
                            return obj;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        //throw e;
                        return null;
                    }
                }
            }
        }
        // ִ��SQL��䣬����Ӱ��ļ�¼��
        public static int ExecuteSql(string SQLString, params SqlParameter[] cmdParms)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        int rows = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        connection.Close();
                        return rows;
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        //throw e;
                        return 0;
                    }
                }
            }
        }
        //ִ�в�ѯ��䣬����DataSet
        public static DataSet Query(string SQLString, params SqlParameter[] cmdParms)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    try
                    {
                        da.Fill(ds, "ds");
                        cmd.Parameters.Clear();

                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        //throw new Exception(ex.Message);
                    }
                    connection.Close();
                    return ds;
                }
            }
        }
        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, string cmdText, SqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;//cmdType;
            if (cmdParms != null)
            {


                foreach (SqlParameter parameter in cmdParms)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parameter);
                }
            }
        }


        public static DataTable GetPage(string DBName, string selFields, string OrderBy, string indexfields, string strWhere, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {
            if (DBName == "")
            {
                RecordCount = 0;
                PageCount = 0;
                return null;
            }
            if (selFields == "")
            {
                selFields = "*";
            }
            if (indexfields == "")
            {
                indexfields = "id";
            }


            string AllFields = selFields;
            string Condition = " " + DBName + " ";
            if (strWhere != "" && strWhere != "#0")
            {
                Condition += " where " + strWhere;
            }
            string IndexField = indexfields;
            string OrderFields = " ";

            if (OrderBy != "")
            {
                OrderFields = " order by " + OrderBy + " ";
            }

            return DbHelperSQL.ExecutePage(AllFields, Condition, IndexField, OrderFields, PageIndex, PageSize, out RecordCount, out PageCount, null);

        }
        public static DataTable ExecutePage(string SqlAllFields, string SqlTablesAndWhere, string IndexField, string OrderFields, int PageIndex, int PageSize, out int RecordCount, out int PageCount, params DbParameter[] commandParameters)
        {

            //ConnectionString

            return ExecutePage(ConnectionString, SqlAllFields, SqlTablesAndWhere, IndexField, OrderFields, PageIndex, PageSize, out  RecordCount, out  PageCount, commandParameters);
        }

        public static DataTable ExecutePage(string connectionString, string SqlAllFields, string SqlTablesAndWhere, string IndexField, string OrderFields, int PageIndex, int PageSize, out int RecordCount, out int PageCount, params DbParameter[] commandParameters)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                return ExecutePage(connection, SqlAllFields, SqlTablesAndWhere, IndexField, OrderFields, PageIndex, PageSize, out RecordCount, out PageCount, commandParameters);
            }
        }
        public static DataTable ExecutePage(DbConnection connection, string SqlAllFields, string SqlTablesAndWhere, string IndexField, string OrderFields, int PageIndex, int PageSize, out int RecordCount, out int PageCount, params DbParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, connection, null, CommandType.Text, "", commandParameters);
            string Sql = GetPageSql(connection, cmd, SqlAllFields, SqlTablesAndWhere, IndexField, OrderFields, PageIndex, PageSize, out  RecordCount, out  PageCount);
            cmd.CommandText = Sql;
            SqlDataAdapter ap = new SqlDataAdapter();
            ap.SelectCommand = cmd;
            DataSet st = new DataSet();
            ap.Fill(st, "PageResult");
            cmd.Parameters.Clear();
            return st.Tables["PageResult"];
        }
        private static void PrepareCommand(DbCommand cmd, DbConnection conn, DbTransaction trans, CommandType cmdType, string cmdText, DbParameter[] cmdParms)
        {

            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            if (trans != null)
                cmd.Transaction = trans;

            cmd.CommandType = cmdType;
            cmd.CommandTimeout = 30;
            if (cmdParms != null)
            {
                foreach (DbParameter parm in cmdParms)
                    if (parm != null)
                        cmd.Parameters.Add(parm);
            }
        }

        /// <summary>
        /// ȡ�÷�ҳ��SQL���
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cmd"></param>
        /// <param name="SqlAllFields"></param>
        /// <param name="SqlTablesAndWhere"></param>
        /// <param name="IndexField"></param>
        /// <param name="OrderFields"></param>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="RecordCount"></param>
        /// <param name="PageCount"></param>
        /// <returns></returns>
        private static string GetPageSql(DbConnection connection, DbCommand cmd, string SqlAllFields, string SqlTablesAndWhere, string IndexField, string OrderFields, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {
            RecordCount = 0;
            PageCount = 0;
            if (PageSize <= 0)
            {
                PageSize = 10;
            }
            string SqlCount = "select count(" + IndexField + ") from " + SqlTablesAndWhere;
            cmd.CommandText = SqlCount;
            RecordCount = (int)cmd.ExecuteScalar();
            if (RecordCount % PageSize == 0)
            {
                PageCount = RecordCount / PageSize;
            }
            else
            {
                PageCount = RecordCount / PageSize + 1;
            }
            if (PageIndex > PageCount)
                PageIndex = PageCount;
            if (PageIndex < 1)
                PageIndex = 1;
            string Sql = null;
            if (PageIndex == 1)
            {
                Sql = "select top " + PageSize + " " + SqlAllFields + " from " + SqlTablesAndWhere + " " + OrderFields;
            }
            else
            {
                Sql = "select top " + PageSize + " " + SqlAllFields + " from ";
                if (SqlTablesAndWhere.ToLower().IndexOf(" where ") > 0)
                {
                    string _where = Regex.Replace(SqlTablesAndWhere, @"\ where\ ", " where (", RegexOptions.IgnoreCase | RegexOptions.Compiled);
                    Sql += _where + ") and (";
                }
                else
                {
                    Sql += SqlTablesAndWhere + " where (";
                }
                Sql += IndexField + " not in (select top " + (PageIndex - 1) * PageSize + " " + IndexField + " from " + SqlTablesAndWhere + " " + OrderFields;
                Sql += ")) " + OrderFields;
            }
            return Sql;
        }


    }
}