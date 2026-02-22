using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000002 RID: 2
public static class SA_Extensions_String : Object
{
	// Token: 0x06000001 RID: 1 RVA: 0x00003714 File Offset: 0x00001914
	// Note: this type is marked as 'beforefieldinit'.
	static SA_Extensions_String()
	{
		Il2CppClassPointerStore<SA_Extensions_String>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "", "SA_Extensions_String");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Extensions_String>.NativeClassPtr);
		SA_Extensions_String.NativeMethodInfoPtr_GetLast_Public_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_String>.NativeClassPtr, 100663297);
		SA_Extensions_String.NativeMethodInfoPtr_RemoveLast_Public_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_String>.NativeClassPtr, 100663298);
		SA_Extensions_String.NativeMethodInfoPtr_GetFirst_Public_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_String>.NativeClassPtr, 100663299);
		SA_Extensions_String.NativeMethodInfoPtr_AllIndexesOf_Public_Static_List_1_Int32_String_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_String>.NativeClassPtr, 100663300);
		SA_Extensions_String.NativeMethodInfoPtr_CopyToClipboard_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_String>.NativeClassPtr, 100663301);
		SA_Extensions_String.NativeMethodInfoPtr_CovertToURI_Public_Static_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_String>.NativeClassPtr, 100663302);
		SA_Extensions_String.NativeMethodInfoPtr_UppercaseFirst_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_String>.NativeClassPtr, 100663303);
		SA_Extensions_String.NativeMethodInfoPtr_SafeStringFormat_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_String>.NativeClassPtr, 100663304);
		SA_Extensions_String.NativeMethodInfoPtr_ToBytes_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_String>.NativeClassPtr, 100663305);
		SA_Extensions_String.NativeMethodInfoPtr_FromBytes_Public_Static_String_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_String>.NativeClassPtr, 100663306);
		SA_Extensions_String.NativeMethodInfoPtr_BytesFromBase64String_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_String>.NativeClassPtr, 100663307);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00003820 File Offset: 0x00001A20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98103, XrefRangeEnd = 98104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLast(this string source, int count)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_String.NativeMethodInfoPtr_GetLast_Public_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x0000386C File Offset: 0x00001A6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98104, XrefRangeEnd = 98107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string RemoveLast(this string source, int count)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_String.NativeMethodInfoPtr_RemoveLast_Public_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000004 RID: 4 RVA: 0x000038B8 File Offset: 0x00001AB8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98107, XrefRangeEnd = 98108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetFirst(this string source, int count)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_String.NativeMethodInfoPtr_GetFirst_Public_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00003904 File Offset: 0x00001B04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98108, XrefRangeEnd = 98120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<int> AllIndexesOf(this string str, string value, StringComparison comparisonType)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_String.NativeMethodInfoPtr_AllIndexesOf_Public_Static_List_1_Int32_String_String_StringComparison_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00003968 File Offset: 0x00001B68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98120, XrefRangeEnd = 98128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyToClipboard(this string source)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_String.NativeMethodInfoPtr_CopyToClipboard_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000039A0 File Offset: 0x00001BA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98128, XrefRangeEnd = 98132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Uri CovertToURI(this string source)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_String.NativeMethodInfoPtr_CovertToURI_Public_Static_Uri_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
		}
	}

	// Token: 0x06000008 RID: 8 RVA: 0x000039E4 File Offset: 0x00001BE4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98132, XrefRangeEnd = 98141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string UppercaseFirst(this string source)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_String.NativeMethodInfoPtr_UppercaseFirst_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00003A20 File Offset: 0x00001C20
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 98149, RefRangeEnd = 98150, XrefRangeStart = 98141, XrefRangeEnd = 98149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string SafeStringFormat(this string source, [Optional] Il2CppReferenceArray<Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Object>(0L);
		}
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_String.NativeMethodInfoPtr_SafeStringFormat_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00003A7C File Offset: 0x00001C7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98150, XrefRangeEnd = 98152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> ToBytes(this string source)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_String.NativeMethodInfoPtr_ToBytes_Public_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00003AC0 File Offset: 0x00001CC0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98152, XrefRangeEnd = 98154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FromBytes(this string source, Il2CppStructArray<byte> data)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_String.NativeMethodInfoPtr_FromBytes_Public_Static_String_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00003B10 File Offset: 0x00001D10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98154, XrefRangeEnd = 98158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> BytesFromBase64String(this string source)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_String.NativeMethodInfoPtr_BytesFromBase64String_Public_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
	public static string SafeStringFormat(string source, params Object[] args)
	{
		return source.SafeStringFormat(new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x0600000E RID: 14 RVA: 0x0000205E File Offset: 0x0000025E
	public SA_Extensions_String(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000001 RID: 1
	private static readonly IntPtr NativeMethodInfoPtr_GetLast_Public_Static_String_String_Int32_0;

	// Token: 0x04000002 RID: 2
	private static readonly IntPtr NativeMethodInfoPtr_RemoveLast_Public_Static_String_String_Int32_0;

	// Token: 0x04000003 RID: 3
	private static readonly IntPtr NativeMethodInfoPtr_GetFirst_Public_Static_String_String_Int32_0;

	// Token: 0x04000004 RID: 4
	private static readonly IntPtr NativeMethodInfoPtr_AllIndexesOf_Public_Static_List_1_Int32_String_String_StringComparison_0;

	// Token: 0x04000005 RID: 5
	private static readonly IntPtr NativeMethodInfoPtr_CopyToClipboard_Public_Static_Void_String_0;

	// Token: 0x04000006 RID: 6
	private static readonly IntPtr NativeMethodInfoPtr_CovertToURI_Public_Static_Uri_String_0;

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeMethodInfoPtr_UppercaseFirst_Public_Static_String_String_0;

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeMethodInfoPtr_SafeStringFormat_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000009 RID: 9
	private static readonly IntPtr NativeMethodInfoPtr_ToBytes_Public_Static_Il2CppStructArray_1_Byte_String_0;

	// Token: 0x0400000A RID: 10
	private static readonly IntPtr NativeMethodInfoPtr_FromBytes_Public_Static_String_String_Il2CppStructArray_1_Byte_0;

	// Token: 0x0400000B RID: 11
	private static readonly IntPtr NativeMethodInfoPtr_BytesFromBase64String_Public_Static_Il2CppStructArray_1_Byte_String_0;
}
