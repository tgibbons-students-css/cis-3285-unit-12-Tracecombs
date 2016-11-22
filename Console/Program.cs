
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubtypeCovariance;

namespace ConsoleSample
{
    class Program
    {
        static void Main(string[] args)
        {

            IEntityRepository<Entity> entityRepository = new EntityRepository();
            Entity myEntity = entityRepository.GetByID(Guid.NewGuid());

            myEntity.Name = "Tom";
            Console.WriteLine("New entity ID: " + myEntity.ID.ToString());
            Console.WriteLine("New entity Name: " + myEntity.Name);

            IEntityRepository<User> userRepository = new UserRepository();
            User myUser = userRepository.GetByID(Guid.NewGuid());

            myUser.Name = "Tom";
            Console.WriteLine("New user ID: " + myUser.ID.ToString());
            Console.WriteLine("New user Email: " + myUser.EmailAddress.ToString());
            Console.WriteLine("New user DOB: " + myUser.DateOfBirth);
        }
    }
}
