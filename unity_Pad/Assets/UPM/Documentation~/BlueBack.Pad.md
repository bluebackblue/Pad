# BlueBack.Pad
パッド操作
* パッドのボタン取得
* FixedUpdateでのダウン、アップ、連射の取得

## ライセンス
MIT License
* https://github.com/bluebackblue/Pad/blob/main/LICENSE

## 外部依存 / 使用ライセンス等
Unity.InputSystem
* https://github.com/bluebackblue/UnityPlayerLoop

## 動作確認
Unity 2021.1.11f1

## UPM
### 最新
* https://github.com/bluebackblue/Pad.git?path=unity_Pad/Assets/UPM#0.0.6
### 開発
* https://github.com/bluebackblue/Pad.git?path=unity_Pad/Assets/UPM

## Unityへの追加方法
* Unity起動
* メニュー選択：「Window->Package Manager」
* ボタン選択：「左上の＋ボタン」
* リスト選択：「Add package from git URL...」
* 上記UPMのURLを追加「 https://github.com/～～/UPM#バージョン 」
### 注
Gitクライアントがインストールされている必要がある。
* https://docs.unity3d.com/ja/current/Manual/upm-git.html
* https://git-scm.com/

## 例
```
/** Update用。
*/
private BlueBack.Pad.Pad pad;

/** FixedUpdate用。
*/
private BlueBack.Pad.Pad pad_fixedupdate;

/** Start
*/
private void Start()
{
	//Param
	BlueBack.Pad.UIM.Param t_param = new BlueBack.Pad.UIM.Param(BlueBack.Pad.UIM.Param.ParamType.PS_ALL);

	//Update用。
	this.pad = new BlueBack.Pad.Pad(BlueBack.Pad.Mode.Update,new BlueBack.Pad.Param(),new BlueBack.Pad.UIM.Engine(t_param));

	//FixedUpdate用。
	this.pad_fixedupdate = new BlueBack.Pad.Pad(BlueBack.Pad.Mode.FixedUpdate,new BlueBack.Pad.Param(),new BlueBack.Pad.UIM.Engine(t_param));
}

/** Update
*/
private void Update()
{
	if(this.pad.dir_r.down == true){
		UnityEngine.Debug.Log("Update : Right");
	}
	if(this.pad.dir_d.down == true){
		UnityEngine.Debug.Log("Update : Down");
	}
	if(this.pad.dir_l.down == true){
		UnityEngine.Debug.Log("Update : Left");
	}
	if(this.pad.dir_u.down == true){
		UnityEngine.Debug.Log("Update : Up");
	}
}

/** FixedUpdate
*/
private void FixedUpdate()
{
	if(this.pad_fixedupdate.dir_r.down == true){
		UnityEngine.Debug.Log("Update : Right");
	}
	if(this.pad_fixedupdate.dir_d.down == true){
		UnityEngine.Debug.Log("Update : Down");
	}
	if(this.pad_fixedupdate.dir_l.down == true){
		UnityEngine.Debug.Log("Update : Left");
	}
	if(this.pad_fixedupdate.dir_u.down == true){
		UnityEngine.Debug.Log("Update : Up");
	}
}
```
### InputManagerAssetへの追加方向
![Sample00](/sample00.png)

