using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200001A RID: 26
	public class IncrementalReadDecoder : Object
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x0000C594 File Offset: 0x0000A794
		// Note: this type is marked as 'beforefieldinit'.
		static IncrementalReadDecoder()
		{
			Il2CppClassPointerStore<IncrementalReadDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IncrementalReadDecoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncrementalReadDecoder>.NativeClassPtr);
			IncrementalReadDecoder.NativeMethodInfoPtr_get_IsFull_Internal_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementalReadDecoder>.NativeClassPtr, 100663424);
			IncrementalReadDecoder.NativeMethodInfoPtr_Decode_Internal_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementalReadDecoder>.NativeClassPtr, 100663425);
			IncrementalReadDecoder.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementalReadDecoder>.NativeClassPtr, 100663426);
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000C600 File Offset: 0x0000A800
		public unsafe virtual bool IsFull
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncrementalReadDecoder.NativeMethodInfoPtr_get_IsFull_Internal_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000C648 File Offset: 0x0000A848
		[CallerCount(0)]
		public unsafe virtual int Decode(Il2CppStructArray<char> chars, int startPos, int len)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncrementalReadDecoder.NativeMethodInfoPtr_Decode_Internal_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000C6BC File Offset: 0x0000A8BC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IncrementalReadDecoder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncrementalReadDecoder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementalReadDecoder.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000024FD File Offset: 0x000006FD
		public IncrementalReadDecoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFull_Internal_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Internal_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
