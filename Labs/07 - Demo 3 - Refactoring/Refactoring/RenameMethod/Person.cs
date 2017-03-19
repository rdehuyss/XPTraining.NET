namespace Refactoring.RenameMethod
{
    public class Person
    {
        private string _officeAreaCode;
        private string _officeNumber;

        public Person(string officeAreaCode, string officeNumber)
        {
            _officeAreaCode = officeAreaCode;
            _officeNumber = officeNumber;
        }

        public string TelephoneNumber => ("(" + _officeAreaCode + ") " + _officeNumber);
        

    }
}