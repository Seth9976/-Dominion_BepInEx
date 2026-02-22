using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

// Token: 0x0200000C RID: 12
public static class SA_Extensions_Vector3 : global::Il2CppSystem.Object
{
	// Token: 0x06000045 RID: 69 RVA: 0x00004AD0 File Offset: 0x00002CD0
	// Note: this type is marked as 'beforefieldinit'.
	static SA_Extensions_Vector3()
	{
		Il2CppClassPointerStore<SA_Extensions_Vector3>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "", "SA_Extensions_Vector3");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Extensions_Vector3>.NativeClassPtr);
		SA_Extensions_Vector3.NativeMethodInfoPtr_Reset_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Vector3>.NativeClassPtr, 100663343);
		SA_Extensions_Vector3.NativeMethodInfoPtr_ResetXCoord_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Vector3>.NativeClassPtr, 100663344);
		SA_Extensions_Vector3.NativeMethodInfoPtr_ResetYCoord_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Vector3>.NativeClassPtr, 100663345);
		SA_Extensions_Vector3.NativeMethodInfoPtr_ResetZCoord_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Vector3>.NativeClassPtr, 100663346);
		SA_Extensions_Vector3.NativeMethodInfoPtr_Average_Public_Static_Vector3_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Vector3>.NativeClassPtr, 100663347);
		SA_Extensions_Vector3.NativeMethodInfoPtr_Add_Public_Static_Void_Il2CppStructArray_1_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Vector3>.NativeClassPtr, 100663348);
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00004B78 File Offset: 0x00002D78
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98457, XrefRangeEnd = 98458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 Reset(this Vector3 vec)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref vec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Vector3.NativeMethodInfoPtr_Reset_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00004BB8 File Offset: 0x00002DB8
	[CallerCount(0)]
	public unsafe static Vector3 ResetXCoord(this Vector3 vec)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref vec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Vector3.NativeMethodInfoPtr_ResetXCoord_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00004BF8 File Offset: 0x00002DF8
	[CallerCount(0)]
	public unsafe static Vector3 ResetYCoord(this Vector3 vec)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref vec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Vector3.NativeMethodInfoPtr_ResetYCoord_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00004C38 File Offset: 0x00002E38
	[CallerCount(0)]
	public unsafe static Vector3 ResetZCoord(this Vector3 vec)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref vec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Vector3.NativeMethodInfoPtr_ResetZCoord_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00004C78 File Offset: 0x00002E78
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98458, XrefRangeEnd = 98462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 Average(this Il2CppStructArray<Vector3> f)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Vector3.NativeMethodInfoPtr_Average_Public_Static_Vector3_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00004CBC File Offset: 0x00002EBC
	[CallerCount(0)]
	public unsafe static void Add(this Il2CppStructArray<Vector3> v3, Vector3 value)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(v3);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Vector3.NativeMethodInfoPtr_Add_Public_Static_Void_Il2CppStructArray_1_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00002175 File Offset: 0x00000375
	public SA_Extensions_Vector3(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0400002F RID: 47
	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Static_Vector3_Vector3_0;

	// Token: 0x04000030 RID: 48
	private static readonly IntPtr NativeMethodInfoPtr_ResetXCoord_Public_Static_Vector3_Vector3_0;

	// Token: 0x04000031 RID: 49
	private static readonly IntPtr NativeMethodInfoPtr_ResetYCoord_Public_Static_Vector3_Vector3_0;

	// Token: 0x04000032 RID: 50
	private static readonly IntPtr NativeMethodInfoPtr_ResetZCoord_Public_Static_Vector3_Vector3_0;

	// Token: 0x04000033 RID: 51
	private static readonly IntPtr NativeMethodInfoPtr_Average_Public_Static_Vector3_Il2CppStructArray_1_Vector3_0;

	// Token: 0x04000034 RID: 52
	private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Void_Il2CppStructArray_1_Vector3_Vector3_0;
}
