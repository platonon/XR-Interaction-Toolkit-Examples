using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketChecker : MonoBehaviour
{
    XRSocketInteractor socket;
    [SerializeField] private string _nameMask;
    private IXRSelectInteractable objName;
    [SerializeField] private PositionChanger _positionChanger;
    void Start()
    {
        socket = GetComponent<XRSocketInteractor>();
    }
    
    private void Update ()
    {
        if (objName.transform.name == _nameMask)
        {
            _positionChanger.IncreaseAmount(objName.transform.name);
        }
    }

    public void socketCheck()
    {
       
        objName = socket.GetOldestInteractableSelected();
       
        Debug.Log(objName.transform.name + " in socket of " + transform.name);
    }
}
