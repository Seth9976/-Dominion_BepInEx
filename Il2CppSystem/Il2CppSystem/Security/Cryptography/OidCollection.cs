using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200007B RID: 123
	public sealed class OidCollection : Object
	{
		// Token: 0x060007E5 RID: 2021 RVA: 0x0002D5E8 File Offset: 0x0002B7E8
		// Note: this type is marked as 'beforefieldinit'.
		static OidCollection()
		{
			Il2CppClassPointerStore<OidCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography", "OidCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OidCollection>.NativeClassPtr);
			OidCollection.NativeFieldInfoPtr_m_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OidCollection>.NativeClassPtr, "m_list");
			OidCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidCollection>.NativeClassPtr, 100664316);
			OidCollection.NativeMethodInfoPtr_Add_Public_Int32_Oid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidCollection>.NativeClassPtr, 100664317);
			OidCollection.NativeMethodInfoPtr_get_Item_Public_get_Oid_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidCollection>.NativeClassPtr, 100664318);
			OidCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidCollection>.NativeClassPtr, 100664319);
			OidCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidCollection>.NativeClassPtr, 100664320);
			OidCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidCollection>.NativeClassPtr, 100664321);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0002D6A4 File Offset: 0x0002B8A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 41398, RefRangeEnd = 41401, XrefRangeStart = 41393, XrefRangeEnd = 41398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OidCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OidCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0002D6E0 File Offset: 0x0002B8E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 41402, RefRangeEnd = 41405, XrefRangeStart = 41401, XrefRangeEnd = 41402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Add(Oid oid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidCollection.NativeMethodInfoPtr_Add_Public_Int32_Oid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700025E RID: 606
		public unsafe Oid this[int index]
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 41406, RefRangeEnd = 41408, XrefRangeStart = 41405, XrefRangeEnd = 41406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidCollection.NativeMethodInfoPtr_get_Item_Public_get_Oid_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Oid>(intPtr3) : null;
				}
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x0002D77C File Offset: 0x0002B97C
		public unsafe int Count
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 12038, RefRangeEnd = 12046, XrefRangeStart = 12038, XrefRangeEnd = 12046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0002D7B8 File Offset: 0x0002B9B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41408, XrefRangeEnd = 41412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0002D7F8 File Offset: 0x0002B9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41412, XrefRangeEnd = 41419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_ICollection_CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x000053AC File Offset: 0x000035AC
		public OidCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x0002D848 File Offset: 0x0002BA48
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x000053B5 File Offset: 0x000035B5
		public unsafe ArrayList m_list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OidCollection.NativeFieldInfoPtr_m_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OidCollection.NativeFieldInfoPtr_m_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeFieldInfoPtr_m_list;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_Oid_0;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Oid_Int32_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;
	}
}
