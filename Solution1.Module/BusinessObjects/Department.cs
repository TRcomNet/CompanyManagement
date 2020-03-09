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
  public class Department : XPObject
  { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
    public Department(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
    }


    bool _active;
    Employee _employee;
    string _departmentName;

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string DepartmentName
    {
      get => _departmentName;
      set => SetPropertyValue(nameof(DepartmentName), ref _departmentName, value);
    }

    [Association]
    public Employee Employee
    {
      get => _employee;
      set => SetPropertyValue(nameof(Employee), ref _employee, value);
    }

    
    public bool Active
    {
      get => _active;
      set => SetPropertyValue(nameof(Active), ref _active, value);
    }
  }
}