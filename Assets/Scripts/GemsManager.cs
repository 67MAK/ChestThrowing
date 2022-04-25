using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemsManager : MonoBehaviour
{
    [SerializeField] GameObject _redGem, _greenGem, _blueGem;
    Transform _gemAnchor;
    bool _isCollide = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Chest") && !_isCollide)
        {
            _gemAnchor = collision.transform;
            for(int i = 0; i < 15; i++)
            {
                GemsIns();
            }
        }
    }

    void GemsIns()
    {
        Destroy(Instantiate(_redGem, _gemAnchor.position, Quaternion.identity), 8f);
        Destroy(Instantiate(_greenGem, _gemAnchor.position, Quaternion.identity), 6f);
        Destroy(Instantiate(_blueGem, _gemAnchor.position, Quaternion.identity), 4f);
    }
}
