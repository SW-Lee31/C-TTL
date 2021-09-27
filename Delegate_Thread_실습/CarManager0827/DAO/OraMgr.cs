using CarManager0811.Model;
using CarManager0827;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oracleTest0827.DAO
{
    class OraMgr
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=scott; Password=tiger;";
        OracleConnection conn;
        OracleCommand cmd;
        static OraMgr instance;

        public static OraMgr Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OraMgr();
                }
                return instance;
            }
        }
        
        // 생성자
        public OraMgr()
        {
            Console.WriteLine("오라클 객체 생성");
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
        }

        // 소멸자
        ~OraMgr()
        {
            closeDB();
            Console.WriteLine("오라클 객체 소멸");
        }

        public void connectDB()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공");
            }
            catch(OracleException e)
            {
                Console.WriteLine("오라클 접속 오류: " + e.Message);
                Environment.Exit(0);
            }
        }

        public void closeDB()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                    Console.WriteLine("오라클 접속 해제");
                }
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 해제 오류: " + e.Message);
            }
        }

        public void createTable()
        {
            try
            {
                string sql = "create table student_t (" +
                    "id number not null," +
                    "name varchar(20) not null," +
                    "age number not null," +
                    "addr varchar(80) not null," +
                    "constraint pk_student_id primary key(id))";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                string seq = "create sequence seq_id " +
                    "increment by 1 start with 1000";
                cmd.CommandText = seq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공");
            }
            catch(OracleException e)
            {
                Console.WriteLine("테이블 생성 오류: " + e.Message);
            }
        }

        public void dropTable()
        {
            try
            {
                string sql = "drop table student_t";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                string seq = "drop sequence seq_id";
                cmd.CommandText = seq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 삭제 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블(시퀀스) 삭제 오류: " 
                    + e.Message);
            }
        }

        public void insertDB()
        {
            try
            {
                string name = "홍길동";
                int age = 200;
                string addr = "조선 한양 홍대감댁 11번지";
                string sql = string.Format("insert into student_t values (" +
                    "seq_id.nextval, '{0}', {1}, '{2}')",
                    name, age, addr);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        public void insertDB(Customer cust)
        {
            try
            {
                string sql = string.Format("insert into customer_0827 values (" +
                    "customer_0827_seq.nextval, '{0}','{1}','{2}','{3}','{4}', '{5}')",
                    cust.Name, cust.Tel, cust.Addr, 
                    cust.Birth, cust.Gender, cust.Date);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                List<string> hbList = cust.HobbyList;
                string[] hbArr = new string[6];
                for (int i=0; i<hbList.Count; i++)
                {
                    hbArr[i] = hbList[i];
                }
                string sqlHb = string.Format("insert into customer_hb_0827 values (" +
                    "customer_hb_0827_seq.nextval, '{0}', '{1}', '{2}', '{3}'," +
                    "'{4}', '{5}', customer_0827_seq.currval)",
                    hbArr[0], hbArr[1], hbArr[2], hbArr[3], hbArr[4], hbArr[5]);
                cmd.CommandText = sqlHb;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        public void insertDB(Car car)
        {
            try
            {
                string sql = string.Format("insert all " +
                    "into car_0827 values (" +
                    "car_0827_seq.nextval, '{0}','{1}', {2},'{3}')",
                    car.Name, car.Color, car.Price, car.InsuDate);
                sql += string.Format(
                    "into sales_0827 values (" +
                    "sales_0827_seq.nextval, sales_0827_seq.currval, " +
                    "sales_0827_seq.currval, '{0}')", car.Manager);
                sql += "select * from dual";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("차량 데이터 추가 오류: " + e.Message);
            }
        }

        public void showDB()
        {
            string sql = "select * from student_t order by id desc";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            int count = 1;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Console.WriteLine("번호: " + count++);
                    Console.WriteLine("이름: " + rd["name"]);
                    Console.WriteLine("나이: " + rd["age"]);
                    Console.WriteLine("주소: " + rd["addr"]);
                    Console.WriteLine("=============================");
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
        }

        /*public List<SalesVo> getSalesVo()
        {
            string sql = "select ca.name as 차량명, " +
                "ca.price as 판매가격, " +
                "ca.insu_date as 인수날짜, cu.name as 고객명, " +
                "cu.tel as 연락처, cu.jupsu_date as 접수날짜, " +
                "sa.manager as 담당자 " +
                "from car_0827 ca, customer_0827 cu, sales_0827 sa " +
                "where sa.carid = ca.carid and sa.cid = cu.cid";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            int count = 1;
            List<SalesVo> list = new List<SalesVo>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Console.WriteLine("번호: " + count++);
                    Console.WriteLine("차량명: " + rd["차량명"]);
                    Console.WriteLine("판매가격: " + rd["판매가격"]);
                    Console.WriteLine("인수날짜: " + rd["인수날짜"]);
                    Console.WriteLine("고객명: " + rd["고객명"]);
                    Console.WriteLine("연락처: " + rd["연락처"]);
                    Console.WriteLine("접수날짜: " + rd["접수날짜"]);
                    Console.WriteLine("담당자: " + rd["담당자"]);
                    Console.WriteLine("=============================");
                    SalesVo saVo = new SalesVo(
                        rd["차량명"].ToString(),
                        Convert.ToInt32(rd["판매가격"].ToString()),
                        rd["인수날짜"].ToString(),
                        rd["고객명"].ToString(),
                        rd["연락처"].ToString(),
                        rd["접수날짜"].ToString(),
                        rd["담당자"].ToString());
                    list.Add(saVo);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }*/

        public List<HobbyVo> getCustHobbyVo(string name)
        {
            string sql = string.Format("select cb.health, cb.game, cb.study, " +
                "cb.drinking, cb.sleeping, cb.bruise " +
                "from sales_0827_view sv, customer_hb_0827 cb " +
                "where 고객ID = cb.cid and 고객명 = '{0}'", name);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<HobbyVo> list = new List<HobbyVo>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    HobbyVo hbVo = new HobbyVo(
                        rd["health"].ToString(),
                        rd["game"].ToString(),
                        rd["study"].ToString(),
                        rd["drinking"].ToString(),
                        rd["sleeping"].ToString(),
                        rd["bruise"].ToString());
                    list.Add(hbVo);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }

        public string login(string passwd)
        {
            string check = string.Empty;
            string sql = string.Format("select count(*) as ret, " +
                "decode(count(*), 1, '성공', 0, '실패', 'None') as 결과 "+
                "from admin_t where id = 'admin' and " +
                "func_decrypt(pwd) = '{0}'", passwd);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    check = rd["결과"].ToString();
                    //Console.WriteLine("암호 확인: " + check);
                }
            }
            else
            {
                Console.WriteLine("암호가 존재하지 않습니다.");
            }
            rd.Close();
            return check;
        }

        public List<SalesVo> getSearchUnion(string[] ans)
        {
            string[] que = new string[]
            {
                "ca.name", "cu.name", "cu.jupsu_date",
                "sa.manager"
            };
            string sqlTail = string.Empty;
            for (int i=0; i<ans.Length; i++)
            {
                if (ans[i] != "")
                {
                    sqlTail += " and ";
                    sqlTail += que[i];
                    sqlTail += "=";
                    sqlTail += "'" + ans[i] + "'";
                }
            }

            string sql = "select ca.name as 차량명, " +
                "ca.price as 판매가격, " +
                "ca.insu_date as 인수날짜, cu.name as 고객명, " +
                "cu.tel as 연락처, cu.jupsu_date as 접수날짜, " +
                "sa.manager as 담당자 " +
                "from car_0827 ca, customer_0827 cu, sales_0827 sa " +
                "where sa.carid = ca.carid and sa.cid = cu.cid";
            sql = sql + sqlTail;
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<SalesVo> list = new List<SalesVo>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    SalesVo saVo = new SalesVo(
                        rd["차량명"].ToString(),
                        Convert.ToInt32(rd["판매가격"].ToString()),
                        rd["인수날짜"].ToString(),
                        rd["고객명"].ToString(),
                        rd["연락처"].ToString(),
                        rd["접수날짜"].ToString(),
                        rd["담당자"].ToString());
                    list.Add(saVo);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }
    }
}
