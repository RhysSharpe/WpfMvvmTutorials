using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIPTutorialMvvmDemo.Model
{
    /***
     * Next, build the Model.As stated previously,
     * The Model provides data for the ViewModel by pulling it from a repository
     * (as well as pushing it back to the repository for saving).
     * 
     * This is demonstrated below with the GetData() method,
     * which will return a simple List<string>.
     * 
     * Business logic is also applied in this layer,
     * and can be seen in the ConcatenateData() method.
     * 
     * This method builds the sentence “Hello, world!”
     * from the List<string> that was previously returned from our “repository”.
     * */
    public class HelloWorldModel
    {
        private List<string> repositoryData;

        public string ImportantInfo
        {
            get
            {
                return ConcatenateData(repositoryData);
            }
        }

        public HelloWorldModel()
        {
            repositoryData = GetData();
        }

        /// <summary>
        /// Simulates data retrieval from a repository
        /// </summary>
        /// <returns>List of strings</returns>
        private List<string> GetData()
        {
            repositoryData = new List<string>()
            {
                "Hello",
                "world"
            };
            return repositoryData;
        }

        /// <summary>
        /// Concatenate the information from the list into a fully formed sentence.
        /// </summary>
        /// <returns>A string</returns>
        private string ConcatenateData(List<string> dataList)
        {
            string importantInfo = dataList.ElementAt(0) + ", " + dataList.ElementAt(1) + "!";
            return importantInfo;
        }
    }
}
