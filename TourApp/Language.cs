using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourApp
{
    class Language
    {
        private string engName;

        public string EngName
        {
            get { return engName; }
            set { engName = value; }
        }
        private string korName;

        public string KorName
        {
            get { return korName; }
            set { korName = value; }
        }
      
        private string select_language;

        public string Select_language
        {
            get { return select_language; }
            set { select_language = value; }
        }
        private string select_region;

        public string Select_region
        {
            get { return select_region; }
            set { select_region = value; }
        }
        private string service_classification;

        public string Service_classification
        {
            get { return service_classification; }
            set { service_classification = value; }
        }
        private string main_Category;

        public string Main_Category
        {
            get { return main_Category; }
            set { main_Category = value; }
        }
        private string middle_class;

        public string Middle_class
        {
            get { return middle_class; }
            set { middle_class = value; }
        }
        private string small_Category;

        public string Small_Category
        {
            get { return small_Category; }
            set { small_Category = value; }
        }

        public Language()
        {
        }

        public Language(string engName, string korName, string select_language, string select_region, string service_classification, string main_Category, string middle_class, string small_Category)
        {
            this.engName = engName;
            this.korName = korName;
            this.select_language = select_language;
            this.select_region = select_region;
            this.service_classification = service_classification;
            this.main_Category = main_Category;
            this.middle_class = middle_class;
            this.small_Category = small_Category;
        }
    }
}
