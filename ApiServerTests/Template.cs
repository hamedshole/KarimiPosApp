using ApiServer;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Shared.Model;
using System.Net.Http.Json;

namespace ApiServerTests
{
    public class Template<T> where T : class,new()
    {

        HttpClient _client;
        private readonly string _url;
        T _insertModel;
        T _updateModel;
        private readonly string getvaluue;
        private readonly string searchvalue;
        private readonly int deleteId;

        public Template(string url, T insertModel, T updateModel,string getvaluue,string searchvalue,int deleteId)
        {
            var factory = new WebApplicationFactory<Program>();
            _client = factory.CreateClient();
            _url = _client.BaseAddress + url;
            _url = url;
            _insertModel = insertModel;
            _updateModel = updateModel;
            this.getvaluue = getvaluue;
            this.searchvalue = searchvalue;
            this.deleteId = deleteId;
        }
        [Fact()]
        public void PostTest()
        {
            DepartmentModel model = new DepartmentModel()
            {
                Description = "",
                DefaultInventory = "سردخانه اصلی"
            ,
                Active = true,
                Title = "test"
            };
            string res = _client.PostAsJsonAsync(_url, _insertModel).Result.Content.ReadAsStringAsync().Result;
            Assert.Contains("آیتم", res);
        }

        [Fact()]
        public void PutTest()
        {
            DepartmentModel model = new DepartmentModel()
            {
                Id = 6,
                Description = "",
                DefaultInventory = "ویترین"
            ,
                Active = false,
                Title = "test"
            };
            string res = _client.PutAsJsonAsync(_url, _updateModel).Result.Content.ReadAsStringAsync().Result;
            Assert.Contains("تغییرات", res);
        }

        [Fact()]
        public void DeleteTest()
        {
            int id = 6;
            string res = _client.DeleteAsync(_url + "?id=" + deleteId).Result.Content.ReadAsStringAsync().Result;
            Assert.Contains("حذف", res);
        }

        [Fact()]
        public void GetAllTest()
        {
            var res = _client.GetAsync(_url).Result.Content.ReadFromJsonAsync<List<DepartmentModel>>().Result;
            Assert.NotNull(res);
        }

        [Fact()]
        public void GetTest()
        {
            string text = "ویترین";
            var res = _client.GetAsync(_url + "/get?text=" + getvaluue).Result.Content.ReadFromJsonAsync<DepartmentModel>().Result;
            Assert.NotNull(res);
        }

        [Fact()]
        public void SearchTest()
        {
            string text = "ویترین";
            var res1 = _client.GetAsync(_url + "/search?text=" + searchvalue).Result.Content.ReadAsStringAsync().Result;
            var list = JsonConvert.DeserializeObject<List<DepartmentModel>>(res1);

            Assert.NotNull(list);
        }


    }
}
