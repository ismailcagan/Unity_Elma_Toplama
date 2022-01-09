using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kutuhareket : MonoBehaviour
{
    private Rigidbody rigidbody;
    public float hiz = 50.0f;
    private void FixedUpdate()
    {
        rigidbody = GetComponent<Rigidbody>();
        float yatay = Input.GetAxis("Horizontal");
        hareket(yatay);
    }
    public void hareket(float yatay)
    {
        rigidbody.velocity = new Vector3(hiz * yatay, rigidbody.velocity.y, 0);
    }
}
