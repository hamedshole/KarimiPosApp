using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Json;
using Shared.Model;
using Newtonsoft.Json;
using ApiServer;

namespace ApiServerTests.Controllers
{
    public class DepartmentControllerTests
    {
        HttpClient _client;
        private readonly string _url;
        public DepartmentControllerTests()
        {

            var factory = new WebApplicationFactory<Program>();
            _client = factory.CreateClient();
            _url = _client.BaseAddress + "api/department";
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
                Title = "test2"
            };
            string res = _client.PostAsJsonAsync(_url, model).Result.Content.ReadAsStringAsync().Result;
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
            string res = _client.PutAsJsonAsync(_url, model).Result.Content.ReadAsStringAsync().Result;
            Assert.Contains("تغییرات", res);
        }

        [Fact()]
        public void DeleteTest()
        {
            int id = 6;
            string res = _client.DeleteAsync(_url + "?id=" + id).Result.Content.ReadAsStringAsync().Result;
            Assert.Contains("حذف", res);
        }

        [Fact()]
        public void GetAllTest()
        {
            var res = _client.GetAsync(_client.BaseAddress + "api/department").Result.Content.ReadFromJsonAsync<List<DepartmentModel>>().Result;
            Assert.NotNull(res);
        }

        [Fact()]
        public void GetTest()
        {
            string text = "ویترین";
            var res = _client.GetAsync(_url + "/get?text=" + text).Result.Content.ReadFromJsonAsync<DepartmentModel>().Result;
            Assert.NotNull(res);
        }

        [Fact()]
        public void SearchTest()
        {
            string text = "ویترین";
            var res1 = _client.GetAsync(_url + "/search?text=" + text).Result.Content.ReadAsStringAsync().Result;
            var list = JsonConvert.DeserializeObject<List<DepartmentModel>>(res1);

            Assert.NotNull(list);
        }
    }
}