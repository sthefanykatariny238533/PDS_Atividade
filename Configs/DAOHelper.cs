
using System;
using MySql.Data.MySqlClient;

namespace AppWebExemplo.Configs
{
    public static class DAOHelper
    {
        public static string GetString(
            MySqlDataReader reader, string column_name)
        {
            string text = string.Empty;

            if (!reader.IsDBNull(reader.GetOrdinal(column_name)))
                text = reader.GetString(column_name);

            return text;
        }

        // Se a coluna for NULL, devolve 0.0
        public static double GetDouble(
            MySqlDataReader reader, string column_name)
        {
            double value = 0.0;

            if (!reader.IsDBNull(reader.GetOrdinal(column_name)))
                value = reader.GetDouble(column_name);

            return value;
        }

        // Se a coluna for NULL, devolve null
        public static DateTime? GetDateTime(
            MySqlDataReader reader, string column_name)
        {
            DateTime? value = null;

            if (!reader.IsDBNull(reader.GetOrdinal(column_name)))
                value = reader.GetDateTime(column_name);

            return value;
        }

        // Verifica se a coluna é NULL
        public static bool IsNull(
            MySqlDataReader reader, string column_name)
        {
            return reader.IsDBNull(reader.GetOrdinal(column_name));
        }
    }
}
