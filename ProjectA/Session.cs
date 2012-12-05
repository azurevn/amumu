using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoAnB
{
    public static class Session
    {
        private static int ID;
        private static String Name;
        private static String username;
        private static String session;

        public static void set(int Ma, String Ten, String TaiKhoan)
        {
            ID = Ma;
            Name = Ten;
            username = TaiKhoan;
        }

        public static int _EmployeeId
        {
            get { return ID; }
            set { ID = value; }
        }

        public static String _EmployeeName
        {
            get { return Name; }
            set { Name = value; }
        }

        public static String _Username
        {
            get { return username; }
            set { username = value; }
        }

        public static String _Session
        {
            get
            {
                return session;
            }
            set { session = username; }
        }
    }
}
