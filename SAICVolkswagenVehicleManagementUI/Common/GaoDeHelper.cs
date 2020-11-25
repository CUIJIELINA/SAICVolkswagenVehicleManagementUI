using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SAICVolkswagenVehicleManagementUI.Common
{
    /// <summary>
    /// 高德地图调用帮助类
    /// </summary>
    public class GaoDeHelper
    {
        //高德平台申请的秘钥
        public static string SecretKey = "申请的秘钥";

        /// <summary>
        /// 获取经度纬度
        /// </summary>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <returns></returns>
        public static string GetGeocode(string address,string city)
        {
            string geocodeUrl = "http://restapi.amap.com/v3/geocode/geo?address={Address}&city={City}&output=json&key={SecretKey}"
                .Replace("{SecretKey}", SecretKey)
                .Replace("{Address}", address)
                .Replace("{City}", city);
            string geocode = WebClientDownloadInfoToString(geocodeUrl);
            geocode = GetLatitudeAndLongitude(geocode);
            return geocode;
        }

        /// <summary>
        /// 获取城市之间的距离
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="beginCity"></param>
        /// <param name="end"></param>
        /// <param name="endCity"></param>
        /// <returns></returns>
        public static string GetDistance(string begin,string beginCity,string end,string endCity)
        {
            string origin = GetGeocode(begin, beginCity);
            string destination = GetGeocode(end, endCity);
            string driveUri = "http://restapi.amap.com/v3/direction/driving?key={SecretKey}&origin={Origin}&destination={Destination}"
                .Replace("{SecretKey}", SecretKey)
                .Replace("{Origin}", origin)
                .Replace("{Destination}", destination);
            string result = WebClientDownloadInfoToString(driveUri);
            return result;
        }

        /// <summary>
        /// 模拟请求
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public static string WebClientDownloadInfoToString(string uri)
        {
            string result = string.Empty;
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers[HttpRequestHeader.ContentType] = "application/xml;charset=UTF-8";
                result = webClient.DownloadString(uri);
            }
            return result;
        }

        /// <summary>
        /// 解析返回的经度纬度信息
        /// </summary>
        /// <param name="GeocodeJsonFormat"></param>
        /// <returns></returns>
        public static string GetLatitudeAndLongitude(string GeocodeJsonFormat)
        {
            JObject o = JObject.Parse(GeocodeJsonFormat);
            string geocodes = (string)o["geocodes"][0]["location"];
            return geocodes;
        }
    }
}
