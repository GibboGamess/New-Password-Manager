using System;
using System.Reflection.Metadata;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PasswordManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form5());

        }
    }

    








}