using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;


namespace KarimiApp.Client.Repository.Util
{
    public class HttpClientAccess
    {
        private readonly Uri baseAddress;
        Configuration config;
        AppSettingsSection app;
        /// <summary>
        /// Initializes a new instance of the <see cref="DataAccess"/> class.
        /// </summary>
        public HttpClientAccess()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            app = config.AppSettings;
           
            this.baseAddress = new Uri(app.Settings["serverAddress"].Value);
        }

        public async Task<TOut> Post<TIn, TOut>(TIn model, string uri) where TOut : new()
        {
            TOut res = new TOut();

            //  if (model != null)
            //  {
            //      try
            //    {
            HttpClient hc = new HttpClient
            {
                MaxResponseContentBufferSize = int.MaxValue,
            };
            hc.DefaultRequestHeaders.Accept.Clear();
            hc.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            hc.BaseAddress = this.baseAddress;
            HttpResponseMessage hrm = await hc.PostAsync(uri, new StringContent(JsonConvert.SerializeObject(model)));
            string s = await hrm.Content.ReadAsStringAsync();
            if (hrm.StatusCode == System.Net.HttpStatusCode.OK)
            {
                res = JsonConvert.DeserializeObject<TOut>(await hrm.Content.ReadAsStringAsync());
                return res;
            }
            else
            {
                var msg = await hrm.Content.ReadAsStringAsync();
                throw new Exception(msg);
            }
            hc.Dispose();
            //   }
            // catch (Exception e)
            //  {

            //     System.Windows.Forms.MessageBox.Show(e.Message);

            //   }
            // /  
            //}

        }

        public async Task<TOut> Put<TIn, TOut>(TIn model, string uri) where TOut : new()
        {
            TOut res = new TOut();

            //  if (model != null)
            //  {
            //      try
            //    {
            HttpClient hc = new HttpClient
            {
                MaxResponseContentBufferSize = int.MaxValue,
            };
            hc.DefaultRequestHeaders.Accept.Clear();
            hc.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            hc.BaseAddress = this.baseAddress;
            HttpResponseMessage hrm = await hc.PutAsync(uri, new StringContent(JsonConvert.SerializeObject(model)));
            string s = await hrm.Content.ReadAsStringAsync();
            if (hrm.StatusCode == System.Net.HttpStatusCode.OK)
            {
                res = JsonConvert.DeserializeObject<TOut>(await hrm.Content.ReadAsStringAsync());
                return res;
            }
            else
            {
                var msg = await hrm.Content.ReadAsStringAsync();
                throw new Exception(msg);
            }
            hc.Dispose();
            //   }
            // catch (Exception e)
            //  {

            //     System.Windows.Forms.MessageBox.Show(e.Message);

            //   }
            // /  
            //}

        }
        public async Task<string> Delete(int id, string uri)
        {
           
            HttpClient hc = new HttpClient
            {
                MaxResponseContentBufferSize = int.MaxValue,
            };
            hc.DefaultRequestHeaders.Accept.Clear();
            hc.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            hc.BaseAddress = this.baseAddress;
            HttpResponseMessage hrm = await hc.DeleteAsync(uri+"?id="+id);
            if (hrm.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string s = await hrm.Content.ReadAsStringAsync();
                return s;
            }
            else
            {
                var msg = await hrm.Content.ReadAsStringAsync();
                throw new Exception(msg);
            }
            hc.Dispose();

        }
        public async Task<string> PostReturnString<TModel>(TModel model, string uri)
          where TModel : new()
        {
            string msg = "";
            if (model != null)
            {
                HttpClient hc = new HttpClient();
                hc.DefaultRequestHeaders.Accept.Clear();
                hc.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                hc.BaseAddress = this.baseAddress;
                HttpResponseMessage hrm = await hc.PostAsync(uri, new StringContent(JsonConvert.SerializeObject(model)));
                if (hrm.IsSuccessStatusCode == true)
                {
                    if (hrm.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        msg = await hrm.Content.ReadAsStringAsync().ConfigureAwait(false);
                    }

                }
                hc.Dispose();
            }
            return msg;
        }


        /// <summary>
        /// Gets the specified URI.
        /// </summary>
        /// <typeparam name="TModel">The type of the t model.</typeparam>
        /// <param name="uri">The URI.</param>
        /// <returns>Task&lt;List&lt;TModel&gt;&gt;.</returns>
        public async Task<TOut> Get<TOut>(string uri)
           where TOut : new()
        {
            TOut tmp = new TOut();
            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Accept.Clear();
            hc.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            hc.BaseAddress = this.baseAddress;
            HttpResponseMessage hrm = await hc.GetAsync(uri).ConfigureAwait(false);
            if (hrm.IsSuccessStatusCode == true)
            {
                if (hrm.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string s = await hrm.Content.ReadAsStringAsync().ConfigureAwait(false);
                    return JsonConvert.DeserializeObject<TOut>(s);
                }
            }

            hc.Dispose();
            return tmp;
        }
        public async Task<string> GetString(string uri)
        {
            string result = "";
            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Accept.Clear();
            hc.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            hc.BaseAddress = this.baseAddress;
            HttpResponseMessage hrm = await hc.GetAsync(uri).ConfigureAwait(false);
            if (hrm.IsSuccessStatusCode == true)
            {
                if (hrm.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result = await hrm.Content.ReadAsStringAsync().ConfigureAwait(false);
                }
            }

            hc.Dispose();
            return result;
        }
    }
}
