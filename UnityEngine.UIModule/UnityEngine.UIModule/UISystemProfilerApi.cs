using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	public static class UISystemProfilerApi : Object
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x00004D4C File Offset: 0x00002F4C
		// Note: this type is marked as 'beforefieldinit'.
		static UISystemProfilerApi()
		{
			Il2CppClassPointerStore<UISystemProfilerApi>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIModule.dll", "UnityEngine", "UISystemProfilerApi");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISystemProfilerApi>.NativeClassPtr);
			UISystemProfilerApi.NativeMethodInfoPtr_BeginSample_Public_Static_Void_SampleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISystemProfilerApi>.NativeClassPtr, 100663398);
			UISystemProfilerApi.NativeMethodInfoPtr_EndSample_Public_Static_Void_SampleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISystemProfilerApi>.NativeClassPtr, 100663399);
			UISystemProfilerApi.NativeMethodInfoPtr_AddMarker_Public_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISystemProfilerApi>.NativeClassPtr, 100663400);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004DB8 File Offset: 0x00002FB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97960, RefRangeEnd = 97962, XrefRangeStart = 97958, XrefRangeEnd = 97960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginSample(UISystemProfilerApi.SampleType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISystemProfilerApi.NativeMethodInfoPtr_BeginSample_Public_Static_Void_SampleType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004DEC File Offset: 0x00002FEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98083, RefRangeEnd = 98085, XrefRangeStart = 97962, XrefRangeEnd = 98083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndSample(UISystemProfilerApi.SampleType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISystemProfilerApi.NativeMethodInfoPtr_EndSample_Public_Static_Void_SampleType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00004E20 File Offset: 0x00003020
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 98087, RefRangeEnd = 98103, XrefRangeStart = 98085, XrefRangeEnd = 98087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddMarker(string name, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISystemProfilerApi.NativeMethodInfoPtr_AddMarker_Public_Static_Void_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002309 File Offset: 0x00000509
		public UISystemProfilerApi(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_BeginSample_Public_Static_Void_SampleType_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_EndSample_Public_Static_Void_SampleType_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_AddMarker_Public_Static_Void_String_Object_0;

		// Token: 0x02000023 RID: 35
		public enum SampleType
		{
			// Token: 0x04000093 RID: 147
			Layout,
			// Token: 0x04000094 RID: 148
			Render
		}
	}
}
