using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveNext : MonoBehaviour
{
    public int Timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        while (true)
        {
            Timer++;

            if (Timer == 1)
            {
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer == 1)
        {
            SceneManager.LoadScene("CubeScene");
        }
    }
}
