using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//-スコアを記録、表示するスクリプト-
public class GameParams : MonoBehaviour
{
    // 自分のインスタンス
    private static GameParams _instance;
    //　スコアテキスト
    public Text scoreText;
	public Text RscoreText;
	public Text MscoreText;
    // スコア
    private static int _score;
	private static int _Resultscore;
	private static int _Maxscore;

	//マネージャーから、スコアの追加に使用する。
    public static void AddScore(int add) 
    {
		
        _score += add;
        if (_score > 999999)
        {
            _score = 999999;
        }
        DrawScore();
    }
	public static void DeScore(int De)
	{
			_score -= De;
			if (_score < 0) {
				_score = 0;
			}
			DrawScore ();
		//Debug.Log (_score);
	}
	//最大スコアを記録しておく。
	public static void MaxScoreC(){
		_Resultscore = _score;
		//確認用_Resultscore = 9000;
			if (_Maxscore < _Resultscore) {
			_Maxscore = _Resultscore;
			}
		//確認用_Maxscore = 10000;

		//Debug.Log (_score);
	}

	//一番初めに実行、thisを入れておく。
    void Awake()
    {
        _instance = this;
    }

    public static void SetScore(int sc)
    {

        _score = sc;
        DrawScore();

    }

    public static void DrawScore()
	{
		if (_instance.scoreText != null) {
			_instance.scoreText.text = "Score " + _score.ToString ("D6");
		}
			if (_instance.RscoreText != null) {
				_instance.RscoreText.text = "" + _Resultscore.ToString ("D6");
			}
			if (_instance.MscoreText != null) {
				_instance.MscoreText.text = "" + _Maxscore.ToString ("D6");
			}
		}
	}
