using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000077 RID: 119
	public sealed class Position : ValueType
	{
		// Token: 0x060008CF RID: 2255 RVA: 0x0002EECC File Offset: 0x0002D0CC
		// Note: this type is marked as 'beforefieldinit'.
		static Position()
		{
			Il2CppClassPointerStore<Position>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Position");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Position>.NativeClassPtr);
			Position.NativeFieldInfoPtr_symbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Position>.NativeClassPtr, "symbol");
			Position.NativeFieldInfoPtr_particle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Position>.NativeClassPtr, "particle");
			Position.NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Position>.NativeClassPtr, 100664725);
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0002EF38 File Offset: 0x0002D138
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21515, RefRangeEnd = 21516, XrefRangeStart = 21515, XrefRangeEnd = 21515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Position(int symbol, Object particle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Position>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref symbol;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Position.NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00004D48 File Offset: 0x00002F48
		public Position(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00004D51 File Offset: 0x00002F51
		public Position()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Position>.NativeClassPtr))
		{
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x0002EF98 File Offset: 0x0002D198
		// (set) Token: 0x060008D4 RID: 2260 RVA: 0x00004D63 File Offset: 0x00002F63
		public unsafe int symbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Position.NativeFieldInfoPtr_symbol);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Position.NativeFieldInfoPtr_symbol)) = value;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x0002EFC0 File Offset: 0x0002D1C0
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x00004D7E File Offset: 0x00002F7E
		public unsafe Object particle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Position.NativeFieldInfoPtr_particle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Position.NativeFieldInfoPtr_particle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeFieldInfoPtr_symbol;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeFieldInfoPtr_particle;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0;
	}
}
