using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportingbehaivor : MonoBehaviour
{
    public GameObject _player;

    public void teleportMove()
    {
        _player.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
}
