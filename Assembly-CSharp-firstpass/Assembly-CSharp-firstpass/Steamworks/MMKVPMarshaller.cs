using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002C0 RID: 704
	public class MMKVPMarshaller : Object
	{
		// Token: 0x06002852 RID: 10322 RVA: 0x000AEF70 File Offset: 0x000AD170
		// Note: this type is marked as 'beforefieldinit'.
		static MMKVPMarshaller()
		{
			Il2CppClassPointerStore<MMKVPMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MMKVPMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MMKVPMarshaller>.NativeClassPtr);
			MMKVPMarshaller.NativeFieldInfoPtr_m_pNativeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMKVPMarshaller>.NativeClassPtr, "m_pNativeArray");
			MMKVPMarshaller.NativeFieldInfoPtr_m_pArrayEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMKVPMarshaller>.NativeClassPtr, "m_pArrayEntries");
			MMKVPMarshaller.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MMKVPMarshaller>.NativeClassPtr, 100668456);
			MMKVPMarshaller.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MMKVPMarshaller>.NativeClassPtr, 100668457);
			MMKVPMarshaller.NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_MMKVPMarshaller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MMKVPMarshaller>.NativeClassPtr, 100668458);
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x000AF004 File Offset: 0x000AD204
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 209324, RefRangeEnd = 209329, XrefRangeStart = 209296, XrefRangeEnd = 209324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MMKVPMarshaller(Il2CppReferenceArray<MatchMakingKeyValuePair_t> filters)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MMKVPMarshaller>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MMKVPMarshaller.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002854 RID: 10324 RVA: 0x000AF050 File Offset: 0x000AD250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209329, XrefRangeEnd = 209342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MMKVPMarshaller.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x000AF08C File Offset: 0x000AD28C
		[CallerCount(0)]
		public unsafe static implicit operator IntPtr(MMKVPMarshaller that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(that);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MMKVPMarshaller.NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_MMKVPMarshaller_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x0001048E File Offset: 0x0000E68E
		public MMKVPMarshaller(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06002857 RID: 10327 RVA: 0x000AF0D0 File Offset: 0x000AD2D0
		// (set) Token: 0x06002858 RID: 10328 RVA: 0x00010497 File Offset: 0x0000E697
		public unsafe IntPtr m_pNativeArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MMKVPMarshaller.NativeFieldInfoPtr_m_pNativeArray);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MMKVPMarshaller.NativeFieldInfoPtr_m_pNativeArray)) = value;
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06002859 RID: 10329 RVA: 0x000AF0F8 File Offset: 0x000AD2F8
		// (set) Token: 0x0600285A RID: 10330 RVA: 0x000104B2 File Offset: 0x0000E6B2
		public unsafe IntPtr m_pArrayEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MMKVPMarshaller.NativeFieldInfoPtr_m_pArrayEntries);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MMKVPMarshaller.NativeFieldInfoPtr_m_pArrayEntries)) = value;
			}
		}

		// Token: 0x04002749 RID: 10057
		private static readonly IntPtr NativeFieldInfoPtr_m_pNativeArray;

		// Token: 0x0400274A RID: 10058
		private static readonly IntPtr NativeFieldInfoPtr_m_pArrayEntries;

		// Token: 0x0400274B RID: 10059
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_0;

		// Token: 0x0400274C RID: 10060
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400274D RID: 10061
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_MMKVPMarshaller_0;
	}
}
