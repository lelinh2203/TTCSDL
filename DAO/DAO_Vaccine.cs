﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Vaccine : DBProvider
    {
        public DataTable getAllVaccine()
        {
            //string query = "SELECT * FROM VACCINE";
            //SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            SqlDataReader rd;
            DataTable dt = new DataTable();

            _conn.Open();
            SqlCommand cmd = new SqlCommand("sp_GetAllVaccine", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            rd = cmd.ExecuteReader();
            dt.Load(rd);
            _conn.Close();

            return dt;
        }
        
        public List<DTO_Vaccine> SearchByMaVC(string value)
        {

            List<DTO_Vaccine> list = new List<DTO_Vaccine>();
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("sp_SearchByMaVC", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Value", "%" + value + "%");

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string maVC = dataReader[0].ToString();
                    string tenVC = dataReader[1].ToString();
                    string nhaSX = dataReader[2].ToString();
                    string ngaySX = ((DateTime)dataReader[3]).ToString("dd/MM/yyyy");
                    string hanSD = ((DateTime)dataReader[4]).ToString("dd/MM/yyyy");
                    string soLo = dataReader[5].ToString();
                    int soLuongSan = int.Parse(dataReader[6].ToString());
                    int donGia = int.Parse(dataReader[7].ToString());
                    string loaiVC = dataReader[8].ToString();

                    DTO_Vaccine vaccine = new DTO_Vaccine(maVC, tenVC, nhaSX, ngaySX, hanSD, soLo, soLuongSan, donGia, loaiVC);
                    list.Add(vaccine);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _conn.Close();
            }
            return list;
        }

        public List<DTO_Vaccine> SearchByTenVC(string value)
        {

            List<DTO_Vaccine> list = new List<DTO_Vaccine>();
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("sp_SearchByTenVC", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Value", "%" + value + "%");

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string maVC = dataReader[0].ToString();
                    string tenVC = dataReader[1].ToString();
                    string nhaSX = dataReader[2].ToString();
                    string ngaySX = ((DateTime)dataReader[3]).ToString("dd/MM/yyyy");
                    string hanSD = ((DateTime)dataReader[4]).ToString("dd/MM/yyyy");
                    string soLo = dataReader[5].ToString();
                    int soLuongSan = int.Parse(dataReader[6].ToString());
                    int donGia = int.Parse(dataReader[7].ToString());
                    string loaiVC = dataReader[8].ToString();

                    DTO_Vaccine vaccine = new DTO_Vaccine(maVC, tenVC, nhaSX, ngaySX, hanSD, soLo, soLuongSan, donGia, loaiVC);
                    list.Add(vaccine);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _conn.Close();
            }
            return list;
        }

        public List<DTO_Vaccine> SearchByLoaiVC(string value)
        {

            List<DTO_Vaccine> list = new List<DTO_Vaccine>();
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("sp_SearchByLoaiVC", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Value", "%" + value + "%");

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string maVC = dataReader[0].ToString();
                    string tenVC = dataReader[1].ToString();
                    string nhaSX = dataReader[2].ToString();
                    string ngaySX = ((DateTime)dataReader[3]).ToString("dd/MM/yyyy");
                    string hanSD = ((DateTime)dataReader[4]).ToString("dd/MM/yyyy");
                    string soLo = dataReader[5].ToString();
                    int soLuongSan = int.Parse(dataReader[6].ToString());
                    int donGia = int.Parse(dataReader[7].ToString());
                    string loaiVC = dataReader[8].ToString();

                    DTO_Vaccine vaccine = new DTO_Vaccine(maVC, tenVC, nhaSX, ngaySX, hanSD, soLo, soLuongSan, donGia, loaiVC);
                    list.Add(vaccine);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _conn.Close();
            }
            return list;
        }

        public List<DTO_Vaccine> SearchByNhaSX(string value)
        {

            List<DTO_Vaccine> list = new List<DTO_Vaccine>();
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("sp_SearchByNhaSX", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Value", "%" + value + "%");

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string maVC = dataReader[0].ToString();
                    string tenVC = dataReader[1].ToString();
                    string nhaSX = dataReader[2].ToString();
                    string ngaySX = ((DateTime)dataReader[3]).ToString("dd/MM/yyyy");
                    string hanSD = ((DateTime)dataReader[4]).ToString("dd/MM/yyyy");
                    string soLo = dataReader[5].ToString();
                    int soLuongSan = int.Parse(dataReader[6].ToString());
                    int donGia = int.Parse(dataReader[7].ToString());
                    string loaiVC = dataReader[8].ToString();

                    DTO_Vaccine vaccine = new DTO_Vaccine(maVC, tenVC, nhaSX, ngaySX, hanSD, soLo, soLuongSan, donGia, loaiVC);
                    list.Add(vaccine);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _conn.Close();
            }
            return list;
        }

        public List<DTO_Vaccine> SearchAll(string value)
        {

            List<DTO_Vaccine> list = new List<DTO_Vaccine>();
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("sp_SearchAllVaccine", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Value", "%" + value + "%");

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string maVC = dataReader[0].ToString();
                    string tenVC = dataReader[1].ToString();
                    string nhaSX = dataReader[2].ToString();
                    string ngaySX = ((DateTime)dataReader[3]).ToString("dd/MM/yyyy");
                    string hanSD = ((DateTime)dataReader[4]).ToString("dd/MM/yyyy");
                    string soLo = dataReader[5].ToString();
                    int soLuongSan = int.Parse(dataReader[6].ToString());
                    int donGia = int.Parse(dataReader[7].ToString());
                    string loaiVC = dataReader[8].ToString();

                    DTO_Vaccine vaccine = new DTO_Vaccine(maVC, tenVC, nhaSX, ngaySX, hanSD, soLo, soLuongSan, donGia, loaiVC);
                    list.Add(vaccine);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _conn.Close();
            }
            return list;
        }

        public int getVCPrice(string maVC)
        {
            string query = "SELECT DONGIA FROM VACCINE WHERE MAVACCINE = @MAVACCINE";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            da.SelectCommand.Parameters.AddWithValue("@MAVACCINE", maVC);

            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return Convert.ToInt32(dt.Rows[0][0].ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
            return -1;
        }

        public string getVCName(string maVC)
        {
            string query = "SELECT TENVACCINE FROM VACCINE WHERE MAVACCINE = @MAVACCINE";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            da.SelectCommand.Parameters.AddWithValue("@MAVACCINE", maVC);

            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0][0].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        public bool IsVCInStock(string maVC)
        {
            //string query = "SELECT MAVACCINE FROM VACCINE WHERE MAVACCINE = @MAVACCINE";
            //SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            //da.SelectCommand.Parameters.AddWithValue("@MAVACCINE", maVC);

            //DataTable dt = new DataTable();

            _conn.Open();
            SqlCommand cmd = new SqlCommand("sp_IsVCInStock", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAVACCINE", maVC);

            SqlParameter retParam = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            retParam.Direction = ParameterDirection.ReturnValue;

            cmd.ExecuteNonQuery();
            _conn.Close();

            int retVal = Convert.ToInt32(retParam.Value);

            if (retVal == 1)
            {
                return true;
            }
            return false;
        }


    }
}
