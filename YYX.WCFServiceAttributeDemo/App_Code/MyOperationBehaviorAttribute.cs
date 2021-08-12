using System;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

public class MyOperationBehaviorAttribute : Attribute, IOperationBehavior
{
    public void AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters)
    {
        
    }

    public void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation)
    {
        
    }

    public void ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation)
    {
        dispatchOperation.ParameterInspectors.Add(new MyParameterInspector());
    }

    public void Validate(OperationDescription operationDescription)
    {
        
    }
}