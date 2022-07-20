namespace Silver.ConsoleApp
{
    public class StudentInfo
    {
        public StudentInfo()
        {
        }

        public StudentInfo(double math, double science, double upper = 100)
        {
            _upper = upper;
            Math = math;
            Science = science;
        }

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
        public double Upper => _upper;
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

        private double _computer;

        public double Computer
        {
            get { return _computer; }
            set
            {
                if (value > _upper)
                {
                    _computer = _upper;
                }
                else if (value < _lower)
                {
                    _computer = _lower;
                }
                else
                {
                    _computer = value;
                }
            }
        }

        public double Total
        {
            get => Science + Math + Computer;
        }

        public double TotalMarks => Science + Math + Computer;

        public double Percentage
        {
            get
            {
                return (Total / (3 * _upper)) * 100;
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

        #region Operator Overloading

        public static StudentInfo operator +(StudentInfo a, StudentInfo b)
        {
            var totalMath = a.Math + b.Math;
            var totalScience = a.Science + b.Science;
            var totalComputer = a.Computer + b.Computer;
            var totalUpper = a.Upper + b.Upper;
            var res = new StudentInfo(totalMath, totalScience, totalUpper);
            return res;
        }

        public static StudentInfo operator +(StudentInfo a, int num)
        {
            a.Math += num;
            a.Science += num;
            a.Computer += num;

            return a;
        }

        public static StudentInfo operator +(StudentInfo a, float num)
        {
            a.Math += num;
            a.Science += num;
            a.Computer += num;

            return a;
        }

        public static StudentInfo operator +(StudentInfo a, double num)
        {
            a.Math += num;
            a.Science += num;
            a.Computer += num;

            return a;
        }

        public static StudentInfo operator +(int num, StudentInfo a)
        {
            a.Math += num;
            a.Science += num;
            a.Computer += num;

            return a;
        }

        public static StudentInfo operator ++(StudentInfo a)
        {
            a.Math++;
            a.Science++;
            a.Computer++;

            return a;
        }

        public static bool operator ==(StudentInfo a, StudentInfo b)
        {
            return (a.Math == b.Math && a.Science == b.Science);
        }

        public static bool operator !=(StudentInfo a, StudentInfo b)
        {
            return !(a.Math == b.Math && a.Science == b.Science);
        }

        #endregion Operator Overloading
    }
}
