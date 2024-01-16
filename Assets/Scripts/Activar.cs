using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar : MonoBehaviour
{
    public IA iaScript;
    public IA iaScript2;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
        iaScript.enabled = false;
        iaScript2.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Niveles.lado == 1) {
            iaScript2.enabled=true;
        }
        if (Niveles.lado == 2) {
            iaScript.enabled=true;
        }
        if(Configuracion.tipoJuego == 3)
        {
            iaScript2.enabled=false;
            iaScript.enabled=false;
        }
    }
}
