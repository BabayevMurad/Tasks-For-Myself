using LibraryClass;
using System.Reflection.Metadata;
using HomeTask.Data;

namespace HomeTask.Helpers
{
    internal static class DatabaseHelpers
    {
        public static List<User> GetAllUsers(TaskContext context)
        {
            return [.. context.Users];
        }

        public static void AddUser(TaskContext context, User user)
        {

            try 
            {
                context.Users.Add(user);

                context.SaveChanges();

                context.SaveChanges();             
            } 
            catch (Exception ex) 
            {
                Console.WriteLine(ex);

                Thread.Sleep(1000);
            }
        }

        public static async void RemoveUser(TaskContext context, int userId)
        {
            try
            {
                var user = GetAllUsers(context).Single(u => u.Id == userId);

                context.Users.Remove(user);

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                Thread.Sleep(1000); 
            }

        }
    }
}
