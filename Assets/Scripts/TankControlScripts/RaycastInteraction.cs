using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastInteraction : MonoBehaviour
{

    Ray ray;
    RaycastHit hit;

    public float interactionDistance = 5f;

    public void Update()
    {

        RaycastInteract();
    }

    public void Start()
    {
        ray = new Ray(transform.position, transform.forward);
    }
    public void RaycastInteract()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    public void Interact()
    {

        ray = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Debug.Log(hit.collider.gameObject.name + "interactable");

            if (hit.collider.CompareTag("interactable"))
            {
                Debug.Log("interact with" + hit.collider.gameObject.name);
            }
        }
    }
}