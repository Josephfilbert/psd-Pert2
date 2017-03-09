using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertemuan_2_PSD
{
    public class Barang
    {
        string nama;
        int harga;

        //Use property instead of getter and setter
        
        public string Nama
        {
            get { return nama; }
            set
            {
                if (value.Trim() == string.Empty)
                    throw new InvalidOperationException("Item name should not be empty");
                else
                    nama = value;
            }
        }

        public int Harga
        {
            get { return harga; }
            set
            {
                if (value < 0)
                    throw new InvalidOperationException("Item price cannot be negative");
                else
                    harga = value;
            }
        }

        public Barang(string _nama, int _harga)
        {
            Nama = _nama;
            Harga = _harga;
        }

    }
}