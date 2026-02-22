using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

namespace Unity.Profiling
{
	// Token: 0x02000009 RID: 9
	[StructLayout(2)]
	public struct ProfilerMarker
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00017C08 File Offset: 0x00015E08
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilerMarker()
		{
			Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", "ProfilerMarker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr);
			ProfilerMarker.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, "m_Ptr");
			ProfilerMarker.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, 100663305);
			ProfilerMarker.NativeMethodInfoPtr_Auto_Public_AutoScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, 100663306);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00017C74 File Offset: 0x00015E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58955, XrefRangeEnd = 58957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilerMarker(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerMarker.NativeMethodInfoPtr__ctor_Public_Void_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00017CAC File Offset: 0x00015EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58957, XrefRangeEnd = 58959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilerMarker.AutoScope Auto()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerMarker.NativeMethodInfoPtr_Auto_Public_AutoScope_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000021BC File Offset: 0x000003BC
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, ref this));
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000021CE File Offset: 0x000003CE
		public IntPtr Handle
		{
			get
			{
				return this.m_Ptr;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000021D6 File Offset: 0x000003D6
		public void Begin()
		{
			Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.BeginSample(this.m_Ptr);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000021E5 File Offset: 0x000003E5
		public void Begin(global::UnityEngine.Object contextUnityObject)
		{
			Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.Internal_BeginWithObject(this.m_Ptr, contextUnityObject);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000021F5 File Offset: 0x000003F5
		public void End()
		{
			Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.EndSample(this.m_Ptr);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002204 File Offset: 0x00000404
		public void GetName(ref string name)
		{
			name = Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.Internal_GetName(this.m_Ptr);
		}

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_Auto_Public_AutoScope_0;

		// Token: 0x04000014 RID: 20
		[NonSerialized]
		[FieldOffset(0)]
		public readonly IntPtr m_Ptr;

		// Token: 0x020002DF RID: 735
		[StructLayout(2)]
		public struct AutoScope
		{
			// Token: 0x0600236E RID: 9070 RVA: 0x0006ADAC File Offset: 0x00068FAC
			// Note: this type is marked as 'beforefieldinit'.
			static AutoScope()
			{
				Il2CppClassPointerStore<ProfilerMarker.AutoScope>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, "AutoScope");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerMarker.AutoScope>.NativeClassPtr);
				ProfilerMarker.AutoScope.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerMarker.AutoScope>.NativeClassPtr, "m_Ptr");
				ProfilerMarker.AutoScope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerMarker.AutoScope>.NativeClassPtr, 100663308);
			}

			// Token: 0x0600236F RID: 9071 RVA: 0x0006AE00 File Offset: 0x00069000
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58953, XrefRangeEnd = 58955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerMarker.AutoScope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002370 RID: 9072 RVA: 0x00014F97 File Offset: 0x00013197
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerMarker.AutoScope>.NativeClassPtr, ref this));
			}

			// Token: 0x04001C13 RID: 7187
			private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

			// Token: 0x04001C14 RID: 7188
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04001C15 RID: 7189
			[FieldOffset(0)]
			public readonly IntPtr m_Ptr;
		}
	}
}
