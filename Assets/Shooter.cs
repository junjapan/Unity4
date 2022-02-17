using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //RaycastHit hit;
            //hitは参照渡し。この場合宣言時はnull。
            //out宣言すると、raycastメソッドは中で値を入れてくれてる（初期化）。
            //raycastメソッド以外でout宣言した場合はメソッド内で初期化をする必要あり。
            //            if(Physics.Raycast(ray, out hit, 100f))
            //            {
            //                Destroy(hit.collider.gameObject);
            //            }
            //            foreach (RaycastHit hit in Physics.RaycastAll(ray))
            //            {
            //                Destroy(hit.collider.gameObject);
            //            }
            foreach (RaycastHit hit in Physics.SphereCastAll(ray, 3f))
            {
                Destroy(hit.collider.gameObject);
            }
        }


    }
}
