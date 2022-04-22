using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject _chest;
    [SerializeField] Transform _anchor;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ChestIns();
        }
    }

    void ChestIns()
    {
        GameObject tempChest;
        tempChest = Instantiate(_chest, _anchor.position, Quaternion.Euler(-90f, 0f, -90f));
        Destroy(tempChest, 9f);
        tempChest.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
    }
}
