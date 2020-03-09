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
  
  public class ProductGroup : XPObject
  { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
    public ProductGroup(Session session)
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
    string _productgrouptype;
    string _groupCode;
    string _productgroupname;

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string ProductGroupName
    {
      get => _productgroupname;
      set => SetPropertyValue(nameof(ProductGroupName), ref _productgroupname, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string GroupCode
    {
      get => _groupCode;
      set => SetPropertyValue(nameof(GroupCode), ref _groupCode, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string ProductGroupType
    {
      get => _productgrouptype;
      set => SetPropertyValue(nameof(ProductGroupType), ref _productgrouptype, value);
    }
    
    public bool Active
    {
      get => _active;
      set => SetPropertyValue(nameof(Active), ref _active, value);
    }

    [Association]
    public XPCollection<Product> Products
    {
      get
      {
        return GetCollection<Product>(nameof(Products));
      }
    }

  }
}