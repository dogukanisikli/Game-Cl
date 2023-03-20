using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class steroidenergydrinkadvertiser : MonoBehaviour
{
    public GameObject advertiser;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "human")
        {
            Destroy(advertiser);
            advertiser.transform.position = new Vector3(advertiser.transform.position.x, advertiser.transform.position.y, advertiser.transform.position.z + 40);
            Instantiate(advertiser, advertiser.transform.position,Quaternion.Euler(90, 0, 0));

        }
    }

}
