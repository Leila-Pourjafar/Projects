
namespace Infrastructure
{
    public static class Utility
    {
        static Utility()
        {
        }

        public static Models.User AuthenticatedUser { get; set; }

        #region RegisterForm
        private static MyApplication.RegisterForm registerForm;

        /// <summary>
        /// RegisterForm
        /// </summary>
        public static MyApplication.RegisterForm RegisterForm
        {
            get
            {
                if (registerForm == null || registerForm.IsDisposed)
                {
                    registerForm = new MyApplication.RegisterForm();
                }

                return registerForm;
            }

        }
        #endregion /RegisterForm

        #region LoginForm
        private static MyApplication.LoginForm loginForm;

        /// <summary>
        /// LoginForm
        /// </summary>
        public static MyApplication.LoginForm LoginForm
        {
            get
            {
                if (loginForm == null || loginForm.IsDisposed)
                {
                    loginForm = new MyApplication.LoginForm();
                }

                return loginForm;
            }
        }
        #endregion /LoginForm

        #region MainForm
        private static MyApplication.MainForm mainForm;

        /// <summary>
        ///  MainForm
        /// </summary>
        public static MyApplication.MainForm MainForm
        {
            get
            {
                if (mainForm == null || mainForm.IsDisposed)
                {
                    mainForm = new MyApplication.MainForm();
                }
                return mainForm;
            }
        }
        #endregion /MainForm
    }
}
