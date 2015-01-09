
/**
 * @author : agus-susanto
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SII //Namespace disesuaikan dengan nama projectnya, biar gampang waktu dipanggil
{
    class Koneksi
    {
        public MySqlConnection _koneksi = new MySqlConnection();

        public void inisialisasi() //Digunakan untuk inisialisasi koneksi (instantiate new mysql connection)
        {
            string strConnString = "SERVER=localhost;DATABASE=wsh;UID=root;PWD=katiasa;"; //Sesuaikan dengan IP, username, password dan nama databasenya
            _koneksi = new MySqlConnection(strConnString);
        }

        public bool bukaKoneksi() //Digunakan untuk membuka koneksi yg sebelumnya sudah di inisialisasi
        {
            try
            {
                _koneksi.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool TutupKoneksi() //Digunakan untuk menutup koneksi
        {
            try
            {
                _koneksi.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
