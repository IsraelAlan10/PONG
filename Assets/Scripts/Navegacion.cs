using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navegacion : MonoBehaviour
{

    void Update() {
        if (Input.GetKey(KeyCode.Space)) {
            SceneManager.LoadScene("Configuracion");
        }if (Input.GetKey(KeyCode.Return)) {
            SceneManager.LoadScene("Inicio");
        }
        if (Input.GetKey(KeyCode.LeftControl)) {
            SceneManager.LoadScene("Inicial");
        }
    }
}
