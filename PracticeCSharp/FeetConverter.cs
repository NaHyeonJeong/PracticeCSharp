using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter
{
    public static class FeetConverter
    {
        //클래스 안의 모든 멤버가 정적 멤버이기 때문에 클래스도 정적 클래스로 지정함

        private const double ratio = 0.3048;    //상수(가급적 public으로 지정하지 않을것)로 정의
        //public static readonly double Ratio = 0.3048;     //public으로 한 경우에는 static readonly를 사용할것

        /// <summary>
        /// feet를 meter로 환산
        /// 인스턴스 속성이나 인스턴스 필드를 이용하지 않는 메서드는 정적 메서드로 만들 수 있다.
        /// </summary>
        /// <param name="feet"></param>
        /// <returns></returns>
        public static double ToMeter(int feet)
        {
            return feet * ratio;
        }

        /// <summary>
        /// meter를 feet로 환산
        /// </summary>
        /// <param name="meter"></param>
        /// <returns></returns>
        public static double FromMeter(int meter)
        {
            return meter / ratio;
        }
    }
}
