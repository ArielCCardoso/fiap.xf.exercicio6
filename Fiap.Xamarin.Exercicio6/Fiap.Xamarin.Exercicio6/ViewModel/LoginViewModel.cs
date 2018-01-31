using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Fiap.Xamarin.Exercicio6.Model;

namespace Fiap.Xamarin.Exercicio6.ViewModel
{
    public class LoginViewModel
    {
        //public bool isValid;
        string userLogin, userSenha, userXML;
        public bool ValidaLogin(Login _login)
        {

            XElement users = XElement.Load("https://mbafiap11net.blob.core.windows.net/xamarin/Users.xml");

            //var selected = from user in users.Elements("User")
            //               where user.Element("login").Value == _login.login.ToString()
            //               select user;

            //System.Console.WriteLine("Selected:");
            //foreach (var d in selected)
            //    Console.WriteLine("{0}", d.ToString());

            //System.Console.WriteLine("\nitems:");
            //foreach (var d in selected)
            //{
            //    Console.WriteLine("id: {0}", d.Element("ID"));
            //}
            //Console.WriteLine("{0}", selected.ToString());
            var selected = from user in users.Elements("User")
                                            where (string)user.Element("login").Value == "admin"
                                            select user;

            userXML = selected.ToString();
            userLogin = selected.Elements("login").ToString();
            userSenha = selected.Elements("senha").ToString();

            if (selected.Elements("senha").ToString() == "admin")
            { return true; }
            else
            { return false; }

        }



    }
}
