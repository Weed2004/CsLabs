using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class MyTestClass
    {
        private void Print(string str)
        {
            Program.form.LogsBox.Text += str + Environment.NewLine;
        }

        public void ShowMethodNamesContainingStrParams(string className)
        {
            Type? classType = Type.GetType(className);
            if (classType != null)
            {
                foreach (var method in classType.GetMethods())
                {
                    foreach (var parameter in method.GetParameters())
                    {
                        if(parameter.ParameterType == typeof(string))
                        {
                            Print(method.Name);
                            break;
                        }
                    }
                }
            }
            else
            {
                Print("Класса не существует!");
            }
        }

        public void InvokeMethodFromFile(string className, string methodName)
        {
            string file = $"{className}.{methodName}";

            if (File.Exists(file))
            {
                Type? classType = Type.GetType(className);

                if(classType != null)
                {
                    MethodInfo? method = classType.GetMethod(methodName);

                    if(method != null)
                    {
                        ArrayList args = new ArrayList();
                        StreamReader sr = File.OpenText(file);

                        foreach(var param in method.GetParameters())
                        {
                            args.Add(Convert.ChangeType(sr.ReadLine(), param.ParameterType));
                        }

                        sr.Close();

                        method.Invoke(Activator.CreateInstance(classType),args.ToArray());
                    }
                    else
                    {
                        Print("Метода не существует");
                    }
                }
                else
                {
                    Print("Класс не существует");
                }
            }
            else
            {
                Print("Файла не существует");
            }
        }

        public void PrintAllMembersToFile(string className)
        {
            Type? type = Type.GetType(className);
            if(type != null)
            {
                string file = $"{className}.members";
                StreamWriter sw = File.CreateText(file);

                foreach(var member in type.GetMembers())
                {
                    sw.WriteLine(member.ToString());
                }

                sw.Close();
                Print($"Все содержимое класса {className} было выведено в файл {file}");
            }
            else
            {
                Print($"Класса {className} не существует");
            }
        }

        public void GenerateClassFile(string className)
        {
            Type? type = Type.GetType(className);
            if(type != null)
            {
                StreamWriter sw = File.CreateText($"{className}.cs");
                sw.WriteLine("using System;");
                sw.WriteLine("namespace WinFormsApp1");
                sw.WriteLine("{");

                sw.WriteLine($"internal class {className}");
                sw.WriteLine("{");

                foreach(var member in type.GetMembers())
                {
                    sw.WriteLine(member.ToString());
                }

                sw.WriteLine("}");
                sw.WriteLine("}");
                sw.Close();
                Print($"Генерация файла класса: {className} успешно завершена!");
            }
            else
            {
                Print($"Класса {className} не существует");
            }
        }

        public void Parse(string className, string arg)
        {
            Type? type = Type.GetType(className);
            if(type != null)
            {

                object? obj = Activator.CreateInstance(type);
                string fieldName = arg.Split("=")[0];
                string fieldValue = arg.Split("=")[1];

                foreach(var member in type.GetMembers())
                {

                    var attribute = member.GetCustomAttribute<CommandLineAttribute>();
                    if (attribute!=null&&attribute.CommandSwitch==fieldName)
                    {
                        if (member is FieldInfo fieldInfo)
                        {
                            if (fieldInfo.FieldType == typeof(bool))
                            {
                                switch (fieldValue)
                                {
                                    case "true":
                                        {
                                            fieldInfo.SetValue(obj, true);
                                            break;
                                        }
                                    case "false":
                                        {
                                            fieldInfo.SetValue(obj, false);
                                            break;
                                        }
                                }
                            }
                            else
                            {
                                fieldInfo.SetValue(obj, Convert.ChangeType(fieldValue, fieldInfo.FieldType));
                            }
                        }
                        if (member is PropertyInfo property)
                        {
                            if(property.PropertyType == typeof(bool))
                            {
                                switch(fieldValue)
                                {
                                    case "true":
                                        {
                                            property.SetValue(obj, true); break;
                                        }
                                    case "false":
                                        {
                                            property.SetValue(obj, false);break;
                                        }
                                }
                            }
                            else
                            {
                                property.SetValue(obj, Convert.ChangeType(fieldValue, property.PropertyType));
                            }
                        }
                    }
                }

                foreach(var member in type.GetMembers())
                {
                    if(member is FieldInfo field)
                    {
                        Print($"field {field.Name} = {field.GetValue(obj)}");
                    }
                    if(member is PropertyInfo property)
                    {
                        Print($"property {property.Name} = {property.GetValue(obj)}");
                    }
                }
            }
            else
            {
                Print("Класса не существует");
            }
        }
    }
}
