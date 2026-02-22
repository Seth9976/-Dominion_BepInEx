using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.SceneManagement
{
	// Token: 0x0200011B RID: 283
	[Serializable]
	[StructLayout(2)]
	public struct LoadSceneParameters
	{
		// Token: 0x060016FD RID: 5885 RVA: 0x00056F28 File Offset: 0x00055128
		// Note: this type is marked as 'beforefieldinit'.
		static LoadSceneParameters()
		{
			Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "LoadSceneParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr);
			LoadSceneParameters.NativeFieldInfoPtr_m_LoadSceneMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, "m_LoadSceneMode");
			LoadSceneParameters.NativeFieldInfoPtr_m_LocalPhysicsMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, "m_LocalPhysicsMode");
			LoadSceneParameters.NativeMethodInfoPtr__ctor_Public_Void_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, 100665019);
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x00056F94 File Offset: 0x00055194
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81525, RefRangeEnd = 81527, XrefRangeStart = 81525, XrefRangeEnd = 81525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadSceneParameters(LoadSceneMode mode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadSceneParameters.NativeMethodInfoPtr__ctor_Public_Void_LoadSceneMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x0000CD6A File Offset: 0x0000AF6A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, ref this));
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001700 RID: 5888 RVA: 0x00056FC8 File Offset: 0x000551C8
		// (set) Token: 0x06001701 RID: 5889 RVA: 0x0000CD7C File Offset: 0x0000AF7C
		public LoadSceneMode loadSceneMode
		{
			get
			{
				return this.m_LoadSceneMode;
			}
			set
			{
				this.m_LoadSceneMode = value;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001702 RID: 5890 RVA: 0x00056FE0 File Offset: 0x000551E0
		// (set) Token: 0x06001703 RID: 5891 RVA: 0x0000CD86 File Offset: 0x0000AF86
		public LocalPhysicsMode localPhysicsMode
		{
			get
			{
				return this.m_LocalPhysicsMode;
			}
			set
			{
				this.m_LocalPhysicsMode = value;
			}
		}

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadSceneMode;

		// Token: 0x040010C6 RID: 4294
		private static readonly IntPtr NativeFieldInfoPtr_m_LocalPhysicsMode;

		// Token: 0x040010C7 RID: 4295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LoadSceneMode_0;

		// Token: 0x040010C8 RID: 4296
		[FieldOffset(0)]
		public LoadSceneMode m_LoadSceneMode;

		// Token: 0x040010C9 RID: 4297
		[FieldOffset(4)]
		public LocalPhysicsMode m_LocalPhysicsMode;
	}
}
