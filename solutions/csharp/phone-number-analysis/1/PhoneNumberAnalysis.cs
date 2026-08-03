public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] splitedPhoneNumber = phoneNumber.Split('-');
        return (splitedPhoneNumber[0].Equals("212"),
            splitedPhoneNumber[1].Equals("555"),
            splitedPhoneNumber[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
