using System.Reflection;


namespace Application.DependencyInjection
{
    public class ApplicationAssembly
    {
        public static Assembly Assembly => Assembly.GetExecutingAssembly();
    }
}
