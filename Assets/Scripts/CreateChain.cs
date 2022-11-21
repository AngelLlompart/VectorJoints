using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateChain : MonoBehaviour
{
    [SerializeField] private GameObject chain;
    [SerializeField] private GameObject chain2;
    void Start()
    {
        Instantiate(chain, transform.position - new Vector3(0, 0.5f, 0), Quaternion.identity);
        chain.GetComponent<HingeJoint>().connectedBody = this.gameObject.GetComponent<Rigidbody>();
        
      //  Instantiate(chain2, chain.transform.position - new Vector3(0, 0.5f, 0), Quaternion.identity);
        //chain2.GetComponent<HingeJoint>().connectedBody = chain.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
