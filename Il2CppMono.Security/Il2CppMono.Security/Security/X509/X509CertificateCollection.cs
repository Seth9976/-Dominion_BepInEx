using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppMono.Security.X509
{
	// Token: 0x0200000B RID: 11
	[Serializable]
	public class X509CertificateCollection : CollectionBase
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x0000690C File Offset: 0x00004B0C
		// Note: this type is marked as 'beforefieldinit'.
		static X509CertificateCollection()
		{
			Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509", "X509CertificateCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr);
			X509CertificateCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100663414);
			X509CertificateCollection.NativeMethodInfoPtr_get_Item_Public_get_X509Certificate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100663415);
			X509CertificateCollection.NativeMethodInfoPtr_Add_Public_Int32_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100663416);
			X509CertificateCollection.NativeMethodInfoPtr_GetEnumerator_Public_X509CertificateEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100663417);
			X509CertificateCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100663418);
			X509CertificateCollection.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100663419);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000069B4 File Offset: 0x00004BB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8104, RefRangeEnd = 8106, XrefRangeStart = 8103, XrefRangeEnd = 8104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509CertificateCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000050 RID: 80
		public unsafe X509Certificate this[int index]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8109, RefRangeEnd = 8110, XrefRangeStart = 8106, XrefRangeEnd = 8109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060000D9 RID: 217 RVA: 0x00006A3C File Offset: 0x00004C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8110, XrefRangeEnd = 8118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Add(X509Certificate value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.NativeMethodInfoPtr_Add_Public_Int32_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00006A8C File Offset: 0x00004C8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8122, RefRangeEnd = 8124, XrefRangeStart = 8118, XrefRangeEnd = 8122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060000DB RID: 219 RVA: 0x00006ACC File Offset: 0x00004CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8124, XrefRangeEnd = 8126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00006B0C File Offset: 0x00004D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8126, XrefRangeEnd = 8128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateCollection.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002669 File Offset: 0x00000869
		public X509CertificateCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_X509Certificate_Int32_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_X509Certificate_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_X509CertificateEnumerator_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0200003B RID: 59
		public class X509CertificateEnumerator : Object
		{
			// Token: 0x06000339 RID: 825 RVA: 0x0000F290 File Offset: 0x0000D490
			// Note: this type is marked as 'beforefieldinit'.
			static X509CertificateEnumerator()
			{
				Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, "X509CertificateEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr);
				X509CertificateCollection.X509CertificateEnumerator.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, "enumerator");
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr__ctor_Public_Void_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100663420);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_get_Current_Public_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100663421);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100663422);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100663423);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100663424);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100663425);
			}

			// Token: 0x0600033A RID: 826 RVA: 0x0000F348 File Offset: 0x0000D548
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 8068, RefRangeEnd = 8072, XrefRangeStart = 8064, XrefRangeEnd = 8068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x0600033B RID: 827 RVA: 0x0000F394 File Offset: 0x0000D594
			public unsafe X509Certificate Current
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 8077, RefRangeEnd = 8082, XrefRangeStart = 8072, XrefRangeEnd = 8077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x0600033C RID: 828 RVA: 0x0000F3D4 File Offset: 0x0000D5D4
			public unsafe virtual Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8082, XrefRangeEnd = 8086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x0600033D RID: 829 RVA: 0x0000F414 File Offset: 0x0000D614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8086, XrefRangeEnd = 8090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Collections_IEnumerator_MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600033E RID: 830 RVA: 0x0000F450 File Offset: 0x0000D650
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8090, XrefRangeEnd = 8094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600033F RID: 831 RVA: 0x0000F484 File Offset: 0x0000D684
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 8098, RefRangeEnd = 8103, XrefRangeStart = 8094, XrefRangeEnd = 8098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000340 RID: 832 RVA: 0x000035CA File Offset: 0x000017CA
			public X509CertificateEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x06000341 RID: 833 RVA: 0x0000F4C0 File Offset: 0x0000D6C0
			// (set) Token: 0x06000342 RID: 834 RVA: 0x000035D3 File Offset: 0x000017D3
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

			// Token: 0x04000367 RID: 871
			private static readonly IntPtr NativeFieldInfoPtr_enumerator;

			// Token: 0x04000368 RID: 872
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_X509CertificateCollection_0;

			// Token: 0x04000369 RID: 873
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_X509Certificate_0;

			// Token: 0x0400036A RID: 874
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400036B RID: 875
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400036C RID: 876
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400036D RID: 877
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Boolean_0;
		}
	}
}
