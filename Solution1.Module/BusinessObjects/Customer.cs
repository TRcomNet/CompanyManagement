using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace Solution1.Module.BusinessObjects
{
  [DefaultClassOptions]
  public class Customer : XPObject
  { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
    public Customer(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      Active = true;
      // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
    }


    string _customerCode;
    string _customerKey;
    string _taxOffice;
    string _taxNumber;
    string _fax;
    string _mobilePhone;
    bool _active;
    string _contactPerson;
    string _email;
    string _phone;
    string _address;
    string _customername;

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string CustomerName
    {
      get => _customername;
      set => SetPropertyValue(nameof(CustomerName), ref _customername, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string MobilePhone
    {
      get => _mobilePhone;
      set => SetPropertyValue(nameof(MobilePhone), ref _mobilePhone, value);
    }


    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string Address
    {
      get => _address;
      set => SetPropertyValue(nameof(Address), ref _address, value);
    }


    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string Phone
    {
      get => _phone;
      set => SetPropertyValue(nameof(Phone), ref _phone, value);
    }


    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string Fax
    {
      get => _fax;
      set => SetPropertyValue(nameof(Fax), ref _fax, value);
    }


    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string TaxNumber
    {
      get => _taxNumber;
      set => SetPropertyValue(nameof(TaxNumber), ref _taxNumber, value);
    }


    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string TaxOffice
    {
      get => _taxOffice;
      set => SetPropertyValue(nameof(TaxOffice), ref _taxOffice, value);
    }



    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string Email
    {
      get => _email;
      set => SetPropertyValue(nameof(Email), ref _email, value);
    }


    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string ContactPerson
    {
      get => _contactPerson;
      set => SetPropertyValue(nameof(ContactPerson), ref _contactPerson, value);
    }


    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string CustomerKey
    {
      get => _customerKey;
      set => SetPropertyValue(nameof(CustomerKey), ref _customerKey, value);
    }

    
    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string CustomerCode
    {
      get => _customerCode;
      set => SetPropertyValue(nameof(CustomerCode), ref _customerCode, value);
    }

    public bool Active
    {
      get => _active;
      set => SetPropertyValue(nameof(Active), ref _active, value);
    }

    [Association]
    public XPCollection<Company> Companies
    {
      get
      {
        return GetCollection<Company>(nameof(Companies));
      }
    }

    [Association]
    public XPCollection<City> City
    {
      get
      {
        return GetCollection<City>(nameof(City));
      }
    }

    [Association("Customer-Country")]
    public XPCollection<Country> Country
    {
      get
      {
        return GetCollection<Country>(nameof(Country));
      }
    }

    [Association("Customer-County")]
    public XPCollection<County> County
    {
      get
      {
        return GetCollection<County>(nameof(County));
      }
    }
  }
}