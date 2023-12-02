using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker 
{
    ICommand _onCommand;
    public Invoker(ICommand onCommand)
    {
        _onCommand = onCommand;
    }

    public void toggleInvoker()
    {
        _onCommand.Execute();
    }


    
}
