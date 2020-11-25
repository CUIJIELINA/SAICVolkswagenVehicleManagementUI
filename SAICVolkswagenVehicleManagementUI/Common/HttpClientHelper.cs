using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SAICVolkswagenVehicleManagementUI.Common
{
    public class HttpClientHelper
    {
        public HttpClientHelper(string baseAddr)
        {
            this.BaseAddr = baseAddr;
        }
        public  string BaseAddr { get; set; }
        HttpClient client = new HttpClient();
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="Url">控制器的名+参数</param>
        /// <returns>返回json字符串</returns>
        public  string Get(string Url)
        {
            
            //设置 API的 基地址
            client.BaseAddress = new Uri(BaseAddr);
            //设置 默认请求头ACCEPT
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //发送GET请求
            HttpResponseMessage msg =  client.GetAsync(Url).Result;
            //判断结果是否成功
            if (msg.IsSuccessStatusCode)
            {
                //返回响应结果
                return msg.Content.ReadAsStringAsync().Result;
            }
            //返回空字符串，表示响应错误
            return "";
        }

        public  string Delete(string Url)
        {
            HttpClient client = new HttpClient();
            //设置 API的 基地址
            client.BaseAddress = new Uri(BaseAddr);
            //设置 默认请求头ACCEPT
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //发送GET请求
            HttpResponseMessage msg = client.DeleteAsync(Url).Result;
            //判断结果是否成功
            if (msg.IsSuccessStatusCode)
            {
                //返回响应结果
                return msg.Content.ReadAsStringAsync().Result;
            }
            //返回空字符串，表示响应错误
            return "";
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="Url">控制器名</param>
        /// <param name="JsonData">json数据</param>
        /// <returns></returns>
        public  string Post(string Url,object JsonData)
        {
            
            //表头参数
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //转为链接需要的格式
            HttpContent httpContent = new JsonContent(JsonData);
            //请求
            HttpResponseMessage response = client.PostAsync(Url, httpContent).Result;
            if (response.IsSuccessStatusCode)
            {
                Task<string> t = response.Content.ReadAsStringAsync();
                if (t != null)
                {
                    return t.Result;
                }
            }
            return "";
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="Url">控制器名</param>
        /// <param name="JsonData">json数据</param>
        /// <returns></returns>
        public string Post(string Url, string JsonData)
        {
            HttpClient client = new HttpClient();
            //设置 API的 基地址
            client.BaseAddress = new Uri(BaseAddr);
            //设置 默认请求头ACCEPT
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //设置消息体
            HttpContent content = new StringContent(JsonData);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            //发送Post请求
            HttpResponseMessage msg = client.PostAsync(Url, content).Result;
            //判断结果是否成功
            if (msg.IsSuccessStatusCode)
            {
                //返回响应结果
                return msg.Content.ReadAsStringAsync().Result;
            }
            //返回空字符串，表示响应错误
            return "";
        }

        public  string Put(string Url, object JsonData)
        {
            HttpClient client = new HttpClient();
            //设置 API的 基地址
            client.BaseAddress = new Uri(BaseAddr);
            //设置 默认请求头ACCEPT
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //设置消息体
            HttpContent content = new JsonContent(JsonData);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            //发送Post请求
            HttpResponseMessage msg = client.PutAsync(Url, content).Result;
            //判断结果是否成功
            if (msg.IsSuccessStatusCode)
            {
                //返回响应结果
                return msg.Content.ReadAsStringAsync().Result;
            }
            //返回空字符串，表示响应错误
            return "";
        }

        public string del(string Url)
        {
            HttpClient client = new HttpClient();
            //设置 API的 基地址
            client.BaseAddress = new Uri(BaseAddr);
            //设置 默认请求头ACCEPT
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //设置消息体
            HttpContent content = new StringContent("");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            //发送Post请求
            HttpResponseMessage msg = client.PostAsync(Url, content).Result;
            //判断结果是否成功
            if (msg.IsSuccessStatusCode)
            {
                //返回响应结果
                return msg.Content.ReadAsStringAsync().Result;
            }
            //返回空字符串，表示响应错误
            return "";
        }
    }
}
