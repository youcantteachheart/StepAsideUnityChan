using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackSideController : MonoBehaviour
{
    private GameObject unitychan;
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");
        this.difference = unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z-difference);
    }

    void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag" || other.gameObject.tag == "CoinTag")
        {
            Debug.Log("削除TAG："+other.gameObject.tag);
            Destroy(other.gameObject);
        }
    }
}
