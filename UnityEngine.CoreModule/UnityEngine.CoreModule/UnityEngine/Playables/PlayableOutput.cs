using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000152 RID: 338
	[StructLayout(2)]
	public struct PlayableOutput
	{
		// Token: 0x06001A37 RID: 6711 RVA: 0x0005DC90 File Offset: 0x0005BE90
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableOutput()
		{
			Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr);
			PlayableOutput.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, "m_Handle");
			PlayableOutput.NativeFieldInfoPtr_m_NullPlayableOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, "m_NullPlayableOutput");
			PlayableOutput.NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, 100665220);
			PlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, 100665221);
			PlayableOutput.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, 100665222);
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x0005DD24 File Offset: 0x0005BF24
		[CallerCount(0)]
		public unsafe PlayableOutput(PlayableOutputHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutput.NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x0005DD58 File Offset: 0x0005BF58
		[CallerCount(0)]
		public unsafe PlayableOutputHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x0005DD88 File Offset: 0x0005BF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82796, XrefRangeEnd = 82804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(PlayableOutput other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutput.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutput_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x0000E92D File Offset: 0x0000CB2D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001A3C RID: 6716 RVA: 0x0005DDC8 File Offset: 0x0005BFC8
		// (set) Token: 0x06001A3D RID: 6717 RVA: 0x0000E93F File Offset: 0x0000CB3F
		public unsafe static PlayableOutput m_NullPlayableOutput
		{
			get
			{
				PlayableOutput playableOutput;
				IL2CPP.il2cpp_field_static_get_value(PlayableOutput.NativeFieldInfoPtr_m_NullPlayableOutput, (void*)(&playableOutput));
				return playableOutput;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayableOutput.NativeFieldInfoPtr_m_NullPlayableOutput, (void*)(&value));
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001A3E RID: 6718 RVA: 0x0005DDE4 File Offset: 0x0005BFE4
		public static PlayableOutput Null
		{
			get
			{
				return PlayableOutput.m_NullPlayableOutput;
			}
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x0005DDFC File Offset: 0x0005BFFC
		public bool IsPlayableOutputOfType<T>() where T : struct
		{
			return this.GetHandle().IsPlayableOutputOfType<T>();
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x0005DE1C File Offset: 0x0005C01C
		public Type GetPlayableOutputType()
		{
			return this.GetHandle().GetPlayableOutputType();
		}

		// Token: 0x0400130D RID: 4877
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x0400130E RID: 4878
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayableOutput;

		// Token: 0x0400130F RID: 4879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0;

		// Token: 0x04001310 RID: 4880
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0;

		// Token: 0x04001311 RID: 4881
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutput_0;

		// Token: 0x04001312 RID: 4882
		[FieldOffset(0)]
		public PlayableOutputHandle m_Handle;
	}
}
