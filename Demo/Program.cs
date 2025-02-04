using Demo.Data;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  ComapnyDbContext context = new ComapnyDbContext();

            ///   try
            ///   {
            ///       //code
            ///   }
            ///   finally
            ///   {
            ///       //close the connection 
            ///       context.Dispose();
            ///   }
            ///   

            ///   using (ComapnyDbContext context = new ComapnyDbContext())
            ///   {
            ///       //write Code 
            ///   }

            using ComapnyDbContext context = new ComapnyDbContext();

            var employee=context.Employees.Where(E=>E.Id==1).FirstOrDefault();

        }
    }
}
