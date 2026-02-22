using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x0200000A RID: 10
public static class SA_Extensions_Texture2D : global::Il2CppSystem.Object
{
	// Token: 0x06000036 RID: 54 RVA: 0x0000465C File Offset: 0x0000285C
	// Note: this type is marked as 'beforefieldinit'.
	static SA_Extensions_Texture2D()
	{
		Il2CppClassPointerStore<SA_Extensions_Texture2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "", "SA_Extensions_Texture2D");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Extensions_Texture2D>.NativeClassPtr);
		SA_Extensions_Texture2D.NativeMethodInfoPtr_Rotate_Public_Static_Texture2D_Texture2D_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Texture2D>.NativeClassPtr, 100663332);
		SA_Extensions_Texture2D.NativeMethodInfoPtr_ToSprite_Public_Static_Sprite_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Texture2D>.NativeClassPtr, 100663333);
		SA_Extensions_Texture2D.NativeMethodInfoPtr_ToBytesArray_Public_Static_Il2CppStructArray_1_Byte_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Texture2D>.NativeClassPtr, 100663334);
		SA_Extensions_Texture2D.NativeMethodInfoPtr_ToBase64String_Public_Static_String_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Texture2D>.NativeClassPtr, 100663335);
		SA_Extensions_Texture2D.NativeMethodInfoPtr_LoadImageFromBase64_Public_Static_Texture2D_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Texture2D>.NativeClassPtr, 100663336);
	}

	// Token: 0x06000037 RID: 55 RVA: 0x000046F0 File Offset: 0x000028F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98383, XrefRangeEnd = 98387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D Rotate(this Texture2D texture, float angle)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Texture2D.NativeMethodInfoPtr_Rotate_Public_Static_Texture2D_Texture2D_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00004744 File Offset: 0x00002944
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98387, XrefRangeEnd = 98389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite ToSprite(this Texture2D texture)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Texture2D.NativeMethodInfoPtr_ToSprite_Public_Static_Sprite_Texture2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00004788 File Offset: 0x00002988
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98389, XrefRangeEnd = 98390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> ToBytesArray(this Texture2D texture)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Texture2D.NativeMethodInfoPtr_ToBytesArray_Public_Static_Il2CppStructArray_1_Byte_Texture2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}
	}

	// Token: 0x0600003A RID: 58 RVA: 0x000047CC File Offset: 0x000029CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98390, XrefRangeEnd = 98395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToBase64String(this Texture2D texture)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Texture2D.NativeMethodInfoPtr_ToBase64String_Public_Static_String_Texture2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00004808 File Offset: 0x00002A08
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98395, XrefRangeEnd = 98400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D LoadImageFromBase64(this Texture2D texture, string base64EncodedStrong)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(base64EncodedStrong);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Texture2D.NativeMethodInfoPtr_LoadImageFromBase64_Public_Static_Texture2D_Texture2D_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002163 File Offset: 0x00000363
	public SA_Extensions_Texture2D(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000024 RID: 36
	private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Static_Texture2D_Texture2D_Single_0;

	// Token: 0x04000025 RID: 37
	private static readonly IntPtr NativeMethodInfoPtr_ToSprite_Public_Static_Sprite_Texture2D_0;

	// Token: 0x04000026 RID: 38
	private static readonly IntPtr NativeMethodInfoPtr_ToBytesArray_Public_Static_Il2CppStructArray_1_Byte_Texture2D_0;

	// Token: 0x04000027 RID: 39
	private static readonly IntPtr NativeMethodInfoPtr_ToBase64String_Public_Static_String_Texture2D_0;

	// Token: 0x04000028 RID: 40
	private static readonly IntPtr NativeMethodInfoPtr_LoadImageFromBase64_Public_Static_Texture2D_Texture2D_String_0;
}
