using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x02000093 RID: 147
	public sealed class X509ChainElementCollection : Object
	{
		// Token: 0x060008C4 RID: 2244 RVA: 0x00030C84 File Offset: 0x0002EE84
		// Note: this type is marked as 'beforefieldinit'.
		static X509ChainElementCollection()
		{
			Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509ChainElementCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr);
			X509ChainElementCollection.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr, "_list");
			X509ChainElementCollection.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr, 100664447);
			X509ChainElementCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr, 100664448);
			X509ChainElementCollection.NativeMethodInfoPtr_get_Item_Public_get_X509ChainElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr, 100664449);
			X509ChainElementCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr, 100664450);
			X509ChainElementCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr, 100664451);
			X509ChainElementCollection.NativeMethodInfoPtr_Add_Internal_Void_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr, 100664452);
			X509ChainElementCollection.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr, 100664453);
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00030D54 File Offset: 0x0002EF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42652, XrefRangeEnd = 42657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainElementCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainElementCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementCollection.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00030D90 File Offset: 0x0002EF90
		public unsafe int Count
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 12038, RefRangeEnd = 12046, XrefRangeStart = 12038, XrefRangeEnd = 12046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A9 RID: 681
		public unsafe X509ChainElement this[int index]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 42659, RefRangeEnd = 42660, XrefRangeStart = 42657, XrefRangeEnd = 42659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementCollection.NativeMethodInfoPtr_get_Item_Public_get_X509ChainElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainElement>(intPtr3) : null;
				}
			}
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00030E18 File Offset: 0x0002F018
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42661, RefRangeEnd = 42662, XrefRangeStart = 42660, XrefRangeEnd = 42661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00030E68 File Offset: 0x0002F068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42662, XrefRangeEnd = 42669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00030EA8 File Offset: 0x0002F0A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42676, RefRangeEnd = 42677, XrefRangeStart = 42669, XrefRangeEnd = 42676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(X509Certificate2 certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementCollection.NativeMethodInfoPtr_Add_Internal_Void_X509Certificate2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00030EEC File Offset: 0x0002F0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42677, XrefRangeEnd = 42678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementCollection.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0000584A File Offset: 0x00003A4A
		public X509ChainElementCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x00030F20 File Offset: 0x0002F120
		// (set) Token: 0x060008CE RID: 2254 RVA: 0x00005853 File Offset: 0x00003A53
		public unsafe ArrayList _list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElementCollection.NativeFieldInfoPtr__list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElementCollection.NativeFieldInfoPtr__list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeFieldInfoPtr__list;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_X509ChainElement_Int32_0;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_X509Certificate2_0;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;
	}
}
