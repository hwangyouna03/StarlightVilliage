using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Menu1()
    {
        SceneManager.LoadScene("Menu1");
    }
     public void Hot()
    {
        SceneManager.LoadScene("Hot");
    }
}
