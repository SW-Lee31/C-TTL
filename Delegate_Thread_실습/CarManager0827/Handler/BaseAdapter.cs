using CarManager0811.Model;
using CarManager0827;
using oracleTest0827.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0811.Handler
{
    class BaseAdapter
    {
        // 고객정보를 저장하는 리스트
        List<Customer> custList = new List<Customer>();
        List<Car> carList = new List<Car>();

        public void addToList(Customer cust)
        {
            custList.Add(cust);
            addToDB(cust);
        }

        public void addToDB(Customer cust)
        {
            OraMgr.Instance.insertDB(cust);
        }

        public void addToList(Car car)
        {
            carList.Add(car);
            addToDB(car);
        }

        public void addToDB(Car car)
        {
            OraMgr.Instance.insertDB(car);
        }

        // db에서 매출정보를 가져옴.
        /*public List<SalesVo> getSalesDB()
        {
            List<SalesVo> list = OraMgr.Instance.getSalesVo();
            return list;
        }*/

        public List<HobbyVo> getHobbyDB(string name)
        {
            List<HobbyVo> list = OraMgr.Instance.getCustHobbyVo(name);
            return list;
        }

        public List<SalesVo> getSearchUnionDB(string[] arr)
        {
            List<SalesVo> list = OraMgr.Instance.getSearchUnion(arr);
            return list;
        }
    }
}
