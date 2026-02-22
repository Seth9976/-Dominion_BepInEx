using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000080 RID: 128
	public sealed class QmarkNode : InteriorNode
	{
		// Token: 0x0600091A RID: 2330 RVA: 0x000302B4 File Offset: 0x0002E4B4
		// Note: this type is marked as 'beforefieldinit'.
		static QmarkNode()
		{
			Il2CppClassPointerStore<QmarkNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "QmarkNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QmarkNode>.NativeClassPtr);
			QmarkNode.NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QmarkNode>.NativeClassPtr, 100664766);
			QmarkNode.NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QmarkNode>.NativeClassPtr, 100664767);
			QmarkNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QmarkNode>.NativeClassPtr, 100664768);
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00030320 File Offset: 0x0002E520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21718, XrefRangeEnd = 21719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QmarkNode.NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x00030388 File Offset: 0x0002E588
		public unsafe override bool IsNullable
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QmarkNode.NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x000303C4 File Offset: 0x0002E5C4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QmarkNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QmarkNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QmarkNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00004E9B File Offset: 0x0000309B
		public QmarkNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
