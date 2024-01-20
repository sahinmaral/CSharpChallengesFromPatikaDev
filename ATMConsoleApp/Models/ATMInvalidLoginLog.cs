namespace ATMConsoleApp.Models
{
    class ATMInvalidLoginLog : ATMBaseLog
    {
        public ATMInvalidLoginLog()
        {
            LogType = ATMLogTypeEnum.InvalidLogin;
        }
    }
}