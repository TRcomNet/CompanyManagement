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
  
  public class Company : XPObject
  { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
    public Company(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      Active = true;
      // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
    }

    Organization _organization;
    Customer _customer;
    bool _active;
    string _companycode;
    string _companyname;

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string CompanyName
    {
      get => _companyname;
      set => SetPropertyValue(nameof(CompanyName), ref _companyname, value);
    }


    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string CompanyCode
    {
      get => _companycode;
      set => SetPropertyValue(nameof(CompanyCode), ref _companycode, value);
    }


    public bool Active
    {
      get => _active;
      set => SetPropertyValue(nameof(Active), ref _active, value);
    }

    [Association]
    public XPCollection<Customer> Customers
    {
      get
      {
        return GetCollection<Customer>(nameof(Customers));
      }
    }

    [Association]
    public XPCollection<Organization> Organizations
    {
      get
      {
        return GetCollection<Organization>(nameof(Organizations));
      }
    }

    [Association]
    public XPCollection<Employee> Employees
    {
      get
      {
        return GetCollection<Employee>(nameof(Employees));
      }
    }

  }
}