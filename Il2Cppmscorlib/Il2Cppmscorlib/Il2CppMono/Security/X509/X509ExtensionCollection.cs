using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppMono.Security.X509
{
	// Token: 0x02000028 RID: 40
	[DefaultMember("Item")]
	public sealed class X509ExtensionCollection : CollectionBase
	{
		// Token: 0x06000294 RID: 660 RVA: 0x0002C258 File Offset: 0x0002A458
		// Note: this type is marked as 'beforefieldinit'.
		static X509ExtensionCollection()
		{
			Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.X509", "X509ExtensionCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr);
			X509ExtensionCollection.NativeFieldInfoPtr_readOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr, "readOnly");
			X509ExtensionCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr, 100663635);
			X509ExtensionCollection.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr, 100663636);
			X509ExtensionCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr, 100663637);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0002C2D8 File Offset: 0x0002A4D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8104, RefRangeEnd = 8106, XrefRangeStart = 8104, XrefRangeEnd = 8106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ExtensionCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ExtensionCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0002C314 File Offset: 0x0002A514
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262418, RefRangeEnd = 262420, XrefRangeStart = 262409, XrefRangeEnd = 262418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ExtensionCollection(ASN1 asn1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ExtensionCollection.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0002C360 File Offset: 0x0002A560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ExtensionCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000031AD File Offset: 0x000013AD
		public X509ExtensionCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0002C3A0 File Offset: 0x0002A5A0
		// (set) Token: 0x0600029A RID: 666 RVA: 0x000031B6 File Offset: 0x000013B6
		public unsafe bool readOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ExtensionCollection.NativeFieldInfoPtr_readOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ExtensionCollection.NativeFieldInfoPtr_readOnly)) = value;
			}
		}

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeFieldInfoPtr_readOnly;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ASN1_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
	}
}
