using System.Xml.Linq;
namespace lesson_8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XElement person = new XElement("Person");
            XElement address = new XElement("Address");
            XElement phones = new XElement("Phones");
            XElement street = new XElement("street");
            XElement houseNumber = new XElement("houseNumber");
            XElement flatNumber = new XElement("flatNumber");
            XElement mobilePhone = new XElement("number");
            XElement flatPhone = new XElement("flatPhone");

            XAttribute attributePerson = new XAttribute("name","Миша");

            person.Add(attributePerson);
            street.Add("Улица");
            houseNumber.Add("номер дома");
            flatNumber.Add("номер квартиры");
            mobilePhone.Add(89999999999);
            flatPhone.Add(123 - 22 - 234);

            person.Add(address);
            address.Add(street);
            address.Add(houseNumber);
            address.Add(flatNumber);
            person.Add(phones);
            phones.Add(mobilePhone);
            phones.Add(flatPhone);

            person.Save("lesson8.4_XML.xml");


        }
    }
}
