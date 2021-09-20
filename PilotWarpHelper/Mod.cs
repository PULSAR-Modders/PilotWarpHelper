using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using PulsarModLoader;
using UnityEngine;

namespace PilotWarpHelper
{
	// Token: 0x02000003 RID: 3
	public class Plugin : PulsarMod
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002138 File Offset: 0x00000338
		public override string Version
		{
			get
			{
				return "1.0.0.0";
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000213F File Offset: 0x0000033F
		public override string Author
		{
			get
			{
				return "BadRyuner";
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002146 File Offset: 0x00000346
		public override string Name
		{
			get
			{
				return "PilotWarpHelper";
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000214D File Offset: 0x0000034D
		public override int MPFunctionality
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002150 File Offset: 0x00000350
		public override string HarmonyIdentifier()
		{
			return "BadRyuner.Utils.PilotWarpHelper";
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002157 File Offset: 0x00000357
		public Plugin()
		{
			this.Setup();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002168 File Offset: 0x00000368
		internal async Task Setup()
		{
			CreateMaterail();
			CreateGO();
		}

		internal void CreateMaterail()
		{
			MyObject.DrawMaterail = new Material(Shader.Find("Hidden/Internal-Colored"));
			MyObject.DrawMaterail.hideFlags = HideFlags.HideAndDontSave;
			MyObject.DrawMaterail.SetInt("_SrcBlend", 5);
			MyObject.DrawMaterail.SetInt("_DstBlend", 10);
			MyObject.DrawMaterail.SetInt("_Cull", 0);
			MyObject.DrawMaterail.SetInt("_ZWrite", 0);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000221C File Offset: 0x0000041C
		internal async void CreateGO()
		{
			GameObject gameObject = new GameObject();
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			gameObject.AddComponent<MyObject>();
			gameObject.hideFlags = HideFlags.HideAndDontSave;
			await Task.CompletedTask;
		}
	}
}

