using UnityEngine;
using System.Collections;
using UnityEngine.XR.Interaction.Toolkit;
 
public class XRGrabInteractable_Custom : XRGrabInteractable {
 
    [SerializeField, Tooltip("The XRSocketInteractor to be checked.")]
    private XRSocketInteractor xrSocketInteractor;
 
    protected override void Drop() {
        base.Drop();
        StartCoroutine(CheckSocket());
    }
 
    IEnumerator CheckSocket() {
        yield return new WaitForEndOfFrame();
        Debug.Log(xrSocketInteractor.hasSelection);
    }
 
}
