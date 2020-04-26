using System;
using System.Collections.Generic;
using System.Text;

namespace Modul5_Kel30_CSharp
{
    class userService
    {
        private string[,] data;
        private string[,] histories;
        private string email, password, roles, roles1, roles2, roles3 = "";

        public userService(string emails, string passwords)
        {
            email = emails;
            password = passwords;
            data = new string[2, 3] {
                {"gilangkelompok30@gmail.com", "12345", "superadmin" },
                {"daffakelompok30@gmail.com", "12345", "user"  }
            };
            histories = new string[2, 4]
            {
                {"gilangkelompok30@gmail.com", "Fisika Dasar", "Dasar Komputer dan Pemrograman", "26-04-2020" },
                {"daffakelompok30@gmail.com", "Dasar Komputer dan Pemrograman", "Konsep Jaringan Komputer", "26-04-2020" },
            };
        }

        public void login()
        {
            var (status, role) = checkCredentials();
            if (status == true)
            {
                Console.WriteLine("\nWelcome " + role);
                Console.WriteLine("Logged it as user email: " + email + "\n");
                Console.WriteLine(email + "meminjam buku :");
                Console.WriteLine(roles1 + "\n" + roles2);
                Console.WriteLine("Tanggal Peminjaman : " + roles3);
            }
            else
            {
                Console.WriteLine("\nInvalid Login");
            }
        }
        private (bool, string) checkCredentials()
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 0] == email && data[i, 1] == password)
                {
                    roles = data[i, 2];
                    roles1 = histories[i, 1];
                    roles2 = histories[i, 2];
                    roles3 = histories[i, 3];

                    return (true, roles);
                }
            }
            return (false, roles);
        }
    }
}

