using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//-座標指定、ボールを順次生成するスクリプト-
public class BallCrate : MonoBehaviour {

	public GameObject blockPrefab;
	public GameObject blockPrefab1;
	public GameObject blockPrefab2;

	public static int countball = 0;
	public static int high = 11;

	//スポーン位置初期作成。pos,1,2に代入
	Vector3 pos = new Vector3 (4.56f, 1.66f, -1.12f);
	Vector3 pos1 = new Vector3 (3.51f,1.11f,-2.15f);
	Vector3 pos2 = new Vector3 (2.56f,0.6f,-3.04f);
	void Start(){

		Quaternion qua = new Quaternion ();
		qua = Quaternion.identity;

		Instantiate (blockPrefab, pos, qua);	
		Instantiate (blockPrefab1, pos1, qua);	
		Instantiate (blockPrefab2, pos2, qua);	
		countball = 3;
		//Debug.Log (countball);
	}

	void Update(){
		Quaternion qua = new Quaternion ();
		qua = Quaternion.identity;


			if (countball < 11) {
				switch (high) {
				case 11:
					Instantiate (blockPrefab, pos, qua);	
					countball += 1;
					//Debug.Log (countball);
					break;
				case 22:
					Instantiate (blockPrefab1, pos1, qua);	
					countball += 1;
				//	Debug.Log (countball);
					break;
				case 33:
					Instantiate (blockPrefab2, pos2, qua);	
					countball += 1;
					//Debug.Log (countball);
					break;
				}

		}
	}
}