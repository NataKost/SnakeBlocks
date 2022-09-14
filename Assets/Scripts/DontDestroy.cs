using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    static private GameObject firstInstance = null;
    void Awake()
    {
        if (firstInstance == null)
        {
            firstInstance = gameObject;
            DontDestroyOnLoad(gameObject);
        }

        else if (gameObject != firstInstance)
            Destroy(gameObject);
    }

}
