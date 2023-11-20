using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListHandler;

namespace BenjaminShirk_ST10081854_ProgPart1
{
    public class Replacing_Books
    {
        #region Variables
        public List<Dewey_Decimal> sList = new List<Dewey_Decimal>();
        public List<Dewey_Decimal> dList = new List<Dewey_Decimal>();
        public Char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public Random randomizer = new Random();
        #endregion

        #region Constructor
        public Replacing_Books()
        {
            //creates the lists
            this.List();
        }
        #endregion

        #region GetAndSetMethods
        /// <summary>
        /// Get/Set Methods
        /// </summary>
        public List<Dewey_Decimal> DList { get => dList; set => dList = value; }
        #endregion

        #region Create and SortList
        /// <summary>
        /// Sort of the lists 
        /// </summary>
        /// <returns></returns>
        //method that will sort the books into the sorted List of books
        public List<Dewey_Decimal> SortedList()
        {
            sList = dList;

            //sort method
            sList.Sort(delegate (Dewey_Decimal List1, Dewey_Decimal List2)
                {
                    var Num = List1.CallNumbers1.CompareTo(List2.CallNumbers1);
                    return Num == 0? List1.DescriptionString1.CompareTo(List2.DescriptionString1) : Num;
            });
            return sList;
        }

        //alternative sort thats not used
        /// <summary>
        /// ChatGPT generated alternative sorting method
        /// </summary>
        /// <returns></returns>
        public List<Dewey_Decimal> SortedList2()
        {
            List<Dewey_Decimal> sList = new List<Dewey_Decimal>(dList);

            sList = sList.OrderBy(item => item.CallNumbers1)
                         .ThenBy(item => item.DescriptionString1)
                         .ToList();

            return sList;
        }

        #endregion

        #region CreateList
        /// <summary>
        /// Creating of the book lists
        /// </summary>
        //Method to create the list of books
        public void List()
        {
            //for loop for the 10 books creation
            for (int i = 0; i < 10; i++)
            {
                //Variables that make up the callnumber on the books
                //this is the numerical value on the book
                string AuthBookString = "";
                double Num1 = randomizer.Next(0, 999);
                double Num2 = randomizer.NextDouble();
                double FullNumber = Math.Round(Num1 + Num2, 2);
                Dewey_Decimal CNum = new Dewey_Decimal();

                //for loop for the string value of the callnumber on the books
                for (int j = 0; j < 3; j++)
                {
                    //used Num as a randomozer between 26 letters in the alphabet
                    int Num = randomizer.Next(1,26);
                    AuthBookString += chars[Num];
                }

                //set the 10 numerical and string value book to the list
                CNum.CallNumbers1 = FullNumber;
                CNum.DescriptionString1 = AuthBookString;
                DList.Add(CNum);
            }
        }
        #endregion

    }
}
//-------------------------------------------EndOFFile-----------------------------------------//