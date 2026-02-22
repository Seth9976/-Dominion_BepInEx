using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.ExceptionServices;

namespace Il2CppMono.Net.Security
{
	// Token: 0x0200001C RID: 28
	public class AsyncProtocolResult : Object
	{
		// Token: 0x06000133 RID: 307 RVA: 0x0001502C File Offset: 0x0001322C
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncProtocolResult()
		{
			Il2CppClassPointerStore<AsyncProtocolResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "AsyncProtocolResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncProtocolResult>.NativeClassPtr);
			AsyncProtocolResult.NativeFieldInfoPtr__UserResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolResult>.NativeClassPtr, "<UserResult>k__BackingField");
			AsyncProtocolResult.NativeFieldInfoPtr__Error_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolResult>.NativeClassPtr, "<Error>k__BackingField");
			AsyncProtocolResult.NativeMethodInfoPtr_get_UserResult_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolResult>.NativeClassPtr, 100663531);
			AsyncProtocolResult.NativeMethodInfoPtr_get_Error_Public_get_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolResult>.NativeClassPtr, 100663532);
			AsyncProtocolResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolResult>.NativeClassPtr, 100663533);
			AsyncProtocolResult.NativeMethodInfoPtr__ctor_Public_Void_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolResult>.NativeClassPtr, 100663534);
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000134 RID: 308 RVA: 0x000150D4 File Offset: 0x000132D4
		public unsafe int UserResult
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolResult.NativeMethodInfoPtr_get_UserResult_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00015110 File Offset: 0x00013310
		public unsafe ExceptionDispatchInfo Error
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolResult.NativeMethodInfoPtr_get_Error_Public_get_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00015150 File Offset: 0x00013350
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncProtocolResult(int result)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncProtocolResult>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00015198 File Offset: 0x00013398
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 33270, RefRangeEnd = 33281, XrefRangeStart = 33269, XrefRangeEnd = 33270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncProtocolResult(ExceptionDispatchInfo error)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncProtocolResult>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolResult.NativeMethodInfoPtr__ctor_Public_Void_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002695 File Offset: 0x00000895
		public AsyncProtocolResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000139 RID: 313 RVA: 0x000151E4 File Offset: 0x000133E4
		// (set) Token: 0x0600013A RID: 314 RVA: 0x0000269E File Offset: 0x0000089E
		public unsafe int _UserResult_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolResult.NativeFieldInfoPtr__UserResult_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolResult.NativeFieldInfoPtr__UserResult_k__BackingField)) = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0001520C File Offset: 0x0001340C
		// (set) Token: 0x0600013C RID: 316 RVA: 0x000026B9 File Offset: 0x000008B9
		public unsafe ExceptionDispatchInfo _Error_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolResult.NativeFieldInfoPtr__Error_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolResult.NativeFieldInfoPtr__Error_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr__UserResult_k__BackingField;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeFieldInfoPtr__Error_k__BackingField;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_get_UserResult_Public_get_Int32_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_ExceptionDispatchInfo_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ExceptionDispatchInfo_0;
	}
}
