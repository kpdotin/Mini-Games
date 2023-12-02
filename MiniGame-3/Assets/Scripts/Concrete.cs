using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Concrete : ICommand
{
    GameManager _gameManager;
    OldMovement _oldMovement;
    public Concrete(OldMovement oldMovement, GameManager gameManager)
    {
        _oldMovement = oldMovement;
        _gameManager = gameManager;
    }
    public void Execute()
    {
        _oldMovement.spacePressed();
    }
    public void Undo()
    {
        _gameManager.setSize();
    }
}

//public class resizeConcrete : ICommand
//{
//    Vector3 _newVect;
//    public resizeConcrete()
//    {
//        _gameManager = gameManager;
//    }
//    public void Execute()
//    {

//    }

//    public void Undo()
//    {
        
//    }
//}