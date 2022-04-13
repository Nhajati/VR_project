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

    IGS520b.starter.SampleGame.GameManager gameManager;
    public GameObject myGameManager;
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
        gameManager = myGameManager.GetComponent<IGS520b.starter.SampleGame.GameManager>();
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "Book1"){
            gameManager.AddPointToCounter();
            Destroy(book1.GetComponent<OVRGrabbable>());
            Destroy(book1.GetComponent<Rigidbody>());
            Destroy(col);
            book1.transform.position = new Vector3(0.44f, 1.31f, 1.0f);
            book1.transform.rotation = Quaternion.Euler(-90, 0, 0);
        }
        else if(col.gameObject.name == "Book2"){
            gameManager.AddPointToCounter();
            Destroy(book2.GetComponent<OVRGrabbable>());
            Destroy(book2.GetComponent<Rigidbody>());
            Destroy(col);
            book2.transform.position = new Vector3(0.44f, 1.90f, -0.5f);
            book2.transform.rotation = Quaternion.Euler(90, 0, 0);
        }
        else if(col.gameObject.name == "Book3"){
            gameManager.AddPointToCounter();
            Destroy(book3.GetComponent<OVRGrabbable>());
            Destroy(book3.GetComponent<Rigidbody>());
            Destroy(col);
            book3.transform.position = new Vector3(0.44f, 0.57f, 0.0f);
            book3.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

}
