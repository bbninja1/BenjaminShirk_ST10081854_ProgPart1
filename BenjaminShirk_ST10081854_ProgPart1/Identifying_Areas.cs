using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenjaminShirk_ST10081854_ProgPart1
{
    class Identifying_Areas
    {
        /// <summary>
        /// Variables and Dictionaries
        /// </summary>
        //Create Random Refrence
        Random R = new Random();
        //Dictionary to store the callnumbers and their description type string
        private Dictionary<string, string> DataDictionary = new Dictionary<string, string>();
        private Dictionary<string, string> AlternativeDictionary = new Dictionary<string, string>();
        //Array for wrong answers of size 2
        string[] AlternateArray = new string[3]; 
        //Alternate between call numbers, and description questions
        private int AlternativeQuestionsColumn = 0;

        public Identifying_Areas()
        {
            #region Add Data To Dictionary
            //Adding Data To My Dictionaries
            DataDictionary1.Add("000-099", "General Works");
            DataDictionary1.Add("100-199", "Philosophy and Psychology");
            DataDictionary1.Add("200-299", "Religion");
            DataDictionary1.Add("300-399", "Social Sciences");
            DataDictionary1.Add("400-499", "Language");
            DataDictionary1.Add("500-599", "Natural Sciences and Mathematics");
            DataDictionary1.Add("600-699", "Technology");
            DataDictionary1.Add("700-799", "The Arts");
            DataDictionary1.Add("800-899", "Literature and Rhetoric");
            DataDictionary1.Add("900-999", "History, Biography, and Geography");
            #endregion
        }

        #region Get/Set Methods
        //gets and sets methods
        public Dictionary<string, string> AlternativeDictionary1 { get => AlternativeDictionary; set => AlternativeDictionary = value; }
        public int AlternativeQuestionsColumn1 { get => AlternativeQuestionsColumn; set => AlternativeQuestionsColumn = value; }
        public string[] AlternateArray1 { get => AlternateArray; set => AlternateArray = value; }
        public Dictionary<string, string> DataDictionary1 { get => DataDictionary; set => DataDictionary = value; }
        #endregion

        #region Generate Question
        //generate a random question using the Dewey Decimal Dictionary
        public void GenerateQuestion()
        {
            List<KeyValuePair<string, string>> possibleAnswers = new List<KeyValuePair<string, string>>(DataDictionary);
            AlternativeDictionary.Clear();

            // Correct Answer
            for (int i = 0; i < 4; i++)
            {
                int randomIndex = GetRandomIndex(possibleAnswers);
                KeyValuePair<string, string> correctAnswer = possibleAnswers[randomIndex];
                AlternativeDictionary.Add(correctAnswer.Key, correctAnswer.Value);
                possibleAnswers.RemoveAt(randomIndex);
            }

            // Wrong Answers
            for (int n = 0; n < 3; n++)
            {
                int randomIndex = GetRandomIndex(possibleAnswers);
                KeyValuePair<string, string> wrongAnswer = possibleAnswers[randomIndex];

                // Select either the key or value based on the condition
                string alternative = (AlternativeQuestionsColumn % 2 == 0) ? wrongAnswer.Value : wrongAnswer.Key;
                AlternateArray[n] = alternative;

                possibleAnswers.RemoveAt(randomIndex);
            }
        }
        #endregion

        #region RandomIndex
        // Helper method to get a random index
        private int GetRandomIndex(List<KeyValuePair<string, string>> listIndex)
        {
            if (listIndex.Count == 0)
            {
                return -1;
            }
            return R.Next(listIndex.Count);
        }
        #endregion

        #region Shuffle List/Dictionary Data
        //randomly shuffle the answers of the question
        public List<string> Shuffle(List<string> SchuffleLists)
        {
            int count = SchuffleLists.Count;
            for (int i = count - 1; i > 0; i--)
            {
                int randomValue = R.Next(0, i + 1);
                string temp = SchuffleLists[i];
                SchuffleLists[i] = SchuffleLists[randomValue];
                SchuffleLists[randomValue] = temp;
            }
            return SchuffleLists;
        }
        #endregion

        #region Validation
        // Checks the answer dictionary
        public bool Validate(string key, string value)
        {
            bool Validity = false;
            if (AlternativeDictionary.ContainsKey(key))
            {
                string correctValue = AlternativeDictionary[key];
                if (value.Equals(correctValue)) Validity = true;
            }
            return Validity;
        }
        #endregion
    }
}
//-------------------------------------------EndOFFile-----------------------------------------//