using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing.MiniJSON
{
	// Token: 0x02000006 RID: 6
	public static class MiniJsonExtensions : Object
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00002540 File Offset: 0x00000740
		// Note: this type is marked as 'beforefieldinit'.
		static MiniJsonExtensions()
		{
			Il2CppClassPointerStore<MiniJsonExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Purchasing.Common.dll", "UnityEngine.Purchasing.MiniJSON", "MiniJsonExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniJsonExtensions>.NativeClassPtr);
			MiniJsonExtensions.NativeMethodInfoPtr_GetString_Public_Static_String_Dictionary_2_String_Object_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJsonExtensions>.NativeClassPtr, 100663328);
			MiniJsonExtensions.NativeMethodInfoPtr_toJson_Public_Static_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJsonExtensions>.NativeClassPtr, 100663329);
			MiniJsonExtensions.NativeMethodInfoPtr_toJson_Public_Static_String_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJsonExtensions>.NativeClassPtr, 100663330);
			MiniJsonExtensions.NativeMethodInfoPtr_HashtableFromJson_Public_Static_Dictionary_2_String_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJsonExtensions>.NativeClassPtr, 100663331);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000025C0 File Offset: 0x000007C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89893, RefRangeEnd = 89894, XrefRangeStart = 89889, XrefRangeEnd = 89893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(this Dictionary<string, Object> dic, string key, string defaultValue = "")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dic);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiniJsonExtensions.NativeMethodInfoPtr_GetString_Public_Static_String_Dictionary_2_String_Object_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002620 File Offset: 0x00000820
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89895, RefRangeEnd = 89896, XrefRangeStart = 89894, XrefRangeEnd = 89895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string toJson(this Dictionary<string, Object> obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiniJsonExtensions.NativeMethodInfoPtr_toJson_Public_Static_String_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000265C File Offset: 0x0000085C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89895, RefRangeEnd = 89896, XrefRangeStart = 89895, XrefRangeEnd = 89896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string toJson(this Dictionary<string, string> obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiniJsonExtensions.NativeMethodInfoPtr_toJson_Public_Static_String_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002698 File Offset: 0x00000898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89899, RefRangeEnd = 89900, XrefRangeStart = 89896, XrefRangeEnd = 89899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, Object> HashtableFromJson(this string json)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiniJsonExtensions.NativeMethodInfoPtr_HashtableFromJson_Public_Static_Dictionary_2_String_Object_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000209B File Offset: 0x0000029B
		public MiniJsonExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_Dictionary_2_String_Object_String_String_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_toJson_Public_Static_String_Dictionary_2_String_Object_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_toJson_Public_Static_String_Dictionary_2_String_String_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_HashtableFromJson_Public_Static_Dictionary_2_String_Object_String_0;
	}
}
