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
 
  public class Product : XPObject
  { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
    public Product(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      Active = true;
      // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
    }


    ProductGroup _productGroup;
    bool _active;
    string _producttype;
    string _productcode;
    string _productname;

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string ProductName
    {
      get => _productname;
      set => SetPropertyValue(nameof(ProductName), ref _productname, value);
    }


    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string ProductCode
    {
      get => _productcode;
      set => SetPropertyValue(nameof(ProductCode), ref _productcode, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string ProductType
    {
      get => _producttype;
      set => SetPropertyValue(nameof(ProductType), ref _producttype, value);
    }

    public bool Active
    {
      get => _active;
      set => SetPropertyValue(nameof(Active), ref _active, value);
    }

    
    [Association]
    public ProductGroup ProductGroup
    {
      get => _productGroup;
      set => SetPropertyValue(nameof(ProductGroup), ref _productGroup, value);
    }


  }
}