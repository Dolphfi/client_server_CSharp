using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVER2023.Domain
{
   public class Transaction
    {
        public Transaction()
        {
        }

        //attribut
        string code;
        string libele;
        DateTime dat;
       
        //constructeur
      
        public Transaction(string co, string lib, DateTime da)
        {
            this.code = co;
            this.libele = lib;
            this.dat = da;
          
        }
        public string Getcode()
        {
            return this.code;
        }
        public string GetLibele()
        {
            return this.libele;
        }
        public DateTime GetDate()
        {
            return this.dat;
        }
        

    }
}
