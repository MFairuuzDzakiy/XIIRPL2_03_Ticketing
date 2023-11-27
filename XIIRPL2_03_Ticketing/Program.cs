using XIIRPL2_03_Ticketing.MasterForm;

namespace XIIRPL2_03_Ticketing
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //FormLogin formLogin = new FormLogin();
            //formLogin.Show();
            FormMasterBandara bandara = new FormMasterBandara();
            bandara.Show();

            //FormMasterMaskapai1 maskapai = new FormMasterMaskapai1();
            //maskapai.Show();

            //FormMasterKodePromo kodePromo = new FormMasterKodePromo();
            //kodePromo.Show();

            //FormMasterJadwalPenerbangan jadwalPenerbangan = new FormMasterJadwalPenerbangan();
            //jadwalPenerbangan.Show();   
            Application.Run();
        }
    }
}