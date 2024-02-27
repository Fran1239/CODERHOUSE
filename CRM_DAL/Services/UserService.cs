using CRM_DAL.Database;
using CRM_DAL.DTO.User_DTO;
using CRM_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CRM_DAL.Services
{
    public  class UserService
    {
        private readonly CoderContext _coderContext;
        private const string Colacion = "SQL_Latin1_General_CP1_CI_AI";
        public UserService()
        {
            _coderContext = new CoderContext();
        }

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

        public async Task<IEnumerable<Userr>> GetUsers(string? useridentification)
        {
            try
            {
                if (useridentification == null)
                {
                    var users = await _coderContext.Userrs.ToListAsync();
                    return users;
                }
                else
                {
                    var result = await _coderContext.Userrs
                          .Where(u =>
                              u.UserNames != null && EF.Functions.Collate(u.UserNames, Colacion).Contains(useridentification) ||
                              u.Names != null && EF.Functions.Collate(u.Names, Colacion).Contains(useridentification) ||
                              u.LastNames != null && EF.Functions.Collate(u.LastNames, Colacion).Contains(useridentification) ||
                              u.Emails != null && EF.Functions.Collate(u.Emails, Colacion).Contains(useridentification))
                          .ToListAsync();
                    if (result == null)
                    {
                        var users = await _coderContext.Userrs.ToListAsync();
                        return users;
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> IsUsernameTaken(string username)
        {
            try
            {
                var existingUser = await _coderContext.Userrs.FirstOrDefaultAsync(u => u.UserNames == username);
                return existingUser != null;
            }
            catch (Exception ex)
            {
                return true;
            }
        }

        public async Task<bool> DeleteUserById(string id)
        {
            try
            {
                Guid userId = new Guid(id);
                Userr? user = await _coderContext.Userrs.FirstOrDefaultAsync(u => u.Id == userId);

                if (user != null)
                {
                    _coderContext.Userrs.Remove(user);
                    await _coderContext.SaveChangesAsync();
                    return true; 
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> EditUserById(string id, UserWriteDTO userWriteDTO)
        {
            try
            {
                Guid userId = new Guid(id);
                Userr? user = await _coderContext.Userrs.FirstOrDefaultAsync(u => u.Id == userId);

                if (user != null)
                {
                    user.UserNames = userWriteDTO.UserNames;
                    user.Names = userWriteDTO.Names;
                    user.LastNames = userWriteDTO.LastNames;
                    user.Emails = userWriteDTO.Emails;

                    _coderContext.Userrs.Update(user);
                    await _coderContext.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<UserReadDTO> ReadUserInfo(string username)
        {
            try
            {
                var existingUser = await _coderContext.Userrs.Where(u => u.UserNames == username)
                                                                .Select(u => new UserReadDTO 
                                                                {
                                                                Emails = u.Emails, 
                                                                LastNames = u.LastNames,
                                                                Names = u.Names,
                                                                UserNames = u.Names,
                                                                })
                                                                .FirstOrDefaultAsync();
                return existingUser;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
