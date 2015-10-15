using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedWebTechnologies_Prac1
{
    public class Prac1
    {
        String Name;

        static void Main1(string[] args)
        {
            Prac1 pro = new Prac1();
            Console.WriteLine("Your Name Is : ");
            pro.Name = Console.ReadLine();
            Console.WriteLine("Hello " + pro.Name);
            Console.WriteLine();
            Console.WriteLine("Press Any Key To Exit");
            Console.ReadLine();
        }
    }
}
namespace AdvancedWebTechnologies_Prac2
{
    public class Program
    {
        public void addNumber()
        {
            int i = 0;
            int num = 1;
            int sum = 0;
            for (i = 0; i < 10; i++)
            {
                sum = sum + num;
                Console.WriteLine(num);
                num++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        static void Main2(string[] args)
        {
            Program pro = new Program();
            pro.addNumber();
        }
    }
}
namespace AdvancedWebTechnologies_Prac3
{
        public class Program{

        int firstNumber { get; set; }
        int secondNumber { get; set; }

        public Program() {
            Console.WriteLine("Welcome to the adding calculator!");
            Console.ReadKey();
        }
        public void getFirstNumber() {
            Console.WriteLine("Enter Integer");
            firstNumber = Convert.ToInt16(Console.ReadLine());
        }
        public void getSecondNumber()
        {
            Console.WriteLine("Enter Integer");
            secondNumber = Convert.ToInt16(Console.ReadLine());
        }
        public void sumNumbers() {
            Console.WriteLine("Sum: " + secondNumber + firstNumber);
            Console.ReadKey(); 
        }

        static void Main3(string[] args) {
            Program pro = new Program();
            pro.getFirstNumber();
            pro.getSecondNumber();
            pro.sumNumbers();
            }
        }
}
namespace AdvancedWebTecnologies_Prac4 {

    public class Prac4 {

        int first_number { get; set; }
        int second_number { get; set; }
        string oper_ator { get; set; }
        int sum { get; set; }

        public Prac4() {
            Console.WriteLine("Welcome to Calculator");
        }

        public void getFirstNumber() {
            Console.WriteLine("Enter first number");
            first_number = Convert.ToInt16(Console.ReadLine());
        }

        public void getSecondNumber() {
            Console.WriteLine("Enter second number");
            second_number = Convert.ToInt16(Console.ReadLine());
        }

        public void getOperator() {
            Console.WriteLine("Enter a valid Operator *,/,-,+");
            oper_ator = Console.ReadLine();
        }

        public void performCalculation() {
            
            switch (oper_ator) {
                case "*": sum = first_number * second_number;
                    break;
                case "/": sum = first_number / second_number;
                    break;
                case "-": sum = first_number - second_number;
                    break;
                case "+": sum = first_number + second_number;
                    break;
            }
        }

        public void displayResult() {
            Console.WriteLine(sum);
            //Console.ReadKey();
        }

        public void doSomeWork(Prac4 prog) {
            prog.getFirstNumber();
            prog.getSecondNumber();
            prog.getOperator();
            prog.performCalculation();
            prog.displayResult();
            doSomeWork(prog);

        }

        public static void Main4(string[] args) {
            Prac4 prog = new Prac4();
            prog.doSomeWork(prog);
            
        }

    }

}
namespace AdvancedWebTecnologies_Prac5 {

    public class EmployeeStore {

        static void Main5(string[] args) {

            try
            {
                // Create a new employee
                Employee employee = new Employee();

                // Set some properties
                employee.FirstName = "Timothy";
                employee.MiddleName = "Arthur";
                employee.LastName = "Tucker";
                employee.SSN = "555-55-5555";

                // Show the results on screen
                string name = employee.FullName;
                string ssn = employee.SSN;

                Console.WriteLine("Name: {0}, SSN: {1}", name, ssn);

                Console.ReadLine();
            }
            catch (Exception exception)
            {
                // Display any errors on screen
                Console.WriteLine(exception.Message);
            }
        }
    }

    class Employee {
        private string m_firstName;
        private string m_middleName;
        private string m_lastName;
        private string m_SSN;

        // FirstName property
        public string FirstName {
            get { return m_firstName; }
            set { m_firstName = value; }
        }
        // MiddleName property
        public string MiddleName {
            get { return m_middleName; }
            set { m_middleName = value; }
        }
        // LastName property
        public string LastName {
            get { return m_lastName; }
            set { m_lastName = value; } 
        }
        // FullName
        public string FullName {
            get { return FirstName + " " + MiddleName + " " + LastName; }
        }
        // SSN property
        public string SSN {
            get { return m_SSN; }
            set { m_SSN = value; }
        }
    }

}
namespace AdvancedWebTecnologies_Prac12{

    public class EmployeeStore
    {

        static void Main12(string[] args)
        {

            try
            {
                // Create a new employee
                Employee employee = new Employee();

                // Create an new address
                Address address = new Address();

                // Set some properties
                employee.FirstName = "Timothy";
                employee.MiddleName = "Arthur";
                employee.LastName = "Tucker";
                employee.SSN = "555-55-5555";
                address.street = " new road";
                address.postCode = "Nr4 i4f";
                address.country = "England";
                employee.address = address;

                // Show the results on screen
                string name = employee.FullName;
                string ssn = employee.SSN;
                string country = employee.address.country;


                Console.WriteLine("Name: {0}, SSN: {1}, Country: {2}", name, ssn, country);

                Console.ReadLine();
            }
            catch (Exception exception)
            {
                // Display any errors on screen
                Console.WriteLine(exception.Message);
            }
        }
    }

    class Employee
    {
        private string m_firstName;
        private string m_middleName;
        private string m_lastName;
        private string m_SSN;
        public Address address { get; set; }

        // FirstName property
        public string FirstName
        {
            get { return m_firstName; }
            set { m_firstName = value; }
        }
        // MiddleName property
        public string MiddleName
        {
            get { return m_middleName; }
            set { m_middleName = value; }
        }
        // LastName property
        public string LastName
        {
            get { return m_lastName; }
            set { m_lastName = value; }
        }
        // FullName
        public string FullName
        {
            get { return FirstName + " " + MiddleName + " " + LastName; }
        }
        // SSN property
        public string SSN
        {
            get { return m_SSN; }
            set { m_SSN = value; }
        }
        
    }

    public struct Address {

        public string street { get; set; }
        public string postCode { get; set; }
        public string country { get; set; }

        public Address(string str, string pcode, string ctry) {
            street = str;
            postCode = pcode;
            country = ctry;
        }
    }
}
namespace AdvancedWebTecnologies_Prac14 {

    public class EmployeeStore
    {
        static void Main(string[] args)
        {
            try
            {
                // Create a new employee
                Employee employee = new Employee();

                // Create an new address
                Address address = new Address();

                // Set some properties
                employee.FirstName = "Timothy";
                employee.MiddleName = "Arthur";
                employee.LastName = "Tucker";
                employee.SSN = "555-55-5555";
                address.setAddress("new road", "Nr4 i4f", "England");
                employee.address = address;

                // Show the results on screen
                string name = employee.FullName;
                string ssn = employee.SSN;
                string country = employee.address.getCountry();

                Console.WriteLine("Name: {0}, SSN: {1}, Country: {2}", name, ssn, country);

                Console.ReadLine();
            }
            catch (Exception exception)
            {
                // Display any errors on screen
                Console.WriteLine(exception.Message);
            }
        }
    }

    interface UpdateEmployee {
        void update();
        void delete();
        void insert();
    }

    class Employee:UpdateEmployee
    {
        private string m_firstName;
        private string m_middleName;
        private string m_lastName;
        private string m_SSN;
        public Address address { get; set; }

        // FirstName property
        public string FirstName
        {
            get { return m_firstName; }
            set { m_firstName = value; }
        }
        // MiddleName property
        public string MiddleName
        {
            get { return m_middleName; }
            set { m_middleName = value; }
        }
        // LastName property
        public string LastName
        {
            get { return m_lastName; }
            set { m_lastName = value; }
        }
        // FullName
        public string FullName
        {
            get { return FirstName + " " + MiddleName + " " + LastName; }
        }
        // SSN property
        public string SSN
        {
            get { return m_SSN; }
            set { m_SSN = value; }
        }
        public Employee()
        {

        }

        public void update()
        {

        }

        public void delete()
        {

        }

        public void insert()
        {

        }

    }
    public struct Address
    {

        private string street { get; set; }
        private string postCode { get; set; }
        private string country { get; set; }

        public Address(string str, string pcode, string ctry)
        {
            street = str;
            postCode = pcode;
            country = ctry;
        }
        public void setAddress(string str, string pcode, string ctry) {
            street = str;
            postCode = pcode;
            country = ctry;
        }
        public string getStreet() {
            return street;
        }
        public string getPostCode()
        {
            return postCode;
        }
        public string getCountry()
        {
            return country;
        }
    }
}