using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x020000E7 RID: 231
public class LocalNotificationTemplate : Object
{
	// Token: 0x06001098 RID: 4248 RVA: 0x000515EC File Offset: 0x0004F7EC
	// Note: this type is marked as 'beforefieldinit'.
	static LocalNotificationTemplate()
	{
		Il2CppClassPointerStore<LocalNotificationTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LocalNotificationTemplate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalNotificationTemplate>.NativeClassPtr);
		LocalNotificationTemplate.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalNotificationTemplate>.NativeClassPtr, "_id");
		LocalNotificationTemplate.NativeFieldInfoPtr__title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalNotificationTemplate>.NativeClassPtr, "_title");
		LocalNotificationTemplate.NativeFieldInfoPtr__message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalNotificationTemplate>.NativeClassPtr, "_message");
		LocalNotificationTemplate.NativeFieldInfoPtr__fireDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalNotificationTemplate>.NativeClassPtr, "_fireDate");
		LocalNotificationTemplate.NativeFieldInfoPtr_DATA_SPLITTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalNotificationTemplate>.NativeClassPtr, "DATA_SPLITTER");
		LocalNotificationTemplate.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalNotificationTemplate>.NativeClassPtr, 100665350);
		LocalNotificationTemplate.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalNotificationTemplate>.NativeClassPtr, 100665351);
		LocalNotificationTemplate.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalNotificationTemplate>.NativeClassPtr, 100665352);
		LocalNotificationTemplate.NativeMethodInfoPtr_get_title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalNotificationTemplate>.NativeClassPtr, 100665353);
		LocalNotificationTemplate.NativeMethodInfoPtr_get_message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalNotificationTemplate>.NativeClassPtr, 100665354);
		LocalNotificationTemplate.NativeMethodInfoPtr_get_fireDate_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalNotificationTemplate>.NativeClassPtr, 100665355);
		LocalNotificationTemplate.NativeMethodInfoPtr_get_SerializedString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalNotificationTemplate>.NativeClassPtr, 100665356);
		LocalNotificationTemplate.NativeMethodInfoPtr_get_IsFired_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalNotificationTemplate>.NativeClassPtr, 100665357);
	}

	// Token: 0x06001099 RID: 4249 RVA: 0x00051720 File Offset: 0x0004F920
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181337, XrefRangeEnd = 181352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LocalNotificationTemplate(string data)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalNotificationTemplate>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalNotificationTemplate.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600109A RID: 4250 RVA: 0x0005176C File Offset: 0x0004F96C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 181353, RefRangeEnd = 181356, XrefRangeStart = 181352, XrefRangeEnd = 181353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LocalNotificationTemplate(int nId, string ttl, string msg, DateTime date)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalNotificationTemplate>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref nId;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ttl);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref date;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalNotificationTemplate.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170004E2 RID: 1250
	// (get) Token: 0x0600109B RID: 4251 RVA: 0x000517E8 File Offset: 0x0004F9E8
	public unsafe int id
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalNotificationTemplate.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170004E3 RID: 1251
	// (get) Token: 0x0600109C RID: 4252 RVA: 0x00051824 File Offset: 0x0004FA24
	public unsafe string title
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalNotificationTemplate.NativeMethodInfoPtr_get_title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170004E4 RID: 1252
	// (get) Token: 0x0600109D RID: 4253 RVA: 0x0005185C File Offset: 0x0004FA5C
	public unsafe string message
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalNotificationTemplate.NativeMethodInfoPtr_get_message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170004E5 RID: 1253
	// (get) Token: 0x0600109E RID: 4254 RVA: 0x00051894 File Offset: 0x0004FA94
	public unsafe DateTime fireDate
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalNotificationTemplate.NativeMethodInfoPtr_get_fireDate_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170004E6 RID: 1254
	// (get) Token: 0x0600109F RID: 4255 RVA: 0x000518D0 File Offset: 0x0004FAD0
	public unsafe string SerializedString
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 181382, RefRangeEnd = 181383, XrefRangeStart = 181356, XrefRangeEnd = 181382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalNotificationTemplate.NativeMethodInfoPtr_get_SerializedString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170004E7 RID: 1255
	// (get) Token: 0x060010A0 RID: 4256 RVA: 0x00051908 File Offset: 0x0004FB08
	public unsafe bool IsFired
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181383, XrefRangeEnd = 181389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalNotificationTemplate.NativeMethodInfoPtr_get_IsFired_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060010A1 RID: 4257 RVA: 0x0000843D File Offset: 0x0000663D
	public LocalNotificationTemplate(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004DD RID: 1245
	// (get) Token: 0x060010A2 RID: 4258 RVA: 0x00051944 File Offset: 0x0004FB44
	// (set) Token: 0x060010A3 RID: 4259 RVA: 0x00008446 File Offset: 0x00006646
	public unsafe int _id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalNotificationTemplate.NativeFieldInfoPtr__id);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalNotificationTemplate.NativeFieldInfoPtr__id)) = value;
		}
	}

	// Token: 0x170004DE RID: 1246
	// (get) Token: 0x060010A4 RID: 4260 RVA: 0x0005196C File Offset: 0x0004FB6C
	// (set) Token: 0x060010A5 RID: 4261 RVA: 0x00008461 File Offset: 0x00006661
	public unsafe string _title
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalNotificationTemplate.NativeFieldInfoPtr__title);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalNotificationTemplate.NativeFieldInfoPtr__title), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004DF RID: 1247
	// (get) Token: 0x060010A6 RID: 4262 RVA: 0x00051994 File Offset: 0x0004FB94
	// (set) Token: 0x060010A7 RID: 4263 RVA: 0x00008480 File Offset: 0x00006680
	public unsafe string _message
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalNotificationTemplate.NativeFieldInfoPtr__message);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalNotificationTemplate.NativeFieldInfoPtr__message), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004E0 RID: 1248
	// (get) Token: 0x060010A8 RID: 4264 RVA: 0x000519BC File Offset: 0x0004FBBC
	// (set) Token: 0x060010A9 RID: 4265 RVA: 0x0000849F File Offset: 0x0000669F
	public unsafe DateTime _fireDate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalNotificationTemplate.NativeFieldInfoPtr__fireDate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalNotificationTemplate.NativeFieldInfoPtr__fireDate)) = value;
		}
	}

	// Token: 0x170004E1 RID: 1249
	// (get) Token: 0x060010AA RID: 4266 RVA: 0x000519E4 File Offset: 0x0004FBE4
	// (set) Token: 0x060010AB RID: 4267 RVA: 0x000084BA File Offset: 0x000066BA
	public unsafe static string DATA_SPLITTER
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LocalNotificationTemplate.NativeFieldInfoPtr_DATA_SPLITTER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LocalNotificationTemplate.NativeFieldInfoPtr_DATA_SPLITTER, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000D08 RID: 3336
	private static readonly IntPtr NativeFieldInfoPtr__id;

	// Token: 0x04000D09 RID: 3337
	private static readonly IntPtr NativeFieldInfoPtr__title;

	// Token: 0x04000D0A RID: 3338
	private static readonly IntPtr NativeFieldInfoPtr__message;

	// Token: 0x04000D0B RID: 3339
	private static readonly IntPtr NativeFieldInfoPtr__fireDate;

	// Token: 0x04000D0C RID: 3340
	private static readonly IntPtr NativeFieldInfoPtr_DATA_SPLITTER;

	// Token: 0x04000D0D RID: 3341
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x04000D0E RID: 3342
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_DateTime_0;

	// Token: 0x04000D0F RID: 3343
	private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

	// Token: 0x04000D10 RID: 3344
	private static readonly IntPtr NativeMethodInfoPtr_get_title_Public_get_String_0;

	// Token: 0x04000D11 RID: 3345
	private static readonly IntPtr NativeMethodInfoPtr_get_message_Public_get_String_0;

	// Token: 0x04000D12 RID: 3346
	private static readonly IntPtr NativeMethodInfoPtr_get_fireDate_Public_get_DateTime_0;

	// Token: 0x04000D13 RID: 3347
	private static readonly IntPtr NativeMethodInfoPtr_get_SerializedString_Public_get_String_0;

	// Token: 0x04000D14 RID: 3348
	private static readonly IntPtr NativeMethodInfoPtr_get_IsFired_Public_get_Boolean_0;
}
