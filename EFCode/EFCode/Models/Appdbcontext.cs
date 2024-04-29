using Microsoft.EntityFrameworkCore;

namespace EFCode.Models
{
    public class Appdbcontext :DbContext
    {//to use the db context class in our application, create a class that
       //derives from the dbcontext class

     //Next, to be able to do any useful work, it needs an instance of the
     //dbcontext options class
     //to pass the configuration info to the dbcontext(base) class, use the
     //dbcontextoptions instance.

        public Appdbcontext(DbContextOptions<Appdbcontext> options):base(options) 
        {  

        }
        //the dbcontext class includes a  dbset<TEntity> for each entity in the model
        //We will use this dbset property to query and save instances of the respective model class
        /// <summary>
       
        /// </summary>
        /// the linq queries against the dbset entity wil be transalated to 
        /// queries against the underlying db
        public DbSet<LoginModel> LoginModel { get; set; }
    }
}
