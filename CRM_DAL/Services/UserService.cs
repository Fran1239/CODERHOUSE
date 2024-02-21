using CRM_DAL.Database;
using CRM_DAL.DTO.User_DTO;
using CRM_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CRM_DAL.Services
{
    public  class UserService
    {
        private readonly CoderContext _coderContext;

        public UserService()
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

        public async Task<bool> LogInUser(UserRequestDTO UserRequest)
        {
            try
            {
                var result = await _coderContext.Userrs.FirstAsync(u => u.UserNames == UserRequest.UserNames && u.Passwords == UserRequest.Passwords);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }
}
