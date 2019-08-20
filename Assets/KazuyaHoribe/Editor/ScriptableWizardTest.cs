using UnityEngine;
using UnityEditor; // 追加
using System.Collections;
 
public class Sample {
    [MenuItem ("Sample/Menu/HelloFromMenuBar %h")]
    static void SayHelloFromMenuBar() {
        Debug.Log ("Hello From Menu Bar");
    }
}
