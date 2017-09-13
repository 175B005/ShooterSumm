using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoretext : MonoBehaviour
{
    public static scoretext instance;
    public GameObject scorePr;
    public Transform canvasT;

    /*
    public Text scorePt;
    
    public Canvas canvasP;
    */
    //親←canvasを入れておく

    private void Awake()
    {
        instance = this;
    }

    public static void TextCreate(int n)
    {

        Quaternion qua = new Quaternion();
        qua = Quaternion.identity;

        Vector3 mmpos = Input.mousePosition;
        mmpos.y = mmpos.y - 10;

    
            GameObject prefab = 
			Instantiate (instance.scorePr, mmpos, qua);
        prefab.transform.SetParent(instance.canvasT);

      
          //  instance.scorePt.transform.SetParent(instance.canvasP.transform, false);
			prefab.GetComponent<Text>().text = "" + n.ToString ();
           // instance.scorePt.transform.SetParent(Transform.parent,false);
        


    }
}