using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002C6 RID: 710
	public static class Packsize : Object
	{
		// Token: 0x060028AC RID: 10412 RVA: 0x000B0164 File Offset: 0x000AE364
		// Note: this type is marked as 'beforefieldinit'.
		static Packsize()
		{
			Il2CppClassPointerStore<Packsize>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "Packsize");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Packsize>.NativeClassPtr);
			Packsize.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packsize>.NativeClassPtr, "value");
			Packsize.NativeMethodInfoPtr_Test_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packsize>.NativeClassPtr, 100668484);
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x000B01BC File Offset: 0x000AE3BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209771, RefRangeEnd = 209772, XrefRangeStart = 209757, XrefRangeEnd = 209771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Test()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packsize.NativeMethodInfoPtr_Test_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x000107A3 File Offset: 0x0000E9A3
		public Packsize(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x060028AF RID: 10415 RVA: 0x000B01EC File Offset: 0x000AE3EC
		// (set) Token: 0x060028B0 RID: 10416 RVA: 0x000107AC File Offset: 0x0000E9AC
		public unsafe static int value
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Packsize.NativeFieldInfoPtr_value, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Packsize.NativeFieldInfoPtr_value, (void*)(&value));
			}
		}

		// Token: 0x0400277E RID: 10110
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x0400277F RID: 10111
		private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Static_Boolean_0;

		// Token: 0x020003C5 RID: 965
		[StructLayout(2)]
		public struct ValvePackingSentinel_t
		{
			// Token: 0x0600383B RID: 14395 RVA: 0x000E511C File Offset: 0x000E331C
			// Note: this type is marked as 'beforefieldinit'.
			static ValvePackingSentinel_t()
			{
				Il2CppClassPointerStore<Packsize.ValvePackingSentinel_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Packsize>.NativeClassPtr, "ValvePackingSentinel_t");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Packsize.ValvePackingSentinel_t>.NativeClassPtr);
				Packsize.ValvePackingSentinel_t.NativeFieldInfoPtr_m_u32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packsize.ValvePackingSentinel_t>.NativeClassPtr, "m_u32");
				Packsize.ValvePackingSentinel_t.NativeFieldInfoPtr_m_u64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packsize.ValvePackingSentinel_t>.NativeClassPtr, "m_u64");
				Packsize.ValvePackingSentinel_t.NativeFieldInfoPtr_m_u16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packsize.ValvePackingSentinel_t>.NativeClassPtr, "m_u16");
				Packsize.ValvePackingSentinel_t.NativeFieldInfoPtr_m_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packsize.ValvePackingSentinel_t>.NativeClassPtr, "m_d");
			}

			// Token: 0x0600383C RID: 14396 RVA: 0x00015C5F File Offset: 0x00013E5F
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Packsize.ValvePackingSentinel_t>.NativeClassPtr, ref this));
			}

			// Token: 0x040032B9 RID: 12985
			private static readonly IntPtr NativeFieldInfoPtr_m_u32;

			// Token: 0x040032BA RID: 12986
			private static readonly IntPtr NativeFieldInfoPtr_m_u64;

			// Token: 0x040032BB RID: 12987
			private static readonly IntPtr NativeFieldInfoPtr_m_u16;

			// Token: 0x040032BC RID: 12988
			private static readonly IntPtr NativeFieldInfoPtr_m_d;

			// Token: 0x040032BD RID: 12989
			[FieldOffset(0)]
			public uint m_u32;

			// Token: 0x040032BE RID: 12990
			[FieldOffset(8)]
			public ulong m_u64;

			// Token: 0x040032BF RID: 12991
			[FieldOffset(16)]
			public ushort m_u16;

			// Token: 0x040032C0 RID: 12992
			[FieldOffset(24)]
			public double m_d;
		}
	}
}
