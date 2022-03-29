using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleportingbehaivor : MonoBehaviour
{
    public GameObject _player;

    public void teleportMove()
    {
        _player.transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
    }

    public void teleportEscena()
    {
        SceneManager.LoadScene(3);
    }
}
