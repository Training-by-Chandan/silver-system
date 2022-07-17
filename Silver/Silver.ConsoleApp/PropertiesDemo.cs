namespace Silver.ConsoleApp
{
    public class StudentInfo
    {
        #region Basic Info

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        //private string lastName;
        //public string LastName
        //{
        //    get { return lastName; }
        //    set { lastName = value; }
        //}
        public string FullName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(MiddleName))
                {
                    return FirstName + " " + LastName;
                }
                else
                {
                    return FirstName + " " + MiddleName + " " + LastName;
                }
            }
        }

        #endregion Basic Info

        #region Marks Info

        private double _lower = 0;
        private double _upper = 100;
        private double _pass = 32;

        private double _math;

        public double Math
        {
            get { return _math; }
            set
            {
                if (value > _upper)
                {
                    _math = _upper;
                }
                else if (value < _lower)
                {
                    _math = _lower;
                }
                else
                {
                    _math = value;
                }
            }
        }

        private double _science;

        public double Science
        {
            get { return _science; }
            set
            {
                if (value > _upper)
                {
                    _science = _upper;
                }
                else if (value < _lower)
                {
                    _science = _lower;
                }
                else
                {
                    _science = value;
                }
            }
        }

        public double Total
        {
            get => Science + Math;
        }

        public double TotalMarks => Science + Math;

        public double Percentage
        {
            get
            {
                return (Total / (2 * _upper)) * 100;
            }
        }

        public string Division
        {
            get
            {
                if (Percentage >= 80)
                {
                    return "Distinction";
                }
                else if (Percentage >= 60)
                {
                    return "First Division";
                }
                else if (Percentage >= 45)
                {
                    return "Second Division";
                }
                else if (Percentage >= 32)
                {
                    return "Third Division";
                }
                else
                {
                    return "Failed";
                }
            }
        }

        public string Div => (Percentage >= 80) ? "Distinction" : (Percentage >= 60) ? "First Division" : (Percentage >= 45) ? "Second Division" : (Percentage >= 32) ? "Third Division" : "Failed";

        #endregion Marks Info
    }
}
