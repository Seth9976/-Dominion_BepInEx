using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x0200000F RID: 15
	[StructLayout(2)]
	public struct SafeGPtrArrayHandle
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00023ABC File Offset: 0x00021CBC
		// Note: this type is marked as 'beforefieldinit'.
		static SafeGPtrArrayHandle()
		{
			Il2CppClassPointerStore<SafeGPtrArrayHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "SafeGPtrArrayHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeGPtrArrayHandle>.NativeClassPtr);
			SafeGPtrArrayHandle.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeGPtrArrayHandle>.NativeClassPtr, "handle");
			SafeGPtrArrayHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeGPtrArrayHandle>.NativeClassPtr, 100663346);
			SafeGPtrArrayHandle.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeGPtrArrayHandle>.NativeClassPtr, 100663347);
			SafeGPtrArrayHandle.NativeMethodInfoPtr_get_Item_Internal_get_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeGPtrArrayHandle>.NativeClassPtr, 100663348);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00023B3C File Offset: 0x00021D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeGPtrArrayHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00023B64 File Offset: 0x00021D64
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeGPtrArrayHandle.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000B RID: 11
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeGPtrArrayHandle.NativeMethodInfoPtr_get_Item_Internal_get_IntPtr_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002137 File Offset: 0x00000337
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SafeGPtrArrayHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Internal_get_Int32_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_IntPtr_Int32_0;

		// Token: 0x04000057 RID: 87
		[FieldOffset(0)]
		public RuntimeGPtrArrayHandle handle;
	}
}
