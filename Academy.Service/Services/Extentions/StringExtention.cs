

using System;

namespace Academy.Service.Services.StringService
{
    public static class StrService
    {
        public static string Str(this string data)
        {
            while (string.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("bosluq olmaz!");
                data = Console.ReadLine();
            }return data;
        }
    }
}
