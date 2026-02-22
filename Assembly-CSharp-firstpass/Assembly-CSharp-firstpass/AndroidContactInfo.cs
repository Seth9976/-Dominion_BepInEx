using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x020000F4 RID: 244
public class AndroidContactInfo : global::Il2CppSystem.Object
{
	// Token: 0x06001127 RID: 4391 RVA: 0x000530FC File Offset: 0x000512FC
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidContactInfo()
	{
		Il2CppClassPointerStore<AndroidContactInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidContactInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidContactInfo>.NativeClassPtr);
		AndroidContactInfo.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidContactInfo>.NativeClassPtr, "name");
		AndroidContactInfo.NativeFieldInfoPtr_phone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidContactInfo>.NativeClassPtr, "phone");
		AndroidContactInfo.NativeFieldInfoPtr_note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidContactInfo>.NativeClassPtr, "note");
		AndroidContactInfo.NativeFieldInfoPtr_email = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidContactInfo>.NativeClassPtr, "email");
		AndroidContactInfo.NativeFieldInfoPtr_chat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidContactInfo>.NativeClassPtr, "chat");
		AndroidContactInfo.NativeFieldInfoPtr_address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidContactInfo>.NativeClassPtr, "address");
		AndroidContactInfo.NativeFieldInfoPtr_organization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidContactInfo>.NativeClassPtr, "organization");
		AndroidContactInfo.NativeFieldInfoPtr_photo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidContactInfo>.NativeClassPtr, "photo");
		AndroidContactInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidContactInfo>.NativeClassPtr, 100665397);
	}

	// Token: 0x06001128 RID: 4392 RVA: 0x000531E0 File Offset: 0x000513E0
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidContactInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidContactInfo>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidContactInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001129 RID: 4393 RVA: 0x000088C6 File Offset: 0x00006AC6
	public AndroidContactInfo(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000515 RID: 1301
	// (get) Token: 0x0600112A RID: 4394 RVA: 0x0005321C File Offset: 0x0005141C
	// (set) Token: 0x0600112B RID: 4395 RVA: 0x000088CF File Offset: 0x00006ACF
	public unsafe string name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidContactInfo.NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidContactInfo.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000516 RID: 1302
	// (get) Token: 0x0600112C RID: 4396 RVA: 0x00053244 File Offset: 0x00051444
	// (set) Token: 0x0600112D RID: 4397 RVA: 0x000088EE File Offset: 0x00006AEE
	public unsafe string phone
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidContactInfo.NativeFieldInfoPtr_phone);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidContactInfo.NativeFieldInfoPtr_phone), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000517 RID: 1303
	// (get) Token: 0x0600112E RID: 4398 RVA: 0x0005326C File Offset: 0x0005146C
	// (set) Token: 0x0600112F RID: 4399 RVA: 0x0000890D File Offset: 0x00006B0D
	public unsafe string note
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidContactInfo.NativeFieldInfoPtr_note);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidContactInfo.NativeFieldInfoPtr_note), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000518 RID: 1304
	// (get) Token: 0x06001130 RID: 4400 RVA: 0x00053294 File Offset: 0x00051494
	// (set) Token: 0x06001131 RID: 4401 RVA: 0x0000892C File Offset: 0x00006B2C
	public unsafe AndroidABEmail email
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidContactInfo.NativeFieldInfoPtr_email);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidABEmail>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidContactInfo.NativeFieldInfoPtr_email), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000519 RID: 1305
	// (get) Token: 0x06001132 RID: 4402 RVA: 0x000532C4 File Offset: 0x000514C4
	// (set) Token: 0x06001133 RID: 4403 RVA: 0x0000894B File Offset: 0x00006B4B
	public unsafe AndroidABChat chat
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidContactInfo.NativeFieldInfoPtr_chat);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidABChat>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidContactInfo.NativeFieldInfoPtr_chat), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700051A RID: 1306
	// (get) Token: 0x06001134 RID: 4404 RVA: 0x000532F4 File Offset: 0x000514F4
	// (set) Token: 0x06001135 RID: 4405 RVA: 0x0000896A File Offset: 0x00006B6A
	public unsafe AndroidABAddress address
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidContactInfo.NativeFieldInfoPtr_address);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidABAddress>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidContactInfo.NativeFieldInfoPtr_address), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700051B RID: 1307
	// (get) Token: 0x06001136 RID: 4406 RVA: 0x00053324 File Offset: 0x00051524
	// (set) Token: 0x06001137 RID: 4407 RVA: 0x00008989 File Offset: 0x00006B89
	public unsafe AndroidABOrganization organization
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidContactInfo.NativeFieldInfoPtr_organization);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidABOrganization>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidContactInfo.NativeFieldInfoPtr_organization), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700051C RID: 1308
	// (get) Token: 0x06001138 RID: 4408 RVA: 0x00053354 File Offset: 0x00051554
	// (set) Token: 0x06001139 RID: 4409 RVA: 0x000089A8 File Offset: 0x00006BA8
	public unsafe Texture2D photo
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidContactInfo.NativeFieldInfoPtr_photo);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidContactInfo.NativeFieldInfoPtr_photo), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000D5A RID: 3418
	private static readonly IntPtr NativeFieldInfoPtr_name;

	// Token: 0x04000D5B RID: 3419
	private static readonly IntPtr NativeFieldInfoPtr_phone;

	// Token: 0x04000D5C RID: 3420
	private static readonly IntPtr NativeFieldInfoPtr_note;

	// Token: 0x04000D5D RID: 3421
	private static readonly IntPtr NativeFieldInfoPtr_email;

	// Token: 0x04000D5E RID: 3422
	private static readonly IntPtr NativeFieldInfoPtr_chat;

	// Token: 0x04000D5F RID: 3423
	private static readonly IntPtr NativeFieldInfoPtr_address;

	// Token: 0x04000D60 RID: 3424
	private static readonly IntPtr NativeFieldInfoPtr_organization;

	// Token: 0x04000D61 RID: 3425
	private static readonly IntPtr NativeFieldInfoPtr_photo;

	// Token: 0x04000D62 RID: 3426
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
