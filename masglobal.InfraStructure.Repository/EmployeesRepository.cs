using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

using masglobal.ApplicationDTO;
using System.Linq;
using masglobal.InfraStructure.Interface;

namespace masglobal.InfraStructure.Repository
{
    public class EmployeesRepository : IEmployeesRepository
    {

        public IEnumerable<EmployeesDTO> GetEmployees(string Id)
        {
            IEnumerable<EmployeesDTO> response;
            try
            {
                #region Consumiendo API
                string urlAPI = "http://masglobaltestapi.azurewebsites.net/api/Employees";
                WebRequest wrGETURL;
                wrGETURL = WebRequest.Create(urlAPI);
                wrGETURL.Method = "GET";
                wrGETURL.ContentType = @"application/json; charset=utf-8";


                HttpWebResponse webresponse = wrGETURL.GetResponse() as HttpWebResponse;
                Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
                // read response stream from response object
                StreamReader loResponseStream = new StreamReader(webresponse.GetResponseStream(), enc);
                // read string from stream data
                string Result = loResponseStream.ReadToEnd();
                // close the stream object
                loResponseStream.Close();
                // close the response object
                webresponse.Close();

                #endregion

                var result = JsonConvert.DeserializeObject<IEnumerable<EmployeesDTO>>(Result);
                response = Id == string.Empty ? result : result.Where(x => x.id.Equals(int.Parse(Id)));
                return response;
            }
            catch (System.Exception)
            {
                throw;
            }   
        }
    }
}
