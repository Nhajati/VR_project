using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class BookShelfItems : MonoBehaviour
{
    [SerializeField]
    private GameObject book1;
    [SerializeField]
    private GameObject book2;
    [SerializeField]
    private GameObject book3;

    [Tooltip("Points scored by touching this object.")]
    public float points = 10;

    // public System.Action<GamePoint> OnTriggerEnterAction;

    // Start is called before the first frame update
    void Start()
    {
        // Make sure non of the colliders in child objects are active
        foreach (Collider collider in GetComponentsInChildren<Collider>())
        {
           collider.enabled = false;
        }

        // Make sure the root collider is a trigger and enabled
        Collider rootCollider = GetComponent<Collider>();
        rootCollider.enabled = true;
        rootCollider.isTrigger = true;
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "Book1"){
            Destroy(book1.GetComponent<OVRGrabbable>());
            Destroy(book1.GetComponent<Rigidbody>());
            Destroy(col);
            book1.transform.position = new Vector3(0.44f, 1.31f, 1.0f);
            book1.transform.rotation = Quaternion.Euler(-90, 0, 0);
        }
    }

    // void OnTriggerEnter(Collider collider)
    //     {
    //         OnTriggerEnterAction?.Invoke(this);
    //     }
}
