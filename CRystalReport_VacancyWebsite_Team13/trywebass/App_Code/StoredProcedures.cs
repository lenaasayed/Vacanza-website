using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace trywebass
{
    public class StoredProcedures
    {
        public static string SelectTypeByEmail = "SelectTypeByEmail";
        public static string SelectPassword = "SelectPassword";
        public static string InsertROOM = "INSERTROOMS";
        public static string InsertHotel = "INSERTHotel";
        public static string InsertService = "InsertService";
        public static string InsertServiceToOffer = "insertServiceToOffer";
        public static string insertoffer = "insertoffer";
        public static string insertPrecentageToOffer= "insertPrecentageToOffer";
        public static string EditServicePrice = "EditServicePrice";
        public static string UpdateRoomPrice = "UpdateRoomPrice";
        public static string insertTransportation = "insertTransportation";
        public static string TotalProfitsForHotel = "TotalProfitsForHotel";
        public static string TotalProfitsForHotelid = "TotalProfitsForHotelbyid";
        public static string totalnumhotelcountry = "NumOfHotelscountry";
        public static string totalnumhotelcity = "NumOfHotelscity";
        public static string totalnumhotel = "NumOfHotels";
        public static string userinfo = "userinfo";
        public static string hotelguests = "numOfHotelGuests";
        public static string review = "adminReviewsForCertainHotel";
        public static string makeadmin = "adduseradmin";
        public static string insertcity = "INSERTCITY";
        public static string insertcountry = "INSERTCOUNTRY";
        public static string deletecity = "deletecity";
        public static string deletecountry = "deletecountry";
        public static string deletehotel = "deletehotel";
        public static string HotelOrderStare = "getstarsordered";

    }
}