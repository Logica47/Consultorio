using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Consultorio.Models;


namespace Consultorio.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult Registration()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration([Bind(Exclude = "CodigoActivacion,VerificarCorreo")]Usuario user)
        {

           // bool Status = false;
            string message = "";

            //validar correo
            if (ModelState.IsValid)
            {
                //Email ya existe
                var isExist = IsEmailExist(usuario.emailID);
                if (isExist)
                {
                    ModelState.AddModelError("EmailExist", "El correo ya existe");
                }return View(user);

               
                //Hash
                #region Hash Contrase?a
                user.Contraseña = crypto.Hash(user.Contraseña);

                #endregion

                #region Guardar en Db
                using (dbloginEntities dc = new dbloginEntities())
                {
                    dc.Usuarios.Add(user);
                    dc.SaveChanges();
                }

                #endregion
            }


            else
            {
                message = "Solicitud Invalidad";
            }

            return View(user);
        }
        //salir
        [NonAction]
        public bool  IsEmailExist(string emailID)
        {
            using (dbloginEntities dc = new dbloginEntities())
            {
                var v = dc.Usuarios.Where(a => a.Correo == emailID).FirstOrDefault();
                return v != null;
            }
        }
        [NonAction]
        public void SendVerificationLinkEmail(string correo, string activacionCode)
        {

        }

    }
}