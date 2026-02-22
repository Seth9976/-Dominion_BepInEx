using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000008 RID: 8
	public static class ListExtension : Object
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00006404 File Offset: 0x00004604
		// Note: this type is marked as 'beforefieldinit'.
		static ListExtension()
		{
			Il2CppClassPointerStore<ListExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "ListExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListExtension>.NativeClassPtr);
			ListExtension.NativeMethodInfoPtr_ToJava_Internal_Static_AndroidJavaObject_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListExtension>.NativeClassPtr, 100663320);
			ListExtension.NativeMethodInfoPtr_ToJavaArray_Private_Static_AndroidJavaObject_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListExtension>.NativeClassPtr, 100663321);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000645C File Offset: 0x0000465C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150194, XrefRangeEnd = 150195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AndroidJavaObject ToJava(this List<string> values)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListExtension.NativeMethodInfoPtr_ToJava_Internal_Static_AndroidJavaObject_List_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000064A0 File Offset: 0x000046A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150227, RefRangeEnd = 150229, XrefRangeStart = 150195, XrefRangeEnd = 150227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AndroidJavaObject ToJavaArray(List<string> values)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListExtension.NativeMethodInfoPtr_ToJavaArray_Private_Static_AndroidJavaObject_List_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002133 File Offset: 0x00000333
		public ListExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_ToJava_Internal_Static_AndroidJavaObject_List_1_String_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_ToJavaArray_Private_Static_AndroidJavaObject_List_1_String_0;
	}
}
