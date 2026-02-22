using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem
{
	// Token: 0x02000064 RID: 100
	public sealed class LocalDataStoreMgr : Object
	{
		// Token: 0x06000688 RID: 1672 RVA: 0x0003F854 File Offset: 0x0003DA54
		// Note: this type is marked as 'beforefieldinit'.
		static LocalDataStoreMgr()
		{
			Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "LocalDataStoreMgr");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr);
			LocalDataStoreMgr.NativeFieldInfoPtr_m_SlotInfoTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "m_SlotInfoTable");
			LocalDataStoreMgr.NativeFieldInfoPtr_m_FirstAvailableSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "m_FirstAvailableSlot");
			LocalDataStoreMgr.NativeFieldInfoPtr_m_ManagedLocalDataStores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "m_ManagedLocalDataStores");
			LocalDataStoreMgr.NativeFieldInfoPtr_m_KeyToSlotMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "m_KeyToSlotMap");
			LocalDataStoreMgr.NativeFieldInfoPtr_m_CookieGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "m_CookieGenerator");
			LocalDataStoreMgr.NativeMethodInfoPtr_CreateLocalDataStore_Public_LocalDataStoreHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100664341);
			LocalDataStoreMgr.NativeMethodInfoPtr_DeleteLocalDataStore_Public_Void_LocalDataStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100664342);
			LocalDataStoreMgr.NativeMethodInfoPtr_AllocateDataSlot_Public_LocalDataStoreSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100664343);
			LocalDataStoreMgr.NativeMethodInfoPtr_AllocateNamedDataSlot_Public_LocalDataStoreSlot_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100664344);
			LocalDataStoreMgr.NativeMethodInfoPtr_GetNamedDataSlot_Public_LocalDataStoreSlot_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100664345);
			LocalDataStoreMgr.NativeMethodInfoPtr_FreeNamedDataSlot_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100664346);
			LocalDataStoreMgr.NativeMethodInfoPtr_FreeDataSlot_Internal_Void_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100664347);
			LocalDataStoreMgr.NativeMethodInfoPtr_ValidateSlot_Public_Void_LocalDataStoreSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100664348);
			LocalDataStoreMgr.NativeMethodInfoPtr_GetSlotTableLength_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100664349);
			LocalDataStoreMgr.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100664350);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0003F9B0 File Offset: 0x0003DBB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275382, RefRangeEnd = 275383, XrefRangeStart = 275364, XrefRangeEnd = 275382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreHolder CreateLocalDataStore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_CreateLocalDataStore_Public_LocalDataStoreHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreHolder>(intPtr3) : null;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0003F9F0 File Offset: 0x0003DBF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275390, RefRangeEnd = 275392, XrefRangeStart = 275383, XrefRangeEnd = 275390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteLocalDataStore(LocalDataStore store)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_DeleteLocalDataStore_Public_Void_LocalDataStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0003FA34 File Offset: 0x0003DC34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275406, RefRangeEnd = 275408, XrefRangeStart = 275392, XrefRangeEnd = 275406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreSlot AllocateDataSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_AllocateDataSlot_Public_LocalDataStoreSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreSlot>(intPtr3) : null;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0003FA74 File Offset: 0x0003DC74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275416, RefRangeEnd = 275418, XrefRangeStart = 275408, XrefRangeEnd = 275416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreSlot AllocateNamedDataSlot(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_AllocateNamedDataSlot_Public_LocalDataStoreSlot_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreSlot>(intPtr3) : null;
			}
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0003FAC4 File Offset: 0x0003DCC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275427, RefRangeEnd = 275428, XrefRangeStart = 275418, XrefRangeEnd = 275427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreSlot GetNamedDataSlot(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_GetNamedDataSlot_Public_LocalDataStoreSlot_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreSlot>(intPtr3) : null;
			}
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0003FB14 File Offset: 0x0003DD14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275435, RefRangeEnd = 275436, XrefRangeStart = 275428, XrefRangeEnd = 275435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeNamedDataSlot(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_FreeNamedDataSlot_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0003FB58 File Offset: 0x0003DD58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275444, RefRangeEnd = 275445, XrefRangeStart = 275436, XrefRangeEnd = 275444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeDataSlot(int slot, long cookie)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref slot;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_FreeDataSlot_Internal_Void_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0003FBA4 File Offset: 0x0003DDA4
		[CallerCount(0)]
		public unsafe void ValidateSlot(LocalDataStoreSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_ValidateSlot_Public_Void_LocalDataStoreSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0003FBE8 File Offset: 0x0003DDE8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 275445, RefRangeEnd = 275457, XrefRangeStart = 275445, XrefRangeEnd = 275445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSlotTableLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_GetSlotTableLength_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0003FC24 File Offset: 0x0003DE24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275473, RefRangeEnd = 275474, XrefRangeStart = 275457, XrefRangeEnd = 275473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreMgr()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0000415F File Offset: 0x0000235F
		public LocalDataStoreMgr(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x0003FC60 File Offset: 0x0003DE60
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x00004168 File Offset: 0x00002368
		public unsafe Il2CppStructArray<bool> m_SlotInfoTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_SlotInfoTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_SlotInfoTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x0003FC90 File Offset: 0x0003DE90
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x00004187 File Offset: 0x00002387
		public unsafe int m_FirstAvailableSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_FirstAvailableSlot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_FirstAvailableSlot)) = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x0003FCB8 File Offset: 0x0003DEB8
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x000041A2 File Offset: 0x000023A2
		public unsafe List<LocalDataStore> m_ManagedLocalDataStores
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_ManagedLocalDataStores);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LocalDataStore>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_ManagedLocalDataStores), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x0003FCE8 File Offset: 0x0003DEE8
		// (set) Token: 0x0600069B RID: 1691 RVA: 0x000041C1 File Offset: 0x000023C1
		public unsafe Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_KeyToSlotMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, LocalDataStoreSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_KeyToSlotMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x0003FD18 File Offset: 0x0003DF18
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x000041E0 File Offset: 0x000023E0
		public unsafe long m_CookieGenerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_CookieGenerator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_CookieGenerator)) = value;
			}
		}

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeFieldInfoPtr_m_SlotInfoTable;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstAvailableSlot;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeFieldInfoPtr_m_ManagedLocalDataStores;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeFieldInfoPtr_m_KeyToSlotMap;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeFieldInfoPtr_m_CookieGenerator;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr_CreateLocalDataStore_Public_LocalDataStoreHolder_0;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_DeleteLocalDataStore_Public_Void_LocalDataStore_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr_AllocateDataSlot_Public_LocalDataStoreSlot_0;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr_AllocateNamedDataSlot_Public_LocalDataStoreSlot_String_0;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_GetNamedDataSlot_Public_LocalDataStoreSlot_String_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_FreeNamedDataSlot_Public_Void_String_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_FreeDataSlot_Internal_Void_Int32_Int64_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_ValidateSlot_Public_Void_LocalDataStoreSlot_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_GetSlotTableLength_Internal_Int32_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
