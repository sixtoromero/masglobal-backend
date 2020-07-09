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

        public IEnumerable<EmployeesDTO> GetEmployees(int Id, string TypeContract)
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
                if (TypeContract == "All")
                {
                    response = Id == 0 ? result : result.Where(x => x.id.Equals(Id));
                }
                else
                {
                    response = Id == 0 ? result.Where(x => x.contractTypeName.Equals(TypeContract)) : result.Where(x => x.id.Equals(Id) && x.contractTypeName.Equals(TypeContract));
                }
                return response;
            }
            catch (System.Exception)
            {
                throw;
            }   
        }
    }
}
