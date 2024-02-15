using CRM_DAL.Database;
using CRM_DAL.DTO.User_DTO;
using CRM_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_DAL.Services
{
    public  class UserData
    {
        private readonly CoderContext _coderContext;

        public UserData()
        {
            _coderContext = new CoderContext();
        }

        //Metodos:
        //Obtenerusuario
        //listarusuario
        //crearusuario
        //modificarusuario
        //eliminarusuario

        public async Task<bool> CreateAccountUser(UserWriteDTO UserWrite)
        {
            try
            {
                Userr newUser = new Userr();

                newUser.Names = UserWrite.Names;
                newUser.LastNames = UserWrite.LastNames;
                newUser.UserNames = UserWrite.UserNames;
                newUser.Emails = UserWrite.Emails;
                newUser.Passwords = UserWrite.Passwords;

                _coderContext.Userrs.Add(newUser);
                await _coderContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

         


    }
}
