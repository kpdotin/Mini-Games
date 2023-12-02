using System;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    public OldMovement oldMovement;

    UndoMovement _undoMovement;

    GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        _undoMovement = new UndoMovement();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ICommand onCommand = new Concrete(oldMovement, _gameManager);
            _undoMovement.resizeCommand(onCommand);
        }

        else if(Input.GetKeyUp(KeyCode.R))
        {
            ICommand resize = new Concrete(oldMovement, _gameManager);
            _undoMovement.undoSize();
        }
        
    }

}
