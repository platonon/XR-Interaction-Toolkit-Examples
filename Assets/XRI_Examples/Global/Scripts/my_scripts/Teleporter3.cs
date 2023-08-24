using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter3 : MonoBehaviour
{
    public GameObject Player;
    public GameObject TeleportTo;
    public AudioSource source;
    public AudioClip clip;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Teleporter3"))
        {
            Player.transform.position = TeleportTo.transform.position;
            source.PlayOneShot(clip);
        }
    }
}