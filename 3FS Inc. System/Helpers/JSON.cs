using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using _3FS_System.Helpers;
using _3FS_System.Models;
using _3FS_System.Repositories;
using _3FS_System.Global_Variables;
using Newtonsoft.Json;
using System.Net.Http;

namespace _3FS_System.Helpers
{
    public static class JSON
    {
        public static async Task GetMain()
        {
            string url = "http://api.warehauspro.com/api/v1/desktop/sync";
            //set http client to send the get request
            HttpClient client = new HttpClient();

            try
            {
                var httpResponseMessage = await client.GetAsync(url);
                //read the string from the response's content
                string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
                //print response
                Console.WriteLine(jsonResponse);

            }
            catch (Exception e)
            {
                //print error
                Console.WriteLine(e.Message);
            }
            finally
            {
                client.Dispose();
            }
        }

        public static async Task PostMain()
        {
            string url = "http://api.warehauspro.com/api/v1/desktop/sync";
            //set http client to send the get request
            //HttpClient client = new HttpClient();
            using (var client = new HttpClient())
            {
                try
                {
                    //Dummy data
                    ItemInventory item = new ItemInventory()
                    {
                        ItemID = 23,
                        BrandName = "Holcim",
                        ItemName = "Cement",
                        CategoryID = 1,
                        SRP = 200,
                        Capital = 190,
                        Storage = "Bodega A",
                        UpdatedDate = DateTime.Now
                    };

                    var jsonitem = JsonConvert.SerializeObject(item);
                    var payload = new StringContent(jsonitem, Encoding.UTF8, "application/json");
                    var Response = await client.PostAsync(url, payload);
                    var jsonResponse = Response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine(Response);
                    Console.WriteLine(jsonResponse);
                }
                catch (Exception e)
                {
                    //print error
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    client.Dispose();
                }
            }
        }

    }
}
