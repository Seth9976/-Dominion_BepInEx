using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000137 RID: 311
	public class TermInfoReader : Object
	{
		// Token: 0x06001671 RID: 5745 RVA: 0x000873EC File Offset: 0x000855EC
		// Note: this type is marked as 'beforefieldinit'.
		static TermInfoReader()
		{
			Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TermInfoReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr);
			TermInfoReader.NativeFieldInfoPtr_boolSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, "boolSize");
			TermInfoReader.NativeFieldInfoPtr_numSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, "numSize");
			TermInfoReader.NativeFieldInfoPtr_strOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, "strOffsets");
			TermInfoReader.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, "buffer");
			TermInfoReader.NativeFieldInfoPtr_booleansOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, "booleansOffset");
			TermInfoReader.NativeFieldInfoPtr_intOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, "intOffset");
			TermInfoReader.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667075);
			TermInfoReader.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667076);
			TermInfoReader.NativeMethodInfoPtr_DetermineVersion_Private_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667077);
			TermInfoReader.NativeMethodInfoPtr_ReadHeader_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667078);
			TermInfoReader.NativeMethodInfoPtr_ReadNames_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667079);
			TermInfoReader.NativeMethodInfoPtr_Get_Public_Int32_TermInfoNumbers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667080);
			TermInfoReader.NativeMethodInfoPtr_Get_Public_String_TermInfoStrings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667081);
			TermInfoReader.NativeMethodInfoPtr_GetStringBytes_Public_Il2CppStructArray_1_Byte_TermInfoStrings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667082);
			TermInfoReader.NativeMethodInfoPtr_GetInt16_Private_Int16_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667083);
			TermInfoReader.NativeMethodInfoPtr_GetInt32_Private_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667084);
			TermInfoReader.NativeMethodInfoPtr_GetInteger_Private_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667085);
			TermInfoReader.NativeMethodInfoPtr_GetString_Private_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667086);
			TermInfoReader.NativeMethodInfoPtr_GetStringBytes_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667087);
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00087598 File Offset: 0x00085798
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309071, RefRangeEnd = 309072, XrefRangeStart = 309060, XrefRangeEnd = 309071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TermInfoReader(string term, string filename)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(filename);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x000875F8 File Offset: 0x000857F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 309081, RefRangeEnd = 309083, XrefRangeStart = 309072, XrefRangeEnd = 309081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TermInfoReader(string term, Il2CppStructArray<byte> buffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00087658 File Offset: 0x00085858
		[CallerCount(0)]
		public unsafe void DetermineVersion(short magic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref magic;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_DetermineVersion_Private_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00087698 File Offset: 0x00085898
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 309087, RefRangeEnd = 309089, XrefRangeStart = 309083, XrefRangeEnd = 309087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadHeader(Il2CppStructArray<byte> buffer, ref int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_ReadHeader_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x000876E8 File Offset: 0x000858E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 309091, RefRangeEnd = 309093, XrefRangeStart = 309089, XrefRangeEnd = 309091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadNames(Il2CppStructArray<byte> buffer, ref int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_ReadNames_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x00087738 File Offset: 0x00085938
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 309094, RefRangeEnd = 309097, XrefRangeStart = 309093, XrefRangeEnd = 309094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Get(TermInfoNumbers number)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref number;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_Get_Public_Int32_TermInfoNumbers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x00087784 File Offset: 0x00085984
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 309100, RefRangeEnd = 309114, XrefRangeStart = 309097, XrefRangeEnd = 309100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Get(TermInfoStrings tstr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tstr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_Get_Public_String_TermInfoStrings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x000877C8 File Offset: 0x000859C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 309120, RefRangeEnd = 309122, XrefRangeStart = 309114, XrefRangeEnd = 309120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetStringBytes(TermInfoStrings tstr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tstr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_GetStringBytes_Public_Il2CppStructArray_1_Byte_TermInfoStrings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x00087814 File Offset: 0x00085A14
		[CallerCount(0)]
		public unsafe short GetInt16(Il2CppStructArray<byte> buffer, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_GetInt16_Private_Int16_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00087870 File Offset: 0x00085A70
		[CallerCount(0)]
		public unsafe int GetInt32(Il2CppStructArray<byte> buffer, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_GetInt32_Private_Int32_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x000878CC File Offset: 0x00085ACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309122, RefRangeEnd = 309123, XrefRangeStart = 309122, XrefRangeEnd = 309122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInteger(Il2CppStructArray<byte> buffer, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_GetInteger_Private_Int32_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x00087928 File Offset: 0x00085B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309123, XrefRangeEnd = 309125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetString(Il2CppStructArray<byte> buffer, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_GetString_Private_String_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00087980 File Offset: 0x00085B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309125, XrefRangeEnd = 309130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetStringBytes(Il2CppStructArray<byte> buffer, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_GetStringBytes_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00007DEB File Offset: 0x00005FEB
		public TermInfoReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06001680 RID: 5760 RVA: 0x000879E0 File Offset: 0x00085BE0
		// (set) Token: 0x06001681 RID: 5761 RVA: 0x00007DF4 File Offset: 0x00005FF4
		public unsafe int boolSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_boolSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_boolSize)) = value;
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06001682 RID: 5762 RVA: 0x00087A08 File Offset: 0x00085C08
		// (set) Token: 0x06001683 RID: 5763 RVA: 0x00007E0F File Offset: 0x0000600F
		public unsafe int numSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_numSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_numSize)) = value;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06001684 RID: 5764 RVA: 0x00087A30 File Offset: 0x00085C30
		// (set) Token: 0x06001685 RID: 5765 RVA: 0x00007E2A File Offset: 0x0000602A
		public unsafe int strOffsets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_strOffsets);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_strOffsets)) = value;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x00087A58 File Offset: 0x00085C58
		// (set) Token: 0x06001687 RID: 5767 RVA: 0x00007E45 File Offset: 0x00006045
		public unsafe Il2CppStructArray<byte> buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001688 RID: 5768 RVA: 0x00087A88 File Offset: 0x00085C88
		// (set) Token: 0x06001689 RID: 5769 RVA: 0x00007E64 File Offset: 0x00006064
		public unsafe int booleansOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_booleansOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_booleansOffset)) = value;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x0600168A RID: 5770 RVA: 0x00087AB0 File Offset: 0x00085CB0
		// (set) Token: 0x0600168B RID: 5771 RVA: 0x00007E7F File Offset: 0x0000607F
		public unsafe int intOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_intOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_intOffset)) = value;
			}
		}

		// Token: 0x04001314 RID: 4884
		private static readonly IntPtr NativeFieldInfoPtr_boolSize;

		// Token: 0x04001315 RID: 4885
		private static readonly IntPtr NativeFieldInfoPtr_numSize;

		// Token: 0x04001316 RID: 4886
		private static readonly IntPtr NativeFieldInfoPtr_strOffsets;

		// Token: 0x04001317 RID: 4887
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x04001318 RID: 4888
		private static readonly IntPtr NativeFieldInfoPtr_booleansOffset;

		// Token: 0x04001319 RID: 4889
		private static readonly IntPtr NativeFieldInfoPtr_intOffset;

		// Token: 0x0400131A RID: 4890
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400131B RID: 4891
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400131C RID: 4892
		private static readonly IntPtr NativeMethodInfoPtr_DetermineVersion_Private_Void_Int16_0;

		// Token: 0x0400131D RID: 4893
		private static readonly IntPtr NativeMethodInfoPtr_ReadHeader_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_0;

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeMethodInfoPtr_ReadNames_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_0;

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Int32_TermInfoNumbers_0;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_String_TermInfoStrings_0;

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeMethodInfoPtr_GetStringBytes_Public_Il2CppStructArray_1_Byte_TermInfoStrings_0;

		// Token: 0x04001322 RID: 4898
		private static readonly IntPtr NativeMethodInfoPtr_GetInt16_Private_Int16_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeMethodInfoPtr_GetInt32_Private_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeMethodInfoPtr_GetInteger_Private_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Private_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeMethodInfoPtr_GetStringBytes_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;
	}
}
