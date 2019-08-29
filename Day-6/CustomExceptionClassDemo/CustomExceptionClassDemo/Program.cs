using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionClassDemo
{
    class Program
    {
        static void Main()
        {
            Application appForm = null;

            try
            {
                appForm = new Application();
                appForm.Name = "joydip";
                appForm.Age = 17;
            }
            catch (InapprorpiateAgeException ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }
        }
    }
}
