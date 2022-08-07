

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief パッド。
*/


/** define
*/
#if((ASMDEF_BLUEBACK_UNITYPLAYERLOOP)||(USERDEF_BLUEBACK_UNITYPLAYERLOOP))
#define ASMDEF_TRUE
#else
#warning "ASMDEF_TRUE"
#endif


/** BlueBack.Pad
*/
namespace BlueBack.Pad
{
	/** Pad
	*/
	public sealed class Pad : System.IDisposable
	{
		/** engine
		*/
		public Engine_Base engine;

		/** スティック。
		*/
		public StatusStick stick_l;
		public StatusStick stick_r;

		/** アナログ。トリガー。
		*/
		public StatusAnalog analog_lt2;
		public StatusAnalog analog_rt2;

		/** メニュー。
		*/
		public StatusButton menu_l;
		public StatusButton menu_r;

		/** 十字。
		*/
		public StatusButton dir_r;
		public StatusButton dir_d;
		public StatusButton dir_l;
		public StatusButton dir_u;

		/** ボタン。
		*/
		public StatusButton button_r;
		public StatusButton button_d;
		public StatusButton button_l;
		public StatusButton button_u;

		/** ボタン。スティック。
		*/
		public StatusButton button_lsr;
		public StatusButton button_lsd;
		public StatusButton button_lsl;
		public StatusButton button_lsu;
		public StatusButton button_rsr;
		public StatusButton button_rsd;
		public StatusButton button_rsl;
		public StatusButton button_rsu;

		/** ボタン。トリガー。
		*/
		public StatusButton button_lt1;
		public StatusButton button_lt2;
		public StatusButton button_lt3;
		public StatusButton button_rt1;
		public StatusButton button_rt2;
		public StatusButton button_rt3;

		/** constructor
		*/
		public Pad(Mode a_mode,in InitParam a_initparam,Engine_Base a_engine)
		#if(ASMDEF_TRUE)
		{
			//PlayerLoopSystem
			{
				UnityEngine.LowLevel.PlayerLoopSystem t_playerloopsystem = BlueBack.UnityPlayerLoop.UnityPlayerLoop.GetCurrentPlayerLoop();

				//StatusUpdate
				switch(a_mode){
				case Mode.FixedUpdate:
					{
						BlueBack.UnityPlayerLoop.Add.AddFromType(ref t_playerloopsystem,UnityPlayerLoop.Mode.AddFirst,typeof(UnityEngine.PlayerLoop.FixedUpdate),typeof(PlayerLoopType.Status),this.StatusUpdate);
					}break;
				case Mode.Update:
					{
						BlueBack.UnityPlayerLoop.Add.AddFromType(ref t_playerloopsystem,UnityPlayerLoop.Mode.AddFirst,typeof(UnityEngine.PlayerLoop.Update),typeof(PlayerLoopType.Status),this.StatusUpdate);
					}break;
				case Mode.Manual:
					{
					}break;
				}

				//DeviceUpdate
				BlueBack.UnityPlayerLoop.Add.AddFromType(ref t_playerloopsystem,UnityPlayerLoop.Mode.AddFirst,typeof(UnityEngine.PlayerLoop.Update),typeof(PlayerLoopType.Device),this.DeviceUpdate);

				//SetPlayerLoop
				BlueBack.UnityPlayerLoop.UnityPlayerLoop.SetPlayerLoop(t_playerloopsystem);

				//SetDefaultPlayerLoopOnUnityDestroy
				BlueBack.UnityPlayerLoop.UnityPlayerLoop.SetDefaultPlayerLoopOnUnityDestroy();
			}

			//engine
			this.engine = a_engine;
			this.engine.Create();

			//Init
			{
				//スティック。
				this.stick_l.Init();
				this.stick_r.Init();

				//アナログ。トリガー。
				this.analog_lt2.Init();
				this.analog_rt2.Init();

				//メニュー。
				this.menu_l.Init(in a_initparam);
				this.menu_r.Init(in a_initparam);

				//十字。
				this.dir_r.Init(in a_initparam);
				this.dir_d.Init(in a_initparam);
				this.dir_l.Init(in a_initparam);
				this.dir_u.Init(in a_initparam);

				//ボタン。
				this.button_r.Init(in a_initparam);
				this.button_d.Init(in a_initparam);
				this.button_l.Init(in a_initparam);
				this.button_u.Init(in a_initparam);

				//ボタン。スティック。
				this.button_lsr.Init(in a_initparam);
				this.button_lsd.Init(in a_initparam);
				this.button_lsl.Init(in a_initparam);
				this.button_lsu.Init(in a_initparam);
				this.button_rsr.Init(in a_initparam);
				this.button_rsd.Init(in a_initparam);
				this.button_rsl.Init(in a_initparam);
				this.button_rsu.Init(in a_initparam);

				//ボタン。トリガー。
				this.button_lt1.Init(in a_initparam);
				this.button_lt2.Init(in a_initparam);
				this.button_lt3.Init(in a_initparam);
				this.button_rt1.Init(in a_initparam);
				this.button_rt2.Init(in a_initparam);
				this.button_rt3.Init(in a_initparam);
			}
		}
		#else
		{
			#warning "ASMDEF_TRUE"
		}
		#endif

		/** [IDisposable]Dispose。
		*/
		public void Dispose()
		#if(ASMDEF_TRUE)
		{
			//engine
			this.engine.Delete();

			//PlayerLoopSystem
			UnityEngine.LowLevel.PlayerLoopSystem t_playerloopsystem = BlueBack.UnityPlayerLoop.UnityPlayerLoop.GetCurrentPlayerLoop();
			BlueBack.UnityPlayerLoop.Remove.RemoveFromType(ref t_playerloopsystem,typeof(PlayerLoopType.Status));
			BlueBack.UnityPlayerLoop.Remove.RemoveFromType(ref t_playerloopsystem,typeof(PlayerLoopType.Device));
			BlueBack.UnityPlayerLoop.UnityPlayerLoop.SetPlayerLoop(t_playerloopsystem);
		}
		#else
		{
			#warning "ASMDEF_TRUE"
		}
		#endif

		/** Reset
		*/
		public void Reset()
		{
			//スティック。
			this.stick_l.Reset();
			this.stick_r.Reset();

			//アナログ。トリガー。
			this.analog_lt2.Reset();
			this.analog_rt2.Reset();

			//メニュー。
			this.menu_l.Reset();
			this.menu_r.Reset();

			//十字。
			this.dir_r.Reset();
			this.dir_d.Reset();
			this.dir_l.Reset();
			this.dir_u.Reset();

			//ボタン。
			this.button_r.Reset();
			this.button_d.Reset();
			this.button_l.Reset();
			this.button_u.Reset();

			//ボタン。スティック。
			this.button_lsr.Reset();
			this.button_lsd.Reset();
			this.button_lsl.Reset();
			this.button_lsu.Reset();
			this.button_rsr.Reset();
			this.button_rsd.Reset();
			this.button_rsl.Reset();
			this.button_rsu.Reset();

			//ボタン。トリガー。
			this.button_lt1.Reset();
			this.button_lt2.Reset();
			this.button_lt3.Reset();
			this.button_rt1.Reset();
			this.button_rt2.Reset();
			this.button_rt3.Reset();
		}

		/** DeviceUpdate
		*/
		private void DeviceUpdate()
		{
			this.engine.PreUpdate();

			//スティック。
			this.stick_l.pos_old = this.stick_l.pos;
			this.stick_l.pos = this.engine.GetStickL();
			this.stick_r.pos_old = this.stick_r.pos;
			this.stick_r.pos = this.engine.GetStickR();

			//アナログ。トリガー。
			this.analog_lt2.value_old = this.analog_lt2.value;
			this.analog_lt2.value = this.engine.GetTriggerL2();
			this.analog_rt2.value_old = this.analog_rt2.value;
			this.analog_rt2.value = this.engine.GetTriggerR2();

			//最新の状態。
			{
				//メニュー。
				this.menu_l.device = this.engine.GetMenuL();
				this.menu_r.device = this.engine.GetMenuR();

				//十字。
				this.dir_r.device = this.engine.GetDirR();
				this.dir_d.device = this.engine.GetDirD();
				this.dir_l.device = this.engine.GetDirL();
				this.dir_u.device = this.engine.GetDirU();

				//ボタン。
				this.button_r.device = this.engine.GetButtonR();
				this.button_d.device = this.engine.GetButtonD();
				this.button_l.device = this.engine.GetButtonL();
				this.button_u.device = this.engine.GetButtonU();

				//ボタン。スティック。
				this.button_lsr.device = this.stick_l.pos.x > 0.5f;
				this.button_lsd.device = this.stick_l.pos.y > 0.5f;
				this.button_lsl.device = this.stick_l.pos.x < -0.5f;
				this.button_lsu.device = this.stick_l.pos.y < -0.5f;
				this.button_rsr.device = this.stick_r.pos.x > 0.5f;
				this.button_rsd.device = this.stick_r.pos.y > 0.5f;
				this.button_rsl.device = this.stick_r.pos.x < -0.5f;
				this.button_rsu.device = this.stick_r.pos.y < -0.5f;

				//ボタン。トリガー。
				this.button_lt1.device = this.engine.GetTriggerL1();
				this.button_lt2.device = this.analog_lt2.value > 0.5f;
				this.button_lt3.device = this.engine.GetTriggerL3();
				this.button_rt1.device = this.engine.GetTriggerR1();
				this.button_rt2.device = this.analog_rt2.value > 0.5f;
				this.button_rt3.device = this.engine.GetTriggerR3();
			}

			//累積。
			{
				//メニュー。
				this.menu_l.device |= this.menu_l.device;
				this.menu_r.device |= this.menu_r.device;

				//十字。
				this.dir_r.device_accumulation |= this.dir_r.device;
				this.dir_d.device_accumulation |= this.dir_d.device;
				this.dir_l.device_accumulation |= this.dir_l.device;
				this.dir_u.device_accumulation |= this.dir_u.device;

				//ボタン。
				this.button_r.device_accumulation |= this.button_r.device;
				this.button_d.device_accumulation |= this.button_d.device;
				this.button_l.device_accumulation |= this.button_l.device;
				this.button_u.device_accumulation |= this.button_u.device;

				//ボタン。スティック。
				this.button_lsr.device_accumulation |= this.button_lsr.device;
				this.button_lsd.device_accumulation |= this.button_lsd.device;
				this.button_lsl.device_accumulation |= this.button_lsl.device;
				this.button_lsu.device_accumulation |= this.button_lsu.device;
				this.button_rsr.device_accumulation |= this.button_rsr.device;
				this.button_rsd.device_accumulation |= this.button_rsd.device;
				this.button_rsl.device_accumulation |= this.button_rsl.device;
				this.button_rsu.device_accumulation |= this.button_rsu.device;

				//ボタン。トリガー。
				this.button_lt1.device_accumulation |= this.button_lt1.device;
				this.button_lt2.device_accumulation |= this.button_lt2.device;
				this.button_lt3.device_accumulation |= this.button_lt3.device;
				this.button_rt1.device_accumulation |= this.button_rt1.device;
				this.button_rt2.device_accumulation |= this.button_rt2.device;
				this.button_rt3.device_accumulation |= this.button_rt3.device;
			}
		}

		/** StatusUpdate
		*/
		public void StatusUpdate()
		{
			//更新。
			{
				//メニュー。
				this.menu_l.Update();
				this.menu_r.Update();

				//十字。
				this.dir_r.Update();
				this.dir_d.Update();
				this.dir_l.Update();
				this.dir_u.Update();

				//ボタン。
				this.button_r.Update();
				this.button_d.Update();
				this.button_l.Update();
				this.button_u.Update();

				//ボタン。スティック。
				this.button_lsr.Update();
				this.button_lsd.Update();
				this.button_lsl.Update();
				this.button_lsu.Update();
				this.button_rsr.Update();
				this.button_rsd.Update();
				this.button_rsl.Update();
				this.button_rsu.Update();

				//ボタン。トリガー。
				this.button_lt1.Update();
				this.button_lt2.Update();
				this.button_lt3.Update();
				this.button_rt1.Update();
				this.button_rt2.Update();
				this.button_rt3.Update();
			}

			//累積リセット。
			{
				//メニュー。
				this.menu_l.device_accumulation = this.menu_l.device;
				this.menu_r.device_accumulation = this.menu_r.device;

				//十字。
				this.dir_r.device_accumulation = this.dir_r.device;
				this.dir_d.device_accumulation = this.dir_d.device;
				this.dir_l.device_accumulation = this.dir_l.device;
				this.dir_u.device_accumulation = this.dir_u.device;

				//ボタン。
				this.button_r.device_accumulation = this.button_r.device;
				this.button_d.device_accumulation = this.button_d.device;
				this.button_l.device_accumulation = this.button_l.device;
				this.button_u.device_accumulation = this.button_u.device;

				//ボタン。スティック。
				this.button_lsr.device_accumulation = this.button_lsr.device;
				this.button_lsd.device_accumulation = this.button_lsd.device;
				this.button_lsl.device_accumulation = this.button_lsl.device;
				this.button_lsu.device_accumulation = this.button_lsu.device;
				this.button_rsr.device_accumulation = this.button_rsr.device;
				this.button_rsd.device_accumulation = this.button_rsd.device;
				this.button_rsl.device_accumulation = this.button_rsl.device;
				this.button_rsu.device_accumulation = this.button_rsu.device;

				//ボタン。トリガー。
				this.button_lt1.device_accumulation = this.button_lt1.device;
				this.button_lt2.device_accumulation = this.button_lt2.device;
				this.button_lt3.device_accumulation = this.button_lt3.device;
				this.button_rt1.device_accumulation = this.button_rt1.device;
				this.button_rt2.device_accumulation = this.button_rt2.device;
				this.button_rt3.device_accumulation = this.button_rt3.device;
			}
		}
	}
}

