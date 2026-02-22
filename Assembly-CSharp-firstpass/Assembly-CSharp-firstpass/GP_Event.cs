using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x0200005D RID: 93
public class GP_Event : global::Il2CppSystem.Object
{
	// Token: 0x060006FE RID: 1790 RVA: 0x0002EF68 File Offset: 0x0002D168
	// Note: this type is marked as 'beforefieldinit'.
	static GP_Event()
	{
		Il2CppClassPointerStore<GP_Event>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_Event");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_Event>.NativeClassPtr);
		GP_Event.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Event>.NativeClassPtr, "Id");
		GP_Event.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Event>.NativeClassPtr, "Description");
		GP_Event.NativeFieldInfoPtr_IconImageUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Event>.NativeClassPtr, "IconImageUrl");
		GP_Event.NativeFieldInfoPtr_FormattedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Event>.NativeClassPtr, "FormattedValue");
		GP_Event.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Event>.NativeClassPtr, "Value");
		GP_Event.NativeFieldInfoPtr__icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Event>.NativeClassPtr, "_icon");
		GP_Event.NativeMethodInfoPtr_LoadIcon_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Event>.NativeClassPtr, 100664141);
		GP_Event.NativeMethodInfoPtr_get_icon_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Event>.NativeClassPtr, 100664142);
		GP_Event.NativeMethodInfoPtr_OnTextureLoaded_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Event>.NativeClassPtr, 100664143);
		GP_Event.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Event>.NativeClassPtr, 100664144);
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x0002F060 File Offset: 0x0002D260
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 167041, RefRangeEnd = 167042, XrefRangeStart = 167028, XrefRangeEnd = 167041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadIcon()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Event.NativeMethodInfoPtr_LoadIcon_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000266 RID: 614
	// (get) Token: 0x06000700 RID: 1792 RVA: 0x0002F094 File Offset: 0x0002D294
	public unsafe Texture2D icon
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Event.NativeMethodInfoPtr_get_icon_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x0002F0D4 File Offset: 0x0002D2D4
	[CallerCount(0)]
	public unsafe void OnTextureLoaded(Texture2D tex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Event.NativeMethodInfoPtr_OnTextureLoaded_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x0002F118 File Offset: 0x0002D318
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_Event()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_Event>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Event.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x00004D88 File Offset: 0x00002F88
	public GP_Event(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000260 RID: 608
	// (get) Token: 0x06000704 RID: 1796 RVA: 0x0002F154 File Offset: 0x0002D354
	// (set) Token: 0x06000705 RID: 1797 RVA: 0x00004D91 File Offset: 0x00002F91
	public unsafe string Id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Event.NativeFieldInfoPtr_Id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Event.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000261 RID: 609
	// (get) Token: 0x06000706 RID: 1798 RVA: 0x0002F17C File Offset: 0x0002D37C
	// (set) Token: 0x06000707 RID: 1799 RVA: 0x00004DB0 File Offset: 0x00002FB0
	public unsafe string Description
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Event.NativeFieldInfoPtr_Description);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Event.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000262 RID: 610
	// (get) Token: 0x06000708 RID: 1800 RVA: 0x0002F1A4 File Offset: 0x0002D3A4
	// (set) Token: 0x06000709 RID: 1801 RVA: 0x00004DCF File Offset: 0x00002FCF
	public unsafe string IconImageUrl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Event.NativeFieldInfoPtr_IconImageUrl);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Event.NativeFieldInfoPtr_IconImageUrl), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000263 RID: 611
	// (get) Token: 0x0600070A RID: 1802 RVA: 0x0002F1CC File Offset: 0x0002D3CC
	// (set) Token: 0x0600070B RID: 1803 RVA: 0x00004DEE File Offset: 0x00002FEE
	public unsafe string FormattedValue
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Event.NativeFieldInfoPtr_FormattedValue);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Event.NativeFieldInfoPtr_FormattedValue), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000264 RID: 612
	// (get) Token: 0x0600070C RID: 1804 RVA: 0x0002F1F4 File Offset: 0x0002D3F4
	// (set) Token: 0x0600070D RID: 1805 RVA: 0x00004E0D File Offset: 0x0000300D
	public unsafe long Value
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Event.NativeFieldInfoPtr_Value);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Event.NativeFieldInfoPtr_Value)) = value;
		}
	}

	// Token: 0x17000265 RID: 613
	// (get) Token: 0x0600070E RID: 1806 RVA: 0x0002F21C File Offset: 0x0002D41C
	// (set) Token: 0x0600070F RID: 1807 RVA: 0x00004E28 File Offset: 0x00003028
	public unsafe Texture2D _icon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Event.NativeFieldInfoPtr__icon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Event.NativeFieldInfoPtr__icon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040005B0 RID: 1456
	private static readonly IntPtr NativeFieldInfoPtr_Id;

	// Token: 0x040005B1 RID: 1457
	private static readonly IntPtr NativeFieldInfoPtr_Description;

	// Token: 0x040005B2 RID: 1458
	private static readonly IntPtr NativeFieldInfoPtr_IconImageUrl;

	// Token: 0x040005B3 RID: 1459
	private static readonly IntPtr NativeFieldInfoPtr_FormattedValue;

	// Token: 0x040005B4 RID: 1460
	private static readonly IntPtr NativeFieldInfoPtr_Value;

	// Token: 0x040005B5 RID: 1461
	private static readonly IntPtr NativeFieldInfoPtr__icon;

	// Token: 0x040005B6 RID: 1462
	private static readonly IntPtr NativeMethodInfoPtr_LoadIcon_Public_Void_0;

	// Token: 0x040005B7 RID: 1463
	private static readonly IntPtr NativeMethodInfoPtr_get_icon_Public_get_Texture2D_0;

	// Token: 0x040005B8 RID: 1464
	private static readonly IntPtr NativeMethodInfoPtr_OnTextureLoaded_Private_Void_Texture2D_0;

	// Token: 0x040005B9 RID: 1465
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
