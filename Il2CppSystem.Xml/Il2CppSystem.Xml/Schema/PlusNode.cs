using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200007F RID: 127
	public sealed class PlusNode : InteriorNode
	{
		// Token: 0x06000915 RID: 2325 RVA: 0x00030168 File Offset: 0x0002E368
		// Note: this type is marked as 'beforefieldinit'.
		static PlusNode()
		{
			Il2CppClassPointerStore<PlusNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "PlusNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlusNode>.NativeClassPtr);
			PlusNode.NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlusNode>.NativeClassPtr, 100664763);
			PlusNode.NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlusNode>.NativeClassPtr, 100664764);
			PlusNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlusNode>.NativeClassPtr, 100664765);
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x000301D4 File Offset: 0x0002E3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21715, XrefRangeEnd = 21718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConstructPos(BitSet firstpos, BitSet lastpos, Il2CppReferenceArray<BitSet> followpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstpos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastpos);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(followpos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlusNode.NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x0003023C File Offset: 0x0002E43C
		public unsafe override bool IsNullable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlusNode.NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00030278 File Offset: 0x0002E478
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlusNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlusNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlusNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00004E92 File Offset: 0x00003092
		public PlusNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
