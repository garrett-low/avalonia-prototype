using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartedApp.Models
{
    public class TestCase
    {
        public string Title { get; set; }
        public string Setup {  get; set; }

        public TestCase(string title, string setup)
        {
            Title = title;
            Setup = setup;
        }
    }
}
