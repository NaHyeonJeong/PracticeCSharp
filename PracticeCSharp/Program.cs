using System;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length >= 1 && args[0] == "-tom") //feet to meter
            {
                PrintFeetToMeterList(1, 10);
            }
            else //meter to feet
            {
                PrintMeterToFeetList(1, 10);
            }
            
        }

        static void PrintFeetToMeterList(int start, int stop)
        {
            for (int feet = start; feet <= stop; feet++)
            {
                double meter = FeetConverter.ToMeter(feet); //해당 함수를 static으로 변경했기 때문에 인스턴스 생성 없이 바로 사용 가능
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
                //Console.WriteLine("{0} ft = {1:0.0000} m", feet, FeetToMeter(feet));
            }
        }

        static void PrintMeterToFeetList(int start, int stop)
        {
            //FeetConverter feetConverter = new FeetConverter();

            for (int meter = start; meter <= stop; meter++)
            {
                double feet = FeetConverter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);
            }
        }

    }
}