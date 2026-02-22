using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Common.Pattern;

// Token: 0x020000DE RID: 222
public class TVAppController : Singleton<TVAppController>
{
	// Token: 0x06000FF2 RID: 4082 RVA: 0x0004F6B0 File Offset: 0x0004D8B0
	// Note: this type is marked as 'beforefieldinit'.
	static TVAppController()
	{
		Il2CppClassPointerStore<TVAppController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TVAppController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVAppController>.NativeClassPtr);
		TVAppController.NativeFieldInfoPtr__IsRuningOnTVDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVAppController>.NativeClassPtr, "_IsRuningOnTVDevice");
		TVAppController.NativeFieldInfoPtr_DeviceTypeChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVAppController>.NativeClassPtr, "DeviceTypeChecked");
		TVAppController.NativeMethodInfoPtr_add_DeviceTypeChecked_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVAppController>.NativeClassPtr, 100665288);
		TVAppController.NativeMethodInfoPtr_remove_DeviceTypeChecked_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVAppController>.NativeClassPtr, 100665289);
		TVAppController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVAppController>.NativeClassPtr, 100665290);
		TVAppController.NativeMethodInfoPtr_CheckForATVDevice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVAppController>.NativeClassPtr, 100665291);
		TVAppController.NativeMethodInfoPtr_OnDeviceStateResponce_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVAppController>.NativeClassPtr, 100665292);
		TVAppController.NativeMethodInfoPtr_get_IsRuningOnTVDevice_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVAppController>.NativeClassPtr, 100665293);
		TVAppController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVAppController>.NativeClassPtr, 100665294);
	}

	// Token: 0x06000FF3 RID: 4083 RVA: 0x0004F794 File Offset: 0x0004D994
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 181045, RefRangeEnd = 181047, XrefRangeStart = 181034, XrefRangeEnd = 181045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_DeviceTypeChecked(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVAppController.NativeMethodInfoPtr_add_DeviceTypeChecked_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000FF4 RID: 4084 RVA: 0x0004F7CC File Offset: 0x0004D9CC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 181058, RefRangeEnd = 181060, XrefRangeStart = 181047, XrefRangeEnd = 181058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_DeviceTypeChecked(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVAppController.NativeMethodInfoPtr_remove_DeviceTypeChecked_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000FF5 RID: 4085 RVA: 0x0004F804 File Offset: 0x0004DA04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181060, XrefRangeEnd = 181065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVAppController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FF6 RID: 4086 RVA: 0x0004F838 File Offset: 0x0004DA38
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 181066, RefRangeEnd = 181068, XrefRangeStart = 181065, XrefRangeEnd = 181066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckForATVDevice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVAppController.NativeMethodInfoPtr_CheckForATVDevice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FF7 RID: 4087 RVA: 0x0004F86C File Offset: 0x0004DA6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181068, XrefRangeEnd = 181089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDeviceStateResponce(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVAppController.NativeMethodInfoPtr_OnDeviceStateResponce_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x170004A3 RID: 1187
	// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x0004F8B0 File Offset: 0x0004DAB0
	public unsafe bool IsRuningOnTVDevice
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVAppController.NativeMethodInfoPtr_get_IsRuningOnTVDevice_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000FF9 RID: 4089 RVA: 0x0004F8EC File Offset: 0x0004DAEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181089, XrefRangeEnd = 181095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TVAppController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVAppController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVAppController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FFA RID: 4090 RVA: 0x00007F56 File Offset: 0x00006156
	public TVAppController(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004A1 RID: 1185
	// (get) Token: 0x06000FFB RID: 4091 RVA: 0x0004F928 File Offset: 0x0004DB28
	// (set) Token: 0x06000FFC RID: 4092 RVA: 0x00007F5F File Offset: 0x0000615F
	public unsafe bool _IsRuningOnTVDevice
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVAppController.NativeFieldInfoPtr__IsRuningOnTVDevice);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVAppController.NativeFieldInfoPtr__IsRuningOnTVDevice)) = value;
		}
	}

	// Token: 0x170004A2 RID: 1186
	// (get) Token: 0x06000FFD RID: 4093 RVA: 0x0004F950 File Offset: 0x0004DB50
	// (set) Token: 0x06000FFE RID: 4094 RVA: 0x00007F7A File Offset: 0x0000617A
	public unsafe static Action DeviceTypeChecked
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(TVAppController.NativeFieldInfoPtr_DeviceTypeChecked, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TVAppController.NativeFieldInfoPtr_DeviceTypeChecked, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000CA0 RID: 3232
	private static readonly IntPtr NativeFieldInfoPtr__IsRuningOnTVDevice;

	// Token: 0x04000CA1 RID: 3233
	private static readonly IntPtr NativeFieldInfoPtr_DeviceTypeChecked;

	// Token: 0x04000CA2 RID: 3234
	private static readonly IntPtr NativeMethodInfoPtr_add_DeviceTypeChecked_Public_Static_add_Void_Action_0;

	// Token: 0x04000CA3 RID: 3235
	private static readonly IntPtr NativeMethodInfoPtr_remove_DeviceTypeChecked_Public_Static_rem_Void_Action_0;

	// Token: 0x04000CA4 RID: 3236
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000CA5 RID: 3237
	private static readonly IntPtr NativeMethodInfoPtr_CheckForATVDevice_Public_Void_0;

	// Token: 0x04000CA6 RID: 3238
	private static readonly IntPtr NativeMethodInfoPtr_OnDeviceStateResponce_Private_Void_String_0;

	// Token: 0x04000CA7 RID: 3239
	private static readonly IntPtr NativeMethodInfoPtr_get_IsRuningOnTVDevice_Public_get_Boolean_0;

	// Token: 0x04000CA8 RID: 3240
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000395 RID: 917
	[ObfuscatedName("TVAppController+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x0600367A RID: 13946 RVA: 0x000DF80C File Offset: 0x000DDA0C
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<TVAppController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TVAppController>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVAppController.__c>.NativeClassPtr);
			TVAppController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVAppController.__c>.NativeClassPtr, "<>9");
			TVAppController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVAppController.__c>.NativeClassPtr, 100670227);
			TVAppController.__c.NativeMethodInfoPtr___cctor_b__10_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVAppController.__c>.NativeClassPtr, 100670228);
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x000DF874 File Offset: 0x000DDA74
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVAppController.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVAppController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x000DF8B0 File Offset: 0x000DDAB0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__10_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVAppController.__c.NativeMethodInfoPtr___cctor_b__10_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x0001520F File Offset: 0x0001340F
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x0600367E RID: 13950 RVA: 0x000DF8E4 File Offset: 0x000DDAE4
		// (set) Token: 0x0600367F RID: 13951 RVA: 0x00015218 File Offset: 0x00013418
		public unsafe static TVAppController.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TVAppController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVAppController.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TVAppController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031D2 RID: 12754
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040031D3 RID: 12755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040031D4 RID: 12756
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__10_0_Internal_Void_0;
	}
}
