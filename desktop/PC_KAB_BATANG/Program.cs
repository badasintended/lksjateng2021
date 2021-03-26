using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PC_KAB_BATANG.Forms;
using PC_KAB_BATANG.DB;
using System.Security.Cryptography;

namespace PC_KAB_BATANG {
    public static class Program {

        public static readonly DBEntities Entities = new DBEntities();
        public static readonly SHA256 Sha256 = SHA256Managed.Create();

        public static Employee Employee = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
