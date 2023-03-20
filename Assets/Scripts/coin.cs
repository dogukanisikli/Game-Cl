using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class coin : MonoBehaviour
{
    public GameObject coinn;

    void Start()
    {

    }

    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "human")
        {
            CoinText.coinAmount += 1;
            Destroy(coinn);
            transform.Rotate(90f, 0, 0);
            coinn.transform.position = new UnityEngine.Vector3(coinn.transform.position.x, coinn.transform.position.y,coinn.transform.position.z+5);
            Instantiate(coinn, coinn.transform.position, UnityEngine.Quaternion.Euler(90, 0, 0));

            coinn.transform.Rotate(90, 0, 0);
        }
    }

}
