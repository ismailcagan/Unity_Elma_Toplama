using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carpma : MonoBehaviour
{
    public int puan = 0;
    public Text puantxt;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "sepet")
        {
            Destroy(gameObject);
            puan++;
            puantxt.text = puan.ToString();
        }
    }
}
