using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Foundation.Time
{
	// Token: 0x0200001B RID: 27
	public static class SA_Rfc3339_Time : Object
	{
		// Token: 0x060000C7 RID: 199 RVA: 0x00006DCC File Offset: 0x00004FCC
		// Note: this type is marked as 'beforefieldinit'.
		static SA_Rfc3339_Time()
		{
			Il2CppClassPointerStore<SA_Rfc3339_Time>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Time", "SA_Rfc3339_Time");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Rfc3339_Time>.NativeClassPtr);
			SA_Rfc3339_Time.NativeFieldInfoPtr__rfc3339Formats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Rfc3339_Time>.NativeClassPtr, "_rfc3339Formats");
			SA_Rfc3339_Time.NativeFieldInfoPtr_Rfc3339Format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Rfc3339_Time>.NativeClassPtr, "Rfc3339Format");
			SA_Rfc3339_Time.NativeFieldInfoPtr_MinRfc339Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Rfc3339_Time>.NativeClassPtr, "MinRfc339Value");
			SA_Rfc3339_Time.NativeMethodInfoPtr_ToRfc3339_Public_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Rfc3339_Time>.NativeClassPtr, 100663435);
			SA_Rfc3339_Time.NativeMethodInfoPtr_TryParseRfc3339_Public_Static_Boolean_String_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Rfc3339_Time>.NativeClassPtr, 100663436);
			SA_Rfc3339_Time.NativeMethodInfoPtr_get_DateTimePatterns_Private_Static_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Rfc3339_Time>.NativeClassPtr, 100663437);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00006E74 File Offset: 0x00005074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99373, XrefRangeEnd = 99386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToRfc3339(DateTime dateTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Rfc3339_Time.NativeMethodInfoPtr_ToRfc3339_Public_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00006EAC File Offset: 0x000050AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99386, XrefRangeEnd = 99406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseRfc3339(string Rfc3339Time, out DateTime result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Rfc3339Time);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Rfc3339_Time.NativeMethodInfoPtr_TryParseRfc3339_Public_Static_Boolean_String_byref_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00006EFC File Offset: 0x000050FC
		public unsafe static Il2CppStringArray DateTimePatterns
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 99472, RefRangeEnd = 99473, XrefRangeStart = 99406, XrefRangeEnd = 99472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Rfc3339_Time.NativeMethodInfoPtr_get_DateTimePatterns_Private_Static_get_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002284 File Offset: 0x00000484
		public SA_Rfc3339_Time(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00006F30 File Offset: 0x00005130
		// (set) Token: 0x060000CD RID: 205 RVA: 0x0000228D File Offset: 0x0000048D
		public unsafe static Il2CppStringArray _rfc3339Formats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Rfc3339_Time.NativeFieldInfoPtr__rfc3339Formats, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Rfc3339_Time.NativeFieldInfoPtr__rfc3339Formats, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00006F58 File Offset: 0x00005158
		// (set) Token: 0x060000CF RID: 207 RVA: 0x0000229F File Offset: 0x0000049F
		public unsafe static string Rfc3339Format
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Rfc3339_Time.NativeFieldInfoPtr_Rfc3339Format, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Rfc3339_Time.NativeFieldInfoPtr_Rfc3339Format, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00006F78 File Offset: 0x00005178
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x000022B1 File Offset: 0x000004B1
		public unsafe static string MinRfc339Value
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Rfc3339_Time.NativeFieldInfoPtr_MinRfc339Value, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Rfc3339_Time.NativeFieldInfoPtr_MinRfc339Value, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr__rfc3339Formats;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_Rfc3339Format;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_MinRfc339Value;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_ToRfc3339_Public_Static_String_DateTime_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_TryParseRfc3339_Public_Static_Boolean_String_byref_DateTime_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTimePatterns_Private_Static_get_Il2CppStringArray_0;
	}
}
