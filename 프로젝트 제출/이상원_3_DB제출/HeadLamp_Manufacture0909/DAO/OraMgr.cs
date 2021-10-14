using HeadLamp_Manufacture0909.Adapter;
using HeadLamp_Manufacture0909.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadLamp_Manufacture0909.DAO
{
    class OraMgr
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=account_1; Password=1234;";
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

        #region
        /*public void createTable()
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
        }*/
        #endregion

        public void insertDB(Admin admin)
        {
            try
            {
                string sql = string.Format("insert into admin_info_t values (" +
                    "admin_info_t_seq.nextval, '{0}', '{1}', '{2}', '{3}', '{4}')",
                    admin.Name, admin.Digit, admin.Addr,
                    admin.Enom, admin.Level);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류1: " + e.Message);
            }
        }


        public void insertDB(Admin_account admin_act)
        {
            try
            {
                string sql = string.Format("insert into admin_account_t values (" +
                    "admin_info_t_seq.currval, '{0}', '{1}')",
                    admin_act.Id, admin_act.Pw);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류2: " + e.Message);
            }
        }

        public void insertDB(Process prc, string process)
        {
            try
            {
                string sql = string.Format("insert into inventory_process values (" +
                    "'{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                    process, prc.Condition, prc.Temp, prc.Humi, prc.Dust, prc.Time);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류3: " + e.Message);
            }
        }

        public void Update_Process_amount(string process, int fair, int fail)
        {
            try
            {
                string sql = string.Format("update inventory_process set " +
                    "pro_g_amount = {0}, pro_b_amount = {1} " +
                    "where inv_process = '{2}'",
                    fair, fail, process);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류4: " + e.Message);
            }
        }

        public void Update_Process_status(string process, string status)
        {
            try
            {
                string sql = string.Format("update inventory_process set " +
                    "pro_c = '{0}', time = '{1}' " +
                    "where inv_process = '{2}'",
                    status, DateTime.Now.ToString("yyyy년MM월dd일 HH: mm: ss"), process);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류5: " + e.Message);
            }
        }

        public void Update_Process_status(string process, string temp, string humi, string dust)
        {
            try
            {
                string sql = string.Format("update inventory_process set " +
                    "pro_temp = '{0}', pro_humi = '{1}', pro_dust = '{2}' " +
                    "where inv_process = '{3}'",
                    temp, humi, dust, process);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류6: " + e.Message);
            }
        }

        public void insertDB(Inventory item)
        {
            try
            {
                string sql = string.Format("insert into inventory_t values (" +
                    "inventory_t_seq.nextval, '{0}', '{1}', '{2}')",
                    item.Time, item.Process, item.Condition);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류7: " + e.Message);
            }
        }

        public void insert_com_DB(string seq, string time)
        {
            try
            {
                string sql = string.Format("insert into inv_suc values (" +
                    "{0}, '{1}', '{2}')",
                    int.Parse(seq), time, "적재");
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류8: " + e.Message);
            }
        }

        public void insertDB(Del del)
        {
            try
            {
                string sql = string.Format("insert into invetory_del_t values (" +
                    "invetory_del_t_seq.nextval, {0}, {1}, '{2}', '{3}', {4}, '{5}')",
                    int.Parse(del.Mem_seq), int.Parse(del.Inv_seq),
                    del.Curr_loc, del.Dest_loc, int.Parse(del.Admin_seq), "배송대기");
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류9: " + e.Message);
            }
        }



        public void updateDB_pro(Process pro, string procss_name)
        {
            try
            {
                string sql = string.Format("update inventory_process set " +
                    "pro_c = '{0}', time = '{1}', " +
                    "pro_temp = '{2}', pro_humi = '{3}', " +
                    "pro_dust = '{4}' " +
                    "where inv_process = {5}",
                    pro.Condition, pro.Time, pro.Temp, pro.Humi, pro.Dust,
                    procss_name);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류10: " + e.Message);
            }
        }

        public void updateDB_inv(Inventory item)
        {
            try
            {
                string sql = string.Format("update inventory_t set " +
                    "inv_time = '{0}', inv_fk_process = '{1}', " +
                    "inv_condition = '{2}' " +
                    "where inv_seq = {3}",
                    item.Time, item.Process, item.Condition, item.Serial);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류11: " + e.Message);
            }
        }

        public string[] show_pro_status(string process)
        {
            string sql = string.Format("select pro_temp, pro_humi, pro_dust from inventory_process " +
                "where inv_process = '{0}'", process);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            string[] result = new string[3];

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    result[0] = rd["pro_temp"].ToString();
                    result[1] = rd["pro_humi"].ToString();
                    result[2] = rd["pro_dust"].ToString();
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.12");
            }
            rd.Close();

            return result;
        }

        public string show_pro_condition(string process)
        {
            string sql = string.Format("select pro_c from inventory_process " +
                "where inv_process = '{0}'", process);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            string result = string.Empty;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    result = rd["pro_c"].ToString();
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.13");
            }
            rd.Close();

            return result;
        }

        public string show_pro_time(string process)
        {
            string sql = string.Format("select time from inventory_process " +
                "where inv_process = '{0}'", process);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            string result = string.Empty;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    result = rd["time"].ToString();
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.14");
            }
            rd.Close();

            return result;
        }

        public void show_admin_DB()
        {
            string sql = "select * from admin_account_t";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    /*Console.WriteLine("번호: " + count++);
                    Console.WriteLine("관리자번호: " + rd["admin_fk_id_seq"]);
                    Console.WriteLine("관리자ID: " + rd["admin_a_id"]);
                    Console.WriteLine("관리자 PW: " + rd["admin_a_pw"]);
                    Console.WriteLine("=============================");*/
                    
                    Admin_account act = new Admin_account(rd["admin_a_id"].ToString(),
                    rd["admin_a_pw"].ToString());

                    BaseAdapter.act_lst_Instance.Add(act);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.15");
            }
            rd.Close();
        }

        public void show_admin_info_DB()
        {
            string sql = "select * from admin_info_t ";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            int count = 1;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    /*Console.WriteLine("번호: " + count++);
                    Console.WriteLine("관리자번호: " + rd["admin_fk_id_seq"]);
                    Console.WriteLine("관리자ID: " + rd["admin_a_id"]);
                    Console.WriteLine("관리자 PW: " + rd["admin_a_pw"]);
                    Console.WriteLine("=============================");*/

                    Admin ad = new Admin(rd["admin_name"].ToString(),
                    rd["admin_digit"].ToString(), rd["admin_addr"].ToString(),
                    rd["admin_enom"].ToString(), rd["admin_lev"].ToString());

                    BaseAdapter.ad_lst_Instance.Add(ad);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.16");
            }
            rd.Close();
        }

        public int search_pro_s(string process)
        {
            string sql = string.Format("select pro_g_amount from inventory_process " +
                "where inv_process = '{0}'", process);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            int count = 0;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    count = int.Parse(rd["pro_g_amount"].ToString());
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.17");
            }
            rd.Close();

            return count;
        }

        public int search_pro_f(string process)
        {
            string sql = string.Format("select pro_b_amount from inventory_process " +
                "where inv_process = '{0}'", process);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            int count = 0;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    count = int.Parse(rd["pro_b_amount"].ToString());
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.17");
            }
            rd.Close();

            return count;
        }

        public int pro_suc_amount(string process)
        {
            string sql = string.Format("select pro_g_amount from inventory_process " +
                "where inv_process = '{0}'", process);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            int count = 0;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    count = int.Parse(rd["pro_g_amount"].ToString());
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.19");
            }
            rd.Close();

            return count;
        }

        public string admin_id_finder(string admin_name)
        {
            string sql = string.Format("select admin_id_seq from admin_info_t " +
                "where admin_name = '{0}'", admin_name);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            string id_seq = string.Empty;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    id_seq = rd["admin_id_seq"].ToString();
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.20");
            }
            rd.Close();

            return id_seq;
        }

        public int pro_fail_amount(string process)
        {
            string sql = string.Format("select pro_b_amount from inventory_process " +
                "where inv_process = '{0}'", process);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            int count = 0;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    count = int.Parse(rd["pro_b_amount"].ToString());
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.21");
            }
            rd.Close();

            return count;
        }

        public void show_inv_DB()
        {
            string sql = "select * from inventory_t";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    /*Console.WriteLine("시리얼: " + rd["inv_seq"]);
                    Console.WriteLine("시간: " + rd["inv_time"]);
                    Console.WriteLine("프로세스위치: " + rd["inv_fk_process"]);
                    Console.WriteLine("상태: " + rd["inv_condition"]);
                    Console.WriteLine("=============================");*/

                    Inventory item = new Inventory(rd["inv_seq"].ToString(), rd["inv_time"].ToString(),
                        rd["inv_fk_process"].ToString(), rd["inv_condition"].ToString());

                    BaseAdapter.inv_lst_Instance.Add(item);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.22");
            }
            rd.Close();
        }

        public List<string> show_inv_suc()
        {
            string sql = "select * from inv_suc " +
                "where inv_con = '적재'";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<string> inv_seq_lst = new List<string>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    inv_seq_lst.Add(rd["inv_fk_seq"].ToString());
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.22");
            }
            rd.Close();

            return inv_seq_lst;
        }

        public int show_invFail_DB()
        {
            string sql = "select count(*) from inventory_t " +
                         "where inventory_t.inv_condition = '불량'";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            int fail = 0;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    /*Console.WriteLine("시리얼: " + rd["inv_seq"]);
                    Console.WriteLine("시간: " + rd["inv_time"]);
                    Console.WriteLine("프로세스위치: " + rd["inv_fk_process"]);
                    Console.WriteLine("상태: " + rd["inv_condition"]);
                    Console.WriteLine("=============================");*/

                    fail = int.Parse(rd["count(*)"].ToString());
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.23");
            }
            return fail;
        }

        public void show_mem_info()
        {
            string sql = "select * from v_mem_info ";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();


            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    /*Console.WriteLine("시리얼: " + rd["inv_seq"]);
                    Console.WriteLine("시간: " + rd["inv_time"]);
                    Console.WriteLine("프로세스위치: " + rd["inv_fk_process"]);
                    Console.WriteLine("상태: " + rd["inv_condition"]);
                    Console.WriteLine("=============================");*/

                    string seq = rd["고객번호"].ToString();
                    string name = rd["이름"].ToString();
                    string dest = rd["배송지"].ToString();

                    Member mem = new Member(seq, name, dest);

                    BaseAdapter.mem_lst_Instance.Add(mem);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.24");
            }
        }

        public int show_invSuc_DB()
        {
            string sql = "select count(*) from inventory_t " +
                         "where inventory_t.inv_condition = '양호' and inventory_t.inv_fk_process = '프로세스5'";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            int suc = 0;


            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    /*Console.WriteLine("시리얼: " + rd["inv_seq"]);
                    Console.WriteLine("시간: " + rd["inv_time"]);
                    Console.WriteLine("프로세스위치: " + rd["inv_fk_process"]);
                    Console.WriteLine("상태: " + rd["inv_condition"]);
                    Console.WriteLine("=============================");*/

                    suc = int.Parse(rd["count(*)"].ToString());
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.25");
            }
            return suc;
        }

        

        public void show_del_info()
        {
            string sql = string.Format("select * from invetory_del_t");
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    string del_seq = rd["inv_d_seq"].ToString();
                    string mem_seq = rd["mem_fk_seq"].ToString();
                    string inv_seq = rd["inv_fk_seq"].ToString();
                    string currloc = rd["inv_d_curr_loc"].ToString();
                    string dest = rd["inv_d_dest_loc"].ToString();
                    string admin = rd["admin_fk_del_seq"].ToString();
                    string con = rd["del_condition"].ToString();

                    Del del = new Del(del_seq, mem_seq, inv_seq, currloc, dest, admin, con);

                    BaseAdapter.del_lst_Instance.Add(del);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.26");
            }
            rd.Close();
        }

        public void Update_inv_suc(string con, string inv)
        {
            try
            {
                string sql = string.Format("update inv_suc set " +
                    "inv_con = '{0}' " +
                    "where inv_fk_seq = {1}",
                    con, int.Parse(inv));
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류29: " + e.Message);
            }
        }

    }
}
