using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020000D7 RID: 215
	[StructLayout(2)]
	public struct BMPAlloc
	{
		// Token: 0x06000C1A RID: 3098 RVA: 0x00031480 File Offset: 0x0002F680
		// Note: this type is marked as 'beforefieldinit'.
		static BMPAlloc()
		{
			Il2CppClassPointerStore<BMPAlloc>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "BMPAlloc");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BMPAlloc>.NativeClassPtr);
			BMPAlloc.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMPAlloc>.NativeClassPtr, "Invalid");
			BMPAlloc.NativeFieldInfoPtr_page = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMPAlloc>.NativeClassPtr, "page");
			BMPAlloc.NativeFieldInfoPtr_pageLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMPAlloc>.NativeClassPtr, "pageLine");
			BMPAlloc.NativeFieldInfoPtr_bitIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMPAlloc>.NativeClassPtr, "bitIndex");
			BMPAlloc.NativeFieldInfoPtr_ownedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMPAlloc>.NativeClassPtr, "ownedState");
			BMPAlloc.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMPAlloc>.NativeClassPtr, 100664269);
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00031528 File Offset: 0x0002F728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97237, XrefRangeEnd = 97249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BMPAlloc.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00007A56 File Offset: 0x00005C56
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BMPAlloc>.NativeClassPtr, ref this));
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x00031554 File Offset: 0x0002F754
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x00007A68 File Offset: 0x00005C68
		public unsafe static BMPAlloc Invalid
		{
			get
			{
				BMPAlloc bmpalloc;
				IL2CPP.il2cpp_field_static_get_value(BMPAlloc.NativeFieldInfoPtr_Invalid, (void*)(&bmpalloc));
				return bmpalloc;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BMPAlloc.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00031570 File Offset: 0x0002F770
		public bool Equals(BMPAlloc other)
		{
			return this.page == other.page && this.pageLine == other.pageLine && this.bitIndex == other.bitIndex;
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x000315B0 File Offset: 0x0002F7B0
		public bool IsValid()
		{
			return this.page >= 0;
		}

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeFieldInfoPtr_page;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeFieldInfoPtr_pageLine;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeFieldInfoPtr_bitIndex;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeFieldInfoPtr_ownedState;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000697 RID: 1687
		[FieldOffset(0)]
		public int page;

		// Token: 0x04000698 RID: 1688
		[FieldOffset(4)]
		public ushort pageLine;

		// Token: 0x04000699 RID: 1689
		[FieldOffset(6)]
		public byte bitIndex;

		// Token: 0x0400069A RID: 1690
		[FieldOffset(7)]
		public OwnedState ownedState;
	}
}
