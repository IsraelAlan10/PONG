using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Niveles : MonoBehaviour
{
    public Text op1, op2, op3, op4, op5;
    public AudioSource reproductor;
    public AudioClip clip;
    public static int nivel;
    public static int lado;
    // Start is called before the first frame update
    void Start()
    {
        nivel = 1;
        lado = 1;
        reproductor = GetComponent<AudioSource>();

    }
    void Awake()
    {
        nivel = 1;
        lado = 1;
        op1.gameObject.SetActive(true);
        op2.gameObject.SetActive(false);
        op3.gameObject.SetActive(false);
        op4.gameObject.SetActive(true);
        op5.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1)|| Input.GetKey(KeyCode.Keypad1)) {
            BorrarSubrayado();
            op1.gameObject.SetActive(true);
            nivel = 1;
        }
        if (Input.GetKey(KeyCode.Alpha2) || Input.GetKey(KeyCode.Keypad2)) {
            BorrarSubrayado();
            op2.gameObject.SetActive(true);
            nivel = 2;
        }
        if (Input.GetKey(KeyCode.Alpha3) || Input.GetKey(KeyCode.Keypad3))
        {
            BorrarSubrayado();
            op3.gameObject.SetActive(true);
            nivel = 3;
        }
        if (Input.GetKey(KeyCode.I)) {
            BorrarSubrrayados();
            lado = 1;
            op4.gameObject.SetActive(true);
        }
        if (Input.GetKey(KeyCode.D)){
            BorrarSubrrayados();
            lado = 2;
            op5.gameObject.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Space)) {
            SceneManager.LoadScene("Main");
        }
        if(Input.GetKey(KeyCode.Escape)) {
            SceneManager.LoadScene("Configuracion");
        }
    }
    public void BorrarSubrayado() {
        op1.gameObject.SetActive(false);
        op2.gameObject.SetActive(false);
        op3.gameObject.SetActive(false);
    }
    public void BorrarSubrrayados(){
        op4.gameObject.SetActive(false);
        op5.gameObject.SetActive(false);
    }
}
