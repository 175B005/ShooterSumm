using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//-あたり判定、生成に必要な情報を渡す-
public class kill : MonoBehaviour {

	public float ar, ar1;

	void OnMouseEnter(){
		//Debug.Log ("10");
		//if (Input.GetMouseButtonDown(0)) {
	//		Debug.Log ("11");
			//Vector3 mpos = Input.mousePosition;
		if(Input.GetButtonDown("Fire1")){
			BallCrate.countball -= 1;
			/*いらない↓
			 * if(0.4f < mpos.y 
				&& mpos.y < 0.8f
				&& 0.92f < mpos.y
				&& mpos.y < 1.32f
				&& 1.46f < mpos.y
				&& mpos.y < 1.86f){

				mpos = Input.mousePosition;
				Vector3 spos = transform.position;

				 ar = spos.x - 0.2f;
				ar1 = spos.x + 0.2f;

				if(ar < spos.x
					&& spos.x < ar1){
					*/
			//効果音
			GameManager.PlaySE(4);

			if (CompareTag ("mato")) {
				GameParams.AddScore (1000);
				scoretext.TextCreate (1000);
				Destroy (gameObject);
			}
			if (CompareTag ("mato1")) {
				GameParams.AddScore (600);
				scoretext.TextCreate (600);
				Destroy (gameObject);
			}
			if (CompareTag ("mato2")) {
				GameParams.AddScore (350);
				scoretext.TextCreate (350);
				Destroy (gameObject);
			}	


			if (BallCrate.high != 33) {
				BallCrate.high += 11;
			} else {
				BallCrate.high = 11;
			}
			//Debug.Log (BallCrate.high);
			}
			}
		//}
	}
	//<sumary>
	/*mato=上ボール
	 * mato1=中
	 * mato2=下
	 * それぞれ早さが違うだけ
	 * 後で大きさなどかえるつもりだったｗ
	 * （変えてないｗ）
	*/