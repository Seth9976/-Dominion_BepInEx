using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200018B RID: 395
	public sealed class OverlayBrowserProtocolNavigation_t : ValueType
	{
		// Token: 0x0600214A RID: 8522 RVA: 0x000A0958 File Offset: 0x0009EB58
		// Note: this type is marked as 'beforefieldinit'.
		static OverlayBrowserProtocolNavigation_t()
		{
			Il2CppClassPointerStore<OverlayBrowserProtocolNavigation_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "OverlayBrowserProtocolNavigation_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverlayBrowserProtocolNavigation_t>.NativeClassPtr);
			OverlayBrowserProtocolNavigation_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayBrowserProtocolNavigation_t>.NativeClassPtr, "k_iCallback");
			OverlayBrowserProtocolNavigation_t.NativeFieldInfoPtr_rgchURI_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayBrowserProtocolNavigation_t>.NativeClassPtr, "rgchURI_");
			OverlayBrowserProtocolNavigation_t.NativeMethodInfoPtr_get_rgchURI_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayBrowserProtocolNavigation_t>.NativeClassPtr, 100668337);
			OverlayBrowserProtocolNavigation_t.NativeMethodInfoPtr_set_rgchURI_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayBrowserProtocolNavigation_t>.NativeClassPtr, 100668338);
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x0600214B RID: 8523 RVA: 0x000A09D8 File Offset: 0x0009EBD8
		// (set) Token: 0x0600214C RID: 8524 RVA: 0x000A0A14 File Offset: 0x0009EC14
		public unsafe string rgchURI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayBrowserProtocolNavigation_t.NativeMethodInfoPtr_get_rgchURI_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206861, XrefRangeEnd = 206862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayBrowserProtocolNavigation_t.NativeMethodInfoPtr_set_rgchURI_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x0000C13B File Offset: 0x0000A33B
		public OverlayBrowserProtocolNavigation_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x0000C144 File Offset: 0x0000A344
		public OverlayBrowserProtocolNavigation_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayBrowserProtocolNavigation_t>.NativeClassPtr))
		{
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x000A0A5C File Offset: 0x0009EC5C
		// (set) Token: 0x06002150 RID: 8528 RVA: 0x0000C156 File Offset: 0x0000A356
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(OverlayBrowserProtocolNavigation_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OverlayBrowserProtocolNavigation_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06002151 RID: 8529 RVA: 0x000A0A78 File Offset: 0x0009EC78
		// (set) Token: 0x06002152 RID: 8530 RVA: 0x0000C164 File Offset: 0x0000A364
		public unsafe Il2CppStructArray<byte> rgchURI_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayBrowserProtocolNavigation_t.NativeFieldInfoPtr_rgchURI_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayBrowserProtocolNavigation_t.NativeFieldInfoPtr_rgchURI_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B06 RID: 6918
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B07 RID: 6919
		private static readonly IntPtr NativeFieldInfoPtr_rgchURI_;

		// Token: 0x04001B08 RID: 6920
		private static readonly IntPtr NativeMethodInfoPtr_get_rgchURI_Public_get_String_0;

		// Token: 0x04001B09 RID: 6921
		private static readonly IntPtr NativeMethodInfoPtr_set_rgchURI_Public_set_Void_String_0;
	}
}
