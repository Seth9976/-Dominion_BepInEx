using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000060 RID: 96
	public sealed class LocalDataStoreHolder : Object
	{
		// Token: 0x0600065E RID: 1630 RVA: 0x0003EF38 File Offset: 0x0003D138
		// Note: this type is marked as 'beforefieldinit'.
		static LocalDataStoreHolder()
		{
			Il2CppClassPointerStore<LocalDataStoreHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "LocalDataStoreHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalDataStoreHolder>.NativeClassPtr);
			LocalDataStoreHolder.NativeFieldInfoPtr_m_Store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreHolder>.NativeClassPtr, "m_Store");
			LocalDataStoreHolder.NativeMethodInfoPtr__ctor_Public_Void_LocalDataStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreHolder>.NativeClassPtr, 100664323);
			LocalDataStoreHolder.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreHolder>.NativeClassPtr, 100664324);
			LocalDataStoreHolder.NativeMethodInfoPtr_get_Store_Public_get_LocalDataStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreHolder>.NativeClassPtr, 100664325);
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0003EFB8 File Offset: 0x0003D1B8
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreHolder(LocalDataStore store)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalDataStoreHolder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreHolder.NativeMethodInfoPtr__ctor_Public_Void_LocalDataStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0003F004 File Offset: 0x0003D204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275331, XrefRangeEnd = 275336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreHolder.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x0003F038 File Offset: 0x0003D238
		public unsafe LocalDataStore Store
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreHolder.NativeMethodInfoPtr_get_Store_Public_get_LocalDataStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStore>(intPtr3) : null;
			}
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0000404F File Offset: 0x0000224F
		public LocalDataStoreHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x0003F078 File Offset: 0x0003D278
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x00004058 File Offset: 0x00002258
		public unsafe LocalDataStore m_Store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreHolder.NativeFieldInfoPtr_m_Store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataStore>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreHolder.NativeFieldInfoPtr_m_Store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeFieldInfoPtr_m_Store;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LocalDataStore_0;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeMethodInfoPtr_get_Store_Public_get_LocalDataStore_0;
	}
}
