using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace SA.AndroidNative.Firebase
{
	// Token: 0x02000352 RID: 850
	public static class Analytics : Object
	{
		// Token: 0x06003346 RID: 13126 RVA: 0x000D5978 File Offset: 0x000D3B78
		// Note: this type is marked as 'beforefieldinit'.
		static Analytics()
		{
			Il2CppClassPointerStore<Analytics>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.AndroidNative.Firebase", "Analytics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Analytics>.NativeClassPtr);
			Analytics.NativeFieldInfoPtr_SEPARATOR1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Analytics>.NativeClassPtr, "SEPARATOR1");
			Analytics.NativeFieldInfoPtr_SEPARATOR2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Analytics>.NativeClassPtr, "SEPARATOR2");
			Analytics.NativeMethodInfoPtr_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Analytics>.NativeClassPtr, 100669866);
			Analytics.NativeMethodInfoPtr_SetEnabled_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Analytics>.NativeClassPtr, 100669867);
			Analytics.NativeMethodInfoPtr_SetMinimumSessionDuration_Public_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Analytics>.NativeClassPtr, 100669868);
			Analytics.NativeMethodInfoPtr_SetSessionTimeoutDuration_Public_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Analytics>.NativeClassPtr, 100669869);
			Analytics.NativeMethodInfoPtr_SetUserId_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Analytics>.NativeClassPtr, 100669870);
			Analytics.NativeMethodInfoPtr_SetUserProperty_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Analytics>.NativeClassPtr, 100669871);
			Analytics.NativeMethodInfoPtr_LogEvent_Public_Static_Void_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Analytics>.NativeClassPtr, 100669872);
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x000D5A5C File Offset: 0x000D3C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223598, XrefRangeEnd = 223599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Analytics.NativeMethodInfoPtr_Init_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x000D5A84 File Offset: 0x000D3C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223599, XrefRangeEnd = 223600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetEnabled(bool enabled)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Analytics.NativeMethodInfoPtr_SetEnabled_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x000D5AB8 File Offset: 0x000D3CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223600, XrefRangeEnd = 223601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMinimumSessionDuration(long milliseconds)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref milliseconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Analytics.NativeMethodInfoPtr_SetMinimumSessionDuration_Public_Static_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x000D5AEC File Offset: 0x000D3CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223601, XrefRangeEnd = 223602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSessionTimeoutDuration(long milliseconds)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref milliseconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Analytics.NativeMethodInfoPtr_SetSessionTimeoutDuration_Public_Static_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x000D5B20 File Offset: 0x000D3D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223602, XrefRangeEnd = 223603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetUserId(string userId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(userId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Analytics.NativeMethodInfoPtr_SetUserId_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x000D5B58 File Offset: 0x000D3D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223603, XrefRangeEnd = 223604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetUserProperty(string name, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Analytics.NativeMethodInfoPtr_SetUserProperty_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x000D5BA0 File Offset: 0x000D3DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223604, XrefRangeEnd = 223638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogEvent(string name, Dictionary<string, Object> data = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Analytics.NativeMethodInfoPtr_LogEvent_Public_Static_Void_String_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x00013F04 File Offset: 0x00012104
		public Analytics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x0600334F RID: 13135 RVA: 0x000D5BE8 File Offset: 0x000D3DE8
		// (set) Token: 0x06003350 RID: 13136 RVA: 0x00013F0D File Offset: 0x0001210D
		public unsafe static string SEPARATOR1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Analytics.NativeFieldInfoPtr_SEPARATOR1, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Analytics.NativeFieldInfoPtr_SEPARATOR1, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06003351 RID: 13137 RVA: 0x000D5C08 File Offset: 0x000D3E08
		// (set) Token: 0x06003352 RID: 13138 RVA: 0x00013F1F File Offset: 0x0001211F
		public unsafe static string SEPARATOR2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Analytics.NativeFieldInfoPtr_SEPARATOR2, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Analytics.NativeFieldInfoPtr_SEPARATOR2, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002FBC RID: 12220
		private static readonly IntPtr NativeFieldInfoPtr_SEPARATOR1;

		// Token: 0x04002FBD RID: 12221
		private static readonly IntPtr NativeFieldInfoPtr_SEPARATOR2;

		// Token: 0x04002FBE RID: 12222
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_0;

		// Token: 0x04002FBF RID: 12223
		private static readonly IntPtr NativeMethodInfoPtr_SetEnabled_Public_Static_Void_Boolean_0;

		// Token: 0x04002FC0 RID: 12224
		private static readonly IntPtr NativeMethodInfoPtr_SetMinimumSessionDuration_Public_Static_Void_Int64_0;

		// Token: 0x04002FC1 RID: 12225
		private static readonly IntPtr NativeMethodInfoPtr_SetSessionTimeoutDuration_Public_Static_Void_Int64_0;

		// Token: 0x04002FC2 RID: 12226
		private static readonly IntPtr NativeMethodInfoPtr_SetUserId_Public_Static_Void_String_0;

		// Token: 0x04002FC3 RID: 12227
		private static readonly IntPtr NativeMethodInfoPtr_SetUserProperty_Public_Static_Void_String_String_0;

		// Token: 0x04002FC4 RID: 12228
		private static readonly IntPtr NativeMethodInfoPtr_LogEvent_Public_Static_Void_String_Dictionary_2_String_Object_0;
	}
}
