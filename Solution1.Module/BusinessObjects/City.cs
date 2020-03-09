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
  
  public class City : XPObject
  { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
    public City(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
    }
    Country _country;
    Customer _customer;
    string _citycode;
    string _cityname;
    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string CityName
    {
      get => _cityname;
      set => SetPropertyValue(nameof(CityName), ref _cityname, value);
    }


    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string CityCode
    {
      get => _citycode;
      set => SetPropertyValue(nameof(CityCode), ref _citycode, value);
    }

    [Association]
    public Customer Customer
    {
      get => _customer;
      set => SetPropertyValue(nameof(Customer), ref _customer, value);
    }

    [Association]
    public XPCollection<County> Counties
    {
      get
      {
        return GetCollection<County>(nameof(Counties));
      }
    }

    [Association]
    public Country Country
    {
      get => _country;
      set => SetPropertyValue(nameof(Country), ref _country, value);
    }

  }
}