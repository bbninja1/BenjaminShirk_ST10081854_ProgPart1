using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHandler
{
    public class Dewey_Decimal
    {
        //Variables
        private double CallNumbers;
        private string DescriptionString;

        public Dewey_Decimal()
        {
            //empty constructor
        }

        #region Constructor
        //constructor that passes values
        public Dewey_Decimal(double callNumber, string Description)
        {
            this.DescriptionString = Description;
            this.CallNumbers = callNumber;
        }
        #endregion

        #region GetAndSetMethods
        /// <summary>
        /// Get/Set Methods
        /// </summary>
        //Get and set methods
        public double CallNumbers1 { get => CallNumbers; set => CallNumbers = value; }
        public string DescriptionString1 { get => DescriptionString; set => DescriptionString = value; }
        #endregion

        #region CallNumberCreationString
        /// <summary>
        /// To String
        /// </summary>
        /// <returns></returns>
        //To String for callnumber with numerical and string value
        public override string ToString()
        {
            string TotalNum = this.CallNumbers.ToString() + " " + this.DescriptionString;
            return TotalNum;
        }
        #endregion

       /* public bool Validate(string key, string value)
        {
            if (AlternativeDictionary.TryGetValue(key, out string correctValue))
            {
                return value.Equals(correctValue);
            }

            return false;
        }
       */
    }
}
//-------------------------------------------EndOFFile-----------------------------------------//
