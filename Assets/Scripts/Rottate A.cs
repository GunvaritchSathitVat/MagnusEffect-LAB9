using UnityEditor.Callbacks;
using UnityEngine;

public class RottateA : MonoBehaviour
{
    Rigidbody rb;
   [SerializeField] Vector3 angularV;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
          rb.angularVelocity  = angularV;
        }
    }
}
