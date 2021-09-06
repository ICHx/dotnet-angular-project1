using System;

namespace dotnet1
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary
        {
            get
            {
                string x;
                switch (this.TemperatureC)
                {
                    case < 10:
                        {
                            x = cold[rng.Next(cold.Length)];
                            break;
                        }
                    case < 28:
                        {
                            x = warm[rng.Next(warm.Length)];
                            break;
                        }
                    case > 28:
                        {
                            x = hot[rng.Next(hot.Length)];
                            break;
                        }
                    default:
                        x = "???";
                        break;
                }
                return x;
            }
        }

        private static Random rng = new Random();

        private static readonly string[] cold = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool",
        };

        private static readonly string[] warm = new[]
{
            "Mild", "Warm", "Balmy",
        };

        private static readonly string[] hot = new[]
{
            "Hot", "Sweltering", "Scorching"
        };
    }
}
