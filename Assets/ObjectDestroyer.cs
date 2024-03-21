using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    void OnBecameInvisible()
    {
        // オブジェクトがカメラのビューポートから見えなくなったら破棄する
        Destroy(gameObject);

        Debug.Log("消える関数通った");
    }
}
