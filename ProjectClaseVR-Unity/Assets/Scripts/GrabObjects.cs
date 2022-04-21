using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObjects : MonoBehaviour
{

    [SerializeField]
    private GameObject _jugador;
    private ParticleSystem _particulas;
    private GameObject _objetoGrabed; 


    private void OnTriggerEnter(Collider other) {
        
        
        if (other.gameObject.tag == "Grab")
        {
            _particulas = other.gameObject.GetComponentInChildren<ParticleSystem>();
            _particulas.Stop();
            other.gameObject.transform.SetParent(_jugador.transform);
            other.gameObject.transform.position = _jugador.transform.position + new Vector3(0,0.3f,0.2f);
            _objetoGrabed = other.gameObject;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "UnGrab")
        {
          _objetoGrabed.gameObject.transform.SetParent(null);
          _objetoGrabed.transform.position = collision.transform.position + new Vector3(0, 0.2f, 0);
          
        }
    }
}
