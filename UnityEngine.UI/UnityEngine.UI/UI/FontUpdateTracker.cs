using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x02000010 RID: 16
	public static class FontUpdateTracker : Object
	{
		// Token: 0x06000141 RID: 321 RVA: 0x0000BB4C File Offset: 0x00009D4C
		// Note: this type is marked as 'beforefieldinit'.
		static FontUpdateTracker()
		{
			Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "FontUpdateTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr);
			FontUpdateTracker.NativeFieldInfoPtr_m_Tracked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr, "m_Tracked");
			FontUpdateTracker.NativeMethodInfoPtr_TrackText_Public_Static_Void_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr, 100663471);
			FontUpdateTracker.NativeMethodInfoPtr_RebuildForFont_Private_Static_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr, 100663472);
			FontUpdateTracker.NativeMethodInfoPtr_UntrackText_Public_Static_Void_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr, 100663473);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000BBCC File Offset: 0x00009DCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 110310, RefRangeEnd = 110313, XrefRangeStart = 110266, XrefRangeEnd = 110310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TrackText(Text t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontUpdateTracker.NativeMethodInfoPtr_TrackText_Public_Static_Void_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000BC04 File Offset: 0x00009E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110313, XrefRangeEnd = 110335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RebuildForFont(Font f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontUpdateTracker.NativeMethodInfoPtr_RebuildForFont_Private_Static_Void_Font_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000BC3C File Offset: 0x00009E3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 110372, RefRangeEnd = 110375, XrefRangeStart = 110335, XrefRangeEnd = 110372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UntrackText(Text t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontUpdateTracker.NativeMethodInfoPtr_UntrackText_Public_Static_Void_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000273E File Offset: 0x0000093E
		public FontUpdateTracker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0000BC74 File Offset: 0x00009E74
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00002747 File Offset: 0x00000947
		public unsafe static Dictionary<Font, HashSet<Text>> m_Tracked
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontUpdateTracker.NativeFieldInfoPtr_m_Tracked, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Font, HashSet<Text>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontUpdateTracker.NativeFieldInfoPtr_m_Tracked, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr_m_Tracked;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_TrackText_Public_Static_Void_Text_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_RebuildForFont_Private_Static_Void_Font_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_UntrackText_Public_Static_Void_Text_0;
	}
}
