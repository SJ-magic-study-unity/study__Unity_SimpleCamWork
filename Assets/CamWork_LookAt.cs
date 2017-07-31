/************************************************************
■Transform.LookAt
	https://docs.unity3d.com/jp/540/ScriptReference/Transform.LookAt.html

■gameObject.GetComponent<Transform>() と transform の違い（または Unity における省略記法について）
	http://qiita.com/megane42/items/9709d696e8f2561dbb1d
	
	contents (非常に理解が進む良い記事)
		・	componentは、アタッチされているGameObjectへの参照を持っている
		・	component内部において、transform は専用の内部関数でコンポーネントを取得しているため、高速
			GetComponent<>() のようにコンポーネントの検索コストがかからない

************************************************************/
using UnityEngine;
using System.Collections;

/************************************************************
************************************************************/
public class CamWork_LookAt : MonoBehaviour {
	public GameObject targetObj;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetPos = targetObj.transform.position;
		transform.LookAt(targetPos);
	}
}
