

/** BlueBack.Pad.Samples.InputSystem
*/
#if(!DEF_BLUEBACK_PAD_SAMPLES_DISABLE)
namespace BlueBack.Pad.Samples.InputSystem
{
	/** Main_MonoBehaviour
	*/
	public sealed class Main_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		#if(ENABLE_INPUT_SYSTEM)

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
			//initparam
			BlueBack.Pad.UIS.InitParam t_initparam_uis = BlueBack.Pad.UIS.InitParam.CreateDefault();

			//Update用。
			{
				BlueBack.Pad.InitParam t_initparam = BlueBack.Pad.InitParam.CreateDefault();
				{
					t_initparam.updatemode = UpdateMode.UnityUpdate;
					t_initparam.engine = new BlueBack.Pad.UIS.Engine(in t_initparam_uis);
				}
				this.pad = new BlueBack.Pad.Pad(in t_initparam);
			}

			//FixedUpdate用。
			{
				BlueBack.Pad.InitParam t_initparam = BlueBack.Pad.InitParam.CreateDefault();
				{
					t_initparam.updatemode = UpdateMode.UnityFixedUpdate;
					t_initparam.engine = new BlueBack.Pad.UIS.Engine(in t_initparam_uis);
				}
				this.pad_fixedupdate = new BlueBack.Pad.Pad(in t_initparam);
			}
		}

		/** OnDestroy
		*/
		private void OnDestroy()
		{
			if(this.pad != null){
				this.pad.Dispose();
				this.pad = null;
			}

			if(this.pad_fixedupdate != null){
				this.pad_fixedupdate.Dispose();
				this.pad_fixedupdate = null;
			}
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

			if(this.pad.button_l.down == true){
				UnityEngine.Debug.Log("button_l");
			}
			if(this.pad.button_r.down == true){
				UnityEngine.Debug.Log("button_r");
			}
			if(this.pad.button_u.down == true){
				UnityEngine.Debug.Log("button_u");
			}
			if(this.pad.button_d.down == true){
				UnityEngine.Debug.Log("button_d");
			}

			if(this.pad.menu_l.down == true){
				UnityEngine.Debug.Log("menu_l");
			}
			if(this.pad.menu_r.down == true){
				UnityEngine.Debug.Log("menu_r");
			}

			if(this.pad.button_lt1.down == true){
				UnityEngine.Debug.Log("button_lt1");
			}
			if(this.pad.button_rt1.down == true){
				UnityEngine.Debug.Log("button_rt1");
			}
			if(this.pad.button_lt3.down == true){
				UnityEngine.Debug.Log("button_lt3");
			}
			if(this.pad.button_rt3.down == true){
				UnityEngine.Debug.Log("button_rt3");
			}

			if(this.pad.stick_l.pos.x != 0.0f){
				UnityEngine.Debug.Log("stick_l.pos.x : " + this.pad.stick_l.pos.x.ToString("0.0000"));
			}
			if(this.pad.stick_l.pos.y != 0.0f){
				UnityEngine.Debug.Log("stick_l.pos.y : " + this.pad.stick_l.pos.y.ToString("0.0000"));
			}
			if(this.pad.stick_r.pos.x != 0.0f){
				UnityEngine.Debug.Log("stick_r.pos.x : " + this.pad.stick_r.pos.x.ToString("0.0000"));
			}
			if(this.pad.stick_r.pos.y != 0.0f){
				UnityEngine.Debug.Log("stick_r.pos.y : " + this.pad.stick_r.pos.y.ToString("0.0000"));
			}

			if(this.pad.analog_lt2.value != 0.0f){
				UnityEngine.Debug.Log("analog_lt2 : " + this.pad.analog_lt2.value.ToString("0.0000"));
			}
			if(this.pad.analog_rt2.value != 0.0f){
				UnityEngine.Debug.Log("analog_rt2 : " + this.pad.analog_rt2.value.ToString("0.0000"));
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

		#endif
	}
}
#endif

