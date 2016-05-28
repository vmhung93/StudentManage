using ManagerStudentApp.Exceptions;
using ManagerStudentLib.Data;
using ManagerStudentLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Service
{
    public class SystemConfigService
    {
        private static SystemConfigService instance;

        public Dictionary<SystemConfigEnum, SystemConfig> Configs {get;set;}
        //singleton
        public static SystemConfigService GetInstance()
        {
            if (instance == null)
            {
                instance = new SystemConfigService();
            }
            return instance;
        }

        private SystemConfigService()
        {
        }

        public void ReLoadConfigs()
        {
            Configs = new Dictionary<SystemConfigEnum, SystemConfig>();
            var cf = SystemConfigData.GetAllSystemConfigs();
            foreach (SystemConfig sys in cf)
            {
                switch (sys.Name)
                {
                    case SystemConfigEnum.MinAge:
                        Configs.Add(SystemConfigEnum.MinAge, sys);
                        break;
                    case SystemConfigEnum.MaxAge:
                        Configs.Add(SystemConfigEnum.MaxAge, sys);
                        break;
                    case SystemConfigEnum.MaxNumberInClass:
                        Configs.Add(SystemConfigEnum.MaxNumberInClass, sys);
                        break;
                    case SystemConfigEnum.PassScore:
                        Configs.Add(SystemConfigEnum.PassScore, sys);
                        break;
                }
            }
        }

        public bool UpdateConfigs()
        {
            var cf = Configs.Values.ToList();
            try 
            {
                SystemConfigData.UpdateSystemConfigs(cf);
                return true;
            }
            catch (DataGetException ex)
            {
                return false;
            }
        }

        public decimal GetValue(SystemConfigEnum name)
        {
            SystemConfig config;
            if (Configs.TryGetValue(name, out config))
            {
                return decimal.Parse(config.Value);
            }
            else
            {
                return -1;
            }
        }

        public void SetValue(SystemConfigEnum name, decimal value) 
        {
            SystemConfig config;
            if (Configs.TryGetValue(name, out config))
            {
                config.Value = value.ToString();
            }
        }
    }
}
