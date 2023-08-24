using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionChanger : MonoBehaviour
{
    [SerializeField]
    private Vector3 targetPosition; // The position you want to move the object to

    public int AmountOfMask = 0;
    private List<string> _answer = new List<string>()
    {
        "mask_1",
        "mask_2",
        "mask_3",
        "mask_4",
    };


    public AudioSource source;
    public AudioClip clip;


    public void Update()
    {
        if (AmountOfMask == 3)
        {
            transform.position = targetPosition;
            Debug.Log("Position: " + transform.position);
            source.PlayOneShot(clip);
            AmountOfMask = 0;
        }
        
    }

    public void IncreaseAmount (string namemask)
    {
        if (_answer.Contains(namemask))
        {
            _answer.Remove(namemask);
            Debug.Log("Work");
            AmountOfMask += 1;
        }
        
    }
}
