using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000257 RID: 599
	public sealed class CancellationTokenRegistration : ValueType
	{
		// Token: 0x06002995 RID: 10645 RVA: 0x000D7FC4 File Offset: 0x000D61C4
		// Note: this type is marked as 'beforefieldinit'.
		static CancellationTokenRegistration()
		{
			Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "CancellationTokenRegistration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr);
			CancellationTokenRegistration.NativeFieldInfoPtr_m_callbackInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, "m_callbackInfo");
			CancellationTokenRegistration.NativeFieldInfoPtr_m_registrationInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, "m_registrationInfo");
			CancellationTokenRegistration.NativeMethodInfoPtr__ctor_Internal_Void_CancellationCallbackInfo_SparselyPopulatedArrayAddInfo_1_CancellationCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, 100669939);
			CancellationTokenRegistration.NativeMethodInfoPtr_TryDeregister_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, 100669940);
			CancellationTokenRegistration.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, 100669941);
			CancellationTokenRegistration.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, 100669942);
			CancellationTokenRegistration.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CancellationTokenRegistration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, 100669943);
			CancellationTokenRegistration.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, 100669944);
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x000D8094 File Offset: 0x000D6294
		[CallerCount(0)]
		public unsafe CancellationTokenRegistration(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callbackInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(registrationInfo));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenRegistration.NativeMethodInfoPtr__ctor_Internal_Void_CancellationCallbackInfo_SparselyPopulatedArrayAddInfo_1_CancellationCallbackInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x000D80FC File Offset: 0x000D62FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330195, RefRangeEnd = 330196, XrefRangeStart = 330190, XrefRangeEnd = 330195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryDeregister()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenRegistration.NativeMethodInfoPtr_TryDeregister_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x000D8140 File Offset: 0x000D6340
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 330205, RefRangeEnd = 330213, XrefRangeStart = 330196, XrefRangeEnd = 330205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenRegistration.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x000D8178 File Offset: 0x000D6378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330213, XrefRangeEnd = 330218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenRegistration.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x000D81CC File Offset: 0x000D63CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330218, XrefRangeEnd = 330220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(CancellationTokenRegistration other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenRegistration.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CancellationTokenRegistration_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x000D8224 File Offset: 0x000D6424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330220, XrefRangeEnd = 330223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenRegistration.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x0000E755 File Offset: 0x0000C955
		public CancellationTokenRegistration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x0000E75E File Offset: 0x0000C95E
		public CancellationTokenRegistration()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr))
		{
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x0600299E RID: 10654 RVA: 0x000D8268 File Offset: 0x000D6468
		// (set) Token: 0x0600299F RID: 10655 RVA: 0x0000E770 File Offset: 0x0000C970
		public unsafe CancellationCallbackInfo m_callbackInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenRegistration.NativeFieldInfoPtr_m_callbackInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationCallbackInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenRegistration.NativeFieldInfoPtr_m_callbackInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x060029A0 RID: 10656 RVA: 0x000D8298 File Offset: 0x000D6498
		// (set) Token: 0x060029A1 RID: 10657 RVA: 0x0000E78F File Offset: 0x0000C98F
		public SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenRegistration.NativeFieldInfoPtr_m_registrationInfo);
				return new SparselyPopulatedArrayAddInfo<CancellationCallbackInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<CancellationCallbackInfo>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenRegistration.NativeFieldInfoPtr_m_registrationInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<CancellationCallbackInfo>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040024A0 RID: 9376
		private static readonly IntPtr NativeFieldInfoPtr_m_callbackInfo;

		// Token: 0x040024A1 RID: 9377
		private static readonly IntPtr NativeFieldInfoPtr_m_registrationInfo;

		// Token: 0x040024A2 RID: 9378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CancellationCallbackInfo_SparselyPopulatedArrayAddInfo_1_CancellationCallbackInfo_0;

		// Token: 0x040024A3 RID: 9379
		private static readonly IntPtr NativeMethodInfoPtr_TryDeregister_Internal_Boolean_0;

		// Token: 0x040024A4 RID: 9380
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040024A5 RID: 9381
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040024A6 RID: 9382
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CancellationTokenRegistration_0;

		// Token: 0x040024A7 RID: 9383
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
