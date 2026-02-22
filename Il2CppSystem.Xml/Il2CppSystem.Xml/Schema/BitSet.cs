using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000074 RID: 116
	public sealed class BitSet : Object
	{
		// Token: 0x0600089A RID: 2202 RVA: 0x0002E1F0 File Offset: 0x0002C3F0
		// Note: this type is marked as 'beforefieldinit'.
		static BitSet()
		{
			Il2CppClassPointerStore<BitSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "BitSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitSet>.NativeClassPtr);
			BitSet.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitSet>.NativeClassPtr, "count");
			BitSet.NativeFieldInfoPtr_bits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitSet>.NativeClassPtr, "bits");
			BitSet.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100664698);
			BitSet.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100664699);
			BitSet.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100664700);
			BitSet.NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100664701);
			BitSet.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100664702);
			BitSet.NativeMethodInfoPtr_Set_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100664703);
			BitSet.NativeMethodInfoPtr_Get_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100664704);
			BitSet.NativeMethodInfoPtr_NextSet_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100664705);
			BitSet.NativeMethodInfoPtr_And_Public_Void_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100664706);
			BitSet.NativeMethodInfoPtr_Or_Public_Void_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100664707);
			BitSet.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100664708);
			BitSet.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100664709);
			BitSet.NativeMethodInfoPtr_Clone_Public_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100664710);
			BitSet.NativeMethodInfoPtr_Intersects_Public_Boolean_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100664711);
			BitSet.NativeMethodInfoPtr_Subscript_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100664712);
			BitSet.NativeMethodInfoPtr_EnsureLength_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitSet>.NativeClassPtr, 100664713);
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0002E388 File Offset: 0x0002C588
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BitSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0002E3C4 File Offset: 0x0002C5C4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 21348, RefRangeEnd = 21358, XrefRangeStart = 21344, XrefRangeEnd = 21348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitSet(int count)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BitSet>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x0002E40C File Offset: 0x0002C60C
		public unsafe int Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000314 RID: 788
		public unsafe bool this[int index]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21358, RefRangeEnd = 21359, XrefRangeStart = 21358, XrefRangeEnd = 21358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0002E494 File Offset: 0x0002C694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21359, RefRangeEnd = 21360, XrefRangeStart = 21359, XrefRangeEnd = 21359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0002E4C8 File Offset: 0x0002C6C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 21361, RefRangeEnd = 21364, XrefRangeStart = 21360, XrefRangeEnd = 21361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_Set_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0002E508 File Offset: 0x0002C708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21358, RefRangeEnd = 21359, XrefRangeStart = 21358, XrefRangeEnd = 21359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Get(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_Get_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0002E554 File Offset: 0x0002C754
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 21364, RefRangeEnd = 21380, XrefRangeStart = 21364, XrefRangeEnd = 21364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int NextSet(int startFrom)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startFrom;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_NextSet_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0002E5A0 File Offset: 0x0002C7A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21380, RefRangeEnd = 21381, XrefRangeStart = 21380, XrefRangeEnd = 21380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void And(BitSet other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_And_Public_Void_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x0002E5E4 File Offset: 0x0002C7E4
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 21382, RefRangeEnd = 21397, XrefRangeStart = 21381, XrefRangeEnd = 21382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Or(BitSet other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_Or_Public_Void_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x0002E628 File Offset: 0x0002C828
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x0002E664 File Offset: 0x0002C864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21397, XrefRangeEnd = 21399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x0002E6B4 File Offset: 0x0002C8B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 21407, RefRangeEnd = 21409, XrefRangeStart = 21399, XrefRangeEnd = 21407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitSet Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_Clone_Public_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr3) : null;
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0002E6F4 File Offset: 0x0002C8F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21413, RefRangeEnd = 21414, XrefRangeStart = 21409, XrefRangeEnd = 21413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Intersects(BitSet other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_Intersects_Public_Boolean_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x0002E744 File Offset: 0x0002C944
		[CallerCount(0)]
		public unsafe int Subscript(int bitIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bitIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_Subscript_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0002E790 File Offset: 0x0002C990
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 21418, RefRangeEnd = 21420, XrefRangeStart = 21414, XrefRangeEnd = 21418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureLength(int nRequiredLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nRequiredLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitSet.NativeMethodInfoPtr_EnsureLength_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00004C03 File Offset: 0x00002E03
		public BitSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x0002E7D0 File Offset: 0x0002C9D0
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x00004C0C File Offset: 0x00002E0C
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitSet.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitSet.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x0002E7F8 File Offset: 0x0002C9F8
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x00004C27 File Offset: 0x00002E27
		public unsafe Il2CppStructArray<uint> bits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitSet.NativeFieldInfoPtr_bits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitSet.NativeFieldInfoPtr_bits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeFieldInfoPtr_bits;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Int32_0;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Boolean_Int32_0;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeMethodInfoPtr_NextSet_Public_Int32_Int32_0;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr_And_Public_Void_BitSet_0;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr_Or_Public_Void_BitSet_0;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_BitSet_0;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_BitSet_0;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeMethodInfoPtr_Subscript_Private_Int32_Int32_0;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeMethodInfoPtr_EnsureLength_Private_Void_Int32_0;
	}
}
