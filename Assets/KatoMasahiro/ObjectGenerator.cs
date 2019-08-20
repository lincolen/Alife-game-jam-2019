using System.Collections;
using UnityEngine;

public class ObjectGenerator : MonoBehaviour{
    // 生成するゲームオブジェクト
    public GameObject target;

    void update(){
        //スペースを押したら出現
        if (Input.GetKeyDown(KeyCode.Space)){
            int x = Random.Range(-100,100);
            int y = Random.Range(-100,100);
            int z = Random.Range(-100,100);

            Instantiate(target,new Vector3(x,y,z),Quaternion.identity);
        }
    }
}
