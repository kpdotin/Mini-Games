using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI text;
    public string toBeDisplayed;
    public Material newmat;

    public Vector3 oldSize;
    void resize()
    {
        GameObject resizeObject = GameObject.FindGameObjectWithTag("Resize");
        oldSize = resizeObject.transform.localScale;
        Debug.Log(oldSize);
        resizeObject.transform.localScale = new Vector3(resizeObject.transform.localScale.x * 2, resizeObject.transform.localScale.y * 2, resizeObject.transform.localScale.z * 2);
    }

    void colour()
    {
        GameObject colourObject = GameObject.FindGameObjectWithTag("Colour");
        colourObject.GetComponent<Renderer>().material = newmat;
    }
    void displayMsg()
    {
        text.text = toBeDisplayed;
    }
    void finishObjects()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("Finish");
        obj.GetComponent<Rigidbody>().velocity = new Vector3(0, 10, 0);
    }

    private void OnEnable()
    {
        OldMovement.moveFinish += finishObjects;
        OldMovement.moveFinish += displayMsg;
        OldMovement.moveFinish += colour;
        OldMovement.moveFinish += resize;
    }

    public void setSize()
    {
        GameObject resizeObject = GameObject.FindGameObjectWithTag("Resize");
        resizeObject.transform.localScale = oldSize;
    }
}
