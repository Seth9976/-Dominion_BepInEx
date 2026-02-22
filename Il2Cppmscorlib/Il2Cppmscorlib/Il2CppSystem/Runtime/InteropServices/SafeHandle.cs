using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.ConstrainedExecution;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000456 RID: 1110
	public class SafeHandle : CriticalFinalizerObject
	{
		// Token: 0x06004308 RID: 17160 RVA: 0x00133760 File Offset: 0x00131960
		// Note: this type is marked as 'beforefieldinit'.
		static SafeHandle()
		{
			Il2CppClassPointerStore<SafeHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "SafeHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr);
			SafeHandle.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, "handle");
			SafeHandle.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, "_state");
			SafeHandle.NativeFieldInfoPtr__ownsHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, "_ownsHandle");
			SafeHandle.NativeFieldInfoPtr__fullyInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, "_fullyInitialized");
			SafeHandle.NativeFieldInfoPtr_RefCount_Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, "RefCount_Mask");
			SafeHandle.NativeFieldInfoPtr_RefCount_One = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, "RefCount_One");
			SafeHandle.NativeMethodInfoPtr__ctor_Protected_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100672996);
			SafeHandle.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100672997);
			SafeHandle.NativeMethodInfoPtr_SetHandle_Protected_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100672998);
			SafeHandle.NativeMethodInfoPtr_DangerousGetHandle_Public_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100672999);
			SafeHandle.NativeMethodInfoPtr_get_IsClosed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673000);
			SafeHandle.NativeMethodInfoPtr_get_IsInvalid_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673001);
			SafeHandle.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673002);
			SafeHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673003);
			SafeHandle.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673004);
			SafeHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673005);
			SafeHandle.NativeMethodInfoPtr_SetHandleAsInvalid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673006);
			SafeHandle.NativeMethodInfoPtr_DangerousAddRef_Public_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673007);
			SafeHandle.NativeMethodInfoPtr_DangerousRelease_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673008);
			SafeHandle.NativeMethodInfoPtr_InternalDispose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673009);
			SafeHandle.NativeMethodInfoPtr_InternalFinalize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673010);
			SafeHandle.NativeMethodInfoPtr_DangerousReleaseInternal_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673011);
		}

		// Token: 0x06004309 RID: 17161 RVA: 0x00133948 File Offset: 0x00131B48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 357510, RefRangeEnd = 357511, XrefRangeStart = 357505, XrefRangeEnd = 357510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeHandle(IntPtr invalidHandleValue, bool ownsHandle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref invalidHandleValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr__ctor_Protected_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600430A RID: 17162 RVA: 0x001339A0 File Offset: 0x00131BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357511, XrefRangeEnd = 357514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeHandle.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600430B RID: 17163 RVA: 0x001339DC File Offset: 0x00131BDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHandle(IntPtr handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_SetHandle_Protected_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600430C RID: 17164 RVA: 0x00133A1C File Offset: 0x00131C1C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr DangerousGetHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_DangerousGetHandle_Public_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x0600430D RID: 17165 RVA: 0x00133A58 File Offset: 0x00131C58
		public unsafe bool IsClosed
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 357514, RefRangeEnd = 357526, XrefRangeStart = 357514, XrefRangeEnd = 357514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_get_IsClosed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x0600430E RID: 17166 RVA: 0x00133A94 File Offset: 0x00131C94
		public unsafe virtual bool IsInvalid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeHandle.NativeMethodInfoPtr_get_IsInvalid_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600430F RID: 17167 RVA: 0x00133ADC File Offset: 0x00131CDC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 316583, RefRangeEnd = 316593, XrefRangeStart = 316583, XrefRangeEnd = 316593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004310 RID: 17168 RVA: 0x00133B10 File Offset: 0x00131D10
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 316583, RefRangeEnd = 316593, XrefRangeStart = 316583, XrefRangeEnd = 316593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004311 RID: 17169 RVA: 0x00133B44 File Offset: 0x00131D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357526, XrefRangeEnd = 357527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeHandle.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004312 RID: 17170 RVA: 0x00133B90 File Offset: 0x00131D90
		[CallerCount(0)]
		public unsafe virtual bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x00133BD8 File Offset: 0x00131DD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 357533, RefRangeEnd = 357534, XrefRangeStart = 357527, XrefRangeEnd = 357533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHandleAsInvalid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_SetHandleAsInvalid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x00133C0C File Offset: 0x00131E0C
		[CallerCount(264)]
		[CachedScanResults(RefRangeStart = 357536, RefRangeEnd = 357800, XrefRangeStart = 357534, XrefRangeEnd = 357536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DangerousAddRef(ref bool success)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &success;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_DangerousAddRef_Public_Void_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004315 RID: 17173 RVA: 0x00133C4C File Offset: 0x00131E4C
		[CallerCount(264)]
		[CachedScanResults(RefRangeStart = 357801, RefRangeEnd = 358065, XrefRangeStart = 357800, XrefRangeEnd = 357801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DangerousRelease()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_DangerousRelease_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004316 RID: 17174 RVA: 0x00133C80 File Offset: 0x00131E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358065, XrefRangeEnd = 358075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalDispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_InternalDispose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x00133CB4 File Offset: 0x00131EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358075, XrefRangeEnd = 358076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalFinalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_InternalFinalize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x00133CE8 File Offset: 0x00131EE8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 358080, RefRangeEnd = 358085, XrefRangeStart = 358076, XrefRangeEnd = 358080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DangerousReleaseInternal(bool dispose)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dispose;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_DangerousReleaseInternal_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004319 RID: 17177 RVA: 0x00019BE2 File Offset: 0x00017DE2
		public SafeHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x0600431A RID: 17178 RVA: 0x00133D28 File Offset: 0x00131F28
		// (set) Token: 0x0600431B RID: 17179 RVA: 0x00019BEB File Offset: 0x00017DEB
		public unsafe IntPtr handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr_handle)) = value;
			}
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x0600431C RID: 17180 RVA: 0x00133D50 File Offset: 0x00131F50
		// (set) Token: 0x0600431D RID: 17181 RVA: 0x00019C06 File Offset: 0x00017E06
		public unsafe int _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr__state)) = value;
			}
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x0600431E RID: 17182 RVA: 0x00133D78 File Offset: 0x00131F78
		// (set) Token: 0x0600431F RID: 17183 RVA: 0x00019C21 File Offset: 0x00017E21
		public unsafe bool _ownsHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr__ownsHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr__ownsHandle)) = value;
			}
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x06004320 RID: 17184 RVA: 0x00133DA0 File Offset: 0x00131FA0
		// (set) Token: 0x06004321 RID: 17185 RVA: 0x00019C3C File Offset: 0x00017E3C
		public unsafe bool _fullyInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr__fullyInitialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr__fullyInitialized)) = value;
			}
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x06004322 RID: 17186 RVA: 0x00133DC8 File Offset: 0x00131FC8
		// (set) Token: 0x06004323 RID: 17187 RVA: 0x00019C57 File Offset: 0x00017E57
		public unsafe static int RefCount_Mask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SafeHandle.NativeFieldInfoPtr_RefCount_Mask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeHandle.NativeFieldInfoPtr_RefCount_Mask, (void*)(&value));
			}
		}

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x06004324 RID: 17188 RVA: 0x00133DE4 File Offset: 0x00131FE4
		// (set) Token: 0x06004325 RID: 17189 RVA: 0x00019C65 File Offset: 0x00017E65
		public unsafe static int RefCount_One
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SafeHandle.NativeFieldInfoPtr_RefCount_One, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeHandle.NativeFieldInfoPtr_RefCount_One, (void*)(&value));
			}
		}

		// Token: 0x040036BC RID: 14012
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x040036BD RID: 14013
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x040036BE RID: 14014
		private static readonly IntPtr NativeFieldInfoPtr__ownsHandle;

		// Token: 0x040036BF RID: 14015
		private static readonly IntPtr NativeFieldInfoPtr__fullyInitialized;

		// Token: 0x040036C0 RID: 14016
		private static readonly IntPtr NativeFieldInfoPtr_RefCount_Mask;

		// Token: 0x040036C1 RID: 14017
		private static readonly IntPtr NativeFieldInfoPtr_RefCount_One;

		// Token: 0x040036C2 RID: 14018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IntPtr_Boolean_0;

		// Token: 0x040036C3 RID: 14019
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040036C4 RID: 14020
		private static readonly IntPtr NativeMethodInfoPtr_SetHandle_Protected_Void_IntPtr_0;

		// Token: 0x040036C5 RID: 14021
		private static readonly IntPtr NativeMethodInfoPtr_DangerousGetHandle_Public_IntPtr_0;

		// Token: 0x040036C6 RID: 14022
		private static readonly IntPtr NativeMethodInfoPtr_get_IsClosed_Public_get_Boolean_0;

		// Token: 0x040036C7 RID: 14023
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInvalid_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040036C8 RID: 14024
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040036C9 RID: 14025
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040036CA RID: 14026
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040036CB RID: 14027
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040036CC RID: 14028
		private static readonly IntPtr NativeMethodInfoPtr_SetHandleAsInvalid_Public_Void_0;

		// Token: 0x040036CD RID: 14029
		private static readonly IntPtr NativeMethodInfoPtr_DangerousAddRef_Public_Void_byref_Boolean_0;

		// Token: 0x040036CE RID: 14030
		private static readonly IntPtr NativeMethodInfoPtr_DangerousRelease_Public_Void_0;

		// Token: 0x040036CF RID: 14031
		private static readonly IntPtr NativeMethodInfoPtr_InternalDispose_Private_Void_0;

		// Token: 0x040036D0 RID: 14032
		private static readonly IntPtr NativeMethodInfoPtr_InternalFinalize_Private_Void_0;

		// Token: 0x040036D1 RID: 14033
		private static readonly IntPtr NativeMethodInfoPtr_DangerousReleaseInternal_Private_Void_Boolean_0;
	}
}
