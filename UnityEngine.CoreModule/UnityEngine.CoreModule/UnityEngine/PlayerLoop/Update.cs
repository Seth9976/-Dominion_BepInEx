using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x02000124 RID: 292
	[StructLayout(2)]
	public struct Update
	{
		// Token: 0x06001729 RID: 5929 RVA: 0x0000CFFB File Offset: 0x0000B1FB
		// Note: this type is marked as 'beforefieldinit'.
		static Update()
		{
			Il2CppClassPointerStore<Update>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "Update");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update>.NativeClassPtr);
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x0000D020 File Offset: 0x0000B220
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update>.NativeClassPtr, ref this));
		}

		// Token: 0x02000919 RID: 2329
		[StructLayout(2)]
		public struct ScriptRunBehaviourUpdate
		{
			// Token: 0x06003033 RID: 12339 RVA: 0x00016945 File Offset: 0x00014B45
			// Note: this type is marked as 'beforefieldinit'.
			static ScriptRunBehaviourUpdate()
			{
				Il2CppClassPointerStore<Update.ScriptRunBehaviourUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, "ScriptRunBehaviourUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update.ScriptRunBehaviourUpdate>.NativeClassPtr);
			}

			// Token: 0x06003034 RID: 12340 RVA: 0x00016965 File Offset: 0x00014B65
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update.ScriptRunBehaviourUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x0200091A RID: 2330
		[StructLayout(2)]
		public struct DirectorUpdate
		{
			// Token: 0x06003035 RID: 12341 RVA: 0x00016977 File Offset: 0x00014B77
			// Note: this type is marked as 'beforefieldinit'.
			static DirectorUpdate()
			{
				Il2CppClassPointerStore<Update.DirectorUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, "DirectorUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update.DirectorUpdate>.NativeClassPtr);
			}

			// Token: 0x06003036 RID: 12342 RVA: 0x00016997 File Offset: 0x00014B97
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update.DirectorUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x0200091B RID: 2331
		[StructLayout(2)]
		public struct ScriptRunDelayedDynamicFrameRate
		{
			// Token: 0x06003037 RID: 12343 RVA: 0x000169A9 File Offset: 0x00014BA9
			// Note: this type is marked as 'beforefieldinit'.
			static ScriptRunDelayedDynamicFrameRate()
			{
				Il2CppClassPointerStore<Update.ScriptRunDelayedDynamicFrameRate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, "ScriptRunDelayedDynamicFrameRate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update.ScriptRunDelayedDynamicFrameRate>.NativeClassPtr);
			}

			// Token: 0x06003038 RID: 12344 RVA: 0x000169C9 File Offset: 0x00014BC9
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update.ScriptRunDelayedDynamicFrameRate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x0200091C RID: 2332
		[StructLayout(2)]
		public struct ScriptRunDelayedTasks
		{
			// Token: 0x06003039 RID: 12345 RVA: 0x000169DB File Offset: 0x00014BDB
			// Note: this type is marked as 'beforefieldinit'.
			static ScriptRunDelayedTasks()
			{
				Il2CppClassPointerStore<Update.ScriptRunDelayedTasks>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, "ScriptRunDelayedTasks");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update.ScriptRunDelayedTasks>.NativeClassPtr);
			}

			// Token: 0x0600303A RID: 12346 RVA: 0x000169FB File Offset: 0x00014BFB
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update.ScriptRunDelayedTasks>.NativeClassPtr, ref this));
			}
		}
	}
}
