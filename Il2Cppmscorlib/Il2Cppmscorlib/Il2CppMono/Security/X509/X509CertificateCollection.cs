using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppMono.Security.X509
{
	// Token: 0x02000026 RID: 38
	[Serializable]
	public class X509CertificateCollection : CollectionBase
	{
		// Token: 0x0600027E RID: 638 RVA: 0x0002BCE0 File Offset: 0x00029EE0
		// Note: this type is marked as 'beforefieldinit'.
		static X509CertificateCollection()
		{
			Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.X509", "X509CertificateCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr);
			X509CertificateCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100663617);
			X509CertificateCollection.NativeMethodInfoPtr_get_Item_Public_get_X509Certificate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100663618);
			X509CertificateCollection.NativeMethodInfoPtr_Add_Public_Int32_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100663619);
			X509CertificateCollection.NativeMethodInfoPtr_GetEnumerator_Public_X509CertificateEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100663620);
			X509CertificateCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100663621);
			X509CertificateCollection.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, 100663622);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0002BD88 File Offset: 0x00029F88
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

		// Token: 0x170000BE RID: 190
		public unsafe X509Certificate this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262291, XrefRangeEnd = 262294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000281 RID: 641 RVA: 0x0002BE10 File Offset: 0x0002A010
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262302, RefRangeEnd = 262304, XrefRangeStart = 262294, XrefRangeEnd = 262302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000282 RID: 642 RVA: 0x0002BE60 File Offset: 0x0002A060
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 262308, RefRangeEnd = 262312, XrefRangeStart = 262304, XrefRangeEnd = 262308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000283 RID: 643 RVA: 0x0002BEA0 File Offset: 0x0002A0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000284 RID: 644 RVA: 0x0002BEE0 File Offset: 0x0002A0E0
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

		// Token: 0x06000285 RID: 645 RVA: 0x00003142 File Offset: 0x00001342
		public X509CertificateCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_X509Certificate_Int32_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_X509Certificate_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_X509CertificateEnumerator_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x02000542 RID: 1346
		public class X509CertificateEnumerator : Object
		{
			// Token: 0x06004DDE RID: 19934 RVA: 0x0015F22C File Offset: 0x0015D42C
			// Note: this type is marked as 'beforefieldinit'.
			static X509CertificateEnumerator()
			{
				Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X509CertificateCollection>.NativeClassPtr, "X509CertificateEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr);
				X509CertificateCollection.X509CertificateEnumerator.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, "enumerator");
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr__ctor_Public_Void_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100663623);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_get_Current_Public_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100663624);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100663625);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100663626);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100663627);
				X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateCollection.X509CertificateEnumerator>.NativeClassPtr, 100663628);
			}

			// Token: 0x06004DDF RID: 19935 RVA: 0x0015F2E4 File Offset: 0x0015D4E4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 262261, RefRangeEnd = 262262, XrefRangeStart = 262257, XrefRangeEnd = 262261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x170013DC RID: 5084
			// (get) Token: 0x06004DE0 RID: 19936 RVA: 0x0015F330 File Offset: 0x0015D530
			public unsafe X509Certificate Current
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 262267, RefRangeEnd = 262271, XrefRangeStart = 262262, XrefRangeEnd = 262267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x170013DD RID: 5085
			// (get) Token: 0x06004DE1 RID: 19937 RVA: 0x0015F370 File Offset: 0x0015D570
			public unsafe virtual Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262271, XrefRangeEnd = 262275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004DE2 RID: 19938 RVA: 0x0015F3B0 File Offset: 0x0015D5B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262275, XrefRangeEnd = 262279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Collections_IEnumerator_MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004DE3 RID: 19939 RVA: 0x0015F3EC File Offset: 0x0015D5EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262279, XrefRangeEnd = 262283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DE4 RID: 19940 RVA: 0x0015F420 File Offset: 0x0015D620
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 262287, RefRangeEnd = 262291, XrefRangeStart = 262283, XrefRangeEnd = 262287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateCollection.X509CertificateEnumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004DE5 RID: 19941 RVA: 0x0001D7DD File Offset: 0x0001B9DD
			public X509CertificateEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013DB RID: 5083
			// (get) Token: 0x06004DE6 RID: 19942 RVA: 0x0015F45C File Offset: 0x0015D65C
			// (set) Token: 0x06004DE7 RID: 19943 RVA: 0x0001D7E6 File Offset: 0x0001B9E6
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

			// Token: 0x04003EE5 RID: 16101
			private static readonly IntPtr NativeFieldInfoPtr_enumerator;

			// Token: 0x04003EE6 RID: 16102
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_X509CertificateCollection_0;

			// Token: 0x04003EE7 RID: 16103
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_X509Certificate_0;

			// Token: 0x04003EE8 RID: 16104
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003EE9 RID: 16105
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003EEA RID: 16106
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003EEB RID: 16107
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Boolean_0;
		}
	}
}
