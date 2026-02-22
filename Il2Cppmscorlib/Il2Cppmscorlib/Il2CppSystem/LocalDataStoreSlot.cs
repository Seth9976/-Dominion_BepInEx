using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000063 RID: 99
	public sealed class LocalDataStoreSlot : Object
	{
		// Token: 0x0600067B RID: 1659 RVA: 0x0003F5B0 File Offset: 0x0003D7B0
		// Note: this type is marked as 'beforefieldinit'.
		static LocalDataStoreSlot()
		{
			Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "LocalDataStoreSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr);
			LocalDataStoreSlot.NativeFieldInfoPtr_m_mgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr, "m_mgr");
			LocalDataStoreSlot.NativeFieldInfoPtr_m_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr, "m_slot");
			LocalDataStoreSlot.NativeFieldInfoPtr_m_cookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr, "m_cookie");
			LocalDataStoreSlot.NativeMethodInfoPtr__ctor_Internal_Void_LocalDataStoreMgr_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr, 100664336);
			LocalDataStoreSlot.NativeMethodInfoPtr_get_Manager_Internal_get_LocalDataStoreMgr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr, 100664337);
			LocalDataStoreSlot.NativeMethodInfoPtr_get_Slot_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr, 100664338);
			LocalDataStoreSlot.NativeMethodInfoPtr_get_Cookie_Internal_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr, 100664339);
			LocalDataStoreSlot.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr, 100664340);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0003F680 File Offset: 0x0003D880
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 16496, RefRangeEnd = 16509, XrefRangeStart = 16496, XrefRangeEnd = 16509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreSlot(LocalDataStoreMgr mgr, int slot, long cookie)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreSlot.NativeMethodInfoPtr__ctor_Internal_Void_LocalDataStoreMgr_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x0003F6E8 File Offset: 0x0003D8E8
		public unsafe LocalDataStoreMgr Manager
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreSlot.NativeMethodInfoPtr_get_Manager_Internal_get_LocalDataStoreMgr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreMgr>(intPtr3) : null;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x0003F728 File Offset: 0x0003D928
		public unsafe int Slot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreSlot.NativeMethodInfoPtr_get_Slot_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x0003F764 File Offset: 0x0003D964
		public unsafe long Cookie
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreSlot.NativeMethodInfoPtr_get_Cookie_Internal_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0003F7A0 File Offset: 0x0003D9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275359, XrefRangeEnd = 275364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreSlot.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00004101 File Offset: 0x00002301
		public LocalDataStoreSlot(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x0003F7D4 File Offset: 0x0003D9D4
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x0000410A File Offset: 0x0000230A
		public unsafe LocalDataStoreMgr m_mgr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreSlot.NativeFieldInfoPtr_m_mgr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataStoreMgr>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreSlot.NativeFieldInfoPtr_m_mgr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x0003F804 File Offset: 0x0003DA04
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x00004129 File Offset: 0x00002329
		public unsafe int m_slot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreSlot.NativeFieldInfoPtr_m_slot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreSlot.NativeFieldInfoPtr_m_slot)) = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x0003F82C File Offset: 0x0003DA2C
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x00004144 File Offset: 0x00002344
		public unsafe long m_cookie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreSlot.NativeFieldInfoPtr_m_cookie);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreSlot.NativeFieldInfoPtr_m_cookie)) = value;
			}
		}

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeFieldInfoPtr_m_mgr;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeFieldInfoPtr_m_slot;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeFieldInfoPtr_m_cookie;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_LocalDataStoreMgr_Int32_Int64_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_get_Manager_Internal_get_LocalDataStoreMgr_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr_get_Slot_Internal_get_Int32_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr_get_Cookie_Internal_get_Int64_0;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}
