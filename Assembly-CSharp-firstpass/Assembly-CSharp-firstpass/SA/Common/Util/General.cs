using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace SA.Common.Util
{
	// Token: 0x02000310 RID: 784
	public static class General : Object
	{
		// Token: 0x06002D38 RID: 11576 RVA: 0x000C0F58 File Offset: 0x000BF158
		// Note: this type is marked as 'beforefieldinit'.
		static General()
		{
			Il2CppClassPointerStore<General>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Common.Util", "General");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<General>.NativeClassPtr);
			General.NativeFieldInfoPtr__rfc3339Formats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<General>.NativeClassPtr, "_rfc3339Formats");
			General.NativeFieldInfoPtr_Rfc3339Format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<General>.NativeClassPtr, "Rfc3339Format");
			General.NativeFieldInfoPtr_MinRfc339Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<General>.NativeClassPtr, "MinRfc339Value");
			General.NativeMethodInfoPtr_Invoke_Public_Static_Void_Single_Action_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<General>.NativeClassPtr, 100669199);
			General.NativeMethodInfoPtr_ParseEnum_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<General>.NativeClassPtr, 100669200);
			General.NativeMethodInfoPtr_get_CurrentTimeStamp_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<General>.NativeClassPtr, 100669201);
			General.NativeMethodInfoPtr_DateTimeToRfc3339_Public_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<General>.NativeClassPtr, 100669202);
			General.NativeMethodInfoPtr_ConvertFromUnixTimestamp_Public_Static_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<General>.NativeClassPtr, 100669203);
			General.NativeMethodInfoPtr_ConvertToUnixTimestamp_Public_Static_Int64_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<General>.NativeClassPtr, 100669204);
			General.NativeMethodInfoPtr_get_DateTimePatterns_Public_Static_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<General>.NativeClassPtr, 100669205);
			General.NativeMethodInfoPtr_TryParseRfc3339_Public_Static_Boolean_String_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<General>.NativeClassPtr, 100669206);
			General.NativeMethodInfoPtr_HMAC_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<General>.NativeClassPtr, 100669207);
			General.NativeMethodInfoPtr_CleanupInstallation_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<General>.NativeClassPtr, 100669208);
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x000C108C File Offset: 0x000BF28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212106, XrefRangeEnd = 212109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Invoke(float time, Action callback, string name = "")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(General.NativeMethodInfoPtr_Invoke_Public_Static_Void_Single_Action_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x000C10E4 File Offset: 0x000BF2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212109, XrefRangeEnd = 212128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T ParseEnum<T>(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(General.MethodInfoStoreGeneric_ParseEnum_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06002D3B RID: 11579 RVA: 0x000C1124 File Offset: 0x000BF324
		public unsafe static int CurrentTimeStamp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212128, XrefRangeEnd = 212135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(General.NativeMethodInfoPtr_get_CurrentTimeStamp_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x000C1154 File Offset: 0x000BF354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212135, XrefRangeEnd = 212148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DateTimeToRfc3339(DateTime dateTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(General.NativeMethodInfoPtr_DateTimeToRfc3339_Public_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x000C118C File Offset: 0x000BF38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ConvertFromUnixTimestamp(long timestamp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timestamp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(General.NativeMethodInfoPtr_ConvertFromUnixTimestamp_Public_Static_DateTime_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D3E RID: 11582 RVA: 0x000C11CC File Offset: 0x000BF3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212148, XrefRangeEnd = 212155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ConvertToUnixTimestamp(DateTime date)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref date;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(General.NativeMethodInfoPtr_ConvertToUnixTimestamp_Public_Static_Int64_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06002D3F RID: 11583 RVA: 0x000C120C File Offset: 0x000BF40C
		public unsafe static Il2CppStringArray DateTimePatterns
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 212221, RefRangeEnd = 212222, XrefRangeStart = 212155, XrefRangeEnd = 212221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(General.NativeMethodInfoPtr_get_DateTimePatterns_Public_Static_get_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06002D40 RID: 11584 RVA: 0x000C1240 File Offset: 0x000BF440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212222, XrefRangeEnd = 212242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseRfc3339(string s, out DateTime result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(General.NativeMethodInfoPtr_TryParseRfc3339_Public_Static_Boolean_String_byref_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D41 RID: 11585 RVA: 0x000C1290 File Offset: 0x000BF490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212242, XrefRangeEnd = 212261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string HMAC(string key, string data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(General.NativeMethodInfoPtr_HMAC_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x000C12E0 File Offset: 0x000BF4E0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanupInstallation()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(General.NativeMethodInfoPtr_CleanupInstallation_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D43 RID: 11587 RVA: 0x00011903 File Offset: 0x0000FB03
		public General(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06002D44 RID: 11588 RVA: 0x000C1308 File Offset: 0x000BF508
		// (set) Token: 0x06002D45 RID: 11589 RVA: 0x0001190C File Offset: 0x0000FB0C
		public unsafe static Il2CppStringArray _rfc3339Formats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(General.NativeFieldInfoPtr__rfc3339Formats, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(General.NativeFieldInfoPtr__rfc3339Formats, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06002D46 RID: 11590 RVA: 0x000C1330 File Offset: 0x000BF530
		// (set) Token: 0x06002D47 RID: 11591 RVA: 0x0001191E File Offset: 0x0000FB1E
		public unsafe static string Rfc3339Format
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(General.NativeFieldInfoPtr_Rfc3339Format, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(General.NativeFieldInfoPtr_Rfc3339Format, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06002D48 RID: 11592 RVA: 0x000C1350 File Offset: 0x000BF550
		// (set) Token: 0x06002D49 RID: 11593 RVA: 0x00011930 File Offset: 0x0000FB30
		public unsafe static string MinRfc339Value
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(General.NativeFieldInfoPtr_MinRfc339Value, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(General.NativeFieldInfoPtr_MinRfc339Value, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002B3B RID: 11067
		private static readonly IntPtr NativeFieldInfoPtr__rfc3339Formats;

		// Token: 0x04002B3C RID: 11068
		private static readonly IntPtr NativeFieldInfoPtr_Rfc3339Format;

		// Token: 0x04002B3D RID: 11069
		private static readonly IntPtr NativeFieldInfoPtr_MinRfc339Value;

		// Token: 0x04002B3E RID: 11070
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_Single_Action_String_0;

		// Token: 0x04002B3F RID: 11071
		private static readonly IntPtr NativeMethodInfoPtr_ParseEnum_Public_Static_T_String_0;

		// Token: 0x04002B40 RID: 11072
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTimeStamp_Public_Static_get_Int32_0;

		// Token: 0x04002B41 RID: 11073
		private static readonly IntPtr NativeMethodInfoPtr_DateTimeToRfc3339_Public_Static_String_DateTime_0;

		// Token: 0x04002B42 RID: 11074
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFromUnixTimestamp_Public_Static_DateTime_Int64_0;

		// Token: 0x04002B43 RID: 11075
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToUnixTimestamp_Public_Static_Int64_DateTime_0;

		// Token: 0x04002B44 RID: 11076
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTimePatterns_Public_Static_get_Il2CppStringArray_0;

		// Token: 0x04002B45 RID: 11077
		private static readonly IntPtr NativeMethodInfoPtr_TryParseRfc3339_Public_Static_Boolean_String_byref_DateTime_0;

		// Token: 0x04002B46 RID: 11078
		private static readonly IntPtr NativeMethodInfoPtr_HMAC_Public_Static_String_String_String_0;

		// Token: 0x04002B47 RID: 11079
		private static readonly IntPtr NativeMethodInfoPtr_CleanupInstallation_Public_Static_Void_0;

		// Token: 0x020003CB RID: 971
		private sealed class MethodInfoStoreGeneric_ParseEnum_Public_Static_T_String_0<T>
		{
			// Token: 0x040032EC RID: 13036
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(General.NativeMethodInfoPtr_ParseEnum_Public_Static_T_String_0, Il2CppClassPointerStore<General>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
