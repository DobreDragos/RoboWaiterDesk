using DataLayerHelper.Classes;
using DataLayerHelper.CustomExceptions;
using DataLayerHelper.Enums;
using DataLayerHelper.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataLayerHelper
{
    public class Helper
    {
        /// <summary>
        /// Retrieves name of a property as string
        /// </summary>
        /// <example>
        /// Helper.GetName<Users>(x => x.Password)
        /// </example>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="exp"></param>
        /// <returns></returns>
        public static string GetName<TClass>(Expression<Func<TClass, object>> exp)
        {
            MemberExpression body = exp.Body as MemberExpression;

            if (body == null)
            {
                UnaryExpression ubody = (UnaryExpression)exp.Body;
                body = ubody.Operand as MemberExpression;
            }

            return body.Member.Name;
        }

        public static FileVersionInfo GetVersion(Assembly assembly)
        {
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi;
        }

        public static string GetHash(string inputString)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(inputString);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            return System.Text.Encoding.ASCII.GetString(data);
        }

        public static int GetDbStepCount(string updateQuery)
        {
            return GetDbSteps(updateQuery).Count ;
        }
        public static List<string> GetDbSteps (string updateQuery)
        {
            var steps = updateQuery.Split(new string[] { "_GO_" }, StringSplitOptions.RemoveEmptyEntries);
            return (steps.Length > 0) ? steps.Take(steps.Length - 1).ToList() : new List<string>(); //laststep is just _go_ step xxx
        }

        public static List<DbStep> GetDbSteps(ResourceSet resourceSet)
        {
            var steps = new List<DbStep>();
            foreach (DictionaryEntry entry in resourceSet)
            {
                string resourceKey = entry.Key.ToString();
                //v1_2_0 => {1, 2, 0}
                string[] versionNumbers = resourceKey.TrimStart('v').Split('_');
                object resource = entry.Value;
                DbStep aux = new DbStep
                {
                    UpdateQuery = resource.ToString(),
                    Version = new Version(Convert.ToInt32(versionNumbers[0]),
                                        Convert.ToInt32(versionNumbers[1]),
                                        Convert.ToInt32(versionNumbers[2]))
                };
                steps.Add(aux);
            }
            return steps;
        }

        public static int GetCurrentDbStep(ResourceSet resourceSet)
        {
            var steps = GetDbSteps(resourceSet).OrderBy(x => x.Version.Major)
                                     .ThenBy(x => x.Version.Minor)
                                     .ThenBy(x => x.Version.Build).ToList();

            return steps.Last().Step;
        }

        public static string SerializeJson(object model)
        {
            return JsonConvert.SerializeObject(model);
        }

        public static T DeserializeJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }


    }
}
