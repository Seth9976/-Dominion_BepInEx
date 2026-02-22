using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text.RegularExpressions;

// Token: 0x02000003 RID: 3
public static class SA_Extensions_Uri : Object
{
	// Token: 0x0600000F RID: 15 RVA: 0x00003B54 File Offset: 0x00001D54
	// Note: this type is marked as 'beforefieldinit'.
	static SA_Extensions_Uri()
	{
		Il2CppClassPointerStore<SA_Extensions_Uri>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "", "SA_Extensions_Uri");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Extensions_Uri>.NativeClassPtr);
		SA_Extensions_Uri.NativeFieldInfoPtr__regex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Extensions_Uri>.NativeClassPtr, "_regex");
		SA_Extensions_Uri.NativeMethodInfoPtr_ParseQueryString_Public_Static_Dictionary_2_String_String_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Uri>.NativeClassPtr, 100663308);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00003BAC File Offset: 0x00001DAC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98158, XrefRangeEnd = 98180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<string, string> ParseQueryString(this Uri uri)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Uri.NativeMethodInfoPtr_ParseQueryString_Public_Static_Dictionary_2_String_String_Uri_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
		}
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002067 File Offset: 0x00000267
	public SA_Extensions_Uri(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000012 RID: 18 RVA: 0x00003BF0 File Offset: 0x00001DF0
	// (set) Token: 0x06000013 RID: 19 RVA: 0x00002070 File Offset: 0x00000270
	public unsafe static Regex _regex
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SA_Extensions_Uri.NativeFieldInfoPtr__regex, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SA_Extensions_Uri.NativeFieldInfoPtr__regex, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400000C RID: 12
	private static readonly IntPtr NativeFieldInfoPtr__regex;

	// Token: 0x0400000D RID: 13
	private static readonly IntPtr NativeMethodInfoPtr_ParseQueryString_Public_Static_Dictionary_2_String_String_Uri_0;
}
