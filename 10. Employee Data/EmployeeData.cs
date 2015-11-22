namespace Employee_Data
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            byte age = 30;
            char gender = 'f';
            ulong personalIdNumber = 8306112507L;
            uint employeeNumber = 27563571;
            System.Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID: {4}\nUnique Employee number: {5}",
                firstName,lastName,age,gender,personalIdNumber,employeeNumber);

        }
    }
}
