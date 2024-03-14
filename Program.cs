/*
 *    Author:     Christopher Lopez
 *    Course:     COMP-003A
 *    Purpose:    Code for a new patient for the health app.
 */
namespace HealthApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // User Input Section
            Console.WriteLine("********************************");
            Console.WriteLine("Avenal Clinic - New Patient Form");
            Console.WriteLine("********************************");
        
        // TODO: the first and last name performs a similar functionality. create a method to handle both.
        // First Name & Last Name 
        string GetValidNameInput(string prompt)
        {
            string name;
            do
            {
                Console.Write(prompt);
                name = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(name) || ContainsNumberOrSpecialCharacter(name));
              return name;
        }
            // First Name
            string firstName = GetValidNameInput("First Name: ");
            // Last Name
            string lastName = GetValidNameInput("Last Name: ");

        // TODO: move this birth year section to a method for code reusability
        // Birth Year
        int GetValidBirthYear()
        {
            int birthYear;
            do
            {
                Console.Write("Birth Year: ");
                string birthYearInput = Console.ReadLine();
                // TODO: what is the purpose of int.TryParse?
                // Ans: The method int.TryParse is used to attempt to parse the user input as an integer. 
                // TODO: what is the purpose of the out keyword?
                // Ans: The out keyword in int.TryParse is used to pass the birthYear variable as an output parameter.
                if (int.TryParse(birthYearInput, out birthYear) && birthYear >= 1900 && birthYear <= DateTime.Now.Year)
                {
                    break;
                }
                Console.WriteLine("Invalid birth year. Please enter a valid year.");
            }   while (true);// TODO: while(true) creates an infinite loop. what makes the loop stop?
                             // Ans: The while(true) loop creates an infinite loop, the loop is stopped by the break statement when the birth year is successfully parsed and within the valid range.
                return birthYear;
        }
            int birthYear = GetValidBirthYear();

        // TODO: move this gender section to a method for code reusability
        // Gender
        char GetValidGender()
        {
            char gender;
            do
            {
                Console.Write("Gender (M/F/O): ");
                string genderInput = Console.ReadLine();
                // TODO: normalize the genderInput so it accepts lowercase and uppercase inputs (e.g. 'm', 'f', 'o')
                if (char.TryParse(genderInput, out gender) && (char.ToUpper(gender) == 'M' || char.ToUpper(gender) == 'F' || char.ToUpper(gender) == 'O'))
                {
                break;
                }
                Console.WriteLine("Invalid gender. Please enter 'M', 'F', or 'O'.");
            } while (true);// TODO: while(true) creates an infinite loop. what makes the loop stop?
                           // Ans: the while (true) statement creates an infinite loop when valid but If the input is invalid, the program displays an error message and continues the loop until a valid gender is entered. 
              return gender;
        }
            char gender = GetValidGender();

        // Questionnaire
        List<string> responses = new List<string>();
        // TODO: consider creating a method to output these section displays
        void DisplaySectionHeader(string header)
        {
            Console.WriteLine("");
            Console.WriteLine("******************************************");
            Console.WriteLine(header);
            Console.WriteLine("******************************************");
        }
        DisplaySectionHeader("Please answer the following questionnaire");

        // TODO: create a data structure to hold the questions
        // TODO: create a reusable method to handle the questions and responses
        // TODO: create a looping statement to display the questions and get the responses
        List<string> questions = new List<string>
        {
                "Date of appointment MM/DD/YYYY",
                "Primary care provider (if applicable)",
                "Insurance provider (if applicable)"
        };
        void HandleQuestionResponse(string question)
        {
            string response;
            do
            {
                Console.Write($"{question}: ");
                response = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(response));
            responses.Add(response);
        }
            foreach (string question in questions)
            {
                HandleQuestionResponse(question);
            }
        
        // TODO: consider creating a method to output these section displays
        // Contact information title
        void DisplaySectionHeader2(string header2)
        {
            Console.WriteLine("");
            Console.WriteLine("******************************************");
            Console.WriteLine(header2);
            Console.WriteLine("******************************************");
        }
        DisplaySectionHeader2("Contact information");

        // TODO: create a data structure to hold the questions
        // TODO: create a reusable method to handle the questions and responses
        // TODO: create a looping statement to display the questions and get the responses
        List<string> questions2 = new List<string>
        {
                "Housing address",
                "Email address",
                "Phone number"
        };
        void HandleQuestionResponse2(string question2)
        {
            string response2;
            do
            {
                Console.Write($"{question2}: ");
                response2 = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(response2));
            responses.Add(response2);
        }
            foreach (string question2 in questions2)
            {
                HandleQuestionResponse2(question2);
            }

        // TODO: consider creating a method to output these section displays
        // Emergency contact information title
        void DisplaySectionHeader3(string header)
        {
            Console.WriteLine("");
            Console.WriteLine("******************************************");
            Console.WriteLine(header);
            Console.WriteLine("******************************************");
        }
        DisplaySectionHeader3("Emergency contact information");

        // TODO: create a data structure to hold the questions
        // TODO: create a reusable method to handle the questions and responses
        // TODO: create a looping statement to display the questions and get the responses
        List<string> questions3 = new List<string>
        {
                "Emergency contact first & last name",
                "Emergency contact phone number"
        };
        void HandleQuestionResponse3(string question3)
        {
            string response3;
            do
            {
                Console.Write($"{question3}: ");
                response3 = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(response3));
            responses.Add(response3);
        }
            foreach (string question3 in questions3)
            {
                HandleQuestionResponse3(question3);
            }

        // TODO: consider creating a method to output these section displays
        // Symptoms title
        void DisplaySectionHeader4(string header)
        {
            Console.WriteLine("");
            Console.WriteLine("******************************************");
            Console.WriteLine(header);
            Console.WriteLine("******************************************");
        }
        DisplaySectionHeader4("Symptoms");

        // TODO: create a data structure to hold the questions
        // TODO: create a reusable method to handle the questions and responses
        // TODO: create a looping statement to display the questions and get the responses
        List<string> questions4 = new List<string>
        {
                "Nausea",
                "Stomach pain",
                "Constipation",
                "Blood in stool",
                "Vomiting",
                "Fever or chills",
                "Fatigue or weakness",
                "Unexplained weight loss or gain",
                "Changes in appetite",
                "Persistent pain or discomfort",
                "Shortness of breath or difficulty breathing",
                "Chest pain or tightness",
                "Palpitations or irregular heartbeats",
                "Dizziness or lightheadedness",
                "Persistent cough or coughing up blood",
                "Difficulty swallowing",
                "Changes in urination (frequency, urgency, pain, blood in urine)",
                "Skin rashes, lesions, or changes in moles",
                "Swelling or lumps in the body",
                "Joint pain or stiffness",
                "Headaches or migraines",
                "Changes in vision or hearing",
                "Mood changes, depression, or anxiety",
                "Sleep disturbances or insomnia"
};    
        void HandleQuestionResponse4(string question4)
        {
            string response4;
            do
            {
               Console.Write($"{question4} Y/N: ");
               response4 = Console.ReadLine();
            } while (!IsValidResponse(response4));
             responses.Add(response4);
        }
            // Method to validate the response (Y/N)
            bool IsValidResponse(string response4)
            {
                return !string.IsNullOrWhiteSpace(response4) && (response4.Equals("Y", StringComparison.OrdinalIgnoreCase) || response4.Equals("N", StringComparison.OrdinalIgnoreCase));
            }
            foreach (string question4 in questions4)
            {
                HandleQuestionResponse4(question4);
            }

            // Profile Summary Section
            Console.WriteLine();
            Console.WriteLine("                           Profile Summary                         ");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Full Name: " + lastName + ", " + firstName);
            Console.WriteLine("Age: " + CalculateAge(birthYear));
            Console.WriteLine("Gender: " + GetGenderDescription(gender));
            Console.WriteLine("                       Questionnaire Responses                     ");
            Console.WriteLine("-------------------------------------------------------------------");

            // TODO: what is the purpose of responses.Count?
            // Ans: The purpose of responses.Count is to determine the number of elements in the responses list.
            // TODO: why is i initialized at 0?
            // Ans: The loop variable i is initialized at 0 because, the array and list indexes start from 0.
            for (int i = 0; i < responses.Count; i++)
            {
                // TODO: what is the purpose of i + 1 here?
                // Ans: The purpose of i + 1 is to display the question number in the output.
                Console.WriteLine("Question " + (i + 1) + ": " + responses[i]);
            }

            // TODO: what is the purpose of the line below?
            // Ans: the purpose of this ReadLine is so it spaces the text a level.
            Console.ReadLine();
        }

        // The input string to checks if the input contains a number or special character, otherwise checks if the input contains a number or special character
        static bool ContainsNumberOrSpecialCharacter(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c) || char.IsPunctuation(c) || char.IsSymbol(c))
                {
                    return true;
                }
            }
            return false;
        }

        // Calculates the age based on the birth year and the current year
        static int CalculateAge(int birthYear)
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - birthYear;
        }

        // Returns the gender description based on the provided gender character
        static string GetGenderDescription(char gender)
        {
            switch (gender)
            {
                case 'M':
                    return "Male";
                case 'F':
                    return "Female";
                case 'O':
                    return "Other";
                default:
                    return "Unknown";
                    // TODO: what is the purpose of this line if it is unreachable?
                    // Ans: If the provided gender character does not match any of the cases, the default "Unknown" case is returned as the gender description.
            }
        }
    }
}