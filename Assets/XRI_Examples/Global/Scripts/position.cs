using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{
    [SerializeField]
    private Vector3 targetPosition; // The position you want to move the object to
    
    public void ChangePosition()
    {
        transform.position = targetPosition;
        Debug.Log("Position: " + transform.position);
    }
}
