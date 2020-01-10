using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectPattern
{
    public class MobileRepository
    {
        public IMobile GetPhoneByCompany(string mobilePhone)
        {
            if (mobilePhone.ToLower() == "sony")
                return new SonyMobile();
            else if (mobilePhone.ToLower() == "samsung")
                return new SamsungMobile();
            else
                return NullMobile.GetInstance();
        }
    }
}
