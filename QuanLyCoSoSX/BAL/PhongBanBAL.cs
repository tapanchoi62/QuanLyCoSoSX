﻿
using QuanLyCoSoSX.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoSoSX.BAL
{
    public class PhongBanBAL
    {
        public List<PhongBan> GetAll(MySqlConnection conn)
        {
            conn.Open();

            string sql = "SELECT * FROM phongban";

            var cmd = new MySqlCommand(sql, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();
            List<PhongBan> list = new List<PhongBan>();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    PhongBan a = new PhongBan();
                    a.Mapb = rdr.GetString("mapb");
                    a.Tenpb = rdr.GetString("tenpb");
                
                    list.Add(a);
                }
            }
            conn.Close();
            return list;
        }
        public PhongBan GetByID(MySqlConnection conn, string id)
        {
            conn.Open();
            PhongBan a = new PhongBan();
            string sql = "SELECT * FROM phongban where mapb= @id";

            var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    a.Mapb = rdr.GetString("mapb");
                    a.Tenpb = rdr.GetString("tenpb");

                }
            }
            conn.Close();
            return a;
        }
        public PhongBan GetByName(MySqlConnection conn, string tenpb)
        {
            conn.Open();
            PhongBan a = new PhongBan();
            string sql = "SELECT * FROM phongban where tenpb= @tenpb";

            var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@tenpb", tenpb);

            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    a.Mapb = rdr.GetString("mapb");
                    a.Tenpb = rdr.GetString("tenpb");

                }
            }
            conn.Close();
            return a;
        }

        public void Insert(MySqlConnection conn, string mapb, string tenpb)
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO `phongban` (`mapb`, `tenpb`) VALUES (@mapb,@tenpb);";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@mapb", mapb);
                cmd.Parameters.AddWithValue("@tenpb", tenpb);
                
                cmd.Prepare();

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That bai," + ex.Message);
            }




        }

        public void Update(MySqlConnection conn, string mapb, string tenpb)
        {
            try
            {
                conn.Open();
                string sql = "Update `phongban` Set `tenpb`=@tenpb where mapb =@mapb;";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@mapb", mapb);
                cmd.Parameters.AddWithValue("@tenpb", tenpb);




                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That bai," + ex.Message);
            }
        }

        public void Delete(MySqlConnection conn, string mapb)
        {
            try
            {
                conn.Open();
                string sql = "Delete from phongban where mapb= @mapb";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@mapb", mapb);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That bai," + ex.Message);
            }
        }

    }
}
