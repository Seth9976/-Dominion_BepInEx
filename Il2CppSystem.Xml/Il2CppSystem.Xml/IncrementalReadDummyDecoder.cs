using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200001B RID: 27
	public class IncrementalReadDummyDecoder : IncrementalReadDecoder
	{
		// Token: 0x060000F5 RID: 245 RVA: 0x0000C6F8 File Offset: 0x0000A8F8
		// Note: this type is marked as 'beforefieldinit'.
		static IncrementalReadDummyDecoder()
		{
			Il2CppClassPointerStore<IncrementalReadDummyDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IncrementalReadDummyDecoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncrementalReadDummyDecoder>.NativeClassPtr);
			IncrementalReadDummyDecoder.NativeMethodInfoPtr_get_IsFull_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementalReadDummyDecoder>.NativeClassPtr, 100663427);
			IncrementalReadDummyDecoder.NativeMethodInfoPtr_Decode_Internal_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementalReadDummyDecoder>.NativeClassPtr, 100663428);
			IncrementalReadDummyDecoder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementalReadDummyDecoder>.NativeClassPtr, 100663429);
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000C764 File Offset: 0x0000A964
		public unsafe override bool IsFull
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncrementalReadDummyDecoder.NativeMethodInfoPtr_get_IsFull_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000C7AC File Offset: 0x0000A9AC
		[CallerCount(0)]
		public unsafe override int Decode(Il2CppStructArray<char> chars, int startPos, int len)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncrementalReadDummyDecoder.NativeMethodInfoPtr_Decode_Internal_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000C820 File Offset: 0x0000AA20
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IncrementalReadDummyDecoder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncrementalReadDummyDecoder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementalReadDummyDecoder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002506 File Offset: 0x00000706
		public IncrementalReadDummyDecoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFull_Internal_Virtual_get_Boolean_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Internal_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
