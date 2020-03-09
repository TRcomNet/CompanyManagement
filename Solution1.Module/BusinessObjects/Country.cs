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

  public class Country : XPObject
  { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
    public Country(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
    }

    Customer _customer;
    string _countrycode;
    string _countryname;

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string CountryName
    {
      get => _countryname;
      set => SetPropertyValue(nameof(CountryName), ref _countryname, value);
    }


    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string CountryCode
    {
      get => _countrycode;
      set => SetPropertyValue(nameof(CountryCode), ref _countrycode, value);
    }

    [Association("Customer-Country")]
    public Customer Customer
    {
      get => _customer;
      set => SetPropertyValue(nameof(Customer), ref _customer, value);
    }

    [Association]
    public XPCollection<City> Cities
    {
      get
      {
        return GetCollection<City>(nameof(Cities));
      }
    }

  }
}