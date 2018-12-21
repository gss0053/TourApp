using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourApp
{
    public class Language
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

        private string necessary;

        public string Necessary
        {
            get { return necessary; }
            set { necessary = value; }
        }
        private string combination;

        public string Combination
        {
            get { return combination; }
            set { combination = value; }
        }
        private string combination2;

        public string Combination2
        {
            get { return combination2; }
            set { combination2 = value; }
        }
        private string within;

        public string Within
        {
            get { return within; }
            set { within = value; }
        }
        private string overlap;

        public string Overlap
        {
            get { return overlap; }
            set { overlap = value; }
        }

        public Language(string engName, string korName, string select_language, string select_region, string service_classification, string main_Category, string middle_class, string small_Category, string necessary, string combination, string combination2, string within, string overlap) : this(engName, korName, select_language, select_region, service_classification, main_Category, middle_class, small_Category)
        {
            this.necessary = necessary;
            this.combination = combination;
            this.combination2 = combination2;
            this.within = within;
            this.overlap = overlap;
        }


        private string post;

        public string Post
        {
            get { return post; }
            set { post = value; }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string home_page;

        public string Home_page
        {
            get { return home_page; }
            set { home_page = value; }
        }

        private string addr;
                
        public string Addr
        {
            get { return addr; }
            set { addr = value; }
        }
        private string main_txt;

        public string Main_txt
        {       
            get { return main_txt; }
            set { main_txt = value; }
        }

        public Language(string engName, string korName, string select_language, string select_region, string service_classification, string main_Category, string middle_class, string small_Category, string necessary, string combination, string combination2, string within, string overlap, string post, string phone, string home_page, string addr, string main_txt) : this(engName, korName, select_language, select_region, service_classification, main_Category, middle_class, small_Category, necessary, combination, combination2, within, overlap)
        {
            this.post = post;
            this.phone = phone;
            this.home_page = home_page;
            this.addr = addr;
            this.main_txt = main_txt;
        }
    }
}
