using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x0200008F RID: 143
	[Serializable]
	public class X509CertificateCollection : CollectionBase
	{
		// Token: 0x0600089A RID: 2202 RVA: 0x000301DC File Offset: 0x0002E3DC
		// Note: this type is marked as 'beforefieldinit'.
		static X509CertificateCollection()
		{
			Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509CertificateCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr);
			X509CertificateCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100664415);
			X509CertificateCollection.NativeMethodInfoPtr__ctor_Public_Void_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100664416);
			X509CertificateCollection.NativeMethodInfoPtr_get_Item_Public_get_X509Certificate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100664417);
			X509CertificateCollection.NativeMethodInfoPtr_AddRange_Public_Void_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100664418);
			X509CertificateCollection.NativeMethodInfoPtr_GetEnumerator_Public_X509CertificateEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100664419);
			X509CertificateCollection.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100664420);
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00030284 File Offset: 0x0002E484
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8104, RefRangeEnd = 8106, XrefRangeStart = 8104, XrefRangeEnd = 8106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509CertificateCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x000302C0 File Offset: 0x0002E4C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42498, RefRangeEnd = 42499, XrefRangeStart = 42490, XrefRangeEnd = 42498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509CertificateCollection(X509CertificateCollection value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.NativeMethodInfoPtr__ctor_Public_Void_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700029C RID: 668
		public unsafe X509Certificate this[int index]
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 42502, RefRangeEnd = 42504, XrefRangeStart = 42499, XrefRangeEnd = 42502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.NativeMethodInfoPtr_get_Item_Public_get_X509Certificate_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
				}
			}
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00030358 File Offset: 0x0002E558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42504, XrefRangeEnd = 42511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRange(X509CertificateCollection value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.NativeMethodInfoPtr_AddRange_Public_Void_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0003039C File Offset: 0x0002E59C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42515, RefRangeEnd = 42516, XrefRangeStart = 42511, XrefRangeEnd = 42515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe X509CertificateCollection.X509CertificateEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.NativeMethodInfoPtr_GetEnumerator_Public_X509CertificateEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection.X509CertificateEnumerator>(intPtr3) : null;
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x000303DC File Offset: 0x0002E5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateCollection.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x000057AA File Offset: 0x000039AA
		public X509CertificateCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_X509CertificateCollection_0;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_X509Certificate_Int32_0;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeMethodInfoPtr_AddRange_Public_Void_X509CertificateCollection_0;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_X509CertificateEnumerator_0;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x02000194 RID: 404
		public class X509CertificateEnumerator : Object
		{
			// Token: 0x0600174E RID: 5966 RVA: 0x00064F3C File Offset: 0x0006313C
			// Note: this type is marked as 'beforefieldinit'.
			static X509CertificateEnumerator()
			{
				Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, "X509CertificateEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr);
				X509CertificateCollection.X509CertificateEnumerator.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, "enumerator");
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr__ctor_Public_Void_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100664421);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_get_Current_Public_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100664422);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100664423);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100664424);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100664425);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100664426);
			}

			// Token: 0x0600174F RID: 5967 RVA: 0x00064FF4 File Offset: 0x000631F4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 42466, RefRangeEnd = 42467, XrefRangeStart = 42462, XrefRangeEnd = 42466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe X509CertificateEnumerator(X509CertificateCollection mappings)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(mappings);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr__ctor_Public_Void_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000781 RID: 1921
			// (get) Token: 0x06001750 RID: 5968 RVA: 0x00065040 File Offset: 0x00063240
			public unsafe X509Certificate Current
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 42472, RefRangeEnd = 42473, XrefRangeStart = 42467, XrefRangeEnd = 42472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_get_Current_Public_get_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
				}
			}

			// Token: 0x17000782 RID: 1922
			// (get) Token: 0x06001751 RID: 5969 RVA: 0x00065080 File Offset: 0x00063280
			public unsafe virtual Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42473, XrefRangeEnd = 42477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001752 RID: 5970 RVA: 0x000650C0 File Offset: 0x000632C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42477, XrefRangeEnd = 42481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Collections_IEnumerator_MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001753 RID: 5971 RVA: 0x000650FC File Offset: 0x000632FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42481, XrefRangeEnd = 42485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001754 RID: 5972 RVA: 0x00065130 File Offset: 0x00063330
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 42489, RefRangeEnd = 42490, XrefRangeStart = 42485, XrefRangeEnd = 42489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001755 RID: 5973 RVA: 0x0000C55C File Offset: 0x0000A75C
			public X509CertificateEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000780 RID: 1920
			// (get) Token: 0x06001756 RID: 5974 RVA: 0x0006516C File Offset: 0x0006336C
			// (set) Token: 0x06001757 RID: 5975 RVA: 0x0000C565 File Offset: 0x0000A765
			public unsafe IEnumerator enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509CertificateCollection.X509CertificateEnumerator.NativeFieldInfoPtr_enumerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509CertificateCollection.X509CertificateEnumerator.NativeFieldInfoPtr_enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012A4 RID: 4772
			private static readonly IntPtr NativeFieldInfoPtr_enumerator;

			// Token: 0x040012A5 RID: 4773
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_X509CertificateCollection_0;

			// Token: 0x040012A6 RID: 4774
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_X509Certificate_0;

			// Token: 0x040012A7 RID: 4775
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040012A8 RID: 4776
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040012A9 RID: 4777
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012AA RID: 4778
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Boolean_0;
		}
	}
}
