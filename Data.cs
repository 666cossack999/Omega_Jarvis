using System.Collections.Generic;

namespace Omega_Jarvis
{
    public static class Data
    {
        public static string PcName { get; set; }
        public static string Login { get; set; }
        public static string ConfigOnServer { get; set; }
        public static string ServerImagePath { get; set; }
        public static List<string> PrinterDrivers { get; set; }

        #region Сервера
        //Ферма TS01
        public static string[] ts01 = new string[]
        {
            @"m-ts01v",
            @"m-ts03v",
            @"m-ts04v"
        };
        //Ферма RDP
        public static string[] rdp = new string[]
        {
            @"srv-rdsh-c1-01",
            @"srv-rdsh-c1-02",
            @"srv-rdsh-c1-03",
            @"srv-rdsh-c1-04",
            @"srv-rdsh-c1-05",
            @"srv-rdsh-c1-06",
            @"srv-rdsh-c1-07",
            @"srv-rdsh-c1-08",
            @"srv-rdsh-c1-09",
            @"srv-rdsh-c1-10"
        };
        //Сервера с ТСД
        public static string mwmts02 = @"m-wmts02";
        public static string mwmts04 = @"m-wmts04";
        #endregion

        #region Группы 1С
        //Группы 1С в AD
        public const string adBuh = @"1cbases_buhkorp";
        public const string adUpr = @"1cbases_upr_trackservice";
        public const string adZup = @"1cbases_zup";
        public const string adUat = @"1cbases_transport";
        public const string adKanban = @"1cbases_kanban";
        public const string adTimeTracking = @"1cbases_urvgkomega";
        //РБ                
        public const string adBuh20Rb = @"1cbases_buh20omegatrack";
        public const string adBuhTruck = @"1cbases_buhomegatrack";
        public const string adBuhRbCopy = @"1cbases_copybprb";
        public const string adZupRb = @"1cbases_zuprb";
        #endregion

        #region Ярлыки 1С
        //Ярлыки баз 1С
        //РФ
        public const string doc = @"CommonInfoBases=\\m-1capp01\Список ярлыков БД\S8_Doc.v8i";
        public const string buh = @"CommonInfoBases=\\m-1capp01\Список ярлыков БД\БП_КОРП_3.0.v8i";
        public const string upr = @"CommonInfoBases=\\m-1capp01\Список ярлыков БД\Управляющий_2015.v8i";
        public const string zup = @"CommonInfoBases=\\m-1capp01\Список ярлыков БД\Зарплата и Управление Персоналом 3 КОРП.v8i";
        public const string uat = @"CommonInfoBases=\\m-1capp01\Список ярлыков БД\Управление автотранспортом Проф, редакция 2.2.v8i";
        public const string kanban = @"CommonInfoBases=\\m-1capp01\Список ярлыков БД\База заявок (Канбан-доска).v8i";
        public const string timeTracking = @"CommonInfoBases=\\m-1capp01\Список ярлыков БД\_Учёт рабочего времени группы компаний Омега и Траксервис.v8i";
        //РБ           
        public const string buh20Rb = @"CommonInfoBases=\\m-1capp01\Список ярлыков БД\Бухгалтерия 20 Омега Трак (Белоруссия).v8i";
        public const string buhTruck = @"CommonInfoBases=\\m-1capp01\Список ярлыков БД\Бухгалтерия Омега Трак (Белоруссия).v8i";
        public const string buhRbCopy = @"CommonInfoBases=\\m-1capp01\Список ярлыков БД\БП РБ 2.1 КОПИЯ.v8i";
        public const string zupRb = @"CommonInfoBases=\\m-1capp01\Список ярлыков БД\ЗУП 3.0 РБ.v8i";
        #endregion
    }
}
