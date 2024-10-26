﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PhamThuyHang_T7
{
    internal class HeThong
    {
        public static string Hash(string text)
        {
            SHA1Managed sha1 = new SHA1Managed();
            byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder hashSb = new StringBuilder();
            foreach (byte b in hash)
                hashSb.Append(b.ToString("X2"));
            return hashSb.ToString();
        }
    }
    public class Khoa
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
    }

}
