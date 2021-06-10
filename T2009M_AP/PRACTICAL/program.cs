namespace T2009M_AP.PRACTICAL
{
    public class program
    {
        public static void Main(string[] args)
                {
                    MobilePhone mobilePhone = new MobilePhone();
                    mobilePhone.PhoneName = "SamSung";
                    mobilePhone.PhoneType = "mobile";
                    mobilePhone.PhonePrice = 3000;
                    mobilePhone.display();
        
                    Phone phone = new Phone();
                    phone.PhoneName = "Ip";
                    phone.PhoneType = "phone";
                    phone.PhonePrice = 2000;
                    phone.display();
                }
    }
}