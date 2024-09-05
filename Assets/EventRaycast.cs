using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class EventRaycast : MonoBehaviour
{
    [SerializeField] LayerMask layerInteract;
    [SerializeField] float distance;
    RaycastHit2D Hit;
    public event Action eventRaycast;
    private void FixedUpdate()
    {
        
    }
    protected virtual void ActiveRaycastJump(GameObject go)
    {
        Physics.Raycast(go.transform.po, Vector2.down, distance, layerInteract);

    }
}
