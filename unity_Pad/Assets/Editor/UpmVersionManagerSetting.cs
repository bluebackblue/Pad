

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief 設定。
*/


/** Editor
*/
#if(UNITY_EDITOR)
namespace Editor
{
	/** UpmVersionManagerSetting
	*/
	[UnityEditor.InitializeOnLoad]
	public static class UpmVersionManagerSetting
	{
		/** UpmVersionManagerSetting
		*/
		static UpmVersionManagerSetting()
		{
			//Object_RootUssUxml
			BlueBack.UpmVersionManager.Editor.Object_RootUssUxml.CreateFile(false);

			BlueBack.UpmVersionManager.Editor.Object_Setting.CreateInstance();
			BlueBack.UpmVersionManager.Editor.Object_Setting.Param t_param = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param();
			{
				//author_name
				t_param.author_name = "BlueBack";

				//git_url
				t_param.git_url = "https://github.com/";

				//git_author
				t_param.git_author = "bluebackblue";

				//git_path
				t_param.git_path = "unity_Pad/Assets/UPM";

				//package_name
				t_param.package_name = "Pad";

				//packagejson_unity
				t_param.packagejson_unity = "2020.1";

				//packagejson_discription
				t_param.packagejson_discription = "パッド操作";

				//packagejson_keyword
				t_param.packagejson_keyword = new string[]{
					"input","pad"
				};

				//packagejson_dependencies
				t_param.packagejson_dependencies = new System.Collections.Generic.Dictionary<string,string>(){
					//{"xxxxx.xxxxx","https://github.com/xxxxx/xxxxx"},
				};

				//root_readmemd_path
				t_param.root_readmemd_path = "../../README.md";

				//asmdef_runtime
				t_param.asmdef_runtime = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefItem{
					reference_list = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefReferenceItem[]{
						new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefReferenceItem(){
							package_name = "BlueBack.UnityPlayerLoop",
							url = "https://github.com/bluebackblue/UnityPlayerLoop",
						},
						new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefReferenceItem(){
							package_name = "Unity.InputSystem",
							url = "https://docs.unity3d.com/ja/2019.4/Manual/com.unity.inputsystem.html",
						},
					},
					versiondefine_list = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefVersionDefineItem[]{
						new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefVersionDefineItem(){
							name = "com.unity.inputsystem",
							define = "DEF_BLUEBACK_PAD_UIS",
							expression = "",
						}
					},
				};

				//asmdef_editor
				t_param.asmdef_editor = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefItem{
					reference_list = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefReferenceItem[]{
						new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefReferenceItem(){
							package_name = "BlueBack.Pad",
							url = "https://github.com/bluebackblue/Pad",
						},
					},
					versiondefine_list = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefVersionDefineItem[]{
					},
				};

				//asmdef_sample
				t_param.asmdef_sample = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefItem{
					reference_list = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefReferenceItem[]{
						new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefReferenceItem(){
							package_name = "BlueBack.Pad",
							url = "https://github.com/bluebackblue/Pad",
						},
						new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefReferenceItem(){
							package_name = "BlueBack.Pad.Editor",
							url = "https://github.com/bluebackblue/Pad",
						},
						new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefReferenceItem(){
							package_name = "Unity.InputSystem",
							url = "https://docs.unity3d.com/ja/2019.4/Manual/com.unity.inputsystem.html",
						},
					},
					versiondefine_list = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefVersionDefineItem[]{
					},
				};

				//changelog
				t_param.changelog = new string[]{
					"# Changelog",
					"",

					"## [0.0.1] - 2021-04-09",
					"### Changes",
					"- Init",
					"",
				};

				//readme_md
				t_param.object_root_readme_md = new BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Type[]{

					//概要。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"# " + a_argument.param.author_name + "." + a_argument.param.package_name,
							"パッド操作",
							"* パッドのボタン取得",
							"* FixedUpdateでのダウン、アップ、連射の取得"
						};
					},

					//ライセンス。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## ライセンス",
							"MIT License",
							"* " + a_argument.param.git_url + a_argument.param.git_author + "/" + a_argument.param.package_name + "/blob/main/LICENSE",
						};
					},

					//依存。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						System.Collections.Generic.List<string> t_list = new System.Collections.Generic.List<string>();
						t_list.Add("## 依存 / 使用ライセンス等");
						t_list.AddRange(BlueBack.UpmVersionManager.Editor.Object_Setting.Create_RootReadMd_Asmdef_Dependence(a_argument));
						return t_list.ToArray();
					},

					//動作確認。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## 動作確認",
							"Unity " + UnityEngine.Application.unityVersion,
						};
					},

					//UPM。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## UPM",
							"### 最新",
							"* " + a_argument.param.git_url + a_argument.param.git_author + "/" + a_argument.param.package_name + ".git?path=" + a_argument.param.git_path + "#" + a_argument.version,
							"### 開発",
							"* " + a_argument.param.git_url + a_argument.param.git_author + "/" + a_argument.param.package_name + ".git?path=" + a_argument.param.git_path,
						};
					},

					//インストール。 
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## Unityへの追加方法",
							"* Unity起動",
							"* メニュー選択：「Window->Package Manager」",
							"* ボタン選択：「左上の＋ボタン」",
							"* リスト選択：「Add package from git URL...」",
							"* 上記UPMのURLを追加「 https://github.com/～～/UPM#バージョン 」",
							"### 注",
							"Gitクライアントがインストールされている必要がある。",
							"* https://docs.unity3d.com/ja/current/Manual/upm-git.html",
							"* https://git-scm.com/",
						};
					},

					//例。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## 例",
							"```",
							"/** Update用。",
							"*/",
							"private BlueBack.Pad.Pad pad;",
							"",
							"/** FixedUpdate用。",
							"*/",
							"private BlueBack.Pad.Pad pad_fixedupdate;",
							"",
							"/** Start",
							"*/",
							"private void Start()",
							"{",
							"	//Param",
							"	BlueBack.Pad.UIM.Param t_param = new BlueBack.Pad.UIM.Param(BlueBack.Pad.UIM.Param.ParamType.PS_ALL);",
							"",
							"	//Update用。",
							"	this.pad = new BlueBack.Pad.Pad(BlueBack.Pad.Mode.Update,new BlueBack.Pad.Param(),new BlueBack.Pad.UIM.Engine(t_param));",
							"",
							"	//FixedUpdate用。",
							"	this.pad_fixedupdate = new BlueBack.Pad.Pad(BlueBack.Pad.Mode.FixedUpdate,new BlueBack.Pad.Param(),new BlueBack.Pad.UIM.Engine(t_param));",
							"}",
							"",
							"/** Update",
							"*/",
							"private void Update()",
							"{",
							"	if(this.pad.dir_r.down == true){",
							"		UnityEngine.Debug.Log(\"Update : Right\");",
							"	}",
							"	if(this.pad.dir_d.down == true){",
							"		UnityEngine.Debug.Log(\"Update : Down\");",
							"	}",
							"	if(this.pad.dir_l.down == true){",
							"		UnityEngine.Debug.Log(\"Update : Left\");",
							"	}",
							"	if(this.pad.dir_u.down == true){",
							"		UnityEngine.Debug.Log(\"Update : Up\");",
							"	}",
							"}",
							"",
							"/** FixedUpdate",
							"*/",
							"private void FixedUpdate()",
							"{",
							"	if(this.pad_fixedupdate.dir_r.down == true){",
							"		UnityEngine.Debug.Log(\"Update : Right\");",
							"	}",
							"	if(this.pad_fixedupdate.dir_d.down == true){",
							"		UnityEngine.Debug.Log(\"Update : Down\");",
							"	}",
							"	if(this.pad_fixedupdate.dir_l.down == true){",
							"		UnityEngine.Debug.Log(\"Update : Left\");",
							"	}",
							"	if(this.pad_fixedupdate.dir_u.down == true){",
							"		UnityEngine.Debug.Log(\"Update : Up\");",
							"	}",
							"}",

							"```",
							"### InputManagerAssetへの追加方向",
							"![Sample00](/sample00.png)",
						};
					},
				};
			}

			BlueBack.UpmVersionManager.Editor.Object_Setting.GetInstance().Set(t_param);
		}
	}
}
#endif

