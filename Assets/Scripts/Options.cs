using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    // config params
    

    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<Options>().Length;  //there's an 's' this time. Plural objects
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false); // this is needed to prevent weird bugs in the singleton.
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }


}
