using XIIRPL2_26_Ticketing.MasterForm;

namespace XIIRPL2_26_Ticketing
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
            //FrmMasterBandara bandara = new FrmMasterBandara();
            //bandara.Show();

            //FrmMasterMaskapai maskapai = new FrmMasterMaskapai();
            //maskapai.Show();
            //FrmMasterKodePromo kodePromo = new FrmMasterKodePromo();
            //kodePromo.Show();

            FrmMasterJadwalPenerbangan  jadwalPenerbangan = new FrmMasterJadwalPenerbangan();
            jadwalPenerbangan.Show();   

            Application.Run();
        }
    }
}