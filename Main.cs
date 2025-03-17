using MelonLoader;
using UnityEngine;
using Il2CppInterop;
using Il2CppInterop.Runtime.Injection; 
using System.Collections;

namespace PauseInJournal
{
	public class Main : MelonMod
	{
		public override void OnInitializeMelon()
		{           
			MelonLogger.Msg("Mod started!");
        }

		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
       


        }

        public override void OnUpdate()
		{

		}

    }
}