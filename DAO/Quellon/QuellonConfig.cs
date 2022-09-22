using HBSIS.Core.Quellon.DAO;
using Quellon.Utility;
using System;

namespace Fiscalizacao.Quellon
{
    public class QuellonConfig
    {
        static QuellonConfig _instancia;
        public static QuellonConfig Instancia
        {
            get { return _instancia ?? (_instancia = new QuellonConfig()); }
        }
        private QuellonConfig()
        {
            _Login = new Login();
        }
        private Login _Login;
        public string Basepath { get; set; }
        private string User { get; set; }
        private string Pass { get; set; }
        public string Caller { get; set; }

        public string Login(string Basepath, string User, string Pass)
        {
            try
            {
                this.Pass = Pass;
                this.User = User;
                this.Basepath = Basepath;

                _Login.SetBasePathUrl(Basepath);

                if (string.IsNullOrEmpty(_Login.UserLogged(Caller)))
                    Caller = _Login.SignIn(User, Pass);
            }
            catch (Exception error)
            {
                throw new Exception("ERRO AO TENTAR REALIZAR LOGIN: " + error.Message);
            }
            return Caller;
        }

        public IXMLMaker Consulta(string @interface)
        {
            return new XMLMakerWrapper(@interface, this.Basepath, this.Caller, false);
        }
    }
}
