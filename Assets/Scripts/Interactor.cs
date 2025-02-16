using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IInteractable
{
    public void Interact();
}
public class Interactor : MonoBehaviour
{
    //public Transform InteractorSource;
    public float InteractRange;

    void Start()
    {
        Debug.Log("Start is being called");
    }

    private void Update()
    {
        Debug.Log("Update is being called");
        if (Input.GetKeyDown(KeyCode.F))
        {
            Ray r = new Ray(transform.position, transform.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj))
                {
                    interactObj.Interact();
                }
            }
        }
    }

}
