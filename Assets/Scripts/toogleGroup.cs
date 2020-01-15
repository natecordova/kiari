using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class toogleGroup : MonoBehaviour
{
    ToggleGroup toggleGroupInstance;


    public Toggle currentSelection
    {
        get { return toggleGroupInstance.ActiveToggles().FirstOrDefault(); }
    }

    // Start is called before the first frame update
    void Start()
    {

       toggleGroupInstance = GetComponent<ToggleGroup>();

        //SelectToggle(1);

    }

    public void SelectToggle(int id)
    {

        var toggles = toggleGroupInstance.GetComponentsInChildren<Toggle>();
        toggles[id].isOn = true;


    }

    public void ChangeScenes() //permite cambiar de escenas con los toogle
    {
            Toggle checkbox1 = GameObject.Find("Toggle1").GetComponent<Toggle>();
            Toggle checkbox2 = GameObject.Find("Toggle2").GetComponent<Toggle>();
            Toggle checkbox3 = GameObject.Find("Toggle3").GetComponent<Toggle>();
        if (checkbox1.isOn == true)
        {
            Debug.Log("check1");
            SceneManager.LoadScene(1);
        }
        else if(checkbox2.isOn == true)
        {
            Debug.Log("check2");
            SceneManager.LoadScene(2);
        }
        else if (checkbox3.isOn == true)
        {
            Debug.Log("check3");
            SceneManager.LoadScene(3);
        }




       


    }
    void update()
    {

    }

}
