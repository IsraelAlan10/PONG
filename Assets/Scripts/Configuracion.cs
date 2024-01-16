using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Configuracion : MonoBehaviour
{ 

    public Text op1, op2;
    public static int tipoJuego = 1;
    public static int jugadorComputadora;

    void Awake(){
        tipoJuego = 1;
        op1.gameObject.SetActive(true);
        op2.gameObject.SetActive(false);
    }

    void Update() {
        if (Input.GetKey(KeyCode.Alpha1) || Input.GetKey(KeyCode.Keypad1)) {
            BorrarSubrayado();
            op1.gameObject.SetActive(true);
            tipoJuego = 1;
        }
        if (Input.GetKey(KeyCode.Alpha2) || Input.GetKey(KeyCode.Keypad2)) {
            BorrarSubrayado();
            op2.gameObject.SetActive(true);
            tipoJuego = 3;
        }
        if(Input.GetKey(KeyCode.Space) && tipoJuego == 3){
            SceneManager.LoadScene("Main");
        }
        if (Input.GetKey(KeyCode.Space) && tipoJuego == 1) {
            SceneManager.LoadScene("Niveles");
        }
        if (Input.GetKey(KeyCode.Escape)) {
            SceneManager.LoadScene("Inicio");
        }
    }
    public void BorrarSubrayado() {
        op1.gameObject.SetActive(false);
        op2.gameObject.SetActive(false);
    }
}
