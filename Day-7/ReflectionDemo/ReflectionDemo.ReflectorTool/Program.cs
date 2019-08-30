//using static System.Diagnostics.Process;
using System.Diagnostics;
using System;
using System.Reflection;

namespace ReflectionDemo.ReflectorTool
{
    class Program
    {
        static void PrintProcessInfo()
        {
            Process currentProcess = Process.GetCurrentProcess();
            Console.WriteLine($"Process Name: {currentProcess.ProcessName} and Id: {currentProcess.Id}");
        }
        static AppDomain PrintDomainInfo()
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            Console.WriteLine($"Domain Name:{currentDomain.FriendlyName}");
            return currentDomain;
        }
        static void PrintDomainAssemblies(AppDomain domain)
        {
            Console.WriteLine($"\nAssemblies in the {domain.FriendlyName} domain");

            Assembly[] assemblies = domain.GetAssemblies();
            foreach (Assembly assembly in assemblies)
            {
                Console.WriteLine($"Name:{assembly.FullName}");
            }
        }
        static Assembly LoadAssembly(string path)
        {
            Assembly loadedAssembly = Assembly.LoadFile(path);
            return loadedAssembly;
        }
        static void PrintAssemblyTypes(Assembly assembly)
        {
            Console.WriteLine($"\nTypes present in the {assembly.FullName}\n");

            Type[] allTypes = assembly.GetTypes();
            foreach (Type type in allTypes)
            {
                Console.WriteLine($"Name:{type.Name}");
                Console.WriteLine($"Is class? {type.IsClass}");
                Console.WriteLine($"Is interface? {type.IsInterface}");
                Console.WriteLine($"Is Value type? {type.IsValueType}");
                Console.WriteLine();
            }
        }
        static Type ExtractAssemblyType(string typeFullName, Assembly assembly)
        {
            Type type = assembly.GetType(typeFullName);
            return type;
        }
        static object CreateTypeInstance(Type type)
        {
            //object instanceRef = Activator.CreateInstance(
            //    type, new object[] { 12 });
            object instanceRef = Activator.CreateInstance(type);
            Console.WriteLine($"\nObject of {instanceRef.GetType().Name} created");
            return instanceRef;
        }
        static void PrintTypeProperties(Type type)
        {
            PropertyInfo[] allProperties = type.GetProperties();
            Console.WriteLine($"\nProperties of {type.Name}\n");
            foreach (PropertyInfo property in allProperties)
            {
                Console.WriteLine($"Name: {property.Name}");
                Console.WriteLine($"Data Type: {property.PropertyType}");
                Console.WriteLine($"Readonly? {property.CanRead}");
                Console.WriteLine($"Writeonly? {property.CanWrite}");
                Console.WriteLine();
            }
        }
        static PropertyInfo ExtractTypeProperty(Type type, string propertyName)
        {
            PropertyInfo propertyInfo = type.GetProperty(propertyName);
            return propertyInfo;
        }
        static void InvokeTypePropertyGetAccessor(PropertyInfo property, object typeObjRef)
        {
            object propertyValue = property.GetValue(typeObjRef);
            Console.WriteLine($"\n{property.Name} property has value {propertyValue}");
        }
        static void InvokeTypePropertySetAccessor(PropertyInfo property, object typeObjRef, object value)
        {
            property.SetValue(typeObjRef, value);
        }
        static void PrintTypeMethods(Type type)
        {
            MethodInfo[] allMethods = type.GetMethods();
            Console.WriteLine($"\nMethods of {type.Name}\n");
            foreach (MethodInfo method in allMethods)
            {
                Console.WriteLine($"Name: {method.Name}");
                Console.WriteLine($"Return type: {method.ReturnType}");
                Console.WriteLine($"Is abstract? {method.IsAbstract}");
                Console.WriteLine($"Is Static? {method.IsStatic}");
                Console.WriteLine();
            }
        }
        static MethodInfo ExtractTypeMethod(Type type, string methodName)
        {
            MethodInfo methodInfo = type.GetMethod(methodName);
            return methodInfo;
        }
        static ParameterInfo[] ExtractMethodParameters(MethodInfo methodInfo)
        {
            ParameterInfo[] parameters = methodInfo.GetParameters();
            if (parameters != null && parameters.Length > 0)
            {
                Console.WriteLine($"\nParameters of {methodInfo.Name} method\n");
                foreach (ParameterInfo parameter in parameters)
                {
                    Console.WriteLine($"Name: {parameter.Name}");
                    Console.WriteLine($"Data Type: {parameter.ParameterType}");
                    Console.WriteLine($"Position: {parameter.Position}");
                    Console.WriteLine($"Is Out? {parameter.IsOut}");
                    Console.WriteLine($"Is Optional? {parameter.IsOptional}");
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine($"\n{methodInfo.Name} doesn't have any parameter");

            return parameters;
        }
        //static void InvokeTypeMethod(MethodInfo methodInfo, object typeObjRef, object[] arguments = null)
        static void InvokeTypeMethod(MethodInfo methodInfo, object typeObjRef, params object[] arguments)
        {
            object returnValue = methodInfo.Invoke(typeObjRef,
                 (arguments == null && arguments.Length > 0) ?
                 arguments : null);
            Console.WriteLine($"Return value of {methodInfo.Name} is: {(returnValue ?? returnValue)}");
        }

        static void Main()
        {
            PrintProcessInfo();
            AppDomain domain = PrintDomainInfo();

            Assembly loadedAssembly = LoadAssembly(@"D:\Siemens\C2C-2019\CSharp\Siemens-C2C2019-CSharp\Day-7\ReflectionDemo\ReflectionDemo.Library\bin\Debug\ReflectionDemo.Library.dll");
            PrintDomainAssemblies(domain);

            PrintAssemblyTypes(loadedAssembly);
            Type circleType = ExtractAssemblyType("ReflectionDemo.Library.Circle", loadedAssembly);
            object circleInstanceRef = CreateTypeInstance(circleType);

            PrintTypeProperties(circleType);
            PropertyInfo radiusPopertyInfo = ExtractTypeProperty(circleType, "Radius");
            InvokeTypePropertySetAccessor(radiusPopertyInfo, circleInstanceRef, 20);
            InvokeTypePropertyGetAccessor(radiusPopertyInfo, circleInstanceRef);

            PrintTypeMethods(circleType);
            //MethodInfo setRadiusMethodInfo = ExtractTypeMethod(circleType, "set_Radius");
            MethodInfo areaMethodInfo = ExtractTypeMethod(circleType, "CalculateArea");
            ParameterInfo[] areaMethodParameters = ExtractMethodParameters(areaMethodInfo);
            InvokeTypeMethod(areaMethodInfo, circleInstanceRef);


            //string str = null;
            //str.Split(',', '.');
            //string tr1 = null;
            //tr1.Split(' ');
            Console.WriteLine("press any key to terminate...");
            Console.ReadLine();
        }
    }
}
