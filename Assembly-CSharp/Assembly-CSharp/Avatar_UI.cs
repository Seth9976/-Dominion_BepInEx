using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200009D RID: 157
public class Avatar_UI : MonoBehaviour
{
	// Token: 0x060012AA RID: 4778 RVA: 0x00052678 File Offset: 0x00050878
	// Note: this type is marked as 'beforefieldinit'.
	static Avatar_UI()
	{
		Il2CppClassPointerStore<Avatar_UI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Avatar_UI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Avatar_UI>.NativeClassPtr);
		Avatar_UI.NativeFieldInfoPtr_m_startingAvatarIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar_UI>.NativeClassPtr, "m_startingAvatarIndex");
		Avatar_UI.NativeFieldInfoPtr_m_UseLargeAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar_UI>.NativeClassPtr, "m_UseLargeAvatar");
		Avatar_UI.NativeFieldInfoPtr_m_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar_UI>.NativeClassPtr, "m_image");
		Avatar_UI.NativeFieldInfoPtr_m_avatarIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar_UI>.NativeClassPtr, "m_avatarIndex");
		Avatar_UI.NativeFieldInfoPtr_m_manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar_UI>.NativeClassPtr, "m_manager");
		Avatar_UI.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar_UI>.NativeClassPtr, 100664767);
		Avatar_UI.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar_UI>.NativeClassPtr, 100664768);
		Avatar_UI.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar_UI>.NativeClassPtr, 100664769);
		Avatar_UI.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar_UI>.NativeClassPtr, 100664770);
		Avatar_UI.NativeMethodInfoPtr_Init_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar_UI>.NativeClassPtr, 100664771);
		Avatar_UI.NativeMethodInfoPtr_SetAvatar_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar_UI>.NativeClassPtr, 100664772);
		Avatar_UI.NativeMethodInfoPtr_ReleaseAvatar_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar_UI>.NativeClassPtr, 100664773);
		Avatar_UI.NativeMethodInfoPtr_SetAvatarSpriteCallback_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar_UI>.NativeClassPtr, 100664774);
		Avatar_UI.NativeMethodInfoPtr_GetIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar_UI>.NativeClassPtr, 100664775);
		Avatar_UI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar_UI>.NativeClassPtr, 100664776);
	}

	// Token: 0x060012AB RID: 4779 RVA: 0x000527D4 File Offset: 0x000509D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243781, XrefRangeEnd = 243782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar_UI.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012AC RID: 4780 RVA: 0x00052808 File Offset: 0x00050A08
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar_UI.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012AD RID: 4781 RVA: 0x0005283C File Offset: 0x00050A3C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 243784, RefRangeEnd = 243785, XrefRangeStart = 243782, XrefRangeEnd = 243784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar_UI.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012AE RID: 4782 RVA: 0x00052870 File Offset: 0x00050A70
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 243784, RefRangeEnd = 243785, XrefRangeStart = 243784, XrefRangeEnd = 243785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar_UI.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012AF RID: 4783 RVA: 0x000528A4 File Offset: 0x00050AA4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 243818, RefRangeEnd = 243821, XrefRangeStart = 243785, XrefRangeEnd = 243818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar_UI.NativeMethodInfoPtr_Init_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012B0 RID: 4784 RVA: 0x000528D8 File Offset: 0x00050AD8
	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 243837, RefRangeEnd = 243866, XrefRangeStart = 243821, XrefRangeEnd = 243837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAvatar(int index, bool setAsStarting = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setAsStarting;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar_UI.NativeMethodInfoPtr_SetAvatar_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012B1 RID: 4785 RVA: 0x00052924 File Offset: 0x00050B24
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 243784, RefRangeEnd = 243785, XrefRangeStart = 243784, XrefRangeEnd = 243785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleaseAvatar()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar_UI.NativeMethodInfoPtr_ReleaseAvatar_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012B2 RID: 4786 RVA: 0x00052958 File Offset: 0x00050B58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243866, XrefRangeEnd = 243868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAvatarSpriteCallback(Sprite avatar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(avatar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar_UI.NativeMethodInfoPtr_SetAvatarSpriteCallback_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060012B3 RID: 4787 RVA: 0x0005299C File Offset: 0x00050B9C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar_UI.NativeMethodInfoPtr_GetIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060012B4 RID: 4788 RVA: 0x000529D8 File Offset: 0x00050BD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243868, XrefRangeEnd = 243869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Avatar_UI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Avatar_UI>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar_UI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012B5 RID: 4789 RVA: 0x0000C5C5 File Offset: 0x0000A7C5
	public Avatar_UI(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005F7 RID: 1527
	// (get) Token: 0x060012B6 RID: 4790 RVA: 0x00052A14 File Offset: 0x00050C14
	// (set) Token: 0x060012B7 RID: 4791 RVA: 0x0000C5CE File Offset: 0x0000A7CE
	public unsafe int m_startingAvatarIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar_UI.NativeFieldInfoPtr_m_startingAvatarIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar_UI.NativeFieldInfoPtr_m_startingAvatarIndex)) = value;
		}
	}

	// Token: 0x170005F8 RID: 1528
	// (get) Token: 0x060012B8 RID: 4792 RVA: 0x00052A3C File Offset: 0x00050C3C
	// (set) Token: 0x060012B9 RID: 4793 RVA: 0x0000C5E9 File Offset: 0x0000A7E9
	public unsafe bool m_UseLargeAvatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar_UI.NativeFieldInfoPtr_m_UseLargeAvatar);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar_UI.NativeFieldInfoPtr_m_UseLargeAvatar)) = value;
		}
	}

	// Token: 0x170005F9 RID: 1529
	// (get) Token: 0x060012BA RID: 4794 RVA: 0x00052A64 File Offset: 0x00050C64
	// (set) Token: 0x060012BB RID: 4795 RVA: 0x0000C604 File Offset: 0x0000A804
	public unsafe Image m_image
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar_UI.NativeFieldInfoPtr_m_image);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar_UI.NativeFieldInfoPtr_m_image), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005FA RID: 1530
	// (get) Token: 0x060012BC RID: 4796 RVA: 0x00052A94 File Offset: 0x00050C94
	// (set) Token: 0x060012BD RID: 4797 RVA: 0x0000C623 File Offset: 0x0000A823
	public unsafe int m_avatarIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar_UI.NativeFieldInfoPtr_m_avatarIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar_UI.NativeFieldInfoPtr_m_avatarIndex)) = value;
		}
	}

	// Token: 0x170005FB RID: 1531
	// (get) Token: 0x060012BE RID: 4798 RVA: 0x00052ABC File Offset: 0x00050CBC
	// (set) Token: 0x060012BF RID: 4799 RVA: 0x0000C63E File Offset: 0x0000A83E
	public unsafe AvatarManager m_manager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar_UI.NativeFieldInfoPtr_m_manager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar_UI.NativeFieldInfoPtr_m_manager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000D10 RID: 3344
	private static readonly IntPtr NativeFieldInfoPtr_m_startingAvatarIndex;

	// Token: 0x04000D11 RID: 3345
	private static readonly IntPtr NativeFieldInfoPtr_m_UseLargeAvatar;

	// Token: 0x04000D12 RID: 3346
	private static readonly IntPtr NativeFieldInfoPtr_m_image;

	// Token: 0x04000D13 RID: 3347
	private static readonly IntPtr NativeFieldInfoPtr_m_avatarIndex;

	// Token: 0x04000D14 RID: 3348
	private static readonly IntPtr NativeFieldInfoPtr_m_manager;

	// Token: 0x04000D15 RID: 3349
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000D16 RID: 3350
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x04000D17 RID: 3351
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x04000D18 RID: 3352
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04000D19 RID: 3353
	private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Void_0;

	// Token: 0x04000D1A RID: 3354
	private static readonly IntPtr NativeMethodInfoPtr_SetAvatar_Public_Void_Int32_Boolean_0;

	// Token: 0x04000D1B RID: 3355
	private static readonly IntPtr NativeMethodInfoPtr_ReleaseAvatar_Public_Void_0;

	// Token: 0x04000D1C RID: 3356
	private static readonly IntPtr NativeMethodInfoPtr_SetAvatarSpriteCallback_Public_Void_Sprite_0;

	// Token: 0x04000D1D RID: 3357
	private static readonly IntPtr NativeMethodInfoPtr_GetIndex_Public_Int32_0;

	// Token: 0x04000D1E RID: 3358
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
