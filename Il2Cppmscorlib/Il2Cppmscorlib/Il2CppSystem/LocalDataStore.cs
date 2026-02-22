using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000062 RID: 98
	public sealed class LocalDataStore : Object
	{
		// Token: 0x0600066F RID: 1647 RVA: 0x0003F2B0 File Offset: 0x0003D4B0
		// Note: this type is marked as 'beforefieldinit'.
		static LocalDataStore()
		{
			Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "LocalDataStore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr);
			LocalDataStore.NativeFieldInfoPtr_m_DataTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, "m_DataTable");
			LocalDataStore.NativeFieldInfoPtr_m_Manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, "m_Manager");
			LocalDataStore.NativeMethodInfoPtr__ctor_Public_Void_LocalDataStoreMgr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, 100664330);
			LocalDataStore.NativeMethodInfoPtr_Dispose_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, 100664331);
			LocalDataStore.NativeMethodInfoPtr_GetData_Public_Object_LocalDataStoreSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, 100664332);
			LocalDataStore.NativeMethodInfoPtr_SetData_Public_Void_LocalDataStoreSlot_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, 100664333);
			LocalDataStore.NativeMethodInfoPtr_FreeData_Internal_Void_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, 100664334);
			LocalDataStore.NativeMethodInfoPtr_PopulateElement_Private_LocalDataStoreElement_LocalDataStoreSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, 100664335);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0003F380 File Offset: 0x0003D580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275336, XrefRangeEnd = 275340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStore(LocalDataStoreMgr mgr, int InitialCapacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref InitialCapacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStore.NativeMethodInfoPtr__ctor_Public_Void_LocalDataStoreMgr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0003F3DC File Offset: 0x0003D5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275340, XrefRangeEnd = 275342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStore.NativeMethodInfoPtr_Dispose_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0003F410 File Offset: 0x0003D610
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275342, RefRangeEnd = 275343, XrefRangeStart = 275342, XrefRangeEnd = 275342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetData(LocalDataStoreSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStore.NativeMethodInfoPtr_GetData_Public_Object_LocalDataStoreSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0003F460 File Offset: 0x0003D660
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275344, RefRangeEnd = 275345, XrefRangeStart = 275343, XrefRangeEnd = 275344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(LocalDataStoreSlot slot, Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStore.NativeMethodInfoPtr_SetData_Public_Void_LocalDataStoreSlot_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0003F4B4 File Offset: 0x0003D6B4
		[CallerCount(0)]
		public unsafe void FreeData(int slot, long cookie)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStore.NativeMethodInfoPtr_FreeData_Internal_Void_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0003F500 File Offset: 0x0003D700
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275358, RefRangeEnd = 275359, XrefRangeStart = 275345, XrefRangeEnd = 275358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreElement PopulateElement(LocalDataStoreSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStore.NativeMethodInfoPtr_PopulateElement_Private_LocalDataStoreElement_LocalDataStoreSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreElement>(intPtr3) : null;
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x000040BA File Offset: 0x000022BA
		public LocalDataStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x0003F550 File Offset: 0x0003D750
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x000040C3 File Offset: 0x000022C3
		public unsafe Il2CppReferenceArray<LocalDataStoreElement> m_DataTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStore.NativeFieldInfoPtr_m_DataTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocalDataStoreElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStore.NativeFieldInfoPtr_m_DataTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x0003F580 File Offset: 0x0003D780
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x000040E2 File Offset: 0x000022E2
		public unsafe LocalDataStoreMgr m_Manager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStore.NativeFieldInfoPtr_m_Manager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataStoreMgr>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStore.NativeFieldInfoPtr_m_Manager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeFieldInfoPtr_m_DataTable;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeFieldInfoPtr_m_Manager;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LocalDataStoreMgr_Int32_0;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Internal_Void_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Object_LocalDataStoreSlot_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_LocalDataStoreSlot_Object_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_FreeData_Internal_Void_Int32_Int64_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr_PopulateElement_Private_LocalDataStoreElement_LocalDataStoreSlot_0;
	}
}
