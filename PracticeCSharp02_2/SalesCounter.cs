using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator
{
    /// <summary>
    /// 점포별 매출을 구한다
    /// 독립된 클래스로 정의해서 적절한 역할을 부여하는 것이 
    /// Program.cs에 다 넣기 보다는 이렇게 따로 분리하는게 효과적
    /// </summary>
    public class SalesCounter
    {
        //private List<Sale> _sales;
        private IEnumerable<Sale> _sales;

        /*public SalesCounter(List<Sale> sales)
        {
            _sales = sales;
        }*/
        public SalesCounter(string filePath)
        {
            _sales = ReadSales(filePath);
        }

        /// <summary>
        /// 매출 데이터를 읽어 들이고 Sales 객체 리스트를 반환
        /// 콘솔 응용 프로그램에 의존하는 코드가 없기 때문에 굳이 Program.cs에 있을 필요가 없음
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private static IEnumerable<Sale> ReadSales(string filePath)
        {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Sale sale = new Sale
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }


            return sales;

        }

        /// <summary>
        /// 점포별 매출을 구한다
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, int> GetPerStoreSales()
        {
            var dict = new Dictionary<string, int>();
            
            foreach (var sale in _sales)
            {
                //지정한 ShopNmae이 dict 안에 저장돼 있는지 ContainsKey()를 사용해 조사
                if (dict.ContainsKey(sale.ShopName))
                {
                    dict[sale.ShopName] += sale.Amount;
                }
                else
                {
                    dict[sale.ShopName] = sale.Amount;
                }
            }
            return dict;
        }
    }
}
