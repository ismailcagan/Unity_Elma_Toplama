using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dusme : MonoBehaviour
{
    public float zaman;
    public int deger;
    public GameObject apply;
    public int rnd = 0;
    void Start()
    {
        zaman = 0;
    }
    // Update is called once per frame
    void Update()
    {
        dusmeHareketi();
    }
    public void dusmeHareketi()
     {
        zaman += Time.deltaTime;
        deger = (int)zaman;
         if (deger == 2)
         {
            deger = 0;
            zaman = 0;
            rnd = Random.Range(-7, 7);
            Instantiate(apply, new Vector3(rnd, 11,0), transform.rotation);     
         }
     }
}
