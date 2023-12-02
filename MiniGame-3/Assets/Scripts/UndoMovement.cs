using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndoMovement {
    Stack<ICommand> _sizesStack;
    
    public UndoMovement()
    {
        _sizesStack = new Stack<ICommand>();
    }

    public void resizeCommand(ICommand newCommand)
    {
        newCommand.Execute();
        _sizesStack.Push(newCommand);
    }

    public void undoSize()
    {
         if( _sizesStack.Count > 0 )
        {
            ICommand latestCommand = _sizesStack.Pop();
            latestCommand.Undo();
        }
        else
        {
            Debug.Log("stack empty");
        }
        
    }
}
