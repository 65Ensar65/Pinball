using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBaseSingleton<T> : EBaseBehaviour where T : Component
{
    public static T instance;

    private static T Instance
    {
        get
        {
            if (instance == null)
            {
                FindObjectOfType<T>();
            }
            return instance;
        }
    }
    
}
