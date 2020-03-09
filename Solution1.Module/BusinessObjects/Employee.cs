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
 
  public class Employee : XPObject
  { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
    public Employee(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      Active = true;
      // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
    }

    string _fullName;
    bool _active;
    byte[] _photo;
    DateTime _birthDate;
    string _phone;
    string _email;
    string _lastName;
    string _firstName;

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string FirstName
    {
      get => _firstName;
      set => SetPropertyValue(nameof(FirstName), ref _firstName, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string LastName
    {
      get => _lastName;
      set => SetPropertyValue(nameof(LastName), ref _lastName, value);
    }

    //[NonPersistent]
    //[Size(SizeAttribute.DefaultStringMappingFieldSize)]
    //public string FullName => _fullName.Format("{0} {1}", FirstName ?? "", LastName ?? "");

    public DateTime BirthDate
    {
      get => _birthDate;
      set => SetPropertyValue(nameof(BirthDate), ref _birthDate, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string Email
    {
      get => _email;
      set => SetPropertyValue(nameof(Email), ref _email, value);
    }


    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string Phone
    {
      get => _phone;
      set => SetPropertyValue(nameof(Phone), ref _phone, value);
    }

    [ImageEditor]
    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public byte[] Photo
    {
      get => _photo;
      set => SetPropertyValue(nameof(Photo), ref _photo, value);
    }


    public bool Active
    {
      get => _active;
      set => SetPropertyValue(nameof(Active), ref _active, value);
    }


    [Association]
    public XPCollection<Department> Departments
    {
      get
      {
        return GetCollection<Department>(nameof(Departments));
      }
    }

    [Association]
    public XPCollection<Company> Companies
    {
      get
      {
        return GetCollection<Company>(nameof(Companies));
      }
    }

  }
}