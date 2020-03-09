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
  
  public class Position : XPObject
  { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
    public Position(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      Active = true;
      // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
    }

    bool _active;
    string _workDescription;
    string _positionname;

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string PositionName
    {
      get => _positionname;
      set => SetPropertyValue(nameof(PositionName), ref _positionname, value);
    }


    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string WorkDescription
    {
      get => _workDescription;
      set => SetPropertyValue(nameof(WorkDescription), ref _workDescription, value);
    }

    
    public bool Active
    {
      get => _active;
      set => SetPropertyValue(nameof(Active), ref _active, value);
    }
  }
}