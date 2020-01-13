using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDesplegableController : MonoBehaviour
{
    public RectTransform subMenu;
    float posFinal;
    bool abrirMenu = true;
    public float tiempo = 0.5f;

    // Start is called before the first frame update
    void Start()    //En canvasMenu esta aplicado el script y en buttonMenu las tres rayas y la X están llamando a la accion
    {
        posFinal = Screen.width / 3; //Default 2
        subMenu.position = new Vector3(-posFinal, subMenu.position.y, 0);

    }

    IEnumerator Mover(float time, Vector3 posInit, Vector3 posFin) {
        float elapsedTime = 0;
        while (elapsedTime < time) {
            subMenu.position = Vector3.Lerp(posInit, posFin, (elapsedTime / time));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        subMenu.position = posFin;

    }

    void MoverMenu(float time, Vector3 posInit, Vector3 posFin){

        StartCoroutine(Mover(time, posInit, posFin));

    }

    public void BUTTON_sub_menu (){
        int signo = 1;
        if (!abrirMenu)
            signo = -1;
        MoverMenu(tiempo, subMenu.position, new Vector3(signo * posFinal, subMenu.position.y, 0));
        abrirMenu = !abrirMenu;


    } 

   
}

