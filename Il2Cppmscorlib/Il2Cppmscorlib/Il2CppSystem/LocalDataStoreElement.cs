using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000061 RID: 97
	public sealed class LocalDataStoreElement : Object
	{
		// Token: 0x06000665 RID: 1637 RVA: 0x0003F0A8 File Offset: 0x0003D2A8
		// Note: this type is marked as 'beforefieldinit'.
		static LocalDataStoreElement()
		{
			Il2CppClassPointerStore<LocalDataStoreElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "LocalDataStoreElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalDataStoreElement>.NativeClassPtr);
			LocalDataStoreElement.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreElement>.NativeClassPtr, "m_value");
			LocalDataStoreElement.NativeFieldInfoPtr_m_cookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreElement>.NativeClassPtr, "m_cookie");
			LocalDataStoreElement.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreElement>.NativeClassPtr, 100664326);
			LocalDataStoreElement.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreElement>.NativeClassPtr, 100664327);
			LocalDataStoreElement.NativeMethodInfoPtr_set_Value_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreElement>.NativeClassPtr, 100664328);
			LocalDataStoreElement.NativeMethodInfoPtr_get_Cookie_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreElement>.NativeClassPtr, 100664329);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0003F150 File Offset: 0x0003D350
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 33270, RefRangeEnd = 33281, XrefRangeStart = 33270, XrefRangeEnd = 33281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreElement(long cookie)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalDataStoreElement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cookie;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreElement.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x0003F198 File Offset: 0x0003D398
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x0003F1D8 File Offset: 0x0003D3D8
		public unsafe Object Value
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreElement.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreElement.NativeMethodInfoPtr_set_Value_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x0003F21C File Offset: 0x0003D41C
		public unsafe long Cookie
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreElement.NativeMethodInfoPtr_get_Cookie_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00004077 File Offset: 0x00002277
		public LocalDataStoreElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x0003F258 File Offset: 0x0003D458
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x00004080 File Offset: 0x00002280
		public unsafe Object m_value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreElement.NativeFieldInfoPtr_m_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreElement.NativeFieldInfoPtr_m_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x0003F288 File Offset: 0x0003D488
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x0000409F File Offset: 0x0000229F
		public unsafe long m_cookie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreElement.NativeFieldInfoPtr_m_cookie);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreElement.NativeFieldInfoPtr_m_cookie)) = value;
			}
		}

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeFieldInfoPtr_m_cookie;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Object_0;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeMethodInfoPtr_get_Cookie_Public_get_Int64_0;
	}
}
