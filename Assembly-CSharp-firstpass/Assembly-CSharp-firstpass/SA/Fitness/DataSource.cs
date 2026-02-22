using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Fitness
{
	// Token: 0x02000334 RID: 820
	public class DataSource : Object
	{
		// Token: 0x06003015 RID: 12309 RVA: 0x000CCEEC File Offset: 0x000CB0EC
		// Note: this type is marked as 'beforefieldinit'.
		static DataSource()
		{
			Il2CppClassPointerStore<DataSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "DataSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataSource>.NativeClassPtr);
			DataSource.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSource>.NativeClassPtr, "dataType");
			DataSource.NativeFieldInfoPtr_dataSourceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSource>.NativeClassPtr, "dataSourceType");
			DataSource.NativeFieldInfoPtr_appPackageName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSource>.NativeClassPtr, "appPackageName");
			DataSource.NativeFieldInfoPtr_device = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSource>.NativeClassPtr, "device");
			DataSource.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSource>.NativeClassPtr, "name");
			DataSource.NativeFieldInfoPtr_streamId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSource>.NativeClassPtr, "streamId");
			DataSource.NativeFieldInfoPtr_streamName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSource>.NativeClassPtr, "streamName");
			DataSource.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSource>.NativeClassPtr, 100669659);
			DataSource.NativeMethodInfoPtr_get_DataType_Public_get_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSource>.NativeClassPtr, 100669660);
			DataSource.NativeMethodInfoPtr_get_DataSourceType_Public_get_DataSourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSource>.NativeClassPtr, 100669661);
			DataSource.NativeMethodInfoPtr_get_AppPackageName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSource>.NativeClassPtr, 100669662);
			DataSource.NativeMethodInfoPtr_get_Device_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSource>.NativeClassPtr, 100669663);
			DataSource.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSource>.NativeClassPtr, 100669664);
			DataSource.NativeMethodInfoPtr_get_StreamId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSource>.NativeClassPtr, 100669665);
			DataSource.NativeMethodInfoPtr_get_StreamName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSource>.NativeClassPtr, 100669666);
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x000CD048 File Offset: 0x000CB248
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221482, RefRangeEnd = 221483, XrefRangeStart = 221468, XrefRangeEnd = 221482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataSource(Il2CppStringArray bundle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataSource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bundle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSource.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06003017 RID: 12311 RVA: 0x000CD094 File Offset: 0x000CB294
		public unsafe DataType DataType
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSource.NativeMethodInfoPtr_get_DataType_Public_get_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr3) : null;
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06003018 RID: 12312 RVA: 0x000CD0D4 File Offset: 0x000CB2D4
		public unsafe DataSourceType DataSourceType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSource.NativeMethodInfoPtr_get_DataSourceType_Public_get_DataSourceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06003019 RID: 12313 RVA: 0x000CD110 File Offset: 0x000CB310
		public unsafe string AppPackageName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSource.NativeMethodInfoPtr_get_AppPackageName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x0600301A RID: 12314 RVA: 0x000CD148 File Offset: 0x000CB348
		public unsafe string Device
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSource.NativeMethodInfoPtr_get_Device_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x0600301B RID: 12315 RVA: 0x000CD180 File Offset: 0x000CB380
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSource.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x0600301C RID: 12316 RVA: 0x000CD1B8 File Offset: 0x000CB3B8
		public unsafe string StreamId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSource.NativeMethodInfoPtr_get_StreamId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x0600301D RID: 12317 RVA: 0x000CD1F0 File Offset: 0x000CB3F0
		public unsafe string StreamName
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSource.NativeMethodInfoPtr_get_StreamName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600301E RID: 12318 RVA: 0x000125B9 File Offset: 0x000107B9
		public DataSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x0600301F RID: 12319 RVA: 0x000CD228 File Offset: 0x000CB428
		// (set) Token: 0x06003020 RID: 12320 RVA: 0x000125C2 File Offset: 0x000107C2
		public unsafe DataType dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSource.NativeFieldInfoPtr_dataType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSource.NativeFieldInfoPtr_dataType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06003021 RID: 12321 RVA: 0x000CD258 File Offset: 0x000CB458
		// (set) Token: 0x06003022 RID: 12322 RVA: 0x000125E1 File Offset: 0x000107E1
		public unsafe DataSourceType dataSourceType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSource.NativeFieldInfoPtr_dataSourceType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSource.NativeFieldInfoPtr_dataSourceType)) = value;
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06003023 RID: 12323 RVA: 0x000CD280 File Offset: 0x000CB480
		// (set) Token: 0x06003024 RID: 12324 RVA: 0x000125FC File Offset: 0x000107FC
		public unsafe string appPackageName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSource.NativeFieldInfoPtr_appPackageName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSource.NativeFieldInfoPtr_appPackageName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06003025 RID: 12325 RVA: 0x000CD2A8 File Offset: 0x000CB4A8
		// (set) Token: 0x06003026 RID: 12326 RVA: 0x0001261B File Offset: 0x0001081B
		public unsafe string device
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSource.NativeFieldInfoPtr_device);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSource.NativeFieldInfoPtr_device), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06003027 RID: 12327 RVA: 0x000CD2D0 File Offset: 0x000CB4D0
		// (set) Token: 0x06003028 RID: 12328 RVA: 0x0001263A File Offset: 0x0001083A
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSource.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSource.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06003029 RID: 12329 RVA: 0x000CD2F8 File Offset: 0x000CB4F8
		// (set) Token: 0x0600302A RID: 12330 RVA: 0x00012659 File Offset: 0x00010859
		public unsafe string streamId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSource.NativeFieldInfoPtr_streamId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSource.NativeFieldInfoPtr_streamId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x0600302B RID: 12331 RVA: 0x000CD320 File Offset: 0x000CB520
		// (set) Token: 0x0600302C RID: 12332 RVA: 0x00012678 File Offset: 0x00010878
		public unsafe string streamName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSource.NativeFieldInfoPtr_streamName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSource.NativeFieldInfoPtr_streamName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002DDD RID: 11741
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x04002DDE RID: 11742
		private static readonly IntPtr NativeFieldInfoPtr_dataSourceType;

		// Token: 0x04002DDF RID: 11743
		private static readonly IntPtr NativeFieldInfoPtr_appPackageName;

		// Token: 0x04002DE0 RID: 11744
		private static readonly IntPtr NativeFieldInfoPtr_device;

		// Token: 0x04002DE1 RID: 11745
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04002DE2 RID: 11746
		private static readonly IntPtr NativeFieldInfoPtr_streamId;

		// Token: 0x04002DE3 RID: 11747
		private static readonly IntPtr NativeFieldInfoPtr_streamName;

		// Token: 0x04002DE4 RID: 11748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0;

		// Token: 0x04002DE5 RID: 11749
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Public_get_DataType_0;

		// Token: 0x04002DE6 RID: 11750
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSourceType_Public_get_DataSourceType_0;

		// Token: 0x04002DE7 RID: 11751
		private static readonly IntPtr NativeMethodInfoPtr_get_AppPackageName_Public_get_String_0;

		// Token: 0x04002DE8 RID: 11752
		private static readonly IntPtr NativeMethodInfoPtr_get_Device_Public_get_String_0;

		// Token: 0x04002DE9 RID: 11753
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04002DEA RID: 11754
		private static readonly IntPtr NativeMethodInfoPtr_get_StreamId_Public_get_String_0;

		// Token: 0x04002DEB RID: 11755
		private static readonly IntPtr NativeMethodInfoPtr_get_StreamName_Public_get_String_0;
	}
}
