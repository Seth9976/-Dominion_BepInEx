using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Fitness
{
	// Token: 0x0200033E RID: 830
	public class ReadSessionRequest : Object
	{
		// Token: 0x06003212 RID: 12818 RVA: 0x000D1A34 File Offset: 0x000CFC34
		// Note: this type is marked as 'beforefieldinit'.
		static ReadSessionRequest()
		{
			Il2CppClassPointerStore<ReadSessionRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "ReadSessionRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadSessionRequest>.NativeClassPtr);
			ReadSessionRequest.NativeFieldInfoPtr_OnSessionReadFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadSessionRequest>.NativeClassPtr, "OnSessionReadFinished");
			ReadSessionRequest.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadSessionRequest>.NativeClassPtr, "startTime");
			ReadSessionRequest.NativeFieldInfoPtr_endTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadSessionRequest>.NativeClassPtr, "endTime");
			ReadSessionRequest.NativeFieldInfoPtr_timeUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadSessionRequest>.NativeClassPtr, "timeUnit");
			ReadSessionRequest.NativeFieldInfoPtr_sessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadSessionRequest>.NativeClassPtr, "sessionId");
			ReadSessionRequest.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadSessionRequest>.NativeClassPtr, "dataType");
			ReadSessionRequest.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadSessionRequest>.NativeClassPtr, "id");
			ReadSessionRequest.NativeMethodInfoPtr_add_OnSessionReadFinished_Public_add_Void_Action_1_ReadSessionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadSessionRequest>.NativeClassPtr, 100669736);
			ReadSessionRequest.NativeMethodInfoPtr_remove_OnSessionReadFinished_Public_rem_Void_Action_1_ReadSessionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadSessionRequest>.NativeClassPtr, 100669737);
			ReadSessionRequest.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadSessionRequest>.NativeClassPtr, 100669738);
			ReadSessionRequest.NativeMethodInfoPtr_DispatchResult_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadSessionRequest>.NativeClassPtr, 100669739);
			ReadSessionRequest.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadSessionRequest>.NativeClassPtr, 100669740);
			ReadSessionRequest.NativeMethodInfoPtr_get_StartTime_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadSessionRequest>.NativeClassPtr, 100669741);
			ReadSessionRequest.NativeMethodInfoPtr_get_EndTime_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadSessionRequest>.NativeClassPtr, 100669742);
			ReadSessionRequest.NativeMethodInfoPtr_get_TimeUnit_Public_get_TimeUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadSessionRequest>.NativeClassPtr, 100669743);
			ReadSessionRequest.NativeMethodInfoPtr_get_SessionId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadSessionRequest>.NativeClassPtr, 100669744);
			ReadSessionRequest.NativeMethodInfoPtr_get_DataType_Public_get_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadSessionRequest>.NativeClassPtr, 100669745);
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x000D1BB8 File Offset: 0x000CFDB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222127, RefRangeEnd = 222128, XrefRangeStart = 222123, XrefRangeEnd = 222127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnSessionReadFinished(Action<ReadSessionResult> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadSessionRequest.NativeMethodInfoPtr_add_OnSessionReadFinished_Public_add_Void_Action_1_ReadSessionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x000D1BFC File Offset: 0x000CFDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222128, XrefRangeEnd = 222132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnSessionReadFinished(Action<ReadSessionResult> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadSessionRequest.NativeMethodInfoPtr_remove_OnSessionReadFinished_Public_rem_Void_Action_1_ReadSessionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003215 RID: 12821 RVA: 0x000D1C40 File Offset: 0x000CFE40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222152, RefRangeEnd = 222153, XrefRangeStart = 222132, XrefRangeEnd = 222152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadSessionRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadSessionRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadSessionRequest.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003216 RID: 12822 RVA: 0x000D1C7C File Offset: 0x000CFE7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222303, RefRangeEnd = 222304, XrefRangeStart = 222153, XrefRangeEnd = 222303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchResult(Il2CppStringArray bundle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bundle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadSessionRequest.NativeMethodInfoPtr_DispatchResult_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06003217 RID: 12823 RVA: 0x000D1CC0 File Offset: 0x000CFEC0
		public unsafe int Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadSessionRequest.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06003218 RID: 12824 RVA: 0x000D1CFC File Offset: 0x000CFEFC
		public unsafe long StartTime
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadSessionRequest.NativeMethodInfoPtr_get_StartTime_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06003219 RID: 12825 RVA: 0x000D1D38 File Offset: 0x000CFF38
		public unsafe long EndTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadSessionRequest.NativeMethodInfoPtr_get_EndTime_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x0600321A RID: 12826 RVA: 0x000D1D74 File Offset: 0x000CFF74
		public unsafe TimeUnit TimeUnit
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadSessionRequest.NativeMethodInfoPtr_get_TimeUnit_Public_get_TimeUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x0600321B RID: 12827 RVA: 0x000D1DB0 File Offset: 0x000CFFB0
		public unsafe string SessionId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadSessionRequest.NativeMethodInfoPtr_get_SessionId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x0600321C RID: 12828 RVA: 0x000D1DE8 File Offset: 0x000CFFE8
		public unsafe DataType DataType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadSessionRequest.NativeMethodInfoPtr_get_DataType_Public_get_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr3) : null;
			}
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x00013666 File Offset: 0x00011866
		public ReadSessionRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x0600321E RID: 12830 RVA: 0x000D1E28 File Offset: 0x000D0028
		// (set) Token: 0x0600321F RID: 12831 RVA: 0x0001366F File Offset: 0x0001186F
		public unsafe Action<ReadSessionResult> OnSessionReadFinished
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadSessionRequest.NativeFieldInfoPtr_OnSessionReadFinished);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ReadSessionResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadSessionRequest.NativeFieldInfoPtr_OnSessionReadFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06003220 RID: 12832 RVA: 0x000D1E58 File Offset: 0x000D0058
		// (set) Token: 0x06003221 RID: 12833 RVA: 0x0001368E File Offset: 0x0001188E
		public unsafe long startTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadSessionRequest.NativeFieldInfoPtr_startTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadSessionRequest.NativeFieldInfoPtr_startTime)) = value;
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06003222 RID: 12834 RVA: 0x000D1E80 File Offset: 0x000D0080
		// (set) Token: 0x06003223 RID: 12835 RVA: 0x000136A9 File Offset: 0x000118A9
		public unsafe long endTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadSessionRequest.NativeFieldInfoPtr_endTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadSessionRequest.NativeFieldInfoPtr_endTime)) = value;
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06003224 RID: 12836 RVA: 0x000D1EA8 File Offset: 0x000D00A8
		// (set) Token: 0x06003225 RID: 12837 RVA: 0x000136C4 File Offset: 0x000118C4
		public unsafe TimeUnit timeUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadSessionRequest.NativeFieldInfoPtr_timeUnit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadSessionRequest.NativeFieldInfoPtr_timeUnit)) = value;
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06003226 RID: 12838 RVA: 0x000D1ED0 File Offset: 0x000D00D0
		// (set) Token: 0x06003227 RID: 12839 RVA: 0x000136DF File Offset: 0x000118DF
		public unsafe string sessionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadSessionRequest.NativeFieldInfoPtr_sessionId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadSessionRequest.NativeFieldInfoPtr_sessionId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06003228 RID: 12840 RVA: 0x000D1EF8 File Offset: 0x000D00F8
		// (set) Token: 0x06003229 RID: 12841 RVA: 0x000136FE File Offset: 0x000118FE
		public unsafe DataType dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadSessionRequest.NativeFieldInfoPtr_dataType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadSessionRequest.NativeFieldInfoPtr_dataType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x0600322A RID: 12842 RVA: 0x000D1F28 File Offset: 0x000D0128
		// (set) Token: 0x0600322B RID: 12843 RVA: 0x0001371D File Offset: 0x0001191D
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadSessionRequest.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadSessionRequest.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x04002EF6 RID: 12022
		private static readonly IntPtr NativeFieldInfoPtr_OnSessionReadFinished;

		// Token: 0x04002EF7 RID: 12023
		private static readonly IntPtr NativeFieldInfoPtr_startTime;

		// Token: 0x04002EF8 RID: 12024
		private static readonly IntPtr NativeFieldInfoPtr_endTime;

		// Token: 0x04002EF9 RID: 12025
		private static readonly IntPtr NativeFieldInfoPtr_timeUnit;

		// Token: 0x04002EFA RID: 12026
		private static readonly IntPtr NativeFieldInfoPtr_sessionId;

		// Token: 0x04002EFB RID: 12027
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x04002EFC RID: 12028
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04002EFD RID: 12029
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSessionReadFinished_Public_add_Void_Action_1_ReadSessionResult_0;

		// Token: 0x04002EFE RID: 12030
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSessionReadFinished_Public_rem_Void_Action_1_ReadSessionResult_0;

		// Token: 0x04002EFF RID: 12031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002F00 RID: 12032
		private static readonly IntPtr NativeMethodInfoPtr_DispatchResult_Public_Void_Il2CppStringArray_0;

		// Token: 0x04002F01 RID: 12033
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x04002F02 RID: 12034
		private static readonly IntPtr NativeMethodInfoPtr_get_StartTime_Public_get_Int64_0;

		// Token: 0x04002F03 RID: 12035
		private static readonly IntPtr NativeMethodInfoPtr_get_EndTime_Public_get_Int64_0;

		// Token: 0x04002F04 RID: 12036
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeUnit_Public_get_TimeUnit_0;

		// Token: 0x04002F05 RID: 12037
		private static readonly IntPtr NativeMethodInfoPtr_get_SessionId_Public_get_String_0;

		// Token: 0x04002F06 RID: 12038
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Public_get_DataType_0;

		// Token: 0x020003E7 RID: 999
		public class Builder : Object
		{
			// Token: 0x06003989 RID: 14729 RVA: 0x000E928C File Offset: 0x000E748C
			// Note: this type is marked as 'beforefieldinit'.
			static Builder()
			{
				Il2CppClassPointerStore<ReadSessionRequest.Builder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReadSessionRequest>.NativeClassPtr, "Builder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadSessionRequest.Builder>.NativeClassPtr);
				ReadSessionRequest.Builder.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadSessionRequest.Builder>.NativeClassPtr, "request");
				ReadSessionRequest.Builder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadSessionRequest.Builder>.NativeClassPtr, 100670552);
				ReadSessionRequest.Builder.NativeMethodInfoPtr_SetTimeinterval_Public_Builder_Int64_Int64_TimeUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadSessionRequest.Builder>.NativeClassPtr, 100670553);
				ReadSessionRequest.Builder.NativeMethodInfoPtr_SetIdentifier_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadSessionRequest.Builder>.NativeClassPtr, 100670554);
				ReadSessionRequest.Builder.NativeMethodInfoPtr_SetDataTypeToRead_Public_Builder_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadSessionRequest.Builder>.NativeClassPtr, 100670555);
				ReadSessionRequest.Builder.NativeMethodInfoPtr_Build_Public_ReadSessionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadSessionRequest.Builder>.NativeClassPtr, 100670556);
			}

			// Token: 0x0600398A RID: 14730 RVA: 0x000E9330 File Offset: 0x000E7530
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 222115, RefRangeEnd = 222116, XrefRangeStart = 222110, XrefRangeEnd = 222115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Builder()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadSessionRequest.Builder>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadSessionRequest.Builder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600398B RID: 14731 RVA: 0x000E936C File Offset: 0x000E756C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 222116, RefRangeEnd = 222117, XrefRangeStart = 222116, XrefRangeEnd = 222116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadSessionRequest.Builder SetTimeinterval(long startTime, long endTime, TimeUnit timeUnit)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref startTime;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endTime;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeUnit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadSessionRequest.Builder.NativeMethodInfoPtr_SetTimeinterval_Public_Builder_Int64_Int64_TimeUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadSessionRequest.Builder>(intPtr3) : null;
			}

			// Token: 0x0600398C RID: 14732 RVA: 0x000E93D4 File Offset: 0x000E75D4
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 222117, RefRangeEnd = 222121, XrefRangeStart = 222117, XrefRangeEnd = 222117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadSessionRequest.Builder SetIdentifier(string sessionId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(sessionId);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadSessionRequest.Builder.NativeMethodInfoPtr_SetIdentifier_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadSessionRequest.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x0600398D RID: 14733 RVA: 0x000E9424 File Offset: 0x000E7624
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 222121, RefRangeEnd = 222123, XrefRangeStart = 222121, XrefRangeEnd = 222121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadSessionRequest.Builder SetDataTypeToRead(DataType dataType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadSessionRequest.Builder.NativeMethodInfoPtr_SetDataTypeToRead_Public_Builder_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadSessionRequest.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x0600398E RID: 14734 RVA: 0x000E9474 File Offset: 0x000E7674
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadSessionRequest Build()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadSessionRequest.Builder.NativeMethodInfoPtr_Build_Public_ReadSessionRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadSessionRequest>(intPtr3) : null;
			}

			// Token: 0x0600398F RID: 14735 RVA: 0x00016423 File Offset: 0x00014623
			public Builder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DA1 RID: 3489
			// (get) Token: 0x06003990 RID: 14736 RVA: 0x000E94B4 File Offset: 0x000E76B4
			// (set) Token: 0x06003991 RID: 14737 RVA: 0x0001642C File Offset: 0x0001462C
			public unsafe ReadSessionRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadSessionRequest.Builder.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadSessionRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadSessionRequest.Builder.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040033A4 RID: 13220
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x040033A5 RID: 13221
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040033A6 RID: 13222
			private static readonly IntPtr NativeMethodInfoPtr_SetTimeinterval_Public_Builder_Int64_Int64_TimeUnit_0;

			// Token: 0x040033A7 RID: 13223
			private static readonly IntPtr NativeMethodInfoPtr_SetIdentifier_Public_Builder_String_0;

			// Token: 0x040033A8 RID: 13224
			private static readonly IntPtr NativeMethodInfoPtr_SetDataTypeToRead_Public_Builder_DataType_0;

			// Token: 0x040033A9 RID: 13225
			private static readonly IntPtr NativeMethodInfoPtr_Build_Public_ReadSessionRequest_0;
		}

		// Token: 0x020003E8 RID: 1000
		[ObfuscatedName("SA.Fitness.ReadSessionRequest+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003992 RID: 14738 RVA: 0x000E94E4 File Offset: 0x000E76E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ReadSessionRequest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReadSessionRequest>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadSessionRequest.__c>.NativeClassPtr);
				ReadSessionRequest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadSessionRequest.__c>.NativeClassPtr, "<>9");
				ReadSessionRequest.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadSessionRequest.__c>.NativeClassPtr, "<>9__9_0");
				ReadSessionRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadSessionRequest.__c>.NativeClassPtr, 100670558);
				ReadSessionRequest.__c.NativeMethodInfoPtr___ctor_b__9_0_Internal_Void_ReadSessionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadSessionRequest.__c>.NativeClassPtr, 100670559);
			}

			// Token: 0x06003993 RID: 14739 RVA: 0x000E9560 File Offset: 0x000E7760
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadSessionRequest.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadSessionRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003994 RID: 14740 RVA: 0x000E959C File Offset: 0x000E779C
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__9_0(ReadSessionResult <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadSessionRequest.__c.NativeMethodInfoPtr___ctor_b__9_0_Internal_Void_ReadSessionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003995 RID: 14741 RVA: 0x0001644B File Offset: 0x0001464B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DA2 RID: 3490
			// (get) Token: 0x06003996 RID: 14742 RVA: 0x000E95E0 File Offset: 0x000E77E0
			// (set) Token: 0x06003997 RID: 14743 RVA: 0x00016454 File Offset: 0x00014654
			public unsafe static ReadSessionRequest.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReadSessionRequest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadSessionRequest.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReadSessionRequest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DA3 RID: 3491
			// (get) Token: 0x06003998 RID: 14744 RVA: 0x000E9608 File Offset: 0x000E7808
			// (set) Token: 0x06003999 RID: 14745 RVA: 0x00016466 File Offset: 0x00014666
			public unsafe static Action<ReadSessionResult> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReadSessionRequest.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ReadSessionResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReadSessionRequest.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040033AA RID: 13226
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040033AB RID: 13227
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x040033AC RID: 13228
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040033AD RID: 13229
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__9_0_Internal_Void_ReadSessionResult_0;
		}
	}
}
