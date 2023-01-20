using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProject
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyse(string className, string constructor)
        {

            if (className.Equals(constructor))
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = assembly.GetType(className);
                    return Activator.CreateInstance(moodAnalyserType);
                }
                catch (ArgumentNullException)
                {
                    throw new CustomException(CustomException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "Constructor not found");

                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.CLASS_NOT_FOUND, "Class not Found");
            }
        }
        public static string CreateMoodAnalyser(string className, string constructor, string message)
        {
            try
            {
                Type type = typeof(MoodAnalyser);
                if (type.Name.Equals(className) || type.FullName.Equals(className))
                {
                    if (type.Name.Equals(constructor))
                    {
                        ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) });
                        var obj = constructorInfo.Invoke(new object[] { message });
                        return Convert.ToString(obj);
                    }
                    else
                    {
                        throw new CustomException(CustomException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "Constructor not found");

                    }

                }
            }
            catch (Exception)
            {
                throw new CustomException(CustomException.ExceptionType.CLASS_NOT_FOUND, "Class not found");

            }
            return default;
        }


    }
}
