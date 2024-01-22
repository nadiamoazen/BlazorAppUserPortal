using BlazorAppUserPortal.DataContext;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppUserPortal.Data
{

    
    /// UserService class for CRUD operations on User entity in a Blazor app.
    
    public class UserService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public UserService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

     
        ///-------CRUD Operations 
   
   

        //List of uers
        public async Task<List<User>> GetAllUsers()
        {
            return await _applicationDbContext.Users.ToListAsync();

        }

        ///  Create a new user entity in the database.
   
        public async Task<bool> InsertUser(User user)
        {
            await _applicationDbContext.Users.AddAsync(user);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        // Retrieve a user entity from the database by Id.  
        public async Task<User> GetUserById(int id)
        {
            User user = await _applicationDbContext.Users.FirstOrDefaultAsync(c => c.Id.Equals(id));
            return user;
        }

        /// Update an existing user entity in the database.
        public async Task<bool> UpdateUser(User user)
        {
            _applicationDbContext.Users.Update(user);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Delete a user entity from the database based on the provided ID.
        public async Task<bool> DeleteUser(User user)
        {
            _applicationDbContext.Users.Remove(user);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
