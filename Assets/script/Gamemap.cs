using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Click()
    {
        SceneManager.LoadScene("Quest1-1");
    }
    public void Clickmap()
    {
        SceneManager.LoadScene("map");
    }
    public void Clickdoor()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
