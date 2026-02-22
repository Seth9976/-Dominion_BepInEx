using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SA.Common.Models;

namespace SA.Fitness
{
	// Token: 0x02000342 RID: 834
	public class SensorRequestResult : Result
	{
		// Token: 0x06003266 RID: 12902 RVA: 0x000D2BDC File Offset: 0x000D0DDC
		// Note: this type is marked as 'beforefieldinit'.
		static SensorRequestResult()
		{
			Il2CppClassPointerStore<SensorRequestResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "SensorRequestResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SensorRequestResult>.NativeClassPtr);
			SensorRequestResult.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorRequestResult>.NativeClassPtr, "id");
			SensorRequestResult.NativeFieldInfoPtr_dataSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorRequestResult>.NativeClassPtr, "dataSources");
			SensorRequestResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRequestResult>.NativeClassPtr, 100669772);
			SensorRequestResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRequestResult>.NativeClassPtr, 100669773);
			SensorRequestResult.NativeMethodInfoPtr_AddDataSource_Public_Void_DataSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRequestResult>.NativeClassPtr, 100669774);
			SensorRequestResult.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRequestResult>.NativeClassPtr, 100669775);
			SensorRequestResult.NativeMethodInfoPtr_get_DataSources_Public_get_List_1_DataSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRequestResult>.NativeClassPtr, 100669776);
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x000D2C98 File Offset: 0x000D0E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222541, XrefRangeEnd = 222548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SensorRequestResult(int id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SensorRequestResult>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorRequestResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x000D2CE0 File Offset: 0x000D0EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222548, XrefRangeEnd = 222559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SensorRequestResult(int id, int resultCode, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SensorRequestResult>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorRequestResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003269 RID: 12905 RVA: 0x000D2D48 File Offset: 0x000D0F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222559, XrefRangeEnd = 222563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDataSource(DataSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorRequestResult.NativeMethodInfoPtr_AddDataSource_Public_Void_DataSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x0600326A RID: 12906 RVA: 0x000D2D8C File Offset: 0x000D0F8C
		public unsafe int Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorRequestResult.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x0600326B RID: 12907 RVA: 0x000D2DC8 File Offset: 0x000D0FC8
		public unsafe List<DataSource> DataSources
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorRequestResult.NativeMethodInfoPtr_get_DataSources_Public_get_List_1_DataSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DataSource>>(intPtr3) : null;
			}
		}

		// Token: 0x0600326C RID: 12908 RVA: 0x000138D2 File Offset: 0x00011AD2
		public SensorRequestResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x0600326D RID: 12909 RVA: 0x000D2E08 File Offset: 0x000D1008
		// (set) Token: 0x0600326E RID: 12910 RVA: 0x000138DB File Offset: 0x00011ADB
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRequestResult.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRequestResult.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x0600326F RID: 12911 RVA: 0x000D2E30 File Offset: 0x000D1030
		// (set) Token: 0x06003270 RID: 12912 RVA: 0x000138F6 File Offset: 0x00011AF6
		public unsafe List<DataSource> dataSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRequestResult.NativeFieldInfoPtr_dataSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DataSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRequestResult.NativeFieldInfoPtr_dataSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F2E RID: 12078
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04002F2F RID: 12079
		private static readonly IntPtr NativeFieldInfoPtr_dataSources;

		// Token: 0x04002F30 RID: 12080
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002F31 RID: 12081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0;

		// Token: 0x04002F32 RID: 12082
		private static readonly IntPtr NativeMethodInfoPtr_AddDataSource_Public_Void_DataSource_0;

		// Token: 0x04002F33 RID: 12083
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x04002F34 RID: 12084
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSources_Public_get_List_1_DataSource_0;
	}
}
