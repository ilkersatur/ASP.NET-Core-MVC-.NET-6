using System.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class UrunDB
    {
        string strConn = "Data Source=SUNUM1\\MSSQLSERVER2014;Initial Catalog =ProductDB;User ID = sa; Password = 1230";
        public List<Urun> TumUrunler()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Uruns",conn);

            SqlDataReader dr = cmd.ExecuteReader();
            List<Urun> urunler = new List<Urun>();

            while (dr.Read())
            {
                Urun urun = new Urun();
                urun.UrunID = dr.GetInt32(0);
                urun.UrunAdi = dr.GetString(1);
                urun.KategoriID = dr.GetInt32(2);
                urun.Fiyat = dr.GetDecimal(3);
                urunler.Add(urun);
            }
            conn.Close();
            return urunler;
        }
        public List<Kategori> TumKategoriler()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Kategoris", conn);

            SqlDataReader dr = cmd.ExecuteReader();
            List<Kategori> kategoriler = new List<Kategori>();

            while (dr.Read())
            {
                Kategori kategori = new Kategori();
                kategori.KategoriID = dr.GetInt32(0);
                kategori.KategoriAdi = dr[1].ToString();
                kategoriler.Add(kategori);
            }
            conn.Close();
            return kategoriler;
        }

        public void UrunEkle(Urun urun)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO URUNS VALUES(@ad,@katID,@fiyat)", conn);

            cmd.Parameters.AddWithValue("@ad",urun.UrunAdi);
            cmd.Parameters.AddWithValue("@katID",urun.KategoriID);
            cmd.Parameters.AddWithValue("@fiyat",urun.Fiyat);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
