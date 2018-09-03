using System;

namespace Utils
{
    public static class Core
    {
        public static DateTime SystemDateTime
        {
            get
            {
                DateTime systemDateTime = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified);
                return systemDateTime;
            }
        }
    }
}
