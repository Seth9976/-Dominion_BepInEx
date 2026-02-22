using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000051 RID: 81
	[StructLayout(2)]
	public struct Resolution
	{
		// Token: 0x06000614 RID: 1556 RVA: 0x00024968 File Offset: 0x00022B68
		// Note: this type is marked as 'beforefieldinit'.
		static Resolution()
		{
			Il2CppClassPointerStore<Resolution>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Resolution");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Resolution>.NativeClassPtr);
			Resolution.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resolution>.NativeClassPtr, "m_Width");
			Resolution.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resolution>.NativeClassPtr, "m_Height");
			Resolution.NativeFieldInfoPtr_m_RefreshRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resolution>.NativeClassPtr, "m_RefreshRate");
			Resolution.NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resolution>.NativeClassPtr, 100663614);
			Resolution.NativeMethodInfoPtr_get_height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resolution>.NativeClassPtr, 100663615);
			Resolution.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resolution>.NativeClassPtr, 100663616);
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x00024A10 File Offset: 0x00022C10
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x000056EE File Offset: 0x000038EE
		public unsafe int width
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 62259, RefRangeEnd = 62285, XrefRangeStart = 62259, XrefRangeEnd = 62285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resolution.NativeMethodInfoPtr_get_width_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Width = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x00024A40 File Offset: 0x00022C40
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x000056F8 File Offset: 0x000038F8
		public unsafe int height
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 62285, RefRangeEnd = 62297, XrefRangeStart = 62285, XrefRangeEnd = 62297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resolution.NativeMethodInfoPtr_get_height_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Height = value;
			}
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00024A70 File Offset: 0x00022C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62735, XrefRangeEnd = 62751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resolution.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x000056DC File Offset: 0x000038DC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Resolution>.NativeClassPtr, ref this));
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x00024A9C File Offset: 0x00022C9C
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x00005702 File Offset: 0x00003902
		public int refreshRate
		{
			get
			{
				return this.m_RefreshRate;
			}
			set
			{
				this.m_RefreshRate = value;
			}
		}

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeFieldInfoPtr_m_Width;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeFieldInfoPtr_m_Height;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeFieldInfoPtr_m_RefreshRate;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Int32_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040003D1 RID: 977
		[FieldOffset(0)]
		public int m_Width;

		// Token: 0x040003D2 RID: 978
		[FieldOffset(4)]
		public int m_Height;

		// Token: 0x040003D3 RID: 979
		[FieldOffset(8)]
		public int m_RefreshRate;
	}
}
