using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using SA.Common.Models;

namespace SA.Fitness
{
	// Token: 0x0200033B RID: 827
	public class ReadDailyTotalResult : Result
	{
		// Token: 0x060031CB RID: 12747 RVA: 0x000D0B60 File Offset: 0x000CED60
		// Note: this type is marked as 'beforefieldinit'.
		static ReadDailyTotalResult()
		{
			Il2CppClassPointerStore<ReadDailyTotalResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "ReadDailyTotalResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadDailyTotalResult>.NativeClassPtr);
			ReadDailyTotalResult.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadDailyTotalResult>.NativeClassPtr, "id");
			ReadDailyTotalResult.NativeFieldInfoPtr_dataSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadDailyTotalResult>.NativeClassPtr, "dataSet");
			ReadDailyTotalResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadDailyTotalResult>.NativeClassPtr, 100669707);
			ReadDailyTotalResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadDailyTotalResult>.NativeClassPtr, 100669708);
			ReadDailyTotalResult.NativeMethodInfoPtr_SetData_Public_Void_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadDailyTotalResult>.NativeClassPtr, 100669709);
			ReadDailyTotalResult.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadDailyTotalResult>.NativeClassPtr, 100669710);
			ReadDailyTotalResult.NativeMethodInfoPtr_get_DataSet_Public_get_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadDailyTotalResult>.NativeClassPtr, 100669711);
		}

		// Token: 0x060031CC RID: 12748 RVA: 0x000D0C1C File Offset: 0x000CEE1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168660, RefRangeEnd = 168662, XrefRangeStart = 168660, XrefRangeEnd = 168662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadDailyTotalResult(int id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadDailyTotalResult>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadDailyTotalResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031CD RID: 12749 RVA: 0x000D0C64 File Offset: 0x000CEE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221806, XrefRangeEnd = 221811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadDailyTotalResult(int id, int resultCode, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadDailyTotalResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resultCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadDailyTotalResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031CE RID: 12750 RVA: 0x000D0CCC File Offset: 0x000CEECC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(DataSet dataSet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadDailyTotalResult.NativeMethodInfoPtr_SetData_Public_Void_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x060031CF RID: 12751 RVA: 0x000D0D10 File Offset: 0x000CEF10
		public unsafe int Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadDailyTotalResult.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x060031D0 RID: 12752 RVA: 0x000D0D4C File Offset: 0x000CEF4C
		public unsafe DataSet DataSet
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadDailyTotalResult.NativeMethodInfoPtr_get_DataSet_Public_get_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataSet>(intPtr3) : null;
			}
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x0001344D File Offset: 0x0001164D
		public ReadDailyTotalResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x060031D2 RID: 12754 RVA: 0x000D0D8C File Offset: 0x000CEF8C
		// (set) Token: 0x060031D3 RID: 12755 RVA: 0x00013456 File Offset: 0x00011656
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadDailyTotalResult.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadDailyTotalResult.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x060031D4 RID: 12756 RVA: 0x000D0DB4 File Offset: 0x000CEFB4
		// (set) Token: 0x060031D5 RID: 12757 RVA: 0x00013471 File Offset: 0x00011671
		public unsafe DataSet dataSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadDailyTotalResult.NativeFieldInfoPtr_dataSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadDailyTotalResult.NativeFieldInfoPtr_dataSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002EC7 RID: 11975
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04002EC8 RID: 11976
		private static readonly IntPtr NativeFieldInfoPtr_dataSet;

		// Token: 0x04002EC9 RID: 11977
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002ECA RID: 11978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0;

		// Token: 0x04002ECB RID: 11979
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_DataSet_0;

		// Token: 0x04002ECC RID: 11980
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x04002ECD RID: 11981
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSet_Public_get_DataSet_0;
	}
}
