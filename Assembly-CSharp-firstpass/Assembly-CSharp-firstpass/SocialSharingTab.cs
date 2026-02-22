using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using SA.AndroidNative.DynamicLinks;
using UnityEngine;

// Token: 0x02000135 RID: 309
public class SocialSharingTab : FeatureTab
{
	// Token: 0x060016C7 RID: 5831 RVA: 0x000653DC File Offset: 0x000635DC
	// Note: this type is marked as 'beforefieldinit'.
	static SocialSharingTab()
	{
		Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SocialSharingTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr);
		SocialSharingTab.NativeFieldInfoPtr_shareTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr, "shareTexture");
		SocialSharingTab.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr, 100666038);
		SocialSharingTab.NativeMethodInfoPtr_ShareText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr, 100666039);
		SocialSharingTab.NativeMethodInfoPtr_RequestDynamicLink_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr, 100666040);
		SocialSharingTab.NativeMethodInfoPtr_HandleOnShareIntentCallback_Private_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr, 100666041);
		SocialSharingTab.NativeMethodInfoPtr_ShareScreehshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr, 100666042);
		SocialSharingTab.NativeMethodInfoPtr_ShareImage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr, 100666043);
		SocialSharingTab.NativeMethodInfoPtr_TwitterShare_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr, 100666044);
		SocialSharingTab.NativeMethodInfoPtr_ShareMail_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr, 100666045);
		SocialSharingTab.NativeMethodInfoPtr_InstaShare_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr, 100666046);
		SocialSharingTab.NativeMethodInfoPtr_GoogleShare_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr, 100666047);
		SocialSharingTab.NativeMethodInfoPtr_ShareFB_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr, 100666048);
		SocialSharingTab.NativeMethodInfoPtr_ShareWhatsapp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr, 100666049);
		SocialSharingTab.NativeMethodInfoPtr_PostScreenshot_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr, 100666050);
		SocialSharingTab.NativeMethodInfoPtr_PostFBScreenshot_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr, 100666051);
		SocialSharingTab.NativeMethodInfoPtr_PostWhatsappScreenshot_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr, 100666052);
		SocialSharingTab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr, 100666053);
	}

	// Token: 0x060016C8 RID: 5832 RVA: 0x00065560 File Offset: 0x00063760
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016C9 RID: 5833 RVA: 0x00065594 File Offset: 0x00063794
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193071, XrefRangeEnd = 193090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShareText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab.NativeMethodInfoPtr_ShareText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016CA RID: 5834 RVA: 0x000655C8 File Offset: 0x000637C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193090, XrefRangeEnd = 193186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RequestDynamicLink()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab.NativeMethodInfoPtr_RequestDynamicLink_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016CB RID: 5835 RVA: 0x000655FC File Offset: 0x000637FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193186, XrefRangeEnd = 193208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleOnShareIntentCallback(bool status, string package)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref status;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(package);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab.NativeMethodInfoPtr_HandleOnShareIntentCallback_Private_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016CC RID: 5836 RVA: 0x0006564C File Offset: 0x0006384C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193208, XrefRangeEnd = 193213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShareScreehshot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab.NativeMethodInfoPtr_ShareScreehshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016CD RID: 5837 RVA: 0x00065680 File Offset: 0x00063880
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193213, XrefRangeEnd = 193223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShareImage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab.NativeMethodInfoPtr_ShareImage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016CE RID: 5838 RVA: 0x000656B4 File Offset: 0x000638B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193223, XrefRangeEnd = 193233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TwitterShare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab.NativeMethodInfoPtr_TwitterShare_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016CF RID: 5839 RVA: 0x000656E8 File Offset: 0x000638E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193233, XrefRangeEnd = 193245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShareMail()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab.NativeMethodInfoPtr_ShareMail_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016D0 RID: 5840 RVA: 0x0006571C File Offset: 0x0006391C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193245, XrefRangeEnd = 193255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InstaShare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab.NativeMethodInfoPtr_InstaShare_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016D1 RID: 5841 RVA: 0x00065750 File Offset: 0x00063950
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193255, XrefRangeEnd = 193261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GoogleShare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab.NativeMethodInfoPtr_GoogleShare_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016D2 RID: 5842 RVA: 0x00065784 File Offset: 0x00063984
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193261, XrefRangeEnd = 193266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShareFB()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab.NativeMethodInfoPtr_ShareFB_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016D3 RID: 5843 RVA: 0x000657B8 File Offset: 0x000639B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193266, XrefRangeEnd = 193271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShareWhatsapp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab.NativeMethodInfoPtr_ShareWhatsapp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016D4 RID: 5844 RVA: 0x000657EC File Offset: 0x000639EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193271, XrefRangeEnd = 193275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator PostScreenshot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab.NativeMethodInfoPtr_PostScreenshot_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060016D5 RID: 5845 RVA: 0x0006582C File Offset: 0x00063A2C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193275, XrefRangeEnd = 193279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator PostFBScreenshot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab.NativeMethodInfoPtr_PostFBScreenshot_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060016D6 RID: 5846 RVA: 0x0006586C File Offset: 0x00063A6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193279, XrefRangeEnd = 193283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator PostWhatsappScreenshot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab.NativeMethodInfoPtr_PostWhatsappScreenshot_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060016D7 RID: 5847 RVA: 0x000658AC File Offset: 0x00063AAC
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 114494, RefRangeEnd = 114502, XrefRangeStart = 114494, XrefRangeEnd = 114502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SocialSharingTab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016D8 RID: 5848 RVA: 0x0000B21E File Offset: 0x0000941E
	public SocialSharingTab(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700067A RID: 1658
	// (get) Token: 0x060016D9 RID: 5849 RVA: 0x000658E8 File Offset: 0x00063AE8
	// (set) Token: 0x060016DA RID: 5850 RVA: 0x0000B227 File Offset: 0x00009427
	public unsafe Texture2D shareTexture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialSharingTab.NativeFieldInfoPtr_shareTexture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialSharingTab.NativeFieldInfoPtr_shareTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04001131 RID: 4401
	private static readonly IntPtr NativeFieldInfoPtr_shareTexture;

	// Token: 0x04001132 RID: 4402
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04001133 RID: 4403
	private static readonly IntPtr NativeMethodInfoPtr_ShareText_Public_Void_0;

	// Token: 0x04001134 RID: 4404
	private static readonly IntPtr NativeMethodInfoPtr_RequestDynamicLink_Public_Void_0;

	// Token: 0x04001135 RID: 4405
	private static readonly IntPtr NativeMethodInfoPtr_HandleOnShareIntentCallback_Private_Void_Boolean_String_0;

	// Token: 0x04001136 RID: 4406
	private static readonly IntPtr NativeMethodInfoPtr_ShareScreehshot_Public_Void_0;

	// Token: 0x04001137 RID: 4407
	private static readonly IntPtr NativeMethodInfoPtr_ShareImage_Public_Void_0;

	// Token: 0x04001138 RID: 4408
	private static readonly IntPtr NativeMethodInfoPtr_TwitterShare_Public_Void_0;

	// Token: 0x04001139 RID: 4409
	private static readonly IntPtr NativeMethodInfoPtr_ShareMail_Public_Void_0;

	// Token: 0x0400113A RID: 4410
	private static readonly IntPtr NativeMethodInfoPtr_InstaShare_Public_Void_0;

	// Token: 0x0400113B RID: 4411
	private static readonly IntPtr NativeMethodInfoPtr_GoogleShare_Public_Void_0;

	// Token: 0x0400113C RID: 4412
	private static readonly IntPtr NativeMethodInfoPtr_ShareFB_Public_Void_0;

	// Token: 0x0400113D RID: 4413
	private static readonly IntPtr NativeMethodInfoPtr_ShareWhatsapp_Public_Void_0;

	// Token: 0x0400113E RID: 4414
	private static readonly IntPtr NativeMethodInfoPtr_PostScreenshot_Private_IEnumerator_0;

	// Token: 0x0400113F RID: 4415
	private static readonly IntPtr NativeMethodInfoPtr_PostFBScreenshot_Private_IEnumerator_0;

	// Token: 0x04001140 RID: 4416
	private static readonly IntPtr NativeMethodInfoPtr_PostWhatsappScreenshot_Private_IEnumerator_0;

	// Token: 0x04001141 RID: 4417
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200039F RID: 927
	[ObfuscatedName("SocialSharingTab+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x060036D2 RID: 14034 RVA: 0x000E0840 File Offset: 0x000DEA40
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<SocialSharingTab.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocialSharingTab.__c>.NativeClassPtr);
			SocialSharingTab.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialSharingTab.__c>.NativeClassPtr, "<>9");
			SocialSharingTab.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialSharingTab.__c>.NativeClassPtr, "<>9__3_0");
			SocialSharingTab.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab.__c>.NativeClassPtr, 100670265);
			SocialSharingTab.__c.NativeMethodInfoPtr__RequestDynamicLink_b__3_0_Internal_Void_ShortLinkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab.__c>.NativeClassPtr, 100670266);
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x000E08BC File Offset: 0x000DEABC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocialSharingTab.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x000E08F8 File Offset: 0x000DEAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193018, XrefRangeEnd = 193026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RequestDynamicLink_b__3_0(ShortLinkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab.__c.NativeMethodInfoPtr__RequestDynamicLink_b__3_0_Internal_Void_ShortLinkResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036D5 RID: 14037 RVA: 0x00015405 File Offset: 0x00013605
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x060036D6 RID: 14038 RVA: 0x000E093C File Offset: 0x000DEB3C
		// (set) Token: 0x060036D7 RID: 14039 RVA: 0x0001540E File Offset: 0x0001360E
		public unsafe static SocialSharingTab.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SocialSharingTab.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SocialSharingTab.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SocialSharingTab.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x060036D8 RID: 14040 RVA: 0x000E0964 File Offset: 0x000DEB64
		// (set) Token: 0x060036D9 RID: 14041 RVA: 0x00015420 File Offset: 0x00013620
		public unsafe static Action<ShortLinkResult> __9__3_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SocialSharingTab.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ShortLinkResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SocialSharingTab.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003204 RID: 12804
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04003205 RID: 12805
		private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

		// Token: 0x04003206 RID: 12806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003207 RID: 12807
		private static readonly IntPtr NativeMethodInfoPtr__RequestDynamicLink_b__3_0_Internal_Void_ShortLinkResult_0;
	}

	// Token: 0x020003A0 RID: 928
	[ObfuscatedName("SocialSharingTab+<PostScreenshot>d__13")]
	public sealed class _PostScreenshot_d__13 : global::Il2CppSystem.Object
	{
		// Token: 0x060036DA RID: 14042 RVA: 0x000E098C File Offset: 0x000DEB8C
		// Note: this type is marked as 'beforefieldinit'.
		static _PostScreenshot_d__13()
		{
			Il2CppClassPointerStore<SocialSharingTab._PostScreenshot_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr, "<PostScreenshot>d__13");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocialSharingTab._PostScreenshot_d__13>.NativeClassPtr);
			SocialSharingTab._PostScreenshot_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialSharingTab._PostScreenshot_d__13>.NativeClassPtr, "<>1__state");
			SocialSharingTab._PostScreenshot_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialSharingTab._PostScreenshot_d__13>.NativeClassPtr, "<>2__current");
			SocialSharingTab._PostScreenshot_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab._PostScreenshot_d__13>.NativeClassPtr, 100670267);
			SocialSharingTab._PostScreenshot_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab._PostScreenshot_d__13>.NativeClassPtr, 100670268);
			SocialSharingTab._PostScreenshot_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab._PostScreenshot_d__13>.NativeClassPtr, 100670269);
			SocialSharingTab._PostScreenshot_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab._PostScreenshot_d__13>.NativeClassPtr, 100670270);
			SocialSharingTab._PostScreenshot_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab._PostScreenshot_d__13>.NativeClassPtr, 100670271);
			SocialSharingTab._PostScreenshot_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab._PostScreenshot_d__13>.NativeClassPtr, 100670272);
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x000E0A58 File Offset: 0x000DEC58
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _PostScreenshot_d__13(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocialSharingTab._PostScreenshot_d__13>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab._PostScreenshot_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x000E0AA0 File Offset: 0x000DECA0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab._PostScreenshot_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x000E0AD4 File Offset: 0x000DECD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193026, XrefRangeEnd = 193036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab._PostScreenshot_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x060036DE RID: 14046 RVA: 0x000E0B10 File Offset: 0x000DED10
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab._PostScreenshot_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x000E0B50 File Offset: 0x000DED50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193036, XrefRangeEnd = 193041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab._PostScreenshot_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x060036E0 RID: 14048 RVA: 0x000E0B84 File Offset: 0x000DED84
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab._PostScreenshot_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x00015432 File Offset: 0x00013632
		public _PostScreenshot_d__13(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x060036E2 RID: 14050 RVA: 0x000E0BC4 File Offset: 0x000DEDC4
		// (set) Token: 0x060036E3 RID: 14051 RVA: 0x0001543B File Offset: 0x0001363B
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialSharingTab._PostScreenshot_d__13.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialSharingTab._PostScreenshot_d__13.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x060036E4 RID: 14052 RVA: 0x000E0BEC File Offset: 0x000DEDEC
		// (set) Token: 0x060036E5 RID: 14053 RVA: 0x00015456 File Offset: 0x00013656
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialSharingTab._PostScreenshot_d__13.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialSharingTab._PostScreenshot_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003208 RID: 12808
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04003209 RID: 12809
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400320A RID: 12810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400320B RID: 12811
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400320C RID: 12812
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400320D RID: 12813
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400320E RID: 12814
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400320F RID: 12815
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020003A1 RID: 929
	[ObfuscatedName("SocialSharingTab+<PostFBScreenshot>d__14")]
	public sealed class _PostFBScreenshot_d__14 : global::Il2CppSystem.Object
	{
		// Token: 0x060036E6 RID: 14054 RVA: 0x000E0C1C File Offset: 0x000DEE1C
		// Note: this type is marked as 'beforefieldinit'.
		static _PostFBScreenshot_d__14()
		{
			Il2CppClassPointerStore<SocialSharingTab._PostFBScreenshot_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr, "<PostFBScreenshot>d__14");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocialSharingTab._PostFBScreenshot_d__14>.NativeClassPtr);
			SocialSharingTab._PostFBScreenshot_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialSharingTab._PostFBScreenshot_d__14>.NativeClassPtr, "<>1__state");
			SocialSharingTab._PostFBScreenshot_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialSharingTab._PostFBScreenshot_d__14>.NativeClassPtr, "<>2__current");
			SocialSharingTab._PostFBScreenshot_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab._PostFBScreenshot_d__14>.NativeClassPtr, 100670273);
			SocialSharingTab._PostFBScreenshot_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab._PostFBScreenshot_d__14>.NativeClassPtr, 100670274);
			SocialSharingTab._PostFBScreenshot_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab._PostFBScreenshot_d__14>.NativeClassPtr, 100670275);
			SocialSharingTab._PostFBScreenshot_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab._PostFBScreenshot_d__14>.NativeClassPtr, 100670276);
			SocialSharingTab._PostFBScreenshot_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab._PostFBScreenshot_d__14>.NativeClassPtr, 100670277);
			SocialSharingTab._PostFBScreenshot_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab._PostFBScreenshot_d__14>.NativeClassPtr, 100670278);
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x000E0CE8 File Offset: 0x000DEEE8
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _PostFBScreenshot_d__14(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocialSharingTab._PostFBScreenshot_d__14>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab._PostFBScreenshot_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036E8 RID: 14056 RVA: 0x000E0D30 File Offset: 0x000DEF30
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab._PostFBScreenshot_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x000E0D64 File Offset: 0x000DEF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193041, XrefRangeEnd = 193051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab._PostFBScreenshot_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x060036EA RID: 14058 RVA: 0x000E0DA0 File Offset: 0x000DEFA0
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab._PostFBScreenshot_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x000E0DE0 File Offset: 0x000DEFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193051, XrefRangeEnd = 193056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab._PostFBScreenshot_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x060036EC RID: 14060 RVA: 0x000E0E14 File Offset: 0x000DF014
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab._PostFBScreenshot_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x00015475 File Offset: 0x00013675
		public _PostFBScreenshot_d__14(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x060036EE RID: 14062 RVA: 0x000E0E54 File Offset: 0x000DF054
		// (set) Token: 0x060036EF RID: 14063 RVA: 0x0001547E File Offset: 0x0001367E
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialSharingTab._PostFBScreenshot_d__14.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialSharingTab._PostFBScreenshot_d__14.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x060036F0 RID: 14064 RVA: 0x000E0E7C File Offset: 0x000DF07C
		// (set) Token: 0x060036F1 RID: 14065 RVA: 0x00015499 File Offset: 0x00013699
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialSharingTab._PostFBScreenshot_d__14.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialSharingTab._PostFBScreenshot_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003210 RID: 12816
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04003211 RID: 12817
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04003212 RID: 12818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003213 RID: 12819
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003214 RID: 12820
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04003215 RID: 12821
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04003216 RID: 12822
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003217 RID: 12823
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020003A2 RID: 930
	[ObfuscatedName("SocialSharingTab+<PostWhatsappScreenshot>d__15")]
	public sealed class _PostWhatsappScreenshot_d__15 : global::Il2CppSystem.Object
	{
		// Token: 0x060036F2 RID: 14066 RVA: 0x000E0EAC File Offset: 0x000DF0AC
		// Note: this type is marked as 'beforefieldinit'.
		static _PostWhatsappScreenshot_d__15()
		{
			Il2CppClassPointerStore<SocialSharingTab._PostWhatsappScreenshot_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SocialSharingTab>.NativeClassPtr, "<PostWhatsappScreenshot>d__15");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocialSharingTab._PostWhatsappScreenshot_d__15>.NativeClassPtr);
			SocialSharingTab._PostWhatsappScreenshot_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialSharingTab._PostWhatsappScreenshot_d__15>.NativeClassPtr, "<>1__state");
			SocialSharingTab._PostWhatsappScreenshot_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialSharingTab._PostWhatsappScreenshot_d__15>.NativeClassPtr, "<>2__current");
			SocialSharingTab._PostWhatsappScreenshot_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab._PostWhatsappScreenshot_d__15>.NativeClassPtr, 100670279);
			SocialSharingTab._PostWhatsappScreenshot_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab._PostWhatsappScreenshot_d__15>.NativeClassPtr, 100670280);
			SocialSharingTab._PostWhatsappScreenshot_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab._PostWhatsappScreenshot_d__15>.NativeClassPtr, 100670281);
			SocialSharingTab._PostWhatsappScreenshot_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab._PostWhatsappScreenshot_d__15>.NativeClassPtr, 100670282);
			SocialSharingTab._PostWhatsappScreenshot_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab._PostWhatsappScreenshot_d__15>.NativeClassPtr, 100670283);
			SocialSharingTab._PostWhatsappScreenshot_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialSharingTab._PostWhatsappScreenshot_d__15>.NativeClassPtr, 100670284);
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x000E0F78 File Offset: 0x000DF178
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _PostWhatsappScreenshot_d__15(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocialSharingTab._PostWhatsappScreenshot_d__15>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab._PostWhatsappScreenshot_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x000E0FC0 File Offset: 0x000DF1C0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab._PostWhatsappScreenshot_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x000E0FF4 File Offset: 0x000DF1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193056, XrefRangeEnd = 193066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab._PostWhatsappScreenshot_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x060036F6 RID: 14070 RVA: 0x000E1030 File Offset: 0x000DF230
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab._PostWhatsappScreenshot_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x000E1070 File Offset: 0x000DF270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193066, XrefRangeEnd = 193071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab._PostWhatsappScreenshot_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x060036F8 RID: 14072 RVA: 0x000E10A4 File Offset: 0x000DF2A4
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialSharingTab._PostWhatsappScreenshot_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x000154B8 File Offset: 0x000136B8
		public _PostWhatsappScreenshot_d__15(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x060036FA RID: 14074 RVA: 0x000E10E4 File Offset: 0x000DF2E4
		// (set) Token: 0x060036FB RID: 14075 RVA: 0x000154C1 File Offset: 0x000136C1
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialSharingTab._PostWhatsappScreenshot_d__15.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialSharingTab._PostWhatsappScreenshot_d__15.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x060036FC RID: 14076 RVA: 0x000E110C File Offset: 0x000DF30C
		// (set) Token: 0x060036FD RID: 14077 RVA: 0x000154DC File Offset: 0x000136DC
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialSharingTab._PostWhatsappScreenshot_d__15.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialSharingTab._PostWhatsappScreenshot_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003218 RID: 12824
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04003219 RID: 12825
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400321A RID: 12826
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400321B RID: 12827
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400321C RID: 12828
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400321D RID: 12829
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400321E RID: 12830
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400321F RID: 12831
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
