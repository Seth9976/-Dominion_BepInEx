using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000076 RID: 118
	[DefaultMember("Item")]
	public class SymbolsDictionary : Object
	{
		// Token: 0x060008B7 RID: 2231 RVA: 0x0002E954 File Offset: 0x0002CB54
		// Note: this type is marked as 'beforefieldinit'.
		static SymbolsDictionary()
		{
			Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SymbolsDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr);
			SymbolsDictionary.NativeFieldInfoPtr_last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, "last");
			SymbolsDictionary.NativeFieldInfoPtr_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, "names");
			SymbolsDictionary.NativeFieldInfoPtr_wildcards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, "wildcards");
			SymbolsDictionary.NativeFieldInfoPtr_particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, "particles");
			SymbolsDictionary.NativeFieldInfoPtr_particleLast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, "particleLast");
			SymbolsDictionary.NativeFieldInfoPtr_isUpaEnforced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, "isUpaEnforced");
			SymbolsDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100664715);
			SymbolsDictionary.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100664716);
			SymbolsDictionary.NativeMethodInfoPtr_get_IsUpaEnforced_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100664717);
			SymbolsDictionary.NativeMethodInfoPtr_set_IsUpaEnforced_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100664718);
			SymbolsDictionary.NativeMethodInfoPtr_AddName_Public_Int32_XmlQualifiedName_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100664719);
			SymbolsDictionary.NativeMethodInfoPtr_AddNamespaceList_Public_Void_NamespaceList_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100664720);
			SymbolsDictionary.NativeMethodInfoPtr_AddWildcard_Private_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100664721);
			SymbolsDictionary.NativeMethodInfoPtr_GetNamespaceListSymbols_Public_ICollection_NamespaceList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100664722);
			SymbolsDictionary.NativeMethodInfoPtr_Exists_Public_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100664723);
			SymbolsDictionary.NativeMethodInfoPtr_GetParticle_Public_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100664724);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x0002EAC4 File Offset: 0x0002CCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21424, XrefRangeEnd = 21433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymbolsDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x0002EB00 File Offset: 0x0002CD00
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x0002EB3C File Offset: 0x0002CD3C
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x0002EB78 File Offset: 0x0002CD78
		public unsafe bool IsUpaEnforced
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_get_IsUpaEnforced_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_set_IsUpaEnforced_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x0002EBB8 File Offset: 0x0002CDB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 21436, RefRangeEnd = 21438, XrefRangeStart = 21433, XrefRangeEnd = 21436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddName(XmlQualifiedName name, Object particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_AddName_Public_Int32_XmlQualifiedName_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0002EC18 File Offset: 0x0002CE18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21461, RefRangeEnd = 21462, XrefRangeStart = 21438, XrefRangeEnd = 21461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNamespaceList(NamespaceList list, Object particle, bool allowLocal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowLocal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_AddNamespaceList_Public_Void_NamespaceList_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x0002EC7C File Offset: 0x0002CE7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 21469, RefRangeEnd = 21472, XrefRangeStart = 21462, XrefRangeEnd = 21469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddWildcard(string wildcard, Object particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(wildcard);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_AddWildcard_Private_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0002ECD0 File Offset: 0x0002CED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21514, RefRangeEnd = 21515, XrefRangeStart = 21472, XrefRangeEnd = 21514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ICollection GetNamespaceListSymbols(NamespaceList list)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_GetNamespaceListSymbols_Public_ICollection_NamespaceList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0002ED20 File Offset: 0x0002CF20
		[CallerCount(0)]
		public unsafe bool Exists(XmlQualifiedName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_Exists_Public_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0002ED70 File Offset: 0x0002CF70
		[CallerCount(0)]
		public unsafe Object GetParticle(int symbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref symbol;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_GetParticle_Public_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00004C8D File Offset: 0x00002E8D
		public SymbolsDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x0002EDBC File Offset: 0x0002CFBC
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x00004C96 File Offset: 0x00002E96
		public unsafe int last
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_last);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_last)) = value;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x0002EDE4 File Offset: 0x0002CFE4
		// (set) Token: 0x060008C6 RID: 2246 RVA: 0x00004CB1 File Offset: 0x00002EB1
		public unsafe Hashtable names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x0002EE14 File Offset: 0x0002D014
		// (set) Token: 0x060008C8 RID: 2248 RVA: 0x00004CD0 File Offset: 0x00002ED0
		public unsafe Hashtable wildcards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_wildcards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_wildcards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x0002EE44 File Offset: 0x0002D044
		// (set) Token: 0x060008CA RID: 2250 RVA: 0x00004CEF File Offset: 0x00002EEF
		public unsafe ArrayList particles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_particles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_particles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x0002EE74 File Offset: 0x0002D074
		// (set) Token: 0x060008CC RID: 2252 RVA: 0x00004D0E File Offset: 0x00002F0E
		public unsafe Object particleLast
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_particleLast);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_particleLast), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x0002EEA4 File Offset: 0x0002D0A4
		// (set) Token: 0x060008CE RID: 2254 RVA: 0x00004D2D File Offset: 0x00002F2D
		public unsafe bool isUpaEnforced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_isUpaEnforced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_isUpaEnforced)) = value;
			}
		}

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeFieldInfoPtr_last;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeFieldInfoPtr_names;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeFieldInfoPtr_wildcards;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeFieldInfoPtr_particles;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeFieldInfoPtr_particleLast;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeFieldInfoPtr_isUpaEnforced;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUpaEnforced_Public_get_Boolean_0;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeMethodInfoPtr_set_IsUpaEnforced_Public_set_Void_Boolean_0;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeMethodInfoPtr_AddName_Public_Int32_XmlQualifiedName_Object_0;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeMethodInfoPtr_AddNamespaceList_Public_Void_NamespaceList_Object_Boolean_0;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeMethodInfoPtr_AddWildcard_Private_Void_String_Object_0;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeMethodInfoPtr_GetNamespaceListSymbols_Public_ICollection_NamespaceList_0;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Boolean_XmlQualifiedName_0;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeMethodInfoPtr_GetParticle_Public_Object_Int32_0;
	}
}
