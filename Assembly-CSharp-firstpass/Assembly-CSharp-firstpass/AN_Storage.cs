using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x020000EF RID: 239
public static class AN_Storage : global::Il2CppSystem.Object
{
	// Token: 0x060010F8 RID: 4344 RVA: 0x00052960 File Offset: 0x00050B60
	// Note: this type is marked as 'beforefieldinit'.
	static AN_Storage()
	{
		Il2CppClassPointerStore<AN_Storage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_Storage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_Storage>.NativeClassPtr);
		AN_Storage.NativeMethodInfoPtr_Save_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_Storage>.NativeClassPtr, 100665386);
		AN_Storage.NativeMethodInfoPtr_Save_Public_Static_Void_String_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_Storage>.NativeClassPtr, 100665387);
		AN_Storage.NativeMethodInfoPtr_Save_Public_Static_Void_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_Storage>.NativeClassPtr, 100665388);
		AN_Storage.NativeMethodInfoPtr_GetString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_Storage>.NativeClassPtr, 100665389);
		AN_Storage.NativeMethodInfoPtr_GetTexture_Public_Static_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_Storage>.NativeClassPtr, 100665390);
		AN_Storage.NativeMethodInfoPtr_GetData_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_Storage>.NativeClassPtr, 100665391);
		AN_Storage.NativeMethodInfoPtr_RemoveData_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_Storage>.NativeClassPtr, 100665392);
	}

	// Token: 0x060010F9 RID: 4345 RVA: 0x00052A1C File Offset: 0x00050C1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181472, XrefRangeEnd = 181479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Save(string key, string data)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_Storage.NativeMethodInfoPtr_Save_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060010FA RID: 4346 RVA: 0x00052A64 File Offset: 0x00050C64
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181479, XrefRangeEnd = 181485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Save(string key, Texture2D texture)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_Storage.NativeMethodInfoPtr_Save_Public_Static_Void_String_Texture2D_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060010FB RID: 4347 RVA: 0x00052AAC File Offset: 0x00050CAC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181485, XrefRangeEnd = 181490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Save(string key, Il2CppStructArray<byte> data)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_Storage.NativeMethodInfoPtr_Save_Public_Static_Void_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060010FC RID: 4348 RVA: 0x00052AF4 File Offset: 0x00050CF4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181490, XrefRangeEnd = 181494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetString(string key)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_Storage.NativeMethodInfoPtr_GetString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x060010FD RID: 4349 RVA: 0x00052B30 File Offset: 0x00050D30
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181494, XrefRangeEnd = 181506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D GetTexture(string key)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_Storage.NativeMethodInfoPtr_GetTexture_Public_Static_Texture2D_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}
	}

	// Token: 0x060010FE RID: 4350 RVA: 0x00052B74 File Offset: 0x00050D74
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181506, XrefRangeEnd = 181515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> GetData(string key)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_Storage.NativeMethodInfoPtr_GetData_Public_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}
	}

	// Token: 0x060010FF RID: 4351 RVA: 0x00052BB8 File Offset: 0x00050DB8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181515, XrefRangeEnd = 181517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveData(string key)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_Storage.NativeMethodInfoPtr_RemoveData_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001100 RID: 4352 RVA: 0x00008706 File Offset: 0x00006906
	public AN_Storage(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000D42 RID: 3394
	private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_String_String_0;

	// Token: 0x04000D43 RID: 3395
	private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_String_Texture2D_0;

	// Token: 0x04000D44 RID: 3396
	private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_String_Il2CppStructArray_1_Byte_0;

	// Token: 0x04000D45 RID: 3397
	private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_String_0;

	// Token: 0x04000D46 RID: 3398
	private static readonly IntPtr NativeMethodInfoPtr_GetTexture_Public_Static_Texture2D_String_0;

	// Token: 0x04000D47 RID: 3399
	private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Static_Il2CppStructArray_1_Byte_String_0;

	// Token: 0x04000D48 RID: 3400
	private static readonly IntPtr NativeMethodInfoPtr_RemoveData_Public_Static_Void_String_0;
}
