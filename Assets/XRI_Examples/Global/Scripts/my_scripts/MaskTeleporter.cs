using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskTeleporter : MonoBehaviour
{
    public GameObject Player;
    public GameObject TeleportTo;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("MaskTeleporter"))
        {
            Player.transform.position = TeleportTo.transform.position;
        }
    }
}