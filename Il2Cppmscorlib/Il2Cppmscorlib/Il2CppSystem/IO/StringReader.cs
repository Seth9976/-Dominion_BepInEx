using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.IO
{
	// Token: 0x0200020D RID: 525
	[Serializable]
	public class StringReader : TextReader
	{
		// Token: 0x06002208 RID: 8712 RVA: 0x000BB1D0 File Offset: 0x000B93D0
		// Note: this type is marked as 'beforefieldinit'.
		static StringReader()
		{
			Il2CppClassPointerStore<StringReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "StringReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringReader>.NativeClassPtr);
			StringReader.NativeFieldInfoPtr__s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReader>.NativeClassPtr, "_s");
			StringReader.NativeFieldInfoPtr__pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReader>.NativeClassPtr, "_pos");
			StringReader.NativeFieldInfoPtr__length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReader>.NativeClassPtr, "_length");
			StringReader.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringReader>.NativeClassPtr, 100668970);
			StringReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringReader>.NativeClassPtr, 100668971);
			StringReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringReader>.NativeClassPtr, 100668972);
			StringReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringReader>.NativeClassPtr, 100668973);
			StringReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringReader>.NativeClassPtr, 100668974);
			StringReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringReader>.NativeClassPtr, 100668975);
			StringReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringReader>.NativeClassPtr, 100668976);
			StringReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringReader>.NativeClassPtr, 100668977);
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x000BB2DC File Offset: 0x000B94DC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 322063, RefRangeEnd = 322074, XrefRangeStart = 322059, XrefRangeEnd = 322063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringReader(string s)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringReader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringReader.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x000BB328 File Offset: 0x000B9528
		[CallerCount(0)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x000BB364 File Offset: 0x000B9564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322074, XrefRangeEnd = 322075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x000BB3B0 File Offset: 0x000B95B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322075, XrefRangeEnd = 322077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x000BB3F8 File Offset: 0x000B95F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322077, XrefRangeEnd = 322079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x000BB440 File Offset: 0x000B9640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322079, XrefRangeEnd = 322081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read([In] [Out] Il2CppStructArray<char> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*buffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<char>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x000BB4C8 File Offset: 0x000B96C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322081, XrefRangeEnd = 322083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadToEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x000BB50C File Offset: 0x000B970C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322083, XrefRangeEnd = 322090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x0000B8D0 File Offset: 0x00009AD0
		public StringReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06002212 RID: 8722 RVA: 0x000BB550 File Offset: 0x000B9750
		// (set) Token: 0x06002213 RID: 8723 RVA: 0x0000B8D9 File Offset: 0x00009AD9
		public unsafe string _s
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringReader.NativeFieldInfoPtr__s);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringReader.NativeFieldInfoPtr__s), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06002214 RID: 8724 RVA: 0x000BB578 File Offset: 0x000B9778
		// (set) Token: 0x06002215 RID: 8725 RVA: 0x0000B8F8 File Offset: 0x00009AF8
		public unsafe int _pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringReader.NativeFieldInfoPtr__pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringReader.NativeFieldInfoPtr__pos)) = value;
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x000BB5A0 File Offset: 0x000B97A0
		// (set) Token: 0x06002217 RID: 8727 RVA: 0x0000B913 File Offset: 0x00009B13
		public unsafe int _length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringReader.NativeFieldInfoPtr__length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringReader.NativeFieldInfoPtr__length)) = value;
			}
		}

		// Token: 0x04001E6F RID: 7791
		private static readonly IntPtr NativeFieldInfoPtr__s;

		// Token: 0x04001E70 RID: 7792
		private static readonly IntPtr NativeFieldInfoPtr__pos;

		// Token: 0x04001E71 RID: 7793
		private static readonly IntPtr NativeFieldInfoPtr__length;

		// Token: 0x04001E72 RID: 7794
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001E73 RID: 7795
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04001E74 RID: 7796
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04001E75 RID: 7797
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0;

		// Token: 0x04001E76 RID: 7798
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_0;

		// Token: 0x04001E77 RID: 7799
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001E78 RID: 7800
		private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0;

		// Token: 0x04001E79 RID: 7801
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0;
	}
}
