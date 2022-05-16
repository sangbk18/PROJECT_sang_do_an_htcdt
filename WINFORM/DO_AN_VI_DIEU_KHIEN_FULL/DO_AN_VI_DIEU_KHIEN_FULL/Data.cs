using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN_VI_DIEU_KHIEN_FULL
{
    public class Data
    {
        private string Nhietdo;
        private string Doam;
        private string Bom;
        private string Den;
        public string nhietdo
        {
            get { return Nhietdo; }
            set 
            {
                if (int.Parse(value) > 100) Nhietdo = "0";
                else
                {
                    Nhietdo = value;
                }    
            }
        }
        public string doam
        {
            get { return Doam; }
            set { Doam = value; }
        }
        public string bom
        {
            get { return Bom; }
            set { Bom = value; }
        }
        public string den
        {
            get { return Den; }
            set { Den = value; }
        }
        public Data(string nhietdo,string doam,string state_bom,string state_den)
        {
            this.Nhietdo = nhietdo;
            this.Doam = doam;
            this.Bom = state_bom;
            this.Den = state_den;
        }
    }
}
