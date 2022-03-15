using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubjectController : MonoBehaviour
{
    float movementSpeed = 0.5f;


    private void Translate(Vector3 direction)
    {
        float singleStep = movementSpeed * Time.deltaTime;
        transform.Translate(direction.normalized * singleStep, Space.World);
    }

    public void MoveForward()
    {
        Translate(transform.forward);
    }

    public void MoveBackward()
    {
        Translate(-transform.forward);
    }

    public void MoveRight()
    {
        Translate(transform.right);
    }

    public void MoveLeft()
    {
        Translate(-transform.right);
    }

    public void Print()
    {
        Debug.Log($"=========  {transform.name}");
    }
}
