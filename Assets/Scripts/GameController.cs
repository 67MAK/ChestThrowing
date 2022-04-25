using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject _chest;
    [SerializeField] Transform _anchor;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ChestIns();
        }
    }

    void ChestIns()
    {
        float xRandom = Random.Range(-3.4f, 3.4f);
        float yRandom = Random.Range(0, 4f);
        GameObject tempChest;
        tempChest = Instantiate(_chest, _anchor.position + new Vector3(xRandom, yRandom, 0), Quaternion.Euler(-90f, 0f, -90f));
        Destroy(tempChest, 9f);
        tempChest.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
    }
}
