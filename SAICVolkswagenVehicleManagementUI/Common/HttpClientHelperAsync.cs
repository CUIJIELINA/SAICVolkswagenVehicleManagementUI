using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace SAICVolkswagenVehicleManagementUI.Common
{
    public class HttpClientHelperAsync
    {
        public string BaseAddr { get; set; }
        public HttpClientHelperAsync(string baseAddr)
        {
            this.BaseAddr = baseAddr;
        }
        #region 获取数据
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="Url">控制器名+参数</param>
        /// <returns>返回json字符串</returns>
        public async Task<string> GetAsync(string Url)
        {
            HttpClient client = new HttpClient();
            //设置默认请求头Accept
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //发送Get请求
            HttpResponseMessage message = await client.GetAsync(Url);
            //判断结果是否成功
            if (message.IsSuccessStatusCode)
            {
                //返回响应结果
                return await message.Content.ReadAsStringAsync();
            }
            //返回空字符串，表示响应错误
            return "";
        }
        #endregion

        #region 删除数据
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="Url">控制器名+参数</param>
        /// <returns>返回json字符串</returns>
        public async Task<string> DeleteAsync(string Url)
        {
            HttpClient client = new HttpClient();
            //设置API的基地址
            client.BaseAddress = new Uri(BaseAddr);
            //设置默认请求头Accept
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //发送Get请求
            HttpResponseMessage message = await client.DeleteAsync(Url);
            //判断结果是否成功
            if (message.IsSuccessStatusCode)
            {
                //返回响应结果
                return await message.Content.ReadAsStringAsync();
            }
            //返回空字符串
            return "";
        }
        #endregion

        #region 添加请求
        /// <summary>
        /// 添加请求
        /// </summary>
        /// <param name="Url">控制器名</param>
        /// <param name="JsonData">json数据</param>
        /// <returns>返回json字符串</returns>
        public async Task<string> PostAsync(string Url, string JsonData)
        {
            HttpClient client = new HttpClient();
            //设置API的基地址
            client.BaseAddress = new Uri(BaseAddr);
            //设置默认请求头Accept
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //设置消息体
            HttpContent content = new StringContent(JsonData);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            //发送Post请求
            HttpResponseMessage message = await client.PostAsync(Url, content);
            //判断结果是否成功
            if (message.IsSuccessStatusCode)
            {
                //返回响应结果
                return await message.Content.ReadAsStringAsync();
            }
            //返回空字符串表示响应错误
            return "";
        }
        #endregion

        #region 修改请求
        /// <summary>
        /// 修改请求
        /// </summary>
        /// <param name="Url">控制器名</param>
        /// <param name="JsonData">json数据</param>
        /// <returns></returns>
        public async Task<string> PutAsync(string Url, string JsonData)
        {
            HttpClient client = new HttpClient();
            //设置API的基地址
            client.BaseAddress = new Uri(BaseAddr);
            //设置默认请求头Accept
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //设置消息体
            HttpContent content = new StringContent(JsonData);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            //发送put请求
            HttpResponseMessage message = await client.PutAsync(Url, content);
            //判断结果是否成功
            if (message.IsSuccessStatusCode)
            {
                //返回响应结果
                return await message.Content.ReadAsStringAsync();
            }
            //返回空字符串，表示响应错误
            return "";
        }
        #endregion

    }
}
