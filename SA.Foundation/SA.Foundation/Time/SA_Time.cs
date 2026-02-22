using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace SA.Foundation.Time
{
	// Token: 0x0200001C RID: 28
	public static class SA_Time : Object
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x00006F98 File Offset: 0x00005198
		// Note: this type is marked as 'beforefieldinit'.
		static SA_Time()
		{
			Il2CppClassPointerStore<SA_Time>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Time", "SA_Time");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Time>.NativeClassPtr);
			SA_Time.NativeFieldInfoPtr_s_timers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Time>.NativeClassPtr, "s_timers");
			SA_Time.NativeMethodInfoPtr_StartTimer_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Time>.NativeClassPtr, 100663439);
			SA_Time.NativeMethodInfoPtr_GetTime_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Time>.NativeClassPtr, 100663440);
			SA_Time.NativeMethodInfoPtr_get_CurrentTimeUTC_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Time>.NativeClassPtr, 100663441);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00007018 File Offset: 0x00005218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99473, XrefRangeEnd = 99485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartTimer(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Time.NativeMethodInfoPtr_StartTimer_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00007050 File Offset: 0x00005250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99485, XrefRangeEnd = 99494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetTime(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Time.NativeMethodInfoPtr_GetTime_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00007094 File Offset: 0x00005294
		public unsafe static int CurrentTimeUTC
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99494, XrefRangeEnd = 99501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Time.NativeMethodInfoPtr_get_CurrentTimeUTC_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000022C3 File Offset: 0x000004C3
		public SA_Time(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000070C4 File Offset: 0x000052C4
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x000022CC File Offset: 0x000004CC
		public unsafe static Dictionary<string, long> s_timers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Time.NativeFieldInfoPtr_s_timers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, long>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Time.NativeFieldInfoPtr_s_timers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr_s_timers;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_StartTimer_Public_Static_Void_String_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_GetTime_Public_Static_Single_String_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTimeUTC_Public_Static_get_Int32_0;
	}
}
