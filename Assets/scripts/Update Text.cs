using System.Collections;
using System.Collections.Generic;
using TMPro; //avisar al c�digo de que vas a utlizar otro c�digo que esta en otra localizaci�n
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class NewBehaviourScript : MonoBehaviour
{
    public GameManager.GameManagerVariables variable;


    private TMP_Text textComponent;

    // Start is called before the first frame update
    private void Start()
    {
        textComponent = GetComponent<TMP_Text>();

    }

    // Update is called once per frame
    void Update()
    {

        //interfaz
        switch (variable) 
        {
            case GameManager.GameManagerVariables.TIME:
                textComponent.text = "Time: " + GameManager.instance.GetTime().ToString("0.00"); // se a�ade el tostring para que devuelva una representacion de la barra de tiempo con solo dos decimales
                break;
            case GameManager.GameManagerVariables.POINTS:
                textComponent.text = "Points: " + GameManager.instance.GetPoints().ToString();
                break;
            default:
                break;

        }
        //el switch seria lo mismo que utilizar lo siguiente; al ser una varibale enumerada es mejor utilizar un switch
        //if(variable == GameManager.GameManagerVariables.TIME)
        //{

        //}
        //else if(variable == GameManager.GameManagerVariables.POINTS)
        //{

        //}
        //else
        //{

        //}
    }
}
