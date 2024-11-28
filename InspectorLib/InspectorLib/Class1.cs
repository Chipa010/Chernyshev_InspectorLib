using System;
using System.Collections.Generic;

namespace InspectorLib
{
    public class FunctionInsp
    {
        
        private const string InspectionName = "Автоинспекция г. Чита";

       
        private string chiefInspectorFullName = "Васильев Василий Иванович";

        private List<string> workers = new List<string>
        {
            "Иванов И.И.",
            "Зиронов Т.А.",
            "Миронов А.В.",
            "Васильев В.И."
        };

        
        public string GetInspector()
        {
            return chiefInspectorFullName;
        }

         
        public string GetCarInspection()
        {
            return InspectionName;
        }

        
        public bool SetInspector(string fullname)
        {
            if (workers.Contains(fullname))
            {
                chiefInspectorFullName = fullname;
                return true;  
            }
            return false;  
        }

       
        public string GenerateNumber(string number, string symbol, string code)
        {
            symbol = symbol.ToUpper();
            return $"{symbol}{number}_{code}";
        }

        
        public List<string> GetWorker()
        {
            return new List<string>(workers); 
        }

        
        public void AddWorker(string fullName)
        {
            if (!workers.Contains(fullName))
            {
                workers.Add(fullName); 
            }
        }
    }
}