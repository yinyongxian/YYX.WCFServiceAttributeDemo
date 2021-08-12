using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Dispatcher;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class MyParameterInspector : IParameterInspector
{
    public MyParameterInspector()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
    {

    }

    public object BeforeCall(string operationName, object[] inputs)
    {
        return null;
    }
}
