using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000509 RID: 1289
	public class TraceLoggingMetadataCollector : Object
	{
		// Token: 0x06004A5E RID: 19038 RVA: 0x00154D04 File Offset: 0x00152F04
		// Note: this type is marked as 'beforefieldinit'.
		static TraceLoggingMetadataCollector()
		{
			Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "TraceLoggingMetadataCollector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr);
			TraceLoggingMetadataCollector.NativeFieldInfoPtr_impl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, "impl");
			TraceLoggingMetadataCollector.NativeFieldInfoPtr_currentGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, "currentGroup");
			TraceLoggingMetadataCollector.NativeFieldInfoPtr_bufferedArrayFieldCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, "bufferedArrayFieldCount");
			TraceLoggingMetadataCollector.NativeFieldInfoPtr__Tags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, "<Tags>k__BackingField");
			TraceLoggingMetadataCollector.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674311);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr__ctor_Private_Void_TraceLoggingMetadataCollector_FieldMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674312);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_get_Tags_Internal_get_EventFieldTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674313);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_set_Tags_Internal_set_Void_EventFieldTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674314);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_get_ScratchSize_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674315);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_get_DataCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674316);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_get_PinCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674317);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_get_BeginningBufferedArray_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674318);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_AddGroup_Public_TraceLoggingMetadataCollector_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674319);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_String_TraceLoggingDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674320);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_AddBinary_Public_Void_String_TraceLoggingDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674321);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_AddArray_Public_Void_String_TraceLoggingDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674322);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_BeginBufferedArray_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674323);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_EndBufferedArray_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674324);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_GetMetadata_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674325);
			TraceLoggingMetadataCollector.NativeMethodInfoPtr_AddField_Private_Void_FieldMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, 100674326);
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x00154EC4 File Offset: 0x001530C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372075, XrefRangeEnd = 372080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceLoggingMetadataCollector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x00154F00 File Offset: 0x00153100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372080, XrefRangeEnd = 372081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceLoggingMetadataCollector(TraceLoggingMetadataCollector other, FieldMetadata group)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(group);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr__ctor_Private_Void_TraceLoggingMetadataCollector_FieldMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x06004A61 RID: 19041 RVA: 0x00154F60 File Offset: 0x00153160
		// (set) Token: 0x06004A62 RID: 19042 RVA: 0x00154F9C File Offset: 0x0015319C
		public unsafe EventFieldTags Tags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_get_Tags_Internal_get_EventFieldTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_set_Tags_Internal_set_Void_EventFieldTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x06004A63 RID: 19043 RVA: 0x00154FDC File Offset: 0x001531DC
		public unsafe int ScratchSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_get_ScratchSize_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x06004A64 RID: 19044 RVA: 0x00155018 File Offset: 0x00153218
		public unsafe int DataCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_get_DataCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x06004A65 RID: 19045 RVA: 0x00155054 File Offset: 0x00153254
		public unsafe int PinCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_get_PinCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x06004A66 RID: 19046 RVA: 0x00155090 File Offset: 0x00153290
		public unsafe bool BeginningBufferedArray
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_get_BeginningBufferedArray_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004A67 RID: 19047 RVA: 0x001550CC File Offset: 0x001532CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 372093, RefRangeEnd = 372097, XrefRangeStart = 372081, XrefRangeEnd = 372093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceLoggingMetadataCollector AddGroup(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_AddGroup_Public_TraceLoggingMetadataCollector_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TraceLoggingMetadataCollector>(intPtr3) : null;
			}
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x0015511C File Offset: 0x0015331C
		[CallerCount(196)]
		[CachedScanResults(RefRangeStart = 372110, RefRangeEnd = 372306, XrefRangeStart = 372097, XrefRangeEnd = 372110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(string name, TraceLoggingDataType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_String_TraceLoggingDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A69 RID: 19049 RVA: 0x0015516C File Offset: 0x0015336C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372316, RefRangeEnd = 372318, XrefRangeStart = 372306, XrefRangeEnd = 372316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBinary(string name, TraceLoggingDataType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_AddBinary_Public_Void_String_TraceLoggingDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A6A RID: 19050 RVA: 0x001551BC File Offset: 0x001533BC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 372339, RefRangeEnd = 372355, XrefRangeStart = 372318, XrefRangeEnd = 372339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(string name, TraceLoggingDataType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_AddArray_Public_Void_String_TraceLoggingDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A6B RID: 19051 RVA: 0x0015520C File Offset: 0x0015340C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372364, RefRangeEnd = 372366, XrefRangeStart = 372355, XrefRangeEnd = 372364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginBufferedArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_BeginBufferedArray_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A6C RID: 19052 RVA: 0x00155240 File Offset: 0x00153440
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372375, RefRangeEnd = 372377, XrefRangeStart = 372366, XrefRangeEnd = 372375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndBufferedArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_EndBufferedArray_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x00155274 File Offset: 0x00153474
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372382, RefRangeEnd = 372384, XrefRangeStart = 372377, XrefRangeEnd = 372382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetMetadata()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_GetMetadata_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06004A6E RID: 19054 RVA: 0x001552B4 File Offset: 0x001534B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372388, RefRangeEnd = 372389, XrefRangeStart = 372384, XrefRangeEnd = 372388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddField(FieldMetadata fieldMetadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fieldMetadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.NativeMethodInfoPtr_AddField_Private_Void_FieldMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004A6F RID: 19055 RVA: 0x0001BE7C File Offset: 0x0001A07C
		public TraceLoggingMetadataCollector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x06004A70 RID: 19056 RVA: 0x001552F8 File Offset: 0x001534F8
		// (set) Token: 0x06004A71 RID: 19057 RVA: 0x0001BE85 File Offset: 0x0001A085
		public unsafe TraceLoggingMetadataCollector.Impl impl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.NativeFieldInfoPtr_impl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceLoggingMetadataCollector.Impl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.NativeFieldInfoPtr_impl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x06004A72 RID: 19058 RVA: 0x00155328 File Offset: 0x00153528
		// (set) Token: 0x06004A73 RID: 19059 RVA: 0x0001BEA4 File Offset: 0x0001A0A4
		public unsafe FieldMetadata currentGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.NativeFieldInfoPtr_currentGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldMetadata>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.NativeFieldInfoPtr_currentGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x06004A74 RID: 19060 RVA: 0x00155358 File Offset: 0x00153558
		// (set) Token: 0x06004A75 RID: 19061 RVA: 0x0001BEC3 File Offset: 0x0001A0C3
		public unsafe int bufferedArrayFieldCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.NativeFieldInfoPtr_bufferedArrayFieldCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.NativeFieldInfoPtr_bufferedArrayFieldCount)) = value;
			}
		}

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x06004A76 RID: 19062 RVA: 0x00155380 File Offset: 0x00153580
		// (set) Token: 0x06004A77 RID: 19063 RVA: 0x0001BEDE File Offset: 0x0001A0DE
		public unsafe EventFieldTags _Tags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.NativeFieldInfoPtr__Tags_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.NativeFieldInfoPtr__Tags_k__BackingField)) = value;
			}
		}

		// Token: 0x04003C11 RID: 15377
		private static readonly IntPtr NativeFieldInfoPtr_impl;

		// Token: 0x04003C12 RID: 15378
		private static readonly IntPtr NativeFieldInfoPtr_currentGroup;

		// Token: 0x04003C13 RID: 15379
		private static readonly IntPtr NativeFieldInfoPtr_bufferedArrayFieldCount;

		// Token: 0x04003C14 RID: 15380
		private static readonly IntPtr NativeFieldInfoPtr__Tags_k__BackingField;

		// Token: 0x04003C15 RID: 15381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04003C16 RID: 15382
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_TraceLoggingMetadataCollector_FieldMetadata_0;

		// Token: 0x04003C17 RID: 15383
		private static readonly IntPtr NativeMethodInfoPtr_get_Tags_Internal_get_EventFieldTags_0;

		// Token: 0x04003C18 RID: 15384
		private static readonly IntPtr NativeMethodInfoPtr_set_Tags_Internal_set_Void_EventFieldTags_0;

		// Token: 0x04003C19 RID: 15385
		private static readonly IntPtr NativeMethodInfoPtr_get_ScratchSize_Internal_get_Int32_0;

		// Token: 0x04003C1A RID: 15386
		private static readonly IntPtr NativeMethodInfoPtr_get_DataCount_Internal_get_Int32_0;

		// Token: 0x04003C1B RID: 15387
		private static readonly IntPtr NativeMethodInfoPtr_get_PinCount_Internal_get_Int32_0;

		// Token: 0x04003C1C RID: 15388
		private static readonly IntPtr NativeMethodInfoPtr_get_BeginningBufferedArray_Private_get_Boolean_0;

		// Token: 0x04003C1D RID: 15389
		private static readonly IntPtr NativeMethodInfoPtr_AddGroup_Public_TraceLoggingMetadataCollector_String_0;

		// Token: 0x04003C1E RID: 15390
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_String_TraceLoggingDataType_0;

		// Token: 0x04003C1F RID: 15391
		private static readonly IntPtr NativeMethodInfoPtr_AddBinary_Public_Void_String_TraceLoggingDataType_0;

		// Token: 0x04003C20 RID: 15392
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_String_TraceLoggingDataType_0;

		// Token: 0x04003C21 RID: 15393
		private static readonly IntPtr NativeMethodInfoPtr_BeginBufferedArray_Public_Void_0;

		// Token: 0x04003C22 RID: 15394
		private static readonly IntPtr NativeMethodInfoPtr_EndBufferedArray_Public_Void_0;

		// Token: 0x04003C23 RID: 15395
		private static readonly IntPtr NativeMethodInfoPtr_GetMetadata_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x04003C24 RID: 15396
		private static readonly IntPtr NativeMethodInfoPtr_AddField_Private_Void_FieldMetadata_0;

		// Token: 0x02000679 RID: 1657
		public class Impl : Object
		{
			// Token: 0x060056D6 RID: 22230 RVA: 0x0017EAC8 File Offset: 0x0017CCC8
			// Note: this type is marked as 'beforefieldinit'.
			static Impl()
			{
				Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TraceLoggingMetadataCollector>.NativeClassPtr, "Impl");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr);
				TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, "fields");
				TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_scratchSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, "scratchSize");
				TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_dataCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, "dataCount");
				TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_pinCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, "pinCount");
				TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_bufferNesting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, "bufferNesting");
				TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_scalar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, "scalar");
				TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr_AddScalar_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, 100674327);
				TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr_AddNonscalar_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, 100674328);
				TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr_BeginBuffered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, 100674329);
				TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr_EndBuffered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, 100674330);
				TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr_Encode_Public_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, 100674331);
				TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr, 100674332);
			}

			// Token: 0x060056D7 RID: 22231 RVA: 0x0017EBE4 File Offset: 0x0017CDE4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 372039, RefRangeEnd = 372042, XrefRangeStart = 372038, XrefRangeEnd = 372039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddScalar(int size)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr_AddScalar_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060056D8 RID: 22232 RVA: 0x0017EC24 File Offset: 0x0017CE24
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 372043, RefRangeEnd = 372045, XrefRangeStart = 372042, XrefRangeEnd = 372043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddNonscalar()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr_AddNonscalar_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056D9 RID: 22233 RVA: 0x0017EC58 File Offset: 0x0017CE58
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 372046, RefRangeEnd = 372047, XrefRangeStart = 372045, XrefRangeEnd = 372046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void BeginBuffered()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr_BeginBuffered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056DA RID: 22234 RVA: 0x0017EC8C File Offset: 0x0017CE8C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 372047, RefRangeEnd = 372048, XrefRangeStart = 372047, XrefRangeEnd = 372047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndBuffered()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr_EndBuffered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056DB RID: 22235 RVA: 0x0017ECC0 File Offset: 0x0017CEC0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 372063, RefRangeEnd = 372065, XrefRangeStart = 372048, XrefRangeEnd = 372063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Encode(Il2CppStructArray<byte> metadata)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(metadata);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr_Encode_Public_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060056DC RID: 22236 RVA: 0x0017ED10 File Offset: 0x0017CF10
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 372072, RefRangeEnd = 372075, XrefRangeStart = 372065, XrefRangeEnd = 372072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Impl()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceLoggingMetadataCollector.Impl>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingMetadataCollector.Impl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056DD RID: 22237 RVA: 0x00021943 File Offset: 0x0001FB43
			public Impl(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001657 RID: 5719
			// (get) Token: 0x060056DE RID: 22238 RVA: 0x0017ED4C File Offset: 0x0017CF4C
			// (set) Token: 0x060056DF RID: 22239 RVA: 0x0002194C File Offset: 0x0001FB4C
			public unsafe List<FieldMetadata> fields
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_fields);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FieldMetadata>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_fields), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001658 RID: 5720
			// (get) Token: 0x060056E0 RID: 22240 RVA: 0x0017ED7C File Offset: 0x0017CF7C
			// (set) Token: 0x060056E1 RID: 22241 RVA: 0x0002196B File Offset: 0x0001FB6B
			public unsafe short scratchSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_scratchSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_scratchSize)) = value;
				}
			}

			// Token: 0x17001659 RID: 5721
			// (get) Token: 0x060056E2 RID: 22242 RVA: 0x0017EDA4 File Offset: 0x0017CFA4
			// (set) Token: 0x060056E3 RID: 22243 RVA: 0x00021986 File Offset: 0x0001FB86
			public unsafe sbyte dataCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_dataCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_dataCount)) = value;
				}
			}

			// Token: 0x1700165A RID: 5722
			// (get) Token: 0x060056E4 RID: 22244 RVA: 0x0017EDCC File Offset: 0x0017CFCC
			// (set) Token: 0x060056E5 RID: 22245 RVA: 0x000219A1 File Offset: 0x0001FBA1
			public unsafe sbyte pinCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_pinCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_pinCount)) = value;
				}
			}

			// Token: 0x1700165B RID: 5723
			// (get) Token: 0x060056E6 RID: 22246 RVA: 0x0017EDF4 File Offset: 0x0017CFF4
			// (set) Token: 0x060056E7 RID: 22247 RVA: 0x000219BC File Offset: 0x0001FBBC
			public unsafe int bufferNesting
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_bufferNesting);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_bufferNesting)) = value;
				}
			}

			// Token: 0x1700165C RID: 5724
			// (get) Token: 0x060056E8 RID: 22248 RVA: 0x0017EE1C File Offset: 0x0017D01C
			// (set) Token: 0x060056E9 RID: 22249 RVA: 0x000219D7 File Offset: 0x0001FBD7
			public unsafe bool scalar
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_scalar);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingMetadataCollector.Impl.NativeFieldInfoPtr_scalar)) = value;
				}
			}

			// Token: 0x0400458C RID: 17804
			private static readonly IntPtr NativeFieldInfoPtr_fields;

			// Token: 0x0400458D RID: 17805
			private static readonly IntPtr NativeFieldInfoPtr_scratchSize;

			// Token: 0x0400458E RID: 17806
			private static readonly IntPtr NativeFieldInfoPtr_dataCount;

			// Token: 0x0400458F RID: 17807
			private static readonly IntPtr NativeFieldInfoPtr_pinCount;

			// Token: 0x04004590 RID: 17808
			private static readonly IntPtr NativeFieldInfoPtr_bufferNesting;

			// Token: 0x04004591 RID: 17809
			private static readonly IntPtr NativeFieldInfoPtr_scalar;

			// Token: 0x04004592 RID: 17810
			private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_Int32_0;

			// Token: 0x04004593 RID: 17811
			private static readonly IntPtr NativeMethodInfoPtr_AddNonscalar_Public_Void_0;

			// Token: 0x04004594 RID: 17812
			private static readonly IntPtr NativeMethodInfoPtr_BeginBuffered_Public_Void_0;

			// Token: 0x04004595 RID: 17813
			private static readonly IntPtr NativeMethodInfoPtr_EndBuffered_Public_Void_0;

			// Token: 0x04004596 RID: 17814
			private static readonly IntPtr NativeMethodInfoPtr_Encode_Public_Int32_Il2CppStructArray_1_Byte_0;

			// Token: 0x04004597 RID: 17815
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
