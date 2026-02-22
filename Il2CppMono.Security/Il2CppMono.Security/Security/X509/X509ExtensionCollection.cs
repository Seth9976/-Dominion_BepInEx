using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppMono.Security.X509
{
	// Token: 0x0200000D RID: 13
	[DefaultMember("Item")]
	public sealed class X509ExtensionCollection : CollectionBase
	{
		// Token: 0x060000EC RID: 236 RVA: 0x00006E84 File Offset: 0x00005084
		// Note: this type is marked as 'beforefieldinit'.
		static X509ExtensionCollection()
		{
			Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509", "X509ExtensionCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr);
			X509ExtensionCollection.NativeFieldInfoPtr_readOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr, "readOnly");
			X509ExtensionCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr, 100663432);
			X509ExtensionCollection.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr, 100663433);
			X509ExtensionCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr, 100663434);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00006F04 File Offset: 0x00005104
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

		// Token: 0x060000EE RID: 238 RVA: 0x00006F40 File Offset: 0x00005140
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8237, RefRangeEnd = 8238, XrefRangeStart = 8228, XrefRangeEnd = 8237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060000EF RID: 239 RVA: 0x00006F8C File Offset: 0x0000518C
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

		// Token: 0x060000F0 RID: 240 RVA: 0x000026D4 File Offset: 0x000008D4
		public X509ExtensionCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00006FCC File Offset: 0x000051CC
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x000026DD File Offset: 0x000008DD
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

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_readOnly;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ASN1_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
	}
}
