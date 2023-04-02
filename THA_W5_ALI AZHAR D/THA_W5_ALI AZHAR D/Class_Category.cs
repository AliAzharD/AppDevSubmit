using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THA_W5_ALI_AZHAR_D
{
    internal class Class_Category
    {
        public string IDCategory;
        public string NamaCategory;

        public Class_Category(string iDCategory, string namaCategory)
        {
            IDCategory = iDCategory;
            NamaCategory = namaCategory;
        }

        public string getIDCategory() 
        { 
            return IDCategory; 
        }
        public void setIDCategory(string IDCategory)
        {
            this.IDCategory = IDCategory;
        }
        public string getNamaCategory()
        {
            return NamaCategory;
        }
        public void setNamaCategory(string NamaCategory)
        {
            this.NamaCategory = NamaCategory;
        }
    }
    
}
