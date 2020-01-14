using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsPanel : MonoBehaviour
{
    public GameObject Panel;

    // Start is called before the first frame update
    public void ClosePanelPopUp()
    {
        if(Panel != null)
        {
            Panel.SetActive(false);
        }
    }

    public void ChangeScenes()
    {
        SceneManager.LoadScene(3);

    }



}
