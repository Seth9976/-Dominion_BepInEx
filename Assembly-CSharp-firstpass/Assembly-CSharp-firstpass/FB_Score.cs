using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000097 RID: 151
public class FB_Score : global::Il2CppSystem.Object
{
	// Token: 0x06000ADB RID: 2779 RVA: 0x0003D358 File Offset: 0x0003B558
	// Note: this type is marked as 'beforefieldinit'.
	static FB_Score()
	{
		Il2CppClassPointerStore<FB_Score>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FB_Score");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FB_Score>.NativeClassPtr);
		FB_Score.NativeFieldInfoPtr_UserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_Score>.NativeClassPtr, "UserId");
		FB_Score.NativeFieldInfoPtr_UserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_Score>.NativeClassPtr, "UserName");
		FB_Score.NativeFieldInfoPtr_AppId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_Score>.NativeClassPtr, "AppId");
		FB_Score.NativeFieldInfoPtr_AppName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_Score>.NativeClassPtr, "AppName");
		FB_Score.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_Score>.NativeClassPtr, "value");
		FB_Score.NativeFieldInfoPtr_profileImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_Score>.NativeClassPtr, "profileImages");
		FB_Score.NativeFieldInfoPtr_OnProfileImageLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_Score>.NativeClassPtr, "OnProfileImageLoaded");
		FB_Score.NativeMethodInfoPtr_add_OnProfileImageLoaded_Public_add_Void_Action_1_FB_Score_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Score>.NativeClassPtr, 100664619);
		FB_Score.NativeMethodInfoPtr_remove_OnProfileImageLoaded_Public_rem_Void_Action_1_FB_Score_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Score>.NativeClassPtr, 100664620);
		FB_Score.NativeMethodInfoPtr_GetProfileUrl_Public_String_FB_ProfileImageSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Score>.NativeClassPtr, 100664621);
		FB_Score.NativeMethodInfoPtr_GetProfileImage_Public_Texture2D_FB_ProfileImageSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Score>.NativeClassPtr, 100664622);
		FB_Score.NativeMethodInfoPtr_LoadProfileImage_Public_Void_FB_ProfileImageSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Score>.NativeClassPtr, 100664623);
		FB_Score.NativeMethodInfoPtr_OnSquareImageLoaded_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Score>.NativeClassPtr, 100664624);
		FB_Score.NativeMethodInfoPtr_OnLargeImageLoaded_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Score>.NativeClassPtr, 100664625);
		FB_Score.NativeMethodInfoPtr_OnNormalImageLoaded_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Score>.NativeClassPtr, 100664626);
		FB_Score.NativeMethodInfoPtr_OnSmallImageLoaded_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Score>.NativeClassPtr, 100664627);
		FB_Score.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Score>.NativeClassPtr, 100664628);
	}

	// Token: 0x06000ADC RID: 2780 RVA: 0x0003D4DC File Offset: 0x0003B6DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173637, XrefRangeEnd = 173641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnProfileImageLoaded(Action<FB_Score> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Score.NativeMethodInfoPtr_add_OnProfileImageLoaded_Public_add_Void_Action_1_FB_Score_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000ADD RID: 2781 RVA: 0x0003D520 File Offset: 0x0003B720
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173641, XrefRangeEnd = 173645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnProfileImageLoaded(Action<FB_Score> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Score.NativeMethodInfoPtr_remove_OnProfileImageLoaded_Public_rem_Void_Action_1_FB_Score_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000ADE RID: 2782 RVA: 0x0003D564 File Offset: 0x0003B764
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 173654, RefRangeEnd = 173659, XrefRangeStart = 173645, XrefRangeEnd = 173654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetProfileUrl(FB_ProfileImageSize size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Score.NativeMethodInfoPtr_GetProfileUrl_Public_String_FB_ProfileImageSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000ADF RID: 2783 RVA: 0x0003D5A8 File Offset: 0x0003B7A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173659, XrefRangeEnd = 173663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2D GetProfileImage(FB_ProfileImageSize size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Score.NativeMethodInfoPtr_GetProfileImage_Public_Texture2D_FB_ProfileImageSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x0003D5F4 File Offset: 0x0003B7F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173663, XrefRangeEnd = 173723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadProfileImage(FB_ProfileImageSize size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Score.NativeMethodInfoPtr_LoadProfileImage_Public_Void_FB_ProfileImageSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000AE1 RID: 2785 RVA: 0x0003D634 File Offset: 0x0003B834
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173723, XrefRangeEnd = 173736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSquareImageLoaded(Texture2D image)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Score.NativeMethodInfoPtr_OnSquareImageLoaded_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000AE2 RID: 2786 RVA: 0x0003D678 File Offset: 0x0003B878
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173736, XrefRangeEnd = 173749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLargeImageLoaded(Texture2D image)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Score.NativeMethodInfoPtr_OnLargeImageLoaded_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x0003D6BC File Offset: 0x0003B8BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173749, XrefRangeEnd = 173762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnNormalImageLoaded(Texture2D image)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Score.NativeMethodInfoPtr_OnNormalImageLoaded_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000AE4 RID: 2788 RVA: 0x0003D700 File Offset: 0x0003B900
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173762, XrefRangeEnd = 173775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSmallImageLoaded(Texture2D image)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Score.NativeMethodInfoPtr_OnSmallImageLoaded_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x0003D744 File Offset: 0x0003B944
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 173797, RefRangeEnd = 173803, XrefRangeStart = 173775, XrefRangeEnd = 173797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FB_Score()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FB_Score>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Score.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AE6 RID: 2790 RVA: 0x0000645C File Offset: 0x0000465C
	public FB_Score(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700036C RID: 876
	// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x0003D780 File Offset: 0x0003B980
	// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x00006465 File Offset: 0x00004665
	public unsafe string UserId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Score.NativeFieldInfoPtr_UserId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Score.NativeFieldInfoPtr_UserId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700036D RID: 877
	// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x0003D7A8 File Offset: 0x0003B9A8
	// (set) Token: 0x06000AEA RID: 2794 RVA: 0x00006484 File Offset: 0x00004684
	public unsafe string UserName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Score.NativeFieldInfoPtr_UserName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Score.NativeFieldInfoPtr_UserName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700036E RID: 878
	// (get) Token: 0x06000AEB RID: 2795 RVA: 0x0003D7D0 File Offset: 0x0003B9D0
	// (set) Token: 0x06000AEC RID: 2796 RVA: 0x000064A3 File Offset: 0x000046A3
	public unsafe string AppId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Score.NativeFieldInfoPtr_AppId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Score.NativeFieldInfoPtr_AppId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700036F RID: 879
	// (get) Token: 0x06000AED RID: 2797 RVA: 0x0003D7F8 File Offset: 0x0003B9F8
	// (set) Token: 0x06000AEE RID: 2798 RVA: 0x000064C2 File Offset: 0x000046C2
	public unsafe string AppName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Score.NativeFieldInfoPtr_AppName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Score.NativeFieldInfoPtr_AppName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000370 RID: 880
	// (get) Token: 0x06000AEF RID: 2799 RVA: 0x0003D820 File Offset: 0x0003BA20
	// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x000064E1 File Offset: 0x000046E1
	public unsafe int value
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Score.NativeFieldInfoPtr_value);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Score.NativeFieldInfoPtr_value)) = value;
		}
	}

	// Token: 0x17000371 RID: 881
	// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x0003D848 File Offset: 0x0003BA48
	// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x000064FC File Offset: 0x000046FC
	public unsafe Dictionary<FB_ProfileImageSize, Texture2D> profileImages
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Score.NativeFieldInfoPtr_profileImages);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<FB_ProfileImageSize, Texture2D>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Score.NativeFieldInfoPtr_profileImages), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000372 RID: 882
	// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x0003D878 File Offset: 0x0003BA78
	// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x0000651B File Offset: 0x0000471B
	public unsafe Action<FB_Score> OnProfileImageLoaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Score.NativeFieldInfoPtr_OnProfileImageLoaded);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FB_Score>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Score.NativeFieldInfoPtr_OnProfileImageLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040008AA RID: 2218
	private static readonly IntPtr NativeFieldInfoPtr_UserId;

	// Token: 0x040008AB RID: 2219
	private static readonly IntPtr NativeFieldInfoPtr_UserName;

	// Token: 0x040008AC RID: 2220
	private static readonly IntPtr NativeFieldInfoPtr_AppId;

	// Token: 0x040008AD RID: 2221
	private static readonly IntPtr NativeFieldInfoPtr_AppName;

	// Token: 0x040008AE RID: 2222
	private static readonly IntPtr NativeFieldInfoPtr_value;

	// Token: 0x040008AF RID: 2223
	private static readonly IntPtr NativeFieldInfoPtr_profileImages;

	// Token: 0x040008B0 RID: 2224
	private static readonly IntPtr NativeFieldInfoPtr_OnProfileImageLoaded;

	// Token: 0x040008B1 RID: 2225
	private static readonly IntPtr NativeMethodInfoPtr_add_OnProfileImageLoaded_Public_add_Void_Action_1_FB_Score_0;

	// Token: 0x040008B2 RID: 2226
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnProfileImageLoaded_Public_rem_Void_Action_1_FB_Score_0;

	// Token: 0x040008B3 RID: 2227
	private static readonly IntPtr NativeMethodInfoPtr_GetProfileUrl_Public_String_FB_ProfileImageSize_0;

	// Token: 0x040008B4 RID: 2228
	private static readonly IntPtr NativeMethodInfoPtr_GetProfileImage_Public_Texture2D_FB_ProfileImageSize_0;

	// Token: 0x040008B5 RID: 2229
	private static readonly IntPtr NativeMethodInfoPtr_LoadProfileImage_Public_Void_FB_ProfileImageSize_0;

	// Token: 0x040008B6 RID: 2230
	private static readonly IntPtr NativeMethodInfoPtr_OnSquareImageLoaded_Private_Void_Texture2D_0;

	// Token: 0x040008B7 RID: 2231
	private static readonly IntPtr NativeMethodInfoPtr_OnLargeImageLoaded_Private_Void_Texture2D_0;

	// Token: 0x040008B8 RID: 2232
	private static readonly IntPtr NativeMethodInfoPtr_OnNormalImageLoaded_Private_Void_Texture2D_0;

	// Token: 0x040008B9 RID: 2233
	private static readonly IntPtr NativeMethodInfoPtr_OnSmallImageLoaded_Private_Void_Texture2D_0;

	// Token: 0x040008BA RID: 2234
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200037E RID: 894
	[ObfuscatedName("FB_Score+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x06003566 RID: 13670 RVA: 0x000DC59C File Offset: 0x000DA79C
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<FB_Score.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FB_Score>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FB_Score.__c>.NativeClassPtr);
			FB_Score.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_Score.__c>.NativeClassPtr, "<>9");
			FB_Score.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_Score.__c>.NativeClassPtr, "<>9__16_0");
			FB_Score.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Score.__c>.NativeClassPtr, 100670118);
			FB_Score.__c.NativeMethodInfoPtr___ctor_b__16_0_Internal_Void_FB_Score_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Score.__c>.NativeClassPtr, 100670119);
		}

		// Token: 0x06003567 RID: 13671 RVA: 0x000DC618 File Offset: 0x000DA818
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FB_Score.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Score.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003568 RID: 13672 RVA: 0x000DC654 File Offset: 0x000DA854
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__16_0(FB_Score <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Score.__c.NativeMethodInfoPtr___ctor_b__16_0_Internal_Void_FB_Score_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003569 RID: 13673 RVA: 0x00014B05 File Offset: 0x00012D05
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x0600356A RID: 13674 RVA: 0x000DC698 File Offset: 0x000DA898
		// (set) Token: 0x0600356B RID: 13675 RVA: 0x00014B0E File Offset: 0x00012D0E
		public unsafe static FB_Score.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FB_Score.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FB_Score.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FB_Score.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x0600356C RID: 13676 RVA: 0x000DC6C0 File Offset: 0x000DA8C0
		// (set) Token: 0x0600356D RID: 13677 RVA: 0x00014B20 File Offset: 0x00012D20
		public unsafe static Action<FB_Score> __9__16_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FB_Score.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FB_Score>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FB_Score.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003131 RID: 12593
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04003132 RID: 12594
		private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

		// Token: 0x04003133 RID: 12595
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003134 RID: 12596
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__16_0_Internal_Void_FB_Score_0;
	}
}
