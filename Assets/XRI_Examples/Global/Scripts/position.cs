using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{
    public void ChangePosition()
    {
        transform.position+=new Vector3(0,0.5f,0);

    }
}
