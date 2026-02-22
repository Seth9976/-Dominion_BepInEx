using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x0200000B RID: 11
	[StructLayout(2)]
	public struct RuntimeGPtrArrayHandle
	{
		// Token: 0x06000036 RID: 54 RVA: 0x000235A0 File Offset: 0x000217A0
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeGPtrArrayHandle()
		{
			Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "RuntimeGPtrArrayHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr);
			RuntimeGPtrArrayHandle.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr, "value");
			RuntimeGPtrArrayHandle.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr, 100663334);
			RuntimeGPtrArrayHandle.NativeMethodInfoPtr_get_Item_Internal_get_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr, 100663335);
			RuntimeGPtrArrayHandle.NativeMethodInfoPtr_Lookup_Internal_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr, 100663336);
			RuntimeGPtrArrayHandle.NativeMethodInfoPtr_GPtrArrayFree_Private_Static_Void_ptr_GPtrArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr, 100663337);
			RuntimeGPtrArrayHandle.NativeMethodInfoPtr_DestroyAndFree_Internal_Static_Void_byref_RuntimeGPtrArrayHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr, 100663338);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00023648 File Offset: 0x00021848
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeGPtrArrayHandle.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000009 RID: 9
		public unsafe IntPtr this[int i]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeGPtrArrayHandle.NativeMethodInfoPtr_get_Item_Internal_get_IntPtr_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000236B8 File Offset: 0x000218B8
		[CallerCount(0)]
		public unsafe IntPtr Lookup(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeGPtrArrayHandle.NativeMethodInfoPtr_Lookup_Internal_IntPtr_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000236F8 File Offset: 0x000218F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258414, XrefRangeEnd = 258415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GPtrArrayFree(RuntimeStructs.GPtrArray* value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeGPtrArrayHandle.NativeMethodInfoPtr_GPtrArrayFree_Private_Static_Void_ptr_GPtrArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0002372C File Offset: 0x0002192C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258415, XrefRangeEnd = 258416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyAndFree(ref RuntimeGPtrArrayHandle h)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &h;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeGPtrArrayHandle.NativeMethodInfoPtr_DestroyAndFree_Internal_Static_Void_byref_RuntimeGPtrArrayHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000020DC File Offset: 0x000002DC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Internal_get_Int32_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_IntPtr_Int32_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_Lookup_Internal_IntPtr_Int32_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_GPtrArrayFree_Private_Static_Void_ptr_GPtrArray_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_DestroyAndFree_Internal_Static_Void_byref_RuntimeGPtrArrayHandle_0;

		// Token: 0x04000032 RID: 50
		[FieldOffset(0)]
		public IntPtr value;
	}
}
