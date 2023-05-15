using System;
using SmartrTools;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DALC
{
    public partial interface DALC
    {
        void ExecuteDelete(string command_text, object i_object);
        void ExecuteEdit(string command_text, object i_object, string pk = "");
        IEnumerable<IDataRecord> ExecuteSelectQuery(string command_text, object i_object);
    }
    public partial class MSSQL_DALC : IDALC
    {
        public string Connection_String { get; set; }
        public MSSQL_DALC(string i_Connection_String)
        {
            this.Connection_String = i_Connection_String;
        }
        public T Get_Data_Record_Value<T>(IDataRecord i_Row, string i_Field_Name)
        {
            int ordinal = i_Row.GetOrdinal(i_Field_Name);
            return (T)(i_Row.IsDBNull(ordinal) ? default(T) : i_Row.GetValue(ordinal));
        }
        public void ExecuteDelete(string command_text, object i_object)
        {
            Dictionary<string, object> args = new Dictionary<string, object>();
            using (SqlConnection oSqlConnection = new SqlConnection(this.Connection_String))
            {
                oSqlConnection.Open();
                using (var command = new SqlCommand(command_text, oSqlConnection))
                {
                    SqlCommand cmd = new SqlCommand(command_text, oSqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlCommandBuilder.DeriveParameters(cmd);
                    foreach (SqlParameter param in cmd.Parameters)
                    {
                        if (param.ParameterName.StartsWith("@P_"))
                        {
                            args.Add(param.ParameterName, Props.Get_Prop_Value(i_object, param.ParameterName.Replace("@P__", "")) == null ? DBNull.Value : Props.Get_Prop_Value(i_object, param.ParameterName.Replace("@P__", "")));
                        }
                    }
                    var Parameters = args.Select(x => ToConvertSqlParams(command, x.Key, x.Value)).ToArray();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(Parameters);
                    command.ExecuteNonQuery();
                }
                oSqlConnection.Close();
            }
        }
        public void ExecuteEdit(string command_text, object i_object, string pk = "")
        {
            Dictionary<string, object> args = new Dictionary<string, object>();
            using (SqlConnection oSqlConnection = new SqlConnection(this.Connection_String))
            {
                oSqlConnection.Open();
                using (var command = new SqlCommand(command_text, oSqlConnection))
                {
                    SqlCommand cmd = new SqlCommand(command_text, oSqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlCommandBuilder.DeriveParameters(cmd);
                    foreach (SqlParameter param in cmd.Parameters)
                    {
                        if (param.ParameterName.StartsWith("@P__"))
                        {
                            args.Add(param.ParameterName, Props.Get_Prop_Value(i_object, param.ParameterName.Replace("@P__", "")) == null ? DBNull.Value : Props.Get_Prop_Value(i_object, param.ParameterName.Replace("@P__", "")));
                        }
                    }
                    var Parameters = args.Select(x => ToConvertSqlParams(command, x.Key, x.Value, x.Key == string.Format("@P__{0}", pk) ? ParameterDirection.InputOutput : ParameterDirection.Input)).ToArray();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(Parameters);
                    command.ExecuteNonQuery();
                    if (!pk.IsEmptyString())
                    {
                        Props.Set_Prop_Value(i_object, pk, command.Parameters[command.Parameters.IndexOf(string.Format("@P__{0}", pk.ToUpper()))].Value);
                    }
                }
                oSqlConnection.Close();
            }
        }
        public IEnumerable<IDataRecord> ExecuteSelectQuery(string command_text, object i_object)
        {
            Dictionary<string, object> args = new Dictionary<string, object>();
            using (SqlConnection oSqlConnection = new SqlConnection(this.Connection_String))
            {
                oSqlConnection.Open();
                using (var command = new SqlCommand(command_text, oSqlConnection))
                {
                    SqlCommand cmd = new SqlCommand(command_text, oSqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlCommandBuilder.DeriveParameters(cmd);
                    foreach (SqlParameter param in cmd.Parameters)
                    {
                        if (param.ParameterName.StartsWith("@P__"))
                        {
                            var x = ((IDictionary<string, object>)i_object)[param.ParameterName.Replace("@P__", "")] == null ? DBNull.Value : ((IDictionary<string, object>)i_object)[param.ParameterName.Replace("@P__", "")];
                            args.Add(param.ParameterName, x);
                        }
                    }
                    var Parameters = args.Select(x => ToConvertSqlParams(command, x.Key, x.Value, cmd.Parameters[x.Key].Direction)).ToArray();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(Parameters);
                    using (var reader = command.ExecuteReader())
                    {
                        foreach (IDataRecord record in reader)
                        {
                            yield return record;
                        }
                    }
                    foreach (SqlParameter param in cmd.Parameters)
                    {
                        if ((param.Direction == ParameterDirection.InputOutput) || (param.Direction == ParameterDirection.Output))
                        {
                            ((IDictionary<string, object>)i_object)[param.ParameterName.Replace("@P__", "")] = command.Parameters[param.ParameterName].Value;
                        }
                    }
                }
                oSqlConnection.Close();
            }
        }
        public static SqlParameter ToConvertSqlParams(SqlCommand command, string name, object value, ParameterDirection pd = ParameterDirection.Input)
        {
            var param = command.CreateParameter();
            param.Value = value;
            param.Direction = pd;
            param.ParameterName = name;
            if (param.Direction == ParameterDirection.Output || param.Direction == ParameterDirection.InputOutput)
            {
                if (param.SqlDbType == SqlDbType.NVarChar)
                {
                    param.Size = -1;
                }
            }
            return param;
        }
    }
}