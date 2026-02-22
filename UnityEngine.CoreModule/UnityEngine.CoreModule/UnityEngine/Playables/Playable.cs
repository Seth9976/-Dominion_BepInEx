using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x0200014C RID: 332
	[StructLayout(2)]
	public struct Playable
	{
		// Token: 0x06001951 RID: 6481 RVA: 0x0005C5C0 File Offset: 0x0005A7C0
		// Note: this type is marked as 'beforefieldinit'.
		static Playable()
		{
			Il2CppClassPointerStore<Playable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "Playable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Playable>.NativeClassPtr);
			Playable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Playable>.NativeClassPtr, "m_Handle");
			Playable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Playable>.NativeClassPtr, "m_NullPlayable");
			Playable.NativeMethodInfoPtr_get_Null_Public_Static_get_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Playable>.NativeClassPtr, 100665184);
			Playable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Playable>.NativeClassPtr, 100665185);
			Playable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Playable>.NativeClassPtr, 100665186);
			Playable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Playable>.NativeClassPtr, 100665187);
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x0005C668 File Offset: 0x0005A868
		public unsafe static Playable Null
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82677, XrefRangeEnd = 82681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Playable.NativeMethodInfoPtr_get_Null_Public_Static_get_Playable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x0005C698 File Offset: 0x0005A898
		[CallerCount(0)]
		public unsafe Playable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Playable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x0005C6CC File Offset: 0x0005A8CC
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Playable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x0005C6FC File Offset: 0x0005A8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82681, XrefRangeEnd = 82689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Playable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Playable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Playable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x0000E1D7 File Offset: 0x0000C3D7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Playable>.NativeClassPtr, ref this));
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001957 RID: 6487 RVA: 0x0005C73C File Offset: 0x0005A93C
		// (set) Token: 0x06001958 RID: 6488 RVA: 0x0000E1E9 File Offset: 0x0000C3E9
		public unsafe static Playable m_NullPlayable
		{
			get
			{
				Playable playable;
				IL2CPP.il2cpp_field_static_get_value(Playable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&playable));
				return playable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Playable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x0005C758 File Offset: 0x0005A958
		public static Playable Create(PlayableGraph graph, [Optional] int inputCount)
		{
			Playable playable = new Playable(graph.CreatePlayableHandle());
			PlayableExtensions.SetInputCount<Playable>(playable, inputCount);
			return playable;
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x0005C784 File Offset: 0x0005A984
		public bool IsPlayableOfType<T>() where T : struct
		{
			return this.GetHandle().IsPlayableOfType<T>();
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x0005C7A4 File Offset: 0x0005A9A4
		public Type GetPlayableType()
		{
			return this.GetHandle().GetPlayableType();
		}

		// Token: 0x04001299 RID: 4761
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x0400129A RID: 4762
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x0400129B RID: 4763
		private static readonly IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_Playable_0;

		// Token: 0x0400129C RID: 4764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x0400129D RID: 4765
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x0400129E RID: 4766
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Playable_0;

		// Token: 0x0400129F RID: 4767
		[FieldOffset(0)]
		public PlayableHandle m_Handle;
	}
}
