using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000002 RID: 2
public class CSVReader : Object
{
	// Token: 0x06000001 RID: 1 RVA: 0x0001AC28 File Offset: 0x00018E28
	// Note: this type is marked as 'beforefieldinit'.
	static CSVReader()
	{
		Il2CppClassPointerStore<CSVReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CSVReader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CSVReader>.NativeClassPtr);
		CSVReader.NativeFieldInfoPtr_m_CSVBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSVReader>.NativeClassPtr, "m_CSVBytes");
		CSVReader.NativeFieldInfoPtr_m_ParseIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSVReader>.NativeClassPtr, "m_ParseIndex");
		CSVReader.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSVReader>.NativeClassPtr, 100663297);
		CSVReader.NativeMethodInfoPtr_ParseNextEntry_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSVReader>.NativeClassPtr, 100663298);
		CSVReader.NativeMethodInfoPtr_ParseCsvLine_Private_Static_Il2CppStringArray_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSVReader>.NativeClassPtr, 100663299);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x0001ACBC File Offset: 0x00018EBC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 223791, RefRangeEnd = 223792, XrefRangeStart = 223790, XrefRangeEnd = 223791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CSVReader(Il2CppStructArray<byte> csv_bytes)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CSVReader>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(csv_bytes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSVReader.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000003 RID: 3 RVA: 0x0001AD08 File Offset: 0x00018F08
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 223793, RefRangeEnd = 223794, XrefRangeStart = 223792, XrefRangeEnd = 223793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray ParseNextEntry()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSVReader.NativeMethodInfoPtr_ParseNextEntry_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x0001AD48 File Offset: 0x00018F48
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 223818, RefRangeEnd = 223819, XrefRangeStart = 223794, XrefRangeEnd = 223818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray ParseCsvLine(Il2CppStructArray<byte> csv_bytes, ref int parseIndex)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(csv_bytes);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &parseIndex;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSVReader.NativeMethodInfoPtr_ParseCsvLine_Private_Static_Il2CppStringArray_Il2CppStructArray_1_Byte_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	public CSVReader(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000006 RID: 6 RVA: 0x0001AD9C File Offset: 0x00018F9C
	// (set) Token: 0x06000007 RID: 7 RVA: 0x00002059 File Offset: 0x00000259
	public unsafe Il2CppStructArray<byte> m_CSVBytes
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CSVReader.NativeFieldInfoPtr_m_CSVBytes);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CSVReader.NativeFieldInfoPtr_m_CSVBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000008 RID: 8 RVA: 0x0001ADCC File Offset: 0x00018FCC
	// (set) Token: 0x06000009 RID: 9 RVA: 0x00002078 File Offset: 0x00000278
	public unsafe int m_ParseIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CSVReader.NativeFieldInfoPtr_m_ParseIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CSVReader.NativeFieldInfoPtr_m_ParseIndex)) = value;
		}
	}

	// Token: 0x04000001 RID: 1
	private static readonly IntPtr NativeFieldInfoPtr_m_CSVBytes;

	// Token: 0x04000002 RID: 2
	private static readonly IntPtr NativeFieldInfoPtr_m_ParseIndex;

	// Token: 0x04000003 RID: 3
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

	// Token: 0x04000004 RID: 4
	private static readonly IntPtr NativeMethodInfoPtr_ParseNextEntry_Public_Il2CppStringArray_0;

	// Token: 0x04000005 RID: 5
	private static readonly IntPtr NativeMethodInfoPtr_ParseCsvLine_Private_Static_Il2CppStringArray_Il2CppStructArray_1_Byte_byref_Int32_0;
}
