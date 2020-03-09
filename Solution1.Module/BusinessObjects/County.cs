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
  
  public class County : XPObject
  { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
    public County(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
    }


    City _city;
    Customer _customer;
    string _countycode;
    string _countyname;

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string CountyName
    {
      get => _countyname;
      set => SetPropertyValue(nameof(CountyName), ref _countyname, value);
    }


    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string CountyCode
    {
      get => _countycode;
      set => SetPropertyValue(nameof(CountyCode), ref _countycode, value);
    }


    [Association("Customer-County")]
    public Customer Customer
    {
      get => _customer;
      set => SetPropertyValue(nameof(Customer), ref _customer, value);
    }

    
    [Association]
    public City City
    {
      get => _city;
      set => SetPropertyValue(nameof(City), ref _city, value);
    }
  }
}