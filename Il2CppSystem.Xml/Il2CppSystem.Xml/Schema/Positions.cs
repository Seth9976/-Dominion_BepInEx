using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000078 RID: 120
	public class Positions : Object
	{
		// Token: 0x060008D7 RID: 2263 RVA: 0x0002EFF0 File Offset: 0x0002D1F0
		// Note: this type is marked as 'beforefieldinit'.
		static Positions()
		{
			Il2CppClassPointerStore<Positions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Positions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Positions>.NativeClassPtr);
			Positions.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Positions>.NativeClassPtr, "positions");
			Positions.NativeMethodInfoPtr_Add_Public_Int32_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Positions>.NativeClassPtr, 100664726);
			Positions.NativeMethodInfoPtr_get_Item_Public_get_Position_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Positions>.NativeClassPtr, 100664727);
			Positions.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Positions>.NativeClassPtr, 100664728);
			Positions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Positions>.NativeClassPtr, 100664729);
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0002F084 File Offset: 0x0002D284
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 21519, RefRangeEnd = 21522, XrefRangeStart = 21516, XrefRangeEnd = 21519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Add(int symbol, Object particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref symbol;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Positions.NativeMethodInfoPtr_Add_Public_Int32_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000322 RID: 802
		public unsafe Position this[int pos]
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 21525, RefRangeEnd = 21529, XrefRangeStart = 21522, XrefRangeEnd = 21525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref pos;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Positions.NativeMethodInfoPtr_get_Item_Public_get_Position_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Position(intPtr);
				}
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x0002F124 File Offset: 0x0002D324
		public unsafe int Count
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 12038, RefRangeEnd = 12046, XrefRangeStart = 12038, XrefRangeEnd = 12046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Positions.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0002F160 File Offset: 0x0002D360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21529, XrefRangeEnd = 21534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Positions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Positions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Positions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00004D9D File Offset: 0x00002F9D
		public Positions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x0002F19C File Offset: 0x0002D39C
		// (set) Token: 0x060008DE RID: 2270 RVA: 0x00004DA6 File Offset: 0x00002FA6
		public unsafe ArrayList positions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Positions.NativeFieldInfoPtr_positions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Positions.NativeFieldInfoPtr_positions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeFieldInfoPtr_positions;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_Int32_Object_0;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Position_Int32_0;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
