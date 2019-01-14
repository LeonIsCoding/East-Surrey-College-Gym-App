namespace GymApp {
    /// <summary>
    /// This class stores information from the 'CustomerDetails' form. It can be accessed from anywhere in the application.
    /// </summary>
    class Customer{

        // Constructor
        public Customer() {
            Title = string.Empty;
            Firstname = string.Empty;
            Surname = string.Empty;
            Address = string.Empty;
            Email = string.Empty;
            PhoneNumber = string.Empty;
            Membership = false;
        }

        // Properties
        /// <summary>
        /// This property holds the customer's title
        /// </summary>
        public string Title { get; set; } 
        /// <summary>
        /// This property holds the customer's first name
        /// </summary>
        public string Firstname { get; set; }
        /// <summary>
        /// This property hold the customer's surname
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// This property hold the customer's address
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// This property hold the customer's email address
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// This property hold the customer's phone number
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// This property holds a true or false if the customer is already a member
        /// </summary>
        public bool Membership { get; set; }
        /// <summary>
        /// This property holds the Basal Metabolic Rate
        /// </summary>
        public double BMR { get; set; }
        /// <summary>
        /// This property holds the Body Mass Index
        /// </summary>
        public double BMI { get; set; }
        /// <summary>
        /// This property holds the Body Mass Index
        /// </summary>
        public string BMICategory { get; set; }
        /// <summary>
        /// This property holds a flag that indicates that the calculations have to be done for 
        /// male or female depending whether its true or false. If true then it's a male
        /// </summary>
        public bool IsMale { get; set; }
        /// <summary>
        /// This property holds the Recommended Daily Intake which is a measurement of Kilocalorie
        /// </summary>
        public double RDI { get; set; }
        /// <summary>
        /// This property holds the exercise level which is a string which is the selected item from the UI control
        /// </summary>
        public string ExerciseLevel { get; set; }

        // This class has no methods at the moment, simply used for storage
        // We'll probably use methods to get from a database and update
    }
}
