using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndSelect : MonoBehaviour
{
    public void DestroyTarget()
    {
        RaycastHit hitInfo;
        bool hit = Physics.Raycast(transform.position, transform.forward, out hitInfo, 3.2f, 3, QueryTriggerInteraction.UseGlobal);
        if (hit)
        {
            Destroy(hitInfo.collider.gameObject);
        }
    }
}
