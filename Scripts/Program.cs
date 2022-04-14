using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityProj.Data;
using EntityProj.Forms;
using Microsoft.EntityFrameworkCore;

namespace EntityProj.Scripts
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var options = new DbContextOptionsBuilder<ContractsContext>()
                .UseSqlite(@"Filename=C:\Users\rekketio\source\repos\EntityProj\Data\AutoShow.db")
                .Options;
            var db = new ContractsContext(options);
            db.Database.EnsureCreated();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm form = new MainForm();
            form.Show();
            Application.Run();
        }
    }
}
