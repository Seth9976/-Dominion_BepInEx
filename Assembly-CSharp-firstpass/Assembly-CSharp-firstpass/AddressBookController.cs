using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using SA.Common.Pattern;

// Token: 0x020000D6 RID: 214
public class AddressBookController : Singleton<AddressBookController>
{
	// Token: 0x06000F1F RID: 3871 RVA: 0x0004C184 File Offset: 0x0004A384
	// Note: this type is marked as 'beforefieldinit'.
	static AddressBookController()
	{
		Il2CppClassPointerStore<AddressBookController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AddressBookController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressBookController>.NativeClassPtr);
		AddressBookController.NativeFieldInfoPtr_OnContactsLoadedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressBookController>.NativeClassPtr, "OnContactsLoadedAction");
		AddressBookController.NativeFieldInfoPtr_DATA_SPLITTER_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressBookController>.NativeClassPtr, "DATA_SPLITTER_1");
		AddressBookController.NativeFieldInfoPtr_DATA_SPLITTER_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressBookController>.NativeClassPtr, "DATA_SPLITTER_2");
		AddressBookController.NativeFieldInfoPtr_byte_limit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressBookController>.NativeClassPtr, "byte_limit");
		AddressBookController.NativeFieldInfoPtr__isLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressBookController>.NativeClassPtr, "_isLoaded");
		AddressBookController.NativeFieldInfoPtr__contacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressBookController>.NativeClassPtr, "_contacts");
		AddressBookController.NativeMethodInfoPtr_add_OnContactsLoadedAction_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressBookController>.NativeClassPtr, 100665151);
		AddressBookController.NativeMethodInfoPtr_remove_OnContactsLoadedAction_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressBookController>.NativeClassPtr, 100665152);
		AddressBookController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressBookController>.NativeClassPtr, 100665153);
		AddressBookController.NativeMethodInfoPtr_LoadContacts_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressBookController>.NativeClassPtr, 100665154);
		AddressBookController.NativeMethodInfoPtr_get_contacts_Public_get_List_1_AndroidContactInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressBookController>.NativeClassPtr, 100665155);
		AddressBookController.NativeMethodInfoPtr_OnContactsLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressBookController>.NativeClassPtr, 100665156);
		AddressBookController.NativeMethodInfoPtr_parseContacts_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressBookController>.NativeClassPtr, 100665157);
		AddressBookController.NativeMethodInfoPtr_trimString_Private_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressBookController>.NativeClassPtr, 100665158);
		AddressBookController.NativeMethodInfoPtr_isValid_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressBookController>.NativeClassPtr, 100665159);
		AddressBookController.NativeMethodInfoPtr_havePhoto_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressBookController>.NativeClassPtr, 100665160);
		AddressBookController.NativeMethodInfoPtr_get_isLoaded_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressBookController>.NativeClassPtr, 100665161);
		AddressBookController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressBookController>.NativeClassPtr, 100665162);
	}

	// Token: 0x06000F20 RID: 3872 RVA: 0x0004C31C File Offset: 0x0004A51C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 179051, RefRangeEnd = 179054, XrefRangeStart = 179040, XrefRangeEnd = 179051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnContactsLoadedAction(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressBookController.NativeMethodInfoPtr_add_OnContactsLoadedAction_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F21 RID: 3873 RVA: 0x0004C354 File Offset: 0x0004A554
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 179065, RefRangeEnd = 179068, XrefRangeStart = 179054, XrefRangeEnd = 179065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnContactsLoadedAction(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressBookController.NativeMethodInfoPtr_remove_OnContactsLoadedAction_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F22 RID: 3874 RVA: 0x0004C38C File Offset: 0x0004A58C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179068, XrefRangeEnd = 179073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressBookController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F23 RID: 3875 RVA: 0x0004C3C0 File Offset: 0x0004A5C0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 179074, RefRangeEnd = 179075, XrefRangeStart = 179073, XrefRangeEnd = 179074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadContacts()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressBookController.NativeMethodInfoPtr_LoadContacts_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000484 RID: 1156
	// (get) Token: 0x06000F24 RID: 3876 RVA: 0x0004C3F4 File Offset: 0x0004A5F4
	public unsafe List<AndroidContactInfo> contacts
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressBookController.NativeMethodInfoPtr_get_contacts_Public_get_List_1_AndroidContactInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<AndroidContactInfo>>(intPtr3) : null;
		}
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x0004C434 File Offset: 0x0004A634
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179075, XrefRangeEnd = 179095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnContactsLoaded(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressBookController.NativeMethodInfoPtr_OnContactsLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F26 RID: 3878 RVA: 0x0004C478 File Offset: 0x0004A678
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 179211, RefRangeEnd = 179212, XrefRangeStart = 179095, XrefRangeEnd = 179211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void parseContacts(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressBookController.NativeMethodInfoPtr_parseContacts_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F27 RID: 3879 RVA: 0x0004C4BC File Offset: 0x0004A6BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179212, XrefRangeEnd = 179214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string trimString(string str, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressBookController.NativeMethodInfoPtr_trimString_Private_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000F28 RID: 3880 RVA: 0x0004C514 File Offset: 0x0004A714
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179214, XrefRangeEnd = 179218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isValid(string str)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressBookController.NativeMethodInfoPtr_isValid_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000F29 RID: 3881 RVA: 0x0004C564 File Offset: 0x0004A764
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179218, XrefRangeEnd = 179221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool havePhoto(string str)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressBookController.NativeMethodInfoPtr_havePhoto_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000485 RID: 1157
	// (get) Token: 0x06000F2A RID: 3882 RVA: 0x0004C5B4 File Offset: 0x0004A7B4
	public unsafe static bool isLoaded
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179221, XrefRangeEnd = 179225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressBookController.NativeMethodInfoPtr_get_isLoaded_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000F2B RID: 3883 RVA: 0x0004C5E4 File Offset: 0x0004A7E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179225, XrefRangeEnd = 179237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AddressBookController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressBookController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressBookController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F2C RID: 3884 RVA: 0x00007C4E File Offset: 0x00005E4E
	public AddressBookController(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700047E RID: 1150
	// (get) Token: 0x06000F2D RID: 3885 RVA: 0x0004C620 File Offset: 0x0004A820
	// (set) Token: 0x06000F2E RID: 3886 RVA: 0x00007C57 File Offset: 0x00005E57
	public unsafe static Action OnContactsLoadedAction
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AddressBookController.NativeFieldInfoPtr_OnContactsLoadedAction, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AddressBookController.NativeFieldInfoPtr_OnContactsLoadedAction, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700047F RID: 1151
	// (get) Token: 0x06000F2F RID: 3887 RVA: 0x0004C648 File Offset: 0x0004A848
	// (set) Token: 0x06000F30 RID: 3888 RVA: 0x00007C69 File Offset: 0x00005E69
	public unsafe static string DATA_SPLITTER_1
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AddressBookController.NativeFieldInfoPtr_DATA_SPLITTER_1, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AddressBookController.NativeFieldInfoPtr_DATA_SPLITTER_1, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000480 RID: 1152
	// (get) Token: 0x06000F31 RID: 3889 RVA: 0x0004C668 File Offset: 0x0004A868
	// (set) Token: 0x06000F32 RID: 3890 RVA: 0x00007C7B File Offset: 0x00005E7B
	public unsafe static string DATA_SPLITTER_2
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AddressBookController.NativeFieldInfoPtr_DATA_SPLITTER_2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AddressBookController.NativeFieldInfoPtr_DATA_SPLITTER_2, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000481 RID: 1153
	// (get) Token: 0x06000F33 RID: 3891 RVA: 0x0004C688 File Offset: 0x0004A888
	// (set) Token: 0x06000F34 RID: 3892 RVA: 0x00007C8D File Offset: 0x00005E8D
	public unsafe static int byte_limit
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AddressBookController.NativeFieldInfoPtr_byte_limit, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AddressBookController.NativeFieldInfoPtr_byte_limit, (void*)(&value));
		}
	}

	// Token: 0x17000482 RID: 1154
	// (get) Token: 0x06000F35 RID: 3893 RVA: 0x0004C6A4 File Offset: 0x0004A8A4
	// (set) Token: 0x06000F36 RID: 3894 RVA: 0x00007C9B File Offset: 0x00005E9B
	public unsafe static bool _isLoaded
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(AddressBookController.NativeFieldInfoPtr__isLoaded, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AddressBookController.NativeFieldInfoPtr__isLoaded, (void*)(&value));
		}
	}

	// Token: 0x17000483 RID: 1155
	// (get) Token: 0x06000F37 RID: 3895 RVA: 0x0004C6C0 File Offset: 0x0004A8C0
	// (set) Token: 0x06000F38 RID: 3896 RVA: 0x00007CA9 File Offset: 0x00005EA9
	public unsafe List<AndroidContactInfo> _contacts
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressBookController.NativeFieldInfoPtr__contacts);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AndroidContactInfo>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddressBookController.NativeFieldInfoPtr__contacts), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000BFA RID: 3066
	private static readonly IntPtr NativeFieldInfoPtr_OnContactsLoadedAction;

	// Token: 0x04000BFB RID: 3067
	private static readonly IntPtr NativeFieldInfoPtr_DATA_SPLITTER_1;

	// Token: 0x04000BFC RID: 3068
	private static readonly IntPtr NativeFieldInfoPtr_DATA_SPLITTER_2;

	// Token: 0x04000BFD RID: 3069
	private static readonly IntPtr NativeFieldInfoPtr_byte_limit;

	// Token: 0x04000BFE RID: 3070
	private static readonly IntPtr NativeFieldInfoPtr__isLoaded;

	// Token: 0x04000BFF RID: 3071
	private static readonly IntPtr NativeFieldInfoPtr__contacts;

	// Token: 0x04000C00 RID: 3072
	private static readonly IntPtr NativeMethodInfoPtr_add_OnContactsLoadedAction_Public_Static_add_Void_Action_0;

	// Token: 0x04000C01 RID: 3073
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnContactsLoadedAction_Public_Static_rem_Void_Action_0;

	// Token: 0x04000C02 RID: 3074
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000C03 RID: 3075
	private static readonly IntPtr NativeMethodInfoPtr_LoadContacts_Public_Void_0;

	// Token: 0x04000C04 RID: 3076
	private static readonly IntPtr NativeMethodInfoPtr_get_contacts_Public_get_List_1_AndroidContactInfo_0;

	// Token: 0x04000C05 RID: 3077
	private static readonly IntPtr NativeMethodInfoPtr_OnContactsLoaded_Private_Void_String_0;

	// Token: 0x04000C06 RID: 3078
	private static readonly IntPtr NativeMethodInfoPtr_parseContacts_Private_Void_String_0;

	// Token: 0x04000C07 RID: 3079
	private static readonly IntPtr NativeMethodInfoPtr_trimString_Private_String_String_Int32_0;

	// Token: 0x04000C08 RID: 3080
	private static readonly IntPtr NativeMethodInfoPtr_isValid_Private_Boolean_String_0;

	// Token: 0x04000C09 RID: 3081
	private static readonly IntPtr NativeMethodInfoPtr_havePhoto_Private_Boolean_String_0;

	// Token: 0x04000C0A RID: 3082
	private static readonly IntPtr NativeMethodInfoPtr_get_isLoaded_Public_Static_get_Boolean_0;

	// Token: 0x04000C0B RID: 3083
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200038C RID: 908
	[ObfuscatedName("AddressBookController+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x06003608 RID: 13832 RVA: 0x000DE244 File Offset: 0x000DC444
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<AddressBookController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressBookController>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressBookController.__c>.NativeClassPtr);
			AddressBookController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressBookController.__c>.NativeClassPtr, "<>9");
			AddressBookController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressBookController.__c>.NativeClassPtr, 100670179);
			AddressBookController.__c.NativeMethodInfoPtr___cctor_b__20_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressBookController.__c>.NativeClassPtr, 100670180);
		}

		// Token: 0x06003609 RID: 13833 RVA: 0x000DE2AC File Offset: 0x000DC4AC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressBookController.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressBookController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600360A RID: 13834 RVA: 0x000DE2E8 File Offset: 0x000DC4E8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__20_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressBookController.__c.NativeMethodInfoPtr___cctor_b__20_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600360B RID: 13835 RVA: 0x00014F07 File Offset: 0x00013107
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x0600360C RID: 13836 RVA: 0x000DE31C File Offset: 0x000DC51C
		// (set) Token: 0x0600360D RID: 13837 RVA: 0x00014F10 File Offset: 0x00013110
		public unsafe static AddressBookController.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddressBookController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressBookController.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddressBookController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400318D RID: 12685
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x0400318E RID: 12686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400318F RID: 12687
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__20_0_Internal_Void_0;
	}
}
