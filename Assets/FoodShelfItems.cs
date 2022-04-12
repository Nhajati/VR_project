using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class FoodShelfItems : MonoBehaviour
{
    [SerializeField]
    private GameObject chips1;
    [SerializeField]
    private GameObject chips2;
    [SerializeField]
    private GameObject chips3;
    [SerializeField]
    private GameObject banana;

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
        if(col.gameObject.name == "ChipsBag1"){
            Destroy(chips1.GetComponent<OVRGrabbable>());
            Destroy(chips1.GetComponent<Rigidbody>());
            Destroy(col);
            chips1.transform.position = new Vector3(4.5f, 0.3f, 3.3f);
            chips1.transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        else if(col.gameObject.name == "ChipsBag2"){
            Destroy(chips2.GetComponent<OVRGrabbable>());
            Destroy(chips2.GetComponent<Rigidbody>());
            Destroy(col);
            chips2.transform.position = new Vector3(4.1f, 0.2f, 3.3f);
            chips2.transform.rotation = Quaternion.Euler(-90, -90, 0);
        }
        else if(col.gameObject.name == "ChipsBag3"){
            Destroy(chips3.GetComponent<OVRGrabbable>());
            Destroy(chips3.GetComponent<Rigidbody>());
            Destroy(col);
            chips3.transform.position = new Vector3(3.4f, 0.27f, 3.3f);
            chips3.transform.rotation = Quaternion.Euler(-20, 138, -7);
        }
        else if(col.gameObject.name == "Banana"){
            Destroy(banana.GetComponent<OVRGrabbable>());
            Destroy(banana.GetComponent<Rigidbody>());
            Destroy(col);
            banana.transform.position = new Vector3(4.0f, 0.73f, 3.4f);
            banana.transform.rotation = Quaternion.Euler(0, -90, 0);
        }
    }

}
