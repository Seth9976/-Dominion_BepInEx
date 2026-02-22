using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x0200011B RID: 283
public class AddressBookExample : MonoBehaviour
{
	// Token: 0x06001383 RID: 4995 RVA: 0x0005A4F8 File Offset: 0x000586F8
	// Note: this type is marked as 'beforefieldinit'.
	static AddressBookExample()
	{
		Il2CppClassPointerStore<AddressBookExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AddressBookExample");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressBookExample>.NativeClassPtr);
		AddressBookExample.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressBookExample>.NativeClassPtr, "_name");
		AddressBookExample.NativeFieldInfoPtr__phone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressBookExample>.NativeClassPtr, "_phone");
		AddressBookExample.NativeFieldInfoPtr__note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressBookExample>.NativeClassPtr, "_note");
		AddressBookExample.NativeFieldInfoPtr__email = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressBookExample>.NativeClassPtr, "_email");
		AddressBookExample.NativeFieldInfoPtr__chat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressBookExample>.NativeClassPtr, "_chat");
		AddressBookExample.NativeFieldInfoPtr__address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressBookExample>.NativeClassPtr, "_address");
		AddressBookExample.NativeFieldInfoPtr_all_contacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressBookExample>.NativeClassPtr, "all_contacts");
		AddressBookExample.NativeMethodInfoPtr_LoadAdressBook_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressBookExample>.NativeClassPtr, 100665638);
		AddressBookExample.NativeMethodInfoPtr_OnContactsLoaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressBookExample>.NativeClassPtr, 100665639);
		AddressBookExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressBookExample>.NativeClassPtr, 100665640);
	}

	// Token: 0x06001384 RID: 4996 RVA: 0x0005A5F0 File Offset: 0x000587F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184610, XrefRangeEnd = 184628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadAdressBook()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressBookExample.NativeMethodInfoPtr_LoadAdressBook_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001385 RID: 4997 RVA: 0x0005A624 File Offset: 0x00058824
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184628, XrefRangeEnd = 184696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnContactsLoaded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressBookExample.NativeMethodInfoPtr_OnContactsLoaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001386 RID: 4998 RVA: 0x0005A658 File Offset: 0x00058858
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184696, XrefRangeEnd = 184703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AddressBookExample()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressBookExample>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressBookExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001387 RID: 4999 RVA: 0x00009AB2 File Offset: 0x00007CB2
	public AddressBookExample(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005B9 RID: 1465
	// (get) Token: 0x06001388 RID: 5000 RVA: 0x0005A694 File Offset: 0x00058894
	// (set) Token: 0x06001389 RID: 5001 RVA: 0x00009ABB File Offset: 0x00007CBB
	public unsafe SA_Label _name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressBookExample.NativeFieldInfoPtr__name);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressBookExample.NativeFieldInfoPtr__name), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005BA RID: 1466
	// (get) Token: 0x0600138A RID: 5002 RVA: 0x0005A6C4 File Offset: 0x000588C4
	// (set) Token: 0x0600138B RID: 5003 RVA: 0x00009ADA File Offset: 0x00007CDA
	public unsafe SA_Label _phone
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressBookExample.NativeFieldInfoPtr__phone);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressBookExample.NativeFieldInfoPtr__phone), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005BB RID: 1467
	// (get) Token: 0x0600138C RID: 5004 RVA: 0x0005A6F4 File Offset: 0x000588F4
	// (set) Token: 0x0600138D RID: 5005 RVA: 0x00009AF9 File Offset: 0x00007CF9
	public unsafe SA_Label _note
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressBookExample.NativeFieldInfoPtr__note);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressBookExample.NativeFieldInfoPtr__note), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005BC RID: 1468
	// (get) Token: 0x0600138E RID: 5006 RVA: 0x0005A724 File Offset: 0x00058924
	// (set) Token: 0x0600138F RID: 5007 RVA: 0x00009B18 File Offset: 0x00007D18
	public unsafe SA_Label _email
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressBookExample.NativeFieldInfoPtr__email);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressBookExample.NativeFieldInfoPtr__email), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005BD RID: 1469
	// (get) Token: 0x06001390 RID: 5008 RVA: 0x0005A754 File Offset: 0x00058954
	// (set) Token: 0x06001391 RID: 5009 RVA: 0x00009B37 File Offset: 0x00007D37
	public unsafe SA_Label _chat
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressBookExample.NativeFieldInfoPtr__chat);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressBookExample.NativeFieldInfoPtr__chat), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005BE RID: 1470
	// (get) Token: 0x06001392 RID: 5010 RVA: 0x0005A784 File Offset: 0x00058984
	// (set) Token: 0x06001393 RID: 5011 RVA: 0x00009B56 File Offset: 0x00007D56
	public unsafe SA_Label _address
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressBookExample.NativeFieldInfoPtr__address);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressBookExample.NativeFieldInfoPtr__address), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005BF RID: 1471
	// (get) Token: 0x06001394 RID: 5012 RVA: 0x0005A7B4 File Offset: 0x000589B4
	// (set) Token: 0x06001395 RID: 5013 RVA: 0x00009B75 File Offset: 0x00007D75
	public unsafe List<AndroidContactInfo> all_contacts
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressBookExample.NativeFieldInfoPtr_all_contacts);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AndroidContactInfo>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressBookExample.NativeFieldInfoPtr_all_contacts), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000EE2 RID: 3810
	private static readonly IntPtr NativeFieldInfoPtr__name;

	// Token: 0x04000EE3 RID: 3811
	private static readonly IntPtr NativeFieldInfoPtr__phone;

	// Token: 0x04000EE4 RID: 3812
	private static readonly IntPtr NativeFieldInfoPtr__note;

	// Token: 0x04000EE5 RID: 3813
	private static readonly IntPtr NativeFieldInfoPtr__email;

	// Token: 0x04000EE6 RID: 3814
	private static readonly IntPtr NativeFieldInfoPtr__chat;

	// Token: 0x04000EE7 RID: 3815
	private static readonly IntPtr NativeFieldInfoPtr__address;

	// Token: 0x04000EE8 RID: 3816
	private static readonly IntPtr NativeFieldInfoPtr_all_contacts;

	// Token: 0x04000EE9 RID: 3817
	private static readonly IntPtr NativeMethodInfoPtr_LoadAdressBook_Private_Void_0;

	// Token: 0x04000EEA RID: 3818
	private static readonly IntPtr NativeMethodInfoPtr_OnContactsLoaded_Private_Void_0;

	// Token: 0x04000EEB RID: 3819
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
