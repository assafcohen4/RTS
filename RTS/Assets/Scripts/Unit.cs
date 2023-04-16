using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private Vector3 targetPosition;
    private float minDistance;

    private void Update()
    {
        if (Vector3.Distance(transform.position, targetPosition) > minDistance)
        { 
            Vector3 moveDirection = (targetPosition - transform.position).normalized;
            float moveSpeed = 4f;
            transform.position += moveDirection * Time.deltaTime * moveSpeed;

            
        }
        if (Input.GetMouseButtonDown(0))
        {
            Move(MouseWorld.GetPosition());
        }

    }

    private void Move(Vector3 targetPosition)
    {
       this.targetPosition = targetPosition;       
        
    }
}
