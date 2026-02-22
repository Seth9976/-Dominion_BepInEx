using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000081 RID: 129
	public sealed class StarNode : InteriorNode
	{
		// Token: 0x0600091F RID: 2335 RVA: 0x00030400 File Offset: 0x0002E600
		// Note: this type is marked as 'beforefieldinit'.
		static StarNode()
		{
			Il2CppClassPointerStore<StarNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "StarNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StarNode>.NativeClassPtr);
			StarNode.NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StarNode>.NativeClassPtr, 100664769);
			StarNode.NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StarNode>.NativeClassPtr, 100664770);
			StarNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StarNode>.NativeClassPtr, 100664771);
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0003046C File Offset: 0x0002E66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StarNode.NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x000304D4 File Offset: 0x0002E6D4
		public unsafe override bool IsNullable
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StarNode.NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00030510 File Offset: 0x0002E710
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StarNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StarNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StarNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00004EA4 File Offset: 0x000030A4
		public StarNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
