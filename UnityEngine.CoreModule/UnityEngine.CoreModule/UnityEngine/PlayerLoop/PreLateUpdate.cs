using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x02000125 RID: 293
	[StructLayout(2)]
	public struct PreLateUpdate
	{
		// Token: 0x0600172B RID: 5931 RVA: 0x0000D032 File Offset: 0x0000B232
		// Note: this type is marked as 'beforefieldinit'.
		static PreLateUpdate()
		{
			Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "PreLateUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr);
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x0000D057 File Offset: 0x0000B257
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, ref this));
		}

		// Token: 0x0200091D RID: 2333
		[StructLayout(2)]
		public struct Physics2DLateUpdate
		{
			// Token: 0x0600303B RID: 12347 RVA: 0x00016A0D File Offset: 0x00014C0D
			// Note: this type is marked as 'beforefieldinit'.
			static Physics2DLateUpdate()
			{
				Il2CppClassPointerStore<PreLateUpdate.Physics2DLateUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "Physics2DLateUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.Physics2DLateUpdate>.NativeClassPtr);
			}

			// Token: 0x0600303C RID: 12348 RVA: 0x00016A2D File Offset: 0x00014C2D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.Physics2DLateUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x0200091E RID: 2334
		[StructLayout(2)]
		public struct AIUpdatePostScript
		{
			// Token: 0x0600303D RID: 12349 RVA: 0x00016A3F File Offset: 0x00014C3F
			// Note: this type is marked as 'beforefieldinit'.
			static AIUpdatePostScript()
			{
				Il2CppClassPointerStore<PreLateUpdate.AIUpdatePostScript>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "AIUpdatePostScript");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.AIUpdatePostScript>.NativeClassPtr);
			}

			// Token: 0x0600303E RID: 12350 RVA: 0x00016A5F File Offset: 0x00014C5F
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.AIUpdatePostScript>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x0200091F RID: 2335
		[StructLayout(2)]
		public struct DirectorUpdateAnimationBegin
		{
			// Token: 0x0600303F RID: 12351 RVA: 0x00016A71 File Offset: 0x00014C71
			// Note: this type is marked as 'beforefieldinit'.
			static DirectorUpdateAnimationBegin()
			{
				Il2CppClassPointerStore<PreLateUpdate.DirectorUpdateAnimationBegin>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "DirectorUpdateAnimationBegin");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.DirectorUpdateAnimationBegin>.NativeClassPtr);
			}

			// Token: 0x06003040 RID: 12352 RVA: 0x00016A91 File Offset: 0x00014C91
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.DirectorUpdateAnimationBegin>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000920 RID: 2336
		[StructLayout(2)]
		public struct LegacyAnimationUpdate
		{
			// Token: 0x06003041 RID: 12353 RVA: 0x00016AA3 File Offset: 0x00014CA3
			// Note: this type is marked as 'beforefieldinit'.
			static LegacyAnimationUpdate()
			{
				Il2CppClassPointerStore<PreLateUpdate.LegacyAnimationUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "LegacyAnimationUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.LegacyAnimationUpdate>.NativeClassPtr);
			}

			// Token: 0x06003042 RID: 12354 RVA: 0x00016AC3 File Offset: 0x00014CC3
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.LegacyAnimationUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000921 RID: 2337
		[StructLayout(2)]
		public struct DirectorUpdateAnimationEnd
		{
			// Token: 0x06003043 RID: 12355 RVA: 0x00016AD5 File Offset: 0x00014CD5
			// Note: this type is marked as 'beforefieldinit'.
			static DirectorUpdateAnimationEnd()
			{
				Il2CppClassPointerStore<PreLateUpdate.DirectorUpdateAnimationEnd>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "DirectorUpdateAnimationEnd");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.DirectorUpdateAnimationEnd>.NativeClassPtr);
			}

			// Token: 0x06003044 RID: 12356 RVA: 0x00016AF5 File Offset: 0x00014CF5
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.DirectorUpdateAnimationEnd>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000922 RID: 2338
		[StructLayout(2)]
		public struct DirectorDeferredEvaluate
		{
			// Token: 0x06003045 RID: 12357 RVA: 0x00016B07 File Offset: 0x00014D07
			// Note: this type is marked as 'beforefieldinit'.
			static DirectorDeferredEvaluate()
			{
				Il2CppClassPointerStore<PreLateUpdate.DirectorDeferredEvaluate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "DirectorDeferredEvaluate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.DirectorDeferredEvaluate>.NativeClassPtr);
			}

			// Token: 0x06003046 RID: 12358 RVA: 0x00016B27 File Offset: 0x00014D27
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.DirectorDeferredEvaluate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000923 RID: 2339
		[StructLayout(2)]
		public struct UIElementsUpdatePanels
		{
			// Token: 0x06003047 RID: 12359 RVA: 0x00016B39 File Offset: 0x00014D39
			// Note: this type is marked as 'beforefieldinit'.
			static UIElementsUpdatePanels()
			{
				Il2CppClassPointerStore<PreLateUpdate.UIElementsUpdatePanels>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "UIElementsUpdatePanels");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.UIElementsUpdatePanels>.NativeClassPtr);
			}

			// Token: 0x06003048 RID: 12360 RVA: 0x00016B59 File Offset: 0x00014D59
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.UIElementsUpdatePanels>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000924 RID: 2340
		[StructLayout(2)]
		public struct UpdateNetworkManager
		{
			// Token: 0x06003049 RID: 12361 RVA: 0x00016B6B File Offset: 0x00014D6B
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateNetworkManager()
			{
				Il2CppClassPointerStore<PreLateUpdate.UpdateNetworkManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "UpdateNetworkManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.UpdateNetworkManager>.NativeClassPtr);
			}

			// Token: 0x0600304A RID: 12362 RVA: 0x00016B8B File Offset: 0x00014D8B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.UpdateNetworkManager>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000925 RID: 2341
		[StructLayout(2)]
		public struct UpdateMasterServerInterface
		{
			// Token: 0x0600304B RID: 12363 RVA: 0x00016B9D File Offset: 0x00014D9D
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateMasterServerInterface()
			{
				Il2CppClassPointerStore<PreLateUpdate.UpdateMasterServerInterface>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "UpdateMasterServerInterface");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.UpdateMasterServerInterface>.NativeClassPtr);
			}

			// Token: 0x0600304C RID: 12364 RVA: 0x00016BBD File Offset: 0x00014DBD
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.UpdateMasterServerInterface>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000926 RID: 2342
		[StructLayout(2)]
		public struct UNetUpdate
		{
			// Token: 0x0600304D RID: 12365 RVA: 0x00016BCF File Offset: 0x00014DCF
			// Note: this type is marked as 'beforefieldinit'.
			static UNetUpdate()
			{
				Il2CppClassPointerStore<PreLateUpdate.UNetUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "UNetUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.UNetUpdate>.NativeClassPtr);
			}

			// Token: 0x0600304E RID: 12366 RVA: 0x00016BEF File Offset: 0x00014DEF
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.UNetUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000927 RID: 2343
		[StructLayout(2)]
		public struct EndGraphicsJobsAfterScriptUpdate
		{
			// Token: 0x0600304F RID: 12367 RVA: 0x00016C01 File Offset: 0x00014E01
			// Note: this type is marked as 'beforefieldinit'.
			static EndGraphicsJobsAfterScriptUpdate()
			{
				Il2CppClassPointerStore<PreLateUpdate.EndGraphicsJobsAfterScriptUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "EndGraphicsJobsAfterScriptUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.EndGraphicsJobsAfterScriptUpdate>.NativeClassPtr);
			}

			// Token: 0x06003050 RID: 12368 RVA: 0x00016C21 File Offset: 0x00014E21
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.EndGraphicsJobsAfterScriptUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000928 RID: 2344
		[StructLayout(2)]
		public struct ParticleSystemBeginUpdateAll
		{
			// Token: 0x06003051 RID: 12369 RVA: 0x00016C33 File Offset: 0x00014E33
			// Note: this type is marked as 'beforefieldinit'.
			static ParticleSystemBeginUpdateAll()
			{
				Il2CppClassPointerStore<PreLateUpdate.ParticleSystemBeginUpdateAll>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "ParticleSystemBeginUpdateAll");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.ParticleSystemBeginUpdateAll>.NativeClassPtr);
			}

			// Token: 0x06003052 RID: 12370 RVA: 0x00016C53 File Offset: 0x00014E53
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.ParticleSystemBeginUpdateAll>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000929 RID: 2345
		[StructLayout(2)]
		public struct ScriptRunBehaviourLateUpdate
		{
			// Token: 0x06003053 RID: 12371 RVA: 0x00016C65 File Offset: 0x00014E65
			// Note: this type is marked as 'beforefieldinit'.
			static ScriptRunBehaviourLateUpdate()
			{
				Il2CppClassPointerStore<PreLateUpdate.ScriptRunBehaviourLateUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "ScriptRunBehaviourLateUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.ScriptRunBehaviourLateUpdate>.NativeClassPtr);
			}

			// Token: 0x06003054 RID: 12372 RVA: 0x00016C85 File Offset: 0x00014E85
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.ScriptRunBehaviourLateUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x0200092A RID: 2346
		[StructLayout(2)]
		public struct ConstraintManagerUpdate
		{
			// Token: 0x06003055 RID: 12373 RVA: 0x00016C97 File Offset: 0x00014E97
			// Note: this type is marked as 'beforefieldinit'.
			static ConstraintManagerUpdate()
			{
				Il2CppClassPointerStore<PreLateUpdate.ConstraintManagerUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "ConstraintManagerUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.ConstraintManagerUpdate>.NativeClassPtr);
			}

			// Token: 0x06003056 RID: 12374 RVA: 0x00016CB7 File Offset: 0x00014EB7
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.ConstraintManagerUpdate>.NativeClassPtr, ref this));
			}
		}
	}
}
