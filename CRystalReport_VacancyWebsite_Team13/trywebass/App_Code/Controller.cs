using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace trywebass
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        // public DataTable Selectdepmalnames(int salary)
        //{
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@SALARY", salary);
        //    string StoredProcedureName = StoredProcedures.depmalenames;
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        //}


        public int InsertRoom(string Hname, int roomnum, string type, string view, double price)
        {

            string StoredProcedureName = StoredProcedures.InsertROOM;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@room_num", roomnum);
            Parameters.Add("@HOTELNAME", Hname);
            Parameters.Add("@TYPE", type);
            Parameters.Add("@VIEW", view);
            Parameters.Add("@PRICE", price);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public int InsertHotel(string Hname, char star, string location, string city_name, int manager_id, string Describtion)
        {


            string StoredProcedureName2 = StoredProcedures.InsertHotel;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@location", location);
            Parameters.Add("@DESCRIBTION", Describtion);
            Parameters.Add("@mgr_id", manager_id);
            Parameters.Add("@city_name", city_name);
            Parameters.Add("@stars", star);
            Parameters.Add("@HOTELNAME", Hname);
            return dbMan.ExecuteNonQuery(StoredProcedureName2, Parameters);
        }


        public int InsertService(string servicename, double price, string hotelname)
        {


            string StoredProcedureName2 = StoredProcedures.InsertService;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@hotel_name", hotelname);
            Parameters.Add("@Service_name", servicename);
            Parameters.Add("@price", price);

            return dbMan.ExecuteNonQuery(StoredProcedureName2, Parameters);
        }
        public int InsertOffer(int offerid, string servicname, string hotelname)
        {
            string StoredProcedureName2 = StoredProcedures.InsertServiceToOffer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@hotel_name", hotelname);
            Parameters.Add("@offer_id", offerid);
            Parameters.Add("@service_name", servicname);
            return dbMan.ExecuteNonQuery(StoredProcedureName2, Parameters);
        }
        public int InsertAnewOffer(int offerid, DateTime Start, DateTime End, int precentage, string hotelname)
        {

            string StoredProcedureName2 = StoredProcedures.insertoffer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@hotel_name", hotelname);
            Parameters.Add("@offer_id", offerid);
            Parameters.Add("@start_date", Start);
            Parameters.Add("@End_date", End);
            dbMan.ExecuteNonQuery(StoredProcedureName2, Parameters);
            string StoredProcedureName = StoredProcedures.insertPrecentageToOffer;
            Dictionary<string, object> Parameters1 = new Dictionary<string, object>();
            Parameters1.Add("@offer_id", offerid);
            Parameters1.Add("@precen", precentage);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters1);
        }

        public int UpdateservicePrice(double price, string name, string hname)
        {
            string StoredProcedureName = StoredProcedures.EditServicePrice;
            Dictionary<string, object> Parameters1 = new Dictionary<string, object>();
            Parameters1.Add("@hotel_name", hname);
            Parameters1.Add("@price", price);
            Parameters1.Add("@service_name", name);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters1);


        }
        public int UpdateRoomPrice(double price, string type, string hname)
        {

            string StoredProcedureName = StoredProcedures.UpdateRoomPrice;
            Dictionary<string, object> Parameters1 = new Dictionary<string, object>();
            Parameters1.Add("@hotel_name", hname);
            Parameters1.Add("@price", price);
            Parameters1.Add("@type", type);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters1);
        }
        public int InsertTransportation(DateTime date, double time, double price, string meeting, string hotelname)
        {
            string StoredProcedureName = StoredProcedures.insertTransportation;
            Dictionary<string, object> Parameters1 = new Dictionary<string, object>();
            Parameters1.Add("@hotel_name", hotelname);
            Parameters1.Add("@Date", date);
            Parameters1.Add("@Time", time);
            Parameters1.Add("@PRICE", price);
            Parameters1.Add("@MEETING", meeting);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters1);


        }
        public object HotelProfits(string hotelname)
        {
            string StoredProcedureName = StoredProcedures.TotalProfitsForHotel;
            Dictionary<string, object> Parameters1 = new Dictionary<string, object>();
            Parameters1.Add("@Hotel_name", hotelname);


            return dbMan.ExecuteScalar(StoredProcedureName, Parameters1);
        }
        public object HotelProfitsbyid(int id)
        {
            string StoredProcedureName = StoredProcedures.TotalProfitsForHotelid;
            Dictionary<string, object> Parameters1 = new Dictionary<string, object>();
            Parameters1.Add("@Hotel_id", id);


            return dbMan.ExecuteScalar(StoredProcedureName, Parameters1);
        }
        public object SelectPassword(string email, string pass)
        {
            string StoredProcedureName = StoredProcedures.SelectPassword;
            Dictionary<string, object> Parameters1 = new Dictionary<string, object>();
            Parameters1.Add("@EMAIL", email);
            Parameters1.Add("@pass", pass);

            return dbMan.ExecuteScalar(StoredProcedureName, Parameters1);

        }
        public object SelectType(string email)
        {
            string StoredProcedureName = StoredProcedures.SelectTypeByEmail;
            Dictionary<string, object> Parameters1 = new Dictionary<string, object>();
            Parameters1.Add("@EMAIL", email);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters1);

        }

        public object numOfhotel_country(int countryID)
        {
            string StoredProcedureName = StoredProcedures.totalnumhotelcountry;
            Dictionary<string, object> Parameters1 = new Dictionary<string, object>();
            Parameters1.Add("@countryid", countryID);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters1);
        }
        public object numOfhotel_city(int cityID)
        {
            string StoredProcedureName = StoredProcedures.totalnumhotelcity;
            Dictionary<string, object> Parameters1 = new Dictionary<string, object>();
            Parameters1.Add("@cityid", cityID);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters1);
        }

        public object numOfhotel()
        {
            string StoredProcedureName = StoredProcedures.totalnumhotel;
            Dictionary<string, object> Parameters1 = new Dictionary<string, object>();
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters1);
        }
        public DataTable review(int id)
        {
            string StoredProcedureName = StoredProcedures.review;
            Dictionary<string, object> Parameters1 = new Dictionary<string, object>();
            Parameters1.Add("@hotelid", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters1);
        }
        public DataTable userinfo(int id)
        {
            string StoredProcedureName = StoredProcedures.userinfo;
            Dictionary<string, object> Parameters1 = new Dictionary<string, object>();
            Parameters1.Add("@userid", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters1);
        }
        public int insertcity(string name, int countryid)
        {
            string StoredProcedureName = StoredProcedures.insertcity;
            Dictionary<string, object> Parameters1 = new Dictionary<string, object>();
            Parameters1.Add("@CITY_NAME", name);
            Parameters1.Add("@COUNTRY_id", countryid);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters1);
        }
        public int insertcountry(string name)
        {
            string StoredProcedureName = StoredProcedures.insertcountry;
            Dictionary<string, object> Parameters1 = new Dictionary<string, object>();
            Parameters1.Add("@COUNTRY_NAME", name);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters1);
        }
        public int makeadmin(string email)
        {
            string StoredProcedureName = StoredProcedures.makeadmin;
            Dictionary<string, object> Parameters1 = new Dictionary<string, object>();
            Parameters1.Add("@useremail", email);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters1);
        }

        public int deletecity(int cityid)
        {
            string StoredProcedureName = StoredProcedures.deletecity;
            Dictionary<string, object> Parameters1 = new Dictionary<string, object>();
            Parameters1.Add("@cityid", cityid);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters1);
        }
        public int deletecountry(int countryid)
        {
            string StoredProcedureName = StoredProcedures.deletecountry;
            Dictionary<string, object> Parameters1 = new Dictionary<string, object>();
            Parameters1.Add("@countryid ", countryid);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters1);
        }
        public int deletehotel(int hotelid)
        {
            string StoredProcedureName = StoredProcedures.deletehotel;
            Dictionary<string, object> Parameters1 = new Dictionary<string, object>();
            Parameters1.Add("@hotelid", hotelid);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters1);
        }

        public DataTable HotelOrderp(char c)
        {
            string StoredProcedureName = StoredProcedures.HotelOrderStare;
            Dictionary<string, object> Parameters1 = new Dictionary<string, object>();
            Parameters1.Add("@c1", c);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters1);
        }


    }
}
