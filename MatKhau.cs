using System;
using System.Security.Cryptography;

namespace GiaoDien_3Form 
{
    public static class MatKhau
    {
        private const int VONG_LAP = 600_000;

        public static (string Salt, string Bam) Tao(string matKhau)
        {
            //Được gọi khi tạo tài khoản mới hoặc đổi mật khẩu.
            byte[] salt = RandomNumberGenerator.GetBytes(16); 
            //Salt đảm bảo cho những người dùng có mật khẩu giống nhau nhưng vẫn sẽ sinh ra các chuỗi băm khác biệt. 
            byte[] bam = Rfc2898DeriveBytes.Pbkdf2(matKhau, salt, VONG_LAP, HashAlgorithmName.SHA256, 32); 
            return (Convert.ToBase64String(salt), Convert.ToBase64String(bam)); 
        }

        public static bool KiemTra(string matKhau, string saltLuu, string bamLuu)
        {
            //Được gọi khi người dùng nhập mật khẩu để đăng nhập hệ thống.
            byte[] salt = Convert.FromBase64String(saltLuu); 
            byte[] bamCu = Convert.FromBase64String(bamLuu);
            byte[] bamMoi = Rfc2898DeriveBytes.Pbkdf2(matKhau, salt, VONG_LAP, HashAlgorithmName.SHA256, 32);

            // Sử dụng FixedTimeEquals để chống rò rỉ thông tin qua thời gian thực thi
            //Nếu như người dùng nhập đúng mật khẩu, bamMoi tính ra sẽ trùng khớp 100 % với bamCu.
            return CryptographicOperations.FixedTimeEquals(bamCu, bamMoi); 
        }
    }
}