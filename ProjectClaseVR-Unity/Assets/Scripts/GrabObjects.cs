using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObjects : MonoBehaviour
{

    [SerializeField]
    private GameObject _jugador;
    private ParticleSystem _particulas;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        
        
        if (other.gameObject.tag == "Grab")
        {
            _particulas = other.gameObject.GetComponentInChildren<ParticleSystem>();
            _particulas.Stop();
            other.gameObject.transform.SetParent(_jugador.transform);
            other.gameObject.transform.position = _jugador.transform.position;
        }
    }
}
